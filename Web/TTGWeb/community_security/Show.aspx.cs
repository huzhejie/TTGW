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
namespace TTG.Web.TTGWeb.community_security
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
		TTG.BLL.TTGWeb.community_security bll=new TTG.BLL.TTGWeb.community_security();
		TTG.Model.TTGWeb.community_security model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_unit_can_build_guard_room_num.Text=model.community_unit_can_build_guard_room_num.ToString();
		this.lblcommunity_unit_with_guard_room_num.Text=model.community_unit_with_guard_room_num.ToString();
		this.lblcommunity_unit_can_install_mf_num.Text=model.community_unit_can_install_mf_num.ToString();
		this.lblcommunity_unit_with_mf_num.Text=model.community_unit_with_mf_num.ToString();
		this.lblcommunity_unit_can_build_fence_num.Text=model.community_unit_can_build_fence_num.ToString();
		this.lblcommunity_unit_with_fence_num.Text=model.community_unit_with_fence_num.ToString();
		this.lblcommunity_emergency_shelter_area.Text=model.community_emergency_shelter_area.ToString();
		this.lblcommunity_civil_air_defence_facilities_num.Text=model.community_civil_air_defence_facilities_num.ToString();
		this.lblcommunity_civil_air_defence_facilities_area.Text=model.community_civil_air_defence_facilities_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblcommunity_unit_can_build_gate_num.Text=model.community_unit_can_build_gate_num.ToString();
		this.lblcommunity_with_gate_num.Text=model.community_with_gate_num.ToString();
		this.lbltcsunset1.Text=model.tcsunset1;
		this.lbltcsunset2.Text=model.tcsunset2;
		this.lbltcsunset3.Text=model.tcsunset3;
		this.lbltcsunset4.Text=model.tcsunset4;
		this.lbltcsunset5.Text=model.tcsunset5;
		this.lbltcsunset6.Text=model.tcsunset6;
		this.lbltcsunset7.Text=model.tcsunset7;
		this.lbltcsunset8.Text=model.tcsunset8;
		this.lbltcsunset9.Text=model.tcsunset9;
		this.lbltcsunset10.Text=model.tcsunset10;
		this.lbltcsunset11.Text=model.tcsunset11;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
