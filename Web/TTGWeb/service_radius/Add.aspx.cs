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
namespace TTG.Web.TTGWeb.service_radius
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtfacilities_type.Text.Trim().Length==0)
			{
				strErr+="facilities_type不能为空！\\n";	
			}
			if(this.txtfacilities_level.Text.Trim().Length==0)
			{
				strErr+="facilities_level不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtservice_radius_value.Text))
			{
				strErr+="service_radius_value格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string facilities_type=this.txtfacilities_type.Text;
			string facilities_level=this.txtfacilities_level.Text;
			decimal service_radius_value=decimal.Parse(this.txtservice_radius_value.Text);

			TTG.Model.TTGWeb.service_radius model=new TTG.Model.TTGWeb.service_radius();
			model.facilities_type=facilities_type;
			model.facilities_level=facilities_level;
			model.service_radius_value=service_radius_value;

			TTG.BLL.TTGWeb.service_radius bll=new TTG.BLL.TTGWeb.service_radius();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
