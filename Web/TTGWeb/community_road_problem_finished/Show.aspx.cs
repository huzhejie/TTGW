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
namespace TTG.Web.TTGWeb.community_road_problem_finished
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
		TTG.BLL.TTGWeb.community_road_problem_finished bll=new TTG.BLL.TTGWeb.community_road_problem_finished();
		TTG.Model.TTGWeb.community_road_problem_finished model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_road_hardening_area.Text=model.community_road_hardening_area.ToString();
		this.lblcommunity_road_maintain_reform_num.Text=model.community_road_maintain_reform_num.ToString();
		this.lblcommunity_road_maintain_reform_len.Text=model.community_road_maintain_reform_len.ToString();
		this.lblcommunity_road_maintain_reform_area.Text=model.community_road_maintain_reform_area.ToString();
		this.lblcommunity_pavement_colorful_brick_len.Text=model.community_pavement_colorful_brick_len.ToString();
		this.lblcommunity_pavement_colorful_brick_area.Text=model.community_pavement_colorful_brick_area.ToString();
		this.lblcommunity_added_road_num.Text=model.community_added_road_num.ToString();
		this.lblcommunity_added_road_area.Text=model.community_added_road_area.ToString();
		this.lblcommunity_road_maintain_reform_num_ots.Text=model.community_road_maintain_reform_num_ots.ToString();
		this.lblcommunity_road_maintain_reform_len_ots.Text=model.community_road_maintain_reform_len_ots.ToString();
		this.lblcommunity_road_maintain_reform_area_ots.Text=model.community_road_maintain_reform_area_ots.ToString();
		this.lblcommunity_added_vehicles_road_num.Text=model.community_added_vehicles_road_num.ToString();
		this.lblcommunity_added_vehicles_road_area.Text=model.community_added_vehicles_road_area.ToString();
		this.lblcommunity_white_change_black_road_num.Text=model.community_white_change_black_road_num.ToString();
		this.lblcommunity_white_change_black_road_area.Text=model.community_white_change_black_road_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lbltciunset5.Text=model.tciunset5;
		this.lbltciunset6.Text=model.tciunset6;
		this.lbltciunset7.Text=model.tciunset7;
		this.lbltciunset8.Text=model.tciunset8;
		this.lbltciunset9.Text=model.tciunset9;
		this.lbltciunset10.Text=model.tciunset10;
		this.lbltciunset11.Text=model.tciunset11;
		this.lbltciunset12.Text=model.tciunset12;
		this.lbltciunset13.Text=model.tciunset13;
		this.lbltciunset14.Text=model.tciunset14;
		this.lbltciunset15.Text=model.tciunset15;
		this.lbltciunset16.Text=model.tciunset16;
		this.lbltciunset17.Text=model.tciunset17;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcommunity_added_road_num_for_update.Text=model.community_added_road_num_for_update.ToString();
		this.lblcommunity_added_road_area_for_update.Text=model.community_added_road_area_for_update.ToString();

	}


    }
}
