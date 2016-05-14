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
    public partial class SingleListjz : System.Web.UI.Page
    {
        DAL.TTGWeb.notification_info DNI = new DAL.TTGWeb.notification_info();
        DAL.TTGWeb.file DFILE = new DAL.TTGWeb.file();
        protected void Page_Load(object sender, EventArgs e)
        {
            int recordCount = DFILE.GetRecordCount("居住环境规程规范");
            AspNetPager1.RecordCount = recordCount;
            AspNetPager1.PageSize = 18;
            if (!IsPostBack)
            {

                DataSet dsLiveCondition = DFILE.GetListByPage("居住环境规程规范", 1, 18);

                //这里添加首次需要加载的24条数据
                //居住环境规程规范数据
                this.RepeaterLiveCondition.DataSource = dsLiveCondition;
                this.RepeaterLiveCondition.DataBind();
            }
        }

        /// <summary>
        /// 换页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {

            int StartIndex = AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager1.PageSize - 1;
            DataSet dsLiveCondition = DFILE.GetListByPage("居住环境规程规范", StartIndex, EndIndex);
            this.RepeaterLiveCondition.DataSource = dsLiveCondition;
            this.RepeaterLiveCondition.DataBind();
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
       /// 下载文件
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
                string filePath = Server.MapPath("~/主页可下载文件/居住环境规程规范/" + fileName);//路径  
                Response.Redirect("download.aspx?path=" + filePath + "&filename=" + fileName);
               
            }
        }
      
    }
}