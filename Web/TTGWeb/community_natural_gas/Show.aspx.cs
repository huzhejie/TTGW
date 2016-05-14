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
namespace TTG.Web.TTGWeb.community_natural_gas
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
		TTG.BLL.TTGWeb.community_natural_gas bll=new TTG.BLL.TTGWeb.community_natural_gas();
		TTG.Model.TTGWeb.community_natural_gas model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_gas_regulating_station_num.Text=model.community_gas_regulating_station_num.ToString();
		this.lblcommunity_natural_gas_pipe_length.Text=model.community_natural_gas_pipe_length.ToString();
		this.lbllow_pressure_natural_gas_pipe_length.Text=model.low_pressure_natural_gas_pipe_length.ToString();
		this.lblmiddle_pressuse_natural_gas_pipe_length.Text=model.middle_pressuse_natural_gas_pipe_length.ToString();
		this.lblintermediate_pressure_natural_gas_pipe_length.Text=model.intermediate_pressure_natural_gas_pipe_length.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbltcngunset1.Text=model.tcngunset1;
		this.lbltcngunset2.Text=model.tcngunset2;
		this.lbltcngunset3.Text=model.tcngunset3;
		this.lbltcngunset4.Text=model.tcngunset4;
		this.lbltcngunset5.Text=model.tcngunset5;
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();

	}


    }
}
