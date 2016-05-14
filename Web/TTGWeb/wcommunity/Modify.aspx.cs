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
namespace TTG.Web.TTGWeb.wcommunity
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string wcommunity_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					wcommunity_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(wcommunity_id,statistics_date);
			}
		}
			
	private void ShowInfo(string wcommunity_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.wcommunity bll=new TTG.BLL.TTGWeb.wcommunity();
		TTG.Model.TTGWeb.wcommunity model=bll.GetModel(wcommunity_id,statistics_date);
		this.lblwcommunity_id.Text=model.wcommunity_id;
		this.txtwcommunity_name.Text=model.wcommunity_name;
		this.txtkindergarten_capacity.Text=model.kindergarten_capacity.ToString();
		this.txtintegrated_management_building_area.Text=model.integrated_management_building_area.ToString();
		this.txtmedical_bed_num.Text=model.medical_bed_num.ToString();
		this.txtparking_space_num.Text=model.parking_space_num.ToString();
		this.txtconvenience_stores_area.Text=model.convenience_stores_area.ToString();
		this.txtvegetable_market_area.Text=model.vegetable_market_area.ToString();
		this.txtculture_fitness_facility_area.Text=model.culture_fitness_facility_area.ToString();
		this.txtfacilities_for_elders_area.Text=model.facilities_for_elders_area.ToString();
		this.txttwunset1.Text=model.twunset1;
		this.txttwunset2.Text=model.twunset2;
		this.txttwunset3.Text=model.twunset3;
		this.txttwunset4.Text=model.twunset4;
		this.txttwunset5.Text=model.twunset5;
		this.txttwunset6.Text=model.twunset6;
		this.txttwunset7.Text=model.twunset7;
		this.txttwunset8.Text=model.twunset8;
		this.txttwunset9.Text=model.twunset9;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txtwcommunity_family_num.Text=model.wcommunity_family_num.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtwcommunity_name.Text.Trim().Length==0)
			{
				strErr+="wcommunity_name不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtkindergarten_capacity.Text))
			{
				strErr+="kindergarten_capacity格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtintegrated_management_building_area.Text))
			{
				strErr+="integrated_management_building_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtmedical_bed_num.Text))
			{
				strErr+="medical_bed_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtparking_space_num.Text))
			{
				strErr+="parking_space_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtconvenience_stores_area.Text))
			{
				strErr+="convenience_stores_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtvegetable_market_area.Text))
			{
				strErr+="vegetable_market_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtculture_fitness_facility_area.Text))
			{
				strErr+="culture_fitness_facility_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtfacilities_for_elders_area.Text))
			{
				strErr+="facilities_for_elders_area格式错误！\\n";	
			}
			if(this.txttwunset1.Text.Trim().Length==0)
			{
				strErr+="twunset1不能为空！\\n";	
			}
			if(this.txttwunset2.Text.Trim().Length==0)
			{
				strErr+="twunset2不能为空！\\n";	
			}
			if(this.txttwunset3.Text.Trim().Length==0)
			{
				strErr+="twunset3不能为空！\\n";	
			}
			if(this.txttwunset4.Text.Trim().Length==0)
			{
				strErr+="twunset4不能为空！\\n";	
			}
			if(this.txttwunset5.Text.Trim().Length==0)
			{
				strErr+="twunset5不能为空！\\n";	
			}
			if(this.txttwunset6.Text.Trim().Length==0)
			{
				strErr+="twunset6不能为空！\\n";	
			}
			if(this.txttwunset7.Text.Trim().Length==0)
			{
				strErr+="twunset7不能为空！\\n";	
			}
			if(this.txttwunset8.Text.Trim().Length==0)
			{
				strErr+="twunset8不能为空！\\n";	
			}
			if(this.txttwunset9.Text.Trim().Length==0)
			{
				strErr+="twunset9不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtwcommunity_family_num.Text))
			{
				strErr+="wcommunity_family_num格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string wcommunity_id=this.lblwcommunity_id.Text;
			string wcommunity_name=this.txtwcommunity_name.Text;
			decimal kindergarten_capacity=decimal.Parse(this.txtkindergarten_capacity.Text);
			decimal integrated_management_building_area=decimal.Parse(this.txtintegrated_management_building_area.Text);
			int medical_bed_num=int.Parse(this.txtmedical_bed_num.Text);
			int parking_space_num=int.Parse(this.txtparking_space_num.Text);
			decimal convenience_stores_area=decimal.Parse(this.txtconvenience_stores_area.Text);
			decimal vegetable_market_area=decimal.Parse(this.txtvegetable_market_area.Text);
			decimal culture_fitness_facility_area=decimal.Parse(this.txtculture_fitness_facility_area.Text);
			decimal facilities_for_elders_area=decimal.Parse(this.txtfacilities_for_elders_area.Text);
			string twunset1=this.txttwunset1.Text;
			string twunset2=this.txttwunset2.Text;
			string twunset3=this.txttwunset3.Text;
			string twunset4=this.txttwunset4.Text;
			string twunset5=this.txttwunset5.Text;
			string twunset6=this.txttwunset6.Text;
			string twunset7=this.txttwunset7.Text;
			string twunset8=this.txttwunset8.Text;
			string twunset9=this.txttwunset9.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int wcommunity_family_num=int.Parse(this.txtwcommunity_family_num.Text);


			TTG.Model.TTGWeb.wcommunity model=new TTG.Model.TTGWeb.wcommunity();
			model.wcommunity_id=wcommunity_id;
			model.wcommunity_name=wcommunity_name;
			model.kindergarten_capacity=kindergarten_capacity;
			model.integrated_management_building_area=integrated_management_building_area;
			model.medical_bed_num=medical_bed_num;
			model.parking_space_num=parking_space_num;
			model.convenience_stores_area=convenience_stores_area;
			model.vegetable_market_area=vegetable_market_area;
			model.culture_fitness_facility_area=culture_fitness_facility_area;
			model.facilities_for_elders_area=facilities_for_elders_area;
			model.twunset1=twunset1;
			model.twunset2=twunset2;
			model.twunset3=twunset3;
			model.twunset4=twunset4;
			model.twunset5=twunset5;
			model.twunset6=twunset6;
			model.twunset7=twunset7;
			model.twunset8=twunset8;
			model.twunset9=twunset9;
			model.lock_tables=lock_tables;
			model.check_status=check_status;
			model.statistics_date=statistics_date;
			model.wcommunity_family_num=wcommunity_family_num;

			TTG.BLL.TTGWeb.wcommunity bll=new TTG.BLL.TTGWeb.wcommunity();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
