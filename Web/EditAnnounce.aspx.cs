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
    
    public partial class EditAnnounce : System.Web.UI.Page
    {
        public int nf_id;
        TTG.DAL.TTGWeb.notification_info DNOI = new DAL.TTGWeb.notification_info();
        TTG.Model.TTGWeb.notification_info MNOI = new Model.TTGWeb.notification_info();

        /// <summary>
        /// 加载通知公告内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            nf_id = Convert.ToInt32(Request["nfid"]);
            if (!IsPostBack)
            {
                DataSet ds = DNOI.GetOne(nf_id);
                Texttitle.Value = ds.Tables[0].Rows[0][1].ToString();
                DropDownListPName.SelectedValue = ds.Tables[0].Rows[0][5].ToString();
                publisherName.Value = ds.Tables[0].Rows[0][4].ToString();
                Texthide.Value = ds.Tables[0].Rows[0][2].ToString();
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>setUMContent();</script>");
            }
            modifyBtn.Attributes.Add("OnClick", "return saveText()");
        }


        /// <summary>
        /// 更改内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void modifyBtn_Click(object sender, EventArgs e)
        {
            string err="";
            //获取标题
            if (Texttitle.Value != "")
            {
                MNOI.nf_title = Texttitle.Value;
            }
            else
            {
                err += "标题不能为空";
            }
         
            MNOI.nf_content = mytextu.Value;
        
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
                MNOI.nf_id = nf_id;
                //更改
                DNOI.Update(MNOI);
                Response.Write("<script>alert('修改成功!')</script>");
                //更改之后重新加载通知内容
                DataSet ds = DNOI.GetOne(nf_id);
                Texttitle.Value = ds.Tables[0].Rows[0][1].ToString();
                DropDownListPName.SelectedValue = ds.Tables[0].Rows[0][5].ToString();
                publisherName.Value = ds.Tables[0].Rows[0][4].ToString();
                Texthide.Value = ds.Tables[0].Rows[0][2].ToString();
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>setUMContent();</script>");

                modifyBtn.Attributes.Add("OnClick", "return saveText()");
            }
            else
            {
                Response.Write("<script>alert('修改失败，请重试！')</script>");
            }
            
        }
    }
}