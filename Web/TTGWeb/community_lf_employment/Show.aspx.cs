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
namespace TTG.Web.TTGWeb.community_lf_employment
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string community_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					community_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(community_id,statistics_date);
			}
		}
		
	private void ShowInfo(string community_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.community_lf_employment bll=new TTG.BLL.TTGWeb.community_lf_employment();
		TTG.Model.TTGWeb.community_lf_employment model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_total_lf_pop.Text=model.community_total_lf_pop.ToString();
		this.lblcommunity_student_lf_pop.Text=model.community_student_lf_pop.ToString();
		this.lblcommunity_lf_age_bet_16_and_29_pop.Text=model.community_lf_age_bet_16_and_29_pop.ToString();
		this.lblcommunity_lf_age_bet_30_and_39_pop.Text=model.community_lf_age_bet_30_and_39_pop.ToString();
		this.lblcommunity_lf_age_bet_40_and_49_pop.Text=model.community_lf_age_bet_40_and_49_pop.ToString();
		this.lblcommunity_lf_age_larger_than_50_pop.Text=model.community_lf_age_larger_than_50_pop.ToString();
		this.lblcommunity_illiterate_lf_pop.Text=model.community_illiterate_lf_pop.ToString();
		this.lblcommunity_primary_school_education_lf_pop.Text=model.community_primary_school_education_lf_pop.ToString();
		this.lblcommunity_middle_school_education_lf_pop.Text=model.community_middle_school_education_lf_pop.ToString();
		this.lblcommunity_senior_school_education_lf_pop.Text=model.community_senior_school_education_lf_pop.ToString();
		this.lblcommunity_college_graduate_lf_pop.Text=model.community_college_graduate_lf_pop.ToString();
		this.lblcommunity_lf_average_education_year.Text=model.community_lf_average_education_year.ToString();
		this.lblcommunity_lf_with_no_skill_pop.Text=model.community_lf_with_no_skill_pop.ToString();
		this.lblcommunity_lf_with_junior_skill_pop.Text=model.community_lf_with_junior_skill_pop.ToString();
		this.lblcommunity_lf_with_medium_grade_skill_pop.Text=model.community_lf_with_medium_grade_skill_pop.ToString();
		this.lblcommunity_lf_with_senior_skill_pop.Text=model.community_lf_with_senior_skill_pop.ToString();
		this.lblcommunity_hou_with_no_job_num.Text=model.community_hou_with_no_job_num.ToString();
		this.lblcommunity_immigrant_hou_with_no_job_num.Text=model.community_immigrant_hou_with_no_job_num.ToString();
		this.lblcommunity_lf_having_a_job_pop.Text=model.community_lf_having_a_job_pop.ToString();
		this.lblcommunity_ai_employee_pop.Text=model.community_ai_employee_pop.ToString();
		this.lblcommunity_enterprise_employee_pop.Text=model.community_enterprise_employee_pop.ToString();
		this.lblcommunity_part_time_job_pop.Text=model.community_part_time_job_pop.ToString();
		this.lblcommunity_migrant_workers_pop.Text=model.community_migrant_workers_pop.ToString();
		this.lblcommunity_household_management_pop.Text=model.community_household_management_pop.ToString();
		this.lblcommunity_no_job_pop.Text=model.community_no_job_pop.ToString();
		this.lblcommunity_have_job_pop.Text=model.community_have_job_pop.ToString();
		this.lblcommunity_farmer_pop.Text=model.community_farmer_pop.ToString();
		this.lblcommunity_industrial_employment_pop.Text=model.community_industrial_employment_pop.ToString();
		this.lblcommunity_buil_industrial_employment_pop.Text=model.community_buil_industrial_employment_pop.ToString();
		this.lblcommunity_transport_employment_pop.Text=model.community_transport_employment_pop.ToString();
		this.lblcommunity_whs_and_retail_employment_pop.Text=model.community_whs_and_retail_employment_pop.ToString();
		this.lblcommunity_catering_accomm_employment_pop.Text=model.community_catering_accomm_employment_pop.ToString();
		this.lblcommunity_other_service_employment_pop.Text=model.community_other_service_employment_pop.ToString();
		this.lblcommunity_empm_information_platform.Text=model.community_empm_information_platform;
		this.lblcommunity_entp_supportive_policy.Text=model.community_entp_supportive_policy;
		this.lblcommunity_enp_supportive_num.Text=model.community_enp_supportive_num.ToString();
		this.lblcommunity_public_spirited_job_num.Text=model.community_public_spirited_job_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcleunset1.Text=model.tcleunset1;
		this.lbltcleunset2.Text=model.tcleunset2;
		this.lbltcleunset3.Text=model.tcleunset3;
		this.lbltcleunset4.Text=model.tcleunset4;
		this.lbltcleunset5.Text=model.tcleunset5;
		this.lbltcleunset6.Text=model.tcleunset6;
		this.lbltcleunset7.Text=model.tcleunset7;
		this.lbltcleunset8.Text=model.tcleunset8;
		this.lbltcleunset9.Text=model.tcleunset9;
		this.lbltcleunset10.Text=model.tcleunset10;
		this.lbltcleunset11.Text=model.tcleunset11;
		this.lbltcleunset12.Text=model.tcleunset12;
		this.lbltcleunset13.Text=model.tcleunset13;
		this.lbltcleunset14.Text=model.tcleunset14;
		this.lbltcleunset15.Text=model.tcleunset15;
		this.lbltcleunset16.Text=model.tcleunset16;
		this.lbltcleunset17.Text=model.tcleunset17;
		this.lbltcleunset18.Text=model.tcleunset18;
		this.lbltcleunset19.Text=model.tcleunset19;
		this.lbltcleunset20.Text=model.tcleunset20;
		this.lbltcleunset21.Text=model.tcleunset21;
		this.lbltcleunset22.Text=model.tcleunset22;
		this.lbltcleunset23.Text=model.tcleunset23;
		this.lbltcleunset24.Text=model.tcleunset24;
		this.lbltcleunset25.Text=model.tcleunset25;
		this.lbltcleunset26.Text=model.tcleunset26;
		this.lbltcleunset27.Text=model.tcleunset27;
		this.lbltcleunset28.Text=model.tcleunset28;
		this.lbltcleunset29.Text=model.tcleunset29;
		this.lbltcleunset30.Text=model.tcleunset30;
		this.lbltcleunset31.Text=model.tcleunset31;
		this.lbltcleunset32.Text=model.tcleunset32;
		this.lbltcleunset33.Text=model.tcleunset33;
		this.lbltcleunset34.Text=model.tcleunset34;
		this.lbltcleunset35.Text=model.tcleunset35;
		this.lbltcleunset36.Text=model.tcleunset36;
		this.lbltcleunset37.Text=model.tcleunset37;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
