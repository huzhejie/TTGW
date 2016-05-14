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
namespace TTG.Web.TTGWeb.community_commerce
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
		TTG.BLL.TTGWeb.community_commerce bll=new TTG.BLL.TTGWeb.community_commerce();
		TTG.Model.TTGWeb.community_commerce model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_come_fac_num.Text=model.community_come_fac_num.ToString();
		this.lblcommunity_come_fac_fs.Text=model.community_come_fac_fs.ToString();
		this.lblcommunity_come_fac_gfa.Text=model.community_come_fac_gfa.ToString();
		this.lblcommunity_come_enp_num.Text=model.community_come_enp_num.ToString();
		this.lblcommunity_come_enp_fs.Text=model.community_come_enp_fs.ToString();
		this.lblcommunity_come_enp_gfa.Text=model.community_come_enp_gfa.ToString();
		this.lblcommunity_emporium_num.Text=model.community_emporium_num.ToString();
		this.lblcommunity_small_supermarket_num.Text=model.community_small_supermarket_num.ToString();
		this.lblcommunity_CVS_num.Text=model.community_CVS_num.ToString();
		this.lblcommunity_restauran_num.Text=model.community_restauran_num.ToString();
		this.lblcommunity_household_appliances_store_num.Text=model.community_household_appliances_store_num.ToString();
		this.lblcommunity_agricultural_production_num.Text=model.community_agricultural_production_num.ToString();
		this.lblcommunity_clothes_store_num.Text=model.community_clothes_store_num.ToString();
		this.lblcommunity_hardware_building_materials_store_num.Text=model.community_hardware_building_materials_store_num.ToString();
		this.lblcommunity_drugstore_num.Text=model.community_drugstore_num.ToString();
		this.lblcommunity_bookstore_num.Text=model.community_bookstore_num.ToString();
		this.lblcommunity_other_come_enp_num.Text=model.community_other_come_enp_num.ToString();
		this.lblcommunity_farm_produce_fair_num.Text=model.community_farm_produce_fair_num.ToString();
		this.lblcommunity_farm_produce_fair_gfa.Text=model.community_farm_produce_fair_gfa.ToString();
		this.lblcommunity_farm_produce_fair_fs.Text=model.community_farm_produce_fair_fs.ToString();
		this.lblcommunity_farm_produce_fair_dis_ots.Text=model.community_farm_produce_fair_dis_ots.ToString();
		this.lblcommunity_pedlar_market_num.Text=model.community_pedlar_market_num.ToString();
		this.lblcommunity_pedlar_market_gfa.Text=model.community_pedlar_market_gfa.ToString();
		this.lblcommunity_pedlar_market_fs.Text=model.community_pedlar_market_fs.ToString();
		this.lblcommunity_pedlar_market_dis_ots.Text=model.community_pedlar_market_dis_ots.ToString();
		this.lblcommunity_farm_whs_market_num.Text=model.community_farm_whs_market_num.ToString();
		this.lblcommunity_farm_whs_market_gfa.Text=model.community_farm_whs_market_gfa.ToString();
		this.lblcommunity_farm_whs_market_fs.Text=model.community_farm_whs_market_fs.ToString();
		this.lblcommunity_farm_whs_market_dis_ots.Text=model.community_farm_whs_market_dis_ots.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltccunset1.Text=model.tccunset1;
		this.lbltccunset2.Text=model.tccunset2;
		this.lbltccunset3.Text=model.tccunset3;
		this.lbltccunset4.Text=model.tccunset4;
		this.lbltccunset5.Text=model.tccunset5;
		this.lbltccunset6.Text=model.tccunset6;
		this.lbltccunset7.Text=model.tccunset7;
		this.lbltccunset8.Text=model.tccunset8;
		this.lbltccunset9.Text=model.tccunset9;
		this.lbltccunset10.Text=model.tccunset10;
		this.lbltccunset11.Text=model.tccunset11;
		this.lbltccunset12.Text=model.tccunset12;
		this.lbltccunset13.Text=model.tccunset13;
		this.lbltccunset14.Text=model.tccunset14;
		this.lbltccunset15.Text=model.tccunset15;
		this.lbltccunset16.Text=model.tccunset16;
		this.lbltccunset17.Text=model.tccunset17;
		this.lbltccunset18.Text=model.tccunset18;
		this.lbltccunset19.Text=model.tccunset19;
		this.lbltccunset20.Text=model.tccunset20;
		this.lbltccunset21.Text=model.tccunset21;
		this.lbltccunset22.Text=model.tccunset22;
		this.lbltccunset23.Text=model.tccunset23;
		this.lbltccunset24.Text=model.tccunset24;
		this.lbltccunset25.Text=model.tccunset25;
		this.lbltccunset26.Text=model.tccunset26;
		this.lbltccunset27.Text=model.tccunset27;
		this.lbltccunset28.Text=model.tccunset28;
		this.lbltccunset29.Text=model.tccunset29;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
