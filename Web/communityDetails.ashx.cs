using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ESRI.ArcGIS.ADF.Web.UI.WebControls;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Designers;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Editors;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Design.Editors.Resources.LayerDefinitions;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Exceptions;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.RenderingEngine;
using ESRI.ArcGIS.ADF.Web.UI.WebControls.Tools;

namespace TTG.Web
{
    /// <summary>
    /// communityDetails 的摘要说明
    /// </summary>
    public class communityDetails : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "UTF-8";
            String p = context.Request["province"];
            String c = context.Request["county"];
            String comm = context.Request["community"];
            String tag = context.Request["tag"];
            json1.jsonTools jsonFactory;
            if (isPrivacy())
            {
                jsonFactory = new json1.mainToJson();
                if (p != null && p != "")
                {
                    jsonFactory = new json1.provinceToJson(p);
                    if (c != null && c != "")
                    {
                        jsonFactory = new json1.countyToJson(p, c);
                        if (comm != null && comm != "")
                        {
                            jsonFactory = new json1.communityToJson(p, c, comm);
                            try
                            {
                                if (tag != null)
                                {
                                    int t = Convert.ToInt32(tag);
                                    //工厂
                                    jsonFactory = getJson(t, p, c, comm);
                                }
                            }
                            catch
                            {
                                context.Response.Write("标签信息有误");
                            }
                            
                        }
                        
                    }
                    
                }

                context.Response.Write(jsonFactory.getResult());

            }
            else
            {
                context.Response.Write("权限不足");
            }

        }
        private json1.jsonTools getJson(int tag,String province,String county,String community)
        {
            json1.jsonTools json=null;
            switch (tag)
            {
                case 0:
                    json = new json1.basicFacilityToJson(province,county,community);//基础设施
                    break;
                case 1:
                    json = new json1.housesafetyToJson(province,county,community);//住房安全
                    break;
                case 2:
                    json = new json1.environmentToJson(province,county,community);//环保设施
                    break;
                case 3:
                    json = new json1.businessToJson(province,county,community);//营商环境
                    break;
                case 4:
                    json = new json1.publicServiceToJson(province,county,community);//公共服务设施
                    break;
                case 5:
                    json = new json1.projectToJson(province, county, community);
                    break;
                default:
                    json = new json1.communityToJson(province, county, community);
                    break;
            }
            return json;
        }


        /// <summary>
        /// 判断用户权限,需先获取用户信息
        /// TODO 应有参数待定,需前端配合
        /// </summary>
        /// <returns></returns>
        private bool isPrivacy()
        {

            return true;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}