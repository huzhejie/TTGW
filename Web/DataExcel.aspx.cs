using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TTG.Web
{
    public partial class DataExcel : System.Web.UI.Page
    {
        public string strNewPath;
        public string title;
        public string filename;
        public string invesId;
        public string communityId;
        TTG.DAL.TTGWeb.Community_Base DCB = new DAL.TTGWeb.Community_Base();
        TTG.DAL.TTGWeb.excel_status DES = new DAL.TTGWeb.excel_status();
        TTG.Model.TTGWeb.excel_status MES = new Model.TTGWeb.excel_status();
        protected void Page_Load(object sender, EventArgs e)
        {
            filename = Request["officeFile"].ToString();
            communityId = Request["comId"].ToString();
            DataSet ds = DCB.getCommunityInfo(communityId);
            string communityName = ds.Tables[0].Rows[0]["community_name"].ToString();
            string communityPro = ds.Tables[0].Rows[0]["community_province"].ToString();
            string communityCou = ds.Tables[0].Rows[0]["community_county"].ToString();
            strNewPath = "http://localhost:8878/数据表/" + communityPro + "/" + communityCou + "/" + communityCou + DateTime.Now.Year + "/" + communityId + communityName + "/" + filename;
            string strFileType = System.IO.Path.GetExtension(filename).ToString().ToLower();
            title = filename.Substring(0, filename.Length - strFileType.Length);
            Label1.Text = title;
            filein.Text = communityName + "(" + communityId + ")" + title;
            invesId = Request["invesId"].ToString();
        }
    }
}