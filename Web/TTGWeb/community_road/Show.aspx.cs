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
namespace TTG.Web.TTGWeb.community_road
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
		TTG.BLL.TTGWeb.community_road bll=new TTG.BLL.TTGWeb.community_road();
		TTG.Model.TTGWeb.community_road model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_road_length.Text=model.community_road_length.ToString();
		this.lblcommunity_road_area.Text=model.community_road_area.ToString();
		this.lblcommunity_road_width_bet_14_and_24_length.Text=model.community_road_width_bet_14_and_24_length.ToString();
		this.lblcommunity_road_width_bet_14_and_24_area.Text=model.community_road_width_bet_14_and_24_area.ToString();
		this.lblcommunity_road_width_bet_10_and_14_length.Text=model.community_road_width_bet_10_and_14_length.ToString();
		this.lblcommunity_road_width_bet_10_and_14_area.Text=model.community_road_width_bet_10_and_14_area.ToString();
		this.lblcommunity_road_width_bet_6_and_9_length.Text=model.community_road_width_bet_6_and_9_length.ToString();
		this.lblcommunity_road_width_bet_6_and_9_area.Text=model.community_road_width_bet_6_and_9_area.ToString();
		this.lblcommunity_road_width_bet_3_and_5_length.Text=model.community_road_width_bet_3_and_5_length.ToString();
		this.lblcommunity_road_width_bet_3_and_5_area.Text=model.community_road_width_bet_3_and_5_area.ToString();
		this.lblcommunity_road_pavement_area.Text=model.community_road_pavement_area.ToString();
		this.lblcommunity_road_pavement_colorful_brick_area.Text=model.community_road_pavement_colorful_brick_area.ToString();
		this.lblcommunity_road_bet_dwellings_length.Text=model.community_road_bet_dwellings_length.ToString();
		this.lblcommunity_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length.Text=model.community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length.ToString();
		this.lblcommunity_pavement_length.Text=model.community_pavement_length.ToString();
		this.lblcommunity_pavement_area.Text=model.community_pavement_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblcommunity_road_num.Text=model.community_road_num.ToString();
		this.lbltcrunset1.Text=model.tcrunset1;
		this.lbltcrunset2.Text=model.tcrunset2;
		this.lbltcrunset3.Text=model.tcrunset3;
		this.lbltcrunset4.Text=model.tcrunset4;
		this.lbltcrunset5.Text=model.tcrunset5;
		this.lbltcrunset6.Text=model.tcrunset6;
		this.lbltcrunset7.Text=model.tcrunset7;
		this.lbltcrunset8.Text=model.tcrunset8;
		this.lbltcrunset9.Text=model.tcrunset9;
		this.lbltcrunset10.Text=model.tcrunset10;
		this.lbltcrunset11.Text=model.tcrunset11;
		this.lbltcrunset12.Text=model.tcrunset12;
		this.lbltcrunset13.Text=model.tcrunset13;
		this.lbltcrunset14.Text=model.tcrunset14;
		this.lbltcrunset15.Text=model.tcrunset15;
		this.lbltcrunset16.Text=model.tcrunset16;
		this.lbltcrunset17.Text=model.tcrunset17;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
