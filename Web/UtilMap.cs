using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
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
    ///UtilMap 的摘要说明
    /// </summary>
    public class UtilMap
    {
        /// <summary>
        /// 根据传入的条件对特定图层进行查询
        /// </summary>
        /// <param name="whereClause">查询字符串</param>
        /// <param name="layName">图层名称</param>
        /// <param name="map">地图控件</param>
        /// <returns>查询的结果</returns>
        public static DataTable Search(string whereClause, string layName, ESRI.ArcGIS.ADF.Web.UI.WebControls.Map map)
        {
            DataTable table = new DataTable();
            //获得这个地图支持的所有功能列表
            IEnumerable func_enum = map.GetFunctionalities();

            //对所有的功能列表进行遍历操作
            foreach (ESRI.ArcGIS.ADF.Web.DataSources.IGISFunctionality igisFunc in func_enum)
            {
                //获取该功能对应的资源并且判断该资源是否是用来绘制上层图形的，如果是就跳过
                ESRI.ArcGIS.ADF.Web.DataSources.IGISResource igisResource = igisFunc.Resource;
                if (igisResource.Name == "Buffer")//绘制图形的图层名为Buffer
                    continue;

                //判断该资源是否支持查询操作
                bool support = false;
                support = igisResource.SupportsFunctionality(typeof(ESRI.ArcGIS.ADF.Web.DataSources.IQueryFunctionality));

                //如果该功能支持查询操作就进行查询
                if (support)
                {
                    //根据该资源创建出实现查询功能的接口
                    ESRI.ArcGIS.ADF.Web.DataSources.IQueryFunctionality iqFunc =
                        (ESRI.ArcGIS.ADF.Web.DataSources.IQueryFunctionality)igisResource.CreateFunctionality(
                        typeof(ESRI.ArcGIS.ADF.Web.DataSources.IQueryFunctionality), null);

                    //获得该资源的所有图层名称和ID
                    string[] lids;
                    string[] lnames;
                    iqFunc.GetQueryableLayers(null, out lids, out lnames);

                    //创建查询的条件
                    ESRI.ArcGIS.ADF.Web.SpatialFilter spatialFilter = new ESRI.ArcGIS.ADF.Web.SpatialFilter();
                    spatialFilter.ReturnADFGeometries = true;
                    spatialFilter.MaxRecords = 10000000;
                    spatialFilter.WhereClause = whereClause; //查询的字符串条件就在之类设置

                    //确定对应图层名字的ID
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

                    //利用查询功能接口的函数进行结果查询
                    table = iqFunc.Query(null, lids[index], spatialFilter);
                    return table;
                }
            }

            return null;
        }

        /// <summary>
        /// 通过一个geometry对地图进行查询
        /// </summary>
        /// <param name="geomety">进行查询的geometry</param>
        /// <param name="map">要查询的地图</param>
        /// <param name="layName">针对的图层</param>
        /// <returns>数据集合</returns>
        public static DataTable QueryByGeometry(ESRI.ArcGIS.ADF.Web.Geometry.Geometry geomety, ESRI.ArcGIS.ADF.Web.UI.WebControls.Map map, string layName)
        {
            //用于返回结果的table
            DataTable table = null;

            IEnumerable func_enum = map.GetFunctionalities();


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
                    spatialFilter.Geometry = geomety;

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
                    return table;
                }
            }

            return null;

        }
    }
}