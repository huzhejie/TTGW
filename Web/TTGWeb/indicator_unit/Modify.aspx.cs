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
namespace TTG.Web.TTGWeb.indicator_unit
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
		TTG.BLL.TTGWeb.indicator_unit bll=new TTG.BLL.TTGWeb.indicator_unit();
		TTG.Model.TTGWeb.indicator_unit model=bll.GetModel();
		this.txtindicator.Text=model.indicator;
		this.txttranslation.Text=model.translation;
		this.txtunit.Text=model.unit;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtindicator.Text.Trim().Length==0)
			{
				strErr+="indicator不能为空！\\n";	
			}
			if(this.txttranslation.Text.Trim().Length==0)
			{
				strErr+="translation不能为空！\\n";	
			}
			if(this.txtunit.Text.Trim().Length==0)
			{
				strErr+="unit不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string indicator=this.txtindicator.Text;
			string translation=this.txttranslation.Text;
			string unit=this.txtunit.Text;


			TTG.Model.TTGWeb.indicator_unit model=new TTG.Model.TTGWeb.indicator_unit();
			model.indicator=indicator;
			model.translation=translation;
			model.unit=unit;

			TTG.BLL.TTGWeb.indicator_unit bll=new TTG.BLL.TTGWeb.indicator_unit();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
