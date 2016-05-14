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
namespace TTG.Web.TTGWeb.community_culture_sports
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcommunity_id.Text.Trim().Length==0)
			{
				strErr+="community_id不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_culture_sports_fs.Text))
			{
				strErr+="community_culture_sports_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_culture_sports_gfa.Text))
			{
				strErr+="community_culture_sports_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_otd_cul_spo_fac_num.Text))
			{
				strErr+="community_otd_cul_spo_fac_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_otd_cul_spo_fac_gfa.Text))
			{
				strErr+="community_otd_cul_spo_fac_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_cul_squ_num.Text))
			{
				strErr+="community_cul_squ_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_cul_squ_fs.Text))
			{
				strErr+="community_cul_squ_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_otd_entm_num.Text))
			{
				strErr+="community_otd_entm_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_otd_entm_fs.Text))
			{
				strErr+="community_otd_entm_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_child_plg_num.Text))
			{
				strErr+="community_child_plg_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_child_plg_fs.Text))
			{
				strErr+="community_child_plg_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_ind_actv_spa_num.Text))
			{
				strErr+="community_ind_actv_spa_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_ind_actv_spa_fs.Text))
			{
				strErr+="community_ind_actv_spa_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_ind_actv_spa_gfa.Text))
			{
				strErr+="community_ind_actv_spa_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_cul_sta_num.Text))
			{
				strErr+="community_cul_sta_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_cul_sta_fs.Text))
			{
				strErr+="community_cul_sta_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_cul_sta_gfa.Text))
			{
				strErr+="community_cul_sta_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_cul_room_num.Text))
			{
				strErr+="community_cul_room_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_cul_room_fs.Text))
			{
				strErr+="community_cul_room_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_cul_room_gfa.Text))
			{
				strErr+="community_cul_room_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_fit_fac_num.Text))
			{
				strErr+="community_fit_fac_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_fit_fac_intact_rate.Text))
			{
				strErr+="community_fit_fac_intact_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttccsunset1.Text.Trim().Length==0)
			{
				strErr+="tccsunset1不能为空！\\n";	
			}
			if(this.txttccsunset2.Text.Trim().Length==0)
			{
				strErr+="tccsunset2不能为空！\\n";	
			}
			if(this.txttccsunset3.Text.Trim().Length==0)
			{
				strErr+="tccsunset3不能为空！\\n";	
			}
			if(this.txttccsunset4.Text.Trim().Length==0)
			{
				strErr+="tccsunset4不能为空！\\n";	
			}
			if(this.txttccsunset5.Text.Trim().Length==0)
			{
				strErr+="tccsunset5不能为空！\\n";	
			}
			if(this.txttccsunset6.Text.Trim().Length==0)
			{
				strErr+="tccsunset6不能为空！\\n";	
			}
			if(this.txttccsunset7.Text.Trim().Length==0)
			{
				strErr+="tccsunset7不能为空！\\n";	
			}
			if(this.txttccsunset8.Text.Trim().Length==0)
			{
				strErr+="tccsunset8不能为空！\\n";	
			}
			if(this.txttccsunset9.Text.Trim().Length==0)
			{
				strErr+="tccsunset9不能为空！\\n";	
			}
			if(this.txttccsunset10.Text.Trim().Length==0)
			{
				strErr+="tccsunset10不能为空！\\n";	
			}
			if(this.txttccsunset11.Text.Trim().Length==0)
			{
				strErr+="tccsunset11不能为空！\\n";	
			}
			if(this.txttccsunset12.Text.Trim().Length==0)
			{
				strErr+="tccsunset12不能为空！\\n";	
			}
			if(this.txttccsunset13.Text.Trim().Length==0)
			{
				strErr+="tccsunset13不能为空！\\n";	
			}
			if(this.txttccsunset14.Text.Trim().Length==0)
			{
				strErr+="tccsunset14不能为空！\\n";	
			}
			if(this.txttccsunset15.Text.Trim().Length==0)
			{
				strErr+="tccsunset15不能为空！\\n";	
			}
			if(this.txttccsunset16.Text.Trim().Length==0)
			{
				strErr+="tccsunset16不能为空！\\n";	
			}
			if(this.txttccsunset17.Text.Trim().Length==0)
			{
				strErr+="tccsunset17不能为空！\\n";	
			}
			if(this.txttccsunset18.Text.Trim().Length==0)
			{
				strErr+="tccsunset18不能为空！\\n";	
			}
			if(this.txttccsunset19.Text.Trim().Length==0)
			{
				strErr+="tccsunset19不能为空！\\n";	
			}
			if(this.txttccsunset20.Text.Trim().Length==0)
			{
				strErr+="tccsunset20不能为空！\\n";	
			}
			if(this.txttccsunset21.Text.Trim().Length==0)
			{
				strErr+="tccsunset21不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			decimal community_culture_sports_fs=decimal.Parse(this.txtcommunity_culture_sports_fs.Text);
			decimal community_culture_sports_gfa=decimal.Parse(this.txtcommunity_culture_sports_gfa.Text);
			int community_otd_cul_spo_fac_num=int.Parse(this.txtcommunity_otd_cul_spo_fac_num.Text);
			decimal community_otd_cul_spo_fac_gfa=decimal.Parse(this.txtcommunity_otd_cul_spo_fac_gfa.Text);
			int community_cul_squ_num=int.Parse(this.txtcommunity_cul_squ_num.Text);
			decimal community_cul_squ_fs=decimal.Parse(this.txtcommunity_cul_squ_fs.Text);
			int community_otd_entm_num=int.Parse(this.txtcommunity_otd_entm_num.Text);
			decimal community_otd_entm_fs=decimal.Parse(this.txtcommunity_otd_entm_fs.Text);
			int community_child_plg_num=int.Parse(this.txtcommunity_child_plg_num.Text);
			decimal community_child_plg_fs=decimal.Parse(this.txtcommunity_child_plg_fs.Text);
			int community_ind_actv_spa_num=int.Parse(this.txtcommunity_ind_actv_spa_num.Text);
			decimal community_ind_actv_spa_fs=decimal.Parse(this.txtcommunity_ind_actv_spa_fs.Text);
			decimal community_ind_actv_spa_gfa=decimal.Parse(this.txtcommunity_ind_actv_spa_gfa.Text);
			int community_cul_sta_num=int.Parse(this.txtcommunity_cul_sta_num.Text);
			decimal community_cul_sta_fs=decimal.Parse(this.txtcommunity_cul_sta_fs.Text);
			decimal community_cul_sta_gfa=decimal.Parse(this.txtcommunity_cul_sta_gfa.Text);
			int community_cul_room_num=int.Parse(this.txtcommunity_cul_room_num.Text);
			decimal community_cul_room_fs=decimal.Parse(this.txtcommunity_cul_room_fs.Text);
			decimal community_cul_room_gfa=decimal.Parse(this.txtcommunity_cul_room_gfa.Text);
			int community_fit_fac_num=int.Parse(this.txtcommunity_fit_fac_num.Text);
			decimal community_fit_fac_intact_rate=decimal.Parse(this.txtcommunity_fit_fac_intact_rate.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tccsunset1=this.txttccsunset1.Text;
			string tccsunset2=this.txttccsunset2.Text;
			string tccsunset3=this.txttccsunset3.Text;
			string tccsunset4=this.txttccsunset4.Text;
			string tccsunset5=this.txttccsunset5.Text;
			string tccsunset6=this.txttccsunset6.Text;
			string tccsunset7=this.txttccsunset7.Text;
			string tccsunset8=this.txttccsunset8.Text;
			string tccsunset9=this.txttccsunset9.Text;
			string tccsunset10=this.txttccsunset10.Text;
			string tccsunset11=this.txttccsunset11.Text;
			string tccsunset12=this.txttccsunset12.Text;
			string tccsunset13=this.txttccsunset13.Text;
			string tccsunset14=this.txttccsunset14.Text;
			string tccsunset15=this.txttccsunset15.Text;
			string tccsunset16=this.txttccsunset16.Text;
			string tccsunset17=this.txttccsunset17.Text;
			string tccsunset18=this.txttccsunset18.Text;
			string tccsunset19=this.txttccsunset19.Text;
			string tccsunset20=this.txttccsunset20.Text;
			string tccsunset21=this.txttccsunset21.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_culture_sports model=new TTG.Model.TTGWeb.community_culture_sports();
			model.community_id=community_id;
			model.community_culture_sports_fs=community_culture_sports_fs;
			model.community_culture_sports_gfa=community_culture_sports_gfa;
			model.community_otd_cul_spo_fac_num=community_otd_cul_spo_fac_num;
			model.community_otd_cul_spo_fac_gfa=community_otd_cul_spo_fac_gfa;
			model.community_cul_squ_num=community_cul_squ_num;
			model.community_cul_squ_fs=community_cul_squ_fs;
			model.community_otd_entm_num=community_otd_entm_num;
			model.community_otd_entm_fs=community_otd_entm_fs;
			model.community_child_plg_num=community_child_plg_num;
			model.community_child_plg_fs=community_child_plg_fs;
			model.community_ind_actv_spa_num=community_ind_actv_spa_num;
			model.community_ind_actv_spa_fs=community_ind_actv_spa_fs;
			model.community_ind_actv_spa_gfa=community_ind_actv_spa_gfa;
			model.community_cul_sta_num=community_cul_sta_num;
			model.community_cul_sta_fs=community_cul_sta_fs;
			model.community_cul_sta_gfa=community_cul_sta_gfa;
			model.community_cul_room_num=community_cul_room_num;
			model.community_cul_room_fs=community_cul_room_fs;
			model.community_cul_room_gfa=community_cul_room_gfa;
			model.community_fit_fac_num=community_fit_fac_num;
			model.community_fit_fac_intact_rate=community_fit_fac_intact_rate;
			model.statistics_date=statistics_date;
			model.tccsunset1=tccsunset1;
			model.tccsunset2=tccsunset2;
			model.tccsunset3=tccsunset3;
			model.tccsunset4=tccsunset4;
			model.tccsunset5=tccsunset5;
			model.tccsunset6=tccsunset6;
			model.tccsunset7=tccsunset7;
			model.tccsunset8=tccsunset8;
			model.tccsunset9=tccsunset9;
			model.tccsunset10=tccsunset10;
			model.tccsunset11=tccsunset11;
			model.tccsunset12=tccsunset12;
			model.tccsunset13=tccsunset13;
			model.tccsunset14=tccsunset14;
			model.tccsunset15=tccsunset15;
			model.tccsunset16=tccsunset16;
			model.tccsunset17=tccsunset17;
			model.tccsunset18=tccsunset18;
			model.tccsunset19=tccsunset19;
			model.tccsunset20=tccsunset20;
			model.tccsunset21=tccsunset21;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_culture_sports bll=new TTG.BLL.TTGWeb.community_culture_sports();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
