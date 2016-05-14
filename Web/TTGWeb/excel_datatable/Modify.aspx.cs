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
namespace TTG.Web.TTGWeb.excel_datatable
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string table_name= Request.Params["id"];
					ShowInfo(table_name);
				}
			}
		}
			
	private void ShowInfo(string table_name)
	{
		TTG.BLL.TTGWeb.excel_datatable bll=new TTG.BLL.TTGWeb.excel_datatable();
		TTG.Model.TTGWeb.excel_datatable model=bll.GetModel(table_name);
		this.txtexcel_name.Text=model.excel_name;
		this.lbltable_name.Text=model.table_name;
		this.txttable_start_column.Text=model.table_start_column.ToString();
		this.txttable_start_row.Text=model.table_start_row.ToString();
		this.txttable_end_column.Text=model.table_end_column.ToString();
		this.txttable_end_row.Text=model.table_end_row.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtexcel_name.Text.Trim().Length==0)
			{
				strErr+="excel_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txttable_start_column.Text))
			{
				strErr+="table_start_column格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttable_start_row.Text))
			{
				strErr+="table_start_row格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttable_end_column.Text))
			{
				strErr+="table_end_column格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttable_end_row.Text))
			{
				strErr+="table_end_row格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string excel_name=this.txtexcel_name.Text;
			string table_name=this.lbltable_name.Text;
			int table_start_column=int.Parse(this.txttable_start_column.Text);
			int table_start_row=int.Parse(this.txttable_start_row.Text);
			int table_end_column=int.Parse(this.txttable_end_column.Text);
			int table_end_row=int.Parse(this.txttable_end_row.Text);


			TTG.Model.TTGWeb.excel_datatable model=new TTG.Model.TTGWeb.excel_datatable();
			model.excel_name=excel_name;
			model.table_name=table_name;
			model.table_start_column=table_start_column;
			model.table_start_row=table_start_row;
			model.table_end_column=table_end_column;
			model.table_end_row=table_end_row;

			TTG.BLL.TTGWeb.excel_datatable bll=new TTG.BLL.TTGWeb.excel_datatable();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
