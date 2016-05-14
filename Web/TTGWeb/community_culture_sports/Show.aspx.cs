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
namespace TTG.Web.TTGWeb.community_culture_sports
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
		TTG.BLL.TTGWeb.community_culture_sports bll=new TTG.BLL.TTGWeb.community_culture_sports();
		TTG.Model.TTGWeb.community_culture_sports model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_culture_sports_fs.Text=model.community_culture_sports_fs.ToString();
		this.lblcommunity_culture_sports_gfa.Text=model.community_culture_sports_gfa.ToString();
		this.lblcommunity_otd_cul_spo_fac_num.Text=model.community_otd_cul_spo_fac_num.ToString();
		this.lblcommunity_otd_cul_spo_fac_gfa.Text=model.community_otd_cul_spo_fac_gfa.ToString();
		this.lblcommunity_cul_squ_num.Text=model.community_cul_squ_num.ToString();
		this.lblcommunity_cul_squ_fs.Text=model.community_cul_squ_fs.ToString();
		this.lblcommunity_otd_entm_num.Text=model.community_otd_entm_num.ToString();
		this.lblcommunity_otd_entm_fs.Text=model.community_otd_entm_fs.ToString();
		this.lblcommunity_child_plg_num.Text=model.community_child_plg_num.ToString();
		this.lblcommunity_child_plg_fs.Text=model.community_child_plg_fs.ToString();
		this.lblcommunity_ind_actv_spa_num.Text=model.community_ind_actv_spa_num.ToString();
		this.lblcommunity_ind_actv_spa_fs.Text=model.community_ind_actv_spa_fs.ToString();
		this.lblcommunity_ind_actv_spa_gfa.Text=model.community_ind_actv_spa_gfa.ToString();
		this.lblcommunity_cul_sta_num.Text=model.community_cul_sta_num.ToString();
		this.lblcommunity_cul_sta_fs.Text=model.community_cul_sta_fs.ToString();
		this.lblcommunity_cul_sta_gfa.Text=model.community_cul_sta_gfa.ToString();
		this.lblcommunity_cul_room_num.Text=model.community_cul_room_num.ToString();
		this.lblcommunity_cul_room_fs.Text=model.community_cul_room_fs.ToString();
		this.lblcommunity_cul_room_gfa.Text=model.community_cul_room_gfa.ToString();
		this.lblcommunity_fit_fac_num.Text=model.community_fit_fac_num.ToString();
		this.lblcommunity_fit_fac_intact_rate.Text=model.community_fit_fac_intact_rate.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltccsunset1.Text=model.tccsunset1;
		this.lbltccsunset2.Text=model.tccsunset2;
		this.lbltccsunset3.Text=model.tccsunset3;
		this.lbltccsunset4.Text=model.tccsunset4;
		this.lbltccsunset5.Text=model.tccsunset5;
		this.lbltccsunset6.Text=model.tccsunset6;
		this.lbltccsunset7.Text=model.tccsunset7;
		this.lbltccsunset8.Text=model.tccsunset8;
		this.lbltccsunset9.Text=model.tccsunset9;
		this.lbltccsunset10.Text=model.tccsunset10;
		this.lbltccsunset11.Text=model.tccsunset11;
		this.lbltccsunset12.Text=model.tccsunset12;
		this.lbltccsunset13.Text=model.tccsunset13;
		this.lbltccsunset14.Text=model.tccsunset14;
		this.lbltccsunset15.Text=model.tccsunset15;
		this.lbltccsunset16.Text=model.tccsunset16;
		this.lbltccsunset17.Text=model.tccsunset17;
		this.lbltccsunset18.Text=model.tccsunset18;
		this.lbltccsunset19.Text=model.tccsunset19;
		this.lbltccsunset20.Text=model.tccsunset20;
		this.lbltccsunset21.Text=model.tccsunset21;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
