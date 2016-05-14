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
using System.IO;


namespace TTG.Web
{
    public partial class Index : System.Web.UI.Page
    {
        public int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.TTGWeb.notification_info DNI = new DAL.TTGWeb.notification_info();
            DAL.TTGWeb.file DFILE = new DAL.TTGWeb.file();
            if (!IsPostBack)
            {
                //所有信息
                DataSet dsNew = DNI.GetList(11, "综合帮扶信息");
                this.RepeaterNew.DataSource = dsNew;
                this.RepeaterNew.DataBind();


                //综合帮扶信息            
                DataSet dshelpinfo = DNI.GetList(8, "综合帮扶信息");
                this.RepeaterAidInf.DataSource = dshelpinfo;
                this.RepeaterAidInf.DataBind();


                //现场检测动态
                DataSet dsfileddetec = DNI.GetList(8, "现场检测动态");
                this.RepeaterFielddetection.DataSource = dsfileddetec;
                this.RepeaterFielddetection.DataBind();

                //小区帮扶标准规范
                DataSet dsaidstandard = DFILE.GetList(8, "小区帮扶标准规范");
                this.RepeaterAidStandard.DataSource = dsaidstandard;
                this.RepeaterAidStandard.DataBind();

                //居住环境规程规范
                DataSet dslivecondition = DFILE.GetList(8, "居住环境规程规范");
                this.RepeaterLiveCondition.DataSource = dslivecondition;
                this.RepeaterLiveCondition.DataBind();

                //区县培训及就业信息
                DataSet dstrainingrecruitment = DNI.GetList(16, "区县培训及就业信息");
                this.RepeaterTrainingRecruitment.DataSource = dstrainingrecruitment;
                this.RepeaterTrainingRecruitment.DataBind();
            }
        }

        /// <summary>
        /// 截取字符串
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
        /// 下载小区帮扶标准规范
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void RepeaterAidStandard_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "d")
            {
                string loadname = e.CommandArgument.ToString();

                //下载文件
                string fileName = loadname;//客户端保存的文件名
                string filePath = Server.MapPath("~/主页可下载文件/小区帮扶标准规范/" + fileName);//路径  

                //以字符流的形式下载文件
                FileStream fs = new FileStream(filePath, FileMode.Open);
                if (fs.Length != 0)
                {
                    byte[] bytes = new byte[(int)fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                    fs.Close();
                    Response.ContentType = "application/octet-stream";
                    //通知浏览器下载文件而不是打开
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
                    Response.BinaryWrite(bytes);
                    Response.Flush();
                    Response.End();
                }
            }
        }



        /// <summary>
        /// 下载居住环境规程规范
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void RepeaterLiveCondition_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "d")
            {
                string loadname = e.CommandArgument.ToString();
                //下载文件
                string fileName = loadname;//客户端保存的文件名
                string filePath = Server.MapPath("~/主页可下载文件/小区帮扶标准规范/" + fileName);//路径  
                //以字符流的形式下载文件
                FileStream fs = new FileStream(filePath, FileMode.Open);
                if (fs.Length != 0)
                {
                    byte[] bytes = new byte[(int)fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                    fs.Close();
                    Response.ContentType = "application/octet-stream";
                    //通知浏览器下载文件而不是打开
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
                    Response.BinaryWrite(bytes);
                    Response.Flush();
                    Response.End();
                }

            }
        }
    }
}