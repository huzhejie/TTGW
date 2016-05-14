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
namespace TTG.Web.TTGWeb.enterprise
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
		TTG.BLL.TTGWeb.enterprise bll=new TTG.BLL.TTGWeb.enterprise();
		TTG.Model.TTGWeb.enterprise model=bll.GetModel(id,statistics_date);
		this.lblid.Text=model.id;
		this.lblcounty.Text=model.county;
		this.lblcommunty.Text=model.communty;
		this.lblname.Text=model.name;
		this.lbladdress.Text=model.address;
		this.lbldistance_to_community.Text=model.distance_to_community.ToString();
		this.lbltype.Text=model.type;
		this.lblmain_product.Text=model.main_product;
		this.lblarea.Text=model.area.ToString();
		this.lblstuff_amount.Text=model.stuff_amount.ToString();
		this.lblimmigrant_stuff_amount.Text=model.immigrant_stuff_amount.ToString();
		this.lbllf_average_salary.Text=model.lf_average_salary.ToString();
		this.lblnote_information.Text=model.note_information;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblteunset1.Text=model.teunset1;
		this.lblteunset2.Text=model.teunset2;
		this.lblteunset3.Text=model.teunset3;
		this.lblteunset4.Text=model.teunset4;
		this.lblteunset5.Text=model.teunset5;
		this.lblteunset6.Text=model.teunset6;
		this.lblteunset7.Text=model.teunset7;
		this.lblteunset8.Text=model.teunset8;
		this.lblteunset9.Text=model.teunset9;
		this.lblteunset10.Text=model.teunset10;
		this.lblteunset11.Text=model.teunset11;
		this.lblteunset12.Text=model.teunset12;

	}


    }
}
