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
namespace TTG.Web.TTGWeb.community_water_drain_problem
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
			if(this.txtcommunity_fill_type.Text.Trim().Length==0)
			{
				strErr+="community_fill_type不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_pipe_no_reasonable_num.Text))
			{
				strErr+="community_pipe_no_reasonable_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_form_warea_num.Text))
			{
				strErr+="community_form_warea_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_form_warea_affect_res_num.Text))
			{
				strErr+="community_form_warea_affect_res_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_not_access_uspn_res_num.Text))
			{
				strErr+="community_not_access_uspn_res_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_not_access_uspn_house_num.Text))
			{
				strErr+="community_not_access_uspn_house_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_insuf_pipe_size_num.Text))
			{
				strErr+="community_insuf_pipe_size_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_pipe_aging_corrosion_num.Text))
			{
				strErr+="community_pipe_aging_corrosion_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_pipe_damage_num.Text))
			{
				strErr+="community_pipe_damage_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_septic_small_volume_num.Text))
			{
				strErr+="community_septic_small_volume_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_septic_damage_leaking_num.Text))
			{
				strErr+="community_septic_damage_leaking_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_sewage_straight_to_cj_num.Text))
			{
				strErr+="community_sewage_straight_to_cj_num格式错误！\\n";	
			}
			if(this.txtcommunity_gutter_damage.Text.Trim().Length==0)
			{
				strErr+="community_gutter_damage不能为空！\\n";	
			}
			if(this.txtcommunity_insuf_gutter.Text.Trim().Length==0)
			{
				strErr+="community_insuf_gutter不能为空！\\n";	
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
			if(this.txttciunset10.Text.Trim().Length==0)
			{
				strErr+="tciunset10不能为空！\\n";	
			}
			if(this.txttciunset11.Text.Trim().Length==0)
			{
				strErr+="tciunset11不能为空！\\n";	
			}
			if(this.txttciunset12.Text.Trim().Length==0)
			{
				strErr+="tciunset12不能为空！\\n";	
			}
			if(this.txttciunset13.Text.Trim().Length==0)
			{
				strErr+="tciunset13不能为空！\\n";	
			}
			if(this.txttciunset14.Text.Trim().Length==0)
			{
				strErr+="tciunset14不能为空！\\n";	
			}
			if(this.txttciunset15.Text.Trim().Length==0)
			{
				strErr+="tciunset15不能为空！\\n";	
			}
			if(this.txttciunset16.Text.Trim().Length==0)
			{
				strErr+="tciunset16不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pipe_damage_length.Text))
			{
				strErr+="community_pipe_damage_length格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			string community_fill_type=this.txtcommunity_fill_type.Text;
			int community_pipe_no_reasonable_num=int.Parse(this.txtcommunity_pipe_no_reasonable_num.Text);
			int community_form_warea_num=int.Parse(this.txtcommunity_form_warea_num.Text);
			int community_form_warea_affect_res_num=int.Parse(this.txtcommunity_form_warea_affect_res_num.Text);
			int community_not_access_uspn_res_num=int.Parse(this.txtcommunity_not_access_uspn_res_num.Text);
			int community_not_access_uspn_house_num=int.Parse(this.txtcommunity_not_access_uspn_house_num.Text);
			int community_insuf_pipe_size_num=int.Parse(this.txtcommunity_insuf_pipe_size_num.Text);
			int community_pipe_aging_corrosion_num=int.Parse(this.txtcommunity_pipe_aging_corrosion_num.Text);
			int community_pipe_damage_num=int.Parse(this.txtcommunity_pipe_damage_num.Text);
			int community_septic_small_volume_num=int.Parse(this.txtcommunity_septic_small_volume_num.Text);
			int community_septic_damage_leaking_num=int.Parse(this.txtcommunity_septic_damage_leaking_num.Text);
			int community_sewage_straight_to_cj_num=int.Parse(this.txtcommunity_sewage_straight_to_cj_num.Text);
			string community_gutter_damage=this.txtcommunity_gutter_damage.Text;
			string community_insuf_gutter=this.txtcommunity_insuf_gutter.Text;
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
			string tciunset10=this.txttciunset10.Text;
			string tciunset11=this.txttciunset11.Text;
			string tciunset12=this.txttciunset12.Text;
			string tciunset13=this.txttciunset13.Text;
			string tciunset14=this.txttciunset14.Text;
			string tciunset15=this.txttciunset15.Text;
			string tciunset16=this.txttciunset16.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			decimal community_pipe_damage_length=decimal.Parse(this.txtcommunity_pipe_damage_length.Text);

			TTG.Model.TTGWeb.community_water_drain_problem model=new TTG.Model.TTGWeb.community_water_drain_problem();
			model.community_id=community_id;
			model.community_fill_type=community_fill_type;
			model.community_pipe_no_reasonable_num=community_pipe_no_reasonable_num;
			model.community_form_warea_num=community_form_warea_num;
			model.community_form_warea_affect_res_num=community_form_warea_affect_res_num;
			model.community_not_access_uspn_res_num=community_not_access_uspn_res_num;
			model.community_not_access_uspn_house_num=community_not_access_uspn_house_num;
			model.community_insuf_pipe_size_num=community_insuf_pipe_size_num;
			model.community_pipe_aging_corrosion_num=community_pipe_aging_corrosion_num;
			model.community_pipe_damage_num=community_pipe_damage_num;
			model.community_septic_small_volume_num=community_septic_small_volume_num;
			model.community_septic_damage_leaking_num=community_septic_damage_leaking_num;
			model.community_sewage_straight_to_cj_num=community_sewage_straight_to_cj_num;
			model.community_gutter_damage=community_gutter_damage;
			model.community_insuf_gutter=community_insuf_gutter;
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
			model.tciunset10=tciunset10;
			model.tciunset11=tciunset11;
			model.tciunset12=tciunset12;
			model.tciunset13=tciunset13;
			model.tciunset14=tciunset14;
			model.tciunset15=tciunset15;
			model.tciunset16=tciunset16;
			model.lock_tables=lock_tables;
			model.community_pipe_damage_length=community_pipe_damage_length;

			TTG.BLL.TTGWeb.community_water_drain_problem bll=new TTG.BLL.TTGWeb.community_water_drain_problem();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
