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
namespace TTG.Web.TTGWeb.community_concil_house
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		TTG.BLL.TTGWeb.community_concil_house bll=new TTG.BLL.TTGWeb.community_concil_house();
		TTG.Model.TTGWeb.community_concil_house model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_council_buil_num.Text=model.community_council_buil_num.ToString();
		this.lblcommunity_conhou_gfa.Text=model.community_conhou_gfa.ToString();
		this.lblcommunity_conhou_fs.Text=model.community_conhou_fs.ToString();
		this.lblcommunity_conhou_unit_num.Text=model.community_conhou_unit_num.ToString();
		this.lblcommunity_conhou_floor_num.Text=model.community_conhou_floor_num.ToString();
		this.lblcommunity_conhou_suite_num.Text=model.community_conhou_suite_num.ToString();
		this.lblcommunity_conhou_family_num.Text=model.community_conhou_family_num.ToString();
		this.lblcommunity_conhou_people_num.Text=model.community_conhou_people_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcchunset1.Text=model.tcchunset1;
		this.lbltcchunset2.Text=model.tcchunset2;
		this.lbltcchunset3.Text=model.tcchunset3;
		this.lbltcchunset4.Text=model.tcchunset4;
		this.lbltcchunset5.Text=model.tcchunset5;
		this.lbltcchunset6.Text=model.tcchunset6;
		this.lbltcchunset8.Text=model.tcchunset8;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
