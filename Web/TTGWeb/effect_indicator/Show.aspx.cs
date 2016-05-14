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
namespace TTG.Web.TTGWeb.effect_indicator
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
		TTG.BLL.TTGWeb.effect_indicator bll=new TTG.BLL.TTGWeb.effect_indicator();
		TTG.Model.TTGWeb.effect_indicator model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblstructure_safe_good_rate.Text=model.structure_safe_good_rate.ToString();
		this.lblroof_good_rate.Text=model.roof_good_rate.ToString();
		this.lblwall_good_rate.Text=model.wall_good_rate.ToString();
		this.lblslope_safe_rate.Text=model.slope_safe_rate.ToString();
		this.lblconcil_house_validate.Text=model.concil_house_validate.ToString();
		this.lblroad_link_degree.Text=model.road_link_degree.ToString();
		this.lblroad_good_degree.Text=model.road_good_degree.ToString();
		this.lbltraffic_validate.Text=model.traffic_validate.ToString();
		this.lblwater_capcity_degree.Text=model.water_capcity_degree.ToString();
		this.lblwater_pipe_net_good_degree.Text=model.water_pipe_net_good_degree.ToString();
		this.lblone_hou_one_water_meter_rate.Text=model.one_hou_one_water_meter_rate.ToString();
		this.lblwater_supply_validate.Text=model.water_supply_validate.ToString();
		this.lblelec_capcity_degree.Text=model.elec_capcity_degree.ToString();
		this.lblelec_wire_safe_degree.Text=model.elec_wire_safe_degree.ToString();
		this.lblone_hou_one_elec_meter_rate.Text=model.one_hou_one_elec_meter_rate.ToString();
		this.lblelec_supply_validate.Text=model.elec_supply_validate.ToString();
		this.lblroad_light_suff_degree.Text=model.road_light_suff_degree.ToString();
		this.lblpassway_light_suff_degree.Text=model.passway_light_suff_degree.ToString();
		this.lbllight_validate.Text=model.light_validate.ToString();
		this.lbloutdoors_ff_good_rate.Text=model.outdoors_ff_good_rate.ToString();
		this.lblindoors_ff_good_rate.Text=model.indoors_ff_good_rate.ToString();
		this.lblff_way_good_rate.Text=model.ff_way_good_rate.ToString();
		this.lblff_validate.Text=model.ff_validate.ToString();
		this.lblbasic_facility_validate.Text=model.basic_facility_validate.ToString();
		this.lblrefuse_collect_rate.Text=model.refuse_collect_rate.ToString();
		this.lbltoilet_cover_degree.Text=model.toilet_cover_degree.ToString();
		this.lblsanitation_validate.Text=model.sanitation_validate.ToString();
		this.lblsewage_collect_rate.Text=model.sewage_collect_rate.ToString();
		this.lbldrain_safe_degree.Text=model.drain_safe_degree.ToString();
		this.lbldrain_validate.Text=model.drain_validate.ToString();
		this.lblgreen_validate.Text=model.green_validate.ToString();
		this.lblenvironment_validate.Text=model.environment_validate.ToString();
		this.lblservice_gfs_good_rate.Text=model.service_gfs_good_rate.ToString();
		this.lblkindergarten_good_rate.Text=model.kindergarten_good_rate.ToString();
		this.lblmedical_good_rate.Text=model.medical_good_rate.ToString();
		this.lblparking_good_rate.Text=model.parking_good_rate.ToString();
		this.lblCVS_good_rate.Text=model.CVS_good_rate.ToString();
		this.lblvegetable_market_good_rate.Text=model.vegetable_market_good_rate.ToString();
		this.lblcommerce_validate.Text=model.commerce_validate.ToString();
		this.lblcul_fitness_facility_good_rate.Text=model.cul_fitness_facility_good_rate.ToString();
		this.lblolder_facility_good_rate.Text=model.older_facility_good_rate.ToString();
		this.lblpublic_service_good_rate.Text=model.public_service_good_rate.ToString();
		this.lblshop_front_use_rate.Text=model.shop_front_use_rate.ToString();
		this.lblshop_front_rent_level.Text=model.shop_front_rent_level.ToString();
		this.lblshop_validate.Text=model.shop_validate.ToString();
		this.lblcommunity_validate.Text=model.community_validate.ToString();
		this.lblindicator1.Text=model.indicator1.ToString();
		this.lblindicator2.Text=model.indicator2.ToString();
		this.lblindicator3.Text=model.indicator3.ToString();
		this.lblindicator4.Text=model.indicator4.ToString();
		this.lblindicator5.Text=model.indicator5.ToString();
		this.lblindicator6.Text=model.indicator6.ToString();
		this.lblindicator7.Text=model.indicator7.ToString();
		this.lblindicator8.Text=model.indicator8.ToString();
		this.lblindicator9.Text=model.indicator9.ToString();
		this.lblindicator10.Text=model.indicator10.ToString();
		this.lblindicator11.Text=model.indicator11.ToString();
		this.lblindicator12.Text=model.indicator12.ToString();
		this.lblindicator13.Text=model.indicator13.ToString();
		this.lblindicator14.Text=model.indicator14.ToString();
		this.lblindicator15.Text=model.indicator15.ToString();
		this.lblindicator16.Text=model.indicator16.ToString();
		this.lblindicator17.Text=model.indicator17.ToString();
		this.lblindicator18.Text=model.indicator18.ToString();
		this.lblindicator19.Text=model.indicator19.ToString();
		this.lblindicator20.Text=model.indicator20.ToString();
		this.lblindicator21.Text=model.indicator21.ToString();
		this.lblindicator22.Text=model.indicator22.ToString();
		this.lblindicator23.Text=model.indicator23.ToString();
		this.lblindicator24.Text=model.indicator24.ToString();
		this.lblindicator25.Text=model.indicator25.ToString();
		this.lblindicator26.Text=model.indicator26.ToString();
		this.lblindicator27.Text=model.indicator27.ToString();
		this.lblindicator28.Text=model.indicator28.ToString();
		this.lblindicator29.Text=model.indicator29.ToString();
		this.lblindicator30.Text=model.indicator30.ToString();
		this.lblindicator31.Text=model.indicator31.ToString();
		this.lblindicator32.Text=model.indicator32.ToString();
		this.lblindicator33.Text=model.indicator33.ToString();
		this.lblindicator34.Text=model.indicator34.ToString();
		this.lblindicator35.Text=model.indicator35.ToString();
		this.lblindicator36.Text=model.indicator36.ToString();
		this.lblindicator37.Text=model.indicator37.ToString();
		this.lblindicator38.Text=model.indicator38.ToString();
		this.lblindicator39.Text=model.indicator39.ToString();
		this.lblindicator40.Text=model.indicator40.ToString();
		this.lblindicator41.Text=model.indicator41.ToString();
		this.lblindicator42.Text=model.indicator42.ToString();
		this.lblindicator43.Text=model.indicator43.ToString();
		this.lblindicator44.Text=model.indicator44.ToString();
		this.lblindicator45.Text=model.indicator45.ToString();
		this.lblindicator46.Text=model.indicator46.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lbllabor_employment_rate.Text=model.labor_employment_rate.ToString();
		this.lbldisposable_money_per_people.Text=model.disposable_money_per_people.ToString();

	}


    }
}
