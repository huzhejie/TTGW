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
namespace TTG.Web.TTGWeb.community_letter_view
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
			if(!PageValidate.IsNumber(txtcommunity_lv_num.Text))
			{
				strErr+="community_lv_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_pop.Text))
			{
				strErr+="community_lv_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_county_government_num.Text))
			{
				strErr+="community_lv_county_government_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_county_government_pop.Text))
			{
				strErr+="community_lv_county_government_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_county_industry_num.Text))
			{
				strErr+="community_lv_county_industry_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_county_industry_pop.Text))
			{
				strErr+="community_lv_county_industry_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_street_agency_num.Text))
			{
				strErr+="community_lv_street_agency_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_street_agency_pop.Text))
			{
				strErr+="community_lv_street_agency_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_neighborhood_committee_num.Text))
			{
				strErr+="community_lv_neighborhood_committee_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_neighborhood_committee_pop.Text))
			{
				strErr+="community_lv_neighborhood_committee_pop格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_immigration_num.Text))
			{
				strErr+="community_lv_immigration_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_basic_fac_num.Text))
			{
				strErr+="community_lv_basic_fac_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_service_fac_num.Text))
			{
				strErr+="community_lv_service_fac_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_livelihood_difficulty_num.Text))
			{
				strErr+="community_lv_livelihood_difficulty_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_lv_disputes_complaints_num.Text))
			{
				strErr+="community_lv_disputes_complaints_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttclvunset1.Text.Trim().Length==0)
			{
				strErr+="tclvunset1不能为空！\\n";	
			}
			if(this.txttclvunset2.Text.Trim().Length==0)
			{
				strErr+="tclvunset2不能为空！\\n";	
			}
			if(this.txttclvunset3.Text.Trim().Length==0)
			{
				strErr+="tclvunset3不能为空！\\n";	
			}
			if(this.txttclvunset4.Text.Trim().Length==0)
			{
				strErr+="tclvunset4不能为空！\\n";	
			}
			if(this.txttclvunset5.Text.Trim().Length==0)
			{
				strErr+="tclvunset5不能为空！\\n";	
			}
			if(this.txttclvunset6.Text.Trim().Length==0)
			{
				strErr+="tclvunset6不能为空！\\n";	
			}
			if(this.txttclvunset7.Text.Trim().Length==0)
			{
				strErr+="tclvunset7不能为空！\\n";	
			}
			if(this.txttclvunset8.Text.Trim().Length==0)
			{
				strErr+="tclvunset8不能为空！\\n";	
			}
			if(this.txttclvunset9.Text.Trim().Length==0)
			{
				strErr+="tclvunset9不能为空！\\n";	
			}
			if(this.txttclvunset10.Text.Trim().Length==0)
			{
				strErr+="tclvunset10不能为空！\\n";	
			}
			if(this.txttclvunset11.Text.Trim().Length==0)
			{
				strErr+="tclvunset11不能为空！\\n";	
			}
			if(this.txttclvunset12.Text.Trim().Length==0)
			{
				strErr+="tclvunset12不能为空！\\n";	
			}
			if(this.txttclvunset13.Text.Trim().Length==0)
			{
				strErr+="tclvunset13不能为空！\\n";	
			}
			if(this.txttclvunset14.Text.Trim().Length==0)
			{
				strErr+="tclvunset14不能为空！\\n";	
			}
			if(this.txttclvunset15.Text.Trim().Length==0)
			{
				strErr+="tclvunset15不能为空！\\n";	
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
			int community_lv_num=int.Parse(this.txtcommunity_lv_num.Text);
			int community_lv_pop=int.Parse(this.txtcommunity_lv_pop.Text);
			int community_lv_county_government_num=int.Parse(this.txtcommunity_lv_county_government_num.Text);
			int community_lv_county_government_pop=int.Parse(this.txtcommunity_lv_county_government_pop.Text);
			int community_lv_county_industry_num=int.Parse(this.txtcommunity_lv_county_industry_num.Text);
			int community_lv_county_industry_pop=int.Parse(this.txtcommunity_lv_county_industry_pop.Text);
			int community_lv_street_agency_num=int.Parse(this.txtcommunity_lv_street_agency_num.Text);
			int community_lv_street_agency_pop=int.Parse(this.txtcommunity_lv_street_agency_pop.Text);
			int community_lv_neighborhood_committee_num=int.Parse(this.txtcommunity_lv_neighborhood_committee_num.Text);
			int community_lv_neighborhood_committee_pop=int.Parse(this.txtcommunity_lv_neighborhood_committee_pop.Text);
			int community_lv_immigration_num=int.Parse(this.txtcommunity_lv_immigration_num.Text);
			int community_lv_basic_fac_num=int.Parse(this.txtcommunity_lv_basic_fac_num.Text);
			int community_lv_service_fac_num=int.Parse(this.txtcommunity_lv_service_fac_num.Text);
			int community_lv_livelihood_difficulty_num=int.Parse(this.txtcommunity_lv_livelihood_difficulty_num.Text);
			int community_lv_disputes_complaints_num=int.Parse(this.txtcommunity_lv_disputes_complaints_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tclvunset1=this.txttclvunset1.Text;
			string tclvunset2=this.txttclvunset2.Text;
			string tclvunset3=this.txttclvunset3.Text;
			string tclvunset4=this.txttclvunset4.Text;
			string tclvunset5=this.txttclvunset5.Text;
			string tclvunset6=this.txttclvunset6.Text;
			string tclvunset7=this.txttclvunset7.Text;
			string tclvunset8=this.txttclvunset8.Text;
			string tclvunset9=this.txttclvunset9.Text;
			string tclvunset10=this.txttclvunset10.Text;
			string tclvunset11=this.txttclvunset11.Text;
			string tclvunset12=this.txttclvunset12.Text;
			string tclvunset13=this.txttclvunset13.Text;
			string tclvunset14=this.txttclvunset14.Text;
			string tclvunset15=this.txttclvunset15.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_letter_view model=new TTG.Model.TTGWeb.community_letter_view();
			model.community_id=community_id;
			model.community_lv_num=community_lv_num;
			model.community_lv_pop=community_lv_pop;
			model.community_lv_county_government_num=community_lv_county_government_num;
			model.community_lv_county_government_pop=community_lv_county_government_pop;
			model.community_lv_county_industry_num=community_lv_county_industry_num;
			model.community_lv_county_industry_pop=community_lv_county_industry_pop;
			model.community_lv_street_agency_num=community_lv_street_agency_num;
			model.community_lv_street_agency_pop=community_lv_street_agency_pop;
			model.community_lv_neighborhood_committee_num=community_lv_neighborhood_committee_num;
			model.community_lv_neighborhood_committee_pop=community_lv_neighborhood_committee_pop;
			model.community_lv_immigration_num=community_lv_immigration_num;
			model.community_lv_basic_fac_num=community_lv_basic_fac_num;
			model.community_lv_service_fac_num=community_lv_service_fac_num;
			model.community_lv_livelihood_difficulty_num=community_lv_livelihood_difficulty_num;
			model.community_lv_disputes_complaints_num=community_lv_disputes_complaints_num;
			model.statistics_date=statistics_date;
			model.tclvunset1=tclvunset1;
			model.tclvunset2=tclvunset2;
			model.tclvunset3=tclvunset3;
			model.tclvunset4=tclvunset4;
			model.tclvunset5=tclvunset5;
			model.tclvunset6=tclvunset6;
			model.tclvunset7=tclvunset7;
			model.tclvunset8=tclvunset8;
			model.tclvunset9=tclvunset9;
			model.tclvunset10=tclvunset10;
			model.tclvunset11=tclvunset11;
			model.tclvunset12=tclvunset12;
			model.tclvunset13=tclvunset13;
			model.tclvunset14=tclvunset14;
			model.tclvunset15=tclvunset15;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_letter_view bll=new TTG.BLL.TTGWeb.community_letter_view();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
