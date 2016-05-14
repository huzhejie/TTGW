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
namespace TTG.Web.TTGWeb.community_immigrant
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
		TTG.BLL.TTGWeb.community_immigrant bll=new TTG.BLL.TTGWeb.community_immigrant();
		TTG.Model.TTGWeb.community_immigrant model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblimmigrant_total_family_num.Text=model.immigrant_total_family_num.ToString();
		this.lblimmigrant_total_population.Text=model.immigrant_total_population.ToString();
		this.lblcommunity_pure_resident_pop.Text=model.community_pure_resident_pop.ToString();
		this.lblcommunity_depart_pop.Text=model.community_depart_pop.ToString();
		this.lblcommunity_enp_staves.Text=model.community_enp_staves.ToString();
		this.lblcommunity_enp_laidoff_staves.Text=model.community_enp_laidoff_staves.ToString();
		this.lblcommunity_have_land_pop.Text=model.community_have_land_pop.ToString();
		this.lblcommunity_rural_to_town_pop.Text=model.community_rural_to_town_pop.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcimunset1.Text=model.tcimunset1;
		this.lbltcimunset2.Text=model.tcimunset2;
		this.lbltcimunset3.Text=model.tcimunset3;
		this.lbltcimunset4.Text=model.tcimunset4;
		this.lbltcimunset5.Text=model.tcimunset5;
		this.lbltcimunset6.Text=model.tcimunset6;
		this.lbltcimunset7.Text=model.tcimunset7;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
