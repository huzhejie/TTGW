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
namespace TTG.Web.TTGWeb.community_green_fields
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
		TTG.BLL.TTGWeb.community_green_fields bll=new TTG.BLL.TTGWeb.community_green_fields();
		TTG.Model.TTGWeb.community_green_fields model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_green_fields_area.Text=model.community_green_fields_area.ToString();
		this.lblcommunity_park_green_fields_area.Text=model.community_park_green_fields_area.ToString();
		this.lblcommunity_garden_green_fields_area.Text=model.community_garden_green_fields_area.ToString();
		this.lblcommunity_other_green_fields_area.Text=model.community_other_green_fields_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblcommunity_green_fields_bet_dwellings_area.Text=model.community_green_fields_bet_dwellings_area.ToString();
		this.lblcommunity_road_green_fields_area.Text=model.community_road_green_fields_area.ToString();
		this.lblcommunity_public_accomm_green_fields_area.Text=model.community_public_accomm_green_fields_area.ToString();
		this.lbltcgfunset1.Text=model.tcgfunset1;
		this.lbltcgfunset2.Text=model.tcgfunset2;
		this.lbltcgfunset3.Text=model.tcgfunset3;
		this.lbltcgfunset4.Text=model.tcgfunset4;
		this.lbltcgfunset5.Text=model.tcgfunset5;
		this.lbltcgfunset6.Text=model.tcgfunset6;
		this.lbltcgfunset7.Text=model.tcgfunset7;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
