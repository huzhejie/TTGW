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
namespace TTG.Web.TTGWeb.community_security
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
			if(!PageValidate.IsNumber(txtcommunity_unit_can_build_guard_room_num.Text))
			{
				strErr+="community_unit_can_build_guard_room_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_unit_with_guard_room_num.Text))
			{
				strErr+="community_unit_with_guard_room_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_unit_can_install_mf_num.Text))
			{
				strErr+="community_unit_can_install_mf_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_unit_with_mf_num.Text))
			{
				strErr+="community_unit_with_mf_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_unit_can_build_fence_num.Text))
			{
				strErr+="community_unit_can_build_fence_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_unit_with_fence_num.Text))
			{
				strErr+="community_unit_with_fence_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_emergency_shelter_area.Text))
			{
				strErr+="community_emergency_shelter_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_civil_air_defence_facilities_num.Text))
			{
				strErr+="community_civil_air_defence_facilities_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_civil_air_defence_facilities_area.Text))
			{
				strErr+="community_civil_air_defence_facilities_area格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_unit_can_build_gate_num.Text))
			{
				strErr+="community_unit_can_build_gate_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_with_gate_num.Text))
			{
				strErr+="community_with_gate_num格式错误！\\n";	
			}
			if(this.txttcsunset1.Text.Trim().Length==0)
			{
				strErr+="tcsunset1不能为空！\\n";	
			}
			if(this.txttcsunset2.Text.Trim().Length==0)
			{
				strErr+="tcsunset2不能为空！\\n";	
			}
			if(this.txttcsunset3.Text.Trim().Length==0)
			{
				strErr+="tcsunset3不能为空！\\n";	
			}
			if(this.txttcsunset4.Text.Trim().Length==0)
			{
				strErr+="tcsunset4不能为空！\\n";	
			}
			if(this.txttcsunset5.Text.Trim().Length==0)
			{
				strErr+="tcsunset5不能为空！\\n";	
			}
			if(this.txttcsunset6.Text.Trim().Length==0)
			{
				strErr+="tcsunset6不能为空！\\n";	
			}
			if(this.txttcsunset7.Text.Trim().Length==0)
			{
				strErr+="tcsunset7不能为空！\\n";	
			}
			if(this.txttcsunset8.Text.Trim().Length==0)
			{
				strErr+="tcsunset8不能为空！\\n";	
			}
			if(this.txttcsunset9.Text.Trim().Length==0)
			{
				strErr+="tcsunset9不能为空！\\n";	
			}
			if(this.txttcsunset10.Text.Trim().Length==0)
			{
				strErr+="tcsunset10不能为空！\\n";	
			}
			if(this.txttcsunset11.Text.Trim().Length==0)
			{
				strErr+="tcsunset11不能为空！\\n";	
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
			int community_unit_can_build_guard_room_num=int.Parse(this.txtcommunity_unit_can_build_guard_room_num.Text);
			int community_unit_with_guard_room_num=int.Parse(this.txtcommunity_unit_with_guard_room_num.Text);
			int community_unit_can_install_mf_num=int.Parse(this.txtcommunity_unit_can_install_mf_num.Text);
			int community_unit_with_mf_num=int.Parse(this.txtcommunity_unit_with_mf_num.Text);
			int community_unit_can_build_fence_num=int.Parse(this.txtcommunity_unit_can_build_fence_num.Text);
			int community_unit_with_fence_num=int.Parse(this.txtcommunity_unit_with_fence_num.Text);
			decimal community_emergency_shelter_area=decimal.Parse(this.txtcommunity_emergency_shelter_area.Text);
			int community_civil_air_defence_facilities_num=int.Parse(this.txtcommunity_civil_air_defence_facilities_num.Text);
			decimal community_civil_air_defence_facilities_area=decimal.Parse(this.txtcommunity_civil_air_defence_facilities_area.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int community_unit_can_build_gate_num=int.Parse(this.txtcommunity_unit_can_build_gate_num.Text);
			int community_with_gate_num=int.Parse(this.txtcommunity_with_gate_num.Text);
			string tcsunset1=this.txttcsunset1.Text;
			string tcsunset2=this.txttcsunset2.Text;
			string tcsunset3=this.txttcsunset3.Text;
			string tcsunset4=this.txttcsunset4.Text;
			string tcsunset5=this.txttcsunset5.Text;
			string tcsunset6=this.txttcsunset6.Text;
			string tcsunset7=this.txttcsunset7.Text;
			string tcsunset8=this.txttcsunset8.Text;
			string tcsunset9=this.txttcsunset9.Text;
			string tcsunset10=this.txttcsunset10.Text;
			string tcsunset11=this.txttcsunset11.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_security model=new TTG.Model.TTGWeb.community_security();
			model.community_id=community_id;
			model.community_unit_can_build_guard_room_num=community_unit_can_build_guard_room_num;
			model.community_unit_with_guard_room_num=community_unit_with_guard_room_num;
			model.community_unit_can_install_mf_num=community_unit_can_install_mf_num;
			model.community_unit_with_mf_num=community_unit_with_mf_num;
			model.community_unit_can_build_fence_num=community_unit_can_build_fence_num;
			model.community_unit_with_fence_num=community_unit_with_fence_num;
			model.community_emergency_shelter_area=community_emergency_shelter_area;
			model.community_civil_air_defence_facilities_num=community_civil_air_defence_facilities_num;
			model.community_civil_air_defence_facilities_area=community_civil_air_defence_facilities_area;
			model.statistics_date=statistics_date;
			model.community_unit_can_build_gate_num=community_unit_can_build_gate_num;
			model.community_with_gate_num=community_with_gate_num;
			model.tcsunset1=tcsunset1;
			model.tcsunset2=tcsunset2;
			model.tcsunset3=tcsunset3;
			model.tcsunset4=tcsunset4;
			model.tcsunset5=tcsunset5;
			model.tcsunset6=tcsunset6;
			model.tcsunset7=tcsunset7;
			model.tcsunset8=tcsunset8;
			model.tcsunset9=tcsunset9;
			model.tcsunset10=tcsunset10;
			model.tcsunset11=tcsunset11;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_security bll=new TTG.BLL.TTGWeb.community_security();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
