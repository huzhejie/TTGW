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
namespace TTG.Web.TTGWeb.alter_field
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string field_name = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					field_name= Request.Params["id0"];
				}
				string table_name = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					table_name= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(field_name,table_name);
			}
		}
		
	private void ShowInfo(string field_name,string table_name)
	{
		TTG.BLL.TTGWeb.alter_field bll=new TTG.BLL.TTGWeb.alter_field();
		TTG.Model.TTGWeb.alter_field model=bll.GetModel(field_name,table_name);
		this.lblfield_name.Text=model.field_name;
		this.lbltable_name.Text=model.table_name;
		this.lblalter_field_name.Text=model.alter_field_name;
		this.lblalter_field_unit.Text=model.alter_field_unit;
		this.lblalter_type.Text=model.alter_type;

	}


    }
}
