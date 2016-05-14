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
namespace TTG.Web.TTGWeb.community_kindergarten_problem
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
			if(this.txtcommunity_fill_type.Text.Trim().Length==0)
			{
				strErr+="community_fill_type不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_child_not_atts_due_to_insuf_capacity_num.Text))
			{
				strErr+="community_child_not_atts_due_to_insuf_capacity_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_large_class_num.Text))
			{
				strErr+="community_large_class_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_required_ta_by_rc.Text))
			{
				strErr+="community_required_ta_by_rc格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_difference_between_the_actual_ta.Text))
			{
				strErr+="community_difference_between_the_actual_ta格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_required_outground_area_by_rc.Text))
			{
				strErr+="community_required_outground_area_by_rc格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_difference_between_the_actual_outground_area.Text))
			{
				strErr+="community_difference_between_the_actual_outground_area格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
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

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			string community_fill_type=this.txtcommunity_fill_type.Text;
			int community_child_not_atts_due_to_insuf_capacity_num=int.Parse(this.txtcommunity_child_not_atts_due_to_insuf_capacity_num.Text);
			int community_large_class_num=int.Parse(this.txtcommunity_large_class_num.Text);
			decimal community_required_ta_by_rc=decimal.Parse(this.txtcommunity_required_ta_by_rc.Text);
			decimal community_difference_between_the_actual_ta=decimal.Parse(this.txtcommunity_difference_between_the_actual_ta.Text);
			decimal community_required_outground_area_by_rc=decimal.Parse(this.txtcommunity_required_outground_area_by_rc.Text);
			decimal community_difference_between_the_actual_outground_area=decimal.Parse(this.txtcommunity_difference_between_the_actual_outground_area.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			string tciunset5=this.txttciunset5.Text;
			string tciunset6=this.txttciunset6.Text;
			string tciunset7=this.txttciunset7.Text;
			string tciunset8=this.txttciunset8.Text;
			string tciunset9=this.txttciunset9.Text;

			TTG.Model.TTGWeb.community_kindergarten_problem model=new TTG.Model.TTGWeb.community_kindergarten_problem();
			model.community_id=community_id;
			model.community_fill_type=community_fill_type;
			model.community_child_not_atts_due_to_insuf_capacity_num=community_child_not_atts_due_to_insuf_capacity_num;
			model.community_large_class_num=community_large_class_num;
			model.community_required_ta_by_rc=community_required_ta_by_rc;
			model.community_difference_between_the_actual_ta=community_difference_between_the_actual_ta;
			model.community_required_outground_area_by_rc=community_required_outground_area_by_rc;
			model.community_difference_between_the_actual_outground_area=community_difference_between_the_actual_outground_area;
			model.statistics_date=statistics_date;
			model.check_status=check_status;
			model.lock_tables=lock_tables;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.tciunset5=tciunset5;
			model.tciunset6=tciunset6;
			model.tciunset7=tciunset7;
			model.tciunset8=tciunset8;
			model.tciunset9=tciunset9;

			TTG.BLL.TTGWeb.community_kindergarten_problem bll=new TTG.BLL.TTGWeb.community_kindergarten_problem();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
