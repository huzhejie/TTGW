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
namespace TTG.Web.TTGWeb.effiect_translate
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		TTG.BLL.TTGWeb.effiect_translate bll=new TTG.BLL.TTGWeb.effiect_translate();
		TTG.Model.TTGWeb.effiect_translate model=bll.GetModel();
		this.txtchinese.Text=model.chinese;
		this.txtenglish.Text=model.english;
		this.txtelevel.Text=model.elevel.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtchinese.Text.Trim().Length==0)
			{
				strErr+="chinese不能为空！\\n";	
			}
			if(this.txtenglish.Text.Trim().Length==0)
			{
				strErr+="english不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtelevel.Text))
			{
				strErr+="elevel格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string chinese=this.txtchinese.Text;
			string english=this.txtenglish.Text;
			int elevel=int.Parse(this.txtelevel.Text);


			TTG.Model.TTGWeb.effiect_translate model=new TTG.Model.TTGWeb.effiect_translate();
			model.chinese=chinese;
			model.english=english;
			model.elevel=elevel;

			TTG.BLL.TTGWeb.effiect_translate bll=new TTG.BLL.TTGWeb.effiect_translate();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
