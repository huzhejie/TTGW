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
namespace TTG.Web.TTGWeb.community_social_insurance
{
    public partial class Modify : Page
    {       

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
		TTG.BLL.TTGWeb.community_social_insurance bll=new TTG.BLL.TTGWeb.community_social_insurance();
		TTG.Model.TTGWeb.community_social_insurance model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_urban_min_living_sec_pop.Text=model.community_urban_min_living_sec_pop.ToString();
		this.txtcommunity_very_poor_household_pop.Text=model.community_very_poor_household_pop.ToString();
		this.txtcommunity_large_med_resv_immg_pop.Text=model.community_large_med_resv_immg_pop.ToString();
		this.txtcommunity_chongqing_immg_poor_pop.Text=model.community_chongqing_immg_poor_pop.ToString();
		this.txtcommunity_medicare_pop.Text=model.community_medicare_pop.ToString();
		this.txtcommunity_endow_insu_pop.Text=model.community_endow_insu_pop.ToString();
		this.txtcommunity_unemp_insu_pop.Text=model.community_unemp_insu_pop.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttcsiunset1.Text=model.tcsiunset1;
		this.txttcsiunset2.Text=model.tcsiunset2;
		this.txttcsiunset3.Text=model.tcsiunset3;
		this.txttcsiunset4.Text=model.tcsiunset4;
		this.txttcsiunset5.Text=model.tcsiunset5;
		this.txttcsiunset6.Text=model.tcsiunset6;
		this.txttcsiunset7.Text=model.tcsiunset7;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txtpoor_people_rate.Text=model.poor_people_rate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommunity_urban_min_living_sec_pop.Text))
			{
				strErr+="community_urban_min_living_sec_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_very_poor_household_pop.Text))
			{
				strErr+="community_very_poor_household_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_large_med_resv_immg_pop.Text))
			{
				strErr+="community_large_med_resv_immg_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_chongqing_immg_poor_pop.Text))
			{
				strErr+="community_chongqing_immg_poor_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_medicare_pop.Text))
			{
				strErr+="community_medicare_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_endow_insu_pop.Text))
			{
				strErr+="community_endow_insu_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_unemp_insu_pop.Text))
			{
				strErr+="community_unemp_insu_pop格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcsiunset1.Text.Trim().Length==0)
			{
				strErr+="tcsiunset1不能为空！\\n";	
			}
			if(this.txttcsiunset2.Text.Trim().Length==0)
			{
				strErr+="tcsiunset2不能为空！\\n";	
			}
			if(this.txttcsiunset3.Text.Trim().Length==0)
			{
				strErr+="tcsiunset3不能为空！\\n";	
			}
			if(this.txttcsiunset4.Text.Trim().Length==0)
			{
				strErr+="tcsiunset4不能为空！\\n";	
			}
			if(this.txttcsiunset5.Text.Trim().Length==0)
			{
				strErr+="tcsiunset5不能为空！\\n";	
			}
			if(this.txttcsiunset6.Text.Trim().Length==0)
			{
				strErr+="tcsiunset6不能为空！\\n";	
			}
			if(this.txttcsiunset7.Text.Trim().Length==0)
			{
				strErr+="tcsiunset7不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpoor_people_rate.Text))
			{
				strErr+="poor_people_rate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			int community_urban_min_living_sec_pop=int.Parse(this.txtcommunity_urban_min_living_sec_pop.Text);
			int community_very_poor_household_pop=int.Parse(this.txtcommunity_very_poor_household_pop.Text);
			int community_large_med_resv_immg_pop=int.Parse(this.txtcommunity_large_med_resv_immg_pop.Text);
			int community_chongqing_immg_poor_pop=int.Parse(this.txtcommunity_chongqing_immg_poor_pop.Text);
			int community_medicare_pop=int.Parse(this.txtcommunity_medicare_pop.Text);
			int community_endow_insu_pop=int.Parse(this.txtcommunity_endow_insu_pop.Text);
			int community_unemp_insu_pop=int.Parse(this.txtcommunity_unemp_insu_pop.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcsiunset1=this.txttcsiunset1.Text;
			string tcsiunset2=this.txttcsiunset2.Text;
			string tcsiunset3=this.txttcsiunset3.Text;
			string tcsiunset4=this.txttcsiunset4.Text;
			string tcsiunset5=this.txttcsiunset5.Text;
			string tcsiunset6=this.txttcsiunset6.Text;
			string tcsiunset7=this.txttcsiunset7.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			decimal poor_people_rate=decimal.Parse(this.txtpoor_people_rate.Text);


			TTG.Model.TTGWeb.community_social_insurance model=new TTG.Model.TTGWeb.community_social_insurance();
			model.community_id=community_id;
			model.community_urban_min_living_sec_pop=community_urban_min_living_sec_pop;
			model.community_very_poor_household_pop=community_very_poor_household_pop;
			model.community_large_med_resv_immg_pop=community_large_med_resv_immg_pop;
			model.community_chongqing_immg_poor_pop=community_chongqing_immg_poor_pop;
			model.community_medicare_pop=community_medicare_pop;
			model.community_endow_insu_pop=community_endow_insu_pop;
			model.community_unemp_insu_pop=community_unemp_insu_pop;
			model.statistics_date=statistics_date;
			model.tcsiunset1=tcsiunset1;
			model.tcsiunset2=tcsiunset2;
			model.tcsiunset3=tcsiunset3;
			model.tcsiunset4=tcsiunset4;
			model.tcsiunset5=tcsiunset5;
			model.tcsiunset6=tcsiunset6;
			model.tcsiunset7=tcsiunset7;
			model.lock_tables=lock_tables;
			model.check_status=check_status;
			model.poor_people_rate=poor_people_rate;

			TTG.BLL.TTGWeb.community_social_insurance bll=new TTG.BLL.TTGWeb.community_social_insurance();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
