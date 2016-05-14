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
namespace TTG.Web.TTGWeb.road
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
		TTG.BLL.TTGWeb.road bll=new TTG.BLL.TTGWeb.road();
		TTG.Model.TTGWeb.road model=bll.GetModel(id,statistics_date);
		this.lblid.Text=model.id;
		this.lblname.Text=model.name;
		this.lblcommunity.Text=model.community;
		this.lblroad_class.Text=model.road_class;
		this.lblwidth.Text=model.width.ToString();
		this.lblpavement_width.Text=model.pavement_width.ToString();
		this.lblcommunity_road_length.Text=model.community_road_length.ToString();
		this.lblstructure.Text=model.structure;
		this.lblis_dead_end_road.Text=model.is_dead_end_road;
		this.lbldamage_road_length.Text=model.damage_road_length.ToString();
		this.lbllarge_slope_road_length.Text=model.large_slope_road_length.ToString();
		this.lblno_hard_road_length.Text=model.no_hard_road_length.ToString();
		this.lbllack_width_road_length.Text=model.lack_width_road_length.ToString();
		this.lblis_somewhere_no_link.Text=model.is_somewhere_no_link;
		this.lblno_afforest_road_length.Text=model.no_afforest_road_length.ToString();
		this.lblless_afforest_road_length.Text=model.less_afforest_road_length.ToString();
		this.lblstreet_light_amount.Text=model.street_light_amount.ToString();
		this.lblgood_street_light_amount.Text=model.good_street_light_amount.ToString();
		this.lblroad_hydrant_amount.Text=model.road_hydrant_amount.ToString();
		this.lblgood_road_hydrant_amount.Text=model.good_road_hydrant_amount.ToString();
		this.lblroad_dustbin_amount.Text=model.road_dustbin_amount.ToString();
		this.lblgood_road_dustbin_amount.Text=model.good_road_dustbin_amount.ToString();
		this.lblroad_parking_space_num.Text=model.road_parking_space_num.ToString();
		this.lblparking_space_use_rate.Text=model.parking_space_use_rate.ToString();
		this.lblnote_information.Text=model.note_information;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lbltrunset1.Text=model.trunset1;
		this.lbltrunset2.Text=model.trunset2;
		this.lbltrunset3.Text=model.trunset3;
		this.lbltrunset4.Text=model.trunset4;
		this.lbltrunset5.Text=model.trunset5;
		this.lbltrunset6.Text=model.trunset6;
		this.lbltrunset7.Text=model.trunset7;
		this.lbltrunset8.Text=model.trunset8;
		this.lbltrunset9.Text=model.trunset9;
		this.lbltrunset10.Text=model.trunset10;
		this.lbltrunset11.Text=model.trunset11;
		this.lbltrunset12.Text=model.trunset12;
		this.lbltrunset13.Text=model.trunset13;
		this.lbltrunset14.Text=model.trunset14;
		this.lbltrunset15.Text=model.trunset15;
		this.lbltrunset16.Text=model.trunset16;
		this.lbltrunset17.Text=model.trunset17;
		this.lbltrunset18.Text=model.trunset18;
		this.lbltrunset19.Text=model.trunset19;
		this.lbltrunset20.Text=model.trunset20;
		this.lbltrunset21.Text=model.trunset21;
		this.lbltrunset22.Text=model.trunset22;
		this.lbltrunset23.Text=model.trunset23;
		this.lbltrunset24.Text=model.trunset24;

	}


    }
}
