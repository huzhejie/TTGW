using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TTG.Web
{
    public partial class ReadOnlyExcel : System.Web.UI.Page
    {

        public string strNewPath="";
        public string title="";
        public string filename="";
        public string communityId="";
        public string fileType = "xls";
        TTG.DAL.TTGWeb.Community_Base DCB = new DAL.TTGWeb.Community_Base();
        TTG.DAL.TTGWeb.excel_status DES = new DAL.TTGWeb.excel_status();
        TTG.Model.TTGWeb.excel_status MES = new Model.TTGWeb.excel_status();
        protected void Page_Load(object sender, EventArgs e)
        {

            filename = Request["officeFile"].ToString();
            string path = filename;
            path = path.Replace(" ", "");
            //获取文件后缀名判断文件类型
            int dotIndex = filename.LastIndexOf(".");
            string fileExtension = filename.Substring(dotIndex + 1);
            
            if (fileExtension == "xlsx" || fileExtension == "xls")
            {
                fileType = "xls";
            }
            else if (fileExtension == "docx" || fileExtension == "doc")
            {
                fileType = "doc";
            }
            else
            {
                Response.Write("<script>alert('文件类型不符合要求');</script>");              
            }

            if (Request["comId"]!=null)
            {
                communityId = Request["comId"].ToString();
                string year = Request["time"].ToString();
                DataSet ds = DCB.getCommunityInfo(communityId);
                string communityName = ds.Tables[0].Rows[0]["community_name"].ToString();
                string communityPro = ds.Tables[0].Rows[0]["community_province"].ToString();
                string communityCou = ds.Tables[0].Rows[0]["community_county"].ToString();
                strNewPath = "http://localhost:8878/数据表/" + communityPro + "/" + communityCou + "/" + communityCou + year + "/" + communityId + communityName + "/" + filename;
            }
            else if (Request["Pro"]!=null)
            {
                string communityPro = Request["Pro"].ToString();
                string communityCou = Request["Cou"].ToString();
                strNewPath = "http://localhost:8878/数据表/" + communityPro + "/" + communityCou + "/" + filename;
            }
            if (Request["dcyId"] != null) {
                string dcyId = Request["dcyId"].ToString();
                strNewPath = "http://localhost:8878/监测日志/" + dcyId + "/" + filename;
            }
            string strFileType = System.IO.Path.GetExtension(filename).ToString().ToLower();
            title = filename.Substring(0, filename.Length - strFileType.Length);
            Label1.Text = title;                   
        }

    }
}