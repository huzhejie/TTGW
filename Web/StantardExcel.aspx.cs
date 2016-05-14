using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TTG.Web
{
    public partial class StantardExcel : System.Web.UI.Page
    {
        public string strNewPath;
        public string title;
        public string filename;
        public string communityId;  
        public string communityName;
        public string invesId;
        TTG.DAL.TTGWeb.Community_Base DCB = new DAL.TTGWeb.Community_Base();
        TTG.DAL.TTGWeb.excel_status DES = new DAL.TTGWeb.excel_status();
        TTG.Model.TTGWeb.excel_status MES = new Model.TTGWeb.excel_status();
        protected void Page_Load(object sender, EventArgs e)
        {
            //saveButton.Attributes.Add("OnClick", "return SaveDoc()");
            //得到文件名，加载文件
            filename = Request["officeFile"].ToString();
            communityId = Request["communityId"].ToString();           
            DataSet ds = DCB.getCommunityInfo(communityId);
            string communityName = ds.Tables[0].Rows[0]["community_name"].ToString();
            strNewPath = "http://localhost:8878/标准表/" + filename;
            string strFileType = System.IO.Path.GetExtension(filename).ToString().ToLower();
            title = filename.Substring(0, filename.Length - strFileType.Length);
            Label1.Text = title;
            filein.Text = communityName + "(" + communityId + ")" + title;
            invesId = Session["userId"].ToString();
        }

        /// <summary>
        /// 上传并保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected void saveButton_Click(object sender, EventArgs e)
        //{
        //    ClientScript.RegisterStartupScript(ClientScript.GetType(), "SaveDoc", "<script> SaveDoc();</script>");
        //    DataSet ds = DCB.getCommunityInfo(communityId);
        //    MES.community_id = communityId;
        //    MES.community_name = ds.Tables[0].Rows[0]["community_name"].ToString();
        //    MES.state = 0;
        //    MES.excel_name = filename;
        //    MES.investigator_id = Session["userId"].ToString();
        //    DES.Add(MES);
        //    Response.Write("<script>alert('恭喜，图片上传成功！');</script>");
        //}
    }
}