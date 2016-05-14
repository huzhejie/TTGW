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
namespace TTG.Web.TTGWeb.notification_info
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
					string nf_id= strid;
					ShowInfo(nf_id);
				}
			}
		}
		
	private void ShowInfo(string nf_id)
	{
		TTG.BLL.TTGWeb.notification_info bll=new TTG.BLL.TTGWeb.notification_info();
		TTG.Model.TTGWeb.notification_info model=bll.GetModel(nf_id);
		this.lblnf_id.Text=model.nf_id;
		this.lblnf_title.Text=model.nf_title;
		this.lblnf_content.Text=model.nf_content;
		this.lblnf_time.Text=model.nf_time.ToString();
		this.lblnf_depart.Text=model.nf_depart;
		this.lblnf_type.Text=model.nf_type;

	}


    }
}
