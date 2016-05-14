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
namespace TTG.Web.TTGWeb.effect_indicator
{
    public partial class Modify : Page
    {       

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
		this.txtstructure_safe_good_rate.Text=model.structure_safe_good_rate.ToString();
		this.txtroof_good_rate.Text=model.roof_good_rate.ToString();
		this.txtwall_good_rate.Text=model.wall_good_rate.ToString();
		this.txtslope_safe_rate.Text=model.slope_safe_rate.ToString();
		this.txtconcil_house_validate.Text=model.concil_house_validate.ToString();
		this.txtroad_link_degree.Text=model.road_link_degree.ToString();
		this.txtroad_good_degree.Text=model.road_good_degree.ToString();
		this.txttraffic_validate.Text=model.traffic_validate.ToString();
		this.txtwater_capcity_degree.Text=model.water_capcity_degree.ToString();
		this.txtwater_pipe_net_good_degree.Text=model.water_pipe_net_good_degree.ToString();
		this.txtone_hou_one_water_meter_rate.Text=model.one_hou_one_water_meter_rate.ToString();
		this.txtwater_supply_validate.Text=model.water_supply_validate.ToString();
		this.txtelec_capcity_degree.Text=model.elec_capcity_degree.ToString();
		this.txtelec_wire_safe_degree.Text=model.elec_wire_safe_degree.ToString();
		this.txtone_hou_one_elec_meter_rate.Text=model.one_hou_one_elec_meter_rate.ToString();
		this.txtelec_supply_validate.Text=model.elec_supply_validate.ToString();
		this.txtroad_light_suff_degree.Text=model.road_light_suff_degree.ToString();
		this.txtpassway_light_suff_degree.Text=model.passway_light_suff_degree.ToString();
		this.txtlight_validate.Text=model.light_validate.ToString();
		this.txtoutdoors_ff_good_rate.Text=model.outdoors_ff_good_rate.ToString();
		this.txtindoors_ff_good_rate.Text=model.indoors_ff_good_rate.ToString();
		this.txtff_way_good_rate.Text=model.ff_way_good_rate.ToString();
		this.txtff_validate.Text=model.ff_validate.ToString();
		this.txtbasic_facility_validate.Text=model.basic_facility_validate.ToString();
		this.txtrefuse_collect_rate.Text=model.refuse_collect_rate.ToString();
		this.txttoilet_cover_degree.Text=model.toilet_cover_degree.ToString();
		this.txtsanitation_validate.Text=model.sanitation_validate.ToString();
		this.txtsewage_collect_rate.Text=model.sewage_collect_rate.ToString();
		this.txtdrain_safe_degree.Text=model.drain_safe_degree.ToString();
		this.txtdrain_validate.Text=model.drain_validate.ToString();
		this.txtgreen_validate.Text=model.green_validate.ToString();
		this.txtenvironment_validate.Text=model.environment_validate.ToString();
		this.txtservice_gfs_good_rate.Text=model.service_gfs_good_rate.ToString();
		this.txtkindergarten_good_rate.Text=model.kindergarten_good_rate.ToString();
		this.txtmedical_good_rate.Text=model.medical_good_rate.ToString();
		this.txtparking_good_rate.Text=model.parking_good_rate.ToString();
		this.txtCVS_good_rate.Text=model.CVS_good_rate.ToString();
		this.txtvegetable_market_good_rate.Text=model.vegetable_market_good_rate.ToString();
		this.txtcommerce_validate.Text=model.commerce_validate.ToString();
		this.txtcul_fitness_facility_good_rate.Text=model.cul_fitness_facility_good_rate.ToString();
		this.txtolder_facility_good_rate.Text=model.older_facility_good_rate.ToString();
		this.txtpublic_service_good_rate.Text=model.public_service_good_rate.ToString();
		this.txtshop_front_use_rate.Text=model.shop_front_use_rate.ToString();
		this.txtshop_front_rent_level.Text=model.shop_front_rent_level.ToString();
		this.txtshop_validate.Text=model.shop_validate.ToString();
		this.txtcommunity_validate.Text=model.community_validate.ToString();
		this.txtindicator1.Text=model.indicator1.ToString();
		this.txtindicator2.Text=model.indicator2.ToString();
		this.txtindicator3.Text=model.indicator3.ToString();
		this.txtindicator4.Text=model.indicator4.ToString();
		this.txtindicator5.Text=model.indicator5.ToString();
		this.txtindicator6.Text=model.indicator6.ToString();
		this.txtindicator7.Text=model.indicator7.ToString();
		this.txtindicator8.Text=model.indicator8.ToString();
		this.txtindicator9.Text=model.indicator9.ToString();
		this.txtindicator10.Text=model.indicator10.ToString();
		this.txtindicator11.Text=model.indicator11.ToString();
		this.txtindicator12.Text=model.indicator12.ToString();
		this.txtindicator13.Text=model.indicator13.ToString();
		this.txtindicator14.Text=model.indicator14.ToString();
		this.txtindicator15.Text=model.indicator15.ToString();
		this.txtindicator16.Text=model.indicator16.ToString();
		this.txtindicator17.Text=model.indicator17.ToString();
		this.txtindicator18.Text=model.indicator18.ToString();
		this.txtindicator19.Text=model.indicator19.ToString();
		this.txtindicator20.Text=model.indicator20.ToString();
		this.txtindicator21.Text=model.indicator21.ToString();
		this.txtindicator22.Text=model.indicator22.ToString();
		this.txtindicator23.Text=model.indicator23.ToString();
		this.txtindicator24.Text=model.indicator24.ToString();
		this.txtindicator25.Text=model.indicator25.ToString();
		this.txtindicator26.Text=model.indicator26.ToString();
		this.txtindicator27.Text=model.indicator27.ToString();
		this.txtindicator28.Text=model.indicator28.ToString();
		this.txtindicator29.Text=model.indicator29.ToString();
		this.txtindicator30.Text=model.indicator30.ToString();
		this.txtindicator31.Text=model.indicator31.ToString();
		this.txtindicator32.Text=model.indicator32.ToString();
		this.txtindicator33.Text=model.indicator33.ToString();
		this.txtindicator34.Text=model.indicator34.ToString();
		this.txtindicator35.Text=model.indicator35.ToString();
		this.txtindicator36.Text=model.indicator36.ToString();
		this.txtindicator37.Text=model.indicator37.ToString();
		this.txtindicator38.Text=model.indicator38.ToString();
		this.txtindicator39.Text=model.indicator39.ToString();
		this.txtindicator40.Text=model.indicator40.ToString();
		this.txtindicator41.Text=model.indicator41.ToString();
		this.txtindicator42.Text=model.indicator42.ToString();
		this.txtindicator43.Text=model.indicator43.ToString();
		this.txtindicator44.Text=model.indicator44.ToString();
		this.txtindicator45.Text=model.indicator45.ToString();
		this.txtindicator46.Text=model.indicator46.ToString();
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtlabor_employment_rate.Text=model.labor_employment_rate.ToString();
		this.txtdisposable_money_per_people.Text=model.disposable_money_per_people.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtstructure_safe_good_rate.Text))
			{
				strErr+="structure_safe_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtroof_good_rate.Text))
			{
				strErr+="roof_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtwall_good_rate.Text))
			{
				strErr+="wall_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtslope_safe_rate.Text))
			{
				strErr+="slope_safe_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtconcil_house_validate.Text))
			{
				strErr+="concil_house_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtroad_link_degree.Text))
			{
				strErr+="road_link_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtroad_good_degree.Text))
			{
				strErr+="road_good_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttraffic_validate.Text))
			{
				strErr+="traffic_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtwater_capcity_degree.Text))
			{
				strErr+="water_capcity_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtwater_pipe_net_good_degree.Text))
			{
				strErr+="water_pipe_net_good_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtone_hou_one_water_meter_rate.Text))
			{
				strErr+="one_hou_one_water_meter_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtwater_supply_validate.Text))
			{
				strErr+="water_supply_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtelec_capcity_degree.Text))
			{
				strErr+="elec_capcity_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtelec_wire_safe_degree.Text))
			{
				strErr+="elec_wire_safe_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtone_hou_one_elec_meter_rate.Text))
			{
				strErr+="one_hou_one_elec_meter_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtelec_supply_validate.Text))
			{
				strErr+="elec_supply_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtroad_light_suff_degree.Text))
			{
				strErr+="road_light_suff_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpassway_light_suff_degree.Text))
			{
				strErr+="passway_light_suff_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlight_validate.Text))
			{
				strErr+="light_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtoutdoors_ff_good_rate.Text))
			{
				strErr+="outdoors_ff_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindoors_ff_good_rate.Text))
			{
				strErr+="indoors_ff_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtff_way_good_rate.Text))
			{
				strErr+="ff_way_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtff_validate.Text))
			{
				strErr+="ff_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtbasic_facility_validate.Text))
			{
				strErr+="basic_facility_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtrefuse_collect_rate.Text))
			{
				strErr+="refuse_collect_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttoilet_cover_degree.Text))
			{
				strErr+="toilet_cover_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsanitation_validate.Text))
			{
				strErr+="sanitation_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsewage_collect_rate.Text))
			{
				strErr+="sewage_collect_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdrain_safe_degree.Text))
			{
				strErr+="drain_safe_degree格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdrain_validate.Text))
			{
				strErr+="drain_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtgreen_validate.Text))
			{
				strErr+="green_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtenvironment_validate.Text))
			{
				strErr+="environment_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtservice_gfs_good_rate.Text))
			{
				strErr+="service_gfs_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtkindergarten_good_rate.Text))
			{
				strErr+="kindergarten_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtmedical_good_rate.Text))
			{
				strErr+="medical_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtparking_good_rate.Text))
			{
				strErr+="parking_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCVS_good_rate.Text))
			{
				strErr+="CVS_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtvegetable_market_good_rate.Text))
			{
				strErr+="vegetable_market_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommerce_validate.Text))
			{
				strErr+="commerce_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcul_fitness_facility_good_rate.Text))
			{
				strErr+="cul_fitness_facility_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtolder_facility_good_rate.Text))
			{
				strErr+="older_facility_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpublic_service_good_rate.Text))
			{
				strErr+="public_service_good_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtshop_front_use_rate.Text))
			{
				strErr+="shop_front_use_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtshop_front_rent_level.Text))
			{
				strErr+="shop_front_rent_level格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtshop_validate.Text))
			{
				strErr+="shop_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_validate.Text))
			{
				strErr+="community_validate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator1.Text))
			{
				strErr+="indicator1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator2.Text))
			{
				strErr+="indicator2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator3.Text))
			{
				strErr+="indicator3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator4.Text))
			{
				strErr+="indicator4格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator5.Text))
			{
				strErr+="indicator5格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator6.Text))
			{
				strErr+="indicator6格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator7.Text))
			{
				strErr+="indicator7格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator8.Text))
			{
				strErr+="indicator8格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator9.Text))
			{
				strErr+="indicator9格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator10.Text))
			{
				strErr+="indicator10格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator11.Text))
			{
				strErr+="indicator11格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator12.Text))
			{
				strErr+="indicator12格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator13.Text))
			{
				strErr+="indicator13格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator14.Text))
			{
				strErr+="indicator14格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator15.Text))
			{
				strErr+="indicator15格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator16.Text))
			{
				strErr+="indicator16格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator17.Text))
			{
				strErr+="indicator17格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator18.Text))
			{
				strErr+="indicator18格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator19.Text))
			{
				strErr+="indicator19格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator20.Text))
			{
				strErr+="indicator20格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator21.Text))
			{
				strErr+="indicator21格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator22.Text))
			{
				strErr+="indicator22格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator23.Text))
			{
				strErr+="indicator23格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator24.Text))
			{
				strErr+="indicator24格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator25.Text))
			{
				strErr+="indicator25格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator26.Text))
			{
				strErr+="indicator26格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator27.Text))
			{
				strErr+="indicator27格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator28.Text))
			{
				strErr+="indicator28格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator29.Text))
			{
				strErr+="indicator29格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator30.Text))
			{
				strErr+="indicator30格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator31.Text))
			{
				strErr+="indicator31格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator32.Text))
			{
				strErr+="indicator32格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator33.Text))
			{
				strErr+="indicator33格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator34.Text))
			{
				strErr+="indicator34格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator35.Text))
			{
				strErr+="indicator35格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator36.Text))
			{
				strErr+="indicator36格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator37.Text))
			{
				strErr+="indicator37格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator38.Text))
			{
				strErr+="indicator38格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator39.Text))
			{
				strErr+="indicator39格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator40.Text))
			{
				strErr+="indicator40格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator41.Text))
			{
				strErr+="indicator41格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator42.Text))
			{
				strErr+="indicator42格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator43.Text))
			{
				strErr+="indicator43格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator44.Text))
			{
				strErr+="indicator44格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator45.Text))
			{
				strErr+="indicator45格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtindicator46.Text))
			{
				strErr+="indicator46格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlabor_employment_rate.Text))
			{
				strErr+="labor_employment_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdisposable_money_per_people.Text))
			{
				strErr+="disposable_money_per_people格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			decimal structure_safe_good_rate=decimal.Parse(this.txtstructure_safe_good_rate.Text);
			decimal roof_good_rate=decimal.Parse(this.txtroof_good_rate.Text);
			decimal wall_good_rate=decimal.Parse(this.txtwall_good_rate.Text);
			decimal slope_safe_rate=decimal.Parse(this.txtslope_safe_rate.Text);
			decimal concil_house_validate=decimal.Parse(this.txtconcil_house_validate.Text);
			decimal road_link_degree=decimal.Parse(this.txtroad_link_degree.Text);
			decimal road_good_degree=decimal.Parse(this.txtroad_good_degree.Text);
			decimal traffic_validate=decimal.Parse(this.txttraffic_validate.Text);
			decimal water_capcity_degree=decimal.Parse(this.txtwater_capcity_degree.Text);
			decimal water_pipe_net_good_degree=decimal.Parse(this.txtwater_pipe_net_good_degree.Text);
			decimal one_hou_one_water_meter_rate=decimal.Parse(this.txtone_hou_one_water_meter_rate.Text);
			decimal water_supply_validate=decimal.Parse(this.txtwater_supply_validate.Text);
			decimal elec_capcity_degree=decimal.Parse(this.txtelec_capcity_degree.Text);
			decimal elec_wire_safe_degree=decimal.Parse(this.txtelec_wire_safe_degree.Text);
			decimal one_hou_one_elec_meter_rate=decimal.Parse(this.txtone_hou_one_elec_meter_rate.Text);
			decimal elec_supply_validate=decimal.Parse(this.txtelec_supply_validate.Text);
			decimal road_light_suff_degree=decimal.Parse(this.txtroad_light_suff_degree.Text);
			decimal passway_light_suff_degree=decimal.Parse(this.txtpassway_light_suff_degree.Text);
			decimal light_validate=decimal.Parse(this.txtlight_validate.Text);
			decimal outdoors_ff_good_rate=decimal.Parse(this.txtoutdoors_ff_good_rate.Text);
			decimal indoors_ff_good_rate=decimal.Parse(this.txtindoors_ff_good_rate.Text);
			decimal ff_way_good_rate=decimal.Parse(this.txtff_way_good_rate.Text);
			decimal ff_validate=decimal.Parse(this.txtff_validate.Text);
			decimal basic_facility_validate=decimal.Parse(this.txtbasic_facility_validate.Text);
			decimal refuse_collect_rate=decimal.Parse(this.txtrefuse_collect_rate.Text);
			decimal toilet_cover_degree=decimal.Parse(this.txttoilet_cover_degree.Text);
			decimal sanitation_validate=decimal.Parse(this.txtsanitation_validate.Text);
			decimal sewage_collect_rate=decimal.Parse(this.txtsewage_collect_rate.Text);
			decimal drain_safe_degree=decimal.Parse(this.txtdrain_safe_degree.Text);
			decimal drain_validate=decimal.Parse(this.txtdrain_validate.Text);
			decimal green_validate=decimal.Parse(this.txtgreen_validate.Text);
			decimal environment_validate=decimal.Parse(this.txtenvironment_validate.Text);
			decimal service_gfs_good_rate=decimal.Parse(this.txtservice_gfs_good_rate.Text);
			decimal kindergarten_good_rate=decimal.Parse(this.txtkindergarten_good_rate.Text);
			decimal medical_good_rate=decimal.Parse(this.txtmedical_good_rate.Text);
			decimal parking_good_rate=decimal.Parse(this.txtparking_good_rate.Text);
			decimal CVS_good_rate=decimal.Parse(this.txtCVS_good_rate.Text);
			decimal vegetable_market_good_rate=decimal.Parse(this.txtvegetable_market_good_rate.Text);
			decimal commerce_validate=decimal.Parse(this.txtcommerce_validate.Text);
			decimal cul_fitness_facility_good_rate=decimal.Parse(this.txtcul_fitness_facility_good_rate.Text);
			decimal older_facility_good_rate=decimal.Parse(this.txtolder_facility_good_rate.Text);
			decimal public_service_good_rate=decimal.Parse(this.txtpublic_service_good_rate.Text);
			decimal shop_front_use_rate=decimal.Parse(this.txtshop_front_use_rate.Text);
			decimal shop_front_rent_level=decimal.Parse(this.txtshop_front_rent_level.Text);
			decimal shop_validate=decimal.Parse(this.txtshop_validate.Text);
			decimal community_validate=decimal.Parse(this.txtcommunity_validate.Text);
			decimal indicator1=decimal.Parse(this.txtindicator1.Text);
			decimal indicator2=decimal.Parse(this.txtindicator2.Text);
			decimal indicator3=decimal.Parse(this.txtindicator3.Text);
			decimal indicator4=decimal.Parse(this.txtindicator4.Text);
			decimal indicator5=decimal.Parse(this.txtindicator5.Text);
			decimal indicator6=decimal.Parse(this.txtindicator6.Text);
			decimal indicator7=decimal.Parse(this.txtindicator7.Text);
			decimal indicator8=decimal.Parse(this.txtindicator8.Text);
			decimal indicator9=decimal.Parse(this.txtindicator9.Text);
			decimal indicator10=decimal.Parse(this.txtindicator10.Text);
			decimal indicator11=decimal.Parse(this.txtindicator11.Text);
			decimal indicator12=decimal.Parse(this.txtindicator12.Text);
			decimal indicator13=decimal.Parse(this.txtindicator13.Text);
			decimal indicator14=decimal.Parse(this.txtindicator14.Text);
			decimal indicator15=decimal.Parse(this.txtindicator15.Text);
			decimal indicator16=decimal.Parse(this.txtindicator16.Text);
			decimal indicator17=decimal.Parse(this.txtindicator17.Text);
			decimal indicator18=decimal.Parse(this.txtindicator18.Text);
			decimal indicator19=decimal.Parse(this.txtindicator19.Text);
			decimal indicator20=decimal.Parse(this.txtindicator20.Text);
			decimal indicator21=decimal.Parse(this.txtindicator21.Text);
			decimal indicator22=decimal.Parse(this.txtindicator22.Text);
			decimal indicator23=decimal.Parse(this.txtindicator23.Text);
			decimal indicator24=decimal.Parse(this.txtindicator24.Text);
			decimal indicator25=decimal.Parse(this.txtindicator25.Text);
			decimal indicator26=decimal.Parse(this.txtindicator26.Text);
			decimal indicator27=decimal.Parse(this.txtindicator27.Text);
			decimal indicator28=decimal.Parse(this.txtindicator28.Text);
			decimal indicator29=decimal.Parse(this.txtindicator29.Text);
			decimal indicator30=decimal.Parse(this.txtindicator30.Text);
			decimal indicator31=decimal.Parse(this.txtindicator31.Text);
			decimal indicator32=decimal.Parse(this.txtindicator32.Text);
			decimal indicator33=decimal.Parse(this.txtindicator33.Text);
			decimal indicator34=decimal.Parse(this.txtindicator34.Text);
			decimal indicator35=decimal.Parse(this.txtindicator35.Text);
			decimal indicator36=decimal.Parse(this.txtindicator36.Text);
			decimal indicator37=decimal.Parse(this.txtindicator37.Text);
			decimal indicator38=decimal.Parse(this.txtindicator38.Text);
			decimal indicator39=decimal.Parse(this.txtindicator39.Text);
			decimal indicator40=decimal.Parse(this.txtindicator40.Text);
			decimal indicator41=decimal.Parse(this.txtindicator41.Text);
			decimal indicator42=decimal.Parse(this.txtindicator42.Text);
			decimal indicator43=decimal.Parse(this.txtindicator43.Text);
			decimal indicator44=decimal.Parse(this.txtindicator44.Text);
			decimal indicator45=decimal.Parse(this.txtindicator45.Text);
			decimal indicator46=decimal.Parse(this.txtindicator46.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			decimal labor_employment_rate=decimal.Parse(this.txtlabor_employment_rate.Text);
			decimal disposable_money_per_people=decimal.Parse(this.txtdisposable_money_per_people.Text);


			TTG.Model.TTGWeb.effect_indicator model=new TTG.Model.TTGWeb.effect_indicator();
			model.community_id=community_id;
			model.statistics_date=statistics_date;
			model.structure_safe_good_rate=structure_safe_good_rate;
			model.roof_good_rate=roof_good_rate;
			model.wall_good_rate=wall_good_rate;
			model.slope_safe_rate=slope_safe_rate;
			model.concil_house_validate=concil_house_validate;
			model.road_link_degree=road_link_degree;
			model.road_good_degree=road_good_degree;
			model.traffic_validate=traffic_validate;
			model.water_capcity_degree=water_capcity_degree;
			model.water_pipe_net_good_degree=water_pipe_net_good_degree;
			model.one_hou_one_water_meter_rate=one_hou_one_water_meter_rate;
			model.water_supply_validate=water_supply_validate;
			model.elec_capcity_degree=elec_capcity_degree;
			model.elec_wire_safe_degree=elec_wire_safe_degree;
			model.one_hou_one_elec_meter_rate=one_hou_one_elec_meter_rate;
			model.elec_supply_validate=elec_supply_validate;
			model.road_light_suff_degree=road_light_suff_degree;
			model.passway_light_suff_degree=passway_light_suff_degree;
			model.light_validate=light_validate;
			model.outdoors_ff_good_rate=outdoors_ff_good_rate;
			model.indoors_ff_good_rate=indoors_ff_good_rate;
			model.ff_way_good_rate=ff_way_good_rate;
			model.ff_validate=ff_validate;
			model.basic_facility_validate=basic_facility_validate;
			model.refuse_collect_rate=refuse_collect_rate;
			model.toilet_cover_degree=toilet_cover_degree;
			model.sanitation_validate=sanitation_validate;
			model.sewage_collect_rate=sewage_collect_rate;
			model.drain_safe_degree=drain_safe_degree;
			model.drain_validate=drain_validate;
			model.green_validate=green_validate;
			model.environment_validate=environment_validate;
			model.service_gfs_good_rate=service_gfs_good_rate;
			model.kindergarten_good_rate=kindergarten_good_rate;
			model.medical_good_rate=medical_good_rate;
			model.parking_good_rate=parking_good_rate;
			model.CVS_good_rate=CVS_good_rate;
			model.vegetable_market_good_rate=vegetable_market_good_rate;
			model.commerce_validate=commerce_validate;
			model.cul_fitness_facility_good_rate=cul_fitness_facility_good_rate;
			model.older_facility_good_rate=older_facility_good_rate;
			model.public_service_good_rate=public_service_good_rate;
			model.shop_front_use_rate=shop_front_use_rate;
			model.shop_front_rent_level=shop_front_rent_level;
			model.shop_validate=shop_validate;
			model.community_validate=community_validate;
			model.indicator1=indicator1;
			model.indicator2=indicator2;
			model.indicator3=indicator3;
			model.indicator4=indicator4;
			model.indicator5=indicator5;
			model.indicator6=indicator6;
			model.indicator7=indicator7;
			model.indicator8=indicator8;
			model.indicator9=indicator9;
			model.indicator10=indicator10;
			model.indicator11=indicator11;
			model.indicator12=indicator12;
			model.indicator13=indicator13;
			model.indicator14=indicator14;
			model.indicator15=indicator15;
			model.indicator16=indicator16;
			model.indicator17=indicator17;
			model.indicator18=indicator18;
			model.indicator19=indicator19;
			model.indicator20=indicator20;
			model.indicator21=indicator21;
			model.indicator22=indicator22;
			model.indicator23=indicator23;
			model.indicator24=indicator24;
			model.indicator25=indicator25;
			model.indicator26=indicator26;
			model.indicator27=indicator27;
			model.indicator28=indicator28;
			model.indicator29=indicator29;
			model.indicator30=indicator30;
			model.indicator31=indicator31;
			model.indicator32=indicator32;
			model.indicator33=indicator33;
			model.indicator34=indicator34;
			model.indicator35=indicator35;
			model.indicator36=indicator36;
			model.indicator37=indicator37;
			model.indicator38=indicator38;
			model.indicator39=indicator39;
			model.indicator40=indicator40;
			model.indicator41=indicator41;
			model.indicator42=indicator42;
			model.indicator43=indicator43;
			model.indicator44=indicator44;
			model.indicator45=indicator45;
			model.indicator46=indicator46;
			model.lock_tables=lock_tables;
			model.labor_employment_rate=labor_employment_rate;
			model.disposable_money_per_people=disposable_money_per_people;

			TTG.BLL.TTGWeb.effect_indicator bll=new TTG.BLL.TTGWeb.effect_indicator();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
