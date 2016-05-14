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
namespace TTG.Web.TTGWeb.community_project_associate
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		this.lblproject_id.Text=model.project_id;
		this.lblproject_name.Text=model.project_name;
		this.lblcommunity_name.Text=model.community_name;
		this.lblcommunity_id.Text=model.community_id;

	}


    }
}
