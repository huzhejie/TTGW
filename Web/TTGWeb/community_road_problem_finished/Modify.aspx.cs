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
namespace TTG.Web.TTGWeb.community_road_problem_finished
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
		TTG.BLL.TTGWeb.community_road_problem_finished bll=new TTG.BLL.TTGWeb.community_road_problem_finished();
		TTG.Model.TTGWeb.community_road_problem_finished model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_road_hardening_area.Text=model.community_road_hardening_area.ToString();
		this.txtcommunity_road_maintain_reform_num.Text=model.community_road_maintain_reform_num.ToString();
		this.txtcommunity_road_maintain_reform_len.Text=model.community_road_maintain_reform_len.ToString();
		this.txtcommunity_road_maintain_reform_area.Text=model.community_road_maintain_reform_area.ToString();
		this.txtcommunity_pavement_colorful_brick_len.Text=model.community_pavement_colorful_brick_len.ToString();
		this.txtcommunity_pavement_colorful_brick_area.Text=model.community_pavement_colorful_brick_area.ToString();
		this.txtcommunity_added_road_num.Text=model.community_added_road_num.ToString();
		this.txtcommunity_added_road_area.Text=model.community_added_road_area.ToString();
		this.txtcommunity_road_maintain_reform_num_ots.Text=model.community_road_maintain_reform_num_ots.ToString();
		this.txtcommunity_road_maintain_reform_len_ots.Text=model.community_road_maintain_reform_len_ots.ToString();
		this.txtcommunity_road_maintain_reform_area_ots.Text=model.community_road_maintain_reform_area_ots.ToString();
		this.txtcommunity_added_vehicles_road_num.Text=model.community_added_vehicles_road_num.ToString();
		this.txtcommunity_added_vehicles_road_area.Text=model.community_added_vehicles_road_area.ToString();
		this.txtcommunity_white_change_black_road_num.Text=model.community_white_change_black_road_num.ToString();
		this.txtcommunity_white_change_black_road_area.Text=model.community_white_change_black_road_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txttciunset1.Text=model.tciunset1;
		this.txttciunset2.Text=model.tciunset2;
		this.txttciunset3.Text=model.tciunset3;
		this.txttciunset4.Text=model.tciunset4;
		this.txttciunset5.Text=model.tciunset5;
		this.txttciunset6.Text=model.tciunset6;
		this.txttciunset7.Text=model.tciunset7;
		this.txttciunset8.Text=model.tciunset8;
		this.txttciunset9.Text=model.tciunset9;
		this.txttciunset10.Text=model.tciunset10;
		this.txttciunset11.Text=model.tciunset11;
		this.txttciunset12.Text=model.tciunset12;
		this.txttciunset13.Text=model.tciunset13;
		this.txttciunset14.Text=model.tciunset14;
		this.txttciunset15.Text=model.tciunset15;
		this.txttciunset16.Text=model.tciunset16;
		this.txttciunset17.Text=model.tciunset17;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcommunity_added_road_num_for_update.Text=model.community_added_road_num_for_update.ToString();
		this.txtcommunity_added_road_area_for_update.Text=model.community_added_road_area_for_update.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtcommunity_road_hardening_area.Text))
			{
				strErr+="community_road_hardening_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_road_maintain_reform_num.Text))
			{
				strErr+="community_road_maintain_reform_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_maintain_reform_len.Text))
			{
				strErr+="community_road_maintain_reform_len格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_maintain_reform_area.Text))
			{
				strErr+="community_road_maintain_reform_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pavement_colorful_brick_len.Text))
			{
				strErr+="community_pavement_colorful_brick_len格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pavement_colorful_brick_area.Text))
			{
				strErr+="community_pavement_colorful_brick_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_road_num.Text))
			{
				strErr+="community_added_road_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_added_road_area.Text))
			{
				strErr+="community_added_road_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_maintain_reform_num_ots.Text))
			{
				strErr+="community_road_maintain_reform_num_ots格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_maintain_reform_len_ots.Text))
			{
				strErr+="community_road_maintain_reform_len_ots格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_maintain_reform_area_ots.Text))
			{
				strErr+="community_road_maintain_reform_area_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_vehicles_road_num.Text))
			{
				strErr+="community_added_vehicles_road_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_added_vehicles_road_area.Text))
			{
				strErr+="community_added_vehicles_road_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_white_change_black_road_num.Text))
			{
				strErr+="community_white_change_black_road_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_white_change_black_road_area.Text))
			{
				strErr+="community_white_change_black_road_area格式错误！\\n";	
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
			if(this.txttciunset13.Text.Trim().Length==0)
			{
				strErr+="tciunset13不能为空！\\n";	
			}
			if(this.txttciunset14.Text.Trim().Length==0)
			{
				strErr+="tciunset14不能为空！\\n";	
			}
			if(this.txttciunset15.Text.Trim().Length==0)
			{
				strErr+="tciunset15不能为空！\\n";	
			}
			if(this.txttciunset16.Text.Trim().Length==0)
			{
				strErr+="tciunset16不能为空！\\n";	
			}
			if(this.txttciunset17.Text.Trim().Length==0)
			{
				strErr+="tciunset17不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_road_num_for_update.Text))
			{
				strErr+="community_added_road_num_for_update格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_added_road_area_for_update.Text))
			{
				strErr+="community_added_road_area_for_update格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			decimal community_road_hardening_area=decimal.Parse(this.txtcommunity_road_hardening_area.Text);
			int community_road_maintain_reform_num=int.Parse(this.txtcommunity_road_maintain_reform_num.Text);
			decimal community_road_maintain_reform_len=decimal.Parse(this.txtcommunity_road_maintain_reform_len.Text);
			decimal community_road_maintain_reform_area=decimal.Parse(this.txtcommunity_road_maintain_reform_area.Text);
			decimal community_pavement_colorful_brick_len=decimal.Parse(this.txtcommunity_pavement_colorful_brick_len.Text);
			decimal community_pavement_colorful_brick_area=decimal.Parse(this.txtcommunity_pavement_colorful_brick_area.Text);
			int community_added_road_num=int.Parse(this.txtcommunity_added_road_num.Text);
			decimal community_added_road_area=decimal.Parse(this.txtcommunity_added_road_area.Text);
			decimal community_road_maintain_reform_num_ots=decimal.Parse(this.txtcommunity_road_maintain_reform_num_ots.Text);
			decimal community_road_maintain_reform_len_ots=decimal.Parse(this.txtcommunity_road_maintain_reform_len_ots.Text);
			decimal community_road_maintain_reform_area_ots=decimal.Parse(this.txtcommunity_road_maintain_reform_area_ots.Text);
			int community_added_vehicles_road_num=int.Parse(this.txtcommunity_added_vehicles_road_num.Text);
			decimal community_added_vehicles_road_area=decimal.Parse(this.txtcommunity_added_vehicles_road_area.Text);
			int community_white_change_black_road_num=int.Parse(this.txtcommunity_white_change_black_road_num.Text);
			decimal community_white_change_black_road_area=decimal.Parse(this.txtcommunity_white_change_black_road_area.Text);
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
			string tciunset13=this.txttciunset13.Text;
			string tciunset14=this.txttciunset14.Text;
			string tciunset15=this.txttciunset15.Text;
			string tciunset16=this.txttciunset16.Text;
			string tciunset17=this.txttciunset17.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int community_added_road_num_for_update=int.Parse(this.txtcommunity_added_road_num_for_update.Text);
			decimal community_added_road_area_for_update=decimal.Parse(this.txtcommunity_added_road_area_for_update.Text);


			TTG.Model.TTGWeb.community_road_problem_finished model=new TTG.Model.TTGWeb.community_road_problem_finished();
			model.community_id=community_id;
			model.community_road_hardening_area=community_road_hardening_area;
			model.community_road_maintain_reform_num=community_road_maintain_reform_num;
			model.community_road_maintain_reform_len=community_road_maintain_reform_len;
			model.community_road_maintain_reform_area=community_road_maintain_reform_area;
			model.community_pavement_colorful_brick_len=community_pavement_colorful_brick_len;
			model.community_pavement_colorful_brick_area=community_pavement_colorful_brick_area;
			model.community_added_road_num=community_added_road_num;
			model.community_added_road_area=community_added_road_area;
			model.community_road_maintain_reform_num_ots=community_road_maintain_reform_num_ots;
			model.community_road_maintain_reform_len_ots=community_road_maintain_reform_len_ots;
			model.community_road_maintain_reform_area_ots=community_road_maintain_reform_area_ots;
			model.community_added_vehicles_road_num=community_added_vehicles_road_num;
			model.community_added_vehicles_road_area=community_added_vehicles_road_area;
			model.community_white_change_black_road_num=community_white_change_black_road_num;
			model.community_white_change_black_road_area=community_white_change_black_road_area;
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
			model.tciunset13=tciunset13;
			model.tciunset14=tciunset14;
			model.tciunset15=tciunset15;
			model.tciunset16=tciunset16;
			model.tciunset17=tciunset17;
			model.lock_tables=lock_tables;
			model.community_added_road_num_for_update=community_added_road_num_for_update;
			model.community_added_road_area_for_update=community_added_road_area_for_update;

			TTG.BLL.TTGWeb.community_road_problem_finished bll=new TTG.BLL.TTGWeb.community_road_problem_finished();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
