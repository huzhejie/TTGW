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
namespace TTG.Web.TTGWeb.community_green_fields
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
			if(!PageValidate.IsDecimal(txtcommunity_green_fields_area.Text))
			{
				strErr+="community_green_fields_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_park_green_fields_area.Text))
			{
				strErr+="community_park_green_fields_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_garden_green_fields_area.Text))
			{
				strErr+="community_garden_green_fields_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_other_green_fields_area.Text))
			{
				strErr+="community_other_green_fields_area格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_green_fields_bet_dwellings_area.Text))
			{
				strErr+="community_green_fields_bet_dwellings_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_green_fields_area.Text))
			{
				strErr+="community_road_green_fields_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_accomm_green_fields_area.Text))
			{
				strErr+="community_public_accomm_green_fields_area格式错误！\\n";	
			}
			if(this.txttcgfunset1.Text.Trim().Length==0)
			{
				strErr+="tcgfunset1不能为空！\\n";	
			}
			if(this.txttcgfunset2.Text.Trim().Length==0)
			{
				strErr+="tcgfunset2不能为空！\\n";	
			}
			if(this.txttcgfunset3.Text.Trim().Length==0)
			{
				strErr+="tcgfunset3不能为空！\\n";	
			}
			if(this.txttcgfunset4.Text.Trim().Length==0)
			{
				strErr+="tcgfunset4不能为空！\\n";	
			}
			if(this.txttcgfunset5.Text.Trim().Length==0)
			{
				strErr+="tcgfunset5不能为空！\\n";	
			}
			if(this.txttcgfunset6.Text.Trim().Length==0)
			{
				strErr+="tcgfunset6不能为空！\\n";	
			}
			if(this.txttcgfunset7.Text.Trim().Length==0)
			{
				strErr+="tcgfunset7不能为空！\\n";	
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
			decimal community_green_fields_area=decimal.Parse(this.txtcommunity_green_fields_area.Text);
			decimal community_park_green_fields_area=decimal.Parse(this.txtcommunity_park_green_fields_area.Text);
			decimal community_garden_green_fields_area=decimal.Parse(this.txtcommunity_garden_green_fields_area.Text);
			decimal community_other_green_fields_area=decimal.Parse(this.txtcommunity_other_green_fields_area.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			decimal community_green_fields_bet_dwellings_area=decimal.Parse(this.txtcommunity_green_fields_bet_dwellings_area.Text);
			decimal community_road_green_fields_area=decimal.Parse(this.txtcommunity_road_green_fields_area.Text);
			decimal community_public_accomm_green_fields_area=decimal.Parse(this.txtcommunity_public_accomm_green_fields_area.Text);
			string tcgfunset1=this.txttcgfunset1.Text;
			string tcgfunset2=this.txttcgfunset2.Text;
			string tcgfunset3=this.txttcgfunset3.Text;
			string tcgfunset4=this.txttcgfunset4.Text;
			string tcgfunset5=this.txttcgfunset5.Text;
			string tcgfunset6=this.txttcgfunset6.Text;
			string tcgfunset7=this.txttcgfunset7.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_green_fields model=new TTG.Model.TTGWeb.community_green_fields();
			model.community_id=community_id;
			model.community_green_fields_area=community_green_fields_area;
			model.community_park_green_fields_area=community_park_green_fields_area;
			model.community_garden_green_fields_area=community_garden_green_fields_area;
			model.community_other_green_fields_area=community_other_green_fields_area;
			model.statistics_date=statistics_date;
			model.community_green_fields_bet_dwellings_area=community_green_fields_bet_dwellings_area;
			model.community_road_green_fields_area=community_road_green_fields_area;
			model.community_public_accomm_green_fields_area=community_public_accomm_green_fields_area;
			model.tcgfunset1=tcgfunset1;
			model.tcgfunset2=tcgfunset2;
			model.tcgfunset3=tcgfunset3;
			model.tcgfunset4=tcgfunset4;
			model.tcgfunset5=tcgfunset5;
			model.tcgfunset6=tcgfunset6;
			model.tcgfunset7=tcgfunset7;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_green_fields bll=new TTG.BLL.TTGWeb.community_green_fields();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}