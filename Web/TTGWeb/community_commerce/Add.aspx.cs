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
namespace TTG.Web.TTGWeb.community_commerce
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
			if(!PageValidate.IsNumber(txtcommunity_come_fac_num.Text))
			{
				strErr+="community_come_fac_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_come_fac_fs.Text))
			{
				strErr+="community_come_fac_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_come_fac_gfa.Text))
			{
				strErr+="community_come_fac_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_come_enp_num.Text))
			{
				strErr+="community_come_enp_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_come_enp_fs.Text))
			{
				strErr+="community_come_enp_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_come_enp_gfa.Text))
			{
				strErr+="community_come_enp_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_emporium_num.Text))
			{
				strErr+="community_emporium_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_small_supermarket_num.Text))
			{
				strErr+="community_small_supermarket_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_CVS_num.Text))
			{
				strErr+="community_CVS_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_restauran_num.Text))
			{
				strErr+="community_restauran_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_household_appliances_store_num.Text))
			{
				strErr+="community_household_appliances_store_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_agricultural_production_num.Text))
			{
				strErr+="community_agricultural_production_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_clothes_store_num.Text))
			{
				strErr+="community_clothes_store_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_hardware_building_materials_store_num.Text))
			{
				strErr+="community_hardware_building_materials_store_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_drugstore_num.Text))
			{
				strErr+="community_drugstore_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_bookstore_num.Text))
			{
				strErr+="community_bookstore_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_other_come_enp_num.Text))
			{
				strErr+="community_other_come_enp_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_farm_produce_fair_num.Text))
			{
				strErr+="community_farm_produce_fair_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_farm_produce_fair_gfa.Text))
			{
				strErr+="community_farm_produce_fair_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_farm_produce_fair_fs.Text))
			{
				strErr+="community_farm_produce_fair_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_farm_produce_fair_dis_ots.Text))
			{
				strErr+="community_farm_produce_fair_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_pedlar_market_num.Text))
			{
				strErr+="community_pedlar_market_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pedlar_market_gfa.Text))
			{
				strErr+="community_pedlar_market_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pedlar_market_fs.Text))
			{
				strErr+="community_pedlar_market_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pedlar_market_dis_ots.Text))
			{
				strErr+="community_pedlar_market_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_farm_whs_market_num.Text))
			{
				strErr+="community_farm_whs_market_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_farm_whs_market_gfa.Text))
			{
				strErr+="community_farm_whs_market_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_farm_whs_market_fs.Text))
			{
				strErr+="community_farm_whs_market_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_farm_whs_market_dis_ots.Text))
			{
				strErr+="community_farm_whs_market_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttccunset1.Text.Trim().Length==0)
			{
				strErr+="tccunset1不能为空！\\n";	
			}
			if(this.txttccunset2.Text.Trim().Length==0)
			{
				strErr+="tccunset2不能为空！\\n";	
			}
			if(this.txttccunset3.Text.Trim().Length==0)
			{
				strErr+="tccunset3不能为空！\\n";	
			}
			if(this.txttccunset4.Text.Trim().Length==0)
			{
				strErr+="tccunset4不能为空！\\n";	
			}
			if(this.txttccunset5.Text.Trim().Length==0)
			{
				strErr+="tccunset5不能为空！\\n";	
			}
			if(this.txttccunset6.Text.Trim().Length==0)
			{
				strErr+="tccunset6不能为空！\\n";	
			}
			if(this.txttccunset7.Text.Trim().Length==0)
			{
				strErr+="tccunset7不能为空！\\n";	
			}
			if(this.txttccunset8.Text.Trim().Length==0)
			{
				strErr+="tccunset8不能为空！\\n";	
			}
			if(this.txttccunset9.Text.Trim().Length==0)
			{
				strErr+="tccunset9不能为空！\\n";	
			}
			if(this.txttccunset10.Text.Trim().Length==0)
			{
				strErr+="tccunset10不能为空！\\n";	
			}
			if(this.txttccunset11.Text.Trim().Length==0)
			{
				strErr+="tccunset11不能为空！\\n";	
			}
			if(this.txttccunset12.Text.Trim().Length==0)
			{
				strErr+="tccunset12不能为空！\\n";	
			}
			if(this.txttccunset13.Text.Trim().Length==0)
			{
				strErr+="tccunset13不能为空！\\n";	
			}
			if(this.txttccunset14.Text.Trim().Length==0)
			{
				strErr+="tccunset14不能为空！\\n";	
			}
			if(this.txttccunset15.Text.Trim().Length==0)
			{
				strErr+="tccunset15不能为空！\\n";	
			}
			if(this.txttccunset16.Text.Trim().Length==0)
			{
				strErr+="tccunset16不能为空！\\n";	
			}
			if(this.txttccunset17.Text.Trim().Length==0)
			{
				strErr+="tccunset17不能为空！\\n";	
			}
			if(this.txttccunset18.Text.Trim().Length==0)
			{
				strErr+="tccunset18不能为空！\\n";	
			}
			if(this.txttccunset19.Text.Trim().Length==0)
			{
				strErr+="tccunset19不能为空！\\n";	
			}
			if(this.txttccunset20.Text.Trim().Length==0)
			{
				strErr+="tccunset20不能为空！\\n";	
			}
			if(this.txttccunset21.Text.Trim().Length==0)
			{
				strErr+="tccunset21不能为空！\\n";	
			}
			if(this.txttccunset22.Text.Trim().Length==0)
			{
				strErr+="tccunset22不能为空！\\n";	
			}
			if(this.txttccunset23.Text.Trim().Length==0)
			{
				strErr+="tccunset23不能为空！\\n";	
			}
			if(this.txttccunset24.Text.Trim().Length==0)
			{
				strErr+="tccunset24不能为空！\\n";	
			}
			if(this.txttccunset25.Text.Trim().Length==0)
			{
				strErr+="tccunset25不能为空！\\n";	
			}
			if(this.txttccunset26.Text.Trim().Length==0)
			{
				strErr+="tccunset26不能为空！\\n";	
			}
			if(this.txttccunset27.Text.Trim().Length==0)
			{
				strErr+="tccunset27不能为空！\\n";	
			}
			if(this.txttccunset28.Text.Trim().Length==0)
			{
				strErr+="tccunset28不能为空！\\n";	
			}
			if(this.txttccunset29.Text.Trim().Length==0)
			{
				strErr+="tccunset29不能为空！\\n";	
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
			int community_come_fac_num=int.Parse(this.txtcommunity_come_fac_num.Text);
			decimal community_come_fac_fs=decimal.Parse(this.txtcommunity_come_fac_fs.Text);
			decimal community_come_fac_gfa=decimal.Parse(this.txtcommunity_come_fac_gfa.Text);
			int community_come_enp_num=int.Parse(this.txtcommunity_come_enp_num.Text);
			decimal community_come_enp_fs=decimal.Parse(this.txtcommunity_come_enp_fs.Text);
			decimal community_come_enp_gfa=decimal.Parse(this.txtcommunity_come_enp_gfa.Text);
			int community_emporium_num=int.Parse(this.txtcommunity_emporium_num.Text);
			int community_small_supermarket_num=int.Parse(this.txtcommunity_small_supermarket_num.Text);
			int community_CVS_num=int.Parse(this.txtcommunity_CVS_num.Text);
			int community_restauran_num=int.Parse(this.txtcommunity_restauran_num.Text);
			int community_household_appliances_store_num=int.Parse(this.txtcommunity_household_appliances_store_num.Text);
			int community_agricultural_production_num=int.Parse(this.txtcommunity_agricultural_production_num.Text);
			int community_clothes_store_num=int.Parse(this.txtcommunity_clothes_store_num.Text);
			int community_hardware_building_materials_store_num=int.Parse(this.txtcommunity_hardware_building_materials_store_num.Text);
			int community_drugstore_num=int.Parse(this.txtcommunity_drugstore_num.Text);
			int community_bookstore_num=int.Parse(this.txtcommunity_bookstore_num.Text);
			int community_other_come_enp_num=int.Parse(this.txtcommunity_other_come_enp_num.Text);
			int community_farm_produce_fair_num=int.Parse(this.txtcommunity_farm_produce_fair_num.Text);
			decimal community_farm_produce_fair_gfa=decimal.Parse(this.txtcommunity_farm_produce_fair_gfa.Text);
			decimal community_farm_produce_fair_fs=decimal.Parse(this.txtcommunity_farm_produce_fair_fs.Text);
			decimal community_farm_produce_fair_dis_ots=decimal.Parse(this.txtcommunity_farm_produce_fair_dis_ots.Text);
			int community_pedlar_market_num=int.Parse(this.txtcommunity_pedlar_market_num.Text);
			decimal community_pedlar_market_gfa=decimal.Parse(this.txtcommunity_pedlar_market_gfa.Text);
			decimal community_pedlar_market_fs=decimal.Parse(this.txtcommunity_pedlar_market_fs.Text);
			decimal community_pedlar_market_dis_ots=decimal.Parse(this.txtcommunity_pedlar_market_dis_ots.Text);
			int community_farm_whs_market_num=int.Parse(this.txtcommunity_farm_whs_market_num.Text);
			decimal community_farm_whs_market_gfa=decimal.Parse(this.txtcommunity_farm_whs_market_gfa.Text);
			decimal community_farm_whs_market_fs=decimal.Parse(this.txtcommunity_farm_whs_market_fs.Text);
			decimal community_farm_whs_market_dis_ots=decimal.Parse(this.txtcommunity_farm_whs_market_dis_ots.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tccunset1=this.txttccunset1.Text;
			string tccunset2=this.txttccunset2.Text;
			string tccunset3=this.txttccunset3.Text;
			string tccunset4=this.txttccunset4.Text;
			string tccunset5=this.txttccunset5.Text;
			string tccunset6=this.txttccunset6.Text;
			string tccunset7=this.txttccunset7.Text;
			string tccunset8=this.txttccunset8.Text;
			string tccunset9=this.txttccunset9.Text;
			string tccunset10=this.txttccunset10.Text;
			string tccunset11=this.txttccunset11.Text;
			string tccunset12=this.txttccunset12.Text;
			string tccunset13=this.txttccunset13.Text;
			string tccunset14=this.txttccunset14.Text;
			string tccunset15=this.txttccunset15.Text;
			string tccunset16=this.txttccunset16.Text;
			string tccunset17=this.txttccunset17.Text;
			string tccunset18=this.txttccunset18.Text;
			string tccunset19=this.txttccunset19.Text;
			string tccunset20=this.txttccunset20.Text;
			string tccunset21=this.txttccunset21.Text;
			string tccunset22=this.txttccunset22.Text;
			string tccunset23=this.txttccunset23.Text;
			string tccunset24=this.txttccunset24.Text;
			string tccunset25=this.txttccunset25.Text;
			string tccunset26=this.txttccunset26.Text;
			string tccunset27=this.txttccunset27.Text;
			string tccunset28=this.txttccunset28.Text;
			string tccunset29=this.txttccunset29.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_commerce model=new TTG.Model.TTGWeb.community_commerce();
			model.community_id=community_id;
			model.community_come_fac_num=community_come_fac_num;
			model.community_come_fac_fs=community_come_fac_fs;
			model.community_come_fac_gfa=community_come_fac_gfa;
			model.community_come_enp_num=community_come_enp_num;
			model.community_come_enp_fs=community_come_enp_fs;
			model.community_come_enp_gfa=community_come_enp_gfa;
			model.community_emporium_num=community_emporium_num;
			model.community_small_supermarket_num=community_small_supermarket_num;
			model.community_CVS_num=community_CVS_num;
			model.community_restauran_num=community_restauran_num;
			model.community_household_appliances_store_num=community_household_appliances_store_num;
			model.community_agricultural_production_num=community_agricultural_production_num;
			model.community_clothes_store_num=community_clothes_store_num;
			model.community_hardware_building_materials_store_num=community_hardware_building_materials_store_num;
			model.community_drugstore_num=community_drugstore_num;
			model.community_bookstore_num=community_bookstore_num;
			model.community_other_come_enp_num=community_other_come_enp_num;
			model.community_farm_produce_fair_num=community_farm_produce_fair_num;
			model.community_farm_produce_fair_gfa=community_farm_produce_fair_gfa;
			model.community_farm_produce_fair_fs=community_farm_produce_fair_fs;
			model.community_farm_produce_fair_dis_ots=community_farm_produce_fair_dis_ots;
			model.community_pedlar_market_num=community_pedlar_market_num;
			model.community_pedlar_market_gfa=community_pedlar_market_gfa;
			model.community_pedlar_market_fs=community_pedlar_market_fs;
			model.community_pedlar_market_dis_ots=community_pedlar_market_dis_ots;
			model.community_farm_whs_market_num=community_farm_whs_market_num;
			model.community_farm_whs_market_gfa=community_farm_whs_market_gfa;
			model.community_farm_whs_market_fs=community_farm_whs_market_fs;
			model.community_farm_whs_market_dis_ots=community_farm_whs_market_dis_ots;
			model.statistics_date=statistics_date;
			model.tccunset1=tccunset1;
			model.tccunset2=tccunset2;
			model.tccunset3=tccunset3;
			model.tccunset4=tccunset4;
			model.tccunset5=tccunset5;
			model.tccunset6=tccunset6;
			model.tccunset7=tccunset7;
			model.tccunset8=tccunset8;
			model.tccunset9=tccunset9;
			model.tccunset10=tccunset10;
			model.tccunset11=tccunset11;
			model.tccunset12=tccunset12;
			model.tccunset13=tccunset13;
			model.tccunset14=tccunset14;
			model.tccunset15=tccunset15;
			model.tccunset16=tccunset16;
			model.tccunset17=tccunset17;
			model.tccunset18=tccunset18;
			model.tccunset19=tccunset19;
			model.tccunset20=tccunset20;
			model.tccunset21=tccunset21;
			model.tccunset22=tccunset22;
			model.tccunset23=tccunset23;
			model.tccunset24=tccunset24;
			model.tccunset25=tccunset25;
			model.tccunset26=tccunset26;
			model.tccunset27=tccunset27;
			model.tccunset28=tccunset28;
			model.tccunset29=tccunset29;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_commerce bll=new TTG.BLL.TTGWeb.community_commerce();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
