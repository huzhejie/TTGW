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
    /// regionList 的摘要说明
    /// </summary>
    public class regionList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "UTF-8";
            String p = context.Request["province"];
            String c = context.Request["county"];
            json1.regionListToJson tl2json = new json1.regionListToJson(p,c);
            context.Response.Write(tl2json.getResult());

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