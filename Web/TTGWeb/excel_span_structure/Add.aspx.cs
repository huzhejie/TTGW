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
namespace TTG.Web.TTGWeb.excel_span_structure
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtproperty.Text.Trim().Length==0)
			{
				strErr+="property不能为空！\\n";	
			}
			if(this.txtexcel_name.Text.Trim().Length==0)
			{
				strErr+="excel_name不能为空！\\n";	
			}
			if(this.txttable_name.Text.Trim().Length==0)
			{
				strErr+="table_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtrow_num.Text))
			{
				strErr+="row_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcolumn_num.Text))
			{
				strErr+="column_num格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string property=this.txtproperty.Text;
			string excel_name=this.txtexcel_name.Text;
			string table_name=this.txttable_name.Text;
			int row_num=int.Parse(this.txtrow_num.Text);
			int column_num=int.Parse(this.txtcolumn_num.Text);

			TTG.Model.TTGWeb.excel_span_structure model=new TTG.Model.TTGWeb.excel_span_structure();
			model.property=property;
			model.excel_name=excel_name;
			model.table_name=table_name;
			model.row_num=row_num;
			model.column_num=column_num;

			TTG.BLL.TTGWeb.excel_span_structure bll=new TTG.BLL.TTGWeb.excel_span_structure();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
