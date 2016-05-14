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
namespace TTG.Web.TTGWeb.community_population
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
			if(!PageValidate.IsNumber(txtcommunity_total_pop.Text))
			{
				strErr+="community_total_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_reg_pop.Text))
			{
				strErr+="community_reg_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_perm_pop.Text))
			{
				strErr+="community_perm_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_man_pop.Text))
			{
				strErr+="community_man_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_female_pop.Text))
			{
				strErr+="community_female_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_younger_6_pop.Text))
			{
				strErr+="community_younger_6_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_bet_7_and_15_pop.Text))
			{
				strErr+="community_bet_7_and_15_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_bet_16_and_29_pop.Text))
			{
				strErr+="community_bet_16_and_29_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_bet_30_and_39_pop.Text))
			{
				strErr+="community_bet_30_and_39_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_bet_40_and_49_pop.Text))
			{
				strErr+="community_bet_40_and_49_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_older_50_pop.Text))
			{
				strErr+="community_older_50_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_illiteracy_pop.Text))
			{
				strErr+="community_illiteracy_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_prim_school_edu_pop.Text))
			{
				strErr+="community_prim_school_edu_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_junior_high_school_edu_pop.Text))
			{
				strErr+="community_junior_high_school_edu_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_senior_high_school_edu_pop.Text))
			{
				strErr+="community_senior_high_school_edu_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_junior_college_edu_pop.Text))
			{
				strErr+="community_junior_college_edu_pop格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtaverage_education_time.Text))
			{
				strErr+="average_education_time格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcpunset1.Text.Trim().Length==0)
			{
				strErr+="tcpunset1不能为空！\\n";	
			}
			if(this.txttcpunset2.Text.Trim().Length==0)
			{
				strErr+="tcpunset2不能为空！\\n";	
			}
			if(this.txttcpunset3.Text.Trim().Length==0)
			{
				strErr+="tcpunset3不能为空！\\n";	
			}
			if(this.txttcpunset4.Text.Trim().Length==0)
			{
				strErr+="tcpunset4不能为空！\\n";	
			}
			if(this.txttcpunset5.Text.Trim().Length==0)
			{
				strErr+="tcpunset5不能为空！\\n";	
			}
			if(this.txttcpunset6.Text.Trim().Length==0)
			{
				strErr+="tcpunset6不能为空！\\n";	
			}
			if(this.txttcpunset7.Text.Trim().Length==0)
			{
				strErr+="tcpunset7不能为空！\\n";	
			}
			if(this.txttcpunset8.Text.Trim().Length==0)
			{
				strErr+="tcpunset8不能为空！\\n";	
			}
			if(this.txttcpunset10.Text.Trim().Length==0)
			{
				strErr+="tcpunset10不能为空！\\n";	
			}
			if(this.txttcpunset11.Text.Trim().Length==0)
			{
				strErr+="tcpunset11不能为空！\\n";	
			}
			if(this.txttcpunset12.Text.Trim().Length==0)
			{
				strErr+="tcpunset12不能为空！\\n";	
			}
			if(this.txttcpunset13.Text.Trim().Length==0)
			{
				strErr+="tcpunset13不能为空！\\n";	
			}
			if(this.txttcpunset14.Text.Trim().Length==0)
			{
				strErr+="tcpunset14不能为空！\\n";	
			}
			if(this.txttcpunset15.Text.Trim().Length==0)
			{
				strErr+="tcpunset15不能为空！\\n";	
			}
			if(this.txttcpunset16.Text.Trim().Length==0)
			{
				strErr+="tcpunset16不能为空！\\n";	
			}
			if(this.txttcpunset17.Text.Trim().Length==0)
			{
				strErr+="tcpunset17不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_family_num.Text))
			{
				strErr+="community_family_num格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			int community_total_pop=int.Parse(this.txtcommunity_total_pop.Text);
			int community_reg_pop=int.Parse(this.txtcommunity_reg_pop.Text);
			int community_perm_pop=int.Parse(this.txtcommunity_perm_pop.Text);
			int community_man_pop=int.Parse(this.txtcommunity_man_pop.Text);
			int community_female_pop=int.Parse(this.txtcommunity_female_pop.Text);
			int community_younger_6_pop=int.Parse(this.txtcommunity_younger_6_pop.Text);
			int community_bet_7_and_15_pop=int.Parse(this.txtcommunity_bet_7_and_15_pop.Text);
			int community_bet_16_and_29_pop=int.Parse(this.txtcommunity_bet_16_and_29_pop.Text);
			int community_bet_30_and_39_pop=int.Parse(this.txtcommunity_bet_30_and_39_pop.Text);
			int community_bet_40_and_49_pop=int.Parse(this.txtcommunity_bet_40_and_49_pop.Text);
			int community_older_50_pop=int.Parse(this.txtcommunity_older_50_pop.Text);
			int community_illiteracy_pop=int.Parse(this.txtcommunity_illiteracy_pop.Text);
			int community_prim_school_edu_pop=int.Parse(this.txtcommunity_prim_school_edu_pop.Text);
			int community_junior_high_school_edu_pop=int.Parse(this.txtcommunity_junior_high_school_edu_pop.Text);
			int community_senior_high_school_edu_pop=int.Parse(this.txtcommunity_senior_high_school_edu_pop.Text);
			int community_junior_college_edu_pop=int.Parse(this.txtcommunity_junior_college_edu_pop.Text);
			decimal average_education_time=decimal.Parse(this.txtaverage_education_time.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcpunset1=this.txttcpunset1.Text;
			string tcpunset2=this.txttcpunset2.Text;
			string tcpunset3=this.txttcpunset3.Text;
			string tcpunset4=this.txttcpunset4.Text;
			string tcpunset5=this.txttcpunset5.Text;
			string tcpunset6=this.txttcpunset6.Text;
			string tcpunset7=this.txttcpunset7.Text;
			string tcpunset8=this.txttcpunset8.Text;
			string tcpunset10=this.txttcpunset10.Text;
			string tcpunset11=this.txttcpunset11.Text;
			string tcpunset12=this.txttcpunset12.Text;
			string tcpunset13=this.txttcpunset13.Text;
			string tcpunset14=this.txttcpunset14.Text;
			string tcpunset15=this.txttcpunset15.Text;
			string tcpunset16=this.txttcpunset16.Text;
			string tcpunset17=this.txttcpunset17.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			decimal community_family_num=decimal.Parse(this.txtcommunity_family_num.Text);

			TTG.Model.TTGWeb.community_population model=new TTG.Model.TTGWeb.community_population();
			model.community_id=community_id;
			model.community_total_pop=community_total_pop;
			model.community_reg_pop=community_reg_pop;
			model.community_perm_pop=community_perm_pop;
			model.community_man_pop=community_man_pop;
			model.community_female_pop=community_female_pop;
			model.community_younger_6_pop=community_younger_6_pop;
			model.community_bet_7_and_15_pop=community_bet_7_and_15_pop;
			model.community_bet_16_and_29_pop=community_bet_16_and_29_pop;
			model.community_bet_30_and_39_pop=community_bet_30_and_39_pop;
			model.community_bet_40_and_49_pop=community_bet_40_and_49_pop;
			model.community_older_50_pop=community_older_50_pop;
			model.community_illiteracy_pop=community_illiteracy_pop;
			model.community_prim_school_edu_pop=community_prim_school_edu_pop;
			model.community_junior_high_school_edu_pop=community_junior_high_school_edu_pop;
			model.community_senior_high_school_edu_pop=community_senior_high_school_edu_pop;
			model.community_junior_college_edu_pop=community_junior_college_edu_pop;
			model.average_education_time=average_education_time;
			model.statistics_date=statistics_date;
			model.tcpunset1=tcpunset1;
			model.tcpunset2=tcpunset2;
			model.tcpunset3=tcpunset3;
			model.tcpunset4=tcpunset4;
			model.tcpunset5=tcpunset5;
			model.tcpunset6=tcpunset6;
			model.tcpunset7=tcpunset7;
			model.tcpunset8=tcpunset8;
			model.tcpunset10=tcpunset10;
			model.tcpunset11=tcpunset11;
			model.tcpunset12=tcpunset12;
			model.tcpunset13=tcpunset13;
			model.tcpunset14=tcpunset14;
			model.tcpunset15=tcpunset15;
			model.tcpunset16=tcpunset16;
			model.tcpunset17=tcpunset17;
			model.check_status=check_status;
			model.lock_tables=lock_tables;
			model.community_family_num=community_family_num;

			TTG.BLL.TTGWeb.community_population bll=new TTG.BLL.TTGWeb.community_population();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
