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
namespace TTG.Web.TTGWeb.community_sanitation_problem
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
			if(!PageValidate.IsNumber(txtcommunity_road_lack_rd_num.Text))
			{
				strErr+="community_road_lack_rd_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_lack_rd_length.Text))
			{
				strErr+="community_road_lack_rd_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_insuf_resd_area.Text))
			{
				strErr+="community_insuf_resd_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_along_rs_garbage_pup_num.Text))
			{
				strErr+="community_along_rs_garbage_pup_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommuniyt_along_rs_garbage_stack_amount.Text))
			{
				strErr+="communiyt_along_rs_garbage_stack_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_bsa_etc_hc_garbage_pup_num.Text))
			{
				strErr+="community_bsa_etc_hc_garbage_pup_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_bsa_etc_hc_garbage_stack_amount.Text))
			{
				strErr+="community_bsa_etc_hc_garbage_stack_amount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_toilet_insuf_pt_area.Text))
			{
				strErr+="community_toilet_insuf_pt_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_regional_insuf_sf_num.Text))
			{
				strErr+="community_regional_insuf_sf_num格式错误！\\n";	
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
			string community_fill_type=this.txtcommunity_fill_type.Text;
			int community_road_lack_rd_num=int.Parse(this.txtcommunity_road_lack_rd_num.Text);
			decimal community_road_lack_rd_length=decimal.Parse(this.txtcommunity_road_lack_rd_length.Text);
			decimal community_insuf_resd_area=decimal.Parse(this.txtcommunity_insuf_resd_area.Text);
			int community_along_rs_garbage_pup_num=int.Parse(this.txtcommunity_along_rs_garbage_pup_num.Text);
			decimal communiyt_along_rs_garbage_stack_amount=decimal.Parse(this.txtcommuniyt_along_rs_garbage_stack_amount.Text);
			int community_bsa_etc_hc_garbage_pup_num=int.Parse(this.txtcommunity_bsa_etc_hc_garbage_pup_num.Text);
			decimal community_bsa_etc_hc_garbage_stack_amount=decimal.Parse(this.txtcommunity_bsa_etc_hc_garbage_stack_amount.Text);
			decimal community_toilet_insuf_pt_area=decimal.Parse(this.txtcommunity_toilet_insuf_pt_area.Text);
			int community_regional_insuf_sf_num=int.Parse(this.txtcommunity_regional_insuf_sf_num.Text);
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

			TTG.Model.TTGWeb.community_sanitation_problem model=new TTG.Model.TTGWeb.community_sanitation_problem();
			model.community_id=community_id;
			model.community_fill_type=community_fill_type;
			model.community_road_lack_rd_num=community_road_lack_rd_num;
			model.community_road_lack_rd_length=community_road_lack_rd_length;
			model.community_insuf_resd_area=community_insuf_resd_area;
			model.community_along_rs_garbage_pup_num=community_along_rs_garbage_pup_num;
			model.communiyt_along_rs_garbage_stack_amount=communiyt_along_rs_garbage_stack_amount;
			model.community_bsa_etc_hc_garbage_pup_num=community_bsa_etc_hc_garbage_pup_num;
			model.community_bsa_etc_hc_garbage_stack_amount=community_bsa_etc_hc_garbage_stack_amount;
			model.community_toilet_insuf_pt_area=community_toilet_insuf_pt_area;
			model.community_regional_insuf_sf_num=community_regional_insuf_sf_num;
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

			TTG.BLL.TTGWeb.community_sanitation_problem bll=new TTG.BLL.TTGWeb.community_sanitation_problem();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
