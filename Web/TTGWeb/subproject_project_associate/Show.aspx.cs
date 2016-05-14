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
namespace TTG.Web.TTGWeb.subproject_project_associate
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		this.lblproject_name.Text=model.project_name;
		this.lblsubproject_name.Text=model.subproject_name;
		this.lblsubproject_id.Text=model.subproject_id;

	}


    }
}
