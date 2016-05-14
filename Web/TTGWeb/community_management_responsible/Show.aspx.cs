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
namespace TTG.Web.TTGWeb.community_management_responsible
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string community_id= strid;
					ShowInfo(community_id);
				}
			}
		}
		
	private void ShowInfo(string community_id)
	{
		TTG.BLL.TTGWeb.community_management_responsible bll=new TTG.BLL.TTGWeb.community_management_responsible();
		TTG.Model.TTGWeb.community_management_responsible model=bll.GetModel(community_id);
		this.lblcommunity_address.Text=model.community_address;
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_manage_charge_person_name.Text=model.community_manage_charge_person_name;
		this.lblcommunity_manage_charge_person_telphone.Text=model.community_manage_charge_person_telphone;
		this.lblcommunity_monitor_charge_person_name.Text=model.community_monitor_charge_person_name;
		this.lblcommunity_monitor_charge_person_telphone.Text=model.community_monitor_charge_person_telphone;
		this.lblcommunity_contacts_telephone.Text=model.community_contacts_telephone;
		this.lblcommunity_staff_telephone.Text=model.community_staff_telephone;
		this.lbltcmrunset1.Text=model.tcmrunset1;
		this.lbltcmrunset2.Text=model.tcmrunset2;
		this.lbltcmrunset3.Text=model.tcmrunset3;
		this.lbltcmrunset4.Text=model.tcmrunset4;
		this.lbltcmrunset5.Text=model.tcmrunset5;
		this.lbltcmrunset6.Text=model.tcmrunset6;

	}


    }
}
