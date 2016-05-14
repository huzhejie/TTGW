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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string project_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					project_id= Request.Params["id0"];
				}
				string subproject_id = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					subproject_id= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(project_id,subproject_id);
			}
		}
			
	private void ShowInfo(string project_id,string subproject_id)
	{
		TTG.BLL.TTGWeb.subproject_project_associate bll=new TTG.BLL.TTGWeb.subproject_project_associate();
		TTG.Model.TTGWeb.subproject_project_associate model=bll.GetModel(project_id,subproject_id);
		this.lblproject_id.Text=model.project_id;
		this.txtproject_name.Text=model.project_name;
		this.txtsubproject_name.Text=model.subproject_name;
		this.lblsubproject_id.Text=model.subproject_id;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtproject_name.Text.Trim().Length==0)
			{
				strErr+="project_name不能为空！\\n";	
			}
			if(this.txtsubproject_name.Text.Trim().Length==0)
			{
				strErr+="subproject_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string project_id=this.lblproject_id.Text;
			string project_name=this.txtproject_name.Text;
			string subproject_name=this.txtsubproject_name.Text;
			string subproject_id=this.lblsubproject_id.Text;


			TTG.Model.TTGWeb.subproject_project_associate model=new TTG.Model.TTGWeb.subproject_project_associate();
			model.project_id=project_id;
			model.project_name=project_name;
			model.subproject_name=subproject_name;
			model.subproject_id=subproject_id;

			TTG.BLL.TTGWeb.subproject_project_associate bll=new TTG.BLL.TTGWeb.subproject_project_associate();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
