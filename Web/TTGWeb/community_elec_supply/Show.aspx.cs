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
namespace TTG.Web.TTGWeb.community_elec_supply
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
		TTG.BLL.TTGWeb.community_elec_supply bll=new TTG.BLL.TTGWeb.community_elec_supply();
		TTG.Model.TTGWeb.community_elec_supply model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_load_dispatching_office_num.Text=model.community_load_dispatching_office_num.ToString();
		this.lblcommunity_transformer_num.Text=model.community_transformer_num.ToString();
		this.lblbelow_100kva_transformer_num.Text=model.below_100kva_transformer_num.ToString();
		this.lblat_100_500kva_transformer_num.Text=model.at_100_500kva_transformer_num.ToString();
		this.lblat_500_1000kva_transformer_num.Text=model.at_500_1000kva_transformer_num.ToString();
		this.lblmore_1000kva_transformer_num.Text=model.more_1000kva_transformer_num.ToString();
		this.lblcommunity_elec_supply_wireways_length.Text=model.community_elec_supply_wireways_length.ToString();
		this.lblcommunity_power_transmission_line_length.Text=model.community_power_transmission_line_length.ToString();
		this.lblcommunity_high_voltage_distr_line_legth.Text=model.community_high_voltage_distr_line_legth.ToString();
		this.lblcommunity_low_voltage_distr_line_legth.Text=model.community_low_voltage_distr_line_legth.ToString();
		this.lblcommunity_elec_supply_consumption.Text=model.community_elec_supply_consumption.ToString();
		this.lblcommunity_resident_elec_consumption.Text=model.community_resident_elec_consumption.ToString();
		this.lblno_elec_days.Text=model.no_elec_days.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcesunset1.Text=model.tcesunset1;
		this.lbltcesunset2.Text=model.tcesunset2;
		this.lbltcesunset3.Text=model.tcesunset3;
		this.lbltcesunset4.Text=model.tcesunset4;
		this.lbltcesunset5.Text=model.tcesunset5;
		this.lbltcesunset6.Text=model.tcesunset6;
		this.lbltcesunset7.Text=model.tcesunset7;
		this.lbltcesunset8.Text=model.tcesunset8;
		this.lbltcesunset9.Text=model.tcesunset9;
		this.lbltcesunset10.Text=model.tcesunset10;
		this.lbltcesunset11.Text=model.tcesunset11;
		this.lbltcesunset12.Text=model.tcesunset12;
		this.lbltcesunset13.Text=model.tcesunset13;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
