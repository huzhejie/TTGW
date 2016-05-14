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
    public partial class allAnno : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.notification_info DNOI = new DAL.TTGWeb.notification_info();
        TTG.Model.TTGWeb.notification_info MNOI = new Model.TTGWeb.notification_info();
        public string publisher = "";
        public string anntype = "";
        public string time = "";
        public string selectTime = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Search.Attributes.Add("OnClick", "return deliver()");

            //计算数据总量得到分页数量
            AspNetPager1.PageSize = 14;
            if (!IsPostBack)
            {
                DataSet dsDepart = DNOI.GetDepart("");
                this.DropDownListPublisher.DataSource = dsDepart.Tables[0];
                this.DropDownListPublisher.DataTextField = "nf_depart";
                this.DropDownListPublisher.DataBind();
                this.DropDownListPublisher.Items.Insert(0, new ListItem("所有发布单位", ""));
                searchNotification();
                
            }
          
        }

        /// <summary>
        /// //查找通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Search_Click(object sender, EventArgs e)
        {
            searchNotification();
        }

        /// <summary>
        /// 按条件查找通知公告
        /// </summary>
        public void searchNotification()
        {
            publisher = DropDownListPublisher.SelectedValue;
            anntype = DropDownListType.SelectedValue;
            time = demoTime.Value;
            if (publisher == "" || publisher == "所有发布单位")
            {
                publisher = "";
            }

            if (anntype == "" || anntype == "所有公告")
            {
                anntype = "";
            }
            if (time == "")
            {
                selectTime = "";
            }
            else
            {
                selectTime = time;
            }
            int recordCount = DNOI.GetRecordCount(anntype, publisher, selectTime);
            AspNetPager1.RecordCount = recordCount;
            AspNetPager1.CurrentPageIndex = 1;
            DataSet dsInf = DNOI.GetListByPage(anntype, publisher, selectTime, 1, 14);
            //这里添加首次需要加载的12条数据
            //综合帮扶信息数据
            this.RepeaterInf.DataSource = dsInf;
            this.RepeaterInf.DataBind();
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
        ///  //删除通知公告
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void RepeaterInf_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "d")
            {
                int nf_id = Convert.ToInt32(e.CommandArgument.ToString());
                DNOI.Delete(nf_id);
                searchNotification();

            }
            else if (e.CommandName == "m")
            {
                string a = e.CommandArgument.ToString();
                Response.Redirect("EditAnnounce.aspx?nfid=" + a);
                //Response.Write("<script language='javascript'>window.open('LeaderIndex.aspx');</script>");
                // ClientScript.RegisterStartupScript(ClientScript.GetType(), "mysecscript", "<script>window.open('LeaderIndex.aspx');</script>");

            }
        }


        /// <summary>
        ///  //分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            int StartIndex = AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager1.PageSize - 1;
            publisher = DropDownListPublisher.SelectedValue;
            anntype = DropDownListType.SelectedValue;
            time = demoTime.Value;
            if (publisher == "" || publisher == "所有发布单位")
            {
                publisher = "";
            }

            if (anntype == "" || anntype == "所有公告")
            {
                anntype = "";
            }
            if (time == "")
            {
                selectTime = "";
            }
            else
            {
                selectTime = time;
            }
            int recordCount = DNOI.GetRecordCount(anntype, publisher, selectTime);
            AspNetPager1.RecordCount = recordCount;
            DataSet dsInf = DNOI.GetListByPage(anntype, publisher, selectTime, StartIndex, EndIndex);
            this.RepeaterInf.DataSource = dsInf;
            this.RepeaterInf.DataBind();

        }
    }
}