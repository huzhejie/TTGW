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
namespace TTG.Web.TTGWeb.community_problem_finished_contrast_info
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcommunity_problem_content.Text.Trim().Length==0)
			{
				strErr+="community_problem_content不能为空！\\n";	
			}
			if(this.txtcommunity_problem_unit.Text.Trim().Length==0)
			{
				strErr+="community_problem_unit不能为空！\\n";	
			}
			if(this.txtcommunity_finish_content.Text.Trim().Length==0)
			{
				strErr+="community_finish_content不能为空！\\n";	
			}
			if(this.txtcommunity_finish_content_unit.Text.Trim().Length==0)
			{
				strErr+="community_finish_content_unit不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(this.txttciunset1.Text.Trim().Length==0)
			{
				strErr+="tciunset1不能为空！\\n";	
			}
			if(this.txttciunset2.Text.Trim().Length==0)
			{
				strErr+="tciunset2不能为空！\\n";	
			}
			if(this.txttciunset3.Text.Trim().Length==0)
			{
				strErr+="tciunset3不能为空！\\n";	
			}
			if(this.txttciunset4.Text.Trim().Length==0)
			{
				strErr+="tciunset4不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_problem_content=this.txtcommunity_problem_content.Text;
			string community_problem_unit=this.txtcommunity_problem_unit.Text;
			string community_finish_content=this.txtcommunity_finish_content.Text;
			string community_finish_content_unit=this.txtcommunity_finish_content_unit.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);

			TTG.Model.TTGWeb.community_problem_finished_contrast_info model=new TTG.Model.TTGWeb.community_problem_finished_contrast_info();
			model.community_problem_content=community_problem_content;
			model.community_problem_unit=community_problem_unit;
			model.community_finish_content=community_finish_content;
			model.community_finish_content_unit=community_finish_content_unit;
			model.check_status=check_status;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.community_problem_finished_contrast_info bll=new TTG.BLL.TTGWeb.community_problem_finished_contrast_info();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
