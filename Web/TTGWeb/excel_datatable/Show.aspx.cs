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
namespace TTG.Web.TTGWeb.excel_datatable
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
					string table_name= strid;
					ShowInfo(table_name);
				}
			}
		}
		
	private void ShowInfo(string table_name)
	{
		TTG.BLL.TTGWeb.excel_datatable bll=new TTG.BLL.TTGWeb.excel_datatable();
		TTG.Model.TTGWeb.excel_datatable model=bll.GetModel(table_name);
		this.lblexcel_name.Text=model.excel_name;
		this.lbltable_name.Text=model.table_name;
		this.lbltable_start_column.Text=model.table_start_column.ToString();
		this.lbltable_start_row.Text=model.table_start_row.ToString();
		this.lbltable_end_column.Text=model.table_end_column.ToString();
		this.lbltable_end_row.Text=model.table_end_row.ToString();

	}


    }
}
