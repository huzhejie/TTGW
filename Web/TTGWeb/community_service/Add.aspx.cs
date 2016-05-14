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
namespace TTG.Web.TTGWeb.community_service
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
			if(!PageValidate.IsDecimal(txtcommunity_comm_serv_fac_fs.Text))
			{
				strErr+="community_comm_serv_fac_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_comm_serv_fac_gfa.Text))
			{
				strErr+="community_comm_serv_fac_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_comm_serv_cen_fs.Text))
			{
				strErr+="community_comm_serv_cen_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_comm_serv_cen_gfa.Text))
			{
				strErr+="community_comm_serv_cen_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_comm_serv_cen_dis_ots.Text))
			{
				strErr+="community_comm_serv_cen_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_empm_supt_cen_fs.Text))
			{
				strErr+="community_empm_supt_cen_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_empm_supt_cen_gfa.Text))
			{
				strErr+="community_empm_supt_cen_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_empm_supt_cen_dis_ots.Text))
			{
				strErr+="community_empm_supt_cen_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_police_sta_fs.Text))
			{
				strErr+="community_police_sta_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_police_sta_gfa.Text))
			{
				strErr+="community_police_sta_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_police_sta_dis_ots.Text))
			{
				strErr+="community_police_sta_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_prop_magm_unit_num.Text))
			{
				strErr+="community_prop_magm_unit_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_no_prop_magm_unit_num.Text))
			{
				strErr+="community_no_prop_magm_unit_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcsrunset1.Text.Trim().Length==0)
			{
				strErr+="tcsrunset1不能为空！\\n";	
			}
			if(this.txttcsrunset2.Text.Trim().Length==0)
			{
				strErr+="tcsrunset2不能为空！\\n";	
			}
			if(this.txttcsrunset3.Text.Trim().Length==0)
			{
				strErr+="tcsrunset3不能为空！\\n";	
			}
			if(this.txttcsrunset4.Text.Trim().Length==0)
			{
				strErr+="tcsrunset4不能为空！\\n";	
			}
			if(this.txttcsrunset5.Text.Trim().Length==0)
			{
				strErr+="tcsrunset5不能为空！\\n";	
			}
			if(this.txttcsrunset6.Text.Trim().Length==0)
			{
				strErr+="tcsrunset6不能为空！\\n";	
			}
			if(this.txttcsrunset7.Text.Trim().Length==0)
			{
				strErr+="tcsrunset7不能为空！\\n";	
			}
			if(this.txttcsrunset8.Text.Trim().Length==0)
			{
				strErr+="tcsrunset8不能为空！\\n";	
			}
			if(this.txttcsrunset9.Text.Trim().Length==0)
			{
				strErr+="tcsrunset9不能为空！\\n";	
			}
			if(this.txttcsrunset10.Text.Trim().Length==0)
			{
				strErr+="tcsrunset10不能为空！\\n";	
			}
			if(this.txttcsrunset11.Text.Trim().Length==0)
			{
				strErr+="tcsrunset11不能为空！\\n";	
			}
			if(this.txttcsrunset12.Text.Trim().Length==0)
			{
				strErr+="tcsrunset12不能为空！\\n";	
			}
			if(this.txttcsrunset13.Text.Trim().Length==0)
			{
				strErr+="tcsrunset13不能为空！\\n";	
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
			decimal community_comm_serv_fac_fs=decimal.Parse(this.txtcommunity_comm_serv_fac_fs.Text);
			decimal community_comm_serv_fac_gfa=decimal.Parse(this.txtcommunity_comm_serv_fac_gfa.Text);
			decimal community_comm_serv_cen_fs=decimal.Parse(this.txtcommunity_comm_serv_cen_fs.Text);
			decimal community_comm_serv_cen_gfa=decimal.Parse(this.txtcommunity_comm_serv_cen_gfa.Text);
			decimal community_comm_serv_cen_dis_ots=decimal.Parse(this.txtcommunity_comm_serv_cen_dis_ots.Text);
			decimal community_empm_supt_cen_fs=decimal.Parse(this.txtcommunity_empm_supt_cen_fs.Text);
			decimal community_empm_supt_cen_gfa=decimal.Parse(this.txtcommunity_empm_supt_cen_gfa.Text);
			decimal community_empm_supt_cen_dis_ots=decimal.Parse(this.txtcommunity_empm_supt_cen_dis_ots.Text);
			decimal community_police_sta_fs=decimal.Parse(this.txtcommunity_police_sta_fs.Text);
			decimal community_police_sta_gfa=decimal.Parse(this.txtcommunity_police_sta_gfa.Text);
			decimal community_police_sta_dis_ots=decimal.Parse(this.txtcommunity_police_sta_dis_ots.Text);
			int community_prop_magm_unit_num=int.Parse(this.txtcommunity_prop_magm_unit_num.Text);
			int community_no_prop_magm_unit_num=int.Parse(this.txtcommunity_no_prop_magm_unit_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcsrunset1=this.txttcsrunset1.Text;
			string tcsrunset2=this.txttcsrunset2.Text;
			string tcsrunset3=this.txttcsrunset3.Text;
			string tcsrunset4=this.txttcsrunset4.Text;
			string tcsrunset5=this.txttcsrunset5.Text;
			string tcsrunset6=this.txttcsrunset6.Text;
			string tcsrunset7=this.txttcsrunset7.Text;
			string tcsrunset8=this.txttcsrunset8.Text;
			string tcsrunset9=this.txttcsrunset9.Text;
			string tcsrunset10=this.txttcsrunset10.Text;
			string tcsrunset11=this.txttcsrunset11.Text;
			string tcsrunset12=this.txttcsrunset12.Text;
			string tcsrunset13=this.txttcsrunset13.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_service model=new TTG.Model.TTGWeb.community_service();
			model.community_id=community_id;
			model.community_comm_serv_fac_fs=community_comm_serv_fac_fs;
			model.community_comm_serv_fac_gfa=community_comm_serv_fac_gfa;
			model.community_comm_serv_cen_fs=community_comm_serv_cen_fs;
			model.community_comm_serv_cen_gfa=community_comm_serv_cen_gfa;
			model.community_comm_serv_cen_dis_ots=community_comm_serv_cen_dis_ots;
			model.community_empm_supt_cen_fs=community_empm_supt_cen_fs;
			model.community_empm_supt_cen_gfa=community_empm_supt_cen_gfa;
			model.community_empm_supt_cen_dis_ots=community_empm_supt_cen_dis_ots;
			model.community_police_sta_fs=community_police_sta_fs;
			model.community_police_sta_gfa=community_police_sta_gfa;
			model.community_police_sta_dis_ots=community_police_sta_dis_ots;
			model.community_prop_magm_unit_num=community_prop_magm_unit_num;
			model.community_no_prop_magm_unit_num=community_no_prop_magm_unit_num;
			model.statistics_date=statistics_date;
			model.tcsrunset1=tcsrunset1;
			model.tcsrunset2=tcsrunset2;
			model.tcsrunset3=tcsrunset3;
			model.tcsrunset4=tcsrunset4;
			model.tcsrunset5=tcsrunset5;
			model.tcsrunset6=tcsrunset6;
			model.tcsrunset7=tcsrunset7;
			model.tcsrunset8=tcsrunset8;
			model.tcsrunset9=tcsrunset9;
			model.tcsrunset10=tcsrunset10;
			model.tcsrunset11=tcsrunset11;
			model.tcsrunset12=tcsrunset12;
			model.tcsrunset13=tcsrunset13;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_service bll=new TTG.BLL.TTGWeb.community_service();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
