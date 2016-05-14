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
namespace TTG.Web.TTGWeb.community_letter_view
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
		TTG.BLL.TTGWeb.community_letter_view bll=new TTG.BLL.TTGWeb.community_letter_view();
		TTG.Model.TTGWeb.community_letter_view model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_lv_num.Text=model.community_lv_num.ToString();
		this.lblcommunity_lv_pop.Text=model.community_lv_pop.ToString();
		this.lblcommunity_lv_county_government_num.Text=model.community_lv_county_government_num.ToString();
		this.lblcommunity_lv_county_government_pop.Text=model.community_lv_county_government_pop.ToString();
		this.lblcommunity_lv_county_industry_num.Text=model.community_lv_county_industry_num.ToString();
		this.lblcommunity_lv_county_industry_pop.Text=model.community_lv_county_industry_pop.ToString();
		this.lblcommunity_lv_street_agency_num.Text=model.community_lv_street_agency_num.ToString();
		this.lblcommunity_lv_street_agency_pop.Text=model.community_lv_street_agency_pop.ToString();
		this.lblcommunity_lv_neighborhood_committee_num.Text=model.community_lv_neighborhood_committee_num.ToString();
		this.lblcommunity_lv_neighborhood_committee_pop.Text=model.community_lv_neighborhood_committee_pop.ToString();
		this.lblcommunity_lv_immigration_num.Text=model.community_lv_immigration_num.ToString();
		this.lblcommunity_lv_basic_fac_num.Text=model.community_lv_basic_fac_num.ToString();
		this.lblcommunity_lv_service_fac_num.Text=model.community_lv_service_fac_num.ToString();
		this.lblcommunity_lv_livelihood_difficulty_num.Text=model.community_lv_livelihood_difficulty_num.ToString();
		this.lblcommunity_lv_disputes_complaints_num.Text=model.community_lv_disputes_complaints_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltclvunset1.Text=model.tclvunset1;
		this.lbltclvunset2.Text=model.tclvunset2;
		this.lbltclvunset3.Text=model.tclvunset3;
		this.lbltclvunset4.Text=model.tclvunset4;
		this.lbltclvunset5.Text=model.tclvunset5;
		this.lbltclvunset6.Text=model.tclvunset6;
		this.lbltclvunset7.Text=model.tclvunset7;
		this.lbltclvunset8.Text=model.tclvunset8;
		this.lbltclvunset9.Text=model.tclvunset9;
		this.lbltclvunset10.Text=model.tclvunset10;
		this.lbltclvunset11.Text=model.tclvunset11;
		this.lbltclvunset12.Text=model.tclvunset12;
		this.lbltclvunset13.Text=model.tclvunset13;
		this.lbltclvunset14.Text=model.tclvunset14;
		this.lbltclvunset15.Text=model.tclvunset15;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
