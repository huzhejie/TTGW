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
namespace TTG.Web.TTGWeb.community_population
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
		TTG.BLL.TTGWeb.community_population bll=new TTG.BLL.TTGWeb.community_population();
		TTG.Model.TTGWeb.community_population model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_total_pop.Text=model.community_total_pop.ToString();
		this.lblcommunity_reg_pop.Text=model.community_reg_pop.ToString();
		this.lblcommunity_perm_pop.Text=model.community_perm_pop.ToString();
		this.lblcommunity_man_pop.Text=model.community_man_pop.ToString();
		this.lblcommunity_female_pop.Text=model.community_female_pop.ToString();
		this.lblcommunity_younger_6_pop.Text=model.community_younger_6_pop.ToString();
		this.lblcommunity_bet_7_and_15_pop.Text=model.community_bet_7_and_15_pop.ToString();
		this.lblcommunity_bet_16_and_29_pop.Text=model.community_bet_16_and_29_pop.ToString();
		this.lblcommunity_bet_30_and_39_pop.Text=model.community_bet_30_and_39_pop.ToString();
		this.lblcommunity_bet_40_and_49_pop.Text=model.community_bet_40_and_49_pop.ToString();
		this.lblcommunity_older_50_pop.Text=model.community_older_50_pop.ToString();
		this.lblcommunity_illiteracy_pop.Text=model.community_illiteracy_pop.ToString();
		this.lblcommunity_prim_school_edu_pop.Text=model.community_prim_school_edu_pop.ToString();
		this.lblcommunity_junior_high_school_edu_pop.Text=model.community_junior_high_school_edu_pop.ToString();
		this.lblcommunity_senior_high_school_edu_pop.Text=model.community_senior_high_school_edu_pop.ToString();
		this.lblcommunity_junior_college_edu_pop.Text=model.community_junior_college_edu_pop.ToString();
		this.lblaverage_education_time.Text=model.average_education_time.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcpunset1.Text=model.tcpunset1;
		this.lbltcpunset2.Text=model.tcpunset2;
		this.lbltcpunset3.Text=model.tcpunset3;
		this.lbltcpunset4.Text=model.tcpunset4;
		this.lbltcpunset5.Text=model.tcpunset5;
		this.lbltcpunset6.Text=model.tcpunset6;
		this.lbltcpunset7.Text=model.tcpunset7;
		this.lbltcpunset8.Text=model.tcpunset8;
		this.lbltcpunset10.Text=model.tcpunset10;
		this.lbltcpunset11.Text=model.tcpunset11;
		this.lbltcpunset12.Text=model.tcpunset12;
		this.lbltcpunset13.Text=model.tcpunset13;
		this.lbltcpunset14.Text=model.tcpunset14;
		this.lbltcpunset15.Text=model.tcpunset15;
		this.lbltcpunset16.Text=model.tcpunset16;
		this.lbltcpunset17.Text=model.tcpunset17;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcommunity_family_num.Text=model.community_family_num.ToString();

	}


    }
}
