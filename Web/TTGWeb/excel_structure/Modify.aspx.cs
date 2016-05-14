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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace TTG.Web.TTGWeb.excel_structure
{
    public partial class Modify : Page
    {       

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
		TTG.BLL.TTGWeb.excel_structure bll=new TTG.BLL.TTGWeb.excel_structure();
		TTG.Model.TTGWeb.excel_structure model=bll.GetModel(property,table_name);
		this.lblproperty.Text=model.property;
		this.txtexcel_name.Text=model.excel_name;
		this.txtrow_column_num.Text=model.row_column_num.ToString();
		this.lbltable_name.Text=model.table_name;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtexcel_name.Text.Trim().Length==0)
			{
				strErr+="excel_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtrow_column_num.Text))
			{
				strErr+="row_column_num格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string property=this.lblproperty.Text;
			string excel_name=this.txtexcel_name.Text;
			int row_column_num=int.Parse(this.txtrow_column_num.Text);
			string table_name=this.lbltable_name.Text;


			TTG.Model.TTGWeb.excel_structure model=new TTG.Model.TTGWeb.excel_structure();
			model.property=property;
			model.excel_name=excel_name;
			model.row_column_num=row_column_num;
			model.table_name=table_name;

			TTG.BLL.TTGWeb.excel_structure bll=new TTG.BLL.TTGWeb.excel_structure();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
