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
namespace TTG.Web.TTGWeb.file
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
					string file_no= strid;
					ShowInfo(file_no);
				}
			}
		}
		
	private void ShowInfo(string file_no)
	{
		TTG.BLL.TTGWeb.file bll=new TTG.BLL.TTGWeb.file();
		TTG.Model.TTGWeb.file model=bll.GetModel(file_no);
		this.lblfile_no.Text=model.file_no;
		this.lblfile_name.Text=model.file_name;
		this.lblfile_address.Text=model.file_address;
		this.lbltime.Text=model.time.ToString();

	}


    }
}
