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
namespace TTG.Web.TTGWeb.community_parking_lot
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
		TTG.BLL.TTGWeb.community_parking_lot bll=new TTG.BLL.TTGWeb.community_parking_lot();
		TTG.Model.TTGWeb.community_parking_lot model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_parking_space_num.Text=model.community_parking_space_num.ToString();
		this.lblcommunity_parking_rate.Text=model.community_parking_rate.ToString();
		this.lblcommunity_parking_space_use_rate.Text=model.community_parking_space_use_rate.ToString();
		this.lblcommunity_public_parking_lot_num.Text=model.community_public_parking_lot_num.ToString();
		this.lblcommunity_public_grand_parking_lot_num.Text=model.community_public_grand_parking_lot_num.ToString();
		this.lblcommunity_public_underg_parking_lot_num.Text=model.community_public_underg_parking_lot_num.ToString();
		this.lblcommunity_public_overg_parking_lot_num.Text=model.community_public_overg_parking_lot_num.ToString();
		this.lblcommunity_public_parking_lot_area.Text=model.community_public_parking_lot_area.ToString();
		this.lblcommunity_public_parking_space_num.Text=model.community_public_parking_space_num.ToString();
		this.lblcommunity_public_parking_lot_area_rate.Text=model.community_public_parking_lot_area_rate.ToString();
		this.lbldis_150m_public_parking_lot_num.Text=model.dis_150m_public_parking_lot_num.ToString();
		this.lbldis_150m_public_parking_lot_area.Text=model.dis_150m_public_parking_lot_area.ToString();
		this.lbldis_150m_public_parking_space_num.Text=model.dis_150m_public_parking_space_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcplunset1.Text=model.tcplunset1;
		this.lbltcplunset2.Text=model.tcplunset2;
		this.lbltcplunset3.Text=model.tcplunset3;
		this.lbltcplunset4.Text=model.tcplunset4;
		this.lbltcplunset5.Text=model.tcplunset5;
		this.lbltcplunset6.Text=model.tcplunset6;
		this.lbltcplunset7.Text=model.tcplunset7;
		this.lbltcplunset8.Text=model.tcplunset8;
		this.lbltcplunset9.Text=model.tcplunset9;
		this.lbltcplunset10.Text=model.tcplunset10;
		this.lbltcplunset11.Text=model.tcplunset11;
		this.lbltcplunset12.Text=model.tcplunset12;
		this.lbltcplunset13.Text=model.tcplunset13;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
