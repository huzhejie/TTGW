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
namespace TTG.Web.TTGWeb.file
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string file_no= Request.Params["id"];
					ShowInfo(file_no);
				}
			}
		}
			
	private void ShowInfo(string file_no)
	{
		TTG.BLL.TTGWeb.file bll=new TTG.BLL.TTGWeb.file();
		TTG.Model.TTGWeb.file model=bll.GetModel(file_no);
		this.lblfile_no.Text=model.file_no;
		this.txtfile_name.Text=model.file_name;
		this.txtfile_address.Text=model.file_address;
		this.txttime.Text=model.time.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtfile_name.Text.Trim().Length==0)
			{
				strErr+="file_name不能为空！\\n";	
			}
			if(this.txtfile_address.Text.Trim().Length==0)
			{
				strErr+="file_address不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txttime.Text))
			{
				strErr+="time格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string file_no=this.lblfile_no.Text;
			string file_name=this.txtfile_name.Text;
			string file_address=this.txtfile_address.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);


			TTG.Model.TTGWeb.file model=new TTG.Model.TTGWeb.file();
			model.file_no=file_no;
			model.file_name=file_name;
			model.file_address=file_address;
			model.time=time;

			TTG.BLL.TTGWeb.file bll=new TTG.BLL.TTGWeb.file();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
