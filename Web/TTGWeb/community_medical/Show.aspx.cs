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
namespace TTG.Web.TTGWeb.community_medical
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
		TTG.BLL.TTGWeb.community_medical bll=new TTG.BLL.TTGWeb.community_medical();
		TTG.Model.TTGWeb.community_medical model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_medical_inst_num.Text=model.community_medical_inst_num.ToString();
		this.lblcommunity_medical_inst_fs.Text=model.community_medical_inst_fs.ToString();
		this.lblcommunity_medical_inst_gfa.Text=model.community_medical_inst_gfa.ToString();
		this.lblcommunity_hospital_num.Text=model.community_hospital_num.ToString();
		this.lblcommunity_hospital_gfa.Text=model.community_hospital_gfa.ToString();
		this.lblcommunity_hospital_fs.Text=model.community_hospital_fs.ToString();
		this.lblcommunity_hospital_bed_num.Text=model.community_hospital_bed_num.ToString();
		this.lblcommunity_hospital_dis_ots.Text=model.community_hospital_dis_ots.ToString();
		this.lblcommunity_heal_sta_num.Text=model.community_heal_sta_num.ToString();
		this.lblcommunity_heal_sta_fs.Text=model.community_heal_sta_fs.ToString();
		this.lblcommunity_heal_sta_gfa.Text=model.community_heal_sta_gfa.ToString();
		this.lblcommunity_heal_sta_bed_num.Text=model.community_heal_sta_bed_num.ToString();
		this.lblcommunity_heal_sta_dis_ots.Text=model.community_heal_sta_dis_ots.ToString();
		this.lblcommunity_clinic_num.Text=model.community_clinic_num.ToString();
		this.lblcommunity_clinic_fs.Text=model.community_clinic_fs.ToString();
		this.lblcommunity_clinic_gfa.Text=model.community_clinic_gfa.ToString();
		this.lblcommunity_clinic_bed_num.Text=model.community_clinic_bed_num.ToString();
		this.lblcommunity_clinic_dis_ots.Text=model.community_clinic_dis_ots.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcmunset1.Text=model.tcmunset1;
		this.lbltcmunset2.Text=model.tcmunset2;
		this.lbltcmunset3.Text=model.tcmunset3;
		this.lbltcmunset4.Text=model.tcmunset4;
		this.lbltcmunset5.Text=model.tcmunset5;
		this.lbltcmunset6.Text=model.tcmunset6;
		this.lbltcmunset7.Text=model.tcmunset7;
		this.lbltcmunset8.Text=model.tcmunset8;
		this.lbltcmunset9.Text=model.tcmunset9;
		this.lbltcmunset10.Text=model.tcmunset10;
		this.lbltcmunset11.Text=model.tcmunset11;
		this.lbltcmunset12.Text=model.tcmunset12;
		this.lbltcmunset13.Text=model.tcmunset13;
		this.lbltcmunset14.Text=model.tcmunset14;
		this.lbltcmunset15.Text=model.tcmunset15;
		this.lbltcmunset16.Text=model.tcmunset16;
		this.lbltcmunset17.Text=model.tcmunset17;
		this.lbltcmunset18.Text=model.tcmunset18;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
