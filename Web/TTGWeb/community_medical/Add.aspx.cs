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
namespace TTG.Web.TTGWeb.community_medical
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
			if(!PageValidate.IsNumber(txtcommunity_medical_inst_num.Text))
			{
				strErr+="community_medical_inst_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_medical_inst_fs.Text))
			{
				strErr+="community_medical_inst_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_medical_inst_gfa.Text))
			{
				strErr+="community_medical_inst_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_hospital_num.Text))
			{
				strErr+="community_hospital_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_hospital_gfa.Text))
			{
				strErr+="community_hospital_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_hospital_fs.Text))
			{
				strErr+="community_hospital_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_hospital_bed_num.Text))
			{
				strErr+="community_hospital_bed_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_hospital_dis_ots.Text))
			{
				strErr+="community_hospital_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_heal_sta_num.Text))
			{
				strErr+="community_heal_sta_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_heal_sta_fs.Text))
			{
				strErr+="community_heal_sta_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_heal_sta_gfa.Text))
			{
				strErr+="community_heal_sta_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_heal_sta_bed_num.Text))
			{
				strErr+="community_heal_sta_bed_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_heal_sta_dis_ots.Text))
			{
				strErr+="community_heal_sta_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_clinic_num.Text))
			{
				strErr+="community_clinic_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_clinic_fs.Text))
			{
				strErr+="community_clinic_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_clinic_gfa.Text))
			{
				strErr+="community_clinic_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_clinic_bed_num.Text))
			{
				strErr+="community_clinic_bed_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_clinic_dis_ots.Text))
			{
				strErr+="community_clinic_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcmunset1.Text.Trim().Length==0)
			{
				strErr+="tcmunset1不能为空！\\n";	
			}
			if(this.txttcmunset2.Text.Trim().Length==0)
			{
				strErr+="tcmunset2不能为空！\\n";	
			}
			if(this.txttcmunset3.Text.Trim().Length==0)
			{
				strErr+="tcmunset3不能为空！\\n";	
			}
			if(this.txttcmunset4.Text.Trim().Length==0)
			{
				strErr+="tcmunset4不能为空！\\n";	
			}
			if(this.txttcmunset5.Text.Trim().Length==0)
			{
				strErr+="tcmunset5不能为空！\\n";	
			}
			if(this.txttcmunset6.Text.Trim().Length==0)
			{
				strErr+="tcmunset6不能为空！\\n";	
			}
			if(this.txttcmunset7.Text.Trim().Length==0)
			{
				strErr+="tcmunset7不能为空！\\n";	
			}
			if(this.txttcmunset8.Text.Trim().Length==0)
			{
				strErr+="tcmunset8不能为空！\\n";	
			}
			if(this.txttcmunset9.Text.Trim().Length==0)
			{
				strErr+="tcmunset9不能为空！\\n";	
			}
			if(this.txttcmunset10.Text.Trim().Length==0)
			{
				strErr+="tcmunset10不能为空！\\n";	
			}
			if(this.txttcmunset11.Text.Trim().Length==0)
			{
				strErr+="tcmunset11不能为空！\\n";	
			}
			if(this.txttcmunset12.Text.Trim().Length==0)
			{
				strErr+="tcmunset12不能为空！\\n";	
			}
			if(this.txttcmunset13.Text.Trim().Length==0)
			{
				strErr+="tcmunset13不能为空！\\n";	
			}
			if(this.txttcmunset14.Text.Trim().Length==0)
			{
				strErr+="tcmunset14不能为空！\\n";	
			}
			if(this.txttcmunset15.Text.Trim().Length==0)
			{
				strErr+="tcmunset15不能为空！\\n";	
			}
			if(this.txttcmunset16.Text.Trim().Length==0)
			{
				strErr+="tcmunset16不能为空！\\n";	
			}
			if(this.txttcmunset17.Text.Trim().Length==0)
			{
				strErr+="tcmunset17不能为空！\\n";	
			}
			if(this.txttcmunset18.Text.Trim().Length==0)
			{
				strErr+="tcmunset18不能为空！\\n";	
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
			int community_medical_inst_num=int.Parse(this.txtcommunity_medical_inst_num.Text);
			decimal community_medical_inst_fs=decimal.Parse(this.txtcommunity_medical_inst_fs.Text);
			decimal community_medical_inst_gfa=decimal.Parse(this.txtcommunity_medical_inst_gfa.Text);
			int community_hospital_num=int.Parse(this.txtcommunity_hospital_num.Text);
			decimal community_hospital_gfa=decimal.Parse(this.txtcommunity_hospital_gfa.Text);
			decimal community_hospital_fs=decimal.Parse(this.txtcommunity_hospital_fs.Text);
			int community_hospital_bed_num=int.Parse(this.txtcommunity_hospital_bed_num.Text);
			decimal community_hospital_dis_ots=decimal.Parse(this.txtcommunity_hospital_dis_ots.Text);
			int community_heal_sta_num=int.Parse(this.txtcommunity_heal_sta_num.Text);
			decimal community_heal_sta_fs=decimal.Parse(this.txtcommunity_heal_sta_fs.Text);
			decimal community_heal_sta_gfa=decimal.Parse(this.txtcommunity_heal_sta_gfa.Text);
			int community_heal_sta_bed_num=int.Parse(this.txtcommunity_heal_sta_bed_num.Text);
			decimal community_heal_sta_dis_ots=decimal.Parse(this.txtcommunity_heal_sta_dis_ots.Text);
			int community_clinic_num=int.Parse(this.txtcommunity_clinic_num.Text);
			decimal community_clinic_fs=decimal.Parse(this.txtcommunity_clinic_fs.Text);
			decimal community_clinic_gfa=decimal.Parse(this.txtcommunity_clinic_gfa.Text);
			int community_clinic_bed_num=int.Parse(this.txtcommunity_clinic_bed_num.Text);
			decimal community_clinic_dis_ots=decimal.Parse(this.txtcommunity_clinic_dis_ots.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcmunset1=this.txttcmunset1.Text;
			string tcmunset2=this.txttcmunset2.Text;
			string tcmunset3=this.txttcmunset3.Text;
			string tcmunset4=this.txttcmunset4.Text;
			string tcmunset5=this.txttcmunset5.Text;
			string tcmunset6=this.txttcmunset6.Text;
			string tcmunset7=this.txttcmunset7.Text;
			string tcmunset8=this.txttcmunset8.Text;
			string tcmunset9=this.txttcmunset9.Text;
			string tcmunset10=this.txttcmunset10.Text;
			string tcmunset11=this.txttcmunset11.Text;
			string tcmunset12=this.txttcmunset12.Text;
			string tcmunset13=this.txttcmunset13.Text;
			string tcmunset14=this.txttcmunset14.Text;
			string tcmunset15=this.txttcmunset15.Text;
			string tcmunset16=this.txttcmunset16.Text;
			string tcmunset17=this.txttcmunset17.Text;
			string tcmunset18=this.txttcmunset18.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_medical model=new TTG.Model.TTGWeb.community_medical();
			model.community_id=community_id;
			model.community_medical_inst_num=community_medical_inst_num;
			model.community_medical_inst_fs=community_medical_inst_fs;
			model.community_medical_inst_gfa=community_medical_inst_gfa;
			model.community_hospital_num=community_hospital_num;
			model.community_hospital_gfa=community_hospital_gfa;
			model.community_hospital_fs=community_hospital_fs;
			model.community_hospital_bed_num=community_hospital_bed_num;
			model.community_hospital_dis_ots=community_hospital_dis_ots;
			model.community_heal_sta_num=community_heal_sta_num;
			model.community_heal_sta_fs=community_heal_sta_fs;
			model.community_heal_sta_gfa=community_heal_sta_gfa;
			model.community_heal_sta_bed_num=community_heal_sta_bed_num;
			model.community_heal_sta_dis_ots=community_heal_sta_dis_ots;
			model.community_clinic_num=community_clinic_num;
			model.community_clinic_fs=community_clinic_fs;
			model.community_clinic_gfa=community_clinic_gfa;
			model.community_clinic_bed_num=community_clinic_bed_num;
			model.community_clinic_dis_ots=community_clinic_dis_ots;
			model.statistics_date=statistics_date;
			model.tcmunset1=tcmunset1;
			model.tcmunset2=tcmunset2;
			model.tcmunset3=tcmunset3;
			model.tcmunset4=tcmunset4;
			model.tcmunset5=tcmunset5;
			model.tcmunset6=tcmunset6;
			model.tcmunset7=tcmunset7;
			model.tcmunset8=tcmunset8;
			model.tcmunset9=tcmunset9;
			model.tcmunset10=tcmunset10;
			model.tcmunset11=tcmunset11;
			model.tcmunset12=tcmunset12;
			model.tcmunset13=tcmunset13;
			model.tcmunset14=tcmunset14;
			model.tcmunset15=tcmunset15;
			model.tcmunset16=tcmunset16;
			model.tcmunset17=tcmunset17;
			model.tcmunset18=tcmunset18;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_medical bll=new TTG.BLL.TTGWeb.community_medical();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
