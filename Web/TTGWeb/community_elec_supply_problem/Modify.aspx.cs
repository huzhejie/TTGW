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
namespace TTG.Web.TTGWeb.community_elec_supply_problem
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
				string community_fill_type = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					community_fill_type= Request.Params["id1"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id2"] != null && Request.Params["id2"].Trim() != "")
				{
					statistics_date= Request.Params["id2"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(community_id,community_fill_type,statistics_date);
			}
		}
			
	private void ShowInfo(string community_id,string community_fill_type,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.community_elec_supply_problem bll=new TTG.BLL.TTGWeb.community_elec_supply_problem();
		TTG.Model.TTGWeb.community_elec_supply_problem model=bll.GetModel(community_id,community_fill_type,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_fill_type.Text=model.community_fill_type;
		this.txtcommunity_transformer_cap_ins_buil_num.Text=model.community_transformer_cap_ins_buil_num.ToString();
		this.txtcommunity_transformer_cap_ins_hou_num.Text=model.community_transformer_cap_ins_hou_num.ToString();
		this.txtcommunity_senescent_elec_wireways_num.Text=model.community_senescent_elec_wireways_num.ToString();
		this.txtcommunity_senescent_elec_wireways_length.Text=model.community_senescent_elec_wireways_length.ToString();
		this.txtcommunity_no_one_hou_one_meter_buil_num.Text=model.community_no_one_hou_one_meter_buil_num.ToString();
		this.txtcommunity_no_one_hou_one_meter_hou_num.Text=model.community_no_one_hou_one_meter_hou_num.ToString();
		this.txtcommunity_unsafe_transformer_num.Text=model.community_unsafe_transformer_num.ToString();
		this.txtcommunity_elec_net_insuf.Text=model.community_elec_net_insuf;
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
		this.txtlock_tables.Text=model.lock_tables.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommunity_transformer_cap_ins_buil_num.Text))
			{
				strErr+="community_transformer_cap_ins_buil_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_transformer_cap_ins_hou_num.Text))
			{
				strErr+="community_transformer_cap_ins_hou_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_senescent_elec_wireways_num.Text))
			{
				strErr+="community_senescent_elec_wireways_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_senescent_elec_wireways_length.Text))
			{
				strErr+="community_senescent_elec_wireways_length格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_no_one_hou_one_meter_buil_num.Text))
			{
				strErr+="community_no_one_hou_one_meter_buil_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_no_one_hou_one_meter_hou_num.Text))
			{
				strErr+="community_no_one_hou_one_meter_hou_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_unsafe_transformer_num.Text))
			{
				strErr+="community_unsafe_transformer_num格式错误！\\n";	
			}
			if(this.txtcommunity_elec_net_insuf.Text.Trim().Length==0)
			{
				strErr+="community_elec_net_insuf不能为空！\\n";	
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
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			string community_fill_type=this.lblcommunity_fill_type.Text;
			int community_transformer_cap_ins_buil_num=int.Parse(this.txtcommunity_transformer_cap_ins_buil_num.Text);
			int community_transformer_cap_ins_hou_num=int.Parse(this.txtcommunity_transformer_cap_ins_hou_num.Text);
			int community_senescent_elec_wireways_num=int.Parse(this.txtcommunity_senescent_elec_wireways_num.Text);
			decimal community_senescent_elec_wireways_length=decimal.Parse(this.txtcommunity_senescent_elec_wireways_length.Text);
			int community_no_one_hou_one_meter_buil_num=int.Parse(this.txtcommunity_no_one_hou_one_meter_buil_num.Text);
			int community_no_one_hou_one_meter_hou_num=int.Parse(this.txtcommunity_no_one_hou_one_meter_hou_num.Text);
			int community_unsafe_transformer_num=int.Parse(this.txtcommunity_unsafe_transformer_num.Text);
			string community_elec_net_insuf=this.txtcommunity_elec_net_insuf.Text;
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
			int lock_tables=int.Parse(this.txtlock_tables.Text);


			TTG.Model.TTGWeb.community_elec_supply_problem model=new TTG.Model.TTGWeb.community_elec_supply_problem();
			model.community_id=community_id;
			model.community_fill_type=community_fill_type;
			model.community_transformer_cap_ins_buil_num=community_transformer_cap_ins_buil_num;
			model.community_transformer_cap_ins_hou_num=community_transformer_cap_ins_hou_num;
			model.community_senescent_elec_wireways_num=community_senescent_elec_wireways_num;
			model.community_senescent_elec_wireways_length=community_senescent_elec_wireways_length;
			model.community_no_one_hou_one_meter_buil_num=community_no_one_hou_one_meter_buil_num;
			model.community_no_one_hou_one_meter_hou_num=community_no_one_hou_one_meter_hou_num;
			model.community_unsafe_transformer_num=community_unsafe_transformer_num;
			model.community_elec_net_insuf=community_elec_net_insuf;
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
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.community_elec_supply_problem bll=new TTG.BLL.TTGWeb.community_elec_supply_problem();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
