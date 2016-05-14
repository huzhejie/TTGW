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
namespace TTG.Web.TTGWeb.community_problem_type_contrast
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string question_content= strid;
					ShowInfo(question_content);
				}
			}
		}
		
	private void ShowInfo(string question_content)
	{
		TTG.BLL.TTGWeb.community_problem_type_contrast bll=new TTG.BLL.TTGWeb.community_problem_type_contrast();
		TTG.Model.TTGWeb.community_problem_type_contrast model=bll.GetModel(question_content);
		this.lblquestion_content.Text=model.question_content;
		this.lbltable_belong_to.Text=model.table_belong_to;
		this.lblunit.Text=model.unit;
		this.lblproblem_nature.Text=model.problem_nature;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
