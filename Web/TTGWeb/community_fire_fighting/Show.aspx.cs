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
namespace TTG.Web.TTGWeb.community_fire_fighting
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
		TTG.BLL.TTGWeb.community_fire_fighting bll=new TTG.BLL.TTGWeb.community_fire_fighting();
		TTG.Model.TTGWeb.community_fire_fighting model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_extinguisher_num.Text=model.community_extinguisher_num.ToString();
		this.lblcommunity_good_extinguisher_rate.Text=model.community_good_extinguisher_rate.ToString();
		this.lblcommunity_hydrant_num.Text=model.community_hydrant_num.ToString();
		this.lblcommunity_ots_hydrant_num.Text=model.community_ots_hydrant_num.ToString();
		this.lblcommunity_good_ots_hydrant_rate.Text=model.community_good_ots_hydrant_rate.ToString();
		this.lblcommunity_ind_hydrant_num.Text=model.community_ind_hydrant_num.ToString();
		this.lblcommunity_good_ind_hydrant_rate.Text=model.community_good_ind_hydrant_rate.ToString();
		this.lblcommunity_ff_pipe_length.Text=model.community_ff_pipe_length.ToString();
		this.lblcommunity_ff_pipe_caliber_larger_than_100mm_length.Text=model.community_ff_pipe_caliber_larger_than_100mm_length.ToString();
		this.lblcommunity_ff_pipe_caliber_less_than_100mm_length.Text=model.community_ff_pipe_caliber_less_than_100mm_length.ToString();
		this.lblsource_of_ff_water_num.Text=model.source_of_ff_water_num.ToString();
		this.lblnatural_ff_water_source_num.Text=model.natural_ff_water_source_num.ToString();
		this.lblmunicipal_administration_pipe_net_ff_water_source.Text=model.municipal_administration_pipe_net_ff_water_source.ToString();
		this.lblff_water_pool_num.Text=model.ff_water_pool_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcffunset1.Text=model.tcffunset1;
		this.lbltcffunset2.Text=model.tcffunset2;
		this.lbltcffunset3.Text=model.tcffunset3;
		this.lbltcffunset4.Text=model.tcffunset4;
		this.lbltcffunset5.Text=model.tcffunset5;
		this.lbltcffunset6.Text=model.tcffunset6;
		this.lbltcffunset7.Text=model.tcffunset7;
		this.lbltcffunset8.Text=model.tcffunset8;
		this.lbltcffunset9.Text=model.tcffunset9;
		this.lbltcffunset10.Text=model.tcffunset10;
		this.lbltcffunset11.Text=model.tcffunset11;
		this.lbltcffunset12.Text=model.tcffunset12;
		this.lbltcffunset13.Text=model.tcffunset13;
		this.lbltcffunset14.Text=model.tcffunset14;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
