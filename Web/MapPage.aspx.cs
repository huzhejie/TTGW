using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Configuration;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.ADF.Web;
using ESRI.ArcGIS.ADF.Web.UI.WebControls;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Designers;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Editors;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Editors.Resources.LayerDefinitions;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Exceptions;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.RenderingEngine;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Tools;
using ESRI.ArcGIS.ADF.Web.DataSources;
using ESRI.ArcGIS.ADF.Web.Display.Graphics;
//using ESRI.ArcGIS.ADF.Web.Display.Symbol;
using ESRI.ArcGIS.ADF.ArcGISServer;
using ESRI.ArcGIS.ADF.Web.Geometry;
using ESRI.ArcGIS.ADF.Web.DataSources.Graphics;
using TTG.DAL.GET;
using System.Text;


namespace TTG.Web
{

    public partial class MapPage : System.Web.UI.Page, ICallbackEventHandler, IMapServerToolAction
    {
        //选择的项目
        //private readonly string[] Layers=new string[]{"hospital_point","school_point","小区_text_1_adjust"};

        private readonly string[] Layers = new string[] { "HospitalName_point", "EduName_point", "CommunityName_point" };
        //自定义详细内容
        private readonly string[] infos = new string[]{
        "养鹿镇位于云阳县西北边陲，地处云阳、开县的交界处，距云阳新县城52公里、云开高速路民国场出口20公里、赵家出口17公里，长江一级支流澎溪河横贯全镇19km。是云阳县三峡库区三、四期农村移民重点乡镇。",
        "寂静集镇属于奉节县康乐镇，位于奉节县北部的腹心地带，东临汾河镇，南至白帝镇，西接朱衣镇，北靠石岗乡。小区位于长江以北梅溪河流域，属康乐镇管辖，住宅区。",
        "盘石集镇与云阳新县城一桥之隔，东接凤鸣镇，南靠万州区白羊镇，西与万州区黄柏乡接壤，是全县四大古镇之一、长江三峡文明长廊建设示范点、三峡工程生态屏障区试点示范项目建设镇。",
        "渠马镇位于云阳县城西北部，澎溪河中游。东接高阳镇，南与养鹿镇接壤，西与双龙镇、开县临界。云开路纵贯南北。距离新县城60km。",
        "云阳县江口盛堡集镇地处云、开、巫三县交界处，距新县城60公里。",
        "南溪镇位于云阳县新县城东北部，东迄云阳县双土镇，西连高阳镇南接云安镇，北靠富家乡，距新县城42公里。"
    };
        //回调的字符串
        public string CallBackString;
        //选择图层的回调字符串
        public string m_SelectLayerCallback;
        //关于自定义弹窗的回调字符串
        public string m_CalloutCallback;
        //关于选择单项的回调字符串
        public string m_SelectItemCallback;
        //关于搜索的回调字符串
        public string m_SearchCallback;
        //缓冲区分析的回调字符串
        public string m_BufferCallback;
        //清除缓冲区分析图形的回调字符串
        public string m_ClearBufferCallback;
        //显示项目图层
        public string m_ShowProjectCallback;

        public int mapNum;

        public string com_name;

        public string com_county;

        public string com_province;

        public int positionX;
        public int positionY;


        protected void Page_Load(object sender, EventArgs e)
        {
            com_name = "";
            com_county = "";
            com_province = "";

            if (Request.QueryString.Count > 0)
            {
                com_name = Request["commuity"].ToString();
                com_county = Request["counity"].ToString();
                com_province = Request["province"].ToString();
            }
            if (this.MapResourceManager1.ResourceItems.Find("MapResourceItem0").Definition.ResourceDefinition == "图层@开县Map")
            {
                mapNum = 0;
            }
            else
            {
                mapNum = 1;
            }

            m_SelectLayerCallback =
                Page.ClientScript.GetCallbackEventReference(this, "message", "ProcessSelectLayer", "context", "postBackError", true);

            m_CalloutCallback =     //注意到这里规定了回调处理的前台函数
                Page.ClientScript.GetCallbackEventReference(this, "message", "ProcessCallout", "context", "postBackError", true);

            m_SelectItemCallback =
                Page.ClientScript.GetCallbackEventReference(this, "message", "processCallbackResult", "context", "postBackError", true);

            m_SearchCallback =
                Page.ClientScript.GetCallbackEventReference(this, "message", "processSearch", "context", "postBackError", true);

            m_BufferCallback =
                Page.ClientScript.GetCallbackEventReference(this, "message", "processCallbackResult", "context", "postBackError", true);

            m_ClearBufferCallback = m_BufferCallback;
            m_ShowProjectCallback = m_BufferCallback;

            Clear();

            if (!Page.IsPostBack)
            {

                if (com_name != "" && com_county != "")
                {
                    changeMap(com_county);
                    DropDownList1.Items.FindByText(com_county).Selected = true;

                    ClientScript.RegisterStartupScript(ClientScript.GetType(), "SelectOneItem", "<script>SelectOneItem('" + com_name + "',2);</script>");
                    ClientScript.RegisterStartupScript(ClientScript.GetType(), "searchCom", "<script>searchCom('" + com_name + "');</script>");
                }
                return;
            }
            // Clear();
        }

        string ICallbackEventHandler.GetCallbackResult()
        {
            return CallBackString;
        }

        void ICallbackEventHandler.RaiseCallbackEvent(string eventArgument)
        {
            //切割参数
            string[] args = eventArgument.Split(':');
            System.Data.DataTable table = null;
            string whereClause = "";

            switch (args[0])
            {
                //显示项目图层
                case "ShowProject":
                    ///====================将项目服务创建缓存之后使用的代码==========================///
                    //MapResourceItem project=Map1.MapResourceManagerInstance.ResourceItems[1];
                    //project.DisplaySettings.Visible = !project.DisplaySettings.Visible;
                    //if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.WebTier)
                    //{
                    //    Map1.Refresh();
                    //}
                    //else {
                    //    Map1.RefreshResource(Map1.MapResourceManagerInstance.ResourceItems[1].Name);
                    //}
                    //CallBackString = Map1.CallbackResults.ToString();
                    ///====================将项目服务创建缓存之后使用的代码 END==========================///
                    MapResourceItem project = Map1.MapResourceManagerInstance.ResourceItems[1];
                    project.DisplaySettings.Visible = true;
                    IEnumerable funcs = Map1.GetFunctionalities();
                    foreach (ESRI.ArcGIS.ADF.Web.DataSources.IMapFunctionality mFunc in funcs)
                    {
                        if (mFunc.Resource.Name == "project")
                        {
                            string[] IDs;
                            string[] Names;
                            mFunc.GetLayers(out IDs, out Names);
                            int index = int.Parse(args[1]);

                            if (index >= IDs.Length)
                                break;
                            mFunc.SetLayerVisibility(IDs[index], true);
                            if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.WebTier)
                            {
                                Map1.Refresh();
                            }
                            else
                            {
                                Map1.RefreshResource("project");
                            }
                            CallBackString = Map1.CallbackResults.ToString();
                            break;
                        }
                    }
                    break;
                //选择医院、小区、学校之类的东西
                case "SelectLayer":
                    SelectLayer(args);
                    break;
                //选择某一个单项
                case "SelectItem":
                    SelectItem(args);
                    break;
                //通过输入框进行搜索
                case "Search":
                    SearchByInput(args);
                    break;
                case "Callout":
                    //通过参数获得xy坐标
                    string[] xy = args[1].Split('&');
                    int x = int.Parse(xy[0]);
                    int y = int.Parse(xy[1]);
                    //根据坐标点创建地图上的point
                    ESRI.ArcGIS.ADF.Web.Geometry.Point point =
                        ESRI.ArcGIS.ADF.Web.Geometry.Point.ToMapPoint(x, y, Map1.GetTransformationParams(ESRI.ArcGIS.ADF.Web.Geometry.TransformationDirection.ToMap));
                    //创建一个一定点为中心的矩形
                    ESRI.ArcGIS.ADF.Web.Geometry.Envelope env =
                        new ESRI.ArcGIS.ADF.Web.Geometry.Envelope(point.X - 30, point.Y - 30, point.X + 30, point.Y + 30);
                    //根据刚刚创建的矩形创建一个圆形
                    ESRI.ArcGIS.ADF.Web.Geometry.Ring ring = new ESRI.ArcGIS.ADF.Web.Geometry.Ring(env);
                    //根据上面的圆形创建一个几何图形用于查询
                    ESRI.ArcGIS.ADF.Web.Geometry.Polygon polygon = new ESRI.ArcGIS.ADF.Web.Geometry.Polygon();
                    polygon.Rings.Add(ring);
                    //对针对的几个图形进行遍历查询
                    int j;
                    for (j = 0; j < Layers.Length; j++)
                    {
                        table = UtilMap.QueryByGeometry(polygon, Map1, Layers[j]);
                        if (table.Rows.Count != 0)
                            break;
                    }
                    //对结果进行判断
                    if (table.Rows.Count == 0)
                    {
                        CallBackString = " ";
                        break;
                    }
                    //确定哪个字段是几何图形
                    int geomID = 0;
                    for (; geomID < table.Columns.Count; geomID++)
                    {
                        if (table.Columns[geomID].DataType == typeof(ESRI.ArcGIS.ADF.Web.Geometry.Geometry))
                            break;
                    }

                    ESRI.ArcGIS.ADF.Web.Geometry.Point geoPoint = table.Rows[0][geomID] as ESRI.ArcGIS.ADF.Web.Geometry.Point;

                    SortedList data = new SortedList();
                    data.Add("UrlDetail", "Detail.aspx");
                    //详细信息的跳转页面
                    //获取当前对象的集合对象，主要用于后面可能会使用到的缓冲区分析
                    data.Add("x", geoPoint.X);
                    data.Add("y", geoPoint.Y);
                    string name;
                    if (j == 2)
                    {
                        name = Convert.ToString(table.Rows[0]["xiaoquName"]);
                        data.Add("ShowBuffer", "none");
                    }
                    else
                    {
                        name = Convert.ToString(table.Rows[0]["TEXTSTRING"]);
                        data.Add("ShowBuffer", "block");
                    }


                    Random randow = new Random();
                    data.Add("Name", name);                         //名称
                    data.Add("UrlImag", "image/app.jpg");            //图片的保存地址
                    data.Add("Address", name + "对应的地址");      //对应的地址
                    data.Add("Content", infos[randow.Next(0, 5)]);    //对应的概要信息
                    m_CalloutCallback = UtilData.ToJson(data);
                    CallBackString = m_CalloutCallback;
                    break;

                case "Buffer":  //通过callout显示缓冲区
                    BufferAnalysis(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]), Convert.ToBoolean(args[3]), Convert.ToBoolean(args[4]));
                    break;

                case "ClearBuffer":     //清理缓冲区图形
                    Clear();
                    break;

                default: break;
            }
        }

        /// <summary>
        /// 缓冲区分析的函数
        /// </summary>
        /// 
        /*
        public void BufferAnalysis(double x, double y, bool clear, bool isIE)
        {
            positionX = (int)x;
            positionY = (int)y;
            bufferAnalyize(positionX,positionY);
        }
        */

        public void BufferAnalysis(double x, double y, bool clear, bool isIE)
        {
            positionX = (int)x;
            positionY = (int)y;
            //表示一些列相互连接的直线或者曲线
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            //缓冲区直径，注意是直径
            int distance = (int)Map1.Extent.Width / 10;
            //创建一个xy为圆心，distance为直径的圆形
            graphicsPath.AddEllipse((int)x - distance / 2, (int)y - distance / 2, distance, distance);
            graphicsPath.Flatten(null, (float)0.5);
            //创建一个点集合
            ESRI.ArcGIS.ADF.Web.Geometry.PointCollection pointCollection = new ESRI.ArcGIS.ADF.Web.Geometry.PointCollection();
            //将圆中的点放置到集合中
            foreach (System.Drawing.PointF pointF in graphicsPath.PathPoints)
            {
                pointCollection.Add(new ESRI.ArcGIS.ADF.Web.Geometry.Point(pointF.X, pointF.Y));
            }
            //利用点集合创建一个圆
            ESRI.ArcGIS.ADF.Web.Geometry.Ring ring = new ESRI.ArcGIS.ADF.Web.Geometry.Ring();
            ring.Points = pointCollection;
            //创建一个圆的集合
            ESRI.ArcGIS.ADF.Web.Geometry.RingCollection ringCollection = new ESRI.ArcGIS.ADF.Web.Geometry.RingCollection();
            ringCollection.Add(ring);
            //利用圆的集合创建一个集合图形
            ESRI.ArcGIS.ADF.Web.Geometry.Polygon polygon = new ESRI.ArcGIS.ADF.Web.Geometry.Polygon();
            polygon.Rings = ringCollection;

            //获得Buffer资源的functionality
            ESRI.ArcGIS.ADF.Web.DataSources.IGISFunctionality func = Map1.GetFunctionality("Buffer");

            //如果不存在这个资源就退出这个功能
            ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource resource = func.Resource as ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource;
            if (resource == null)
                return;
            //resource.DisplaySettings.ImageDescriptor.Width = 280;
            //resource.DisplaySettings.ImageDescriptor.Height = 24;  
            //创建一个图形集合
            ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer elayer = null;
            foreach (System.Data.DataTable table in resource.Graphics.Tables)
            {
                if (table is ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)
                {
                    elayer = (ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)table;
                }
            }

            if (elayer == null)
            {
                elayer = new ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer();
                resource.Graphics.Tables.Add(elayer);
            }

            if (clear)
            {
                elayer.Clear();
            }

            //创建一个几何形状
            ESRI.ArcGIS.ADF.Web.Geometry.Geometry geo = (ESRI.ArcGIS.ADF.Web.Geometry.Geometry)polygon;

            //创建显示几何形状的要素
            ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement ge =
                new ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement(geo, System.Drawing.Color.Green);

            if (isIE)
                ge.Symbol.Transparency = 100;
            else
                ge.Symbol.Transparency = 70;

            elayer.Add(ge);

            //设置透明度
            ESRI.ArcGIS.ADF.Web.UI.WebControls.MapResourceItem item = Map1.MapResourceManagerInstance.ResourceItems.Find("Buffer");
            item.DisplaySettings.Transparency = 50;
            //刷新资源
            if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.WebTier)
            {
                Map1.Refresh();
            }
            else if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.Browser)
            {
                //只刷新Graphics Resource
                Map1.RefreshResource(resource.Name);
            }
            CallBackString = Map1.CallbackResults.ToString();
        }

        public void Clear()
        {
            ESRI.ArcGIS.ADF.Web.DataSources.IGISFunctionality func = Map1.GetFunctionality("Buffer");

            ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource resource = func.Resource as ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource;
            if (resource == null)
                return;

            ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer elayer = null;
            foreach (System.Data.DataTable table in resource.Graphics.Tables)
            {
                if (table is ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)
                {
                    elayer = (ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)table;
                }
            }

            if (elayer == null)
            {
                elayer = new ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer();
                resource.Graphics.Tables.Add(elayer);
            }

            //清除已有的数据
            elayer.Clear();

            if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.WebTier)
            {
                Map1.Refresh();
            }
            else if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.Browser)
            {
                //只刷新Graphics Resource
                Map1.RefreshResource(resource.Name);
            }

            CallBackString = Map1.CallbackResults.ToString();
        }
        /// <summary>
        /// 查找特定的图层
        /// </summary>
        /// <param name="args">对前台传回的字符串进行切割之后的数组，第二项是选择的项目</param>
        public void SelectLayer(string[] args)
        {
            //前台传回的选择项目
            int index = Convert.ToInt32(args[1]);
            if (index >= Layers.Length)
            {
                CallBackString = "";
                return;
            }

            //创建一个返回数据表
            DataTable selectLayerTable = new System.Data.DataTable();

            selectLayerTable.Columns.Add("name", typeof(System.String));
            selectLayerTable.Columns.Add("address", typeof(System.String));
            selectLayerTable.Columns.Add("x", typeof(System.Double));
            selectLayerTable.Columns.Add("y", typeof(System.Double));
            selectLayerTable.Columns.Add("url", typeof(System.String));
            selectLayerTable.Columns.Add("type", typeof(System.Int32));

            //遍历图层数据，Layers数组保存的是特定的几个图层，以后可以直接在该这个数组
            DataTable table = UtilMap.Search("", Layers[index], Map1);

            //确定结果表中哪个字段是几何图形
            int geoIndex = 0;
            for (; geoIndex < table.Columns.Count; geoIndex++)
            {
                if (table.Columns[geoIndex].DataType == typeof(ESRI.ArcGIS.ADF.Web.Geometry.Geometry))
                    break;
            }

            ESRI.ArcGIS.ADF.Web.Geometry.Point point = null;

            //将地图上查询回来的结果保存到结果表中
            foreach (System.Data.DataRow dr in table.Rows)
            {
                System.Data.DataRow row = selectLayerTable.NewRow();

                if (mapNum == 0)
                {

                    //因为现在图层属性名称不统一，所以现在要做一个类型判断
                    if (index == 2)
                        row["name"] = dr["xiaoquName"] as System.String;
                    else
                        row["name"] = dr["NAME"] as System.String;
                }
                else
                {
                    if (index == 2)
                        row["name"] = dr["xiaoquName"] as System.String;
                    else
                        row["name"] = dr["TEXTSTRING"] as System.String;

                }

                //保存这个表中每个结果的几何点以便后期单击某个子项方便定位
                point = dr[geoIndex] as ESRI.ArcGIS.ADF.Web.Geometry.Point;
                if (point == null)
                    continue;

                row["x"] = point.X;
                row["y"] = point.Y;


                //这里应该会有个数据库的函数进行地址的查询操作，暂时写样例数据
                //参数传递的后期确定

                row["url"] = "images/simple/thumbs/1.jpg";
                row["type"] = index;


                selectLayerTable.Rows.Add(row);

            }

            //将结果转成json字符串传回前台
            m_SelectLayerCallback = UtilData.ToJson(selectLayerTable);
            CallBackString = m_SelectLayerCallback;
        }
        /// <summary>
        /// 实现搜索功能的代码
        /// </summary>
        /// <param name="args">前台传回来的参数数组</param>
        public void SelectItem(string[] args)
        {
            //用来保存搜索条件的字符串
            string whereClause = "";
            bool isCommunity = false;
            if (args[2] == "2") isCommunity = true;

            //参数数组的第三项是选择类型
            if (mapNum == 0)
            {
                //因为现在开县的这个地图中属性明明有一定的问题所以需要通过确定选择的类型来构建条件字符串
                if (args[2] == "2")
                    whereClause += "xiaoquName";
                else
                    whereClause += "NAME";
            }
            else
            {
                if (args[2] == "2")
                    whereClause += "xiaoquName";
                else
                    whereClause += "TEXTSTRING";
            }

            //构建查询字符串，实质的意义是判断名称等于我们传递过来的参数
            whereClause += " = '" + args[1] + "'";
            //根据创建的查询条件、查询图层、以及Map控件进行查询操作并且保存在结果表中
            DataTable table = null;

            table = UtilMap.Search(whereClause, Layers[int.Parse(args[2])], Map1);
            DataTable polygonTable = UtilMap.Search(whereClause, "Community_polygon", Map1);
            //因为在Search函数中创建查询条件的时候，设置返回geometry是为true的，所以在返回的结果表中是包含我们查询出来的geometry的
            //在这里通过这个循环确定geometry保存在结果表中哪个一列中



            int index = 0;
            for (; index < table.Columns.Count; index++)
            {
                if (table.Columns[index].DataType == typeof(ESRI.ArcGIS.ADF.Web.Geometry.Geometry))
                {
                     break;
                }

            }

            //HeightLight2(whereClause, Layers[int.Parse(args[2])]);
            //根据查询出来的geometry将地图放缩到这个geometry并且将地图进行放大操作
            ESRI.ArcGIS.ADF.Web.Geometry.Point geo = table.Rows[0][index] as ESRI.ArcGIS.ADF.Web.Geometry.Point;
            Map1.Zoom(geo);
            Map1.Zoom(10000);
            //下面是模拟从数据库获取的数据
            //这个list理论上是从数据库中读取出来的
            SortedList data = new SortedList();
            data.Add("UrlDetail", "Detail.aspx");//详细信息的跳转页面
            string name;
            if (mapNum == 0)
            {
                if (args[2] == "2")
                    name = Convert.ToString(table.Rows[0]["xiaoquName"]);
                else
                    name = Convert.ToString(table.Rows[0]["NAME"]);
            }
            else
            {
                if (args[2] == "2")
                    name = Convert.ToString(table.Rows[0]["xiaoquName"]);
                else
                    name = Convert.ToString(table.Rows[0]["TEXTSTRING"]);
            }

            Random randow = new Random();
            data.Add("Name", name);//名称
            data.Add("x", geo.X);
            data.Add("y", geo.Y);
            data.Add("UrlImag", "image/app.jpg");//图片的保存地址
            data.Add("Content", infos[randow.Next(0, 5)]);//对应的概要信息
            data.Add("showCallout", isCommunity);

            //根据小区名找到对应的省市和区县
            string province="重庆市";
            string county="涪陵";
            

            try
            {
                get_community_mainpage commuityInfo = new get_community_mainpage(province, county, name);
                
            
                

                data.Add("Address", commuityInfo.Address);//对应的地址
          

                data.Add("buildYear", commuityInfo.Construct_year);
                data.Add("totalHouseHold", commuityInfo.Reg_family_num);  //居民户籍人口户数
                data.Add("totalHeadCount", commuityInfo.Reg_people_num);    //居民户籍人口人数
                data.Add("emHouseHold", commuityInfo.Immigrant_family_num);  //移民人口户数
                data.Add("emHeadCount", commuityInfo.Immigrant_people_num);  //移民人口人数

                data.Add("buildArea", commuityInfo.Construction_area.ToString());  //建筑面积
                data.Add("occupyArea", commuityInfo.Floor_area.ToString());        //占地面积
                data.Add("showCount", commuityInfo.Facade.ToString());             //门面数
                data.Add("showCountUsage", Convert.ToDouble(commuityInfo.Facade_use_rate[1]).ToString("0.00"));  //门面使用率
                data.Add("employmentRate", Convert.ToDouble(commuityInfo.Employment_rate[1]).ToString("0.00")); //
                data.Add("perDisposableIncome", Convert.ToDouble(commuityInfo.Disposable_income[1]).ToString("0.0")); //人均可支配收入


                //开始
                data.Add("totalScheduleInvest", commuityInfo.Founds_down.ToString());  //累计专项资金下达
                data.Add("totalCompleteInvest", commuityInfo.Founds_com.ToString()); //累计专项资金完成
                data.Add("investUsage", Convert.ToDouble(commuityInfo.Founds_rate).ToString("0.00"));        //专项资金完成比率

                //按照资金来源的划分的投资计划及其完成情况
                data.Add("planCon2013", commuityInfo.Before_cons_2013);   //计划投资——专项投资
                data.Add("planCon2014", commuityInfo.Before_cons_2014);   //计划投资——对口支援投资
                data.Add("isCon2013", commuityInfo.Com_cons_2013);//计划投资——其他投资

                data.Add("isCon2014", commuityInfo.Com_cons_2014);//完成投资——专项投资
                data.Add("hasCon2013", commuityInfo.In_cons_2013); //完成投资——对口支援投资

                data.Add("hasCon2014", commuityInfo.In_cons_2013);   //完成投资——其他投资
                //结束

                //按照类别结构划分的投资计划及其完成情况
                data.Add("projectPSysConstructInvest", commuityInfo.Plan_house_safe);//计划投资——统建房安全
                data.Add("projectPBasisInvest", commuityInfo.Plan_base_fac); //计划投资——基础设施
                data.Add("projectPEnFriendInvest", commuityInfo.Plan_envir_pro);//计划投资——环保设施
                data.Add("projectPPublicServiceInvest", commuityInfo.Plan_public_fac); //计划投资——公共设施
                data.Add("projectPEconomicInvest", commuityInfo.Plan_busin);//计划投资——营商环境

                data.Add("projectFSysConstructInvest", commuityInfo.Com_house_safe); //完成投资——统建房安全
                data.Add("projectFBasisInvest", commuityInfo.Com_base_fac);//完成投资——基础设施
                data.Add("projectFEnFriendInvest", commuityInfo.Com_envir_pro);//完成投资——环保设施
                data.Add("projectFPublicServiceInvest", commuityInfo.Com_public_fac); //完成投资——公共设施
                data.Add("projectFEconomicInvest", commuityInfo.Com_busin);//完成投资——营商环境
                TTG.DAL.GET.get_project getProject = new get_project(province,county,name);
                List<project_data> totalList = getProject.List;
                if (totalList.Count > 0)
                {
                    data.Add("proCount", totalList.Count);
                    for (int i = 0; i < totalList.Count; i++)
                    {

                        if (totalList[i].Subproject_id == null)
                        {
                            data.Add("project_id_" + i, totalList[i].Project_id);
                        }
                        else {
                            data.Add("project_id_" + i, totalList[i].Subproject_id);
                        }
                        if (totalList[i].Child_name == null || totalList[i].Child_name == "--")
                        {
                            data.Add("project_name_" + i, totalList[i].Project_name);
                        }
                        else
                        {
                            data.Add("project_name_" + i, totalList[i].Child_name);
                        }
                        data.Add("project_progress_" + i, totalList[i].Project_progress);
                    }
                }
                

            }
            catch
            {
               
               
                data.Add("Address", name + "对应的地址");//对应的地址
                data.Add("buildYear", "2000");
                data.Add("totalHouseHold", 4000);
                data.Add("totalHeadCount", 12000);
                data.Add("emHouseHold", 2800);
                data.Add("emHeadCount", 8400);

                data.Add("buildArea", 300000);
                data.Add("occupyArea", 600000);
                data.Add("showCount", 500);
                data.Add("showCountUsage", 78);
                data.Add("employmentRate", 92);
                data.Add("perDisposableIncome", 40000);
                data.Add("totalScheduleInvest", 32000);
                data.Add("totalCompleteInvest", 24000);
                data.Add("investUsage", 75);

                //按照资金来源的划分的投资计划及其完成情况
                data.Add("fundPSpecialInvest", 100);
                data.Add("fundPMatchedInvest", 76);
                data.Add("fundPOtherInvest", 60);

                data.Add("fundFSpecialInvest", 80);
                data.Add("fundFMatchedInvest", 64);
                data.Add("fundFOtherInvest", 40);


                //按照类别结构划分的投资计划及其完成情况
                data.Add("projectPSysConstructInvest", 90);
                data.Add("projectPBasisInvest", 86);
                data.Add("projectPEnFriendInvest", 70);
                data.Add("projectPPublicServiceInvest", 68);
                data.Add("projectPEconomicInvest", 85);

                data.Add("projectFSysConstructInvest", 70);
                data.Add("projectFBasisInvest", 76);
                data.Add("projectFEnFriendInvest", 64);
                data.Add("projectFPublicServiceInvest", 56);
                data.Add("projectFEconomicInvest", 70);
                
              
                    data.Add("proCount", 0);
                  
                
            }


            //将保存结果的sortedlist转换成为json字符串
            string jsonStr = UtilData.ToJson(data);
            //HeightLight(table);
            //通过使用CallbackResult调用前台的processSelectItem处理返回的json字符串
            string JavascriptStr = "processSelectItem('" + jsonStr + "')";



            CallbackResult callback = new CallbackResult(null, null, "javascript", JavascriptStr);
            //HightLightShow(Map1, table);
            Map1.CallbackResults.Add(callback);
            //将Map的callbackresult集合字符串返回给js类库进行处理
            CallBackString = Map1.CallbackResults.ToString();
            //HeightLight(table);
            //  if(isCommunity)
            //  HightLightShow(Map1, polygonTable);

            //HeightLight(table);
            // HeightLight2(whereClause, Layers[int.Parse(args[2])]);
        }

        public void SearchByInput(string[] args)
        {
            DataTable data = new System.Data.DataTable();
            data.Columns.Add("name", typeof(System.String));
            data.Columns.Add("address", typeof(System.String));
            data.Columns.Add("x", typeof(System.Double));
            data.Columns.Add("y", typeof(System.Double));
            data.Columns.Add("url", typeof(System.String));
            data.Columns.Add("type", typeof(System.Int32));

            string whereClause = "";
            string name = "";

            for (int i = 0; i < Layers.Length; i++)
            {
                if (i == 2)
                    name = "xiaoquName";
                else
                    name = "TEXTSTRING";
                whereClause = name + " like '%" + args[1] + "%'";

                DataTable table = UtilMap.Search(whereClause, Layers[i], Map1);

                if (table != null && table.Rows.Count != 0)
                {
                    int index = 0;
                    for (; index < table.Columns.Count; index++)
                    {
                        if (table.Columns[index].DataType == typeof(ESRI.ArcGIS.ADF.Web.Geometry.Geometry))
                            break;
                    }

                    foreach (DataRow dr in table.Rows)
                    {
                        DataRow row = data.NewRow();
                        row["name"] = dr[name].ToString();
                        row["address"] = "测试地址";
                        row["url"] = "images/simple/thumbs/1.jpg";
                        row["type"] = i;

                        ESRI.ArcGIS.ADF.Web.Geometry.Point point = dr[index] as ESRI.ArcGIS.ADF.Web.Geometry.Point;
                        row["x"] = point.X;
                        row["y"] = point.Y;

                        data.Rows.Add(row);

                    }
                }


            }

            string jsonStr = UtilData.ToJson(data);
            CallBackString = jsonStr;
        }

        public void changeMap(string mapName)
        {
            ESRI.ArcGIS.ADF.Web.UI.WebControls.MapResourceItem item = Map1.MapResourceManagerInstance.ResourceItems.Find("kai");
            this.MapResourceManager1.ResourceItems.Remove(this.MapResourceManager1.ResourceItems.Find("MapResourceItem0"));
            string definition = "图层@" + mapName;
            //MapResourceManager1.Dispose();
            MapResourceItem mri = new MapResourceItem();
            MapResourceItem mri2 = new MapResourceItem();
            GISResourceItemDefinition grid = new GISResourceItemDefinition();
            GISResourceItemDefinition grid2 = new GISResourceItemDefinition();
            mri.Name = "MapResourceItem0";
            mri2.Name = "Buffer";
            OverviewMap1.OverviewMapResource = "MapResourceItem0";
            grid.DataSourceType = "ArcGIS Server Internet";
            grid.DataSourceDefinition = ConfigurationManager.AppSettings["dataSourceDefinition"].ToString();
            grid.Identity = "Uz6KdRH1PwWQbGLPcZzsKt+MQf/4Q6RO";
            grid.ResourceDefinition = definition;
            //grid.DataSourceShared = true;
            grid2.DataSourceType = "GraphicsLayer";
            grid2.DataSourceDefinition = "In Memory";
            mri.Parent = this.MapResourceManager1;
            mri.Definition = grid;
            ESRI.ArcGIS.ADF.Web.DisplaySettings displaySettings = new DisplaySettings();
            displaySettings.DisplayInTableOfContents = true;
            displaySettings.Visible = true;

            mri.DisplaySettings = displaySettings;
            mri2.DisplaySettings = displaySettings;

            this.MapResourceManager1.ResourceItems.Add(mri);
            this.MapResourceManager1.ResourceItems.Add(mri2);
            this.MapResourceManager1.Initialize();
            this.MapResourceManager1.Refresh();
            this.Map1.MapResourceManagerInstance = this.MapResourceManager1;
            this.Map1.MapResourceManager = "MapResourceManager1";
            if (Map1 != null)
                Map1.Reset();
            Map1.ZoomToFullExtent();
            this.Map1.Refresh();


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeMap(DropDownList1.SelectedItem.Value.ToString());

        }

















        /****************************以下代码没有运用***************************/
        public static void HighLightShowD(ESRI.ArcGIS.ADF.Web.UI.WebControls.Map map, DataTable datatable)
        {

            //ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer elemenGraL;
            //if (elemenGraL == null)
            //     return;

            IGISFunctionality gisfunctionality = map.GetFunctionality("Buffer");
            if (gisfunctionality == null)
                return;

            ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource gResource = null;
            gResource = (ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource)gisfunctionality.Resource;

            if (gResource == null)
                return;

            ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer glayer = null;

            foreach (System.Data.DataTable dt in gResource.Graphics.Tables)
            {
                if (dt is ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)
                {
                    glayer = (ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)dt;
                    break;
                }
            }
            if (glayer == null)
            {
                glayer = new ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer();
                gResource.Graphics.Tables.Add(glayer);
            }

            glayer.Clear();

            DataRowCollection drs = datatable.Rows;
            GeometryCollection collection = new GeometryCollection();

            int shpind = -1;

            for (int i = 0; i < datatable.Columns.Count; i++)
            {
                if (datatable.Columns[i].DataType == typeof(ESRI.ArcGIS.ADF.Web.Geometry.Geometry))
                {
                    shpind = i;
                    break;
                }
            }

            try
            {
                foreach (DataRow dr in drs)
                {
                    ESRI.ArcGIS.ADF.Web.Geometry.Geometry geom =
                        (ESRI.ArcGIS.ADF.Web.Geometry.Geometry)dr[shpind];
                    ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement ge = new
                        ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement(geom, System.Drawing.Color.Yellow);
                    GraphicsLayer graphicsLayer;
                    ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol symbol = new ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol();
                    //ge.Symbol.Transparency = 50.0;
                    symbol.Color = System.Drawing.Color.Blue;
                    symbol.BoundaryColor = System.Drawing.Color.Green;

                    //设置属性
                    ge.Symbol.Transparency = 80.0;
                    ge.Symbol = symbol;
                    ge.Geometry = geom;

                    //将对象添加到容器中

                    ESRI.ArcGIS.ADF.Web.Geometry.Point centerpoint =
                        ESRI.ArcGIS.ADF.Web.Geometry.Geometry.GetCenterPoint(geom);

                    //elemenGraL.Add(ge);
                    collection.Add(geom);
                    glayer.Add(ge);
                }
            }
            catch (InvalidCastException ice)
            {

                throw new Exception("No geometry available in datatable");
            }

        }

        public static void HightLightShow(ESRI.ArcGIS.ADF.Web.UI.WebControls.Map map, DataTable datatable)
        {

            IGISFunctionality gisfunctionality = map.GetFunctionality("Buffer");
            if (gisfunctionality == null)
                return;

            ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource gResource = null;

            gResource = (ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource)gisfunctionality.Resource;

            if (gResource == null)
                return;

            ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer glayer = null;

            foreach (DataTable dt in gResource.Graphics.Tables)
            {
                if (dt is ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)
                {
                    glayer = (ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)dt;
                    break;
                }
            }
            if (glayer == null)
            {
                glayer = new ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer();
                gResource.Graphics.Tables.Add(glayer);
            }
            glayer.Clear();

            DataRowCollection drs = datatable.Rows;

            int shpind = -1;

            for (int i = 0; i < datatable.Columns.Count; i++)
            {
                if (datatable.Columns[i].DataType == typeof(ESRI.ArcGIS.ADF.Web.Geometry.Geometry))
                {
                    shpind = i;
                    break;
                }
            }

            try
            {
                foreach (DataRow dr in drs)
                {
                    ESRI.ArcGIS.ADF.Web.Geometry.Geometry geom =
                                    (ESRI.ArcGIS.ADF.Web.Geometry.Geometry)dr[shpind];
                    ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement ge = new
                                            ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement(geom, System.Drawing.Color.Blue);

                    ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol symbol = new ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol();

                    ESRI.ArcGIS.ADF.Web.Geometry.Point centerpoint =
                           ESRI.ArcGIS.ADF.Web.Geometry.Geometry.GetCenterPoint(geom);

                    glayer.Add(ge);
                    map.CenterAt(centerpoint);
                }
            }
            catch (InvalidCastException ice)
            {
                throw new Exception("No geometry available in datatable");
            }
        }
        /*
     public void BufferAnalysis(double x, double y, bool clear, bool isIE)
     {

         System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
         //缓冲区直径，注意是直径
         float distance = 100;
         //创建一个xy为圆心，distance为直径的圆形
         graphicsPath.AddEllipse((int)x - distance / 2, (int)y - distance / 2, distance, distance);
         System.Drawing.Drawing2D.Matrix translateMatrix = new
             System.Drawing.Drawing2D.Matrix();

         translateMatrix.Translate(0,0);

         float flattening = distance / 10;

         graphicsPath.Flatten(translateMatrix,flattening);

         ESRI.ArcGIS.ADF.Web.Geometry.PointCollection pc = new
             ESRI.ArcGIS.ADF.Web.Geometry.PointCollection();

          //将圆中的点放置到集合中
         foreach (System.Drawing.PointF pointF in graphicsPath.PathPoints)
         {
             pc.Add(new ESRI.ArcGIS.ADF.Web.Geometry.Point(pointF.X, pointF.Y));
         }

          //利用点集合创建一个圆
         ESRI.ArcGIS.ADF.Web.Geometry.Ring ring = new ESRI.ArcGIS.ADF.Web.Geometry.Ring();
         ring.Points = pc;

         //创建一个圆的集合
         ESRI.ArcGIS.ADF.Web.Geometry.RingCollection ringCollection = new ESRI.ArcGIS.ADF.Web.Geometry.RingCollection();
         ringCollection.Add(ring);

         //利用圆的集合创建一个集合图形
         ESRI.ArcGIS.ADF.Web.Geometry.Polygon polygon = new ESRI.ArcGIS.ADF.Web.Geometry.Polygon();
         polygon.Rings = ringCollection;

         //获得Buffer资源的functionality
         ESRI.ArcGIS.ADF.Web.DataSources.IGISFunctionality func = Map1.GetFunctionality("Buffer");

         //如果不存在这个资源就退出这个功能
         ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource resource = func.Resource as ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource;
         if (resource == null)
             return;
         //创建一个图形集合
         ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer elayer = null;
         foreach (System.Data.DataTable table in resource.Graphics.Tables)
         {
             if (table is ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)
             {
                 elayer = (ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)table;
             }
         }

         if (elayer == null)
         {
             elayer = new ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer();
             resource.Graphics.Tables.Add(elayer);
         }

         if (clear)
         {
             elayer.Clear();
         }

         //创建一个几何形状
         ESRI.ArcGIS.ADF.Web.Geometry.Geometry geo = (ESRI.ArcGIS.ADF.Web.Geometry.Geometry)polygon;

         //创建显示几何形状的要素
         ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement ge =
             new ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement(geo, System.Drawing.Color.Green);

         if (isIE)
             ge.Symbol.Transparency = 100;
         else
             ge.Symbol.Transparency = 70;

         elayer.Add(ge);

         //设置透明度
         ESRI.ArcGIS.ADF.Web.UI.WebControls.MapResourceItem item = Map1.MapResourceManagerInstance.ResourceItems.Find("Buffer");
         item.DisplaySettings.Transparency = 50;
         //刷新资源
         if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.WebTier)
         {
             Map1.Refresh();
         }
         else if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.Browser)
         {
             //只刷新Graphics Resource
             Map1.RefreshResource(resource.Name);
         }
         CallBackString = Map1.CallbackResults.ToString();
     }
      * /
     /*
     private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
     {
         ESRI.ArcGIS.Carto.IFillShapeElement pPolygonElement;
         ESRI.ArcGIS.Carto.IFillShapeElement pSimpleFillSymbol = new SimpleFillSymbolClass();
         IPolygon pPolygon = new PolygonClass();
         IRubberBand pRubberBand = new RubberPolygonClass();
         ISimpleLineSymbol pSimpleLineSymbol = new SimpleLineSymbolClass();
         pPolygonElement = new PolygonElementClass();

         if (e.button == 1)
         {
             pPolygon = (IPolygon)pRubberBand.TrackNew(axMapControl1.ActiveView.ScreenDisplay, null);
         }
         pSimpleLineSymbol.Width = 2;
         pSimpleLineSymbol.Style = esriSimpleLineStyle.esriSLSSolid;
         pSimpleLineSymbol.Color = GetRGBColor(46, 24, 63);

         pSimpleFillSymbol.Color = GetRGBColor(11, 200, 145);
         pSimpleFillSymbol.Outline = pSimpleLineSymbol;
         IElement pElement = (IElement)pPolygonElement;
         pElement.Geometry = pPolygon;
         pPolygonElement.Symbol = pSimpleFillSymbol;

         IGraphicsContainer pGraphicsContainer = (IGraphicsContainer)axMapControl1.Map;
         pGraphicsContainer.AddElement((IElement)pPolygonElement, 0);
         axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
     }

     private IRgbColor GetRGBColor(int red, int green, int blue)
     {
         IRgbColor rGBColor = new RgbColorClass();
         rGBColor.Red = red;
         rGBColor.Green = green;
         rGBColor.Blue = blue;
         return rGBColor;
     }
      * */
        /*
        public void BufferAnalysis(double x, double y, bool clear, bool isIE)
        {

            ESRI.ArcGIS.ADF.Web.Geometry.PointCollection pc =
                                        new ESRI.ArcGIS.ADF.Web.Geometry.PointCollection();

            double degress;
            double rad = 100;
            for (int i = 0; i < 360; i++)
            {
                degress = i * (Math.PI / 180);
                double newx = x + Math.Cos(degress) * rad;
                double newy = y + Math.Sin(degress) * rad;
                ESRI.ArcGIS.ADF.Web.Geometry.Point pt =
                     ESRI.ArcGIS.ADF.Web.Geometry.Point.ToMapPoint((int)Math.Round(newx), (int)Math.Round(newy), Map1.GetTransformationParams(ESRI.ArcGIS.ADF.Web.Geometry.TransformationDirection.ToMap));
                pc.Add(pt);
            }
            //利用点集合创建一个圆
            ESRI.ArcGIS.ADF.Web.Geometry.Ring ring = new ESRI.ArcGIS.ADF.Web.Geometry.Ring();
            ring.Points = pc;


            //利用圆的集合创建一个集合图形
            ESRI.ArcGIS.ADF.Web.Geometry.Polygon polygon = new ESRI.ArcGIS.ADF.Web.Geometry.Polygon();

            //获得Buffer资源的functionality
            ESRI.ArcGIS.ADF.Web.DataSources.IGISFunctionality func = Map1.GetFunctionality("Buffer");

            //如果不存在这个资源就退出这个功能
            ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource resource = func.Resource as ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource;
           

            polygon.Rings.Add(ring);

            if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.WebTier)
            {
                Map1.Refresh();
            }
            else if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.Browser)
            {
                //只刷新Graphics Resource
                Map1.RefreshResource(resource.Name);
            }

            CallBackString = Map1.CallbackResults.ToString();
        }
        */
        #region 清除第一种高亮
        public ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer clear1()
        {
            //获取用于高亮的资源
            IEnumerable func_enum = Map1.GetFunctionalities();

            ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource mapR = null;

            foreach (ESRI.ArcGIS.ADF.Web.DataSources.IGISFunctionality igisF in func_enum)
            {
                if (igisF.Resource.Name == "Buffer")
                {
                    mapR = (ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource)igisF.Resource;
                    break;
                }
            }

            if (mapR == null)
                return null;

            //获取该资源的高亮绘制图层
            ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer elemenGraL = null;

            foreach (DataTable datatable in mapR.Graphics.Tables)
            {

                if (datatable is ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)
                    elemenGraL = (ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)datatable;

            }

            if (elemenGraL == null)
            {

                elemenGraL = new ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer();
                mapR.Graphics.Tables.Add(elemenGraL);

            }

            elemenGraL.Clear();
            return elemenGraL;

        }
        #endregion

        #region 第一种高亮方式
        public void HeightLight(DataTable table)
        {

            ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer elemenGraL = clear1();

            if (elemenGraL == null)
                return;

            int hlindex = -1;

            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].DataType == typeof(ESRI.ArcGIS.ADF.Web.Geometry.Geometry))
                {
                    hlindex = i;
                    break;
                }
            }

            //获得Buffer资源的functionality
            ESRI.ArcGIS.ADF.Web.DataSources.IGISFunctionality func = Map1.GetFunctionality("Buffer");

            //如果不存在这个资源就退出这个功能
            ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource resource =
                               func.Resource as ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapResource;

            DataRowCollection rows = table.Rows;
            GeometryCollection collection = new GeometryCollection();

            try
            {
                foreach (DataRow row in rows)
                {
                    //获得表中保存的geometry对象
                    ESRI.ArcGIS.ADF.Web.Geometry.Geometry geom = (ESRI.ArcGIS.ADF.Web.Geometry.Geometry)row[hlindex];

                    //创建代表高亮的GraphicElement对象
                    ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement ge =
                        new ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement();
                    //创建一个SimpleFillSymbol对象设置高亮的显示方式
                    ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol symbol = new ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol();

                    symbol.Color = System.Drawing.Color.Red;
                    symbol.BoundaryColor = System.Drawing.Color.Yellow;

                    //设置属性
                    ge.Symbol = symbol;
                    ge.Geometry = geom;

                    //将对象添加到容器中
                    elemenGraL.Add(ge);
                    collection.Add(geom);

                }
            }
            catch (InvalidCastException ice)
            {
                throw new Exception("No geometry available in datatable");
            }

            Map1.Zoom(100);
            /*
            if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.WebTier)
            {
                Map1.Refresh();
            }
            else if (Map1.ImageBlendingMode == ESRI.ArcGIS.ADF.Web.UI.WebControls.ImageBlendingMode.Browser)
            {
                Map1.RefreshResource(resource.Name);
            }
            */

        }
        #endregion

        #region 第二种高亮方式

        public DataTable HeightLight2(string whereClause, string layName)
        {

            IEnumerable func_enum = Map1.GetFunctionalities();
            DataTable table = new DataTable();

            foreach (ESRI.ArcGIS.ADF.Web.DataSources.IGISFunctionality igisFunc in func_enum)
            {
                ESRI.ArcGIS.ADF.Web.DataSources.IGISResource igisResource = igisFunc.Resource;
                if (igisResource.Name == "Buffer")
                    continue;

                bool support = false;
                support = igisResource.SupportsFunctionality(typeof(ESRI.ArcGIS.ADF.Web.DataSources.IQueryFunctionality));

                if (support)
                {
                    ESRI.ArcGIS.ADF.Web.DataSources.IQueryFunctionality iqFunc =
                        (ESRI.ArcGIS.ADF.Web.DataSources.IQueryFunctionality)igisResource.CreateFunctionality(
                        typeof(ESRI.ArcGIS.ADF.Web.DataSources.IQueryFunctionality), null);

                    string[] lids;
                    string[] lnames;

                    iqFunc.GetQueryableLayers(null, out lids, out lnames);

                    ESRI.ArcGIS.ADF.Web.SpatialFilter spatialFilter = new ESRI.ArcGIS.ADF.Web.SpatialFilter();
                    spatialFilter.ReturnADFGeometries = true;
                    spatialFilter.MaxRecords = 1000;
                    spatialFilter.WhereClause = whereClause;

                    int index = -1;
                    for (int i = 0; i < lnames.Length; i++)
                    {
                        if (lnames[i] == layName)
                        {
                            index = i;
                            break;
                        }
                    }

                    if (index == -1)
                    {
                        return null;
                    }

                    table = iqFunc.Query(null, lids[index], spatialFilter);

                    if (table != null)
                    {
                        ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicsLayer selectLayer = ESRI.ArcGIS.ADF.Web.Converter.ToGraphicsLayer(table);
                        foreach (System.Data.DataRow dr in selectLayer.Rows)
                            dr[selectLayer.IsSelectedColumn] = true;
                        MapResourceManager mrm = Map1.MapResourceManagerInstance;

                        ESRI.ArcGIS.ADF.Web.UI.WebControls.LayerFormat lf =
                            ESRI.ArcGIS.ADF.Web.UI.WebControls.LayerFormat.FromMapResourceManager(
                            Map1.MapResourceManagerInstance, igisResource.Name, lids[index]);
                        lf.Apply(selectLayer);
                        selectLayer.RenderOnClient = true;

                        //Invocation = Map1.CallbackResults.ToString();
                    }
                    return table;
                }
            }
            return null;

        }

        #endregion

        /*
        private string getJavaScript() {

            StringBuilder JavaScript = new StringBuilder();
            JavaScript.Append("<script type='text/javascript'>");
            JavaScript.Append("var Id=0;\n");
            JavaScript.AppendFormat("var MAX = {0};\n",_UpperLimit);
            JavaScript.AppendFormat("var DivFiles = document.getElementById('{0}'); \n",pnlFiles.ClientID);
            JavaScript.AppendFormat("var DivListBox = document.getElementById('{0}'); \n",pnListBox.ClientID);
            JavaScript.AppendFormat("var BtnAdd = document.getELementById('{0}'); \n",btnAdd.ClientID);
            JavaScript.Append("function Add()");
            JavaScript.Append("{ \n");
            JavaScript.Append("var IpFile = GetTopFile(); \n");

            JavaScript.Append("if(IpFile ==null || IpFile.value == null || IpFile.value.length ==0) \n");
            JavaScript.Append("{ \n");
            JavaScript.Append("alert('请选择添加的文件'); \n");
            JavaScript.Append("return;\n");
            JavaScript.Append("} \n");
            JavaScript.Append("var NewIpFile = CreateFile(); \n");
            JavaScript.Append("DivFiles.insertBefore(NewIpFile,IpFile); \n");

            JavaScript.Append("if(MAX !=0 &&GetTotalFiles() - 1 == MAX) \n");
            JavaScript.Append("{ \n");

            JavaScript.Append("NewIpFile.disabled = true; \n");
            JavaScript.Append("BtnAdd.disabled = true; \n");
            JavaScript.Append("}\n");
            JavaScript.Append("function CreateFile()");
            JavaScript.Append("{\n");
            JavaScript.Append("var IpFile = document.createElement('input'); \n");
            JavaScript.Append("IpFile.id = IpFile.name = '_IpFile_' + Id ++; \n");
            JavaScript.Append("IpFile.type = 'file'; \n");

            JavaScript.Append("return IpFile; \n");
            JavaScript.Append("} \n");
            JavaScript.Append("function CreateItem(IpFile) \n");
            JavaScript.Append("{\n");

            JavaScript.Append("var Item = document.createElement('div'); \n");
            JavaScript.Append("Item.style.backgroundColor = '#ffffff'; \n");
            JavaScript.Append("Item.style.fontWeight ='normal';\n");
            JavaScript.Append("Item.style.textAlign = 'Left';\n");
            JavaScript.Append("Item.style.verticalAlign = 'middle';\n");
            JavaScript.Append("Item.style.cursor = 'default';\n");
            JavaScript.Append("Item.style.height = 20 + 'px';\n");
            JavaScript.Append("var Splits = IpFile.value.split('\\\\');\n");


            JavaScript.Append("Item.innerHTML = Splits[Splits.length -1] + '&nbsp;'; \n");
            JavaScript.Append("Item.value = IpFile.id; \n");
            JavaScript.Append("Item.title = IpFile.value;\n");
            JavaScript.Append("var A = document.createElement('a');\n");
            JavaScript.Append("A.innerHTML = 'Delete';");
            JavaScript.Append("A.id = 'A_' + Id++; \n");
            JavaScript.Append("A.href = '#'; \n");
            JavaScript.Append("A.style.color = 'blue';\n");

            JavaScript.Append("A.onclick = function() \n");
            JavaScript.Append("{ \n");
            JavaScript.Append("DivFiles.removeChild(document.getElementById(this.parentNode.value));\n");
            JavaScript.Append("DivListBox.removeChild(this.parentNode); \n");
            JavaScript.Append("if(MAX !=0 && GEtTotalFiles() - 1 < MAX) \n");
            JavaScript.Append("{\n");
            JavaScript.Append("GetTopFile().disabled = false;\n");
            JavaScript.Append("BtnAdd.disabled = false;\n");
            JavaScript.Append("}\n");
            JavaScript.Append("}\n");

            JavaScript.Append("Item.appendChild(A);\n");

            JavaScript.Append("Item.onmouseover = function()\n");
            JavaScript.Append("{\n");
            JavaScript.Append("Item.bgColor = Item.style.backgroundColor;\n");
            JavaScript.Append("Item.fColor = Item.style.color;\n");
            JavaScript.Append("Item.style.backgroundColor = '#C6780B'; \n");
            JavaScript.Append("Item.style.color = '#ffffff'; \n");
            JavaScript.Append("Item.style.fontWeight = 'bold'; \n");
            JavaScript.Append("}\n");
            JavaScript.Append("Item.onmouseout = function() \n");
            JavaScript.Append("{\n");
            JavaScript.Append("Item.style.backgroundColor = Item.bgColor;\n");
            JavaScript.Append("Item.style.color = Item.fColor; \n");
            JavaScript.Append("Item.style.fontWeight = 'normal'; \n");
            JavaScript.Append("}\n");
            JavaScript.Append("return Item;\n");
            JavaScript.Append("}\n");

            JavaScript.Append("function Clear() \n");
            JavaScript.Append("{\n");
            JavaScript.Append("DivListBox.innerHTML = '';\n");
            JavaScript.Append("DivFiles.innerHTML   = '';\n");
            JavaScript.Append("DivFiles.appendChild(CreateFile()); \n");
            JavaScript.Append("BtnAdd.disabled = false; \n");
            JavaScript.Append("}\n");

            JavaScript.Append("function GetTopFile()\n");
            JavaScript.Append("{\n");
            JavaScript.Append("var Inputs = DivFiles.getElementsByTagName('input'); \n");
            JavaScript.Append("var IpFile = null; \n");
            JavaScript.Append("for(var n=0;n<Inputs.length &&Inputs[n].type == 'file';++n)\n");
            JavaScript.Append("{\n");
            JavaScript.Append("IpFile = Inputs[n]; \n");
            JavaScript.Append("break;\n");
            JavaScript.Append("}\n");
            JavaScript.Append("return IpFile;\n");
            JavaScript.Append("}\n");

            JavaScript.Append("function GetTopFiles()\n");
            JavaScript.Append("{\n");
            JavaScript.Append("var Inputs = DivFiles.getElementsByTagName('input');\n");
            JavaScript.Append("var Counter = 0; \n");
            JavaScript.Append("for(var n=0;n<Inputs.length && Inputs[n].type == 'file';++n) \n");
            JavaScript.Append("Counter++;\n");
            JavaScript.Append("return Counter;\n");
            JavaScript.Append("}\n"); 

            JavaScript.Append("function GetTotalItems()\n");
            JavaScript.Append("{\n");
            JavaScript.Append("var Items = DivListBox.getElementsByTagName('div'); \n");
            JavaScript.Append("return Item.length; \n");
            JavaScript.Append("}\n");

            JavaScript.Append("function DisableTop()\n");
            JavaScript.Append("{\n");
            JavaScript.Append("if(GetTotalItems() == 0) \n");
            JavaScript.Append("alert(请选择最少一个文件上传);\n");
            JavaScript.Append("return false; \n");
            JavaScript.Append("}\n");
            JavaScript.Append("GetTopFile().disabled = true;");
            JavaScript.Append("return true; \n");
            JavaScript.Append("}\n");
            JavaScript.Append("</script>");
            
           return JavaScript.ToString();
            
        }

        private ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.MapResourceBase GetResource() {
            ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.MapFunctionality
                    agsMapFunctionality = (ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.MapFunctionality)Map1.GetFunctionality(_targetResourceName);
            return agsMapFunctionality.Resource as ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.MapResourceBase;
                     
        }

        public void AddLayer(ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.MapResourceBase mapResourceBase,string layerName) {
                    ESRI.ArcGIS.Carto.IMapServerObjects mapServerObjects =
                            (ESRI.ArcGIS.Carto.IMapServerObjects)mapResourceBase.MapServerInfo;
                      
        }
      */
        void IMapServerToolAction.ServerAction(ToolEventArgs args)
        {
            ESRI.ArcGIS.ADF.Web.UI.WebControls.Map map = args.Control as ESRI.ArcGIS.ADF.Web.UI.WebControls.Map;
            PointEventArgs pea = (PointEventArgs)args;
            System.Drawing.Point screenPoint = pea.ScreenPoint;

            ESRI.ArcGIS.ADF.Web.Geometry.Point adfmapPoint = ESRI.ArcGIS.ADF.Web.Geometry.Point.ToMapPoint(screenPoint.X, screenPoint.Y, map.Extent,
                                    (int)map.Width.Value, (int)map.Height.Value);

            ESRI.ArcGIS.ADF.ArcGISServer.PointN agsmapPoint;
            agsmapPoint = ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.Converter.FromAdfPoint(adfmapPoint);

            ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.MapFunctionality mf;
            mf = (ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.MapFunctionality)map.GetFunctionality("Buffer");
            if (mf == null)
                return;




        }
        /*
        public void bufferAnalyize(double x, double y)
        {

            ESRI.ArcGIS.ADF.ArcGISServer.PointN pt = new ESRI.ArcGIS.ADF.ArcGISServer.PointN();
            pt.X = x;
            pt.Y = y;

            // 设置点的颜色
            ESRI.ArcGIS.ADF.ArcGISServer.RgbColor rgb = new ESRI.ArcGIS.ADF.ArcGISServer.RgbColor();
            rgb.Red = 0;
            rgb.Blue = 0;
            rgb.Green = 20;

            // 设置点的符号
            ESRI.ArcGIS.ADF.ArcGISServer.SimpleMarkerSymbol sms = new ESRI.ArcGIS.ADF.ArcGISServer.SimpleMarkerSymbol();
            sms.Style = ESRI.ArcGIS.ADF.ArcGISServer.esriSimpleMarkerStyle.esriSMSCircle;
            sms.Color = rgb;
            sms.Size = 20;

            ESRI.ArcGIS.ADF.ArcGISServer.MarkerElement marker = new ESRI.ArcGIS.ADF.ArcGISServer.MarkerElement();
            marker.Symbol = sms;
            marker.Point = pt;

            
            ESRI.ArcGIS.ADF.Identity identity = new ESRI.ArcGIS.ADF.Identity("arcgisservices", "admin", "localhost");
            ESRI.ArcGIS.ADF.Connection.AGS.AGSServerConnection agsconnection;
            agsconnection = new ESRI.ArcGIS.ADF.Connection.AGS.AGSServerConnection("localhost", identity);
            agsconnection.Connect();
            ESRI.ArcGIS.Server.IServerObjectManager som = agsconnection.ServerObjectManager;
            ESRI.ArcGIS.Server.IServerContext serverContext = som.CreateServerContext("Redlands", "MapServer");
            

            // 定义COM对象的点
            ESRI.ArcGIS.Geometry.IPoint ipnt;
            // 进行valueobject到comobject之间的转换
            ipnt = (ESRI.ArcGIS.Geometry.IPoint)ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.Converter.ValueObjectToComObject(pt, serverContext);

            ESRI.ArcGIS.Geometry.ITopologicalOperator topop = (ESRI.ArcGIS.Geometry.ITopologicalOperator)ipnt;
            double bufferDistance = 100;
            ESRI.ArcGIS.Geometry.IPolygon bufferPolygon;
            bufferPolygon = (ESRI.ArcGIS.Geometry.IPolygon)topop.Buffer(bufferDistance);


            // 定义valueobject的点
            ESRI.ArcGIS.ADF.ArcGISServer.PolygonN buffer_polyn;
            // 进行comobject到valueobject之间的转换
            buffer_polyn = (ESRI.ArcGIS.ADF.ArcGISServer.PolygonN)ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.Converter.ComObjectToValueObject(bufferPolygon, serverContext, typeof(ESRI.ArcGIS.ADF.ArcGISServer.PolygonN));

            ESRI.ArcGIS.ADF.ArcGISServer.RgbColor rgb1 = new ESRI.ArcGIS.ADF.ArcGISServer.RgbColor();
            rgb1.Red = 200;
            rgb1.Green = 200;
            rgb1.Blue = 20;
            // 设置区的填充色
            ESRI.ArcGIS.ADF.ArcGISServer.SimpleFillSymbol sfs1 = new ESRI.ArcGIS.ADF.ArcGISServer.SimpleFillSymbol();
            sfs1.Style = ESRI.ArcGIS.ADF.ArcGISServer.esriSimpleFillStyle.esriSFSHorizontal;
            sfs1.Color = rgb1;

            ESRI.ArcGIS.ADF.ArcGISServer.PolygonElement polyelement1 = new ESRI.ArcGIS.ADF.ArcGISServer.PolygonElement();
            polyelement1.Symbol = sfs1;
            polyelement1.Polygon = buffer_polyn;
        }
        */
        public void bufferAnalyize()
        {
            ESRI.ArcGIS.ADF.Connection.AGS.AGSServerConnection connection = new
                ESRI.ArcGIS.ADF.Connection.AGS.AGSServerConnection();

            connection.Host = "localhost";
            connection.Connect();

            ESRI.ArcGIS.Server.IServerObjectManager pSOM = connection.ServerObjectManager;
            ESRI.ArcGIS.Server.IServerContext pSC = pSOM.CreateServerContext("涪陵", "MapServer");

            ESRI.ArcGIS.Carto.IMapServer imapserver = pSC.ServerObject as ESRI.ArcGIS.Carto.IMapServer;

            ESRI.ArcGIS.Carto.IMapServerObjects pMSO = (ESRI.ArcGIS.Carto.IMapServerObjects)imapserver;

            ESRI.ArcGIS.Geometry.IGeometry compnt = (ESRI.ArcGIS.Geometry.IGeometry)ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.Converter.ValueObjectToComObject(pSC, pSOM);

            ESRI.ArcGIS.Geometry.SpatialReferenceEnvironment are = new ESRI.ArcGIS.Geometry.SpatialReferenceEnvironment();

            ESRI.ArcGIS.Geometry.ISpatialReference pSR = are.CreateGeographicCoordinateSystem(4326);
            compnt.SpatialReference = pSR;
            ESRI.ArcGIS.Geometry.ITopologicalOperator pTOPO = (ESRI.ArcGIS.Geometry.ITopologicalOperator)compnt;

            pTOPO.Simplify();

            double bufdis = Map1.Extent.Width / 10;
            ESRI.ArcGIS.Geometry.IPolygon bufPoly =
                 (ESRI.ArcGIS.Geometry.IPolygon)pTOPO.Buffer(1);

            ESRI.ArcGIS.ADF.ArcGISServer.PolygonN valuePoly =
                (ESRI.ArcGIS.ADF.ArcGISServer.PolygonN)ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.Converter.ComObjectToValueObject(bufPoly, pSC, typeof(ESRI.ArcGIS.ADF.ArcGISServer.PolygonN));

            ESRI.ArcGIS.ADF.Web.Geometry.Polygon adfpoly =
                  (ESRI.ArcGIS.ADF.Web.Geometry.Polygon)ESRI.ArcGIS.ADF.Web.DataSources.ArcGISServer.Converter.ToAdfPolygon(valuePoly);

        }
        public void ServerAction(ESRI.ArcGIS.ADF.Web.UI.WebControls.ToolEventArgs args)
        {
            ESRI.ArcGIS.ADF.Web.UI.WebControls.Map adfMap = (ESRI.ArcGIS.ADF.Web.UI.WebControls.Map)args.Control;

        }
        private void ConvertToADFGeometry(CircleEventArgs args)
        {
            ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapFunctionality adfGraphicsMapFunctionality = null;
            ESRI.ArcGIS.ADF.Web.Geometry.PointCollection pc = new ESRI.ArcGIS.ADF.Web.Geometry.PointCollection();
            double degress;
            double rad = 100.00;
            ESRI.ArcGIS.ADF.Web.UI.WebControls.Map adfMap = (ESRI.ArcGIS.ADF.Web.UI.WebControls.Map)args.Control;
            for (int i = 0; i < 360; i++)
            {
                degress = i * (Math.PI / 180);
                double x = args.CenterPoint.X + Math.Cos(degress) * rad;
                double y = args.CenterPoint.Y + Math.Sin(degress) * rad;

                ESRI.ArcGIS.ADF.Web.Geometry.Point pt = ESRI.ArcGIS.ADF.Web.Geometry.Point.ToMapPoint((int)Math.Round(x),
                                        (int)Math.Round(y), adfMap.GetTransformationParams(ESRI.ArcGIS.ADF.Web.Geometry.TransformationDirection.ToMap));
                pc.Add(pt);
            }



            ESRI.ArcGIS.ADF.Web.Geometry.Ring ring = new ESRI.ArcGIS.ADF.Web.Geometry.Ring();
            ring.Points = pc;
            ESRI.ArcGIS.ADF.Web.Geometry.RingCollection rings = new ESRI.ArcGIS.ADF.Web.Geometry.RingCollection();
            rings.Add(ring);
            ESRI.ArcGIS.ADF.Web.Geometry.Polygon polygon = new ESRI.ArcGIS.ADF.Web.Geometry.Polygon();
            polygon.Rings = rings;

            //MapFunctionality
            foreach (ESRI.ArcGIS.ADF.Web.DataSources.IMapFunctionality mapFunctionality in adfMap.GetFunctionalities())
            {
                //当Resource为ADFGraphicsResource,ADFGraphicsResource为GraphicsLayer， 保存在内存中用显示临时图层
                if (mapFunctionality.Resource.Name == "GraphicsResource")
                {
                    adfGraphicsMapFunctionality = (ESRI.ArcGIS.ADF.Web.DataSources.Graphics.MapFunctionality)mapFunctionality;
                    break;
                }
            }
            //从adfGraphicsMapFunctionality获取名为Element Graphics的DataTable
            //ElementGraphicsLayers通常用来显示图形元素，例如显示Map中被选择的图形元素。图层并不用来存储属性，而可以存储不同的图形类型。
            ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer elementGraphicsLayer = null;
            foreach (System.Data.DataTable dataTable in adfGraphicsMapFunctionality.GraphicsDataSet.Tables)
            {
                if (dataTable.TableName == "Element Graphics")
                {
                    elementGraphicsLayer = (ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer)dataTable;
                    break;
                }
            }
            //如果名为Element Graphics的DataTable为null，就新建Element Graphics DataTable添加到adfGraphicsMapFunctionality.GraphicsDataSet中,同时刷新Toc1显示
            if (elementGraphicsLayer == null)
            {
                elementGraphicsLayer = new ESRI.ArcGIS.ADF.Web.Display.Graphics.ElementGraphicsLayer();
                elementGraphicsLayer.TableName = "Element Graphics";
                adfGraphicsMapFunctionality.GraphicsDataSet.Tables.Add(elementGraphicsLayer);
            }

            ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol simpleMarkerSymbol = new ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol();
            simpleMarkerSymbol.Color = System.Drawing.Color.Yellow;
            simpleMarkerSymbol.FillType = ESRI.ArcGIS.ADF.Web.Display.Symbol.PolygonFillType.DiagCross;

            ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol simpleSelectedMarkerSymbol = new ESRI.ArcGIS.ADF.Web.Display.Symbol.SimpleFillSymbol();
            ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement graphicElement = new ESRI.ArcGIS.ADF.Web.Display.Graphics.GraphicElement(polygon, simpleMarkerSymbol, simpleSelectedMarkerSymbol);
            //把标点添加到elementGraphicsLayer
            elementGraphicsLayer.Add(graphicElement);

        }
        /****************************以上代码没有运用***************************/
    }
}