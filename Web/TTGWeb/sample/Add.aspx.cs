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
namespace TTG.Web.TTGWeb.sample
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcommunity_id.Text.Trim().Length==0)
			{
				strErr+="community_id不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsample_house_num.Text))
			{
				strErr+="sample_house_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsample_family_pop.Text))
			{
				strErr+="sample_family_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsample_labor_force_pop.Text))
			{
				strErr+="sample_labor_force_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsample_employment_lf_pop.Text))
			{
				strErr+="sample_employment_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsample_primary_industry_lf_pop.Text))
			{
				strErr+="sample_primary_industry_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsample_secondary_industry_lf_pop.Text))
			{
				strErr+="sample_secondary_industry_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsample_tertiary_industry_lf_pop.Text))
			{
				strErr+="sample_tertiary_industry_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsample_PCDI.Text))
			{
				strErr+="sample_PCDI格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsample_wages_income.Text))
			{
				strErr+="sample_wages_income格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsample_family_run_pure_income.Text))
			{
				strErr+="sample_family_run_pure_income格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsample_property_income.Text))
			{
				strErr+="sample_property_income格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsample_transfer_income.Text))
			{
				strErr+="sample_transfer_income格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsample_CONSP.Text))
			{
				strErr+="sample_CONSP格式错误！\\n";	
			}
			if(this.txttsunset1.Text.Trim().Length==0)
			{
				strErr+="tsunset1不能为空！\\n";	
			}
			if(this.txttsunset2.Text.Trim().Length==0)
			{
				strErr+="tsunset2不能为空！\\n";	
			}
			if(this.txttsunset3.Text.Trim().Length==0)
			{
				strErr+="tsunset3不能为空！\\n";	
			}
			if(this.txttsunset4.Text.Trim().Length==0)
			{
				strErr+="tsunset4不能为空！\\n";	
			}
			if(this.txttsunset5.Text.Trim().Length==0)
			{
				strErr+="tsunset5不能为空！\\n";	
			}
			if(this.txttsunset6.Text.Trim().Length==0)
			{
				strErr+="tsunset6不能为空！\\n";	
			}
			if(this.txttsunset7.Text.Trim().Length==0)
			{
				strErr+="tsunset7不能为空！\\n";	
			}
			if(this.txttsunset8.Text.Trim().Length==0)
			{
				strErr+="tsunset8不能为空！\\n";	
			}
			if(this.txttsunset9.Text.Trim().Length==0)
			{
				strErr+="tsunset9不能为空！\\n";	
			}
			if(this.txttsunset10.Text.Trim().Length==0)
			{
				strErr+="tsunset10不能为空！\\n";	
			}
			if(this.txttsunset11.Text.Trim().Length==0)
			{
				strErr+="tsunset11不能为空！\\n";	
			}
			if(this.txttsunset12.Text.Trim().Length==0)
			{
				strErr+="tsunset12不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			int sample_house_num=int.Parse(this.txtsample_house_num.Text);
			int sample_family_pop=int.Parse(this.txtsample_family_pop.Text);
			int sample_labor_force_pop=int.Parse(this.txtsample_labor_force_pop.Text);
			int sample_employment_lf_pop=int.Parse(this.txtsample_employment_lf_pop.Text);
			int sample_primary_industry_lf_pop=int.Parse(this.txtsample_primary_industry_lf_pop.Text);
			int sample_secondary_industry_lf_pop=int.Parse(this.txtsample_secondary_industry_lf_pop.Text);
			int sample_tertiary_industry_lf_pop=int.Parse(this.txtsample_tertiary_industry_lf_pop.Text);
			decimal sample_PCDI=decimal.Parse(this.txtsample_PCDI.Text);
			decimal sample_wages_income=decimal.Parse(this.txtsample_wages_income.Text);
			decimal sample_family_run_pure_income=decimal.Parse(this.txtsample_family_run_pure_income.Text);
			decimal sample_property_income=decimal.Parse(this.txtsample_property_income.Text);
			decimal sample_transfer_income=decimal.Parse(this.txtsample_transfer_income.Text);
			decimal sample_CONSP=decimal.Parse(this.txtsample_CONSP.Text);
			string tsunset1=this.txttsunset1.Text;
			string tsunset2=this.txttsunset2.Text;
			string tsunset3=this.txttsunset3.Text;
			string tsunset4=this.txttsunset4.Text;
			string tsunset5=this.txttsunset5.Text;
			string tsunset6=this.txttsunset6.Text;
			string tsunset7=this.txttsunset7.Text;
			string tsunset8=this.txttsunset8.Text;
			string tsunset9=this.txttsunset9.Text;
			string tsunset10=this.txttsunset10.Text;
			string tsunset11=this.txttsunset11.Text;
			string tsunset12=this.txttsunset12.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);

			TTG.Model.TTGWeb.sample model=new TTG.Model.TTGWeb.sample();
			model.community_id=community_id;
			model.sample_house_num=sample_house_num;
			model.sample_family_pop=sample_family_pop;
			model.sample_labor_force_pop=sample_labor_force_pop;
			model.sample_employment_lf_pop=sample_employment_lf_pop;
			model.sample_primary_industry_lf_pop=sample_primary_industry_lf_pop;
			model.sample_secondary_industry_lf_pop=sample_secondary_industry_lf_pop;
			model.sample_tertiary_industry_lf_pop=sample_tertiary_industry_lf_pop;
			model.sample_PCDI=sample_PCDI;
			model.sample_wages_income=sample_wages_income;
			model.sample_family_run_pure_income=sample_family_run_pure_income;
			model.sample_property_income=sample_property_income;
			model.sample_transfer_income=sample_transfer_income;
			model.sample_CONSP=sample_CONSP;
			model.tsunset1=tsunset1;
			model.tsunset2=tsunset2;
			model.tsunset3=tsunset3;
			model.tsunset4=tsunset4;
			model.tsunset5=tsunset5;
			model.tsunset6=tsunset6;
			model.tsunset7=tsunset7;
			model.tsunset8=tsunset8;
			model.tsunset9=tsunset9;
			model.tsunset10=tsunset10;
			model.tsunset11=tsunset11;
			model.tsunset12=tsunset12;
			model.lock_tables=lock_tables;
			model.check_status=check_status;
			model.statistics_date=statistics_date;

			TTG.BLL.TTGWeb.sample bll=new TTG.BLL.TTGWeb.sample();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
