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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string community_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					community_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(community_id,statistics_date);
			}
		}
			
	private void ShowInfo(string community_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.community_security bll=new TTG.BLL.TTGWeb.community_security();
		TTG.Model.TTGWeb.community_security model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_unit_can_build_guard_room_num.Text=model.community_unit_can_build_guard_room_num.ToString();
		this.txtcommunity_unit_with_guard_room_num.Text=model.community_unit_with_guard_room_num.ToString();
		this.txtcommunity_unit_can_install_mf_num.Text=model.community_unit_can_install_mf_num.ToString();
		this.txtcommunity_unit_with_mf_num.Text=model.community_unit_with_mf_num.ToString();
		this.txtcommunity_unit_can_build_fence_num.Text=model.community_unit_can_build_fence_num.ToString();
		this.txtcommunity_unit_with_fence_num.Text=model.community_unit_with_fence_num.ToString();
		this.txtcommunity_emergency_shelter_area.Text=model.community_emergency_shelter_area.ToString();
		this.txtcommunity_civil_air_defence_facilities_num.Text=model.community_civil_air_defence_facilities_num.ToString();
		this.txtcommunity_civil_air_defence_facilities_area.Text=model.community_civil_air_defence_facilities_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txtcommunity_unit_can_build_gate_num.Text=model.community_unit_can_build_gate_num.ToString();
		this.txtcommunity_with_gate_num.Text=model.community_with_gate_num.ToString();
		this.txttcsunset1.Text=model.tcsunset1;
		this.txttcsunset2.Text=model.tcsunset2;
		this.txttcsunset3.Text=model.tcsunset3;
		this.txttcsunset4.Text=model.tcsunset4;
		this.txttcsunset5.Text=model.tcsunset5;
		this.txttcsunset6.Text=model.tcsunset6;
		this.txttcsunset7.Text=model.tcsunset7;
		this.txttcsunset8.Text=model.tcsunset8;
		this.txttcsunset9.Text=model.tcsunset9;
		this.txttcsunset10.Text=model.tcsunset10;
		this.txttcsunset11.Text=model.tcsunset11;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			string community_id=this.lblcommunity_id.Text;
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
