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
namespace TTG.Web.TTGWeb.community_geologic_hazard
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
		TTG.BLL.TTGWeb.community_geologic_hazard bll=new TTG.BLL.TTGWeb.community_geologic_hazard();
		TTG.Model.TTGWeb.community_geologic_hazard model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblserious_geologic_hazard_num.Text=model.serious_geologic_hazard_num.ToString();
		this.lblserious_geologic_hazard_handle_num.Text=model.serious_geologic_hazard_handle_num.ToString();
		this.lblinfluence_house_area.Text=model.influence_house_area.ToString();
		this.lblprotect_house_area.Text=model.protect_house_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcghunset1.Text=model.tcghunset1;
		this.lbltcghunset2.Text=model.tcghunset2;
		this.lbltcghunset3.Text=model.tcghunset3;
		this.lbltcghunset4.Text=model.tcghunset4;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
