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
namespace TTG.Web.TTGWeb.community_service
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
		TTG.BLL.TTGWeb.community_service bll=new TTG.BLL.TTGWeb.community_service();
		TTG.Model.TTGWeb.community_service model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_comm_serv_fac_fs.Text=model.community_comm_serv_fac_fs.ToString();
		this.lblcommunity_comm_serv_fac_gfa.Text=model.community_comm_serv_fac_gfa.ToString();
		this.lblcommunity_comm_serv_cen_fs.Text=model.community_comm_serv_cen_fs.ToString();
		this.lblcommunity_comm_serv_cen_gfa.Text=model.community_comm_serv_cen_gfa.ToString();
		this.lblcommunity_comm_serv_cen_dis_ots.Text=model.community_comm_serv_cen_dis_ots.ToString();
		this.lblcommunity_empm_supt_cen_fs.Text=model.community_empm_supt_cen_fs.ToString();
		this.lblcommunity_empm_supt_cen_gfa.Text=model.community_empm_supt_cen_gfa.ToString();
		this.lblcommunity_empm_supt_cen_dis_ots.Text=model.community_empm_supt_cen_dis_ots.ToString();
		this.lblcommunity_police_sta_fs.Text=model.community_police_sta_fs.ToString();
		this.lblcommunity_police_sta_gfa.Text=model.community_police_sta_gfa.ToString();
		this.lblcommunity_police_sta_dis_ots.Text=model.community_police_sta_dis_ots.ToString();
		this.lblcommunity_prop_magm_unit_num.Text=model.community_prop_magm_unit_num.ToString();
		this.lblcommunity_no_prop_magm_unit_num.Text=model.community_no_prop_magm_unit_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcsrunset1.Text=model.tcsrunset1;
		this.lbltcsrunset2.Text=model.tcsrunset2;
		this.lbltcsrunset3.Text=model.tcsrunset3;
		this.lbltcsrunset4.Text=model.tcsrunset4;
		this.lbltcsrunset5.Text=model.tcsrunset5;
		this.lbltcsrunset6.Text=model.tcsrunset6;
		this.lbltcsrunset7.Text=model.tcsrunset7;
		this.lbltcsrunset8.Text=model.tcsrunset8;
		this.lbltcsrunset9.Text=model.tcsrunset9;
		this.lbltcsrunset10.Text=model.tcsrunset10;
		this.lbltcsrunset11.Text=model.tcsrunset11;
		this.lbltcsrunset12.Text=model.tcsrunset12;
		this.lbltcsrunset13.Text=model.tcsrunset13;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
