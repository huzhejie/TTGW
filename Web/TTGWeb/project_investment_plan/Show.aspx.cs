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
namespace TTG.Web.TTGWeb.project_investment_plan
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
				string investment_year = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					investment_year= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(project_id,investment_year);
			}
		}
		
	private void ShowInfo(string project_id,string investment_year)
	{
		TTG.BLL.TTGWeb.project_investment_plan bll=new TTG.BLL.TTGWeb.project_investment_plan();
		TTG.Model.TTGWeb.project_investment_plan model=bll.GetModel(project_id,investment_year);
		this.lblproject_id.Text=model.project_id;
		this.lblproject_name.Text=model.project_name;
		this.lblinvestment_plan.Text=model.investment_plan.ToString();
		this.lblinvestment_year.Text=model.investment_year;
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
