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
namespace TTG.Web.TTGWeb.community_water_supply
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
		TTG.BLL.TTGWeb.community_water_supply bll=new TTG.BLL.TTGWeb.community_water_supply();
		TTG.Model.TTGWeb.community_water_supply model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_water_supply_pipe_length.Text=model.community_water_supply_pipe_length.ToString();
		this.lblcommunity_water_supply_main_pipe_length.Text=model.community_water_supply_main_pipe_length.ToString();
		this.lblcommunity_water_supply_pipe_branch_length.Text=model.community_water_supply_pipe_branch_length.ToString();
		this.lblcommunity_water_supply_service_pipe_length.Text=model.community_water_supply_service_pipe_length.ToString();
		this.lblcommunity_water_supply_consumption.Text=model.community_water_supply_consumption.ToString();
		this.lblcommunity_per_capita_water_supply_consumption.Text=model.community_per_capita_water_supply_consumption.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcwsunset1.Text=model.tcwsunset1;
		this.lbltcwsunset2.Text=model.tcwsunset2;
		this.lbltcwsunset3.Text=model.tcwsunset3;
		this.lbltcwsunset4.Text=model.tcwsunset4;
		this.lbltcwsunset5.Text=model.tcwsunset5;
		this.lbltcwsunset6.Text=model.tcwsunset6;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
