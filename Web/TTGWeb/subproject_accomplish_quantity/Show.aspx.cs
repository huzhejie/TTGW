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
namespace TTG.Web.TTGWeb.subproject_accomplish_quantity
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
		TTG.BLL.TTGWeb.subproject_accomplish_quantity bll=new TTG.BLL.TTGWeb.subproject_accomplish_quantity();
		TTG.Model.TTGWeb.subproject_accomplish_quantity model=bll.GetModel(subproject_id,statistics_date);
		this.lblsubproject_id.Text=model.subproject_id;
		this.lblsubproject_name.Text=model.subproject_name;
		this.lblsubproject_finish_quantity.Text=model.subproject_finish_quantity.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
