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
namespace TTG.Web.TTGWeb.community_shop_front
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
		TTG.BLL.TTGWeb.community_shop_front bll=new TTG.BLL.TTGWeb.community_shop_front();
		TTG.Model.TTGWeb.community_shop_front model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_shop_front_num.Text=model.community_shop_front_num.ToString();
		this.txtcommunity_shop_front_in_main_street_num.Text=model.community_shop_front_in_main_street_num.ToString();
		this.txtcommunity_shop_front_in_collector_street_num.Text=model.community_shop_front_in_collector_street_num.ToString();
		this.txtcommunity_shop_front_in_alley_num.Text=model.community_shop_front_in_alley_num.ToString();
		this.txtcommunity_back_street_shop_front_num.Text=model.community_back_street_shop_front_num.ToString();
		this.txtcommunity_shop_front_area.Text=model.community_shop_front_area.ToString();
		this.txtcommunity_immigrant_shop_front_num.Text=model.community_immigrant_shop_front_num.ToString();
		this.txtcommunity_immigrant_shop_front_area.Text=model.community_immigrant_shop_front_area.ToString();
		this.txtcommunity_immigrant_run_shop_front_num.Text=model.community_immigrant_run_shop_front_num.ToString();
		this.txtcommunity_immigrant_run_shop_front_area.Text=model.community_immigrant_run_shop_front_area.ToString();
		this.txtcommunity_immigrant_rent_out_shop_front_num.Text=model.community_immigrant_rent_out_shop_front_num.ToString();
		this.txtcommunity_immigrant_rent_out_shop_front_area.Text=model.community_immigrant_rent_out_shop_front_area.ToString();
		this.txtcommunity_immigrant_unused_shop_front_num.Text=model.community_immigrant_unused_shop_front_num.ToString();
		this.txtcommunity_immigrant_unused_shop_front_area.Text=model.community_immigrant_unused_shop_front_area.ToString();
		this.txtcommunity_shop_front_amount.Text=model.community_shop_front_amount.ToString();
		this.txtcommunity_catering_shop_front_num.Text=model.community_catering_shop_front_num.ToString();
		this.txtcommunity_accommodation_shop_front_num.Text=model.community_accommodation_shop_front_num.ToString();
		this.txtcommunity_commodity_shop_front_num.Text=model.community_commodity_shop_front_num.ToString();
		this.txtcommunity_means_of_production_shop_front_num.Text=model.community_means_of_production_shop_front_num.ToString();
		this.txtcommunity_automobile_service_shop_front_num.Text=model.community_automobile_service_shop_front_num.ToString();
		this.txtcommunity_other__shop_front_num.Text=model.community_other__shop_front_num.ToString();
		this.txtcommunity_average_rent_of_shop_front.Text=model.community_average_rent_of_shop_front.ToString();
		this.txtcommunity_average_rent_time_of_shop_front.Text=model.community_average_rent_time_of_shop_front;
		this.txtcommunity_average_price_shop_front.Text=model.community_average_price_shop_front.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommunity_shop_front_num.Text))
			{
				strErr+="community_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_shop_front_in_main_street_num.Text))
			{
				strErr+="community_shop_front_in_main_street_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_shop_front_in_collector_street_num.Text))
			{
				strErr+="community_shop_front_in_collector_street_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_shop_front_in_alley_num.Text))
			{
				strErr+="community_shop_front_in_alley_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_back_street_shop_front_num.Text))
			{
				strErr+="community_back_street_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_shop_front_area.Text))
			{
				strErr+="community_shop_front_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_immigrant_shop_front_num.Text))
			{
				strErr+="community_immigrant_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_immigrant_shop_front_area.Text))
			{
				strErr+="community_immigrant_shop_front_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_immigrant_run_shop_front_num.Text))
			{
				strErr+="community_immigrant_run_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_immigrant_run_shop_front_area.Text))
			{
				strErr+="community_immigrant_run_shop_front_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_immigrant_rent_out_shop_front_num.Text))
			{
				strErr+="community_immigrant_rent_out_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_immigrant_rent_out_shop_front_area.Text))
			{
				strErr+="community_immigrant_rent_out_shop_front_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_immigrant_unused_shop_front_num.Text))
			{
				strErr+="community_immigrant_unused_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_immigrant_unused_shop_front_area.Text))
			{
				strErr+="community_immigrant_unused_shop_front_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_shop_front_amount.Text))
			{
				strErr+="community_shop_front_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_catering_shop_front_num.Text))
			{
				strErr+="community_catering_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_accommodation_shop_front_num.Text))
			{
				strErr+="community_accommodation_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_commodity_shop_front_num.Text))
			{
				strErr+="community_commodity_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_means_of_production_shop_front_num.Text))
			{
				strErr+="community_means_of_production_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_automobile_service_shop_front_num.Text))
			{
				strErr+="community_automobile_service_shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_other__shop_front_num.Text))
			{
				strErr+="community_other__shop_front_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_average_rent_of_shop_front.Text))
			{
				strErr+="community_average_rent_of_shop_front格式错误！\\n";	
			}
			if(this.txtcommunity_average_rent_time_of_shop_front.Text.Trim().Length==0)
			{
				strErr+="community_average_rent_time_of_shop_front不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_average_price_shop_front.Text))
			{
				strErr+="community_average_price_shop_front格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			int community_shop_front_num=int.Parse(this.txtcommunity_shop_front_num.Text);
			int community_shop_front_in_main_street_num=int.Parse(this.txtcommunity_shop_front_in_main_street_num.Text);
			int community_shop_front_in_collector_street_num=int.Parse(this.txtcommunity_shop_front_in_collector_street_num.Text);
			int community_shop_front_in_alley_num=int.Parse(this.txtcommunity_shop_front_in_alley_num.Text);
			int community_back_street_shop_front_num=int.Parse(this.txtcommunity_back_street_shop_front_num.Text);
			decimal community_shop_front_area=decimal.Parse(this.txtcommunity_shop_front_area.Text);
			int community_immigrant_shop_front_num=int.Parse(this.txtcommunity_immigrant_shop_front_num.Text);
			decimal community_immigrant_shop_front_area=decimal.Parse(this.txtcommunity_immigrant_shop_front_area.Text);
			int community_immigrant_run_shop_front_num=int.Parse(this.txtcommunity_immigrant_run_shop_front_num.Text);
			decimal community_immigrant_run_shop_front_area=decimal.Parse(this.txtcommunity_immigrant_run_shop_front_area.Text);
			int community_immigrant_rent_out_shop_front_num=int.Parse(this.txtcommunity_immigrant_rent_out_shop_front_num.Text);
			decimal community_immigrant_rent_out_shop_front_area=decimal.Parse(this.txtcommunity_immigrant_rent_out_shop_front_area.Text);
			int community_immigrant_unused_shop_front_num=int.Parse(this.txtcommunity_immigrant_unused_shop_front_num.Text);
			decimal community_immigrant_unused_shop_front_area=decimal.Parse(this.txtcommunity_immigrant_unused_shop_front_area.Text);
			int community_shop_front_amount=int.Parse(this.txtcommunity_shop_front_amount.Text);
			int community_catering_shop_front_num=int.Parse(this.txtcommunity_catering_shop_front_num.Text);
			int community_accommodation_shop_front_num=int.Parse(this.txtcommunity_accommodation_shop_front_num.Text);
			int community_commodity_shop_front_num=int.Parse(this.txtcommunity_commodity_shop_front_num.Text);
			int community_means_of_production_shop_front_num=int.Parse(this.txtcommunity_means_of_production_shop_front_num.Text);
			int community_automobile_service_shop_front_num=int.Parse(this.txtcommunity_automobile_service_shop_front_num.Text);
			int community_other__shop_front_num=int.Parse(this.txtcommunity_other__shop_front_num.Text);
			decimal community_average_rent_of_shop_front=decimal.Parse(this.txtcommunity_average_rent_of_shop_front.Text);
			string community_average_rent_time_of_shop_front=this.txtcommunity_average_rent_time_of_shop_front.Text;
			decimal community_average_price_shop_front=decimal.Parse(this.txtcommunity_average_price_shop_front.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);


			TTG.Model.TTGWeb.community_shop_front model=new TTG.Model.TTGWeb.community_shop_front();
			model.community_id=community_id;
			model.community_shop_front_num=community_shop_front_num;
			model.community_shop_front_in_main_street_num=community_shop_front_in_main_street_num;
			model.community_shop_front_in_collector_street_num=community_shop_front_in_collector_street_num;
			model.community_shop_front_in_alley_num=community_shop_front_in_alley_num;
			model.community_back_street_shop_front_num=community_back_street_shop_front_num;
			model.community_shop_front_area=community_shop_front_area;
			model.community_immigrant_shop_front_num=community_immigrant_shop_front_num;
			model.community_immigrant_shop_front_area=community_immigrant_shop_front_area;
			model.community_immigrant_run_shop_front_num=community_immigrant_run_shop_front_num;
			model.community_immigrant_run_shop_front_area=community_immigrant_run_shop_front_area;
			model.community_immigrant_rent_out_shop_front_num=community_immigrant_rent_out_shop_front_num;
			model.community_immigrant_rent_out_shop_front_area=community_immigrant_rent_out_shop_front_area;
			model.community_immigrant_unused_shop_front_num=community_immigrant_unused_shop_front_num;
			model.community_immigrant_unused_shop_front_area=community_immigrant_unused_shop_front_area;
			model.community_shop_front_amount=community_shop_front_amount;
			model.community_catering_shop_front_num=community_catering_shop_front_num;
			model.community_accommodation_shop_front_num=community_accommodation_shop_front_num;
			model.community_commodity_shop_front_num=community_commodity_shop_front_num;
			model.community_means_of_production_shop_front_num=community_means_of_production_shop_front_num;
			model.community_automobile_service_shop_front_num=community_automobile_service_shop_front_num;
			model.community_other__shop_front_num=community_other__shop_front_num;
			model.community_average_rent_of_shop_front=community_average_rent_of_shop_front;
			model.community_average_rent_time_of_shop_front=community_average_rent_time_of_shop_front;
			model.community_average_price_shop_front=community_average_price_shop_front;
			model.statistics_date=statistics_date;

			TTG.BLL.TTGWeb.community_shop_front bll=new TTG.BLL.TTGWeb.community_shop_front();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
