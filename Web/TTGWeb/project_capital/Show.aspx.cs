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
namespace TTG.Web.TTGWeb.project_capital
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
				string furnished_type = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					furnished_type= Request.Params["id1"];
				}
				DateTime time = "";
				if (Request.Params["id2"] != null && Request.Params["id2"].Trim() != "")
				{
					time= Request.Params["id2"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(project_id,furnished_type,time);
			}
		}
		
	private void ShowInfo(string project_id,string furnished_type,DateTime time)
	{
		TTG.BLL.TTGWeb.project_capital bll=new TTG.BLL.TTGWeb.project_capital();
		TTG.Model.TTGWeb.project_capital model=bll.GetModel(project_id,furnished_type,time);
		this.lblproject_id.Text=model.project_id;
		this.lblproject_name.Text=model.project_name;
		this.lblfurnished_type.Text=model.furnished_type;
		this.lbltotal_investment.Text=model.total_investment.ToString();
		this.lblTTG_follow_up_work_approved_special_subsidies.Text=model.TTG_follow_up_work_approved_special_subsidies.ToString();
		this.lblplan_counterparts_support_funds.Text=model.plan_counterparts_support_funds.ToString();
		this.lblother_matching_funds.Text=model.other_matching_funds.ToString();
		this.lblother_funds.Text=model.other_funds.ToString();
		this.lbltime.Text=model.time.ToString();
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lbltciunset5.Text=model.tciunset5;
		this.lbltciunset6.Text=model.tciunset6;
		this.lbltciunset7.Text=model.tciunset7;
		this.lbltciunset8.Text=model.tciunset8;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
