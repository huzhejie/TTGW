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
namespace TTG.Web.TTGWeb.sample
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
		TTG.BLL.TTGWeb.sample bll=new TTG.BLL.TTGWeb.sample();
		TTG.Model.TTGWeb.sample model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblsample_house_num.Text=model.sample_house_num.ToString();
		this.lblsample_family_pop.Text=model.sample_family_pop.ToString();
		this.lblsample_labor_force_pop.Text=model.sample_labor_force_pop.ToString();
		this.lblsample_employment_lf_pop.Text=model.sample_employment_lf_pop.ToString();
		this.lblsample_primary_industry_lf_pop.Text=model.sample_primary_industry_lf_pop.ToString();
		this.lblsample_secondary_industry_lf_pop.Text=model.sample_secondary_industry_lf_pop.ToString();
		this.lblsample_tertiary_industry_lf_pop.Text=model.sample_tertiary_industry_lf_pop.ToString();
		this.lblsample_PCDI.Text=model.sample_PCDI.ToString();
		this.lblsample_wages_income.Text=model.sample_wages_income.ToString();
		this.lblsample_family_run_pure_income.Text=model.sample_family_run_pure_income.ToString();
		this.lblsample_property_income.Text=model.sample_property_income.ToString();
		this.lblsample_transfer_income.Text=model.sample_transfer_income.ToString();
		this.lblsample_CONSP.Text=model.sample_CONSP.ToString();
		this.lbltsunset1.Text=model.tsunset1;
		this.lbltsunset2.Text=model.tsunset2;
		this.lbltsunset3.Text=model.tsunset3;
		this.lbltsunset4.Text=model.tsunset4;
		this.lbltsunset5.Text=model.tsunset5;
		this.lbltsunset6.Text=model.tsunset6;
		this.lbltsunset7.Text=model.tsunset7;
		this.lbltsunset8.Text=model.tsunset8;
		this.lbltsunset9.Text=model.tsunset9;
		this.lbltsunset10.Text=model.tsunset10;
		this.lbltsunset11.Text=model.tsunset11;
		this.lbltsunset12.Text=model.tsunset12;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();

	}


    }
}
