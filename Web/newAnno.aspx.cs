using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTG.Web
{
    public partial class newAnno : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.notification_info DNOI = new DAL.TTGWeb.notification_info();
        TTG.Model.TTGWeb.notification_info MNOI = new Model.TTGWeb.notification_info();
        public string err = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            publishBtn.Attributes.Add("OnClick", "return saveText()");
        }


        /// <summary>
        ///  //发布通知公告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void publishBtn_Click(object sender, EventArgs e)
        {
            //获取标题
            if (Texttitle.Value != "")
            {
                MNOI.nf_title = Texttitle.Value;
            }
            else
            {
                err += "标题不能为空";
            }
            //获取公告内容
            if (mytext.Value != "")
            {

                MNOI.nf_content = mytext.Value;

            }
            else
            {
                err += "内容不能为空";
            }
            //公告类型
            if (DropDownListPName.SelectedValue == "所有公告")
            {
                err += "公告类型不能为所有公告";
            }
            else
            {
                MNOI.nf_type = DropDownListPName.SelectedValue;
            }

            //发布单位
            if (publisherName.Value != "")
            {
                MNOI.nf_depart = publisherName.Value;
            }
            else
            {
                err += "发布单位不能为空";
            }
            if (string.IsNullOrEmpty(err.Trim()))
            {
                MNOI.nf_time = DateTime.Now;
                MNOI.nf_image = null;
                DNOI.Add(MNOI);


            }
            Response.Redirect("sysManage.aspx");
            //Texttitle.Value = "";
            //mytext.Value = "";
            //DropDownListPName.SelectedValue="所有公告";
            //publisherName.Value = "";
            //ClientScript.RegisterStartupScript(ClientScript.GetType(), "showscript", "<script>show(1);</script>");
        }
    }
}