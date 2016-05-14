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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnf_id.Text.Trim().Length==0)
			{
				strErr+="nf_id不能为空！\\n";	
			}
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
			string nf_id=this.txtnf_id.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
