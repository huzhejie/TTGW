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
namespace TTG.Web.TTGWeb.community_shop_front
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
		TTG.BLL.TTGWeb.community_shop_front bll=new TTG.BLL.TTGWeb.community_shop_front();
		TTG.Model.TTGWeb.community_shop_front model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_shop_front_num.Text=model.community_shop_front_num.ToString();
		this.lblcommunity_shop_front_in_main_street_num.Text=model.community_shop_front_in_main_street_num.ToString();
		this.lblcommunity_shop_front_in_collector_street_num.Text=model.community_shop_front_in_collector_street_num.ToString();
		this.lblcommunity_shop_front_in_alley_num.Text=model.community_shop_front_in_alley_num.ToString();
		this.lblcommunity_back_street_shop_front_num.Text=model.community_back_street_shop_front_num.ToString();
		this.lblcommunity_shop_front_area.Text=model.community_shop_front_area.ToString();
		this.lblcommunity_immigrant_shop_front_num.Text=model.community_immigrant_shop_front_num.ToString();
		this.lblcommunity_immigrant_shop_front_area.Text=model.community_immigrant_shop_front_area.ToString();
		this.lblcommunity_immigrant_run_shop_front_num.Text=model.community_immigrant_run_shop_front_num.ToString();
		this.lblcommunity_immigrant_run_shop_front_area.Text=model.community_immigrant_run_shop_front_area.ToString();
		this.lblcommunity_immigrant_rent_out_shop_front_num.Text=model.community_immigrant_rent_out_shop_front_num.ToString();
		this.lblcommunity_immigrant_rent_out_shop_front_area.Text=model.community_immigrant_rent_out_shop_front_area.ToString();
		this.lblcommunity_immigrant_unused_shop_front_num.Text=model.community_immigrant_unused_shop_front_num.ToString();
		this.lblcommunity_immigrant_unused_shop_front_area.Text=model.community_immigrant_unused_shop_front_area.ToString();
		this.lblcommunity_shop_front_amount.Text=model.community_shop_front_amount.ToString();
		this.lblcommunity_catering_shop_front_num.Text=model.community_catering_shop_front_num.ToString();
		this.lblcommunity_accommodation_shop_front_num.Text=model.community_accommodation_shop_front_num.ToString();
		this.lblcommunity_commodity_shop_front_num.Text=model.community_commodity_shop_front_num.ToString();
		this.lblcommunity_means_of_production_shop_front_num.Text=model.community_means_of_production_shop_front_num.ToString();
		this.lblcommunity_automobile_service_shop_front_num.Text=model.community_automobile_service_shop_front_num.ToString();
		this.lblcommunity_other__shop_front_num.Text=model.community_other__shop_front_num.ToString();
		this.lblcommunity_average_rent_of_shop_front.Text=model.community_average_rent_of_shop_front.ToString();
		this.lblcommunity_average_rent_time_of_shop_front.Text=model.community_average_rent_time_of_shop_front;
		this.lblcommunity_average_price_shop_front.Text=model.community_average_price_shop_front.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();

	}


    }
}
