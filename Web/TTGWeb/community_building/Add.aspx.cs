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
namespace TTG.Web.TTGWeb.community_building
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
			if(!PageValidate.IsDecimal(txtcommunity_building_total_gfa.Text))
			{
				strErr+="community_building_total_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_building_total_fs.Text))
			{
				strErr+="community_building_total_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_building_total_num.Text))
			{
				strErr+="community_building_total_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_house_gfa.Text))
			{
				strErr+="community_house_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_house_fs.Text))
			{
				strErr+="community_house_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_house_num.Text))
			{
				strErr+="community_house_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_edu_gfa.Text))
			{
				strErr+="community_edu_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_edu_fs.Text))
			{
				strErr+="community_edu_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_edu_num.Text))
			{
				strErr+="community_edu_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_medical_gfa.Text))
			{
				strErr+="community_medical_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_medical_fs.Text))
			{
				strErr+="community_medical_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_medical_num.Text))
			{
				strErr+="community_medical_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_culture_sports_gfa.Text))
			{
				strErr+="community_culture_sports_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_culture_sports_fs.Text))
			{
				strErr+="community_culture_sports_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_culture_sports_num.Text))
			{
				strErr+="community_culture_sports_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_service_gfa.Text))
			{
				strErr+="community_service_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_service_fs.Text))
			{
				strErr+="community_service_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_service_num.Text))
			{
				strErr+="community_service_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_other_building_gfa.Text))
			{
				strErr+="community_other_building_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_other_building_fs.Text))
			{
				strErr+="community_other_building_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_other_building_num.Text))
			{
				strErr+="community_other_building_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcbunset1.Text.Trim().Length==0)
			{
				strErr+="tcbunset1不能为空！\\n";	
			}
			if(this.txttcbunset2.Text.Trim().Length==0)
			{
				strErr+="tcbunset2不能为空！\\n";	
			}
			if(this.txttcbunset3.Text.Trim().Length==0)
			{
				strErr+="tcbunset3不能为空！\\n";	
			}
			if(this.txttcbunset4.Text.Trim().Length==0)
			{
				strErr+="tcbunset4不能为空！\\n";	
			}
			if(this.txttcbunset5.Text.Trim().Length==0)
			{
				strErr+="tcbunset5不能为空！\\n";	
			}
			if(this.txttcbunset6.Text.Trim().Length==0)
			{
				strErr+="tcbunset6不能为空！\\n";	
			}
			if(this.txttcbunset7.Text.Trim().Length==0)
			{
				strErr+="tcbunset7不能为空！\\n";	
			}
			if(this.txttcbunset8.Text.Trim().Length==0)
			{
				strErr+="tcbunset8不能为空！\\n";	
			}
			if(this.txttcbunset9.Text.Trim().Length==0)
			{
				strErr+="tcbunset9不能为空！\\n";	
			}
			if(this.txttcbunset10.Text.Trim().Length==0)
			{
				strErr+="tcbunset10不能为空！\\n";	
			}
			if(this.txttcbunset11.Text.Trim().Length==0)
			{
				strErr+="tcbunset11不能为空！\\n";	
			}
			if(this.txttcbunset12.Text.Trim().Length==0)
			{
				strErr+="tcbunset12不能为空！\\n";	
			}
			if(this.txttcbunset13.Text.Trim().Length==0)
			{
				strErr+="tcbunset13不能为空！\\n";	
			}
			if(this.txttcbunset14.Text.Trim().Length==0)
			{
				strErr+="tcbunset14不能为空！\\n";	
			}
			if(this.txttcbunset15.Text.Trim().Length==0)
			{
				strErr+="tcbunset15不能为空！\\n";	
			}
			if(this.txttcbunset16.Text.Trim().Length==0)
			{
				strErr+="tcbunset16不能为空！\\n";	
			}
			if(this.txttcbunset17.Text.Trim().Length==0)
			{
				strErr+="tcbunset17不能为空！\\n";	
			}
			if(this.txttcbunset18.Text.Trim().Length==0)
			{
				strErr+="tcbunset18不能为空！\\n";	
			}
			if(this.txttcbunset19.Text.Trim().Length==0)
			{
				strErr+="tcbunset19不能为空！\\n";	
			}
			if(this.txttcbunset20.Text.Trim().Length==0)
			{
				strErr+="tcbunset20不能为空！\\n";	
			}
			if(this.txttcbunset21.Text.Trim().Length==0)
			{
				strErr+="tcbunset21不能为空！\\n";	
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
			decimal community_building_total_gfa=decimal.Parse(this.txtcommunity_building_total_gfa.Text);
			decimal community_building_total_fs=decimal.Parse(this.txtcommunity_building_total_fs.Text);
			int community_building_total_num=int.Parse(this.txtcommunity_building_total_num.Text);
			decimal community_house_gfa=decimal.Parse(this.txtcommunity_house_gfa.Text);
			decimal community_house_fs=decimal.Parse(this.txtcommunity_house_fs.Text);
			int community_house_num=int.Parse(this.txtcommunity_house_num.Text);
			decimal community_edu_gfa=decimal.Parse(this.txtcommunity_edu_gfa.Text);
			decimal community_edu_fs=decimal.Parse(this.txtcommunity_edu_fs.Text);
			int community_edu_num=int.Parse(this.txtcommunity_edu_num.Text);
			decimal community_medical_gfa=decimal.Parse(this.txtcommunity_medical_gfa.Text);
			decimal community_medical_fs=decimal.Parse(this.txtcommunity_medical_fs.Text);
			int community_medical_num=int.Parse(this.txtcommunity_medical_num.Text);
			decimal community_culture_sports_gfa=decimal.Parse(this.txtcommunity_culture_sports_gfa.Text);
			decimal community_culture_sports_fs=decimal.Parse(this.txtcommunity_culture_sports_fs.Text);
			int community_culture_sports_num=int.Parse(this.txtcommunity_culture_sports_num.Text);
			decimal community_service_gfa=decimal.Parse(this.txtcommunity_service_gfa.Text);
			decimal community_service_fs=decimal.Parse(this.txtcommunity_service_fs.Text);
			int community_service_num=int.Parse(this.txtcommunity_service_num.Text);
			decimal community_other_building_gfa=decimal.Parse(this.txtcommunity_other_building_gfa.Text);
			decimal community_other_building_fs=decimal.Parse(this.txtcommunity_other_building_fs.Text);
			int community_other_building_num=int.Parse(this.txtcommunity_other_building_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcbunset1=this.txttcbunset1.Text;
			string tcbunset2=this.txttcbunset2.Text;
			string tcbunset3=this.txttcbunset3.Text;
			string tcbunset4=this.txttcbunset4.Text;
			string tcbunset5=this.txttcbunset5.Text;
			string tcbunset6=this.txttcbunset6.Text;
			string tcbunset7=this.txttcbunset7.Text;
			string tcbunset8=this.txttcbunset8.Text;
			string tcbunset9=this.txttcbunset9.Text;
			string tcbunset10=this.txttcbunset10.Text;
			string tcbunset11=this.txttcbunset11.Text;
			string tcbunset12=this.txttcbunset12.Text;
			string tcbunset13=this.txttcbunset13.Text;
			string tcbunset14=this.txttcbunset14.Text;
			string tcbunset15=this.txttcbunset15.Text;
			string tcbunset16=this.txttcbunset16.Text;
			string tcbunset17=this.txttcbunset17.Text;
			string tcbunset18=this.txttcbunset18.Text;
			string tcbunset19=this.txttcbunset19.Text;
			string tcbunset20=this.txttcbunset20.Text;
			string tcbunset21=this.txttcbunset21.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);

			TTG.Model.TTGWeb.community_building model=new TTG.Model.TTGWeb.community_building();
			model.community_id=community_id;
			model.community_building_total_gfa=community_building_total_gfa;
			model.community_building_total_fs=community_building_total_fs;
			model.community_building_total_num=community_building_total_num;
			model.community_house_gfa=community_house_gfa;
			model.community_house_fs=community_house_fs;
			model.community_house_num=community_house_num;
			model.community_edu_gfa=community_edu_gfa;
			model.community_edu_fs=community_edu_fs;
			model.community_edu_num=community_edu_num;
			model.community_medical_gfa=community_medical_gfa;
			model.community_medical_fs=community_medical_fs;
			model.community_medical_num=community_medical_num;
			model.community_culture_sports_gfa=community_culture_sports_gfa;
			model.community_culture_sports_fs=community_culture_sports_fs;
			model.community_culture_sports_num=community_culture_sports_num;
			model.community_service_gfa=community_service_gfa;
			model.community_service_fs=community_service_fs;
			model.community_service_num=community_service_num;
			model.community_other_building_gfa=community_other_building_gfa;
			model.community_other_building_fs=community_other_building_fs;
			model.community_other_building_num=community_other_building_num;
			model.statistics_date=statistics_date;
			model.tcbunset1=tcbunset1;
			model.tcbunset2=tcbunset2;
			model.tcbunset3=tcbunset3;
			model.tcbunset4=tcbunset4;
			model.tcbunset5=tcbunset5;
			model.tcbunset6=tcbunset6;
			model.tcbunset7=tcbunset7;
			model.tcbunset8=tcbunset8;
			model.tcbunset9=tcbunset9;
			model.tcbunset10=tcbunset10;
			model.tcbunset11=tcbunset11;
			model.tcbunset12=tcbunset12;
			model.tcbunset13=tcbunset13;
			model.tcbunset14=tcbunset14;
			model.tcbunset15=tcbunset15;
			model.tcbunset16=tcbunset16;
			model.tcbunset17=tcbunset17;
			model.tcbunset18=tcbunset18;
			model.tcbunset19=tcbunset19;
			model.tcbunset20=tcbunset20;
			model.tcbunset21=tcbunset21;
			model.check_status=check_status;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.community_building bll=new TTG.BLL.TTGWeb.community_building();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
