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
namespace TTG.Web.TTGWeb.community_fire_fighting
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
		TTG.BLL.TTGWeb.community_fire_fighting bll=new TTG.BLL.TTGWeb.community_fire_fighting();
		TTG.Model.TTGWeb.community_fire_fighting model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_extinguisher_num.Text=model.community_extinguisher_num.ToString();
		this.txtcommunity_good_extinguisher_rate.Text=model.community_good_extinguisher_rate.ToString();
		this.txtcommunity_hydrant_num.Text=model.community_hydrant_num.ToString();
		this.txtcommunity_ots_hydrant_num.Text=model.community_ots_hydrant_num.ToString();
		this.txtcommunity_good_ots_hydrant_rate.Text=model.community_good_ots_hydrant_rate.ToString();
		this.txtcommunity_ind_hydrant_num.Text=model.community_ind_hydrant_num.ToString();
		this.txtcommunity_good_ind_hydrant_rate.Text=model.community_good_ind_hydrant_rate.ToString();
		this.txtcommunity_ff_pipe_length.Text=model.community_ff_pipe_length.ToString();
		this.txtcommunity_ff_pipe_caliber_larger_than_100mm_length.Text=model.community_ff_pipe_caliber_larger_than_100mm_length.ToString();
		this.txtcommunity_ff_pipe_caliber_less_than_100mm_length.Text=model.community_ff_pipe_caliber_less_than_100mm_length.ToString();
		this.txtsource_of_ff_water_num.Text=model.source_of_ff_water_num.ToString();
		this.txtnatural_ff_water_source_num.Text=model.natural_ff_water_source_num.ToString();
		this.txtmunicipal_administration_pipe_net_ff_water_source.Text=model.municipal_administration_pipe_net_ff_water_source.ToString();
		this.txtff_water_pool_num.Text=model.ff_water_pool_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttcffunset1.Text=model.tcffunset1;
		this.txttcffunset2.Text=model.tcffunset2;
		this.txttcffunset3.Text=model.tcffunset3;
		this.txttcffunset4.Text=model.tcffunset4;
		this.txttcffunset5.Text=model.tcffunset5;
		this.txttcffunset6.Text=model.tcffunset6;
		this.txttcffunset7.Text=model.tcffunset7;
		this.txttcffunset8.Text=model.tcffunset8;
		this.txttcffunset9.Text=model.tcffunset9;
		this.txttcffunset10.Text=model.tcffunset10;
		this.txttcffunset11.Text=model.tcffunset11;
		this.txttcffunset12.Text=model.tcffunset12;
		this.txttcffunset13.Text=model.tcffunset13;
		this.txttcffunset14.Text=model.tcffunset14;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommunity_extinguisher_num.Text))
			{
				strErr+="community_extinguisher_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_good_extinguisher_rate.Text))
			{
				strErr+="community_good_extinguisher_rate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_hydrant_num.Text))
			{
				strErr+="community_hydrant_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_ots_hydrant_num.Text))
			{
				strErr+="community_ots_hydrant_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_good_ots_hydrant_rate.Text))
			{
				strErr+="community_good_ots_hydrant_rate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_ind_hydrant_num.Text))
			{
				strErr+="community_ind_hydrant_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_good_ind_hydrant_rate.Text))
			{
				strErr+="community_good_ind_hydrant_rate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_ff_pipe_length.Text))
			{
				strErr+="community_ff_pipe_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_ff_pipe_caliber_larger_than_100mm_length.Text))
			{
				strErr+="community_ff_pipe_caliber_larger_than_100mm_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_ff_pipe_caliber_less_than_100mm_length.Text))
			{
				strErr+="community_ff_pipe_caliber_less_than_100mm_length格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsource_of_ff_water_num.Text))
			{
				strErr+="source_of_ff_water_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnatural_ff_water_source_num.Text))
			{
				strErr+="natural_ff_water_source_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtmunicipal_administration_pipe_net_ff_water_source.Text))
			{
				strErr+="municipal_administration_pipe_net_ff_water_source格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtff_water_pool_num.Text))
			{
				strErr+="ff_water_pool_num格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttcffunset1.Text.Trim().Length==0)
			{
				strErr+="tcffunset1不能为空！\\n";	
			}
			if(this.txttcffunset2.Text.Trim().Length==0)
			{
				strErr+="tcffunset2不能为空！\\n";	
			}
			if(this.txttcffunset3.Text.Trim().Length==0)
			{
				strErr+="tcffunset3不能为空！\\n";	
			}
			if(this.txttcffunset4.Text.Trim().Length==0)
			{
				strErr+="tcffunset4不能为空！\\n";	
			}
			if(this.txttcffunset5.Text.Trim().Length==0)
			{
				strErr+="tcffunset5不能为空！\\n";	
			}
			if(this.txttcffunset6.Text.Trim().Length==0)
			{
				strErr+="tcffunset6不能为空！\\n";	
			}
			if(this.txttcffunset7.Text.Trim().Length==0)
			{
				strErr+="tcffunset7不能为空！\\n";	
			}
			if(this.txttcffunset8.Text.Trim().Length==0)
			{
				strErr+="tcffunset8不能为空！\\n";	
			}
			if(this.txttcffunset9.Text.Trim().Length==0)
			{
				strErr+="tcffunset9不能为空！\\n";	
			}
			if(this.txttcffunset10.Text.Trim().Length==0)
			{
				strErr+="tcffunset10不能为空！\\n";	
			}
			if(this.txttcffunset11.Text.Trim().Length==0)
			{
				strErr+="tcffunset11不能为空！\\n";	
			}
			if(this.txttcffunset12.Text.Trim().Length==0)
			{
				strErr+="tcffunset12不能为空！\\n";	
			}
			if(this.txttcffunset13.Text.Trim().Length==0)
			{
				strErr+="tcffunset13不能为空！\\n";	
			}
			if(this.txttcffunset14.Text.Trim().Length==0)
			{
				strErr+="tcffunset14不能为空！\\n";	
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
			string community_id=this.lblcommunity_id.Text;
			int community_extinguisher_num=int.Parse(this.txtcommunity_extinguisher_num.Text);
			decimal community_good_extinguisher_rate=decimal.Parse(this.txtcommunity_good_extinguisher_rate.Text);
			int community_hydrant_num=int.Parse(this.txtcommunity_hydrant_num.Text);
			int community_ots_hydrant_num=int.Parse(this.txtcommunity_ots_hydrant_num.Text);
			decimal community_good_ots_hydrant_rate=decimal.Parse(this.txtcommunity_good_ots_hydrant_rate.Text);
			int community_ind_hydrant_num=int.Parse(this.txtcommunity_ind_hydrant_num.Text);
			decimal community_good_ind_hydrant_rate=decimal.Parse(this.txtcommunity_good_ind_hydrant_rate.Text);
			decimal community_ff_pipe_length=decimal.Parse(this.txtcommunity_ff_pipe_length.Text);
			decimal community_ff_pipe_caliber_larger_than_100mm_length=decimal.Parse(this.txtcommunity_ff_pipe_caliber_larger_than_100mm_length.Text);
			decimal community_ff_pipe_caliber_less_than_100mm_length=decimal.Parse(this.txtcommunity_ff_pipe_caliber_less_than_100mm_length.Text);
			int source_of_ff_water_num=int.Parse(this.txtsource_of_ff_water_num.Text);
			int natural_ff_water_source_num=int.Parse(this.txtnatural_ff_water_source_num.Text);
			int municipal_administration_pipe_net_ff_water_source=int.Parse(this.txtmunicipal_administration_pipe_net_ff_water_source.Text);
			int ff_water_pool_num=int.Parse(this.txtff_water_pool_num.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tcffunset1=this.txttcffunset1.Text;
			string tcffunset2=this.txttcffunset2.Text;
			string tcffunset3=this.txttcffunset3.Text;
			string tcffunset4=this.txttcffunset4.Text;
			string tcffunset5=this.txttcffunset5.Text;
			string tcffunset6=this.txttcffunset6.Text;
			string tcffunset7=this.txttcffunset7.Text;
			string tcffunset8=this.txttcffunset8.Text;
			string tcffunset9=this.txttcffunset9.Text;
			string tcffunset10=this.txttcffunset10.Text;
			string tcffunset11=this.txttcffunset11.Text;
			string tcffunset12=this.txttcffunset12.Text;
			string tcffunset13=this.txttcffunset13.Text;
			string tcffunset14=this.txttcffunset14.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);


			TTG.Model.TTGWeb.community_fire_fighting model=new TTG.Model.TTGWeb.community_fire_fighting();
			model.community_id=community_id;
			model.community_extinguisher_num=community_extinguisher_num;
			model.community_good_extinguisher_rate=community_good_extinguisher_rate;
			model.community_hydrant_num=community_hydrant_num;
			model.community_ots_hydrant_num=community_ots_hydrant_num;
			model.community_good_ots_hydrant_rate=community_good_ots_hydrant_rate;
			model.community_ind_hydrant_num=community_ind_hydrant_num;
			model.community_good_ind_hydrant_rate=community_good_ind_hydrant_rate;
			model.community_ff_pipe_length=community_ff_pipe_length;
			model.community_ff_pipe_caliber_larger_than_100mm_length=community_ff_pipe_caliber_larger_than_100mm_length;
			model.community_ff_pipe_caliber_less_than_100mm_length=community_ff_pipe_caliber_less_than_100mm_length;
			model.source_of_ff_water_num=source_of_ff_water_num;
			model.natural_ff_water_source_num=natural_ff_water_source_num;
			model.municipal_administration_pipe_net_ff_water_source=municipal_administration_pipe_net_ff_water_source;
			model.ff_water_pool_num=ff_water_pool_num;
			model.statistics_date=statistics_date;
			model.tcffunset1=tcffunset1;
			model.tcffunset2=tcffunset2;
			model.tcffunset3=tcffunset3;
			model.tcffunset4=tcffunset4;
			model.tcffunset5=tcffunset5;
			model.tcffunset6=tcffunset6;
			model.tcffunset7=tcffunset7;
			model.tcffunset8=tcffunset8;
			model.tcffunset9=tcffunset9;
			model.tcffunset10=tcffunset10;
			model.tcffunset11=tcffunset11;
			model.tcffunset12=tcffunset12;
			model.tcffunset13=tcffunset13;
			model.tcffunset14=tcffunset14;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_fire_fighting bll=new TTG.BLL.TTGWeb.community_fire_fighting();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
