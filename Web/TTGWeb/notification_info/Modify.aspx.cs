using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace TTG.Web.TTGWeb.notification_info
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string nf_id= Request.Params["id"];
					ShowInfo(nf_id);
				}
			}
		}
			
	private void ShowInfo(string nf_id)
	{
		TTG.BLL.TTGWeb.notification_info bll=new TTG.BLL.TTGWeb.notification_info();
		TTG.Model.TTGWeb.notification_info model=bll.GetModel(nf_id);
		this.lblnf_id.Text=model.nf_id;
		this.txtnf_title.Text=model.nf_title;
		this.txtnf_content.Text=model.nf_content;
		this.txtnf_time.Text=model.nf_time.ToString();
		this.txtnf_depart.Text=model.nf_depart;
		this.txtnf_type.Text=model.nf_type;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnf_title.Text.Trim().Length==0)
			{
				strErr+="nf_title不能为空！\\n";	
			}
			if(this.txtnf_content.Text.Trim().Length==0)
			{
				strErr+="nf_content不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtnf_time.Text))
			{
				strErr+="nf_time格式错误！\\n";	
			}
			if(this.txtnf_depart.Text.Trim().Length==0)
			{
				strErr+="nf_depart不能为空！\\n";	
			}
			if(this.txtnf_type.Text.Trim().Length==0)
			{
				strErr+="nf_type不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string nf_id=this.lblnf_id.Text;
			string nf_title=this.txtnf_title.Text;
			string nf_content=this.txtnf_content.Text;
			DateTime nf_time=DateTime.Parse(this.txtnf_time.Text);
			string nf_depart=this.txtnf_depart.Text;
			string nf_type=this.txtnf_type.Text;


			TTG.Model.TTGWeb.notification_info model=new TTG.Model.TTGWeb.notification_info();
			model.nf_id=nf_id;
			model.nf_title=nf_title;
			model.nf_content=nf_content;
			model.nf_time=nf_time;
			model.nf_depart=nf_depart;
			model.nf_type=nf_type;

			TTG.BLL.TTGWeb.notification_info bll=new TTG.BLL.TTGWeb.notification_info();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
