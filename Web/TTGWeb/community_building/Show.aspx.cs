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
namespace TTG.Web.TTGWeb.community_building
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
		TTG.BLL.TTGWeb.community_building bll=new TTG.BLL.TTGWeb.community_building();
		TTG.Model.TTGWeb.community_building model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_building_total_gfa.Text=model.community_building_total_gfa.ToString();
		this.lblcommunity_building_total_fs.Text=model.community_building_total_fs.ToString();
		this.lblcommunity_building_total_num.Text=model.community_building_total_num.ToString();
		this.lblcommunity_house_gfa.Text=model.community_house_gfa.ToString();
		this.lblcommunity_house_fs.Text=model.community_house_fs.ToString();
		this.lblcommunity_house_num.Text=model.community_house_num.ToString();
		this.lblcommunity_edu_gfa.Text=model.community_edu_gfa.ToString();
		this.lblcommunity_edu_fs.Text=model.community_edu_fs.ToString();
		this.lblcommunity_edu_num.Text=model.community_edu_num.ToString();
		this.lblcommunity_medical_gfa.Text=model.community_medical_gfa.ToString();
		this.lblcommunity_medical_fs.Text=model.community_medical_fs.ToString();
		this.lblcommunity_medical_num.Text=model.community_medical_num.ToString();
		this.lblcommunity_culture_sports_gfa.Text=model.community_culture_sports_gfa.ToString();
		this.lblcommunity_culture_sports_fs.Text=model.community_culture_sports_fs.ToString();
		this.lblcommunity_culture_sports_num.Text=model.community_culture_sports_num.ToString();
		this.lblcommunity_service_gfa.Text=model.community_service_gfa.ToString();
		this.lblcommunity_service_fs.Text=model.community_service_fs.ToString();
		this.lblcommunity_service_num.Text=model.community_service_num.ToString();
		this.lblcommunity_other_building_gfa.Text=model.community_other_building_gfa.ToString();
		this.lblcommunity_other_building_fs.Text=model.community_other_building_fs.ToString();
		this.lblcommunity_other_building_num.Text=model.community_other_building_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcbunset1.Text=model.tcbunset1;
		this.lbltcbunset2.Text=model.tcbunset2;
		this.lbltcbunset3.Text=model.tcbunset3;
		this.lbltcbunset4.Text=model.tcbunset4;
		this.lbltcbunset5.Text=model.tcbunset5;
		this.lbltcbunset6.Text=model.tcbunset6;
		this.lbltcbunset7.Text=model.tcbunset7;
		this.lbltcbunset8.Text=model.tcbunset8;
		this.lbltcbunset9.Text=model.tcbunset9;
		this.lbltcbunset10.Text=model.tcbunset10;
		this.lbltcbunset11.Text=model.tcbunset11;
		this.lbltcbunset12.Text=model.tcbunset12;
		this.lbltcbunset13.Text=model.tcbunset13;
		this.lbltcbunset14.Text=model.tcbunset14;
		this.lbltcbunset15.Text=model.tcbunset15;
		this.lbltcbunset16.Text=model.tcbunset16;
		this.lbltcbunset17.Text=model.tcbunset17;
		this.lbltcbunset18.Text=model.tcbunset18;
		this.lbltcbunset19.Text=model.tcbunset19;
		this.lbltcbunset20.Text=model.tcbunset20;
		this.lbltcbunset21.Text=model.tcbunset21;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
