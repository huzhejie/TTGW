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
namespace TTG.Web.TTGWeb.community_concil_house
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
		TTG.BLL.TTGWeb.community_concil_house bll=new TTG.BLL.TTGWeb.community_concil_house();
		TTG.Model.TTGWeb.community_concil_house model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_council_buil_num.Text=model.community_council_buil_num.ToString();
		this.txtcommunity_conhou_gfa.Text=model.community_conhou_gfa.ToString();
		this.txtcommunity_conhou_fs.Text=model.community_conhou_fs.ToString();
		this.txtcommunity_conhou_unit_num.Text=model.community_conhou_unit_num.ToString();
		this.txtcommunity_conhou_floor_num.Text=model.community_conhou_floor_num.ToString();
		this.txtcommunity_conhou_suite_num.Text=model.community_conhou_suite_num.ToString();
		this.txtcommunity_conhou_family_num.Text=model.community_conhou_family_num.ToString();
		this.txtcommunity_conhou_people_num.Text=model.community_conhou_people_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttcchunset1.Text=model.tcchunset1;
		this.txttcchunset2.Text=model.tcchunset2;
		this.txttcchunset3.Text=model.tcchunset3;
		this.txttcchunset4.Text=model.tcchunset4;
		this.txttcchunset5.Text=model.tcchunset5;
		this.txttcchunset6.Text=model.tcchunset6;
		this.txttcchunset8.Text=model.tcchunset8;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommunity_council_buil_num.Text))
			{
				strErr+="community_council_buil_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_conhou_gfa.Text))
			{
				strErr+="community_conhou_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_conhou_fs.Text))
			{
				strErr+="community_conhou_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_conhou_unit_num.Text))
			{
				strErr+="community_conhou_unit_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_conhou_floor_num.Text))
			{
				strErr+="community_conhou_floor_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_conhou_suite_num.Text))
			{
				strErr+="community_conhou_suite_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_conhou_family_num.Text))
			{
				strErr+="community_conhou_family_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_conhou_people_num.Text))
			{
				strErr+="community_conhou_people_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcchunset1.Text.Trim().Length==0)
			{
				strErr+="tcchunset1不能为空！\\n";	
			}
			if(this.txttcchunset2.Text.Trim().Length==0)
			{
				strErr+="tcchunset2不能为空！\\n";	
			}
			if(this.txttcchunset3.Text.Trim().Length==0)
			{
				strErr+="tcchunset3不能为空！\\n";	
			}
			if(this.txttcchunset4.Text.Trim().Length==0)
			{
				strErr+="tcchunset4不能为空！\\n";	
			}
			if(this.txttcchunset5.Text.Trim().Length==0)
			{
				strErr+="tcchunset5不能为空！\\n";	
			}
			if(this.txttcchunset6.Text.Trim().Length==0)
			{
				strErr+="tcchunset6不能为空！\\n";	
			}
			if(this.txttcchunset8.Text.Trim().Length==0)
			{
				strErr+="tcchunset8不能为空！\\n";	
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
			int community_council_buil_num=int.Parse(this.txtcommunity_council_buil_num.Text);
			decimal community_conhou_gfa=decimal.Parse(this.txtcommunity_conhou_gfa.Text);
			decimal community_conhou_fs=decimal.Parse(this.txtcommunity_conhou_fs.Text);
			int community_conhou_unit_num=int.Parse(this.txtcommunity_conhou_unit_num.Text);
			int community_conhou_floor_num=int.Parse(this.txtcommunity_conhou_floor_num.Text);
			int community_conhou_suite_num=int.Parse(this.txtcommunity_conhou_suite_num.Text);
			int community_conhou_family_num=int.Parse(this.txtcommunity_conhou_family_num.Text);
			int community_conhou_people_num=int.Parse(this.txtcommunity_conhou_people_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcchunset1=this.txttcchunset1.Text;
			string tcchunset2=this.txttcchunset2.Text;
			string tcchunset3=this.txttcchunset3.Text;
			string tcchunset4=this.txttcchunset4.Text;
			string tcchunset5=this.txttcchunset5.Text;
			string tcchunset6=this.txttcchunset6.Text;
			string tcchunset8=this.txttcchunset8.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);


			TTG.Model.TTGWeb.community_concil_house model=new TTG.Model.TTGWeb.community_concil_house();
			model.community_id=community_id;
			model.community_council_buil_num=community_council_buil_num;
			model.community_conhou_gfa=community_conhou_gfa;
			model.community_conhou_fs=community_conhou_fs;
			model.community_conhou_unit_num=community_conhou_unit_num;
			model.community_conhou_floor_num=community_conhou_floor_num;
			model.community_conhou_suite_num=community_conhou_suite_num;
			model.community_conhou_family_num=community_conhou_family_num;
			model.community_conhou_people_num=community_conhou_people_num;
			model.statistics_date=statistics_date;
			model.tcchunset1=tcchunset1;
			model.tcchunset2=tcchunset2;
			model.tcchunset3=tcchunset3;
			model.tcchunset4=tcchunset4;
			model.tcchunset5=tcchunset5;
			model.tcchunset6=tcchunset6;
			model.tcchunset8=tcchunset8;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_concil_house bll=new TTG.BLL.TTGWeb.community_concil_house();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
