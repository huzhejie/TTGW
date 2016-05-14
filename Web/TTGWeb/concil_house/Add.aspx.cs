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
namespace TTG.Web.TTGWeb.concil_house
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
			if(this.txtcommunity.Text.Trim().Length==0)
			{
				strErr+="community不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtbuilding.Text))
			{
				strErr+="building格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtunit.Text))
			{
				strErr+="unit格式错误！\\n";	
			}
			if(this.txtstructure.Text.Trim().Length==0)
			{
				strErr+="structure不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtfloor.Text))
			{
				strErr+="floor格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txthouse.Text))
			{
				strErr+="house格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtfinish_time.Text))
			{
				strErr+="finish_time格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtgross_floor_area.Text))
			{
				strErr+="gross_floor_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttiled_wall_area.Text))
			{
				strErr+="tiled_wall_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfamily_num.Text))
			{
				strErr+="family_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpop_num.Text))
			{
				strErr+="pop_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtslight_deform_cra_area.Text))
			{
				strErr+="slight_deform_cra_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtbase_subs_area.Text))
			{
				strErr+="base_subs_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdila_buil_area.Text))
			{
				strErr+="dila_buil_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstru_safety_prob_fam_num.Text))
			{
				strErr+="stru_safety_prob_fam_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtslight_deform_cra_pop.Text))
			{
				strErr+="slight_deform_cra_pop格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtseepage_buil_area.Text))
			{
				strErr+="seepage_buil_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtseepage_fam_num.Text))
			{
				strErr+="seepage_fam_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtseepage_pop.Text))
			{
				strErr+="seepage_pop格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttile_paint_cra_holl_buil_area.Text))
			{
				strErr+="tile_paint_cra_holl_buil_area格式错误！\\n";	
			}
			if(this.txtnote_information.Text.Trim().Length==0)
			{
				strErr+="note_information不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttchunset1.Text.Trim().Length==0)
			{
				strErr+="tchunset1不能为空！\\n";	
			}
			if(this.txttchunset2.Text.Trim().Length==0)
			{
				strErr+="tchunset2不能为空！\\n";	
			}
			if(this.txttchunset3.Text.Trim().Length==0)
			{
				strErr+="tchunset3不能为空！\\n";	
			}
			if(this.txttchunset4.Text.Trim().Length==0)
			{
				strErr+="tchunset4不能为空！\\n";	
			}
			if(this.txttchunset5.Text.Trim().Length==0)
			{
				strErr+="tchunset5不能为空！\\n";	
			}
			if(this.txttchunset6.Text.Trim().Length==0)
			{
				strErr+="tchunset6不能为空！\\n";	
			}
			if(this.txttchunset7.Text.Trim().Length==0)
			{
				strErr+="tchunset7不能为空！\\n";	
			}
			if(this.txttchunset8.Text.Trim().Length==0)
			{
				strErr+="tchunset8不能为空！\\n";	
			}
			if(this.txttchunset9.Text.Trim().Length==0)
			{
				strErr+="tchunset9不能为空！\\n";	
			}
			if(this.txttchunset10.Text.Trim().Length==0)
			{
				strErr+="tchunset10不能为空！\\n";	
			}
			if(this.txttchunset11.Text.Trim().Length==0)
			{
				strErr+="tchunset11不能为空！\\n";	
			}
			if(this.txttchunset12.Text.Trim().Length==0)
			{
				strErr+="tchunset12不能为空！\\n";	
			}
			if(this.txttchunset13.Text.Trim().Length==0)
			{
				strErr+="tchunset13不能为空！\\n";	
			}
			if(this.txttchunset14.Text.Trim().Length==0)
			{
				strErr+="tchunset14不能为空！\\n";	
			}
			if(this.txttchunset15.Text.Trim().Length==0)
			{
				strErr+="tchunset15不能为空！\\n";	
			}
			if(this.txttchunset16.Text.Trim().Length==0)
			{
				strErr+="tchunset16不能为空！\\n";	
			}
			if(this.txttchunset17.Text.Trim().Length==0)
			{
				strErr+="tchunset17不能为空！\\n";	
			}
			if(this.txttchunset18.Text.Trim().Length==0)
			{
				strErr+="tchunset18不能为空！\\n";	
			}
			if(this.txttchunset19.Text.Trim().Length==0)
			{
				strErr+="tchunset19不能为空！\\n";	
			}
			if(this.txttchunset20.Text.Trim().Length==0)
			{
				strErr+="tchunset20不能为空！\\n";	
			}
			if(this.txttchunset21.Text.Trim().Length==0)
			{
				strErr+="tchunset21不能为空！\\n";	
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
			string id=this.txtid.Text;
			string community=this.txtcommunity.Text;
			int building=int.Parse(this.txtbuilding.Text);
			int unit=int.Parse(this.txtunit.Text);
			string structure=this.txtstructure.Text;
			int floor=int.Parse(this.txtfloor.Text);
			int house=int.Parse(this.txthouse.Text);
			DateTime finish_time=DateTime.Parse(this.txtfinish_time.Text);
			decimal gross_floor_area=decimal.Parse(this.txtgross_floor_area.Text);
			decimal tiled_wall_area=decimal.Parse(this.txttiled_wall_area.Text);
			int family_num=int.Parse(this.txtfamily_num.Text);
			int pop_num=int.Parse(this.txtpop_num.Text);
			decimal slight_deform_cra_area=decimal.Parse(this.txtslight_deform_cra_area.Text);
			decimal base_subs_area=decimal.Parse(this.txtbase_subs_area.Text);
			decimal dila_buil_area=decimal.Parse(this.txtdila_buil_area.Text);
			int stru_safety_prob_fam_num=int.Parse(this.txtstru_safety_prob_fam_num.Text);
			int slight_deform_cra_pop=int.Parse(this.txtslight_deform_cra_pop.Text);
			decimal seepage_buil_area=decimal.Parse(this.txtseepage_buil_area.Text);
			int seepage_fam_num=int.Parse(this.txtseepage_fam_num.Text);
			int seepage_pop=int.Parse(this.txtseepage_pop.Text);
			decimal tile_paint_cra_holl_buil_area=decimal.Parse(this.txttile_paint_cra_holl_buil_area.Text);
			string note_information=this.txtnote_information.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tchunset1=this.txttchunset1.Text;
			string tchunset2=this.txttchunset2.Text;
			string tchunset3=this.txttchunset3.Text;
			string tchunset4=this.txttchunset4.Text;
			string tchunset5=this.txttchunset5.Text;
			string tchunset6=this.txttchunset6.Text;
			string tchunset7=this.txttchunset7.Text;
			string tchunset8=this.txttchunset8.Text;
			string tchunset9=this.txttchunset9.Text;
			string tchunset10=this.txttchunset10.Text;
			string tchunset11=this.txttchunset11.Text;
			string tchunset12=this.txttchunset12.Text;
			string tchunset13=this.txttchunset13.Text;
			string tchunset14=this.txttchunset14.Text;
			string tchunset15=this.txttchunset15.Text;
			string tchunset16=this.txttchunset16.Text;
			string tchunset17=this.txttchunset17.Text;
			string tchunset18=this.txttchunset18.Text;
			string tchunset19=this.txttchunset19.Text;
			string tchunset20=this.txttchunset20.Text;
			string tchunset21=this.txttchunset21.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);

			TTG.Model.TTGWeb.concil_house model=new TTG.Model.TTGWeb.concil_house();
			model.id=id;
			model.community=community;
			model.building=building;
			model.unit=unit;
			model.structure=structure;
			model.floor=floor;
			model.house=house;
			model.finish_time=finish_time;
			model.gross_floor_area=gross_floor_area;
			model.tiled_wall_area=tiled_wall_area;
			model.family_num=family_num;
			model.pop_num=pop_num;
			model.slight_deform_cra_area=slight_deform_cra_area;
			model.base_subs_area=base_subs_area;
			model.dila_buil_area=dila_buil_area;
			model.stru_safety_prob_fam_num=stru_safety_prob_fam_num;
			model.slight_deform_cra_pop=slight_deform_cra_pop;
			model.seepage_buil_area=seepage_buil_area;
			model.seepage_fam_num=seepage_fam_num;
			model.seepage_pop=seepage_pop;
			model.tile_paint_cra_holl_buil_area=tile_paint_cra_holl_buil_area;
			model.note_information=note_information;
			model.statistics_date=statistics_date;
			model.tchunset1=tchunset1;
			model.tchunset2=tchunset2;
			model.tchunset3=tchunset3;
			model.tchunset4=tchunset4;
			model.tchunset5=tchunset5;
			model.tchunset6=tchunset6;
			model.tchunset7=tchunset7;
			model.tchunset8=tchunset8;
			model.tchunset9=tchunset9;
			model.tchunset10=tchunset10;
			model.tchunset11=tchunset11;
			model.tchunset12=tchunset12;
			model.tchunset13=tchunset13;
			model.tchunset14=tchunset14;
			model.tchunset15=tchunset15;
			model.tchunset16=tchunset16;
			model.tchunset17=tchunset17;
			model.tchunset18=tchunset18;
			model.tchunset19=tchunset19;
			model.tchunset20=tchunset20;
			model.tchunset21=tchunset21;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.concil_house bll=new TTG.BLL.TTGWeb.concil_house();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
