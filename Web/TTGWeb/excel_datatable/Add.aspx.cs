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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtexcel_name.Text.Trim().Length==0)
			{
				strErr+="excel_name不能为空！\\n";	
			}
			if(this.txttable_name.Text.Trim().Length==0)
			{
				strErr+="table_name不能为空！\\n";	
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
			string table_name=this.txttable_name.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
