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
namespace TTG.Web.TTGWeb.concil_house
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(id,statistics_date);
			}
		}
		
	private void ShowInfo(string id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.concil_house bll=new TTG.BLL.TTGWeb.concil_house();
		TTG.Model.TTGWeb.concil_house model=bll.GetModel(id,statistics_date);
		this.lblid.Text=model.id;
		this.lblcommunity.Text=model.community;
		this.lblbuilding.Text=model.building.ToString();
		this.lblunit.Text=model.unit.ToString();
		this.lblstructure.Text=model.structure;
		this.lblfloor.Text=model.floor.ToString();
		this.lblhouse.Text=model.house.ToString();
		this.lblfinish_time.Text=model.finish_time.ToString();
		this.lblgross_floor_area.Text=model.gross_floor_area.ToString();
		this.lbltiled_wall_area.Text=model.tiled_wall_area.ToString();
		this.lblfamily_num.Text=model.family_num.ToString();
		this.lblpop_num.Text=model.pop_num.ToString();
		this.lblslight_deform_cra_area.Text=model.slight_deform_cra_area.ToString();
		this.lblbase_subs_area.Text=model.base_subs_area.ToString();
		this.lbldila_buil_area.Text=model.dila_buil_area.ToString();
		this.lblstru_safety_prob_fam_num.Text=model.stru_safety_prob_fam_num.ToString();
		this.lblslight_deform_cra_pop.Text=model.slight_deform_cra_pop.ToString();
		this.lblseepage_buil_area.Text=model.seepage_buil_area.ToString();
		this.lblseepage_fam_num.Text=model.seepage_fam_num.ToString();
		this.lblseepage_pop.Text=model.seepage_pop.ToString();
		this.lbltile_paint_cra_holl_buil_area.Text=model.tile_paint_cra_holl_buil_area.ToString();
		this.lblnote_information.Text=model.note_information;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltchunset1.Text=model.tchunset1;
		this.lbltchunset2.Text=model.tchunset2;
		this.lbltchunset3.Text=model.tchunset3;
		this.lbltchunset4.Text=model.tchunset4;
		this.lbltchunset5.Text=model.tchunset5;
		this.lbltchunset6.Text=model.tchunset6;
		this.lbltchunset7.Text=model.tchunset7;
		this.lbltchunset8.Text=model.tchunset8;
		this.lbltchunset9.Text=model.tchunset9;
		this.lbltchunset10.Text=model.tchunset10;
		this.lbltchunset11.Text=model.tchunset11;
		this.lbltchunset12.Text=model.tchunset12;
		this.lbltchunset13.Text=model.tchunset13;
		this.lbltchunset14.Text=model.tchunset14;
		this.lbltchunset15.Text=model.tchunset15;
		this.lbltchunset16.Text=model.tchunset16;
		this.lbltchunset17.Text=model.tchunset17;
		this.lbltchunset18.Text=model.tchunset18;
		this.lbltchunset19.Text=model.tchunset19;
		this.lbltchunset20.Text=model.tchunset20;
		this.lbltchunset21.Text=model.tchunset21;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
