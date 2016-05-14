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
namespace TTG.Web.TTGWeb.community_sanitation_problem_finished
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
			if(!PageValidate.IsNumber(txtcommunity_added_ashbin_num.Text))
			{
				strErr+="community_added_ashbin_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_dustbin_num.Text))
			{
				strErr+="community_added_dustbin_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_toilet_num.Text))
			{
				strErr+="community_public_toilet_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_toilet_area.Text))
			{
				strErr+="community_public_toilet_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_waste_transfer_station_num.Text))
			{
				strErr+="community_added_waste_transfer_station_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_added_waste_transfer_station_area.Text))
			{
				strErr+="community_added_waste_transfer_station_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_ashbin_dustbin_num.Text))
			{
				strErr+="community_added_ashbin_dustbin_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(this.txttciunset1.Text.Trim().Length==0)
			{
				strErr+="tciunset1不能为空！\\n";	
			}
			if(this.txttciunset2.Text.Trim().Length==0)
			{
				strErr+="tciunset2不能为空！\\n";	
			}
			if(this.txttciunset3.Text.Trim().Length==0)
			{
				strErr+="tciunset3不能为空！\\n";	
			}
			if(this.txttciunset4.Text.Trim().Length==0)
			{
				strErr+="tciunset4不能为空！\\n";	
			}
			if(this.txttciunset5.Text.Trim().Length==0)
			{
				strErr+="tciunset5不能为空！\\n";	
			}
			if(this.txttciunset6.Text.Trim().Length==0)
			{
				strErr+="tciunset6不能为空！\\n";	
			}
			if(this.txttciunset7.Text.Trim().Length==0)
			{
				strErr+="tciunset7不能为空！\\n";	
			}
			if(this.txttciunset8.Text.Trim().Length==0)
			{
				strErr+="tciunset8不能为空！\\n";	
			}
			if(this.txttciunset9.Text.Trim().Length==0)
			{
				strErr+="tciunset9不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_toilet_num_f_update.Text))
			{
				strErr+="community_public_toilet_num_f_update格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_toilet_area_f_update.Text))
			{
				strErr+="community_public_toilet_area_f_update格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			int community_added_ashbin_num=int.Parse(this.txtcommunity_added_ashbin_num.Text);
			int community_added_dustbin_num=int.Parse(this.txtcommunity_added_dustbin_num.Text);
			int community_public_toilet_num=int.Parse(this.txtcommunity_public_toilet_num.Text);
			decimal community_public_toilet_area=decimal.Parse(this.txtcommunity_public_toilet_area.Text);
			int community_added_waste_transfer_station_num=int.Parse(this.txtcommunity_added_waste_transfer_station_num.Text);
			decimal community_added_waste_transfer_station_area=decimal.Parse(this.txtcommunity_added_waste_transfer_station_area.Text);
			int community_added_ashbin_dustbin_num=int.Parse(this.txtcommunity_added_ashbin_dustbin_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			string tciunset5=this.txttciunset5.Text;
			string tciunset6=this.txttciunset6.Text;
			string tciunset7=this.txttciunset7.Text;
			string tciunset8=this.txttciunset8.Text;
			string tciunset9=this.txttciunset9.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int community_public_toilet_num_f_update=int.Parse(this.txtcommunity_public_toilet_num_f_update.Text);
			decimal community_public_toilet_area_f_update=decimal.Parse(this.txtcommunity_public_toilet_area_f_update.Text);

			TTG.Model.TTGWeb.community_sanitation_problem_finished model=new TTG.Model.TTGWeb.community_sanitation_problem_finished();
			model.community_id=community_id;
			model.community_added_ashbin_num=community_added_ashbin_num;
			model.community_added_dustbin_num=community_added_dustbin_num;
			model.community_public_toilet_num=community_public_toilet_num;
			model.community_public_toilet_area=community_public_toilet_area;
			model.community_added_waste_transfer_station_num=community_added_waste_transfer_station_num;
			model.community_added_waste_transfer_station_area=community_added_waste_transfer_station_area;
			model.community_added_ashbin_dustbin_num=community_added_ashbin_dustbin_num;
			model.statistics_date=statistics_date;
			model.check_status=check_status;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.tciunset5=tciunset5;
			model.tciunset6=tciunset6;
			model.tciunset7=tciunset7;
			model.tciunset8=tciunset8;
			model.tciunset9=tciunset9;
			model.lock_tables=lock_tables;
			model.community_public_toilet_num_f_update=community_public_toilet_num_f_update;
			model.community_public_toilet_area_f_update=community_public_toilet_area_f_update;

			TTG.BLL.TTGWeb.community_sanitation_problem_finished bll=new TTG.BLL.TTGWeb.community_sanitation_problem_finished();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
