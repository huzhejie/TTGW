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
namespace TTG.Web.TTGWeb.community_education
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
		TTG.BLL.TTGWeb.community_education bll=new TTG.BLL.TTGWeb.community_education();
		TTG.Model.TTGWeb.community_education model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_edu_inst_num.Text=model.community_edu_inst_num.ToString();
		this.lblcommunity_edu_fs.Text=model.community_edu_fs.ToString();
		this.lblcommunity_edu_gfa.Text=model.community_edu_gfa.ToString();
		this.lblcommunity_kdg_num.Text=model.community_kdg_num.ToString();
		this.lblcommunity_pri_kdg_num.Text=model.community_pri_kdg_num.ToString();
		this.lblcommunity_kdg_fs.Text=model.community_kdg_fs.ToString();
		this.lblcommunity_kdg_gfa.Text=model.community_kdg_gfa.ToString();
		this.lblcommunity_kdg_stu_num.Text=model.community_kdg_stu_num.ToString();
		this.lblcommunity_kdg_class_num.Text=model.community_kdg_class_num.ToString();
		this.lblcommunity_kdg_actv_room_area.Text=model.community_kdg_actv_room_area.ToString();
		this.lblcommunity_kdg_otd_actv_spa_area.Text=model.community_kdg_otd_actv_spa_area.ToString();
		this.lblcommunity_kdg_greenland_area.Text=model.community_kdg_greenland_area.ToString();
		this.lblcommunity_kdg_dist_ots.Text=model.community_kdg_dist_ots.ToString();
		this.lblcommunity_prim_school_num.Text=model.community_prim_school_num.ToString();
		this.lblcommunity_prim_school_gfa.Text=model.community_prim_school_gfa.ToString();
		this.lblcommunity_prim_school_fs.Text=model.community_prim_school_fs.ToString();
		this.lblcommunity_prim_school_stu_num.Text=model.community_prim_school_stu_num.ToString();
		this.lblcommunity_prim_school_class_num.Text=model.community_prim_school_class_num.ToString();
		this.lblcommunity_prim_school_plg_area.Text=model.community_prim_school_plg_area.ToString();
		this.lblcommunity_prim_school_dist_ots.Text=model.community_prim_school_dist_ots.ToString();
		this.lblcommunity_mid_school_num.Text=model.community_mid_school_num.ToString();
		this.lblcommunity_mid_school_gfa.Text=model.community_mid_school_gfa.ToString();
		this.lblcommunity_mid_school_fs.Text=model.community_mid_school_fs.ToString();
		this.lblcommunity_mid_school_stu_num.Text=model.community_mid_school_stu_num.ToString();
		this.lblcommunity_mid_school_class_num.Text=model.community_mid_school_class_num.ToString();
		this.lblcommunity_mid_school_plg_area.Text=model.community_mid_school_plg_area.ToString();
		this.lblcommunity_mid_school_dist_ots.Text=model.community_mid_school_dist_ots.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltceunset1.Text=model.tceunset1;
		this.lbltceunset2.Text=model.tceunset2;
		this.lbltceunset3.Text=model.tceunset3;
		this.lbltceunset4.Text=model.tceunset4;
		this.lbltceunset5.Text=model.tceunset5;
		this.lbltceunset6.Text=model.tceunset6;
		this.lbltceunset7.Text=model.tceunset7;
		this.lbltceunset8.Text=model.tceunset8;
		this.lbltceunset9.Text=model.tceunset9;
		this.lbltceunset10.Text=model.tceunset10;
		this.lbltceunset11.Text=model.tceunset11;
		this.lbltceunset12.Text=model.tceunset12;
		this.lbltceunset13.Text=model.tceunset13;
		this.lbltceunset14.Text=model.tceunset14;
		this.lbltceunset15.Text=model.tceunset15;
		this.lbltceunset16.Text=model.tceunset16;
		this.lbltceunset17.Text=model.tceunset17;
		this.lbltceunset18.Text=model.tceunset18;
		this.lbltceunset19.Text=model.tceunset19;
		this.lbltceunset20.Text=model.tceunset20;
		this.lbltceunset21.Text=model.tceunset21;
		this.lbltceunset22.Text=model.tceunset22;
		this.lbltceunset23.Text=model.tceunset23;
		this.lbltceunset24.Text=model.tceunset24;
		this.lbltceunset25.Text=model.tceunset25;
		this.lbltceunset26.Text=model.tceunset26;
		this.lbltceunset27.Text=model.tceunset27;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
