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
namespace TTG.Web.TTGWeb.excel_span_structure
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string property = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					property= Request.Params["id0"];
				}
				string table_name = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					table_name= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(property,table_name);
			}
		}
		
	private void ShowInfo(string property,string table_name)
	{
		TTG.BLL.TTGWeb.excel_span_structure bll=new TTG.BLL.TTGWeb.excel_span_structure();
		TTG.Model.TTGWeb.excel_span_structure model=bll.GetModel(property,table_name);
		this.lblproperty.Text=model.property;
		this.lblexcel_name.Text=model.excel_name;
		this.lbltable_name.Text=model.table_name;
		this.lblrow_num.Text=model.row_num.ToString();
		this.lblcolumn_num.Text=model.column_num.ToString();

	}


    }
}
