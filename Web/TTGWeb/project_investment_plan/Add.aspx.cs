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
namespace TTG.Web.TTGWeb.project_investment_plan
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtproject_id.Text.Trim().Length==0)
			{
				strErr+="project_id不能为空！\\n";	
			}
			if(this.txtproject_name.Text.Trim().Length==0)
			{
				strErr+="project_name不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtinvestment_plan.Text))
			{
				strErr+="investment_plan格式错误！\\n";	
			}
			if(this.txtinvestment_year.Text.Trim().Length==0)
			{
				strErr+="investment_year不能为空！\\n";	
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
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
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
			string project_id=this.txtproject_id.Text;
			string project_name=this.txtproject_name.Text;
			decimal investment_plan=decimal.Parse(this.txtinvestment_plan.Text);
			string investment_year=this.txtinvestment_year.Text;
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);

			TTG.Model.TTGWeb.project_investment_plan model=new TTG.Model.TTGWeb.project_investment_plan();
			model.project_id=project_id;
			model.project_name=project_name;
			model.investment_plan=investment_plan;
			model.investment_year=investment_year;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.check_status=check_status;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.project_investment_plan bll=new TTG.BLL.TTGWeb.project_investment_plan();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
