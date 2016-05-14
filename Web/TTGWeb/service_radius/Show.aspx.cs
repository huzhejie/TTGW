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
namespace TTG.Web.TTGWeb.service_radius
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string facilities_type = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					facilities_type= Request.Params["id0"];
				}
				string facilities_level = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					facilities_level= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(facilities_type,facilities_level);
			}
		}
		
	private void ShowInfo(string facilities_type,string facilities_level)
	{
		TTG.BLL.TTGWeb.service_radius bll=new TTG.BLL.TTGWeb.service_radius();
		TTG.Model.TTGWeb.service_radius model=bll.GetModel(facilities_type,facilities_level);
		this.lblfacilities_type.Text=model.facilities_type;
		this.lblfacilities_level.Text=model.facilities_level;
		this.lblservice_radius_value.Text=model.service_radius_value.ToString();

	}


    }
}
