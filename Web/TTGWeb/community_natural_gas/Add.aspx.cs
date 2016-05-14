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
namespace TTG.Web.TTGWeb.community_natural_gas
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
			if(!PageValidate.IsNumber(txtcommunity_gas_regulating_station_num.Text))
			{
				strErr+="community_gas_regulating_station_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_natural_gas_pipe_length.Text))
			{
				strErr+="community_natural_gas_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlow_pressure_natural_gas_pipe_length.Text))
			{
				strErr+="low_pressure_natural_gas_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtmiddle_pressuse_natural_gas_pipe_length.Text))
			{
				strErr+="middle_pressuse_natural_gas_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtintermediate_pressure_natural_gas_pipe_length.Text))
			{
				strErr+="intermediate_pressure_natural_gas_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcngunset1.Text.Trim().Length==0)
			{
				strErr+="tcngunset1不能为空！\\n";	
			}
			if(this.txttcngunset2.Text.Trim().Length==0)
			{
				strErr+="tcngunset2不能为空！\\n";	
			}
			if(this.txttcngunset3.Text.Trim().Length==0)
			{
				strErr+="tcngunset3不能为空！\\n";	
			}
			if(this.txttcngunset4.Text.Trim().Length==0)
			{
				strErr+="tcngunset4不能为空！\\n";	
			}
			if(this.txttcngunset5.Text.Trim().Length==0)
			{
				strErr+="tcngunset5不能为空！\\n";	
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
			int community_gas_regulating_station_num=int.Parse(this.txtcommunity_gas_regulating_station_num.Text);
			decimal community_natural_gas_pipe_length=decimal.Parse(this.txtcommunity_natural_gas_pipe_length.Text);
			decimal low_pressure_natural_gas_pipe_length=decimal.Parse(this.txtlow_pressure_natural_gas_pipe_length.Text);
			decimal middle_pressuse_natural_gas_pipe_length=decimal.Parse(this.txtmiddle_pressuse_natural_gas_pipe_length.Text);
			decimal intermediate_pressure_natural_gas_pipe_length=decimal.Parse(this.txtintermediate_pressure_natural_gas_pipe_length.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcngunset1=this.txttcngunset1.Text;
			string tcngunset2=this.txttcngunset2.Text;
			string tcngunset3=this.txttcngunset3.Text;
			string tcngunset4=this.txttcngunset4.Text;
			string tcngunset5=this.txttcngunset5.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_natural_gas model=new TTG.Model.TTGWeb.community_natural_gas();
			model.community_id=community_id;
			model.community_gas_regulating_station_num=community_gas_regulating_station_num;
			model.community_natural_gas_pipe_length=community_natural_gas_pipe_length;
			model.low_pressure_natural_gas_pipe_length=low_pressure_natural_gas_pipe_length;
			model.middle_pressuse_natural_gas_pipe_length=middle_pressuse_natural_gas_pipe_length;
			model.intermediate_pressure_natural_gas_pipe_length=intermediate_pressure_natural_gas_pipe_length;
			model.statistics_date=statistics_date;
			model.tcngunset1=tcngunset1;
			model.tcngunset2=tcngunset2;
			model.tcngunset3=tcngunset3;
			model.tcngunset4=tcngunset4;
			model.tcngunset5=tcngunset5;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_natural_gas bll=new TTG.BLL.TTGWeb.community_natural_gas();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
