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
namespace TTG.Web.TTGWeb.community_social_insurance
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
		TTG.BLL.TTGWeb.community_social_insurance bll=new TTG.BLL.TTGWeb.community_social_insurance();
		TTG.Model.TTGWeb.community_social_insurance model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_urban_min_living_sec_pop.Text=model.community_urban_min_living_sec_pop.ToString();
		this.lblcommunity_very_poor_household_pop.Text=model.community_very_poor_household_pop.ToString();
		this.lblcommunity_large_med_resv_immg_pop.Text=model.community_large_med_resv_immg_pop.ToString();
		this.lblcommunity_chongqing_immg_poor_pop.Text=model.community_chongqing_immg_poor_pop.ToString();
		this.lblcommunity_medicare_pop.Text=model.community_medicare_pop.ToString();
		this.lblcommunity_endow_insu_pop.Text=model.community_endow_insu_pop.ToString();
		this.lblcommunity_unemp_insu_pop.Text=model.community_unemp_insu_pop.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcsiunset1.Text=model.tcsiunset1;
		this.lbltcsiunset2.Text=model.tcsiunset2;
		this.lbltcsiunset3.Text=model.tcsiunset3;
		this.lbltcsiunset4.Text=model.tcsiunset4;
		this.lbltcsiunset5.Text=model.tcsiunset5;
		this.lbltcsiunset6.Text=model.tcsiunset6;
		this.lbltcsiunset7.Text=model.tcsiunset7;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lblpoor_people_rate.Text=model.poor_people_rate.ToString();

	}


    }
}
