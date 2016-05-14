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
namespace TTG.Web.TTGWeb.community_environmental_hygiene
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
		TTG.BLL.TTGWeb.community_environmental_hygiene bll=new TTG.BLL.TTGWeb.community_environmental_hygiene();
		TTG.Model.TTGWeb.community_environmental_hygiene model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_refuse_transfer_station_num.Text=model.community_refuse_transfer_station_num.ToString();
		this.txtcommunity_refuse_transfer_station_dis_ots.Text=model.community_refuse_transfer_station_dis_ots.ToString();
		this.txtcommunity_refuse_collection_point_num.Text=model.community_refuse_collection_point_num.ToString();
		this.txtcommunity_dustbin_num.Text=model.community_dustbin_num.ToString();
		this.txtrubbish_produce_amount.Text=model.rubbish_produce_amount.ToString();
		this.txtlive_rubbish_produce_year_amount.Text=model.live_rubbish_produce_year_amount.ToString();
		this.txtsolid_rubbish_produce_amount.Text=model.solid_rubbish_produce_amount.ToString();
		this.txtenvironmental_fee_charge_amount.Text=model.environmental_fee_charge_amount.ToString();
		this.txtcommunity_public_toilet_num.Text=model.community_public_toilet_num.ToString();
		this.txtcommunity_public_toilet_space_num.Text=model.community_public_toilet_space_num.ToString();
		this.txtcommunity_public_toilet_inside_300m_num.Text=model.community_public_toilet_inside_300m_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txtcommunity_public_toilet_cover_road_length.Text=model.community_public_toilet_cover_road_length.ToString();
		this.txttcehunset1.Text=model.tcehunset1;
		this.txttcehunset2.Text=model.tcehunset2;
		this.txttcehunset3.Text=model.tcehunset3;
		this.txttcehunset4.Text=model.tcehunset4;
		this.txttcehunset5.Text=model.tcehunset5;
		this.txttcehunset6.Text=model.tcehunset6;
		this.txttcehunset7.Text=model.tcehunset7;
		this.txttcehunset8.Text=model.tcehunset8;
		this.txttcehunset9.Text=model.tcehunset9;
		this.txttcehunset10.Text=model.tcehunset10;
		this.txttcehunset11.Text=model.tcehunset11;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txtcommunity_public_toilet_area_num.Text=model.community_public_toilet_area_num.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommunity_refuse_transfer_station_num.Text))
			{
				strErr+="community_refuse_transfer_station_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_refuse_transfer_station_dis_ots.Text))
			{
				strErr+="community_refuse_transfer_station_dis_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_refuse_collection_point_num.Text))
			{
				strErr+="community_refuse_collection_point_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_dustbin_num.Text))
			{
				strErr+="community_dustbin_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtrubbish_produce_amount.Text))
			{
				strErr+="rubbish_produce_amount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlive_rubbish_produce_year_amount.Text))
			{
				strErr+="live_rubbish_produce_year_amount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsolid_rubbish_produce_amount.Text))
			{
				strErr+="solid_rubbish_produce_amount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtenvironmental_fee_charge_amount.Text))
			{
				strErr+="environmental_fee_charge_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_toilet_num.Text))
			{
				strErr+="community_public_toilet_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_toilet_space_num.Text))
			{
				strErr+="community_public_toilet_space_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_toilet_inside_300m_num.Text))
			{
				strErr+="community_public_toilet_inside_300m_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_toilet_cover_road_length.Text))
			{
				strErr+="community_public_toilet_cover_road_length格式错误！\\n";	
			}
			if(this.txttcehunset1.Text.Trim().Length==0)
			{
				strErr+="tcehunset1不能为空！\\n";	
			}
			if(this.txttcehunset2.Text.Trim().Length==0)
			{
				strErr+="tcehunset2不能为空！\\n";	
			}
			if(this.txttcehunset3.Text.Trim().Length==0)
			{
				strErr+="tcehunset3不能为空！\\n";	
			}
			if(this.txttcehunset4.Text.Trim().Length==0)
			{
				strErr+="tcehunset4不能为空！\\n";	
			}
			if(this.txttcehunset5.Text.Trim().Length==0)
			{
				strErr+="tcehunset5不能为空！\\n";	
			}
			if(this.txttcehunset6.Text.Trim().Length==0)
			{
				strErr+="tcehunset6不能为空！\\n";	
			}
			if(this.txttcehunset7.Text.Trim().Length==0)
			{
				strErr+="tcehunset7不能为空！\\n";	
			}
			if(this.txttcehunset8.Text.Trim().Length==0)
			{
				strErr+="tcehunset8不能为空！\\n";	
			}
			if(this.txttcehunset9.Text.Trim().Length==0)
			{
				strErr+="tcehunset9不能为空！\\n";	
			}
			if(this.txttcehunset10.Text.Trim().Length==0)
			{
				strErr+="tcehunset10不能为空！\\n";	
			}
			if(this.txttcehunset11.Text.Trim().Length==0)
			{
				strErr+="tcehunset11不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_toilet_area_num.Text))
			{
				strErr+="community_public_toilet_area_num格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			int community_refuse_transfer_station_num=int.Parse(this.txtcommunity_refuse_transfer_station_num.Text);
			decimal community_refuse_transfer_station_dis_ots=decimal.Parse(this.txtcommunity_refuse_transfer_station_dis_ots.Text);
			int community_refuse_collection_point_num=int.Parse(this.txtcommunity_refuse_collection_point_num.Text);
			int community_dustbin_num=int.Parse(this.txtcommunity_dustbin_num.Text);
			decimal rubbish_produce_amount=decimal.Parse(this.txtrubbish_produce_amount.Text);
			decimal live_rubbish_produce_year_amount=decimal.Parse(this.txtlive_rubbish_produce_year_amount.Text);
			decimal solid_rubbish_produce_amount=decimal.Parse(this.txtsolid_rubbish_produce_amount.Text);
			decimal environmental_fee_charge_amount=decimal.Parse(this.txtenvironmental_fee_charge_amount.Text);
			int community_public_toilet_num=int.Parse(this.txtcommunity_public_toilet_num.Text);
			int community_public_toilet_space_num=int.Parse(this.txtcommunity_public_toilet_space_num.Text);
			int community_public_toilet_inside_300m_num=int.Parse(this.txtcommunity_public_toilet_inside_300m_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			decimal community_public_toilet_cover_road_length=decimal.Parse(this.txtcommunity_public_toilet_cover_road_length.Text);
			string tcehunset1=this.txttcehunset1.Text;
			string tcehunset2=this.txttcehunset2.Text;
			string tcehunset3=this.txttcehunset3.Text;
			string tcehunset4=this.txttcehunset4.Text;
			string tcehunset5=this.txttcehunset5.Text;
			string tcehunset6=this.txttcehunset6.Text;
			string tcehunset7=this.txttcehunset7.Text;
			string tcehunset8=this.txttcehunset8.Text;
			string tcehunset9=this.txttcehunset9.Text;
			string tcehunset10=this.txttcehunset10.Text;
			string tcehunset11=this.txttcehunset11.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			decimal community_public_toilet_area_num=decimal.Parse(this.txtcommunity_public_toilet_area_num.Text);


			TTG.Model.TTGWeb.community_environmental_hygiene model=new TTG.Model.TTGWeb.community_environmental_hygiene();
			model.community_id=community_id;
			model.community_refuse_transfer_station_num=community_refuse_transfer_station_num;
			model.community_refuse_transfer_station_dis_ots=community_refuse_transfer_station_dis_ots;
			model.community_refuse_collection_point_num=community_refuse_collection_point_num;
			model.community_dustbin_num=community_dustbin_num;
			model.rubbish_produce_amount=rubbish_produce_amount;
			model.live_rubbish_produce_year_amount=live_rubbish_produce_year_amount;
			model.solid_rubbish_produce_amount=solid_rubbish_produce_amount;
			model.environmental_fee_charge_amount=environmental_fee_charge_amount;
			model.community_public_toilet_num=community_public_toilet_num;
			model.community_public_toilet_space_num=community_public_toilet_space_num;
			model.community_public_toilet_inside_300m_num=community_public_toilet_inside_300m_num;
			model.statistics_date=statistics_date;
			model.community_public_toilet_cover_road_length=community_public_toilet_cover_road_length;
			model.tcehunset1=tcehunset1;
			model.tcehunset2=tcehunset2;
			model.tcehunset3=tcehunset3;
			model.tcehunset4=tcehunset4;
			model.tcehunset5=tcehunset5;
			model.tcehunset6=tcehunset6;
			model.tcehunset7=tcehunset7;
			model.tcehunset8=tcehunset8;
			model.tcehunset9=tcehunset9;
			model.tcehunset10=tcehunset10;
			model.tcehunset11=tcehunset11;
			model.lock_tables=lock_tables;
			model.check_status=check_status;
			model.community_public_toilet_area_num=community_public_toilet_area_num;

			TTG.BLL.TTGWeb.community_environmental_hygiene bll=new TTG.BLL.TTGWeb.community_environmental_hygiene();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
