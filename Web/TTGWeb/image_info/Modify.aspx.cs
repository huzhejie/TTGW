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
namespace TTG.Web.TTGWeb.image_info
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string image_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					image_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(image_id,statistics_date);
			}
		}
			
	private void ShowInfo(string image_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.image_info bll=new TTG.BLL.TTGWeb.image_info();
		TTG.Model.TTGWeb.image_info model=bll.GetModel(image_id,statistics_date);
		this.lblimage_id.Text=model.image_id;
		this.txtimage_name.Text=model.image_name;
		this.txtimage_address.Text=model.image_address;
		this.txtcommunity_id.Text=model.community_id;
		this.txtimage_type.Text=model.image_type;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txtnf_id.Text=model.nf_id;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtimage_name.Text.Trim().Length==0)
			{
				strErr+="image_name不能为空！\\n";	
			}
			if(this.txtimage_address.Text.Trim().Length==0)
			{
				strErr+="image_address不能为空！\\n";	
			}
			if(this.txtcommunity_id.Text.Trim().Length==0)
			{
				strErr+="community_id不能为空！\\n";	
			}
			if(this.txtimage_type.Text.Trim().Length==0)
			{
				strErr+="image_type不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txtnf_id.Text.Trim().Length==0)
			{
				strErr+="nf_id不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string image_id=this.lblimage_id.Text;
			string image_name=this.txtimage_name.Text;
			string image_address=this.txtimage_address.Text;
			string community_id=this.txtcommunity_id.Text;
			string image_type=this.txtimage_type.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string nf_id=this.txtnf_id.Text;


			TTG.Model.TTGWeb.image_info model=new TTG.Model.TTGWeb.image_info();
			model.image_id=image_id;
			model.image_name=image_name;
			model.image_address=image_address;
			model.community_id=community_id;
			model.image_type=image_type;
			model.statistics_date=statistics_date;
			model.nf_id=nf_id;

			TTG.BLL.TTGWeb.image_info bll=new TTG.BLL.TTGWeb.image_info();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
