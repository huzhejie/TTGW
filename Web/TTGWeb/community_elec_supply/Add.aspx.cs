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
namespace TTG.Web.TTGWeb.community_elec_supply
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
			if(!PageValidate.IsNumber(txtcommunity_load_dispatching_office_num.Text))
			{
				strErr+="community_load_dispatching_office_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_transformer_num.Text))
			{
				strErr+="community_transformer_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtbelow_100kva_transformer_num.Text))
			{
				strErr+="below_100kva_transformer_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtat_100_500kva_transformer_num.Text))
			{
				strErr+="at_100_500kva_transformer_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtat_500_1000kva_transformer_num.Text))
			{
				strErr+="at_500_1000kva_transformer_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtmore_1000kva_transformer_num.Text))
			{
				strErr+="more_1000kva_transformer_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_elec_supply_wireways_length.Text))
			{
				strErr+="community_elec_supply_wireways_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_power_transmission_line_length.Text))
			{
				strErr+="community_power_transmission_line_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_high_voltage_distr_line_legth.Text))
			{
				strErr+="community_high_voltage_distr_line_legth格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_low_voltage_distr_line_legth.Text))
			{
				strErr+="community_low_voltage_distr_line_legth格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_elec_supply_consumption.Text))
			{
				strErr+="community_elec_supply_consumption格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_resident_elec_consumption.Text))
			{
				strErr+="community_resident_elec_consumption格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtno_elec_days.Text))
			{
				strErr+="no_elec_days格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcesunset1.Text.Trim().Length==0)
			{
				strErr+="tcesunset1不能为空！\\n";	
			}
			if(this.txttcesunset2.Text.Trim().Length==0)
			{
				strErr+="tcesunset2不能为空！\\n";	
			}
			if(this.txttcesunset3.Text.Trim().Length==0)
			{
				strErr+="tcesunset3不能为空！\\n";	
			}
			if(this.txttcesunset4.Text.Trim().Length==0)
			{
				strErr+="tcesunset4不能为空！\\n";	
			}
			if(this.txttcesunset5.Text.Trim().Length==0)
			{
				strErr+="tcesunset5不能为空！\\n";	
			}
			if(this.txttcesunset6.Text.Trim().Length==0)
			{
				strErr+="tcesunset6不能为空！\\n";	
			}
			if(this.txttcesunset7.Text.Trim().Length==0)
			{
				strErr+="tcesunset7不能为空！\\n";	
			}
			if(this.txttcesunset8.Text.Trim().Length==0)
			{
				strErr+="tcesunset8不能为空！\\n";	
			}
			if(this.txttcesunset9.Text.Trim().Length==0)
			{
				strErr+="tcesunset9不能为空！\\n";	
			}
			if(this.txttcesunset10.Text.Trim().Length==0)
			{
				strErr+="tcesunset10不能为空！\\n";	
			}
			if(this.txttcesunset11.Text.Trim().Length==0)
			{
				strErr+="tcesunset11不能为空！\\n";	
			}
			if(this.txttcesunset12.Text.Trim().Length==0)
			{
				strErr+="tcesunset12不能为空！\\n";	
			}
			if(this.txttcesunset13.Text.Trim().Length==0)
			{
				strErr+="tcesunset13不能为空！\\n";	
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
			int community_load_dispatching_office_num=int.Parse(this.txtcommunity_load_dispatching_office_num.Text);
			int community_transformer_num=int.Parse(this.txtcommunity_transformer_num.Text);
			int below_100kva_transformer_num=int.Parse(this.txtbelow_100kva_transformer_num.Text);
			int at_100_500kva_transformer_num=int.Parse(this.txtat_100_500kva_transformer_num.Text);
			int at_500_1000kva_transformer_num=int.Parse(this.txtat_500_1000kva_transformer_num.Text);
			int more_1000kva_transformer_num=int.Parse(this.txtmore_1000kva_transformer_num.Text);
			decimal community_elec_supply_wireways_length=decimal.Parse(this.txtcommunity_elec_supply_wireways_length.Text);
			decimal community_power_transmission_line_length=decimal.Parse(this.txtcommunity_power_transmission_line_length.Text);
			decimal community_high_voltage_distr_line_legth=decimal.Parse(this.txtcommunity_high_voltage_distr_line_legth.Text);
			decimal community_low_voltage_distr_line_legth=decimal.Parse(this.txtcommunity_low_voltage_distr_line_legth.Text);
			decimal community_elec_supply_consumption=decimal.Parse(this.txtcommunity_elec_supply_consumption.Text);
			decimal community_resident_elec_consumption=decimal.Parse(this.txtcommunity_resident_elec_consumption.Text);
			int no_elec_days=int.Parse(this.txtno_elec_days.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcesunset1=this.txttcesunset1.Text;
			string tcesunset2=this.txttcesunset2.Text;
			string tcesunset3=this.txttcesunset3.Text;
			string tcesunset4=this.txttcesunset4.Text;
			string tcesunset5=this.txttcesunset5.Text;
			string tcesunset6=this.txttcesunset6.Text;
			string tcesunset7=this.txttcesunset7.Text;
			string tcesunset8=this.txttcesunset8.Text;
			string tcesunset9=this.txttcesunset9.Text;
			string tcesunset10=this.txttcesunset10.Text;
			string tcesunset11=this.txttcesunset11.Text;
			string tcesunset12=this.txttcesunset12.Text;
			string tcesunset13=this.txttcesunset13.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_elec_supply model=new TTG.Model.TTGWeb.community_elec_supply();
			model.community_id=community_id;
			model.community_load_dispatching_office_num=community_load_dispatching_office_num;
			model.community_transformer_num=community_transformer_num;
			model.below_100kva_transformer_num=below_100kva_transformer_num;
			model.at_100_500kva_transformer_num=at_100_500kva_transformer_num;
			model.at_500_1000kva_transformer_num=at_500_1000kva_transformer_num;
			model.more_1000kva_transformer_num=more_1000kva_transformer_num;
			model.community_elec_supply_wireways_length=community_elec_supply_wireways_length;
			model.community_power_transmission_line_length=community_power_transmission_line_length;
			model.community_high_voltage_distr_line_legth=community_high_voltage_distr_line_legth;
			model.community_low_voltage_distr_line_legth=community_low_voltage_distr_line_legth;
			model.community_elec_supply_consumption=community_elec_supply_consumption;
			model.community_resident_elec_consumption=community_resident_elec_consumption;
			model.no_elec_days=no_elec_days;
			model.statistics_date=statistics_date;
			model.tcesunset1=tcesunset1;
			model.tcesunset2=tcesunset2;
			model.tcesunset3=tcesunset3;
			model.tcesunset4=tcesunset4;
			model.tcesunset5=tcesunset5;
			model.tcesunset6=tcesunset6;
			model.tcesunset7=tcesunset7;
			model.tcesunset8=tcesunset8;
			model.tcesunset9=tcesunset9;
			model.tcesunset10=tcesunset10;
			model.tcesunset11=tcesunset11;
			model.tcesunset12=tcesunset12;
			model.tcesunset13=tcesunset13;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_elec_supply bll=new TTG.BLL.TTGWeb.community_elec_supply();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
