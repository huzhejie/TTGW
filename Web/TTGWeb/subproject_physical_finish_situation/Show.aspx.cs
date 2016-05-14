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
namespace TTG.Web.TTGWeb.subproject_physical_finish_situation
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string subproject_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					subproject_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(subproject_id,statistics_date);
			}
		}
		
	private void ShowInfo(string subproject_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.subproject_physical_finish_situation bll=new TTG.BLL.TTGWeb.subproject_physical_finish_situation();
		TTG.Model.TTGWeb.subproject_physical_finish_situation model=bll.GetModel(subproject_id,statistics_date);
		this.lblsubproject_id.Text=model.subproject_id;
		this.lblsubproject_no.Text=model.subproject_no;
		this.lblsubproject_name.Text=model.subproject_name;
		this.lblcounty_name.Text=model.county_name;
		this.lblproject_name.Text=model.project_name;
		this.lblsubproject_category.Text=model.subproject_category;
		this.lblcommunity.Text=model.community;
		this.lblphysical_class.Text=model.physical_class;
		this.lblphysical_subclass.Text=model.physical_subclass;
		this.lblphysical_class_content.Text=model.physical_class_content;
		this.lblplan_quantity.Text=model.plan_quantity.ToString();
		this.lblnote_information.Text=model.note_information;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lbltciunset5.Text=model.tciunset5;
		this.lbltciunset6.Text=model.tciunset6;
		this.lbltciunset7.Text=model.tciunset7;
		this.lbltciunset8.Text=model.tciunset8;
		this.lbltciunset9.Text=model.tciunset9;
		this.lbltciunset10.Text=model.tciunset10;
		this.lbltciunset11.Text=model.tciunset11;
		this.lbltciunset12.Text=model.tciunset12;
		this.lbltciunset13.Text=model.tciunset13;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
