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
namespace TTG.Web.TTGWeb.image_info
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string image_id = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					image_id= Request.Params["id0"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					statistics_date= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(image_id,statistics_date);
			}
		}
		
	private void ShowInfo(string image_id,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.image_info bll=new TTG.BLL.TTGWeb.image_info();
		TTG.Model.TTGWeb.image_info model=bll.GetModel(image_id,statistics_date);
		this.lblimage_id.Text=model.image_id;
		this.lblimage_name.Text=model.image_name;
		this.lblimage_address.Text=model.image_address;
		this.lblcommunity_id.Text=model.community_id;
		this.lblimage_type.Text=model.image_type;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblnf_id.Text=model.nf_id;

	}


    }
}
