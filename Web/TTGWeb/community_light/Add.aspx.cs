﻿using System;
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
namespace TTG.Web.TTGWeb.community_light
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
			if(!PageValidate.IsNumber(txtcommunity_streetlight_num.Text))
			{
				strErr+="community_streetlight_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_energy_efficient_streetlight_num.Text))
			{
				strErr+="community_energy_efficient_streetlight_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_good_streetlight_rate.Text))
			{
				strErr+="community_good_streetlight_rate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_otd_exercise_yard_light_num.Text))
			{
				strErr+="community_otd_exercise_yard_light_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_otd_good_exercise_yard_light_rate.Text))
			{
				strErr+="community_otd_good_exercise_yard_light_rate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_passageway_light_num.Text))
			{
				strErr+="community_passageway_light_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_good_passageway_light_rate.Text))
			{
				strErr+="community_good_passageway_light_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcltunset1.Text.Trim().Length==0)
			{
				strErr+="tcltunset1不能为空！\\n";	
			}
			if(this.txttcltunset2.Text.Trim().Length==0)
			{
				strErr+="tcltunset2不能为空！\\n";	
			}
			if(this.txttcltunset3.Text.Trim().Length==0)
			{
				strErr+="tcltunset3不能为空！\\n";	
			}
			if(this.txttcltunset4.Text.Trim().Length==0)
			{
				strErr+="tcltunset4不能为空！\\n";	
			}
			if(this.txttcltunset5.Text.Trim().Length==0)
			{
				strErr+="tcltunset5不能为空！\\n";	
			}
			if(this.txttcltunset6.Text.Trim().Length==0)
			{
				strErr+="tcltunset6不能为空！\\n";	
			}
			if(this.txttcltunset7.Text.Trim().Length==0)
			{
				strErr+="tcltunset7不能为空！\\n";	
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
			int community_streetlight_num=int.Parse(this.txtcommunity_streetlight_num.Text);
			int community_energy_efficient_streetlight_num=int.Parse(this.txtcommunity_energy_efficient_streetlight_num.Text);
			decimal community_good_streetlight_rate=decimal.Parse(this.txtcommunity_good_streetlight_rate.Text);
			int community_otd_exercise_yard_light_num=int.Parse(this.txtcommunity_otd_exercise_yard_light_num.Text);
			decimal community_otd_good_exercise_yard_light_rate=decimal.Parse(this.txtcommunity_otd_good_exercise_yard_light_rate.Text);
			int community_passageway_light_num=int.Parse(this.txtcommunity_passageway_light_num.Text);
			decimal community_good_passageway_light_rate=decimal.Parse(this.txtcommunity_good_passageway_light_rate.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcltunset1=this.txttcltunset1.Text;
			string tcltunset2=this.txttcltunset2.Text;
			string tcltunset3=this.txttcltunset3.Text;
			string tcltunset4=this.txttcltunset4.Text;
			string tcltunset5=this.txttcltunset5.Text;
			string tcltunset6=this.txttcltunset6.Text;
			string tcltunset7=this.txttcltunset7.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_light model=new TTG.Model.TTGWeb.community_light();
			model.community_id=community_id;
			model.community_streetlight_num=community_streetlight_num;
			model.community_energy_efficient_streetlight_num=community_energy_efficient_streetlight_num;
			model.community_good_streetlight_rate=community_good_streetlight_rate;
			model.community_otd_exercise_yard_light_num=community_otd_exercise_yard_light_num;
			model.community_otd_good_exercise_yard_light_rate=community_otd_good_exercise_yard_light_rate;
			model.community_passageway_light_num=community_passageway_light_num;
			model.community_good_passageway_light_rate=community_good_passageway_light_rate;
			model.statistics_date=statistics_date;
			model.tcltunset1=tcltunset1;
			model.tcltunset2=tcltunset2;
			model.tcltunset3=tcltunset3;
			model.tcltunset4=tcltunset4;
			model.tcltunset5=tcltunset5;
			model.tcltunset6=tcltunset6;
			model.tcltunset7=tcltunset7;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_light bll=new TTG.BLL.TTGWeb.community_light();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
