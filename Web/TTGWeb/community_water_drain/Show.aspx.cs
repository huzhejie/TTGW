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
namespace TTG.Web.TTGWeb.community_water_drain
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
		TTG.BLL.TTGWeb.community_water_drain bll=new TTG.BLL.TTGWeb.community_water_drain();
		TTG.Model.TTGWeb.community_water_drain model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_water_drain_mechanism.Text=model.community_water_drain_mechanism;
		this.lblcommunity_domestic_sewage_consumption.Text=model.community_domestic_sewage_consumption.ToString();
		this.lblcommunity_water_drain_pipe_length.Text=model.community_water_drain_pipe_length.ToString();
		this.lblcommunity_water_drain_main_pipe_length.Text=model.community_water_drain_main_pipe_length.ToString();
		this.lblcommunity_water_drain_pipe_branch_length.Text=model.community_water_drain_pipe_branch_length.ToString();
		this.lblcommunity_water_drain_service_pipe_length.Text=model.community_water_drain_service_pipe_length.ToString();
		this.lblcommunity_water_drain_canal_length.Text=model.community_water_drain_canal_length.ToString();
		this.lblcommunity_water_open_drain_canal_length.Text=model.community_water_open_drain_canal_length.ToString();
		this.lblcommunity_septic_tank_num.Text=model.community_septic_tank_num.ToString();
		this.lblcommunity_septic_tank_capacity.Text=model.community_septic_tank_capacity.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcwdunset1.Text=model.tcwdunset1;
		this.lbltcwdunset2.Text=model.tcwdunset2;
		this.lbltcwdunset3.Text=model.tcwdunset3;
		this.lbltcwdunset4.Text=model.tcwdunset4;
		this.lbltcwdunset5.Text=model.tcwdunset5;
		this.lbltcwdunset6.Text=model.tcwdunset6;
		this.lbltcwdunset7.Text=model.tcwdunset7;
		this.lbltcwdunset8.Text=model.tcwdunset8;
		this.lbltcwdunset9.Text=model.tcwdunset9;
		this.lbltcwdunset10.Text=model.tcwdunset10;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
