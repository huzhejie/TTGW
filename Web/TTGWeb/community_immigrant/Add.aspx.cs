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
namespace TTG.Web.TTGWeb.community_immigrant
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
			if(!PageValidate.IsNumber(txtimmigrant_total_family_num.Text))
			{
				strErr+="immigrant_total_family_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtimmigrant_total_population.Text))
			{
				strErr+="immigrant_total_population格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_pure_resident_pop.Text))
			{
				strErr+="community_pure_resident_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_depart_pop.Text))
			{
				strErr+="community_depart_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_enp_staves.Text))
			{
				strErr+="community_enp_staves格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_enp_laidoff_staves.Text))
			{
				strErr+="community_enp_laidoff_staves格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_have_land_pop.Text))
			{
				strErr+="community_have_land_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_rural_to_town_pop.Text))
			{
				strErr+="community_rural_to_town_pop格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcimunset1.Text.Trim().Length==0)
			{
				strErr+="tcimunset1不能为空！\\n";	
			}
			if(this.txttcimunset2.Text.Trim().Length==0)
			{
				strErr+="tcimunset2不能为空！\\n";	
			}
			if(this.txttcimunset3.Text.Trim().Length==0)
			{
				strErr+="tcimunset3不能为空！\\n";	
			}
			if(this.txttcimunset4.Text.Trim().Length==0)
			{
				strErr+="tcimunset4不能为空！\\n";	
			}
			if(this.txttcimunset5.Text.Trim().Length==0)
			{
				strErr+="tcimunset5不能为空！\\n";	
			}
			if(this.txttcimunset6.Text.Trim().Length==0)
			{
				strErr+="tcimunset6不能为空！\\n";	
			}
			if(this.txttcimunset7.Text.Trim().Length==0)
			{
				strErr+="tcimunset7不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			int immigrant_total_family_num=int.Parse(this.txtimmigrant_total_family_num.Text);
			int immigrant_total_population=int.Parse(this.txtimmigrant_total_population.Text);
			int community_pure_resident_pop=int.Parse(this.txtcommunity_pure_resident_pop.Text);
			int community_depart_pop=int.Parse(this.txtcommunity_depart_pop.Text);
			int community_enp_staves=int.Parse(this.txtcommunity_enp_staves.Text);
			int community_enp_laidoff_staves=int.Parse(this.txtcommunity_enp_laidoff_staves.Text);
			int community_have_land_pop=int.Parse(this.txtcommunity_have_land_pop.Text);
			int community_rural_to_town_pop=int.Parse(this.txtcommunity_rural_to_town_pop.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcimunset1=this.txttcimunset1.Text;
			string tcimunset2=this.txttcimunset2.Text;
			string tcimunset3=this.txttcimunset3.Text;
			string tcimunset4=this.txttcimunset4.Text;
			string tcimunset5=this.txttcimunset5.Text;
			string tcimunset6=this.txttcimunset6.Text;
			string tcimunset7=this.txttcimunset7.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);

			TTG.Model.TTGWeb.community_immigrant model=new TTG.Model.TTGWeb.community_immigrant();
			model.community_id=community_id;
			model.immigrant_total_family_num=immigrant_total_family_num;
			model.immigrant_total_population=immigrant_total_population;
			model.community_pure_resident_pop=community_pure_resident_pop;
			model.community_depart_pop=community_depart_pop;
			model.community_enp_staves=community_enp_staves;
			model.community_enp_laidoff_staves=community_enp_laidoff_staves;
			model.community_have_land_pop=community_have_land_pop;
			model.community_rural_to_town_pop=community_rural_to_town_pop;
			model.statistics_date=statistics_date;
			model.tcimunset1=tcimunset1;
			model.tcimunset2=tcimunset2;
			model.tcimunset3=tcimunset3;
			model.tcimunset4=tcimunset4;
			model.tcimunset5=tcimunset5;
			model.tcimunset6=tcimunset6;
			model.tcimunset7=tcimunset7;
			model.check_status=check_status;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.community_immigrant bll=new TTG.BLL.TTGWeb.community_immigrant();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
