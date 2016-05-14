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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtfile_no.Text.Trim().Length==0)
			{
				strErr+="file_no不能为空！\\n";	
			}
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
			string file_no=this.txtfile_no.Text;
			string file_name=this.txtfile_name.Text;
			string file_address=this.txtfile_address.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);

			TTG.Model.TTGWeb.file model=new TTG.Model.TTGWeb.file();
			model.file_no=file_no;
			model.file_name=file_name;
			model.file_address=file_address;
			model.time=time;

			TTG.BLL.TTGWeb.file bll=new TTG.BLL.TTGWeb.file();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
