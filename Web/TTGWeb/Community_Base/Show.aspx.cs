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
namespace TTG.Web.TTGWeb.Community_Base
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
		TTG.BLL.TTGWeb.Community_Base bll=new TTG.BLL.TTGWeb.Community_Base();
		TTG.Model.TTGWeb.Community_Base model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_name.Text=model.community_name;
		this.lblcommunity_location.Text=model.community_location;
		this.lblcommunity_county.Text=model.community_county;
		this.lblcommunity_type.Text=model.community_type;
		this.lblcommunity_feature.Text=model.community_feature;
		this.lblcommunity_function_area.Text=model.community_function_area;
		this.lblcommunity_function_type.Text=model.community_function_type;
		this.lbldistance_to_county.Text=model.distance_to_county.ToString();
		this.lbldistance_to_street_committees.Text=model.distance_to_street_committees.ToString();
		this.lbldistance_to_main_business_area.Text=model.distance_to_main_business_area.ToString();
		this.lbldistance_to_main_education_area.Text=model.distance_to_main_education_area.ToString();
		this.lbldistance_to_railway_station.Text=model.distance_to_railway_station.ToString();
		this.lbldistance_to_coach_station.Text=model.distance_to_coach_station.ToString();
		this.lbldistance_to_passenger_quay.Text=model.distance_to_passenger_quay.ToString();
		this.lbldistance_to_main_street.Text=model.distance_to_main_street.ToString();
		this.lbldistance_to_collector_street.Text=model.distance_to_collector_street.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltbcunset1.Text=model.tbcunset1;
		this.lbltbcunset2.Text=model.tbcunset2;
		this.lbltbcunset3.Text=model.tbcunset3;
		this.lbltbcunset4.Text=model.tbcunset4;
		this.lbltbcunset5.Text=model.tbcunset5;
		this.lbltbcunset6.Text=model.tbcunset6;
		this.lbltbcunset7.Text=model.tbcunset7;
		this.lbltbcunset8.Text=model.tbcunset8;
		this.lbltbcunset9.Text=model.tbcunset9;
		this.lbltbcunset10.Text=model.tbcunset10;
		this.lbltbcunset11.Text=model.tbcunset11;
		this.lbltbcunset12.Text=model.tbcunset12;
		this.lbltbcunset13.Text=model.tbcunset13;
		this.lbltbcunset14.Text=model.tbcunset14;
		this.lbltbcunset15.Text=model.tbcunset15;
		this.lbltbcunset16.Text=model.tbcunset16;
		this.lbltbcunset17.Text=model.tbcunset17;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcommunity_wcommunity.Text=model.community_wcommunity;
		this.lblcommunity_category.Text=model.community_category;
		this.lblcommunity_construct_year.Text=model.community_construct_year.ToString();
		this.lblcommunity_province.Text=model.community_province;

	}


    }
}
