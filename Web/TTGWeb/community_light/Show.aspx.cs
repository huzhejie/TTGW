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
namespace TTG.Web.TTGWeb.community_light
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
		TTG.BLL.TTGWeb.community_light bll=new TTG.BLL.TTGWeb.community_light();
		TTG.Model.TTGWeb.community_light model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_streetlight_num.Text=model.community_streetlight_num.ToString();
		this.lblcommunity_energy_efficient_streetlight_num.Text=model.community_energy_efficient_streetlight_num.ToString();
		this.lblcommunity_good_streetlight_rate.Text=model.community_good_streetlight_rate.ToString();
		this.lblcommunity_otd_exercise_yard_light_num.Text=model.community_otd_exercise_yard_light_num.ToString();
		this.lblcommunity_otd_good_exercise_yard_light_rate.Text=model.community_otd_good_exercise_yard_light_rate.ToString();
		this.lblcommunity_passageway_light_num.Text=model.community_passageway_light_num.ToString();
		this.lblcommunity_good_passageway_light_rate.Text=model.community_good_passageway_light_rate.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcltunset1.Text=model.tcltunset1;
		this.lbltcltunset2.Text=model.tcltunset2;
		this.lbltcltunset3.Text=model.tcltunset3;
		this.lbltcltunset4.Text=model.tcltunset4;
		this.lbltcltunset5.Text=model.tcltunset5;
		this.lbltcltunset6.Text=model.tcltunset6;
		this.lbltcltunset7.Text=model.tcltunset7;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
