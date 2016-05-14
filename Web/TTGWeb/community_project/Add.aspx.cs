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
namespace TTG.Web.TTGWeb.community_project
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcounty_name.Text.Trim().Length==0)
			{
				strErr+="county_name不能为空！\\n";	
			}
			if(this.txtproject_id.Text.Trim().Length==0)
			{
				strErr+="project_id不能为空！\\n";	
			}
			if(this.txtproject_name.Text.Trim().Length==0)
			{
				strErr+="project_name不能为空！\\n";	
			}
			if(this.txtproject_category.Text.Trim().Length==0)
			{
				strErr+="project_category不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtproject_add_time.Text))
			{
				strErr+="project_add_time格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtproject_total_investment.Text))
			{
				strErr+="project_total_investment格式错误！\\n";	
			}
			if(this.txtproject_proprietor.Text.Trim().Length==0)
			{
				strErr+="project_proprietor不能为空！\\n";	
			}
			if(this.txtplan_to_bulid.Text.Trim().Length==0)
			{
				strErr+="plan_to_bulid不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtbiding_finish_time.Text))
			{
				strErr+="biding_finish_time格式错误！\\n";	
			}
			if(this.txtcontract_period.Text.Trim().Length==0)
			{
				strErr+="contract_period不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtproject_start_time.Text))
			{
				strErr+="project_start_time格式错误！\\n";	
			}
			if(this.txtnot_started_reason_analysis.Text.Trim().Length==0)
			{
				strErr+="not_started_reason_analysis不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcomplete_time.Text))
			{
				strErr+="complete_time格式错误！\\n";	
			}
			if(this.txtproject_delay_reason_analysis.Text.Trim().Length==0)
			{
				strErr+="project_delay_reason_analysis不能为空！\\n";	
			}
			if(this.txtif_major_quality_or_security_accident_happened.Text.Trim().Length==0)
			{
				strErr+="if_major_quality_or_security_accident_happened不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtproject_complete_acceptance_time.Text))
			{
				strErr+="project_complete_acceptance_time格式错误！\\n";	
			}
			if(this.txtcomplete_acceptance_quality_level.Text.Trim().Length==0)
			{
				strErr+="complete_acceptance_quality_level不能为空！\\n";	
			}
			if(this.txtif_transfer.Text.Trim().Length==0)
			{
				strErr+="if_transfer不能为空！\\n";	
			}
			if(this.txtproject_community_correlation_description.Text.Trim().Length==0)
			{
				strErr+="project_community_correlation_description不能为空！\\n";	
			}
			if(this.txtnote_information.Text.Trim().Length==0)
			{
				strErr+="note_information不能为空！\\n";	
			}
			if(this.txtproject_type.Text.Trim().Length==0)
			{
				strErr+="project_type不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txtmajor_quality_or_security_accident.Text.Trim().Length==0)
			{
				strErr+="major_quality_or_security_accident不能为空！\\n";	
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
			if(this.txttciunset9.Text.Trim().Length==0)
			{
				strErr+="tciunset9不能为空！\\n";	
			}
			if(this.txttciunset10.Text.Trim().Length==0)
			{
				strErr+="tciunset10不能为空！\\n";	
			}
			if(this.txttciunset11.Text.Trim().Length==0)
			{
				strErr+="tciunset11不能为空！\\n";	
			}
			if(this.txttciunset12.Text.Trim().Length==0)
			{
				strErr+="tciunset12不能为空！\\n";	
			}
			if(this.txttciunset13.Text.Trim().Length==0)
			{
				strErr+="tciunset13不能为空！\\n";	
			}
			if(this.txttciunset14.Text.Trim().Length==0)
			{
				strErr+="tciunset14不能为空！\\n";	
			}
			if(this.txttciunset15.Text.Trim().Length==0)
			{
				strErr+="tciunset15不能为空！\\n";	
			}
			if(this.txttciunset16.Text.Trim().Length==0)
			{
				strErr+="tciunset16不能为空！\\n";	
			}
			if(this.txttciunset17.Text.Trim().Length==0)
			{
				strErr+="tciunset17不能为空！\\n";	
			}
			if(this.txttciunset18.Text.Trim().Length==0)
			{
				strErr+="tciunset18不能为空！\\n";	
			}
			if(this.txttciunset19.Text.Trim().Length==0)
			{
				strErr+="tciunset19不能为空！\\n";	
			}
			if(this.txttciunset20.Text.Trim().Length==0)
			{
				strErr+="tciunset20不能为空！\\n";	
			}
			if(this.txttciunset21.Text.Trim().Length==0)
			{
				strErr+="tciunset21不能为空！\\n";	
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
			string county_name=this.txtcounty_name.Text;
			string project_id=this.txtproject_id.Text;
			string project_name=this.txtproject_name.Text;
			string project_category=this.txtproject_category.Text;
			DateTime project_add_time=DateTime.Parse(this.txtproject_add_time.Text);
			decimal project_total_investment=decimal.Parse(this.txtproject_total_investment.Text);
			string project_proprietor=this.txtproject_proprietor.Text;
			string plan_to_bulid=this.txtplan_to_bulid.Text;
			DateTime biding_finish_time=DateTime.Parse(this.txtbiding_finish_time.Text);
			string contract_period=this.txtcontract_period.Text;
			DateTime project_start_time=DateTime.Parse(this.txtproject_start_time.Text);
			string not_started_reason_analysis=this.txtnot_started_reason_analysis.Text;
			DateTime complete_time=DateTime.Parse(this.txtcomplete_time.Text);
			string project_delay_reason_analysis=this.txtproject_delay_reason_analysis.Text;
			string if_major_quality_or_security_accident_happened=this.txtif_major_quality_or_security_accident_happened.Text;
			DateTime project_complete_acceptance_time=DateTime.Parse(this.txtproject_complete_acceptance_time.Text);
			string complete_acceptance_quality_level=this.txtcomplete_acceptance_quality_level.Text;
			string if_transfer=this.txtif_transfer.Text;
			string project_community_correlation_description=this.txtproject_community_correlation_description.Text;
			string note_information=this.txtnote_information.Text;
			string project_type=this.txtproject_type.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string major_quality_or_security_accident=this.txtmajor_quality_or_security_accident.Text;
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			string tciunset5=this.txttciunset5.Text;
			string tciunset6=this.txttciunset6.Text;
			string tciunset7=this.txttciunset7.Text;
			string tciunset8=this.txttciunset8.Text;
			string tciunset9=this.txttciunset9.Text;
			string tciunset10=this.txttciunset10.Text;
			string tciunset11=this.txttciunset11.Text;
			string tciunset12=this.txttciunset12.Text;
			string tciunset13=this.txttciunset13.Text;
			string tciunset14=this.txttciunset14.Text;
			string tciunset15=this.txttciunset15.Text;
			string tciunset16=this.txttciunset16.Text;
			string tciunset17=this.txttciunset17.Text;
			string tciunset18=this.txttciunset18.Text;
			string tciunset19=this.txttciunset19.Text;
			string tciunset20=this.txttciunset20.Text;
			string tciunset21=this.txttciunset21.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);

			TTG.Model.TTGWeb.community_project model=new TTG.Model.TTGWeb.community_project();
			model.county_name=county_name;
			model.project_id=project_id;
			model.project_name=project_name;
			model.project_category=project_category;
			model.project_add_time=project_add_time;
			model.project_total_investment=project_total_investment;
			model.project_proprietor=project_proprietor;
			model.plan_to_bulid=plan_to_bulid;
			model.biding_finish_time=biding_finish_time;
			model.contract_period=contract_period;
			model.project_start_time=project_start_time;
			model.not_started_reason_analysis=not_started_reason_analysis;
			model.complete_time=complete_time;
			model.project_delay_reason_analysis=project_delay_reason_analysis;
			model.if_major_quality_or_security_accident_happened=if_major_quality_or_security_accident_happened;
			model.project_complete_acceptance_time=project_complete_acceptance_time;
			model.complete_acceptance_quality_level=complete_acceptance_quality_level;
			model.if_transfer=if_transfer;
			model.project_community_correlation_description=project_community_correlation_description;
			model.note_information=note_information;
			model.project_type=project_type;
			model.statistics_date=statistics_date;
			model.major_quality_or_security_accident=major_quality_or_security_accident;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.tciunset5=tciunset5;
			model.tciunset6=tciunset6;
			model.tciunset7=tciunset7;
			model.tciunset8=tciunset8;
			model.tciunset9=tciunset9;
			model.tciunset10=tciunset10;
			model.tciunset11=tciunset11;
			model.tciunset12=tciunset12;
			model.tciunset13=tciunset13;
			model.tciunset14=tciunset14;
			model.tciunset15=tciunset15;
			model.tciunset16=tciunset16;
			model.tciunset17=tciunset17;
			model.tciunset18=tciunset18;
			model.tciunset19=tciunset19;
			model.tciunset20=tciunset20;
			model.tciunset21=tciunset21;
			model.check_status=check_status;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.community_project bll=new TTG.BLL.TTGWeb.community_project();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
