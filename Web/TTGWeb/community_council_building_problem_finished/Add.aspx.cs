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
namespace TTG.Web.TTGWeb.community_council_building_problem_finished
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
			if(!PageValidate.IsNumber(txtcommunity_struc_reinforce_num.Text))
			{
				strErr+="community_struc_reinforce_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_struc_reinforce_area.Text))
			{
				strErr+="community_struc_reinforce_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_demolished_rebuilt_nu.Text))
			{
				strErr+="community_demolished_rebuilt_nu格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_demolished_rebuilt_area.Text))
			{
				strErr+="community_demolished_rebuilt_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_roof_leakproof_num.Text))
			{
				strErr+="community_roof_leakproof_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_roof_leakproof_area.Text))
			{
				strErr+="community_roof_leakproof_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_facades_maintain_num.Text))
			{
				strErr+="community_facades_maintain_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_facades_maintain_area.Text))
			{
				strErr+="community_facades_maintain_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_slope_govern_house_num.Text))
			{
				strErr+="community_slope_govern_house_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_slope_govern_house_area.Text))
			{
				strErr+="community_slope_govern_house_area格式错误！\\n";	
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
			int community_struc_reinforce_num=int.Parse(this.txtcommunity_struc_reinforce_num.Text);
			decimal community_struc_reinforce_area=decimal.Parse(this.txtcommunity_struc_reinforce_area.Text);
			int community_demolished_rebuilt_nu=int.Parse(this.txtcommunity_demolished_rebuilt_nu.Text);
			decimal community_demolished_rebuilt_area=decimal.Parse(this.txtcommunity_demolished_rebuilt_area.Text);
			int community_roof_leakproof_num=int.Parse(this.txtcommunity_roof_leakproof_num.Text);
			decimal community_roof_leakproof_area=decimal.Parse(this.txtcommunity_roof_leakproof_area.Text);
			int community_facades_maintain_num=int.Parse(this.txtcommunity_facades_maintain_num.Text);
			decimal community_facades_maintain_area=decimal.Parse(this.txtcommunity_facades_maintain_area.Text);
			int community_slope_govern_house_num=int.Parse(this.txtcommunity_slope_govern_house_num.Text);
			decimal community_slope_govern_house_area=decimal.Parse(this.txtcommunity_slope_govern_house_area.Text);
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
			int lock_tables=int.Parse(this.txtlock_tables.Text);

			TTG.Model.TTGWeb.community_council_building_problem_finished model=new TTG.Model.TTGWeb.community_council_building_problem_finished();
			model.community_id=community_id;
			model.community_struc_reinforce_num=community_struc_reinforce_num;
			model.community_struc_reinforce_area=community_struc_reinforce_area;
			model.community_demolished_rebuilt_nu=community_demolished_rebuilt_nu;
			model.community_demolished_rebuilt_area=community_demolished_rebuilt_area;
			model.community_roof_leakproof_num=community_roof_leakproof_num;
			model.community_roof_leakproof_area=community_roof_leakproof_area;
			model.community_facades_maintain_num=community_facades_maintain_num;
			model.community_facades_maintain_area=community_facades_maintain_area;
			model.community_slope_govern_house_num=community_slope_govern_house_num;
			model.community_slope_govern_house_area=community_slope_govern_house_area;
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
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.community_council_building_problem_finished bll=new TTG.BLL.TTGWeb.community_council_building_problem_finished();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
