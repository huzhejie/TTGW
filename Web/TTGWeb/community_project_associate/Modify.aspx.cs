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
namespace TTG.Web.TTGWeb.community_project_associate
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
		TTG.BLL.TTGWeb.community_project_associate bll=new TTG.BLL.TTGWeb.community_project_associate();
		TTG.Model.TTGWeb.community_project_associate model=bll.GetModel();
		this.txtproject_id.Text=model.project_id;
		this.txtproject_name.Text=model.project_name;
		this.txtcommunity_name.Text=model.community_name;
		this.txtcommunity_id.Text=model.community_id;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			if(this.txtcommunity_name.Text.Trim().Length==0)
			{
				strErr+="community_name不能为空！\\n";	
			}
			if(this.txtcommunity_id.Text.Trim().Length==0)
			{
				strErr+="community_id不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string project_id=this.txtproject_id.Text;
			string project_name=this.txtproject_name.Text;
			string community_name=this.txtcommunity_name.Text;
			string community_id=this.txtcommunity_id.Text;


			TTG.Model.TTGWeb.community_project_associate model=new TTG.Model.TTGWeb.community_project_associate();
			model.project_id=project_id;
			model.project_name=project_name;
			model.community_name=community_name;
			model.community_id=community_id;

			TTG.BLL.TTGWeb.community_project_associate bll=new TTG.BLL.TTGWeb.community_project_associate();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
