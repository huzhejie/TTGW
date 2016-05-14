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
namespace TTG.Web.TTGWeb.subproject_project_associate
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtproject_id.Text.Trim().Length==0)
			{
				strErr+="project_id不能为空！\\n";	
			}
			if(this.txtproject_name.Text.Trim().Length==0)
			{
				strErr+="project_name不能为空！\\n";	
			}
			if(this.txtsubproject_name.Text.Trim().Length==0)
			{
				strErr+="subproject_name不能为空！\\n";	
			}
			if(this.txtsubproject_id.Text.Trim().Length==0)
			{
				strErr+="subproject_id不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string project_id=this.txtproject_id.Text;
			string project_name=this.txtproject_name.Text;
			string subproject_name=this.txtsubproject_name.Text;
			string subproject_id=this.txtsubproject_id.Text;

			TTG.Model.TTGWeb.subproject_project_associate model=new TTG.Model.TTGWeb.subproject_project_associate();
			model.project_id=project_id;
			model.project_name=project_name;
			model.subproject_name=subproject_name;
			model.subproject_id=subproject_id;

			TTG.BLL.TTGWeb.subproject_project_associate bll=new TTG.BLL.TTGWeb.subproject_project_associate();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
