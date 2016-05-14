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
			string community_id=this.txtcommunity_id.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
