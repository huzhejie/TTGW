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
namespace TTG.Web.TTGWeb.community_water_supply_problem_finished
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
			if(!PageValidate.IsDecimal(txtcommunity_added_water_supply_capa.Text))
			{
				strErr+="community_added_water_supply_capa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_water_supply_pre_facility.Text))
			{
				strErr+="community_added_water_supply_pre_facility格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_water_meter_install_hou_num.Text))
			{
				strErr+="community_water_meter_install_hou_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_maintain_reform_water_pipe_len.Text))
			{
				strErr+="community_maintain_reform_water_pipe_len格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_added_water_supply_pipe_len.Text))
			{
				strErr+="community_added_water_supply_pipe_len格式错误！\\n";	
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
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_added_water_supply_pipe_len_f_update.Text))
			{
				strErr+="community_added_water_supply_pipe_len_f_update格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_water_supply_pre_facility_f_update.Text))
			{
				strErr+="community_added_water_supply_pre_facility_f_update格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_added_water_supply_capa_f_update.Text))
			{
				strErr+="community_added_water_supply_capa_f_update格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			decimal community_added_water_supply_capa=decimal.Parse(this.txtcommunity_added_water_supply_capa.Text);
			int community_added_water_supply_pre_facility=int.Parse(this.txtcommunity_added_water_supply_pre_facility.Text);
			int community_water_meter_install_hou_num=int.Parse(this.txtcommunity_water_meter_install_hou_num.Text);
			decimal community_maintain_reform_water_pipe_len=decimal.Parse(this.txtcommunity_maintain_reform_water_pipe_len.Text);
			decimal community_added_water_supply_pipe_len=decimal.Parse(this.txtcommunity_added_water_supply_pipe_len.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			string tciunset5=this.txttciunset5.Text;
			string tciunset6=this.txttciunset6.Text;
			string tciunset7=this.txttciunset7.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			decimal community_added_water_supply_pipe_len_f_update=decimal.Parse(this.txtcommunity_added_water_supply_pipe_len_f_update.Text);
			int community_added_water_supply_pre_facility_f_update=int.Parse(this.txtcommunity_added_water_supply_pre_facility_f_update.Text);
			decimal community_added_water_supply_capa_f_update=decimal.Parse(this.txtcommunity_added_water_supply_capa_f_update.Text);

			TTG.Model.TTGWeb.community_water_supply_problem_finished model=new TTG.Model.TTGWeb.community_water_supply_problem_finished();
			model.community_id=community_id;
			model.community_added_water_supply_capa=community_added_water_supply_capa;
			model.community_added_water_supply_pre_facility=community_added_water_supply_pre_facility;
			model.community_water_meter_install_hou_num=community_water_meter_install_hou_num;
			model.community_maintain_reform_water_pipe_len=community_maintain_reform_water_pipe_len;
			model.community_added_water_supply_pipe_len=community_added_water_supply_pipe_len;
			model.statistics_date=statistics_date;
			model.check_status=check_status;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.tciunset5=tciunset5;
			model.tciunset6=tciunset6;
			model.tciunset7=tciunset7;
			model.lock_tables=lock_tables;
			model.community_added_water_supply_pipe_len_f_update=community_added_water_supply_pipe_len_f_update;
			model.community_added_water_supply_pre_facility_f_update=community_added_water_supply_pre_facility_f_update;
			model.community_added_water_supply_capa_f_update=community_added_water_supply_capa_f_update;

			TTG.BLL.TTGWeb.community_water_supply_problem_finished bll=new TTG.BLL.TTGWeb.community_water_supply_problem_finished();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
