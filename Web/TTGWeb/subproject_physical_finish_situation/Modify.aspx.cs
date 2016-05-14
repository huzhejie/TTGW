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
namespace TTG.Web.TTGWeb.subproject_physical_finish_situation
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
		TTG.BLL.TTGWeb.subproject_physical_finish_situation bll=new TTG.BLL.TTGWeb.subproject_physical_finish_situation();
		TTG.Model.TTGWeb.subproject_physical_finish_situation model=bll.GetModel(subproject_id,statistics_date);
		this.lblsubproject_id.Text=model.subproject_id;
		this.txtsubproject_no.Text=model.subproject_no;
		this.txtsubproject_name.Text=model.subproject_name;
		this.txtcounty_name.Text=model.county_name;
		this.txtproject_name.Text=model.project_name;
		this.txtsubproject_category.Text=model.subproject_category;
		this.txtcommunity.Text=model.community;
		this.txtphysical_class.Text=model.physical_class;
		this.txtphysical_subclass.Text=model.physical_subclass;
		this.txtphysical_class_content.Text=model.physical_class_content;
		this.txtplan_quantity.Text=model.plan_quantity.ToString();
		this.txtnote_information.Text=model.note_information;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttciunset1.Text=model.tciunset1;
		this.txttciunset2.Text=model.tciunset2;
		this.txttciunset3.Text=model.tciunset3;
		this.txttciunset4.Text=model.tciunset4;
		this.txttciunset5.Text=model.tciunset5;
		this.txttciunset6.Text=model.tciunset6;
		this.txttciunset7.Text=model.tciunset7;
		this.txttciunset8.Text=model.tciunset8;
		this.txttciunset9.Text=model.tciunset9;
		this.txttciunset10.Text=model.tciunset10;
		this.txttciunset11.Text=model.tciunset11;
		this.txttciunset12.Text=model.tciunset12;
		this.txttciunset13.Text=model.tciunset13;
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txtlock_tables.Text=model.lock_tables.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtsubproject_no.Text.Trim().Length==0)
			{
				strErr+="subproject_no不能为空！\\n";	
			}
			if(this.txtsubproject_name.Text.Trim().Length==0)
			{
				strErr+="subproject_name不能为空！\\n";	
			}
			if(this.txtcounty_name.Text.Trim().Length==0)
			{
				strErr+="county_name不能为空！\\n";	
			}
			if(this.txtproject_name.Text.Trim().Length==0)
			{
				strErr+="project_name不能为空！\\n";	
			}
			if(this.txtsubproject_category.Text.Trim().Length==0)
			{
				strErr+="subproject_category不能为空！\\n";	
			}
			if(this.txtcommunity.Text.Trim().Length==0)
			{
				strErr+="community不能为空！\\n";	
			}
			if(this.txtphysical_class.Text.Trim().Length==0)
			{
				strErr+="physical_class不能为空！\\n";	
			}
			if(this.txtphysical_subclass.Text.Trim().Length==0)
			{
				strErr+="physical_subclass不能为空！\\n";	
			}
			if(this.txtphysical_class_content.Text.Trim().Length==0)
			{
				strErr+="physical_class_content不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtplan_quantity.Text))
			{
				strErr+="plan_quantity格式错误！\\n";	
			}
			if(this.txtnote_information.Text.Trim().Length==0)
			{
				strErr+="note_information不能为空！\\n";	
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
			if(this.txttciunset5.Text.Trim().Length==0)
			{
				strErr+="tciunset5不能为空！\\n";	
			}
			if(this.txttciunset6.Text.Trim().Length==0)
			{
				strErr+="tciunset6不能为空！\\n";	
			}
			if(this.txttciunset7.Text.Trim().Length==0)
			{
				strErr+="tciunset7不能为空！\\n";	
			}
			if(this.txttciunset8.Text.Trim().Length==0)
			{
				strErr+="tciunset8不能为空！\\n";	
			}
			if(this.txttciunset9.Text.Trim().Length==0)
			{
				strErr+="tciunset9不能为空！\\n";	
			}
			if(this.txttciunset10.Text.Trim().Length==0)
			{
				strErr+="tciunset10不能为空！\\n";	
			}
			if(this.txttciunset11.Text.Trim().Length==0)
			{
				strErr+="tciunset11不能为空！\\n";	
			}
			if(this.txttciunset12.Text.Trim().Length==0)
			{
				strErr+="tciunset12不能为空！\\n";	
			}
			if(this.txttciunset13.Text.Trim().Length==0)
			{
				strErr+="tciunset13不能为空！\\n";	
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
			string subproject_no=this.txtsubproject_no.Text;
			string subproject_name=this.txtsubproject_name.Text;
			string county_name=this.txtcounty_name.Text;
			string project_name=this.txtproject_name.Text;
			string subproject_category=this.txtsubproject_category.Text;
			string community=this.txtcommunity.Text;
			string physical_class=this.txtphysical_class.Text;
			string physical_subclass=this.txtphysical_subclass.Text;
			string physical_class_content=this.txtphysical_class_content.Text;
			decimal plan_quantity=decimal.Parse(this.txtplan_quantity.Text);
			string note_information=this.txtnote_information.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			string tciunset5=this.txttciunset5.Text;
			string tciunset6=this.txttciunset6.Text;
			string tciunset7=this.txttciunset7.Text;
			string tciunset8=this.txttciunset8.Text;
			string tciunset9=this.txttciunset9.Text;
			string tciunset10=this.txttciunset10.Text;
			string tciunset11=this.txttciunset11.Text;
			string tciunset12=this.txttciunset12.Text;
			string tciunset13=this.txttciunset13.Text;
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);


			TTG.Model.TTGWeb.subproject_physical_finish_situation model=new TTG.Model.TTGWeb.subproject_physical_finish_situation();
			model.subproject_id=subproject_id;
			model.subproject_no=subproject_no;
			model.subproject_name=subproject_name;
			model.county_name=county_name;
			model.project_name=project_name;
			model.subproject_category=subproject_category;
			model.community=community;
			model.physical_class=physical_class;
			model.physical_subclass=physical_subclass;
			model.physical_class_content=physical_class_content;
			model.plan_quantity=plan_quantity;
			model.note_information=note_information;
			model.statistics_date=statistics_date;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.tciunset5=tciunset5;
			model.tciunset6=tciunset6;
			model.tciunset7=tciunset7;
			model.tciunset8=tciunset8;
			model.tciunset9=tciunset9;
			model.tciunset10=tciunset10;
			model.tciunset11=tciunset11;
			model.tciunset12=tciunset12;
			model.tciunset13=tciunset13;
			model.check_status=check_status;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.subproject_physical_finish_situation bll=new TTG.BLL.TTGWeb.subproject_physical_finish_situation();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
