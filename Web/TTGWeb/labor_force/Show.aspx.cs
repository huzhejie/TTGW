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
namespace TTG.Web.TTGWeb.labor_force
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(id,statistics_date);
			}
		}
		
	private void ShowInfo(string id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.labor_force bll=new TTG.BLL.TTGWeb.labor_force();
		TTG.Model.TTGWeb.labor_force model=bll.GetModel(id,statistics_date);
		this.lblid.Text=model.id;
		this.lblcounty.Text=model.county;
		this.lblcommunity.Text=model.community;
		this.lbllf_have_a_job_pop.Text=model.lf_have_a_job_pop.ToString();
		this.lbllf_have_a_steady_job_pop.Text=model.lf_have_a_steady_job_pop.ToString();
		this.lblempm_information_platform_num.Text=model.empm_information_platform_num.ToString();
		this.lblempm_information_platform_information_num.Text=model.empm_information_platform_information_num.ToString();
		this.lblpublic_spirited_job_pop.Text=model.public_spirited_job_pop.ToString();
		this.lblclean_keeping_pop.Text=model.clean_keeping_pop.ToString();
		this.lblsecurity_guard_pop.Text=model.security_guard_pop.ToString();
		this.lblfarm_produce_fair_administrator_pop.Text=model.farm_produce_fair_administrator_pop.ToString();
		this.lblother_job_pop.Text=model.other_job_pop.ToString();
		this.lblenp_supportive_num.Text=model.enp_supportive_num.ToString();
		this.lblsmall_manual_processing_enp_num.Text=model.small_manual_processing_enp_num.ToString();
		this.lblfood_enp_num.Text=model.food_enp_num.ToString();
		this.lblsewing_embroidery_enp_num.Text=model.sewing_embroidery_enp_num.ToString();
		this.lblother_enp_supportive_num.Text=model.other_enp_supportive_num.ToString();
		this.lblnote_information.Text=model.note_information;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltlfunset1.Text=model.tlfunset1;
		this.lbltlfunset2.Text=model.tlfunset2;
		this.lbltlfunset3.Text=model.tlfunset3;
		this.lbltlfunset4.Text=model.tlfunset4;
		this.lbltlfunset5.Text=model.tlfunset5;
		this.lbltlfunset6.Text=model.tlfunset6;
		this.lbltlfunset7.Text=model.tlfunset7;
		this.lbltlfunset8.Text=model.tlfunset8;
		this.lbltlfunset9.Text=model.tlfunset9;
		this.lbltlfunset10.Text=model.tlfunset10;
		this.lbltlfunset11.Text=model.tlfunset11;
		this.lbltlfunset12.Text=model.tlfunset12;
		this.lbltlfunset13.Text=model.tlfunset13;
		this.lbltlfunset14.Text=model.tlfunset14;
		this.lbltlfunset15.Text=model.tlfunset15;
		this.lbltlfunset16.Text=model.tlfunset16;
		this.lbltlfunset17.Text=model.tlfunset17;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
