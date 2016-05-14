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
namespace TTG.Web.TTGWeb.community_education
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcommunity_id.Text.Trim().Length==0)
			{
				strErr+="community_id不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_edu_inst_num.Text))
			{
				strErr+="community_edu_inst_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_edu_fs.Text))
			{
				strErr+="community_edu_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_edu_gfa.Text))
			{
				strErr+="community_edu_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_kdg_num.Text))
			{
				strErr+="community_kdg_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_pri_kdg_num.Text))
			{
				strErr+="community_pri_kdg_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_kdg_fs.Text))
			{
				strErr+="community_kdg_fs格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_kdg_gfa.Text))
			{
				strErr+="community_kdg_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_kdg_stu_num.Text))
			{
				strErr+="community_kdg_stu_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_kdg_class_num.Text))
			{
				strErr+="community_kdg_class_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_kdg_actv_room_area.Text))
			{
				strErr+="community_kdg_actv_room_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_kdg_otd_actv_spa_area.Text))
			{
				strErr+="community_kdg_otd_actv_spa_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_kdg_greenland_area.Text))
			{
				strErr+="community_kdg_greenland_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_kdg_dist_ots.Text))
			{
				strErr+="community_kdg_dist_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_prim_school_num.Text))
			{
				strErr+="community_prim_school_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_prim_school_gfa.Text))
			{
				strErr+="community_prim_school_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_prim_school_fs.Text))
			{
				strErr+="community_prim_school_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_prim_school_stu_num.Text))
			{
				strErr+="community_prim_school_stu_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_prim_school_class_num.Text))
			{
				strErr+="community_prim_school_class_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_prim_school_plg_area.Text))
			{
				strErr+="community_prim_school_plg_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_prim_school_dist_ots.Text))
			{
				strErr+="community_prim_school_dist_ots格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_mid_school_num.Text))
			{
				strErr+="community_mid_school_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_mid_school_gfa.Text))
			{
				strErr+="community_mid_school_gfa格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_mid_school_fs.Text))
			{
				strErr+="community_mid_school_fs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_mid_school_stu_num.Text))
			{
				strErr+="community_mid_school_stu_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_mid_school_class_num.Text))
			{
				strErr+="community_mid_school_class_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_mid_school_plg_area.Text))
			{
				strErr+="community_mid_school_plg_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_mid_school_dist_ots.Text))
			{
				strErr+="community_mid_school_dist_ots格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttceunset1.Text.Trim().Length==0)
			{
				strErr+="tceunset1不能为空！\\n";	
			}
			if(this.txttceunset2.Text.Trim().Length==0)
			{
				strErr+="tceunset2不能为空！\\n";	
			}
			if(this.txttceunset3.Text.Trim().Length==0)
			{
				strErr+="tceunset3不能为空！\\n";	
			}
			if(this.txttceunset4.Text.Trim().Length==0)
			{
				strErr+="tceunset4不能为空！\\n";	
			}
			if(this.txttceunset5.Text.Trim().Length==0)
			{
				strErr+="tceunset5不能为空！\\n";	
			}
			if(this.txttceunset6.Text.Trim().Length==0)
			{
				strErr+="tceunset6不能为空！\\n";	
			}
			if(this.txttceunset7.Text.Trim().Length==0)
			{
				strErr+="tceunset7不能为空！\\n";	
			}
			if(this.txttceunset8.Text.Trim().Length==0)
			{
				strErr+="tceunset8不能为空！\\n";	
			}
			if(this.txttceunset9.Text.Trim().Length==0)
			{
				strErr+="tceunset9不能为空！\\n";	
			}
			if(this.txttceunset10.Text.Trim().Length==0)
			{
				strErr+="tceunset10不能为空！\\n";	
			}
			if(this.txttceunset11.Text.Trim().Length==0)
			{
				strErr+="tceunset11不能为空！\\n";	
			}
			if(this.txttceunset12.Text.Trim().Length==0)
			{
				strErr+="tceunset12不能为空！\\n";	
			}
			if(this.txttceunset13.Text.Trim().Length==0)
			{
				strErr+="tceunset13不能为空！\\n";	
			}
			if(this.txttceunset14.Text.Trim().Length==0)
			{
				strErr+="tceunset14不能为空！\\n";	
			}
			if(this.txttceunset15.Text.Trim().Length==0)
			{
				strErr+="tceunset15不能为空！\\n";	
			}
			if(this.txttceunset16.Text.Trim().Length==0)
			{
				strErr+="tceunset16不能为空！\\n";	
			}
			if(this.txttceunset17.Text.Trim().Length==0)
			{
				strErr+="tceunset17不能为空！\\n";	
			}
			if(this.txttceunset18.Text.Trim().Length==0)
			{
				strErr+="tceunset18不能为空！\\n";	
			}
			if(this.txttceunset19.Text.Trim().Length==0)
			{
				strErr+="tceunset19不能为空！\\n";	
			}
			if(this.txttceunset20.Text.Trim().Length==0)
			{
				strErr+="tceunset20不能为空！\\n";	
			}
			if(this.txttceunset21.Text.Trim().Length==0)
			{
				strErr+="tceunset21不能为空！\\n";	
			}
			if(this.txttceunset22.Text.Trim().Length==0)
			{
				strErr+="tceunset22不能为空！\\n";	
			}
			if(this.txttceunset23.Text.Trim().Length==0)
			{
				strErr+="tceunset23不能为空！\\n";	
			}
			if(this.txttceunset24.Text.Trim().Length==0)
			{
				strErr+="tceunset24不能为空！\\n";	
			}
			if(this.txttceunset25.Text.Trim().Length==0)
			{
				strErr+="tceunset25不能为空！\\n";	
			}
			if(this.txttceunset26.Text.Trim().Length==0)
			{
				strErr+="tceunset26不能为空！\\n";	
			}
			if(this.txttceunset27.Text.Trim().Length==0)
			{
				strErr+="tceunset27不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.txtcommunity_id.Text;
			int community_edu_inst_num=int.Parse(this.txtcommunity_edu_inst_num.Text);
			decimal community_edu_fs=decimal.Parse(this.txtcommunity_edu_fs.Text);
			decimal community_edu_gfa=decimal.Parse(this.txtcommunity_edu_gfa.Text);
			int community_kdg_num=int.Parse(this.txtcommunity_kdg_num.Text);
			int community_pri_kdg_num=int.Parse(this.txtcommunity_pri_kdg_num.Text);
			decimal community_kdg_fs=decimal.Parse(this.txtcommunity_kdg_fs.Text);
			decimal community_kdg_gfa=decimal.Parse(this.txtcommunity_kdg_gfa.Text);
			int community_kdg_stu_num=int.Parse(this.txtcommunity_kdg_stu_num.Text);
			int community_kdg_class_num=int.Parse(this.txtcommunity_kdg_class_num.Text);
			decimal community_kdg_actv_room_area=decimal.Parse(this.txtcommunity_kdg_actv_room_area.Text);
			decimal community_kdg_otd_actv_spa_area=decimal.Parse(this.txtcommunity_kdg_otd_actv_spa_area.Text);
			decimal community_kdg_greenland_area=decimal.Parse(this.txtcommunity_kdg_greenland_area.Text);
			decimal community_kdg_dist_ots=decimal.Parse(this.txtcommunity_kdg_dist_ots.Text);
			int community_prim_school_num=int.Parse(this.txtcommunity_prim_school_num.Text);
			decimal community_prim_school_gfa=decimal.Parse(this.txtcommunity_prim_school_gfa.Text);
			decimal community_prim_school_fs=decimal.Parse(this.txtcommunity_prim_school_fs.Text);
			int community_prim_school_stu_num=int.Parse(this.txtcommunity_prim_school_stu_num.Text);
			int community_prim_school_class_num=int.Parse(this.txtcommunity_prim_school_class_num.Text);
			decimal community_prim_school_plg_area=decimal.Parse(this.txtcommunity_prim_school_plg_area.Text);
			decimal community_prim_school_dist_ots=decimal.Parse(this.txtcommunity_prim_school_dist_ots.Text);
			int community_mid_school_num=int.Parse(this.txtcommunity_mid_school_num.Text);
			decimal community_mid_school_gfa=decimal.Parse(this.txtcommunity_mid_school_gfa.Text);
			decimal community_mid_school_fs=decimal.Parse(this.txtcommunity_mid_school_fs.Text);
			int community_mid_school_stu_num=int.Parse(this.txtcommunity_mid_school_stu_num.Text);
			int community_mid_school_class_num=int.Parse(this.txtcommunity_mid_school_class_num.Text);
			decimal community_mid_school_plg_area=decimal.Parse(this.txtcommunity_mid_school_plg_area.Text);
			decimal community_mid_school_dist_ots=decimal.Parse(this.txtcommunity_mid_school_dist_ots.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tceunset1=this.txttceunset1.Text;
			string tceunset2=this.txttceunset2.Text;
			string tceunset3=this.txttceunset3.Text;
			string tceunset4=this.txttceunset4.Text;
			string tceunset5=this.txttceunset5.Text;
			string tceunset6=this.txttceunset6.Text;
			string tceunset7=this.txttceunset7.Text;
			string tceunset8=this.txttceunset8.Text;
			string tceunset9=this.txttceunset9.Text;
			string tceunset10=this.txttceunset10.Text;
			string tceunset11=this.txttceunset11.Text;
			string tceunset12=this.txttceunset12.Text;
			string tceunset13=this.txttceunset13.Text;
			string tceunset14=this.txttceunset14.Text;
			string tceunset15=this.txttceunset15.Text;
			string tceunset16=this.txttceunset16.Text;
			string tceunset17=this.txttceunset17.Text;
			string tceunset18=this.txttceunset18.Text;
			string tceunset19=this.txttceunset19.Text;
			string tceunset20=this.txttceunset20.Text;
			string tceunset21=this.txttceunset21.Text;
			string tceunset22=this.txttceunset22.Text;
			string tceunset23=this.txttceunset23.Text;
			string tceunset24=this.txttceunset24.Text;
			string tceunset25=this.txttceunset25.Text;
			string tceunset26=this.txttceunset26.Text;
			string tceunset27=this.txttceunset27.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.community_education model=new TTG.Model.TTGWeb.community_education();
			model.community_id=community_id;
			model.community_edu_inst_num=community_edu_inst_num;
			model.community_edu_fs=community_edu_fs;
			model.community_edu_gfa=community_edu_gfa;
			model.community_kdg_num=community_kdg_num;
			model.community_pri_kdg_num=community_pri_kdg_num;
			model.community_kdg_fs=community_kdg_fs;
			model.community_kdg_gfa=community_kdg_gfa;
			model.community_kdg_stu_num=community_kdg_stu_num;
			model.community_kdg_class_num=community_kdg_class_num;
			model.community_kdg_actv_room_area=community_kdg_actv_room_area;
			model.community_kdg_otd_actv_spa_area=community_kdg_otd_actv_spa_area;
			model.community_kdg_greenland_area=community_kdg_greenland_area;
			model.community_kdg_dist_ots=community_kdg_dist_ots;
			model.community_prim_school_num=community_prim_school_num;
			model.community_prim_school_gfa=community_prim_school_gfa;
			model.community_prim_school_fs=community_prim_school_fs;
			model.community_prim_school_stu_num=community_prim_school_stu_num;
			model.community_prim_school_class_num=community_prim_school_class_num;
			model.community_prim_school_plg_area=community_prim_school_plg_area;
			model.community_prim_school_dist_ots=community_prim_school_dist_ots;
			model.community_mid_school_num=community_mid_school_num;
			model.community_mid_school_gfa=community_mid_school_gfa;
			model.community_mid_school_fs=community_mid_school_fs;
			model.community_mid_school_stu_num=community_mid_school_stu_num;
			model.community_mid_school_class_num=community_mid_school_class_num;
			model.community_mid_school_plg_area=community_mid_school_plg_area;
			model.community_mid_school_dist_ots=community_mid_school_dist_ots;
			model.statistics_date=statistics_date;
			model.tceunset1=tceunset1;
			model.tceunset2=tceunset2;
			model.tceunset3=tceunset3;
			model.tceunset4=tceunset4;
			model.tceunset5=tceunset5;
			model.tceunset6=tceunset6;
			model.tceunset7=tceunset7;
			model.tceunset8=tceunset8;
			model.tceunset9=tceunset9;
			model.tceunset10=tceunset10;
			model.tceunset11=tceunset11;
			model.tceunset12=tceunset12;
			model.tceunset13=tceunset13;
			model.tceunset14=tceunset14;
			model.tceunset15=tceunset15;
			model.tceunset16=tceunset16;
			model.tceunset17=tceunset17;
			model.tceunset18=tceunset18;
			model.tceunset19=tceunset19;
			model.tceunset20=tceunset20;
			model.tceunset21=tceunset21;
			model.tceunset22=tceunset22;
			model.tceunset23=tceunset23;
			model.tceunset24=tceunset24;
			model.tceunset25=tceunset25;
			model.tceunset26=tceunset26;
			model.tceunset27=tceunset27;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_education bll=new TTG.BLL.TTGWeb.community_education();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
