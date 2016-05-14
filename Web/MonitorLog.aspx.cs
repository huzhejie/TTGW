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
    public partial class MonitorLog : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.excel_status DEXCEL = new DAL.TTGWeb.excel_status();
        TTG.DAL.TTGWeb.user DUSER = new DAL.TTGWeb.user();
        public string investigator_id = "";
        /// <summary>
        /// 初始化页面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            investigator_id = Session["userId"].ToString();
            if (!IsPostBack)
            {
                //初始化检测日志
                DAL.TTGWeb.monitor_log dtm = new DAL.TTGWeb.monitor_log();
                int recordCount = dtm.GetRecordCount("investigator_id='" + investigator_id + "'");
                AspNetPager1.RecordCount = recordCount;
                AspNetPager1.PageSize = 18;
                DataSet ds = dtm.GetListByPage("investigator_id='" + investigator_id + "'", 1, 18);
                RepeaterLog.DataSource = ds;
                RepeaterLog.DataBind();
                RepeaterLog.DataBind();
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
            DAL.TTGWeb.monitor_log dtm = new DAL.TTGWeb.monitor_log();
            DataSet ds = dtm.GetListByPage("investigator_id='" + investigator_id + "'", StartIndex, EndIndex);
            RepeaterLog.DataSource = ds;
            RepeaterLog.DataBind();

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
        /// 把ID翻译为name
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string toName(string str)
        {
            DataSet ds = DUSER.GetOneName(str);
            return ds.Tables[0].Rows[0][0].ToString();
        }

    }
}
