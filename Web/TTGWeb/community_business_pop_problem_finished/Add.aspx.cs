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
namespace TTG.Web.TTGWeb.community_business_pop_problem_finished
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
			if(!PageValidate.IsDecimal(txtcommunity_recon_block_len.Text))
			{
				strErr+="community_recon_block_len格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_recon_shop_front_num.Text))
			{
				strErr+="community_recon_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_recon_shop_front_area.Text))
			{
				strErr+="community_recon_shop_front_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_market_merchants_num.Text))
			{
				strErr+="community_added_market_merchants_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_market_area.Text))
			{
				strErr+="community_market_area格式错误！\\n";	
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

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			decimal community_recon_block_len=decimal.Parse(this.txtcommunity_recon_block_len.Text);
			int community_recon_shop_front_num=int.Parse(this.txtcommunity_recon_shop_front_num.Text);
			decimal community_recon_shop_front_area=decimal.Parse(this.txtcommunity_recon_shop_front_area.Text);
			int community_added_market_merchants_num=int.Parse(this.txtcommunity_added_market_merchants_num.Text);
			decimal community_market_area=decimal.Parse(this.txtcommunity_market_area.Text);
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

			TTG.Model.TTGWeb.community_business_pop_problem_finished model=new TTG.Model.TTGWeb.community_business_pop_problem_finished();
			model.community_id=community_id;
			model.community_recon_block_len=community_recon_block_len;
			model.community_recon_shop_front_num=community_recon_shop_front_num;
			model.community_recon_shop_front_area=community_recon_shop_front_area;
			model.community_added_market_merchants_num=community_added_market_merchants_num;
			model.community_market_area=community_market_area;
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

			TTG.BLL.TTGWeb.community_business_pop_problem_finished bll=new TTG.BLL.TTGWeb.community_business_pop_problem_finished();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
