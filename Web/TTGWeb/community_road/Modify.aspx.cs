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
namespace TTG.Web.TTGWeb.community_road
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
		TTG.BLL.TTGWeb.community_road bll=new TTG.BLL.TTGWeb.community_road();
		TTG.Model.TTGWeb.community_road model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_road_length.Text=model.community_road_length.ToString();
		this.txtcommunity_road_area.Text=model.community_road_area.ToString();
		this.txtcommunity_road_width_bet_14_and_24_length.Text=model.community_road_width_bet_14_and_24_length.ToString();
		this.txtcommunity_road_width_bet_14_and_24_area.Text=model.community_road_width_bet_14_and_24_area.ToString();
		this.txtcommunity_road_width_bet_10_and_14_length.Text=model.community_road_width_bet_10_and_14_length.ToString();
		this.txtcommunity_road_width_bet_10_and_14_area.Text=model.community_road_width_bet_10_and_14_area.ToString();
		this.txtcommunity_road_width_bet_6_and_9_length.Text=model.community_road_width_bet_6_and_9_length.ToString();
		this.txtcommunity_road_width_bet_6_and_9_area.Text=model.community_road_width_bet_6_and_9_area.ToString();
		this.txtcommunity_road_width_bet_3_and_5_length.Text=model.community_road_width_bet_3_and_5_length.ToString();
		this.txtcommunity_road_width_bet_3_and_5_area.Text=model.community_road_width_bet_3_and_5_area.ToString();
		this.txtcommunity_road_pavement_area.Text=model.community_road_pavement_area.ToString();
		this.txtcommunity_road_pavement_colorful_brick_area.Text=model.community_road_pavement_colorful_brick_area.ToString();
		this.txtcommunity_road_bet_dwellings_length.Text=model.community_road_bet_dwellings_length.ToString();
		this.txtcommunity_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length.Text=model.community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length.ToString();
		this.txtcommunity_pavement_length.Text=model.community_pavement_length.ToString();
		this.txtcommunity_pavement_area.Text=model.community_pavement_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txtcommunity_road_num.Text=model.community_road_num.ToString();
		this.txttcrunset1.Text=model.tcrunset1;
		this.txttcrunset2.Text=model.tcrunset2;
		this.txttcrunset3.Text=model.tcrunset3;
		this.txttcrunset4.Text=model.tcrunset4;
		this.txttcrunset5.Text=model.tcrunset5;
		this.txttcrunset6.Text=model.tcrunset6;
		this.txttcrunset7.Text=model.tcrunset7;
		this.txttcrunset8.Text=model.tcrunset8;
		this.txttcrunset9.Text=model.tcrunset9;
		this.txttcrunset10.Text=model.tcrunset10;
		this.txttcrunset11.Text=model.tcrunset11;
		this.txttcrunset12.Text=model.tcrunset12;
		this.txttcrunset13.Text=model.tcrunset13;
		this.txttcrunset14.Text=model.tcrunset14;
		this.txttcrunset15.Text=model.tcrunset15;
		this.txttcrunset16.Text=model.tcrunset16;
		this.txttcrunset17.Text=model.tcrunset17;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtcommunity_road_length.Text))
			{
				strErr+="community_road_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_area.Text))
			{
				strErr+="community_road_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_width_bet_14_and_24_length.Text))
			{
				strErr+="community_road_width_bet_14_and_24_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_width_bet_14_and_24_area.Text))
			{
				strErr+="community_road_width_bet_14_and_24_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_width_bet_10_and_14_length.Text))
			{
				strErr+="community_road_width_bet_10_and_14_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_width_bet_10_and_14_area.Text))
			{
				strErr+="community_road_width_bet_10_and_14_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_width_bet_6_and_9_length.Text))
			{
				strErr+="community_road_width_bet_6_and_9_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_width_bet_6_and_9_area.Text))
			{
				strErr+="community_road_width_bet_6_and_9_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_width_bet_3_and_5_length.Text))
			{
				strErr+="community_road_width_bet_3_and_5_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_width_bet_3_and_5_area.Text))
			{
				strErr+="community_road_width_bet_3_and_5_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_pavement_area.Text))
			{
				strErr+="community_road_pavement_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_pavement_colorful_brick_area.Text))
			{
				strErr+="community_road_pavement_colorful_brick_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_bet_dwellings_length.Text))
			{
				strErr+="community_road_bet_dwellings_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length.Text))
			{
				strErr+="community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pavement_length.Text))
			{
				strErr+="community_pavement_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_pavement_area.Text))
			{
				strErr+="community_pavement_area格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_road_num.Text))
			{
				strErr+="community_road_num格式错误！\\n";	
			}
			if(this.txttcrunset1.Text.Trim().Length==0)
			{
				strErr+="tcrunset1不能为空！\\n";	
			}
			if(this.txttcrunset2.Text.Trim().Length==0)
			{
				strErr+="tcrunset2不能为空！\\n";	
			}
			if(this.txttcrunset3.Text.Trim().Length==0)
			{
				strErr+="tcrunset3不能为空！\\n";	
			}
			if(this.txttcrunset4.Text.Trim().Length==0)
			{
				strErr+="tcrunset4不能为空！\\n";	
			}
			if(this.txttcrunset5.Text.Trim().Length==0)
			{
				strErr+="tcrunset5不能为空！\\n";	
			}
			if(this.txttcrunset6.Text.Trim().Length==0)
			{
				strErr+="tcrunset6不能为空！\\n";	
			}
			if(this.txttcrunset7.Text.Trim().Length==0)
			{
				strErr+="tcrunset7不能为空！\\n";	
			}
			if(this.txttcrunset8.Text.Trim().Length==0)
			{
				strErr+="tcrunset8不能为空！\\n";	
			}
			if(this.txttcrunset9.Text.Trim().Length==0)
			{
				strErr+="tcrunset9不能为空！\\n";	
			}
			if(this.txttcrunset10.Text.Trim().Length==0)
			{
				strErr+="tcrunset10不能为空！\\n";	
			}
			if(this.txttcrunset11.Text.Trim().Length==0)
			{
				strErr+="tcrunset11不能为空！\\n";	
			}
			if(this.txttcrunset12.Text.Trim().Length==0)
			{
				strErr+="tcrunset12不能为空！\\n";	
			}
			if(this.txttcrunset13.Text.Trim().Length==0)
			{
				strErr+="tcrunset13不能为空！\\n";	
			}
			if(this.txttcrunset14.Text.Trim().Length==0)
			{
				strErr+="tcrunset14不能为空！\\n";	
			}
			if(this.txttcrunset15.Text.Trim().Length==0)
			{
				strErr+="tcrunset15不能为空！\\n";	
			}
			if(this.txttcrunset16.Text.Trim().Length==0)
			{
				strErr+="tcrunset16不能为空！\\n";	
			}
			if(this.txttcrunset17.Text.Trim().Length==0)
			{
				strErr+="tcrunset17不能为空！\\n";	
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
			decimal community_road_length=decimal.Parse(this.txtcommunity_road_length.Text);
			decimal community_road_area=decimal.Parse(this.txtcommunity_road_area.Text);
			decimal community_road_width_bet_14_and_24_length=decimal.Parse(this.txtcommunity_road_width_bet_14_and_24_length.Text);
			decimal community_road_width_bet_14_and_24_area=decimal.Parse(this.txtcommunity_road_width_bet_14_and_24_area.Text);
			decimal community_road_width_bet_10_and_14_length=decimal.Parse(this.txtcommunity_road_width_bet_10_and_14_length.Text);
			decimal community_road_width_bet_10_and_14_area=decimal.Parse(this.txtcommunity_road_width_bet_10_and_14_area.Text);
			decimal community_road_width_bet_6_and_9_length=decimal.Parse(this.txtcommunity_road_width_bet_6_and_9_length.Text);
			decimal community_road_width_bet_6_and_9_area=decimal.Parse(this.txtcommunity_road_width_bet_6_and_9_area.Text);
			decimal community_road_width_bet_3_and_5_length=decimal.Parse(this.txtcommunity_road_width_bet_3_and_5_length.Text);
			decimal community_road_width_bet_3_and_5_area=decimal.Parse(this.txtcommunity_road_width_bet_3_and_5_area.Text);
			decimal community_road_pavement_area=decimal.Parse(this.txtcommunity_road_pavement_area.Text);
			decimal community_road_pavement_colorful_brick_area=decimal.Parse(this.txtcommunity_road_pavement_colorful_brick_area.Text);
			decimal community_road_bet_dwellings_length=decimal.Parse(this.txtcommunity_road_bet_dwellings_length.Text);
			decimal community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length=decimal.Parse(this.txtcommunity_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length.Text);
			decimal community_pavement_length=decimal.Parse(this.txtcommunity_pavement_length.Text);
			decimal community_pavement_area=decimal.Parse(this.txtcommunity_pavement_area.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int community_road_num=int.Parse(this.txtcommunity_road_num.Text);
			string tcrunset1=this.txttcrunset1.Text;
			string tcrunset2=this.txttcrunset2.Text;
			string tcrunset3=this.txttcrunset3.Text;
			string tcrunset4=this.txttcrunset4.Text;
			string tcrunset5=this.txttcrunset5.Text;
			string tcrunset6=this.txttcrunset6.Text;
			string tcrunset7=this.txttcrunset7.Text;
			string tcrunset8=this.txttcrunset8.Text;
			string tcrunset9=this.txttcrunset9.Text;
			string tcrunset10=this.txttcrunset10.Text;
			string tcrunset11=this.txttcrunset11.Text;
			string tcrunset12=this.txttcrunset12.Text;
			string tcrunset13=this.txttcrunset13.Text;
			string tcrunset14=this.txttcrunset14.Text;
			string tcrunset15=this.txttcrunset15.Text;
			string tcrunset16=this.txttcrunset16.Text;
			string tcrunset17=this.txttcrunset17.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);


			TTG.Model.TTGWeb.community_road model=new TTG.Model.TTGWeb.community_road();
			model.community_id=community_id;
			model.community_road_length=community_road_length;
			model.community_road_area=community_road_area;
			model.community_road_width_bet_14_and_24_length=community_road_width_bet_14_and_24_length;
			model.community_road_width_bet_14_and_24_area=community_road_width_bet_14_and_24_area;
			model.community_road_width_bet_10_and_14_length=community_road_width_bet_10_and_14_length;
			model.community_road_width_bet_10_and_14_area=community_road_width_bet_10_and_14_area;
			model.community_road_width_bet_6_and_9_length=community_road_width_bet_6_and_9_length;
			model.community_road_width_bet_6_and_9_area=community_road_width_bet_6_and_9_area;
			model.community_road_width_bet_3_and_5_length=community_road_width_bet_3_and_5_length;
			model.community_road_width_bet_3_and_5_area=community_road_width_bet_3_and_5_area;
			model.community_road_pavement_area=community_road_pavement_area;
			model.community_road_pavement_colorful_brick_area=community_road_pavement_colorful_brick_area;
			model.community_road_bet_dwellings_length=community_road_bet_dwellings_length;
			model.community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length=community_road_bet_dwellings_lengthcommunity_road_bet_dwellings_length;
			model.community_pavement_length=community_pavement_length;
			model.community_pavement_area=community_pavement_area;
			model.statistics_date=statistics_date;
			model.community_road_num=community_road_num;
			model.tcrunset1=tcrunset1;
			model.tcrunset2=tcrunset2;
			model.tcrunset3=tcrunset3;
			model.tcrunset4=tcrunset4;
			model.tcrunset5=tcrunset5;
			model.tcrunset6=tcrunset6;
			model.tcrunset7=tcrunset7;
			model.tcrunset8=tcrunset8;
			model.tcrunset9=tcrunset9;
			model.tcrunset10=tcrunset10;
			model.tcrunset11=tcrunset11;
			model.tcrunset12=tcrunset12;
			model.tcrunset13=tcrunset13;
			model.tcrunset14=tcrunset14;
			model.tcrunset15=tcrunset15;
			model.tcrunset16=tcrunset16;
			model.tcrunset17=tcrunset17;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_road bll=new TTG.BLL.TTGWeb.community_road();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
