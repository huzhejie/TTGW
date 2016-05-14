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
namespace TTG.Web.TTGWeb.community_cultrue_sports_problem_finished
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string community_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					community_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(community_id,statistics_date);
			}
		}
			
	private void ShowInfo(string community_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.community_cultrue_sports_problem_finished bll=new TTG.BLL.TTGWeb.community_cultrue_sports_problem_finished();
		TTG.Model.TTGWeb.community_cultrue_sports_problem_finished model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_otd_exercise_yard_area.Text=model.community_otd_exercise_yard_area.ToString();
		this.txtcommunity_added_fitness_equipment_num.Text=model.community_added_fitness_equipment_num.ToString();
		this.txtcommunity_ind_exercise_yard_area.Text=model.community_ind_exercise_yard_area.ToString();
		this.txtcommunity_added_ind_exercise_yard_faci_num.Text=model.community_added_ind_exercise_yard_faci_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();
		this.txttciunset1.Text=model.tciunset1;
		this.txttciunset2.Text=model.tciunset2;
		this.txttciunset3.Text=model.tciunset3;
		this.txttciunset4.Text=model.tciunset4;
		this.txttciunset5.Text=model.tciunset5;
		this.txttciunset6.Text=model.tciunset6;
		this.txtlock_tables.Text=model.lock_tables.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtcommunity_otd_exercise_yard_area.Text))
			{
				strErr+="community_otd_exercise_yard_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_fitness_equipment_num.Text))
			{
				strErr+="community_added_fitness_equipment_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_ind_exercise_yard_area.Text))
			{
				strErr+="community_ind_exercise_yard_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_added_ind_exercise_yard_faci_num.Text))
			{
				strErr+="community_added_ind_exercise_yard_faci_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
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
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			decimal community_otd_exercise_yard_area=decimal.Parse(this.txtcommunity_otd_exercise_yard_area.Text);
			int community_added_fitness_equipment_num=int.Parse(this.txtcommunity_added_fitness_equipment_num.Text);
			decimal community_ind_exercise_yard_area=decimal.Parse(this.txtcommunity_ind_exercise_yard_area.Text);
			int community_added_ind_exercise_yard_faci_num=int.Parse(this.txtcommunity_added_ind_exercise_yard_faci_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			string tciunset1=this.txttciunset1.Text;
			string tciunset2=this.txttciunset2.Text;
			string tciunset3=this.txttciunset3.Text;
			string tciunset4=this.txttciunset4.Text;
			string tciunset5=this.txttciunset5.Text;
			string tciunset6=this.txttciunset6.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);


			TTG.Model.TTGWeb.community_cultrue_sports_problem_finished model=new TTG.Model.TTGWeb.community_cultrue_sports_problem_finished();
			model.community_id=community_id;
			model.community_otd_exercise_yard_area=community_otd_exercise_yard_area;
			model.community_added_fitness_equipment_num=community_added_fitness_equipment_num;
			model.community_ind_exercise_yard_area=community_ind_exercise_yard_area;
			model.community_added_ind_exercise_yard_faci_num=community_added_ind_exercise_yard_faci_num;
			model.statistics_date=statistics_date;
			model.check_status=check_status;
			model.tciunset1=tciunset1;
			model.tciunset2=tciunset2;
			model.tciunset3=tciunset3;
			model.tciunset4=tciunset4;
			model.tciunset5=tciunset5;
			model.tciunset6=tciunset6;
			model.lock_tables=lock_tables;

			TTG.BLL.TTGWeb.community_cultrue_sports_problem_finished bll=new TTG.BLL.TTGWeb.community_cultrue_sports_problem_finished();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
