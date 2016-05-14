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
namespace TTG.Web.TTGWeb.community_environmental_hygiene
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
		TTG.BLL.TTGWeb.community_environmental_hygiene bll=new TTG.BLL.TTGWeb.community_environmental_hygiene();
		TTG.Model.TTGWeb.community_environmental_hygiene model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_refuse_transfer_station_num.Text=model.community_refuse_transfer_station_num.ToString();
		this.lblcommunity_refuse_transfer_station_dis_ots.Text=model.community_refuse_transfer_station_dis_ots.ToString();
		this.lblcommunity_refuse_collection_point_num.Text=model.community_refuse_collection_point_num.ToString();
		this.lblcommunity_dustbin_num.Text=model.community_dustbin_num.ToString();
		this.lblrubbish_produce_amount.Text=model.rubbish_produce_amount.ToString();
		this.lbllive_rubbish_produce_year_amount.Text=model.live_rubbish_produce_year_amount.ToString();
		this.lblsolid_rubbish_produce_amount.Text=model.solid_rubbish_produce_amount.ToString();
		this.lblenvironmental_fee_charge_amount.Text=model.environmental_fee_charge_amount.ToString();
		this.lblcommunity_public_toilet_num.Text=model.community_public_toilet_num.ToString();
		this.lblcommunity_public_toilet_space_num.Text=model.community_public_toilet_space_num.ToString();
		this.lblcommunity_public_toilet_inside_300m_num.Text=model.community_public_toilet_inside_300m_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblcommunity_public_toilet_cover_road_length.Text=model.community_public_toilet_cover_road_length.ToString();
		this.lbltcehunset1.Text=model.tcehunset1;
		this.lbltcehunset2.Text=model.tcehunset2;
		this.lbltcehunset3.Text=model.tcehunset3;
		this.lbltcehunset4.Text=model.tcehunset4;
		this.lbltcehunset5.Text=model.tcehunset5;
		this.lbltcehunset6.Text=model.tcehunset6;
		this.lbltcehunset7.Text=model.tcehunset7;
		this.lbltcehunset8.Text=model.tcehunset8;
		this.lbltcehunset9.Text=model.tcehunset9;
		this.lbltcehunset10.Text=model.tcehunset10;
		this.lbltcehunset11.Text=model.tcehunset11;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lblcommunity_public_toilet_area_num.Text=model.community_public_toilet_area_num.ToString();

	}


    }
}
