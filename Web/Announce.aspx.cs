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

namespace TTG.Web
{
    public partial class Announce : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.notification_info DNI = new DAL.TTGWeb.notification_info();
        /// <summary>
        /// 初始化页面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string nfid = Request["nfid"].ToString();
            int nf_id = Convert.ToInt32(nfid);
            DataSet ds = DNI.GetOne(nf_id);
            ptitle.InnerHtml = ds.Tables[0].Rows[0][1].ToString();
            ptime.InnerHtml = ds.Tables[0].Rows[0][3].ToString();
            //divcontent.InnerHtml = ds.Tables[0].Rows[0][2].ToString();
            Label1.Text = ds.Tables[0].Rows[0][2].ToString();
        }
    }
}