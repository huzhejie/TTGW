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
    public partial class allFiles : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.file DFI = new DAL.TTGWeb.file();
        TTG.Model.TTGWeb.file MTF = new Model.TTGWeb.file();
        protected void Page_Load(object sender, EventArgs e)
        {
            AspNetPager2.PageSize = 14;
            if (!IsPostBack) {
                searchFile();
            }
        }
        /// <summary>
        /// //查找文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SearchFileBtn_Click(object sender, EventArgs e)
        {
            searchFile();
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

        /// <summary>
        /// //删除文件
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void Repeaterfile_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "d")
            {
                int fileid = Convert.ToInt32(e.CommandArgument.ToString());
                DFI.Delete(fileid);
                searchFile();

            }
        }


        /// <summary>
        /// 按条件查找文件
        /// </summary>
        public void searchFile()
        {
            string filetype = DropDownListFileType.SelectedValue;
            if (filetype == "" || filetype.Equals("所有文件"))
            {
                filetype = "";
            }
            int recordCount = DFI.GetRecordCount(filetype);
            AspNetPager2.RecordCount = recordCount;
            AspNetPager2.CurrentPageIndex = 1;
            DataSet dsFile = DFI.GetListByPage(filetype, 1, 14);
            this.Repeaterfile.DataSource = dsFile;
            this.Repeaterfile.DataBind();
        }

        /// <summary>
        ///  //分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager2_PageChanged(object sender, EventArgs e)
        {

            int StartIndex = AspNetPager2.PageSize * (AspNetPager2.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager2.PageSize - 1;
            string filetype = DropDownListFileType.SelectedValue;
            if (filetype == "" || filetype.Equals("所有文件"))
            {
                filetype = "";
            }
            int recordCount = DFI.GetRecordCount(filetype);
            AspNetPager2.RecordCount = recordCount;
            DataSet dsFile = DFI.GetListByPage(filetype, StartIndex, EndIndex);
            this.Repeaterfile.DataSource = dsFile;
            this.Repeaterfile.DataBind();

        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void uploadFileBtn_Click(object sender, EventArgs e)
        {
            string severpath = "";
            string filename = "";
            string fileaddress = "";
            string fileExtension = "";
            if (FileUploadForFile.HasFile)
            {
                string filetype = DropDownListupType.SelectedValue;
                if (filetype != "" && !filetype.Equals("文件类型"))
                {
                    if (filetype == "居住环境规程规范")
                    {
                        severpath = Server.MapPath("~/主页可下载文件/居住环境规程规范");
                        fileExtension = System.IO.Path.GetExtension(FileUploadForFile.FileName).ToLower();
                        fileaddress = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + System.IO.Path.GetFileNameWithoutExtension(FileUploadForFile.PostedFile.FileName) + fileExtension;
                        FileUploadForFile.SaveAs(severpath + "\\" + fileaddress);//上传文件
                        filename = FileUploadForFile.FileName;
                        MTF.file_name = filename;
                        MTF.file_address = fileaddress;
                        MTF.file_type = filetype;
                        MTF.time = DateTime.Now;
                        DFI.Add(MTF);
                        //Response.Redirect("sysManage.aspx");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>show(7);</script>");
                        searchFile();
                    }
                    else if (filetype == "小区帮扶标准规范")
                    {
                        severpath = Server.MapPath("~/主页可下载文件/小区帮扶标准规范");
                        fileExtension = System.IO.Path.GetExtension(FileUploadForFile.FileName).ToLower();
                        fileaddress = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + System.IO.Path.GetFileNameWithoutExtension(FileUploadForFile.PostedFile.FileName) + fileExtension;
                        FileUploadForFile.SaveAs(severpath + "\\" + fileaddress);//上传文件
                        filename = FileUploadForFile.FileName;
                        MTF.file_name = filename;
                        MTF.file_address = fileaddress;
                        MTF.file_type = filetype;
                        MTF.time = DateTime.Now;
                        DFI.Add(MTF);
                        //Response.Redirect("sysManage.aspx");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>show(7);</script>");
                        searchFile();
                    }
                    else
                    {
                        Response.Write("<scropt>alert('上传出错！')</script>");
                    }

                }

            }

        }
    }
}