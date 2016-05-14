using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTG.BLL.TTGWeb;
using TTG.Model;
using TTG.DAL.TTGWeb;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TTG.Web
{
    public partial class stantardFiles : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.excel_message DEXCELMS = new DAL.TTGWeb.excel_message();
        TTG.Model.TTGWeb.excel_message MEXCELMS = new Model.TTGWeb.excel_message();
        protected void Page_Load(object sender, EventArgs e)
        {
            AspNetPager3.PageSize = 14;  
            if (!IsPostBack) {
                searchStantardFile();
            }
        }


        /// <summary>
        /// //截取过长的标题
        /// </summary>
        /// <param name="anno"></param>
        /// <returns></returns>
        public string trimanno(string anno)
        {
            if (anno.Length >= 25)
            {
                anno = anno.Substring(0, 25) + "...";
                return anno;
            }
            return anno;
        }

        /// <summary>
        /// //截取过长的标题
        /// </summary>
        /// <param name="anno"></param>
        /// <returns></returns>
        public string trimanno6(string anno)
        {
            if (anno.Length > 6)
            {
                anno = anno.Substring(0, 5) + "...";
                return anno;
            }
            return anno;
        }
        #region 标准表
        /// <summary>
        /// 查找标准表
        /// </summary>
        public void searchStantardFile()
        {
            int recordCount = DEXCELMS.GetRecordCount();
            AspNetPager3.RecordCount = recordCount;
            AspNetPager3.CurrentPageIndex = 1;
            DataSet dsFile = DEXCELMS.GetListByPage(1, 14);
            this.RepeaterStantard.DataSource = dsFile;
            this.RepeaterStantard.DataBind();
        }


        /// <summary>
        /// 标准表分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager3_PageChanged(object sender, EventArgs e)
        {
            int recordCount = DEXCELMS.GetRecordCount();
            AspNetPager3.RecordCount = recordCount;
            int StartIndex = AspNetPager3.PageSize * (AspNetPager3.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager3.PageSize - 1;
            DataSet dsFile = DEXCELMS.GetListByPage(StartIndex, EndIndex);
            this.RepeaterStantard.DataSource = dsFile;
            this.RepeaterStantard.DataBind();

        }

        /// <summary>
        /// 上传标准表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void StantardUplBtn_Click(object sender, EventArgs e)
        {
            string severpath = "";
            if (FileUploadStantard.HasFile)
            {
                MEXCELMS.table_name = System.IO.Path.GetFileNameWithoutExtension(FileUploadStantard.FileName);
                MEXCELMS.table_path = System.IO.Path.GetFileName(FileUploadStantard.FileName);
                bool flag = DEXCELMS.Exists(MEXCELMS);
                if (!flag)
                {
                    severpath = Server.MapPath("~/标准表");
                    FileUploadStantard.SaveAs(severpath + "\\" + MEXCELMS.table_path);//上传文件    

                    DEXCELMS.Add(MEXCELMS);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(UpdatePanel9, UpdatePanel9.GetType(), "", "<script>alert('存在同名文件，如果更改原文件，请先删除！');</script>", false);
                }

            }
            else
            {
                ScriptManager.RegisterStartupScript(UpdatePanel9, UpdatePanel9.GetType(), "", "<script>alert('您还没有选择文件或者选择的文件大小为0K！');</script>", false);
            }
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>show(8);</script>");

            searchStantardFile();
        }
        /// <summary>
        /// 删除标准表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void RepeaterStantard_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "delStantard")
            {
                int fileid = Convert.ToInt32(e.CommandArgument.ToString());
                DEXCELMS.Delete(fileid);
                searchStantardFile();
            }
        }

        #endregion 标准表
    }
}