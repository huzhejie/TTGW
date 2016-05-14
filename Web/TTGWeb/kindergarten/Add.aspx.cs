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
namespace TTG.Web.TTGWeb.kindergarten
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtcommunity.Text.Trim().Length==0)
			{
				strErr+="community不能为空！\\n";	
			}
			if(this.txttype.Text.Trim().Length==0)
			{
				strErr+="type不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtfloor_space.Text))
			{
				strErr+="floor_space格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtgross_floor_area.Text))
			{
				strErr+="gross_floor_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstudents_amount.Text))
			{
				strErr+="students_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtteachers_amount.Text))
			{
				strErr+="teachers_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtclass_amount.Text))
			{
				strErr+="class_amount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtteachers_students_rate.Text))
			{
				strErr+="teachers_students_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtactivity_room_area.Text))
			{
				strErr+="activity_room_area格式错误！\\n";	
			}
			if(this.txtactivity_room_area_if_suff.Text.Trim().Length==0)
			{
				strErr+="activity_room_area_if_suff不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtotds_activity_room_area.Text))
			{
				strErr+="otds_activity_room_area格式错误！\\n";	
			}
			if(this.txtotds_activity_room_area_if_suff.Text.Trim().Length==0)
			{
				strErr+="otds_activity_room_area_if_suff不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtafforest_area.Text))
			{
				strErr+="afforest_area格式错误！\\n";	
			}
			if(this.txtafforest_area_if_suff.Text.Trim().Length==0)
			{
				strErr+="afforest_area_if_suff不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtschool_bus_amount.Text))
			{
				strErr+="school_bus_amount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpick_up_students_amount_daily.Text))
			{
				strErr+="pick_up_students_amount_daily格式错误！\\n";	
			}
			if(this.txtnote_information.Text.Trim().Length==0)
			{
				strErr+="note_information不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(this.txttkunset1.Text.Trim().Length==0)
			{
				strErr+="tkunset1不能为空！\\n";	
			}
			if(this.txttkunset2.Text.Trim().Length==0)
			{
				strErr+="tkunset2不能为空！\\n";	
			}
			if(this.txttkunset3.Text.Trim().Length==0)
			{
				strErr+="tkunset3不能为空！\\n";	
			}
			if(this.txttkunset4.Text.Trim().Length==0)
			{
				strErr+="tkunset4不能为空！\\n";	
			}
			if(this.txttkunset5.Text.Trim().Length==0)
			{
				strErr+="tkunset5不能为空！\\n";	
			}
			if(this.txttkunset6.Text.Trim().Length==0)
			{
				strErr+="tkunset6不能为空！\\n";	
			}
			if(this.txttkunset7.Text.Trim().Length==0)
			{
				strErr+="tkunset7不能为空！\\n";	
			}
			if(this.txttkunset8.Text.Trim().Length==0)
			{
				strErr+="tkunset8不能为空！\\n";	
			}
			if(this.txttkunset9.Text.Trim().Length==0)
			{
				strErr+="tkunset9不能为空！\\n";	
			}
			if(this.txttkunset10.Text.Trim().Length==0)
			{
				strErr+="tkunset10不能为空！\\n";	
			}
			if(this.txttkunset11.Text.Trim().Length==0)
			{
				strErr+="tkunset11不能为空！\\n";	
			}
			if(this.txttkunset12.Text.Trim().Length==0)
			{
				strErr+="tkunset12不能为空！\\n";	
			}
			if(this.txttkunset13.Text.Trim().Length==0)
			{
				strErr+="tkunset13不能为空！\\n";	
			}
			if(this.txttkunset14.Text.Trim().Length==0)
			{
				strErr+="tkunset14不能为空！\\n";	
			}
			if(this.txttkunset15.Text.Trim().Length==0)
			{
				strErr+="tkunset15不能为空！\\n";	
			}
			if(this.txttkunset16.Text.Trim().Length==0)
			{
				strErr+="tkunset16不能为空！\\n";	
			}
			if(this.txttkunset17.Text.Trim().Length==0)
			{
				strErr+="tkunset17不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string name=this.txtname.Text;
			string community=this.txtcommunity.Text;
			string type=this.txttype.Text;
			decimal floor_space=decimal.Parse(this.txtfloor_space.Text);
			decimal gross_floor_area=decimal.Parse(this.txtgross_floor_area.Text);
			int students_amount=int.Parse(this.txtstudents_amount.Text);
			int teachers_amount=int.Parse(this.txtteachers_amount.Text);
			int class_amount=int.Parse(this.txtclass_amount.Text);
			decimal teachers_students_rate=decimal.Parse(this.txtteachers_students_rate.Text);
			decimal activity_room_area=decimal.Parse(this.txtactivity_room_area.Text);
			string activity_room_area_if_suff=this.txtactivity_room_area_if_suff.Text;
			decimal otds_activity_room_area=decimal.Parse(this.txtotds_activity_room_area.Text);
			string otds_activity_room_area_if_suff=this.txtotds_activity_room_area_if_suff.Text;
			decimal afforest_area=decimal.Parse(this.txtafforest_area.Text);
			string afforest_area_if_suff=this.txtafforest_area_if_suff.Text;
			int school_bus_amount=int.Parse(this.txtschool_bus_amount.Text);
			decimal pick_up_students_amount_daily=decimal.Parse(this.txtpick_up_students_amount_daily.Text);
			string note_information=this.txtnote_information.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			string tkunset1=this.txttkunset1.Text;
			string tkunset2=this.txttkunset2.Text;
			string tkunset3=this.txttkunset3.Text;
			string tkunset4=this.txttkunset4.Text;
			string tkunset5=this.txttkunset5.Text;
			string tkunset6=this.txttkunset6.Text;
			string tkunset7=this.txttkunset7.Text;
			string tkunset8=this.txttkunset8.Text;
			string tkunset9=this.txttkunset9.Text;
			string tkunset10=this.txttkunset10.Text;
			string tkunset11=this.txttkunset11.Text;
			string tkunset12=this.txttkunset12.Text;
			string tkunset13=this.txttkunset13.Text;
			string tkunset14=this.txttkunset14.Text;
			string tkunset15=this.txttkunset15.Text;
			string tkunset16=this.txttkunset16.Text;
			string tkunset17=this.txttkunset17.Text;

			TTG.Model.TTGWeb.kindergarten model=new TTG.Model.TTGWeb.kindergarten();
			model.name=name;
			model.community=community;
			model.type=type;
			model.floor_space=floor_space;
			model.gross_floor_area=gross_floor_area;
			model.students_amount=students_amount;
			model.teachers_amount=teachers_amount;
			model.class_amount=class_amount;
			model.teachers_students_rate=teachers_students_rate;
			model.activity_room_area=activity_room_area;
			model.activity_room_area_if_suff=activity_room_area_if_suff;
			model.otds_activity_room_area=otds_activity_room_area;
			model.otds_activity_room_area_if_suff=otds_activity_room_area_if_suff;
			model.afforest_area=afforest_area;
			model.afforest_area_if_suff=afforest_area_if_suff;
			model.school_bus_amount=school_bus_amount;
			model.pick_up_students_amount_daily=pick_up_students_amount_daily;
			model.note_information=note_information;
			model.statistics_date=statistics_date;
			model.lock_tables=lock_tables;
			model.check_status=check_status;
			model.tkunset1=tkunset1;
			model.tkunset2=tkunset2;
			model.tkunset3=tkunset3;
			model.tkunset4=tkunset4;
			model.tkunset5=tkunset5;
			model.tkunset6=tkunset6;
			model.tkunset7=tkunset7;
			model.tkunset8=tkunset8;
			model.tkunset9=tkunset9;
			model.tkunset10=tkunset10;
			model.tkunset11=tkunset11;
			model.tkunset12=tkunset12;
			model.tkunset13=tkunset13;
			model.tkunset14=tkunset14;
			model.tkunset15=tkunset15;
			model.tkunset16=tkunset16;
			model.tkunset17=tkunset17;

			TTG.BLL.TTGWeb.kindergarten bll=new TTG.BLL.TTGWeb.kindergarten();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
