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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
