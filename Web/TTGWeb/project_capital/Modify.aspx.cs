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
namespace TTG.Web.TTGWeb.project_capital
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string project_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					project_id= Request.Params["id0"];
				}
				string furnished_type = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					furnished_type= Request.Params["id1"];
				}
				DateTime time = "";
				if (Request.Params["id2"] != null && Request.Params["id2"].Trim() != "")
				{
					time= Request.Params["id2"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(project_id,furnished_type,time);
			}
		}
			
	private void ShowInfo(string project_id,string furnished_type,DateTime time)
	{
		TTG.BLL.TTGWeb.project_capital bll=new TTG.BLL.TTGWeb.project_capital();
		TTG.Model.TTGWeb.project_capital model=bll.GetModel(project_id,furnished_type,time);
		this.lblproject_id.Text=model.project_id;
		this.txtproject_name.Text=model.project_name;
		this.lblfurnished_type.Text=model.furnished_type;
		this.txttotal_investment.Text=model.total_investment.ToString();
		this.txtTTG_follow_up_work_approved_special_subsidies.Text=model.TTG_follow_up_work_approved_special_subsidies.ToString();
		this.txtplan_counterparts_support_funds.Text=model.plan_counterparts_support_funds.ToString();
		this.txtother_matching_funds.Text=model.other_matching_funds.ToString();
		this.txtother_funds.Text=model.other_funds.ToString();
		this.lbltime.Text=model.time.ToString();
		this.txttciunset1.Text=model.tciunset1;
		this.txttciunset2.Text=model.tciunset2;
		this.txttciunset3.Text=model.tciunset3;
		this.txttciunset4.Text=model.tciunset4;
		this.txttciunset5.Text=model.tciunset5;
		this.txttciunset6.Text=model.tciunset6;
		this.txttciunset7.Text=model.tciunset7;
		this.txttciunset8.Text=model.tciunset8;
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txtlock_tables.Text=model.lock_tables.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtproject_name.Text.Trim().Length==0)
			{
				strErr+="project_name不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txttotal_investment.Text))
			{
				strErr+="total_investment格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTTG_follow_up_work_approved_special_subsidies.Text))
			{
				strErr+="TTG_follow_up_work_approved_special_subsidies格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtplan_counterparts_support_funds.Text))
			{
				strErr+="plan_counterparts_support_funds格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtother_matching_funds.Text))
			{
				strErr+="other_matching_funds格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtother_funds.Text))
			{
				strErr+="other_funds格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttime.Text))
			{
				strErr+="time格式错误！\\n";	
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
			if(this.txttciunset5.Text.Trim().Length==0)
			{
				strErr+="tciunset5不能为空！\\n";	
			}
			if(this.txttciunset6.Text.Trim().Length==0)
			{
				strErr+="tciunset6不能为空！\\n";	
			}
			if(this.txttciunset7.Text.Trim().Length==0)
			{
				strErr+="tciunset7不能为空！\\n";	
			}
			if(this.txttciunset8.Text.Trim().Length==0)
			{
				strErr+="tciunset8不能为空！\\n";	
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
			string project_id=this.lblproject_id.Text;
			string project_name=this.txtproject_name.Text;
			string furnished_type=this.lblfurnished_type.Text;
			decimal total_investment=decimal.Parse(this.txttotal_investment.Text);
			decimal TTG_follow_up_work_approved_special_subsidies=decimal.Parse(this.txtTTG_follow_up_work_approved_special_subsidies.Text);
			decimal plan_counterparts_support_funds=decimal.Parse(this.txtplan_counterparts_support_funds.Text);
			decimal other_matching_funds=decimal.Parse(this.txtother_matching_funds.Text);
			decimal other_funds=decimal.Parse(this.txtother_funds.Text);
			DateTime time=DateTime.Parse(this.txttime.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			string tciunset5=this.txttciunset5.Text;
			string tciunset6=this.txttciunset6.Text;
			string tciunset7=this.txttciunset7.Text;
			string tciunset8=this.txttciunset8.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);


			TTG.Model.TTGWeb.project_capital model=new TTG.Model.TTGWeb.project_capital();
			model.project_id=project_id;
			model.project_name=project_name;
			model.furnished_type=furnished_type;
			model.total_investment=total_investment;
			model.TTG_follow_up_work_approved_special_subsidies=TTG_follow_up_work_approved_special_subsidies;
			model.plan_counterparts_support_funds=plan_counterparts_support_funds;
			model.other_matching_funds=other_matching_funds;
			model.other_funds=other_funds;
			model.time=time;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.tciunset5=tciunset5;
			model.tciunset6=tciunset6;
			model.tciunset7=tciunset7;
			model.tciunset8=tciunset8;
			model.check_status=check_status;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.project_capital bll=new TTG.BLL.TTGWeb.project_capital();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
