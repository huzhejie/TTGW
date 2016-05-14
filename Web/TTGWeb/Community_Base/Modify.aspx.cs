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
namespace TTG.Web.TTGWeb.Community_Base
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
		TTG.BLL.TTGWeb.Community_Base bll=new TTG.BLL.TTGWeb.Community_Base();
		TTG.Model.TTGWeb.Community_Base model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_name.Text=model.community_name;
		this.txtcommunity_location.Text=model.community_location;
		this.txtcommunity_county.Text=model.community_county;
		this.txtcommunity_type.Text=model.community_type;
		this.txtcommunity_feature.Text=model.community_feature;
		this.txtcommunity_function_area.Text=model.community_function_area;
		this.txtcommunity_function_type.Text=model.community_function_type;
		this.txtdistance_to_county.Text=model.distance_to_county.ToString();
		this.txtdistance_to_street_committees.Text=model.distance_to_street_committees.ToString();
		this.txtdistance_to_main_business_area.Text=model.distance_to_main_business_area.ToString();
		this.txtdistance_to_main_education_area.Text=model.distance_to_main_education_area.ToString();
		this.txtdistance_to_railway_station.Text=model.distance_to_railway_station.ToString();
		this.txtdistance_to_coach_station.Text=model.distance_to_coach_station.ToString();
		this.txtdistance_to_passenger_quay.Text=model.distance_to_passenger_quay.ToString();
		this.txtdistance_to_main_street.Text=model.distance_to_main_street.ToString();
		this.txtdistance_to_collector_street.Text=model.distance_to_collector_street.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttbcunset1.Text=model.tbcunset1;
		this.txttbcunset2.Text=model.tbcunset2;
		this.txttbcunset3.Text=model.tbcunset3;
		this.txttbcunset4.Text=model.tbcunset4;
		this.txttbcunset5.Text=model.tbcunset5;
		this.txttbcunset6.Text=model.tbcunset6;
		this.txttbcunset7.Text=model.tbcunset7;
		this.txttbcunset8.Text=model.tbcunset8;
		this.txttbcunset9.Text=model.tbcunset9;
		this.txttbcunset10.Text=model.tbcunset10;
		this.txttbcunset11.Text=model.tbcunset11;
		this.txttbcunset12.Text=model.tbcunset12;
		this.txttbcunset13.Text=model.tbcunset13;
		this.txttbcunset14.Text=model.tbcunset14;
		this.txttbcunset15.Text=model.tbcunset15;
		this.txttbcunset16.Text=model.tbcunset16;
		this.txttbcunset17.Text=model.tbcunset17;
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcommunity_wcommunity.Text=model.community_wcommunity;
		this.txtcommunity_category.Text=model.community_category;
		this.txtcommunity_construct_year.Text=model.community_construct_year.ToString();
		this.txtcommunity_province.Text=model.community_province;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcommunity_name.Text.Trim().Length==0)
			{
				strErr+="community_name不能为空！\\n";	
			}
			if(this.txtcommunity_location.Text.Trim().Length==0)
			{
				strErr+="community_location不能为空！\\n";	
			}
			if(this.txtcommunity_county.Text.Trim().Length==0)
			{
				strErr+="community_county不能为空！\\n";	
			}
			if(this.txtcommunity_type.Text.Trim().Length==0)
			{
				strErr+="community_type不能为空！\\n";	
			}
			if(this.txtcommunity_feature.Text.Trim().Length==0)
			{
				strErr+="community_feature不能为空！\\n";	
			}
			if(this.txtcommunity_function_area.Text.Trim().Length==0)
			{
				strErr+="community_function_area不能为空！\\n";	
			}
			if(this.txtcommunity_function_type.Text.Trim().Length==0)
			{
				strErr+="community_function_type不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_county.Text))
			{
				strErr+="distance_to_county格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_street_committees.Text))
			{
				strErr+="distance_to_street_committees格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_main_business_area.Text))
			{
				strErr+="distance_to_main_business_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_main_education_area.Text))
			{
				strErr+="distance_to_main_education_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_railway_station.Text))
			{
				strErr+="distance_to_railway_station格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_coach_station.Text))
			{
				strErr+="distance_to_coach_station格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_passenger_quay.Text))
			{
				strErr+="distance_to_passenger_quay格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_main_street.Text))
			{
				strErr+="distance_to_main_street格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_collector_street.Text))
			{
				strErr+="distance_to_collector_street格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttbcunset1.Text.Trim().Length==0)
			{
				strErr+="tbcunset1不能为空！\\n";	
			}
			if(this.txttbcunset2.Text.Trim().Length==0)
			{
				strErr+="tbcunset2不能为空！\\n";	
			}
			if(this.txttbcunset3.Text.Trim().Length==0)
			{
				strErr+="tbcunset3不能为空！\\n";	
			}
			if(this.txttbcunset4.Text.Trim().Length==0)
			{
				strErr+="tbcunset4不能为空！\\n";	
			}
			if(this.txttbcunset5.Text.Trim().Length==0)
			{
				strErr+="tbcunset5不能为空！\\n";	
			}
			if(this.txttbcunset6.Text.Trim().Length==0)
			{
				strErr+="tbcunset6不能为空！\\n";	
			}
			if(this.txttbcunset7.Text.Trim().Length==0)
			{
				strErr+="tbcunset7不能为空！\\n";	
			}
			if(this.txttbcunset8.Text.Trim().Length==0)
			{
				strErr+="tbcunset8不能为空！\\n";	
			}
			if(this.txttbcunset9.Text.Trim().Length==0)
			{
				strErr+="tbcunset9不能为空！\\n";	
			}
			if(this.txttbcunset10.Text.Trim().Length==0)
			{
				strErr+="tbcunset10不能为空！\\n";	
			}
			if(this.txttbcunset11.Text.Trim().Length==0)
			{
				strErr+="tbcunset11不能为空！\\n";	
			}
			if(this.txttbcunset12.Text.Trim().Length==0)
			{
				strErr+="tbcunset12不能为空！\\n";	
			}
			if(this.txttbcunset13.Text.Trim().Length==0)
			{
				strErr+="tbcunset13不能为空！\\n";	
			}
			if(this.txttbcunset14.Text.Trim().Length==0)
			{
				strErr+="tbcunset14不能为空！\\n";	
			}
			if(this.txttbcunset15.Text.Trim().Length==0)
			{
				strErr+="tbcunset15不能为空！\\n";	
			}
			if(this.txttbcunset16.Text.Trim().Length==0)
			{
				strErr+="tbcunset16不能为空！\\n";	
			}
			if(this.txttbcunset17.Text.Trim().Length==0)
			{
				strErr+="tbcunset17不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(this.txtcommunity_wcommunity.Text.Trim().Length==0)
			{
				strErr+="community_wcommunity不能为空！\\n";	
			}
			if(this.txtcommunity_category.Text.Trim().Length==0)
			{
				strErr+="community_category不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_construct_year.Text))
			{
				strErr+="community_construct_year格式错误！\\n";	
			}
			if(this.txtcommunity_province.Text.Trim().Length==0)
			{
				strErr+="community_province不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			string community_name=this.txtcommunity_name.Text;
			string community_location=this.txtcommunity_location.Text;
			string community_county=this.txtcommunity_county.Text;
			string community_type=this.txtcommunity_type.Text;
			string community_feature=this.txtcommunity_feature.Text;
			string community_function_area=this.txtcommunity_function_area.Text;
			string community_function_type=this.txtcommunity_function_type.Text;
			decimal distance_to_county=decimal.Parse(this.txtdistance_to_county.Text);
			decimal distance_to_street_committees=decimal.Parse(this.txtdistance_to_street_committees.Text);
			decimal distance_to_main_business_area=decimal.Parse(this.txtdistance_to_main_business_area.Text);
			decimal distance_to_main_education_area=decimal.Parse(this.txtdistance_to_main_education_area.Text);
			decimal distance_to_railway_station=decimal.Parse(this.txtdistance_to_railway_station.Text);
			decimal distance_to_coach_station=decimal.Parse(this.txtdistance_to_coach_station.Text);
			decimal distance_to_passenger_quay=decimal.Parse(this.txtdistance_to_passenger_quay.Text);
			decimal distance_to_main_street=decimal.Parse(this.txtdistance_to_main_street.Text);
			decimal distance_to_collector_street=decimal.Parse(this.txtdistance_to_collector_street.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tbcunset1=this.txttbcunset1.Text;
			string tbcunset2=this.txttbcunset2.Text;
			string tbcunset3=this.txttbcunset3.Text;
			string tbcunset4=this.txttbcunset4.Text;
			string tbcunset5=this.txttbcunset5.Text;
			string tbcunset6=this.txttbcunset6.Text;
			string tbcunset7=this.txttbcunset7.Text;
			string tbcunset8=this.txttbcunset8.Text;
			string tbcunset9=this.txttbcunset9.Text;
			string tbcunset10=this.txttbcunset10.Text;
			string tbcunset11=this.txttbcunset11.Text;
			string tbcunset12=this.txttbcunset12.Text;
			string tbcunset13=this.txttbcunset13.Text;
			string tbcunset14=this.txttbcunset14.Text;
			string tbcunset15=this.txttbcunset15.Text;
			string tbcunset16=this.txttbcunset16.Text;
			string tbcunset17=this.txttbcunset17.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			string community_wcommunity=this.txtcommunity_wcommunity.Text;
			string community_category=this.txtcommunity_category.Text;
			int community_construct_year=int.Parse(this.txtcommunity_construct_year.Text);
			string community_province=this.txtcommunity_province.Text;


			TTG.Model.TTGWeb.Community_Base model=new TTG.Model.TTGWeb.Community_Base();
			model.community_id=community_id;
			model.community_name=community_name;
			model.community_location=community_location;
			model.community_county=community_county;
			model.community_type=community_type;
			model.community_feature=community_feature;
			model.community_function_area=community_function_area;
			model.community_function_type=community_function_type;
			model.distance_to_county=distance_to_county;
			model.distance_to_street_committees=distance_to_street_committees;
			model.distance_to_main_business_area=distance_to_main_business_area;
			model.distance_to_main_education_area=distance_to_main_education_area;
			model.distance_to_railway_station=distance_to_railway_station;
			model.distance_to_coach_station=distance_to_coach_station;
			model.distance_to_passenger_quay=distance_to_passenger_quay;
			model.distance_to_main_street=distance_to_main_street;
			model.distance_to_collector_street=distance_to_collector_street;
			model.statistics_date=statistics_date;
			model.tbcunset1=tbcunset1;
			model.tbcunset2=tbcunset2;
			model.tbcunset3=tbcunset3;
			model.tbcunset4=tbcunset4;
			model.tbcunset5=tbcunset5;
			model.tbcunset6=tbcunset6;
			model.tbcunset7=tbcunset7;
			model.tbcunset8=tbcunset8;
			model.tbcunset9=tbcunset9;
			model.tbcunset10=tbcunset10;
			model.tbcunset11=tbcunset11;
			model.tbcunset12=tbcunset12;
			model.tbcunset13=tbcunset13;
			model.tbcunset14=tbcunset14;
			model.tbcunset15=tbcunset15;
			model.tbcunset16=tbcunset16;
			model.tbcunset17=tbcunset17;
			model.check_status=check_status;
			model.lock_tables=lock_tables;
			model.community_wcommunity=community_wcommunity;
			model.community_category=community_category;
			model.community_construct_year=community_construct_year;
			model.community_province=community_province;

			TTG.BLL.TTGWeb.Community_Base bll=new TTG.BLL.TTGWeb.Community_Base();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
