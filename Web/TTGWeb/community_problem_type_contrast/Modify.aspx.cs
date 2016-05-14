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
namespace TTG.Web.TTGWeb.community_problem_type_contrast
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string question_content= Request.Params["id"];
					ShowInfo(question_content);
				}
			}
		}
			
	private void ShowInfo(string question_content)
	{
		TTG.BLL.TTGWeb.community_problem_type_contrast bll=new TTG.BLL.TTGWeb.community_problem_type_contrast();
		TTG.Model.TTGWeb.community_problem_type_contrast model=bll.GetModel(question_content);
		this.lblquestion_content.Text=model.question_content;
		this.txttable_belong_to.Text=model.table_belong_to;
		this.txtunit.Text=model.unit;
		this.txtproblem_nature.Text=model.problem_nature;
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txttciunset1.Text=model.tciunset1;
		this.txttciunset2.Text=model.tciunset2;
		this.txttciunset3.Text=model.tciunset3;
		this.txttciunset4.Text=model.tciunset4;
		this.txtlock_tables.Text=model.lock_tables.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txttable_belong_to.Text.Trim().Length==0)
			{
				strErr+="table_belong_to不能为空！\\n";	
			}
			if(this.txtunit.Text.Trim().Length==0)
			{
				strErr+="unit不能为空！\\n";	
			}
			if(this.txtproblem_nature.Text.Trim().Length==0)
			{
				strErr+="problem_nature不能为空！\\n";	
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
			string question_content=this.lblquestion_content.Text;
			string table_belong_to=this.txttable_belong_to.Text;
			string unit=this.txtunit.Text;
			string problem_nature=this.txtproblem_nature.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);


			TTG.Model.TTGWeb.community_problem_type_contrast model=new TTG.Model.TTGWeb.community_problem_type_contrast();
			model.question_content=question_content;
			model.table_belong_to=table_belong_to;
			model.unit=unit;
			model.problem_nature=problem_nature;
			model.check_status=check_status;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.community_problem_type_contrast bll=new TTG.BLL.TTGWeb.community_problem_type_contrast();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
