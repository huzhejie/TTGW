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
namespace TTG.Web.TTGWeb.road
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtid.Text.Trim().Length==0)
			{
				strErr+="id不能为空！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtcommunity.Text.Trim().Length==0)
			{
				strErr+="community不能为空！\\n";	
			}
			if(this.txtroad_class.Text.Trim().Length==0)
			{
				strErr+="road_class不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtwidth.Text))
			{
				strErr+="width格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpavement_width.Text))
			{
				strErr+="pavement_width格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_road_length.Text))
			{
				strErr+="community_road_length格式错误！\\n";	
			}
			if(this.txtstructure.Text.Trim().Length==0)
			{
				strErr+="structure不能为空！\\n";	
			}
			if(this.txtis_dead_end_road.Text.Trim().Length==0)
			{
				strErr+="is_dead_end_road不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdamage_road_length.Text))
			{
				strErr+="damage_road_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlarge_slope_road_length.Text))
			{
				strErr+="large_slope_road_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_hard_road_length.Text))
			{
				strErr+="no_hard_road_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlack_width_road_length.Text))
			{
				strErr+="lack_width_road_length格式错误！\\n";	
			}
			if(this.txtis_somewhere_no_link.Text.Trim().Length==0)
			{
				strErr+="is_somewhere_no_link不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtno_afforest_road_length.Text))
			{
				strErr+="no_afforest_road_length格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtless_afforest_road_length.Text))
			{
				strErr+="less_afforest_road_length格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstreet_light_amount.Text))
			{
				strErr+="street_light_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtgood_street_light_amount.Text))
			{
				strErr+="good_street_light_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtroad_hydrant_amount.Text))
			{
				strErr+="road_hydrant_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtgood_road_hydrant_amount.Text))
			{
				strErr+="good_road_hydrant_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtroad_dustbin_amount.Text))
			{
				strErr+="road_dustbin_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtgood_road_dustbin_amount.Text))
			{
				strErr+="good_road_dustbin_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtroad_parking_space_num.Text))
			{
				strErr+="road_parking_space_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtparking_space_use_rate.Text))
			{
				strErr+="parking_space_use_rate格式错误！\\n";	
			}
			if(this.txtnote_information.Text.Trim().Length==0)
			{
				strErr+="note_information不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(this.txttrunset1.Text.Trim().Length==0)
			{
				strErr+="trunset1不能为空！\\n";	
			}
			if(this.txttrunset2.Text.Trim().Length==0)
			{
				strErr+="trunset2不能为空！\\n";	
			}
			if(this.txttrunset3.Text.Trim().Length==0)
			{
				strErr+="trunset3不能为空！\\n";	
			}
			if(this.txttrunset4.Text.Trim().Length==0)
			{
				strErr+="trunset4不能为空！\\n";	
			}
			if(this.txttrunset5.Text.Trim().Length==0)
			{
				strErr+="trunset5不能为空！\\n";	
			}
			if(this.txttrunset6.Text.Trim().Length==0)
			{
				strErr+="trunset6不能为空！\\n";	
			}
			if(this.txttrunset7.Text.Trim().Length==0)
			{
				strErr+="trunset7不能为空！\\n";	
			}
			if(this.txttrunset8.Text.Trim().Length==0)
			{
				strErr+="trunset8不能为空！\\n";	
			}
			if(this.txttrunset9.Text.Trim().Length==0)
			{
				strErr+="trunset9不能为空！\\n";	
			}
			if(this.txttrunset10.Text.Trim().Length==0)
			{
				strErr+="trunset10不能为空！\\n";	
			}
			if(this.txttrunset11.Text.Trim().Length==0)
			{
				strErr+="trunset11不能为空！\\n";	
			}
			if(this.txttrunset12.Text.Trim().Length==0)
			{
				strErr+="trunset12不能为空！\\n";	
			}
			if(this.txttrunset13.Text.Trim().Length==0)
			{
				strErr+="trunset13不能为空！\\n";	
			}
			if(this.txttrunset14.Text.Trim().Length==0)
			{
				strErr+="trunset14不能为空！\\n";	
			}
			if(this.txttrunset15.Text.Trim().Length==0)
			{
				strErr+="trunset15不能为空！\\n";	
			}
			if(this.txttrunset16.Text.Trim().Length==0)
			{
				strErr+="trunset16不能为空！\\n";	
			}
			if(this.txttrunset17.Text.Trim().Length==0)
			{
				strErr+="trunset17不能为空！\\n";	
			}
			if(this.txttrunset18.Text.Trim().Length==0)
			{
				strErr+="trunset18不能为空！\\n";	
			}
			if(this.txttrunset19.Text.Trim().Length==0)
			{
				strErr+="trunset19不能为空！\\n";	
			}
			if(this.txttrunset20.Text.Trim().Length==0)
			{
				strErr+="trunset20不能为空！\\n";	
			}
			if(this.txttrunset21.Text.Trim().Length==0)
			{
				strErr+="trunset21不能为空！\\n";	
			}
			if(this.txttrunset22.Text.Trim().Length==0)
			{
				strErr+="trunset22不能为空！\\n";	
			}
			if(this.txttrunset23.Text.Trim().Length==0)
			{
				strErr+="trunset23不能为空！\\n";	
			}
			if(this.txttrunset24.Text.Trim().Length==0)
			{
				strErr+="trunset24不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string id=this.txtid.Text;
			string name=this.txtname.Text;
			string community=this.txtcommunity.Text;
			string road_class=this.txtroad_class.Text;
			decimal width=decimal.Parse(this.txtwidth.Text);
			decimal pavement_width=decimal.Parse(this.txtpavement_width.Text);
			decimal community_road_length=decimal.Parse(this.txtcommunity_road_length.Text);
			string structure=this.txtstructure.Text;
			string is_dead_end_road=this.txtis_dead_end_road.Text;
			decimal damage_road_length=decimal.Parse(this.txtdamage_road_length.Text);
			decimal large_slope_road_length=decimal.Parse(this.txtlarge_slope_road_length.Text);
			decimal no_hard_road_length=decimal.Parse(this.txtno_hard_road_length.Text);
			decimal lack_width_road_length=decimal.Parse(this.txtlack_width_road_length.Text);
			string is_somewhere_no_link=this.txtis_somewhere_no_link.Text;
			decimal no_afforest_road_length=decimal.Parse(this.txtno_afforest_road_length.Text);
			decimal less_afforest_road_length=decimal.Parse(this.txtless_afforest_road_length.Text);
			int street_light_amount=int.Parse(this.txtstreet_light_amount.Text);
			int good_street_light_amount=int.Parse(this.txtgood_street_light_amount.Text);
			int road_hydrant_amount=int.Parse(this.txtroad_hydrant_amount.Text);
			int good_road_hydrant_amount=int.Parse(this.txtgood_road_hydrant_amount.Text);
			int road_dustbin_amount=int.Parse(this.txtroad_dustbin_amount.Text);
			int good_road_dustbin_amount=int.Parse(this.txtgood_road_dustbin_amount.Text);
			int road_parking_space_num=int.Parse(this.txtroad_parking_space_num.Text);
			int parking_space_use_rate=int.Parse(this.txtparking_space_use_rate.Text);
			string note_information=this.txtnote_information.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			string trunset1=this.txttrunset1.Text;
			string trunset2=this.txttrunset2.Text;
			string trunset3=this.txttrunset3.Text;
			string trunset4=this.txttrunset4.Text;
			string trunset5=this.txttrunset5.Text;
			string trunset6=this.txttrunset6.Text;
			string trunset7=this.txttrunset7.Text;
			string trunset8=this.txttrunset8.Text;
			string trunset9=this.txttrunset9.Text;
			string trunset10=this.txttrunset10.Text;
			string trunset11=this.txttrunset11.Text;
			string trunset12=this.txttrunset12.Text;
			string trunset13=this.txttrunset13.Text;
			string trunset14=this.txttrunset14.Text;
			string trunset15=this.txttrunset15.Text;
			string trunset16=this.txttrunset16.Text;
			string trunset17=this.txttrunset17.Text;
			string trunset18=this.txttrunset18.Text;
			string trunset19=this.txttrunset19.Text;
			string trunset20=this.txttrunset20.Text;
			string trunset21=this.txttrunset21.Text;
			string trunset22=this.txttrunset22.Text;
			string trunset23=this.txttrunset23.Text;
			string trunset24=this.txttrunset24.Text;

			TTG.Model.TTGWeb.road model=new TTG.Model.TTGWeb.road();
			model.id=id;
			model.name=name;
			model.community=community;
			model.road_class=road_class;
			model.width=width;
			model.pavement_width=pavement_width;
			model.community_road_length=community_road_length;
			model.structure=structure;
			model.is_dead_end_road=is_dead_end_road;
			model.damage_road_length=damage_road_length;
			model.large_slope_road_length=large_slope_road_length;
			model.no_hard_road_length=no_hard_road_length;
			model.lack_width_road_length=lack_width_road_length;
			model.is_somewhere_no_link=is_somewhere_no_link;
			model.no_afforest_road_length=no_afforest_road_length;
			model.less_afforest_road_length=less_afforest_road_length;
			model.street_light_amount=street_light_amount;
			model.good_street_light_amount=good_street_light_amount;
			model.road_hydrant_amount=road_hydrant_amount;
			model.good_road_hydrant_amount=good_road_hydrant_amount;
			model.road_dustbin_amount=road_dustbin_amount;
			model.good_road_dustbin_amount=good_road_dustbin_amount;
			model.road_parking_space_num=road_parking_space_num;
			model.parking_space_use_rate=parking_space_use_rate;
			model.note_information=note_information;
			model.statistics_date=statistics_date;
			model.check_status=check_status;
			model.lock_tables=lock_tables;
			model.trunset1=trunset1;
			model.trunset2=trunset2;
			model.trunset3=trunset3;
			model.trunset4=trunset4;
			model.trunset5=trunset5;
			model.trunset6=trunset6;
			model.trunset7=trunset7;
			model.trunset8=trunset8;
			model.trunset9=trunset9;
			model.trunset10=trunset10;
			model.trunset11=trunset11;
			model.trunset12=trunset12;
			model.trunset13=trunset13;
			model.trunset14=trunset14;
			model.trunset15=trunset15;
			model.trunset16=trunset16;
			model.trunset17=trunset17;
			model.trunset18=trunset18;
			model.trunset19=trunset19;
			model.trunset20=trunset20;
			model.trunset21=trunset21;
			model.trunset22=trunset22;
			model.trunset23=trunset23;
			model.trunset24=trunset24;

			TTG.BLL.TTGWeb.road bll=new TTG.BLL.TTGWeb.road();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
