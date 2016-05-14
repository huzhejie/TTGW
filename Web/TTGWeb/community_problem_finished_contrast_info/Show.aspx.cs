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
namespace TTG.Web.TTGWeb.community_problem_finished_contrast_info
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
		TTG.BLL.TTGWeb.community_problem_finished_contrast_info bll=new TTG.BLL.TTGWeb.community_problem_finished_contrast_info();
		TTG.Model.TTGWeb.community_problem_finished_contrast_info model=bll.GetModel();
		this.lblcommunity_problem_content.Text=model.community_problem_content;
		this.lblcommunity_problem_unit.Text=model.community_problem_unit;
		this.lblcommunity_finish_content.Text=model.community_finish_content;
		this.lblcommunity_finish_content_unit.Text=model.community_finish_content_unit;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
