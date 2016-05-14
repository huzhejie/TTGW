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
namespace TTG.Web.TTGWeb.community_water_supply
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
		TTG.BLL.TTGWeb.community_water_supply bll=new TTG.BLL.TTGWeb.community_water_supply();
		TTG.Model.TTGWeb.community_water_supply model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_water_supply_pipe_length.Text=model.community_water_supply_pipe_length.ToString();
		this.txtcommunity_water_supply_main_pipe_length.Text=model.community_water_supply_main_pipe_length.ToString();
		this.txtcommunity_water_supply_pipe_branch_length.Text=model.community_water_supply_pipe_branch_length.ToString();
		this.txtcommunity_water_supply_service_pipe_length.Text=model.community_water_supply_service_pipe_length.ToString();
		this.txtcommunity_water_supply_consumption.Text=model.community_water_supply_consumption.ToString();
		this.txtcommunity_per_capita_water_supply_consumption.Text=model.community_per_capita_water_supply_consumption.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttcwsunset1.Text=model.tcwsunset1;
		this.txttcwsunset2.Text=model.tcwsunset2;
		this.txttcwsunset3.Text=model.tcwsunset3;
		this.txttcwsunset4.Text=model.tcwsunset4;
		this.txttcwsunset5.Text=model.tcwsunset5;
		this.txttcwsunset6.Text=model.tcwsunset6;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtcommunity_water_supply_pipe_length.Text))
			{
				strErr+="community_water_supply_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_supply_main_pipe_length.Text))
			{
				strErr+="community_water_supply_main_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_supply_pipe_branch_length.Text))
			{
				strErr+="community_water_supply_pipe_branch_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_supply_service_pipe_length.Text))
			{
				strErr+="community_water_supply_service_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_water_supply_consumption.Text))
			{
				strErr+="community_water_supply_consumption格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_per_capita_water_supply_consumption.Text))
			{
				strErr+="community_per_capita_water_supply_consumption格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcwsunset1.Text.Trim().Length==0)
			{
				strErr+="tcwsunset1不能为空！\\n";	
			}
			if(this.txttcwsunset2.Text.Trim().Length==0)
			{
				strErr+="tcwsunset2不能为空！\\n";	
			}
			if(this.txttcwsunset3.Text.Trim().Length==0)
			{
				strErr+="tcwsunset3不能为空！\\n";	
			}
			if(this.txttcwsunset4.Text.Trim().Length==0)
			{
				strErr+="tcwsunset4不能为空！\\n";	
			}
			if(this.txttcwsunset5.Text.Trim().Length==0)
			{
				strErr+="tcwsunset5不能为空！\\n";	
			}
			if(this.txttcwsunset6.Text.Trim().Length==0)
			{
				strErr+="tcwsunset6不能为空！\\n";	
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
			decimal community_water_supply_pipe_length=decimal.Parse(this.txtcommunity_water_supply_pipe_length.Text);
			decimal community_water_supply_main_pipe_length=decimal.Parse(this.txtcommunity_water_supply_main_pipe_length.Text);
			decimal community_water_supply_pipe_branch_length=decimal.Parse(this.txtcommunity_water_supply_pipe_branch_length.Text);
			decimal community_water_supply_service_pipe_length=decimal.Parse(this.txtcommunity_water_supply_service_pipe_length.Text);
			decimal community_water_supply_consumption=decimal.Parse(this.txtcommunity_water_supply_consumption.Text);
			decimal community_per_capita_water_supply_consumption=decimal.Parse(this.txtcommunity_per_capita_water_supply_consumption.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcwsunset1=this.txttcwsunset1.Text;
			string tcwsunset2=this.txttcwsunset2.Text;
			string tcwsunset3=this.txttcwsunset3.Text;
			string tcwsunset4=this.txttcwsunset4.Text;
			string tcwsunset5=this.txttcwsunset5.Text;
			string tcwsunset6=this.txttcwsunset6.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);


			TTG.Model.TTGWeb.community_water_supply model=new TTG.Model.TTGWeb.community_water_supply();
			model.community_id=community_id;
			model.community_water_supply_pipe_length=community_water_supply_pipe_length;
			model.community_water_supply_main_pipe_length=community_water_supply_main_pipe_length;
			model.community_water_supply_pipe_branch_length=community_water_supply_pipe_branch_length;
			model.community_water_supply_service_pipe_length=community_water_supply_service_pipe_length;
			model.community_water_supply_consumption=community_water_supply_consumption;
			model.community_per_capita_water_supply_consumption=community_per_capita_water_supply_consumption;
			model.statistics_date=statistics_date;
			model.tcwsunset1=tcwsunset1;
			model.tcwsunset2=tcwsunset2;
			model.tcwsunset3=tcwsunset3;
			model.tcwsunset4=tcwsunset4;
			model.tcwsunset5=tcwsunset5;
			model.tcwsunset6=tcwsunset6;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_water_supply bll=new TTG.BLL.TTGWeb.community_water_supply();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
