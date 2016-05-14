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
namespace TTG.Web.TTGWeb.community_traffic
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
		TTG.BLL.TTGWeb.community_traffic bll=new TTG.BLL.TTGWeb.community_traffic();
		TTG.Model.TTGWeb.community_traffic model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_passenger_station_num.Text=model.community_passenger_station_num.ToString();
		this.lblcommunity_station_waiting_room_area.Text=model.community_station_waiting_room_area.ToString();
		this.lblcommunity_station_parking_lot_area.Text=model.community_station_parking_lot_area.ToString();
		this.lblcommunity_bus_trips.Text=model.community_bus_trips.ToString();
		this.lblcommunity_quay_num.Text=model.community_quay_num.ToString();
		this.lblcommunity_passenger_and_goods_quay_num.Text=model.community_passenger_and_goods_quay_num.ToString();
		this.lblcommunity_goods_quay_num.Text=model.community_goods_quay_num.ToString();
		this.lblcommunity_passenger_quay_num.Text=model.community_passenger_quay_num.ToString();
		this.lblcommunity_docking_point.Text=model.community_docking_point.ToString();
		this.lblcommunity_passenger_quay_waiting_room_area.Text=model.community_passenger_quay_waiting_room_area.ToString();
		this.lblcommunity_passenger_quay_parking_lot_area.Text=model.community_passenger_quay_parking_lot_area.ToString();
		this.lblcommunity_passenger_quay_ship_trips.Text=model.community_passenger_quay_ship_trips.ToString();
		this.lblcommunity_passenger_quay_dis_to_county.Text=model.community_passenger_quay_dis_to_county.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltctunset1.Text=model.tctunset1;
		this.lbltctunset2.Text=model.tctunset2;
		this.lbltctunset3.Text=model.tctunset3;
		this.lbltctunset4.Text=model.tctunset4;
		this.lbltctunset5.Text=model.tctunset5;
		this.lbltctunset6.Text=model.tctunset6;
		this.lbltctunset7.Text=model.tctunset7;
		this.lbltctunset8.Text=model.tctunset8;
		this.lbltctunset9.Text=model.tctunset9;
		this.lbltctunset10.Text=model.tctunset10;
		this.lbltctunset11.Text=model.tctunset11;
		this.lbltctunset12.Text=model.tctunset12;
		this.lbltctunset13.Text=model.tctunset13;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
