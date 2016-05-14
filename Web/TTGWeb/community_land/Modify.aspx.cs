﻿using System;
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
namespace TTG.Web.TTGWeb.community_land
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
		TTG.BLL.TTGWeb.community_land bll=new TTG.BLL.TTGWeb.community_land();
		TTG.Model.TTGWeb.community_land model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_total_land_area.Text=model.community_total_land_area.ToString();
		this.txtcommunity_house_land_area.Text=model.community_house_land_area.ToString();
		this.txtcommunity_public_building_land_area.Text=model.community_public_building_land_area.ToString();
		this.txtcommunity_road_land_area.Text=model.community_road_land_area.ToString();
		this.txtcommunity_public_greenland_area.Text=model.community_public_greenland_area.ToString();
		this.txtcommunity_industry_land_area.Text=model.community_industry_land_area.ToString();
		this.txtcommunity_warehousing_land_area.Text=model.community_warehousing_land_area.ToString();
		this.txtcommunity_traffic_land_area.Text=model.community_traffic_land_area.ToString();
		this.txtcommunity_municipal_administration_land_area.Text=model.community_municipal_administration_land_area.ToString();
		this.txtcommunity_other_land_area.Text=model.community_other_land_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttclunset1.Text=model.tclunset1;
		this.txttclunset2.Text=model.tclunset2;
		this.txttclunset3.Text=model.tclunset3;
		this.txttclunset4.Text=model.tclunset4;
		this.txttclunset5.Text=model.tclunset5;
		this.txttclunset6.Text=model.tclunset6;
		this.txttclunset7.Text=model.tclunset7;
		this.txttclunset8.Text=model.tclunset8;
		this.txttclunset9.Text=model.tclunset9;
		this.txttclunset10.Text=model.tclunset10;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtcommunity_total_land_area.Text))
			{
				strErr+="community_total_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_house_land_area.Text))
			{
				strErr+="community_house_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_building_land_area.Text))
			{
				strErr+="community_public_building_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_land_area.Text))
			{
				strErr+="community_road_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_greenland_area.Text))
			{
				strErr+="community_public_greenland_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_industry_land_area.Text))
			{
				strErr+="community_industry_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_warehousing_land_area.Text))
			{
				strErr+="community_warehousing_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_traffic_land_area.Text))
			{
				strErr+="community_traffic_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_municipal_administration_land_area.Text))
			{
				strErr+="community_municipal_administration_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_other_land_area.Text))
			{
				strErr+="community_other_land_area格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttclunset1.Text.Trim().Length==0)
			{
				strErr+="tclunset1不能为空！\\n";	
			}
			if(this.txttclunset2.Text.Trim().Length==0)
			{
				strErr+="tclunset2不能为空！\\n";	
			}
			if(this.txttclunset3.Text.Trim().Length==0)
			{
				strErr+="tclunset3不能为空！\\n";	
			}
			if(this.txttclunset4.Text.Trim().Length==0)
			{
				strErr+="tclunset4不能为空！\\n";	
			}
			if(this.txttclunset5.Text.Trim().Length==0)
			{
				strErr+="tclunset5不能为空！\\n";	
			}
			if(this.txttclunset6.Text.Trim().Length==0)
			{
				strErr+="tclunset6不能为空！\\n";	
			}
			if(this.txttclunset7.Text.Trim().Length==0)
			{
				strErr+="tclunset7不能为空！\\n";	
			}
			if(this.txttclunset8.Text.Trim().Length==0)
			{
				strErr+="tclunset8不能为空！\\n";	
			}
			if(this.txttclunset9.Text.Trim().Length==0)
			{
				strErr+="tclunset9不能为空！\\n";	
			}
			if(this.txttclunset10.Text.Trim().Length==0)
			{
				strErr+="tclunset10不能为空！\\n";	
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
			decimal community_total_land_area=decimal.Parse(this.txtcommunity_total_land_area.Text);
			decimal community_house_land_area=decimal.Parse(this.txtcommunity_house_land_area.Text);
			decimal community_public_building_land_area=decimal.Parse(this.txtcommunity_public_building_land_area.Text);
			decimal community_road_land_area=decimal.Parse(this.txtcommunity_road_land_area.Text);
			decimal community_public_greenland_area=decimal.Parse(this.txtcommunity_public_greenland_area.Text);
			decimal community_industry_land_area=decimal.Parse(this.txtcommunity_industry_land_area.Text);
			decimal community_warehousing_land_area=decimal.Parse(this.txtcommunity_warehousing_land_area.Text);
			decimal community_traffic_land_area=decimal.Parse(this.txtcommunity_traffic_land_area.Text);
			decimal community_municipal_administration_land_area=decimal.Parse(this.txtcommunity_municipal_administration_land_area.Text);
			decimal community_other_land_area=decimal.Parse(this.txtcommunity_other_land_area.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tclunset1=this.txttclunset1.Text;
			string tclunset2=this.txttclunset2.Text;
			string tclunset3=this.txttclunset3.Text;
			string tclunset4=this.txttclunset4.Text;
			string tclunset5=this.txttclunset5.Text;
			string tclunset6=this.txttclunset6.Text;
			string tclunset7=this.txttclunset7.Text;
			string tclunset8=this.txttclunset8.Text;
			string tclunset9=this.txttclunset9.Text;
			string tclunset10=this.txttclunset10.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);


			TTG.Model.TTGWeb.community_land model=new TTG.Model.TTGWeb.community_land();
			model.community_id=community_id;
			model.community_total_land_area=community_total_land_area;
			model.community_house_land_area=community_house_land_area;
			model.community_public_building_land_area=community_public_building_land_area;
			model.community_road_land_area=community_road_land_area;
			model.community_public_greenland_area=community_public_greenland_area;
			model.community_industry_land_area=community_industry_land_area;
			model.community_warehousing_land_area=community_warehousing_land_area;
			model.community_traffic_land_area=community_traffic_land_area;
			model.community_municipal_administration_land_area=community_municipal_administration_land_area;
			model.community_other_land_area=community_other_land_area;
			model.statistics_date=statistics_date;
			model.tclunset1=tclunset1;
			model.tclunset2=tclunset2;
			model.tclunset3=tclunset3;
			model.tclunset4=tclunset4;
			model.tclunset5=tclunset5;
			model.tclunset6=tclunset6;
			model.tclunset7=tclunset7;
			model.tclunset8=tclunset8;
			model.tclunset9=tclunset9;
			model.tclunset10=tclunset10;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_land bll=new TTG.BLL.TTGWeb.community_land();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
