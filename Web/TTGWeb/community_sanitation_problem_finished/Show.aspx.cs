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
namespace TTG.Web.TTGWeb.community_sanitation_problem_finished
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
		TTG.BLL.TTGWeb.community_sanitation_problem_finished bll=new TTG.BLL.TTGWeb.community_sanitation_problem_finished();
		TTG.Model.TTGWeb.community_sanitation_problem_finished model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_added_ashbin_num.Text=model.community_added_ashbin_num.ToString();
		this.lblcommunity_added_dustbin_num.Text=model.community_added_dustbin_num.ToString();
		this.lblcommunity_public_toilet_num.Text=model.community_public_toilet_num.ToString();
		this.lblcommunity_public_toilet_area.Text=model.community_public_toilet_area.ToString();
		this.lblcommunity_added_waste_transfer_station_num.Text=model.community_added_waste_transfer_station_num.ToString();
		this.lblcommunity_added_waste_transfer_station_area.Text=model.community_added_waste_transfer_station_area.ToString();
		this.lblcommunity_added_ashbin_dustbin_num.Text=model.community_added_ashbin_dustbin_num.ToString();
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
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcommunity_public_toilet_num_f_update.Text=model.community_public_toilet_num_f_update.ToString();
		this.lblcommunity_public_toilet_area_f_update.Text=model.community_public_toilet_area_f_update.ToString();

	}


    }
}
