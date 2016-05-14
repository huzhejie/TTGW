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
namespace TTG.Web.TTGWeb.wcommunity
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string wcommunity_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					wcommunity_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(wcommunity_id,statistics_date);
			}
		}
		
	private void ShowInfo(string wcommunity_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.wcommunity bll=new TTG.BLL.TTGWeb.wcommunity();
		TTG.Model.TTGWeb.wcommunity model=bll.GetModel(wcommunity_id,statistics_date);
		this.lblwcommunity_id.Text=model.wcommunity_id;
		this.lblwcommunity_name.Text=model.wcommunity_name;
		this.lblkindergarten_capacity.Text=model.kindergarten_capacity.ToString();
		this.lblintegrated_management_building_area.Text=model.integrated_management_building_area.ToString();
		this.lblmedical_bed_num.Text=model.medical_bed_num.ToString();
		this.lblparking_space_num.Text=model.parking_space_num.ToString();
		this.lblconvenience_stores_area.Text=model.convenience_stores_area.ToString();
		this.lblvegetable_market_area.Text=model.vegetable_market_area.ToString();
		this.lblculture_fitness_facility_area.Text=model.culture_fitness_facility_area.ToString();
		this.lblfacilities_for_elders_area.Text=model.facilities_for_elders_area.ToString();
		this.lbltwunset1.Text=model.twunset1;
		this.lbltwunset2.Text=model.twunset2;
		this.lbltwunset3.Text=model.twunset3;
		this.lbltwunset4.Text=model.twunset4;
		this.lbltwunset5.Text=model.twunset5;
		this.lbltwunset6.Text=model.twunset6;
		this.lbltwunset7.Text=model.twunset7;
		this.lbltwunset8.Text=model.twunset8;
		this.lbltwunset9.Text=model.twunset9;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblwcommunity_family_num.Text=model.wcommunity_family_num.ToString();

	}


    }
}
