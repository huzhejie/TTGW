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
namespace TTG.Web.TTGWeb.subproject_accomplish_quantity
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string subproject_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					subproject_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(subproject_id,statistics_date);
			}
		}
			
	private void ShowInfo(string subproject_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.subproject_accomplish_quantity bll=new TTG.BLL.TTGWeb.subproject_accomplish_quantity();
		TTG.Model.TTGWeb.subproject_accomplish_quantity model=bll.GetModel(subproject_id,statistics_date);
		this.lblsubproject_id.Text=model.subproject_id;
		this.txtsubproject_name.Text=model.subproject_name;
		this.txtsubproject_finish_quantity.Text=model.subproject_finish_quantity.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttciunset1.Text=model.tciunset1;
		this.txttciunset2.Text=model.tciunset2;
		this.txttciunset3.Text=model.tciunset3;
		this.txttciunset4.Text=model.tciunset4;
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txtlock_tables.Text=model.lock_tables.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtsubproject_name.Text.Trim().Length==0)
			{
				strErr+="subproject_name不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtsubproject_finish_quantity.Text))
			{
				strErr+="subproject_finish_quantity格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttciunset1.Text.Trim().Length==0)
			{
				strErr+="tciunset1不能为空！\\n";	
			}
			if(this.txttciunset2.Text.Trim().Length==0)
			{
				strErr+="tciunset2不能为空！\\n";	
			}
			if(this.txttciunset3.Text.Trim().Length==0)
			{
				strErr+="tciunset3不能为空！\\n";	
			}
			if(this.txttciunset4.Text.Trim().Length==0)
			{
				strErr+="tciunset4不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string subproject_id=this.lblsubproject_id.Text;
			string subproject_name=this.txtsubproject_name.Text;
			decimal subproject_finish_quantity=decimal.Parse(this.txtsubproject_finish_quantity.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);


			TTG.Model.TTGWeb.subproject_accomplish_quantity model=new TTG.Model.TTGWeb.subproject_accomplish_quantity();
			model.subproject_id=subproject_id;
			model.subproject_name=subproject_name;
			model.subproject_finish_quantity=subproject_finish_quantity;
			model.statistics_date=statistics_date;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.check_status=check_status;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.subproject_accomplish_quantity bll=new TTG.BLL.TTGWeb.subproject_accomplish_quantity();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
