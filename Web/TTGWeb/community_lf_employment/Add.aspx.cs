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
namespace TTG.Web.TTGWeb.community_lf_employment
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
			if(!PageValidate.IsNumber(txtcommunity_total_lf_pop.Text))
			{
				strErr+="community_total_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_student_lf_pop.Text))
			{
				strErr+="community_student_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_age_bet_16_and_29_pop.Text))
			{
				strErr+="community_lf_age_bet_16_and_29_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_age_bet_30_and_39_pop.Text))
			{
				strErr+="community_lf_age_bet_30_and_39_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_age_bet_40_and_49_pop.Text))
			{
				strErr+="community_lf_age_bet_40_and_49_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_age_larger_than_50_pop.Text))
			{
				strErr+="community_lf_age_larger_than_50_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_illiterate_lf_pop.Text))
			{
				strErr+="community_illiterate_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_primary_school_education_lf_pop.Text))
			{
				strErr+="community_primary_school_education_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_middle_school_education_lf_pop.Text))
			{
				strErr+="community_middle_school_education_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_senior_school_education_lf_pop.Text))
			{
				strErr+="community_senior_school_education_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_college_graduate_lf_pop.Text))
			{
				strErr+="community_college_graduate_lf_pop格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_lf_average_education_year.Text))
			{
				strErr+="community_lf_average_education_year格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_with_no_skill_pop.Text))
			{
				strErr+="community_lf_with_no_skill_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_with_junior_skill_pop.Text))
			{
				strErr+="community_lf_with_junior_skill_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_with_medium_grade_skill_pop.Text))
			{
				strErr+="community_lf_with_medium_grade_skill_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_with_senior_skill_pop.Text))
			{
				strErr+="community_lf_with_senior_skill_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_hou_with_no_job_num.Text))
			{
				strErr+="community_hou_with_no_job_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_immigrant_hou_with_no_job_num.Text))
			{
				strErr+="community_immigrant_hou_with_no_job_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lf_having_a_job_pop.Text))
			{
				strErr+="community_lf_having_a_job_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_ai_employee_pop.Text))
			{
				strErr+="community_ai_employee_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_enterprise_employee_pop.Text))
			{
				strErr+="community_enterprise_employee_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_part_time_job_pop.Text))
			{
				strErr+="community_part_time_job_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_migrant_workers_pop.Text))
			{
				strErr+="community_migrant_workers_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_household_management_pop.Text))
			{
				strErr+="community_household_management_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_no_job_pop.Text))
			{
				strErr+="community_no_job_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_have_job_pop.Text))
			{
				strErr+="community_have_job_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_farmer_pop.Text))
			{
				strErr+="community_farmer_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_industrial_employment_pop.Text))
			{
				strErr+="community_industrial_employment_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_buil_industrial_employment_pop.Text))
			{
				strErr+="community_buil_industrial_employment_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_transport_employment_pop.Text))
			{
				strErr+="community_transport_employment_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_whs_and_retail_employment_pop.Text))
			{
				strErr+="community_whs_and_retail_employment_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_catering_accomm_employment_pop.Text))
			{
				strErr+="community_catering_accomm_employment_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_other_service_employment_pop.Text))
			{
				strErr+="community_other_service_employment_pop格式错误！\\n";	
			}
			if(this.txtcommunity_empm_information_platform.Text.Trim().Length==0)
			{
				strErr+="community_empm_information_platform不能为空！\\n";	
			}
			if(this.txtcommunity_entp_supportive_policy.Text.Trim().Length==0)
			{
				strErr+="community_entp_supportive_policy不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_enp_supportive_num.Text))
			{
				strErr+="community_enp_supportive_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_spirited_job_num.Text))
			{
				strErr+="community_public_spirited_job_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcleunset1.Text.Trim().Length==0)
			{
				strErr+="tcleunset1不能为空！\\n";	
			}
			if(this.txttcleunset2.Text.Trim().Length==0)
			{
				strErr+="tcleunset2不能为空！\\n";	
			}
			if(this.txttcleunset3.Text.Trim().Length==0)
			{
				strErr+="tcleunset3不能为空！\\n";	
			}
			if(this.txttcleunset4.Text.Trim().Length==0)
			{
				strErr+="tcleunset4不能为空！\\n";	
			}
			if(this.txttcleunset5.Text.Trim().Length==0)
			{
				strErr+="tcleunset5不能为空！\\n";	
			}
			if(this.txttcleunset6.Text.Trim().Length==0)
			{
				strErr+="tcleunset6不能为空！\\n";	
			}
			if(this.txttcleunset7.Text.Trim().Length==0)
			{
				strErr+="tcleunset7不能为空！\\n";	
			}
			if(this.txttcleunset8.Text.Trim().Length==0)
			{
				strErr+="tcleunset8不能为空！\\n";	
			}
			if(this.txttcleunset9.Text.Trim().Length==0)
			{
				strErr+="tcleunset9不能为空！\\n";	
			}
			if(this.txttcleunset10.Text.Trim().Length==0)
			{
				strErr+="tcleunset10不能为空！\\n";	
			}
			if(this.txttcleunset11.Text.Trim().Length==0)
			{
				strErr+="tcleunset11不能为空！\\n";	
			}
			if(this.txttcleunset12.Text.Trim().Length==0)
			{
				strErr+="tcleunset12不能为空！\\n";	
			}
			if(this.txttcleunset13.Text.Trim().Length==0)
			{
				strErr+="tcleunset13不能为空！\\n";	
			}
			if(this.txttcleunset14.Text.Trim().Length==0)
			{
				strErr+="tcleunset14不能为空！\\n";	
			}
			if(this.txttcleunset15.Text.Trim().Length==0)
			{
				strErr+="tcleunset15不能为空！\\n";	
			}
			if(this.txttcleunset16.Text.Trim().Length==0)
			{
				strErr+="tcleunset16不能为空！\\n";	
			}
			if(this.txttcleunset17.Text.Trim().Length==0)
			{
				strErr+="tcleunset17不能为空！\\n";	
			}
			if(this.txttcleunset18.Text.Trim().Length==0)
			{
				strErr+="tcleunset18不能为空！\\n";	
			}
			if(this.txttcleunset19.Text.Trim().Length==0)
			{
				strErr+="tcleunset19不能为空！\\n";	
			}
			if(this.txttcleunset20.Text.Trim().Length==0)
			{
				strErr+="tcleunset20不能为空！\\n";	
			}
			if(this.txttcleunset21.Text.Trim().Length==0)
			{
				strErr+="tcleunset21不能为空！\\n";	
			}
			if(this.txttcleunset22.Text.Trim().Length==0)
			{
				strErr+="tcleunset22不能为空！\\n";	
			}
			if(this.txttcleunset23.Text.Trim().Length==0)
			{
				strErr+="tcleunset23不能为空！\\n";	
			}
			if(this.txttcleunset24.Text.Trim().Length==0)
			{
				strErr+="tcleunset24不能为空！\\n";	
			}
			if(this.txttcleunset25.Text.Trim().Length==0)
			{
				strErr+="tcleunset25不能为空！\\n";	
			}
			if(this.txttcleunset26.Text.Trim().Length==0)
			{
				strErr+="tcleunset26不能为空！\\n";	
			}
			if(this.txttcleunset27.Text.Trim().Length==0)
			{
				strErr+="tcleunset27不能为空！\\n";	
			}
			if(this.txttcleunset28.Text.Trim().Length==0)
			{
				strErr+="tcleunset28不能为空！\\n";	
			}
			if(this.txttcleunset29.Text.Trim().Length==0)
			{
				strErr+="tcleunset29不能为空！\\n";	
			}
			if(this.txttcleunset30.Text.Trim().Length==0)
			{
				strErr+="tcleunset30不能为空！\\n";	
			}
			if(this.txttcleunset31.Text.Trim().Length==0)
			{
				strErr+="tcleunset31不能为空！\\n";	
			}
			if(this.txttcleunset32.Text.Trim().Length==0)
			{
				strErr+="tcleunset32不能为空！\\n";	
			}
			if(this.txttcleunset33.Text.Trim().Length==0)
			{
				strErr+="tcleunset33不能为空！\\n";	
			}
			if(this.txttcleunset34.Text.Trim().Length==0)
			{
				strErr+="tcleunset34不能为空！\\n";	
			}
			if(this.txttcleunset35.Text.Trim().Length==0)
			{
				strErr+="tcleunset35不能为空！\\n";	
			}
			if(this.txttcleunset36.Text.Trim().Length==0)
			{
				strErr+="tcleunset36不能为空！\\n";	
			}
			if(this.txttcleunset37.Text.Trim().Length==0)
			{
				strErr+="tcleunset37不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			int community_total_lf_pop=int.Parse(this.txtcommunity_total_lf_pop.Text);
			int community_student_lf_pop=int.Parse(this.txtcommunity_student_lf_pop.Text);
			int community_lf_age_bet_16_and_29_pop=int.Parse(this.txtcommunity_lf_age_bet_16_and_29_pop.Text);
			int community_lf_age_bet_30_and_39_pop=int.Parse(this.txtcommunity_lf_age_bet_30_and_39_pop.Text);
			int community_lf_age_bet_40_and_49_pop=int.Parse(this.txtcommunity_lf_age_bet_40_and_49_pop.Text);
			int community_lf_age_larger_than_50_pop=int.Parse(this.txtcommunity_lf_age_larger_than_50_pop.Text);
			int community_illiterate_lf_pop=int.Parse(this.txtcommunity_illiterate_lf_pop.Text);
			int community_primary_school_education_lf_pop=int.Parse(this.txtcommunity_primary_school_education_lf_pop.Text);
			int community_middle_school_education_lf_pop=int.Parse(this.txtcommunity_middle_school_education_lf_pop.Text);
			int community_senior_school_education_lf_pop=int.Parse(this.txtcommunity_senior_school_education_lf_pop.Text);
			int community_college_graduate_lf_pop=int.Parse(this.txtcommunity_college_graduate_lf_pop.Text);
			decimal community_lf_average_education_year=decimal.Parse(this.txtcommunity_lf_average_education_year.Text);
			int community_lf_with_no_skill_pop=int.Parse(this.txtcommunity_lf_with_no_skill_pop.Text);
			int community_lf_with_junior_skill_pop=int.Parse(this.txtcommunity_lf_with_junior_skill_pop.Text);
			int community_lf_with_medium_grade_skill_pop=int.Parse(this.txtcommunity_lf_with_medium_grade_skill_pop.Text);
			int community_lf_with_senior_skill_pop=int.Parse(this.txtcommunity_lf_with_senior_skill_pop.Text);
			int community_hou_with_no_job_num=int.Parse(this.txtcommunity_hou_with_no_job_num.Text);
			int community_immigrant_hou_with_no_job_num=int.Parse(this.txtcommunity_immigrant_hou_with_no_job_num.Text);
			int community_lf_having_a_job_pop=int.Parse(this.txtcommunity_lf_having_a_job_pop.Text);
			int community_ai_employee_pop=int.Parse(this.txtcommunity_ai_employee_pop.Text);
			int community_enterprise_employee_pop=int.Parse(this.txtcommunity_enterprise_employee_pop.Text);
			int community_part_time_job_pop=int.Parse(this.txtcommunity_part_time_job_pop.Text);
			int community_migrant_workers_pop=int.Parse(this.txtcommunity_migrant_workers_pop.Text);
			int community_household_management_pop=int.Parse(this.txtcommunity_household_management_pop.Text);
			int community_no_job_pop=int.Parse(this.txtcommunity_no_job_pop.Text);
			int community_have_job_pop=int.Parse(this.txtcommunity_have_job_pop.Text);
			int community_farmer_pop=int.Parse(this.txtcommunity_farmer_pop.Text);
			int community_industrial_employment_pop=int.Parse(this.txtcommunity_industrial_employment_pop.Text);
			int community_buil_industrial_employment_pop=int.Parse(this.txtcommunity_buil_industrial_employment_pop.Text);
			int community_transport_employment_pop=int.Parse(this.txtcommunity_transport_employment_pop.Text);
			int community_whs_and_retail_employment_pop=int.Parse(this.txtcommunity_whs_and_retail_employment_pop.Text);
			int community_catering_accomm_employment_pop=int.Parse(this.txtcommunity_catering_accomm_employment_pop.Text);
			int community_other_service_employment_pop=int.Parse(this.txtcommunity_other_service_employment_pop.Text);
			string community_empm_information_platform=this.txtcommunity_empm_information_platform.Text;
			string community_entp_supportive_policy=this.txtcommunity_entp_supportive_policy.Text;
			int community_enp_supportive_num=int.Parse(this.txtcommunity_enp_supportive_num.Text);
			int community_public_spirited_job_num=int.Parse(this.txtcommunity_public_spirited_job_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcleunset1=this.txttcleunset1.Text;
			string tcleunset2=this.txttcleunset2.Text;
			string tcleunset3=this.txttcleunset3.Text;
			string tcleunset4=this.txttcleunset4.Text;
			string tcleunset5=this.txttcleunset5.Text;
			string tcleunset6=this.txttcleunset6.Text;
			string tcleunset7=this.txttcleunset7.Text;
			string tcleunset8=this.txttcleunset8.Text;
			string tcleunset9=this.txttcleunset9.Text;
			string tcleunset10=this.txttcleunset10.Text;
			string tcleunset11=this.txttcleunset11.Text;
			string tcleunset12=this.txttcleunset12.Text;
			string tcleunset13=this.txttcleunset13.Text;
			string tcleunset14=this.txttcleunset14.Text;
			string tcleunset15=this.txttcleunset15.Text;
			string tcleunset16=this.txttcleunset16.Text;
			string tcleunset17=this.txttcleunset17.Text;
			string tcleunset18=this.txttcleunset18.Text;
			string tcleunset19=this.txttcleunset19.Text;
			string tcleunset20=this.txttcleunset20.Text;
			string tcleunset21=this.txttcleunset21.Text;
			string tcleunset22=this.txttcleunset22.Text;
			string tcleunset23=this.txttcleunset23.Text;
			string tcleunset24=this.txttcleunset24.Text;
			string tcleunset25=this.txttcleunset25.Text;
			string tcleunset26=this.txttcleunset26.Text;
			string tcleunset27=this.txttcleunset27.Text;
			string tcleunset28=this.txttcleunset28.Text;
			string tcleunset29=this.txttcleunset29.Text;
			string tcleunset30=this.txttcleunset30.Text;
			string tcleunset31=this.txttcleunset31.Text;
			string tcleunset32=this.txttcleunset32.Text;
			string tcleunset33=this.txttcleunset33.Text;
			string tcleunset34=this.txttcleunset34.Text;
			string tcleunset35=this.txttcleunset35.Text;
			string tcleunset36=this.txttcleunset36.Text;
			string tcleunset37=this.txttcleunset37.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_lf_employment model=new TTG.Model.TTGWeb.community_lf_employment();
			model.community_id=community_id;
			model.community_total_lf_pop=community_total_lf_pop;
			model.community_student_lf_pop=community_student_lf_pop;
			model.community_lf_age_bet_16_and_29_pop=community_lf_age_bet_16_and_29_pop;
			model.community_lf_age_bet_30_and_39_pop=community_lf_age_bet_30_and_39_pop;
			model.community_lf_age_bet_40_and_49_pop=community_lf_age_bet_40_and_49_pop;
			model.community_lf_age_larger_than_50_pop=community_lf_age_larger_than_50_pop;
			model.community_illiterate_lf_pop=community_illiterate_lf_pop;
			model.community_primary_school_education_lf_pop=community_primary_school_education_lf_pop;
			model.community_middle_school_education_lf_pop=community_middle_school_education_lf_pop;
			model.community_senior_school_education_lf_pop=community_senior_school_education_lf_pop;
			model.community_college_graduate_lf_pop=community_college_graduate_lf_pop;
			model.community_lf_average_education_year=community_lf_average_education_year;
			model.community_lf_with_no_skill_pop=community_lf_with_no_skill_pop;
			model.community_lf_with_junior_skill_pop=community_lf_with_junior_skill_pop;
			model.community_lf_with_medium_grade_skill_pop=community_lf_with_medium_grade_skill_pop;
			model.community_lf_with_senior_skill_pop=community_lf_with_senior_skill_pop;
			model.community_hou_with_no_job_num=community_hou_with_no_job_num;
			model.community_immigrant_hou_with_no_job_num=community_immigrant_hou_with_no_job_num;
			model.community_lf_having_a_job_pop=community_lf_having_a_job_pop;
			model.community_ai_employee_pop=community_ai_employee_pop;
			model.community_enterprise_employee_pop=community_enterprise_employee_pop;
			model.community_part_time_job_pop=community_part_time_job_pop;
			model.community_migrant_workers_pop=community_migrant_workers_pop;
			model.community_household_management_pop=community_household_management_pop;
			model.community_no_job_pop=community_no_job_pop;
			model.community_have_job_pop=community_have_job_pop;
			model.community_farmer_pop=community_farmer_pop;
			model.community_industrial_employment_pop=community_industrial_employment_pop;
			model.community_buil_industrial_employment_pop=community_buil_industrial_employment_pop;
			model.community_transport_employment_pop=community_transport_employment_pop;
			model.community_whs_and_retail_employment_pop=community_whs_and_retail_employment_pop;
			model.community_catering_accomm_employment_pop=community_catering_accomm_employment_pop;
			model.community_other_service_employment_pop=community_other_service_employment_pop;
			model.community_empm_information_platform=community_empm_information_platform;
			model.community_entp_supportive_policy=community_entp_supportive_policy;
			model.community_enp_supportive_num=community_enp_supportive_num;
			model.community_public_spirited_job_num=community_public_spirited_job_num;
			model.statistics_date=statistics_date;
			model.tcleunset1=tcleunset1;
			model.tcleunset2=tcleunset2;
			model.tcleunset3=tcleunset3;
			model.tcleunset4=tcleunset4;
			model.tcleunset5=tcleunset5;
			model.tcleunset6=tcleunset6;
			model.tcleunset7=tcleunset7;
			model.tcleunset8=tcleunset8;
			model.tcleunset9=tcleunset9;
			model.tcleunset10=tcleunset10;
			model.tcleunset11=tcleunset11;
			model.tcleunset12=tcleunset12;
			model.tcleunset13=tcleunset13;
			model.tcleunset14=tcleunset14;
			model.tcleunset15=tcleunset15;
			model.tcleunset16=tcleunset16;
			model.tcleunset17=tcleunset17;
			model.tcleunset18=tcleunset18;
			model.tcleunset19=tcleunset19;
			model.tcleunset20=tcleunset20;
			model.tcleunset21=tcleunset21;
			model.tcleunset22=tcleunset22;
			model.tcleunset23=tcleunset23;
			model.tcleunset24=tcleunset24;
			model.tcleunset25=tcleunset25;
			model.tcleunset26=tcleunset26;
			model.tcleunset27=tcleunset27;
			model.tcleunset28=tcleunset28;
			model.tcleunset29=tcleunset29;
			model.tcleunset30=tcleunset30;
			model.tcleunset31=tcleunset31;
			model.tcleunset32=tcleunset32;
			model.tcleunset33=tcleunset33;
			model.tcleunset34=tcleunset34;
			model.tcleunset35=tcleunset35;
			model.tcleunset36=tcleunset36;
			model.tcleunset37=tcleunset37;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_lf_employment bll=new TTG.BLL.TTGWeb.community_lf_employment();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
