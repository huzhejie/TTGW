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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace TTG.Web.TTGWeb.labor_force
{
    public partial class Modify : Page
    {       

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
		this.txtcounty.Text=model.county;
		this.txtcommunity.Text=model.community;
		this.txtlf_have_a_job_pop.Text=model.lf_have_a_job_pop.ToString();
		this.txtlf_have_a_steady_job_pop.Text=model.lf_have_a_steady_job_pop.ToString();
		this.txtempm_information_platform_num.Text=model.empm_information_platform_num.ToString();
		this.txtempm_information_platform_information_num.Text=model.empm_information_platform_information_num.ToString();
		this.txtpublic_spirited_job_pop.Text=model.public_spirited_job_pop.ToString();
		this.txtclean_keeping_pop.Text=model.clean_keeping_pop.ToString();
		this.txtsecurity_guard_pop.Text=model.security_guard_pop.ToString();
		this.txtfarm_produce_fair_administrator_pop.Text=model.farm_produce_fair_administrator_pop.ToString();
		this.txtother_job_pop.Text=model.other_job_pop.ToString();
		this.txtenp_supportive_num.Text=model.enp_supportive_num.ToString();
		this.txtsmall_manual_processing_enp_num.Text=model.small_manual_processing_enp_num.ToString();
		this.txtfood_enp_num.Text=model.food_enp_num.ToString();
		this.txtsewing_embroidery_enp_num.Text=model.sewing_embroidery_enp_num.ToString();
		this.txtother_enp_supportive_num.Text=model.other_enp_supportive_num.ToString();
		this.txtnote_information.Text=model.note_information;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttlfunset1.Text=model.tlfunset1;
		this.txttlfunset2.Text=model.tlfunset2;
		this.txttlfunset3.Text=model.tlfunset3;
		this.txttlfunset4.Text=model.tlfunset4;
		this.txttlfunset5.Text=model.tlfunset5;
		this.txttlfunset6.Text=model.tlfunset6;
		this.txttlfunset7.Text=model.tlfunset7;
		this.txttlfunset8.Text=model.tlfunset8;
		this.txttlfunset9.Text=model.tlfunset9;
		this.txttlfunset10.Text=model.tlfunset10;
		this.txttlfunset11.Text=model.tlfunset11;
		this.txttlfunset12.Text=model.tlfunset12;
		this.txttlfunset13.Text=model.tlfunset13;
		this.txttlfunset14.Text=model.tlfunset14;
		this.txttlfunset15.Text=model.tlfunset15;
		this.txttlfunset16.Text=model.tlfunset16;
		this.txttlfunset17.Text=model.tlfunset17;
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txtlock_tables.Text=model.lock_tables.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcounty.Text.Trim().Length==0)
			{
				strErr+="county不能为空！\\n";	
			}
			if(this.txtcommunity.Text.Trim().Length==0)
			{
				strErr+="community不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlf_have_a_job_pop.Text))
			{
				strErr+="lf_have_a_job_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlf_have_a_steady_job_pop.Text))
			{
				strErr+="lf_have_a_steady_job_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtempm_information_platform_num.Text))
			{
				strErr+="empm_information_platform_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtempm_information_platform_information_num.Text))
			{
				strErr+="empm_information_platform_information_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpublic_spirited_job_pop.Text))
			{
				strErr+="public_spirited_job_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtclean_keeping_pop.Text))
			{
				strErr+="clean_keeping_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsecurity_guard_pop.Text))
			{
				strErr+="security_guard_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfarm_produce_fair_administrator_pop.Text))
			{
				strErr+="farm_produce_fair_administrator_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtother_job_pop.Text))
			{
				strErr+="other_job_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtenp_supportive_num.Text))
			{
				strErr+="enp_supportive_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsmall_manual_processing_enp_num.Text))
			{
				strErr+="small_manual_processing_enp_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfood_enp_num.Text))
			{
				strErr+="food_enp_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsewing_embroidery_enp_num.Text))
			{
				strErr+="sewing_embroidery_enp_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtother_enp_supportive_num.Text))
			{
				strErr+="other_enp_supportive_num格式错误！\\n";	
			}
			if(this.txtnote_information.Text.Trim().Length==0)
			{
				strErr+="note_information不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttlfunset1.Text.Trim().Length==0)
			{
				strErr+="tlfunset1不能为空！\\n";	
			}
			if(this.txttlfunset2.Text.Trim().Length==0)
			{
				strErr+="tlfunset2不能为空！\\n";	
			}
			if(this.txttlfunset3.Text.Trim().Length==0)
			{
				strErr+="tlfunset3不能为空！\\n";	
			}
			if(this.txttlfunset4.Text.Trim().Length==0)
			{
				strErr+="tlfunset4不能为空！\\n";	
			}
			if(this.txttlfunset5.Text.Trim().Length==0)
			{
				strErr+="tlfunset5不能为空！\\n";	
			}
			if(this.txttlfunset6.Text.Trim().Length==0)
			{
				strErr+="tlfunset6不能为空！\\n";	
			}
			if(this.txttlfunset7.Text.Trim().Length==0)
			{
				strErr+="tlfunset7不能为空！\\n";	
			}
			if(this.txttlfunset8.Text.Trim().Length==0)
			{
				strErr+="tlfunset8不能为空！\\n";	
			}
			if(this.txttlfunset9.Text.Trim().Length==0)
			{
				strErr+="tlfunset9不能为空！\\n";	
			}
			if(this.txttlfunset10.Text.Trim().Length==0)
			{
				strErr+="tlfunset10不能为空！\\n";	
			}
			if(this.txttlfunset11.Text.Trim().Length==0)
			{
				strErr+="tlfunset11不能为空！\\n";	
			}
			if(this.txttlfunset12.Text.Trim().Length==0)
			{
				strErr+="tlfunset12不能为空！\\n";	
			}
			if(this.txttlfunset13.Text.Trim().Length==0)
			{
				strErr+="tlfunset13不能为空！\\n";	
			}
			if(this.txttlfunset14.Text.Trim().Length==0)
			{
				strErr+="tlfunset14不能为空！\\n";	
			}
			if(this.txttlfunset15.Text.Trim().Length==0)
			{
				strErr+="tlfunset15不能为空！\\n";	
			}
			if(this.txttlfunset16.Text.Trim().Length==0)
			{
				strErr+="tlfunset16不能为空！\\n";	
			}
			if(this.txttlfunset17.Text.Trim().Length==0)
			{
				strErr+="tlfunset17不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string id=this.lblid.Text;
			string county=this.txtcounty.Text;
			string community=this.txtcommunity.Text;
			int lf_have_a_job_pop=int.Parse(this.txtlf_have_a_job_pop.Text);
			int lf_have_a_steady_job_pop=int.Parse(this.txtlf_have_a_steady_job_pop.Text);
			int empm_information_platform_num=int.Parse(this.txtempm_information_platform_num.Text);
			int empm_information_platform_information_num=int.Parse(this.txtempm_information_platform_information_num.Text);
			int public_spirited_job_pop=int.Parse(this.txtpublic_spirited_job_pop.Text);
			int clean_keeping_pop=int.Parse(this.txtclean_keeping_pop.Text);
			int security_guard_pop=int.Parse(this.txtsecurity_guard_pop.Text);
			int farm_produce_fair_administrator_pop=int.Parse(this.txtfarm_produce_fair_administrator_pop.Text);
			int other_job_pop=int.Parse(this.txtother_job_pop.Text);
			int enp_supportive_num=int.Parse(this.txtenp_supportive_num.Text);
			int small_manual_processing_enp_num=int.Parse(this.txtsmall_manual_processing_enp_num.Text);
			int food_enp_num=int.Parse(this.txtfood_enp_num.Text);
			int sewing_embroidery_enp_num=int.Parse(this.txtsewing_embroidery_enp_num.Text);
			int other_enp_supportive_num=int.Parse(this.txtother_enp_supportive_num.Text);
			string note_information=this.txtnote_information.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tlfunset1=this.txttlfunset1.Text;
			string tlfunset2=this.txttlfunset2.Text;
			string tlfunset3=this.txttlfunset3.Text;
			string tlfunset4=this.txttlfunset4.Text;
			string tlfunset5=this.txttlfunset5.Text;
			string tlfunset6=this.txttlfunset6.Text;
			string tlfunset7=this.txttlfunset7.Text;
			string tlfunset8=this.txttlfunset8.Text;
			string tlfunset9=this.txttlfunset9.Text;
			string tlfunset10=this.txttlfunset10.Text;
			string tlfunset11=this.txttlfunset11.Text;
			string tlfunset12=this.txttlfunset12.Text;
			string tlfunset13=this.txttlfunset13.Text;
			string tlfunset14=this.txttlfunset14.Text;
			string tlfunset15=this.txttlfunset15.Text;
			string tlfunset16=this.txttlfunset16.Text;
			string tlfunset17=this.txttlfunset17.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);


			TTG.Model.TTGWeb.labor_force model=new TTG.Model.TTGWeb.labor_force();
			model.id=id;
			model.county=county;
			model.community=community;
			model.lf_have_a_job_pop=lf_have_a_job_pop;
			model.lf_have_a_steady_job_pop=lf_have_a_steady_job_pop;
			model.empm_information_platform_num=empm_information_platform_num;
			model.empm_information_platform_information_num=empm_information_platform_information_num;
			model.public_spirited_job_pop=public_spirited_job_pop;
			model.clean_keeping_pop=clean_keeping_pop;
			model.security_guard_pop=security_guard_pop;
			model.farm_produce_fair_administrator_pop=farm_produce_fair_administrator_pop;
			model.other_job_pop=other_job_pop;
			model.enp_supportive_num=enp_supportive_num;
			model.small_manual_processing_enp_num=small_manual_processing_enp_num;
			model.food_enp_num=food_enp_num;
			model.sewing_embroidery_enp_num=sewing_embroidery_enp_num;
			model.other_enp_supportive_num=other_enp_supportive_num;
			model.note_information=note_information;
			model.statistics_date=statistics_date;
			model.tlfunset1=tlfunset1;
			model.tlfunset2=tlfunset2;
			model.tlfunset3=tlfunset3;
			model.tlfunset4=tlfunset4;
			model.tlfunset5=tlfunset5;
			model.tlfunset6=tlfunset6;
			model.tlfunset7=tlfunset7;
			model.tlfunset8=tlfunset8;
			model.tlfunset9=tlfunset9;
			model.tlfunset10=tlfunset10;
			model.tlfunset11=tlfunset11;
			model.tlfunset12=tlfunset12;
			model.tlfunset13=tlfunset13;
			model.tlfunset14=tlfunset14;
			model.tlfunset15=tlfunset15;
			model.tlfunset16=tlfunset16;
			model.tlfunset17=tlfunset17;
			model.check_status=check_status;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.labor_force bll=new TTG.BLL.TTGWeb.labor_force();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
