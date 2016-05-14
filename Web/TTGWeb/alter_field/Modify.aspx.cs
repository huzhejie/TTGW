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
namespace TTG.Web.TTGWeb.alter_field
{
    public partial class Modify : Page
    {       

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
		this.txtalter_field_name.Text=model.alter_field_name;
		this.txtalter_field_unit.Text=model.alter_field_unit;
		this.txtalter_type.Text=model.alter_type;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtalter_field_name.Text.Trim().Length==0)
			{
				strErr+="alter_field_name不能为空！\\n";	
			}
			if(this.txtalter_field_unit.Text.Trim().Length==0)
			{
				strErr+="alter_field_unit不能为空！\\n";	
			}
			if(this.txtalter_type.Text.Trim().Length==0)
			{
				strErr+="alter_type不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string field_name=this.lblfield_name.Text;
			string table_name=this.lbltable_name.Text;
			string alter_field_name=this.txtalter_field_name.Text;
			string alter_field_unit=this.txtalter_field_unit.Text;
			string alter_type=this.txtalter_type.Text;


			TTG.Model.TTGWeb.alter_field model=new TTG.Model.TTGWeb.alter_field();
			model.field_name=field_name;
			model.table_name=table_name;
			model.alter_field_name=alter_field_name;
			model.alter_field_unit=alter_field_unit;
			model.alter_type=alter_type;

			TTG.BLL.TTGWeb.alter_field bll=new TTG.BLL.TTGWeb.alter_field();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
