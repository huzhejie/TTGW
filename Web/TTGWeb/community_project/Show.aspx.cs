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
namespace TTG.Web.TTGWeb.community_project
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string county_name = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					county_name= Request.Params["id0"];
				}
				string project_id = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					project_id= Request.Params["id1"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id2"] != null && Request.Params["id2"].Trim() != "")
				{
					statistics_date= Request.Params["id2"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(county_name,project_id,statistics_date);
			}
		}
		
	private void ShowInfo(string county_name,string project_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.community_project bll=new TTG.BLL.TTGWeb.community_project();
		TTG.Model.TTGWeb.community_project model=bll.GetModel(county_name,project_id,statistics_date);
		this.lblcounty_name.Text=model.county_name;
		this.lblproject_id.Text=model.project_id;
		this.lblproject_name.Text=model.project_name;
		this.lblproject_category.Text=model.project_category;
		this.lblproject_add_time.Text=model.project_add_time.ToString();
		this.lblproject_total_investment.Text=model.project_total_investment.ToString();
		this.lblproject_proprietor.Text=model.project_proprietor;
		this.lblplan_to_bulid.Text=model.plan_to_bulid;
		this.lblbiding_finish_time.Text=model.biding_finish_time.ToString();
		this.lblcontract_period.Text=model.contract_period;
		this.lblproject_start_time.Text=model.project_start_time.ToString();
		this.lblnot_started_reason_analysis.Text=model.not_started_reason_analysis;
		this.lblcomplete_time.Text=model.complete_time.ToString();
		this.lblproject_delay_reason_analysis.Text=model.project_delay_reason_analysis;
		this.lblif_major_quality_or_security_accident_happened.Text=model.if_major_quality_or_security_accident_happened;
		this.lblproject_complete_acceptance_time.Text=model.project_complete_acceptance_time.ToString();
		this.lblcomplete_acceptance_quality_level.Text=model.complete_acceptance_quality_level;
		this.lblif_transfer.Text=model.if_transfer;
		this.lblproject_community_correlation_description.Text=model.project_community_correlation_description;
		this.lblnote_information.Text=model.note_information;
		this.lblproject_type.Text=model.project_type;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblmajor_quality_or_security_accident.Text=model.major_quality_or_security_accident;
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lbltciunset5.Text=model.tciunset5;
		this.lbltciunset6.Text=model.tciunset6;
		this.lbltciunset7.Text=model.tciunset7;
		this.lbltciunset8.Text=model.tciunset8;
		this.lbltciunset9.Text=model.tciunset9;
		this.lbltciunset10.Text=model.tciunset10;
		this.lbltciunset11.Text=model.tciunset11;
		this.lbltciunset12.Text=model.tciunset12;
		this.lbltciunset13.Text=model.tciunset13;
		this.lbltciunset14.Text=model.tciunset14;
		this.lbltciunset15.Text=model.tciunset15;
		this.lbltciunset16.Text=model.tciunset16;
		this.lbltciunset17.Text=model.tciunset17;
		this.lbltciunset18.Text=model.tciunset18;
		this.lbltciunset19.Text=model.tciunset19;
		this.lbltciunset20.Text=model.tciunset20;
		this.lbltciunset21.Text=model.tciunset21;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
