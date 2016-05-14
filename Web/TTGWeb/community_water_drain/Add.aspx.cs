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
namespace TTG.Web.TTGWeb.community_water_drain
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
			if(this.txtcommunity_water_drain_mechanism.Text.Trim().Length==0)
			{
				strErr+="community_water_drain_mechanism不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_domestic_sewage_consumption.Text))
			{
				strErr+="community_domestic_sewage_consumption格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_drain_pipe_length.Text))
			{
				strErr+="community_water_drain_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_drain_main_pipe_length.Text))
			{
				strErr+="community_water_drain_main_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_drain_pipe_branch_length.Text))
			{
				strErr+="community_water_drain_pipe_branch_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_drain_service_pipe_length.Text))
			{
				strErr+="community_water_drain_service_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_drain_canal_length.Text))
			{
				strErr+="community_water_drain_canal_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_open_drain_canal_length.Text))
			{
				strErr+="community_water_open_drain_canal_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_septic_tank_num.Text))
			{
				strErr+="community_septic_tank_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_septic_tank_capacity.Text))
			{
				strErr+="community_septic_tank_capacity格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcwdunset1.Text.Trim().Length==0)
			{
				strErr+="tcwdunset1不能为空！\\n";	
			}
			if(this.txttcwdunset2.Text.Trim().Length==0)
			{
				strErr+="tcwdunset2不能为空！\\n";	
			}
			if(this.txttcwdunset3.Text.Trim().Length==0)
			{
				strErr+="tcwdunset3不能为空！\\n";	
			}
			if(this.txttcwdunset4.Text.Trim().Length==0)
			{
				strErr+="tcwdunset4不能为空！\\n";	
			}
			if(this.txttcwdunset5.Text.Trim().Length==0)
			{
				strErr+="tcwdunset5不能为空！\\n";	
			}
			if(this.txttcwdunset6.Text.Trim().Length==0)
			{
				strErr+="tcwdunset6不能为空！\\n";	
			}
			if(this.txttcwdunset7.Text.Trim().Length==0)
			{
				strErr+="tcwdunset7不能为空！\\n";	
			}
			if(this.txttcwdunset8.Text.Trim().Length==0)
			{
				strErr+="tcwdunset8不能为空！\\n";	
			}
			if(this.txttcwdunset9.Text.Trim().Length==0)
			{
				strErr+="tcwdunset9不能为空！\\n";	
			}
			if(this.txttcwdunset10.Text.Trim().Length==0)
			{
				strErr+="tcwdunset10不能为空！\\n";	
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
			string community_water_drain_mechanism=this.txtcommunity_water_drain_mechanism.Text;
			decimal community_domestic_sewage_consumption=decimal.Parse(this.txtcommunity_domestic_sewage_consumption.Text);
			decimal community_water_drain_pipe_length=decimal.Parse(this.txtcommunity_water_drain_pipe_length.Text);
			decimal community_water_drain_main_pipe_length=decimal.Parse(this.txtcommunity_water_drain_main_pipe_length.Text);
			decimal community_water_drain_pipe_branch_length=decimal.Parse(this.txtcommunity_water_drain_pipe_branch_length.Text);
			decimal community_water_drain_service_pipe_length=decimal.Parse(this.txtcommunity_water_drain_service_pipe_length.Text);
			decimal community_water_drain_canal_length=decimal.Parse(this.txtcommunity_water_drain_canal_length.Text);
			decimal community_water_open_drain_canal_length=decimal.Parse(this.txtcommunity_water_open_drain_canal_length.Text);
			decimal community_septic_tank_num=decimal.Parse(this.txtcommunity_septic_tank_num.Text);
			decimal community_septic_tank_capacity=decimal.Parse(this.txtcommunity_septic_tank_capacity.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcwdunset1=this.txttcwdunset1.Text;
			string tcwdunset2=this.txttcwdunset2.Text;
			string tcwdunset3=this.txttcwdunset3.Text;
			string tcwdunset4=this.txttcwdunset4.Text;
			string tcwdunset5=this.txttcwdunset5.Text;
			string tcwdunset6=this.txttcwdunset6.Text;
			string tcwdunset7=this.txttcwdunset7.Text;
			string tcwdunset8=this.txttcwdunset8.Text;
			string tcwdunset9=this.txttcwdunset9.Text;
			string tcwdunset10=this.txttcwdunset10.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_water_drain model=new TTG.Model.TTGWeb.community_water_drain();
			model.community_id=community_id;
			model.community_water_drain_mechanism=community_water_drain_mechanism;
			model.community_domestic_sewage_consumption=community_domestic_sewage_consumption;
			model.community_water_drain_pipe_length=community_water_drain_pipe_length;
			model.community_water_drain_main_pipe_length=community_water_drain_main_pipe_length;
			model.community_water_drain_pipe_branch_length=community_water_drain_pipe_branch_length;
			model.community_water_drain_service_pipe_length=community_water_drain_service_pipe_length;
			model.community_water_drain_canal_length=community_water_drain_canal_length;
			model.community_water_open_drain_canal_length=community_water_open_drain_canal_length;
			model.community_septic_tank_num=community_septic_tank_num;
			model.community_septic_tank_capacity=community_septic_tank_capacity;
			model.statistics_date=statistics_date;
			model.tcwdunset1=tcwdunset1;
			model.tcwdunset2=tcwdunset2;
			model.tcwdunset3=tcwdunset3;
			model.tcwdunset4=tcwdunset4;
			model.tcwdunset5=tcwdunset5;
			model.tcwdunset6=tcwdunset6;
			model.tcwdunset7=tcwdunset7;
			model.tcwdunset8=tcwdunset8;
			model.tcwdunset9=tcwdunset9;
			model.tcwdunset10=tcwdunset10;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_water_drain bll=new TTG.BLL.TTGWeb.community_water_drain();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
