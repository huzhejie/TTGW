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
namespace TTG.Web.TTGWeb.community_parking_lot
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
		TTG.BLL.TTGWeb.community_parking_lot bll=new TTG.BLL.TTGWeb.community_parking_lot();
		TTG.Model.TTGWeb.community_parking_lot model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_parking_space_num.Text=model.community_parking_space_num.ToString();
		this.txtcommunity_parking_rate.Text=model.community_parking_rate.ToString();
		this.txtcommunity_parking_space_use_rate.Text=model.community_parking_space_use_rate.ToString();
		this.txtcommunity_public_parking_lot_num.Text=model.community_public_parking_lot_num.ToString();
		this.txtcommunity_public_grand_parking_lot_num.Text=model.community_public_grand_parking_lot_num.ToString();
		this.txtcommunity_public_underg_parking_lot_num.Text=model.community_public_underg_parking_lot_num.ToString();
		this.txtcommunity_public_overg_parking_lot_num.Text=model.community_public_overg_parking_lot_num.ToString();
		this.txtcommunity_public_parking_lot_area.Text=model.community_public_parking_lot_area.ToString();
		this.txtcommunity_public_parking_space_num.Text=model.community_public_parking_space_num.ToString();
		this.txtcommunity_public_parking_lot_area_rate.Text=model.community_public_parking_lot_area_rate.ToString();
		this.txtdis_150m_public_parking_lot_num.Text=model.dis_150m_public_parking_lot_num.ToString();
		this.txtdis_150m_public_parking_lot_area.Text=model.dis_150m_public_parking_lot_area.ToString();
		this.txtdis_150m_public_parking_space_num.Text=model.dis_150m_public_parking_space_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttcplunset1.Text=model.tcplunset1;
		this.txttcplunset2.Text=model.tcplunset2;
		this.txttcplunset3.Text=model.tcplunset3;
		this.txttcplunset4.Text=model.tcplunset4;
		this.txttcplunset5.Text=model.tcplunset5;
		this.txttcplunset6.Text=model.tcplunset6;
		this.txttcplunset7.Text=model.tcplunset7;
		this.txttcplunset8.Text=model.tcplunset8;
		this.txttcplunset9.Text=model.tcplunset9;
		this.txttcplunset10.Text=model.tcplunset10;
		this.txttcplunset11.Text=model.tcplunset11;
		this.txttcplunset12.Text=model.tcplunset12;
		this.txttcplunset13.Text=model.tcplunset13;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommunity_parking_space_num.Text))
			{
				strErr+="community_parking_space_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_parking_rate.Text))
			{
				strErr+="community_parking_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_parking_space_use_rate.Text))
			{
				strErr+="community_parking_space_use_rate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_parking_lot_num.Text))
			{
				strErr+="community_public_parking_lot_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_grand_parking_lot_num.Text))
			{
				strErr+="community_public_grand_parking_lot_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_underg_parking_lot_num.Text))
			{
				strErr+="community_public_underg_parking_lot_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_overg_parking_lot_num.Text))
			{
				strErr+="community_public_overg_parking_lot_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_parking_lot_area.Text))
			{
				strErr+="community_public_parking_lot_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_public_parking_space_num.Text))
			{
				strErr+="community_public_parking_space_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_public_parking_lot_area_rate.Text))
			{
				strErr+="community_public_parking_lot_area_rate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtdis_150m_public_parking_lot_num.Text))
			{
				strErr+="dis_150m_public_parking_lot_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdis_150m_public_parking_lot_area.Text))
			{
				strErr+="dis_150m_public_parking_lot_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtdis_150m_public_parking_space_num.Text))
			{
				strErr+="dis_150m_public_parking_space_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcplunset1.Text.Trim().Length==0)
			{
				strErr+="tcplunset1不能为空！\\n";	
			}
			if(this.txttcplunset2.Text.Trim().Length==0)
			{
				strErr+="tcplunset2不能为空！\\n";	
			}
			if(this.txttcplunset3.Text.Trim().Length==0)
			{
				strErr+="tcplunset3不能为空！\\n";	
			}
			if(this.txttcplunset4.Text.Trim().Length==0)
			{
				strErr+="tcplunset4不能为空！\\n";	
			}
			if(this.txttcplunset5.Text.Trim().Length==0)
			{
				strErr+="tcplunset5不能为空！\\n";	
			}
			if(this.txttcplunset6.Text.Trim().Length==0)
			{
				strErr+="tcplunset6不能为空！\\n";	
			}
			if(this.txttcplunset7.Text.Trim().Length==0)
			{
				strErr+="tcplunset7不能为空！\\n";	
			}
			if(this.txttcplunset8.Text.Trim().Length==0)
			{
				strErr+="tcplunset8不能为空！\\n";	
			}
			if(this.txttcplunset9.Text.Trim().Length==0)
			{
				strErr+="tcplunset9不能为空！\\n";	
			}
			if(this.txttcplunset10.Text.Trim().Length==0)
			{
				strErr+="tcplunset10不能为空！\\n";	
			}
			if(this.txttcplunset11.Text.Trim().Length==0)
			{
				strErr+="tcplunset11不能为空！\\n";	
			}
			if(this.txttcplunset12.Text.Trim().Length==0)
			{
				strErr+="tcplunset12不能为空！\\n";	
			}
			if(this.txttcplunset13.Text.Trim().Length==0)
			{
				strErr+="tcplunset13不能为空！\\n";	
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
			int community_parking_space_num=int.Parse(this.txtcommunity_parking_space_num.Text);
			decimal community_parking_rate=decimal.Parse(this.txtcommunity_parking_rate.Text);
			decimal community_parking_space_use_rate=decimal.Parse(this.txtcommunity_parking_space_use_rate.Text);
			int community_public_parking_lot_num=int.Parse(this.txtcommunity_public_parking_lot_num.Text);
			int community_public_grand_parking_lot_num=int.Parse(this.txtcommunity_public_grand_parking_lot_num.Text);
			int community_public_underg_parking_lot_num=int.Parse(this.txtcommunity_public_underg_parking_lot_num.Text);
			int community_public_overg_parking_lot_num=int.Parse(this.txtcommunity_public_overg_parking_lot_num.Text);
			decimal community_public_parking_lot_area=decimal.Parse(this.txtcommunity_public_parking_lot_area.Text);
			int community_public_parking_space_num=int.Parse(this.txtcommunity_public_parking_space_num.Text);
			decimal community_public_parking_lot_area_rate=decimal.Parse(this.txtcommunity_public_parking_lot_area_rate.Text);
			int dis_150m_public_parking_lot_num=int.Parse(this.txtdis_150m_public_parking_lot_num.Text);
			decimal dis_150m_public_parking_lot_area=decimal.Parse(this.txtdis_150m_public_parking_lot_area.Text);
			int dis_150m_public_parking_space_num=int.Parse(this.txtdis_150m_public_parking_space_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcplunset1=this.txttcplunset1.Text;
			string tcplunset2=this.txttcplunset2.Text;
			string tcplunset3=this.txttcplunset3.Text;
			string tcplunset4=this.txttcplunset4.Text;
			string tcplunset5=this.txttcplunset5.Text;
			string tcplunset6=this.txttcplunset6.Text;
			string tcplunset7=this.txttcplunset7.Text;
			string tcplunset8=this.txttcplunset8.Text;
			string tcplunset9=this.txttcplunset9.Text;
			string tcplunset10=this.txttcplunset10.Text;
			string tcplunset11=this.txttcplunset11.Text;
			string tcplunset12=this.txttcplunset12.Text;
			string tcplunset13=this.txttcplunset13.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);


			TTG.Model.TTGWeb.community_parking_lot model=new TTG.Model.TTGWeb.community_parking_lot();
			model.community_id=community_id;
			model.community_parking_space_num=community_parking_space_num;
			model.community_parking_rate=community_parking_rate;
			model.community_parking_space_use_rate=community_parking_space_use_rate;
			model.community_public_parking_lot_num=community_public_parking_lot_num;
			model.community_public_grand_parking_lot_num=community_public_grand_parking_lot_num;
			model.community_public_underg_parking_lot_num=community_public_underg_parking_lot_num;
			model.community_public_overg_parking_lot_num=community_public_overg_parking_lot_num;
			model.community_public_parking_lot_area=community_public_parking_lot_area;
			model.community_public_parking_space_num=community_public_parking_space_num;
			model.community_public_parking_lot_area_rate=community_public_parking_lot_area_rate;
			model.dis_150m_public_parking_lot_num=dis_150m_public_parking_lot_num;
			model.dis_150m_public_parking_lot_area=dis_150m_public_parking_lot_area;
			model.dis_150m_public_parking_space_num=dis_150m_public_parking_space_num;
			model.statistics_date=statistics_date;
			model.tcplunset1=tcplunset1;
			model.tcplunset2=tcplunset2;
			model.tcplunset3=tcplunset3;
			model.tcplunset4=tcplunset4;
			model.tcplunset5=tcplunset5;
			model.tcplunset6=tcplunset6;
			model.tcplunset7=tcplunset7;
			model.tcplunset8=tcplunset8;
			model.tcplunset9=tcplunset9;
			model.tcplunset10=tcplunset10;
			model.tcplunset11=tcplunset11;
			model.tcplunset12=tcplunset12;
			model.tcplunset13=tcplunset13;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_parking_lot bll=new TTG.BLL.TTGWeb.community_parking_lot();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
