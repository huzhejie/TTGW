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
namespace TTG.Web.TTGWeb.community_geologic_hazard
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
		TTG.BLL.TTGWeb.community_geologic_hazard bll=new TTG.BLL.TTGWeb.community_geologic_hazard();
		TTG.Model.TTGWeb.community_geologic_hazard model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtserious_geologic_hazard_num.Text=model.serious_geologic_hazard_num.ToString();
		this.txtserious_geologic_hazard_handle_num.Text=model.serious_geologic_hazard_handle_num.ToString();
		this.txtinfluence_house_area.Text=model.influence_house_area.ToString();
		this.txtprotect_house_area.Text=model.protect_house_area.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttcghunset1.Text=model.tcghunset1;
		this.txttcghunset2.Text=model.tcghunset2;
		this.txttcghunset3.Text=model.tcghunset3;
		this.txttcghunset4.Text=model.tcghunset4;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtserious_geologic_hazard_num.Text))
			{
				strErr+="serious_geologic_hazard_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtserious_geologic_hazard_handle_num.Text))
			{
				strErr+="serious_geologic_hazard_handle_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtinfluence_house_area.Text))
			{
				strErr+="influence_house_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtprotect_house_area.Text))
			{
				strErr+="protect_house_area格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcghunset1.Text.Trim().Length==0)
			{
				strErr+="tcghunset1不能为空！\\n";	
			}
			if(this.txttcghunset2.Text.Trim().Length==0)
			{
				strErr+="tcghunset2不能为空！\\n";	
			}
			if(this.txttcghunset3.Text.Trim().Length==0)
			{
				strErr+="tcghunset3不能为空！\\n";	
			}
			if(this.txttcghunset4.Text.Trim().Length==0)
			{
				strErr+="tcghunset4不能为空！\\n";	
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
			int serious_geologic_hazard_num=int.Parse(this.txtserious_geologic_hazard_num.Text);
			int serious_geologic_hazard_handle_num=int.Parse(this.txtserious_geologic_hazard_handle_num.Text);
			decimal influence_house_area=decimal.Parse(this.txtinfluence_house_area.Text);
			decimal protect_house_area=decimal.Parse(this.txtprotect_house_area.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcghunset1=this.txttcghunset1.Text;
			string tcghunset2=this.txttcghunset2.Text;
			string tcghunset3=this.txttcghunset3.Text;
			string tcghunset4=this.txttcghunset4.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);


			TTG.Model.TTGWeb.community_geologic_hazard model=new TTG.Model.TTGWeb.community_geologic_hazard();
			model.community_id=community_id;
			model.serious_geologic_hazard_num=serious_geologic_hazard_num;
			model.serious_geologic_hazard_handle_num=serious_geologic_hazard_handle_num;
			model.influence_house_area=influence_house_area;
			model.protect_house_area=protect_house_area;
			model.statistics_date=statistics_date;
			model.tcghunset1=tcghunset1;
			model.tcghunset2=tcghunset2;
			model.tcghunset3=tcghunset3;
			model.tcghunset4=tcghunset4;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_geologic_hazard bll=new TTG.BLL.TTGWeb.community_geologic_hazard();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
