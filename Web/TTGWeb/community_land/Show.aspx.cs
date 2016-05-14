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
namespace TTG.Web.TTGWeb.community_land
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
		TTG.BLL.TTGWeb.community_land bll=new TTG.BLL.TTGWeb.community_land();
		TTG.Model.TTGWeb.community_land model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_total_land_area.Text=model.community_total_land_area.ToString();
		this.lblcommunity_house_land_area.Text=model.community_house_land_area.ToString();
		this.lblcommunity_public_building_land_area.Text=model.community_public_building_land_area.ToString();
		this.lblcommunity_road_land_area.Text=model.community_road_land_area.ToString();
		this.lblcommunity_public_greenland_area.Text=model.community_public_greenland_area.ToString();
		this.lblcommunity_industry_land_area.Text=model.community_industry_land_area.ToString();
		this.lblcommunity_warehousing_land_area.Text=model.community_warehousing_land_area.ToString();
		this.lblcommunity_traffic_land_area.Text=model.community_traffic_land_area.ToString();
		this.lblcommunity_municipal_administration_land_area.Text=model.community_municipal_administration_land_area.ToString();
		this.lblcommunity_other_land_area.Text=model.community_other_land_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltclunset1.Text=model.tclunset1;
		this.lbltclunset2.Text=model.tclunset2;
		this.lbltclunset3.Text=model.tclunset3;
		this.lbltclunset4.Text=model.tclunset4;
		this.lbltclunset5.Text=model.tclunset5;
		this.lbltclunset6.Text=model.tclunset6;
		this.lbltclunset7.Text=model.tclunset7;
		this.lbltclunset8.Text=model.tclunset8;
		this.lbltclunset9.Text=model.tclunset9;
		this.lbltclunset10.Text=model.tclunset10;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
