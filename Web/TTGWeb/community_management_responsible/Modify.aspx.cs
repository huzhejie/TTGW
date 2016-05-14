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
namespace TTG.Web.TTGWeb.community_management_responsible
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string community_id= Request.Params["id"];
					ShowInfo(community_id);
				}
			}
		}
			
	private void ShowInfo(string community_id)
	{
		TTG.BLL.TTGWeb.community_management_responsible bll=new TTG.BLL.TTGWeb.community_management_responsible();
		TTG.Model.TTGWeb.community_management_responsible model=bll.GetModel(community_id);
		this.txtcommunity_address.Text=model.community_address;
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_manage_charge_person_name.Text=model.community_manage_charge_person_name;
		this.txtcommunity_manage_charge_person_telphone.Text=model.community_manage_charge_person_telphone;
		this.txtcommunity_monitor_charge_person_name.Text=model.community_monitor_charge_person_name;
		this.txtcommunity_monitor_charge_person_telphone.Text=model.community_monitor_charge_person_telphone;
		this.txtcommunity_contacts_telephone.Text=model.community_contacts_telephone;
		this.txtcommunity_staff_telephone.Text=model.community_staff_telephone;
		this.txttcmrunset1.Text=model.tcmrunset1;
		this.txttcmrunset2.Text=model.tcmrunset2;
		this.txttcmrunset3.Text=model.tcmrunset3;
		this.txttcmrunset4.Text=model.tcmrunset4;
		this.txttcmrunset5.Text=model.tcmrunset5;
		this.txttcmrunset6.Text=model.tcmrunset6;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcommunity_address.Text.Trim().Length==0)
			{
				strErr+="community_address不能为空！\\n";	
			}
			if(this.txtcommunity_manage_charge_person_name.Text.Trim().Length==0)
			{
				strErr+="community_manage_charge_person_name不能为空！\\n";	
			}
			if(this.txtcommunity_manage_charge_person_telphone.Text.Trim().Length==0)
			{
				strErr+="community_manage_charge_person_telphone不能为空！\\n";	
			}
			if(this.txtcommunity_monitor_charge_person_name.Text.Trim().Length==0)
			{
				strErr+="community_monitor_charge_person_name不能为空！\\n";	
			}
			if(this.txtcommunity_monitor_charge_person_telphone.Text.Trim().Length==0)
			{
				strErr+="community_monitor_charge_person_telphone不能为空！\\n";	
			}
			if(this.txtcommunity_contacts_telephone.Text.Trim().Length==0)
			{
				strErr+="community_contacts_telephone不能为空！\\n";	
			}
			if(this.txtcommunity_staff_telephone.Text.Trim().Length==0)
			{
				strErr+="community_staff_telephone不能为空！\\n";	
			}
			if(this.txttcmrunset1.Text.Trim().Length==0)
			{
				strErr+="tcmrunset1不能为空！\\n";	
			}
			if(this.txttcmrunset2.Text.Trim().Length==0)
			{
				strErr+="tcmrunset2不能为空！\\n";	
			}
			if(this.txttcmrunset3.Text.Trim().Length==0)
			{
				strErr+="tcmrunset3不能为空！\\n";	
			}
			if(this.txttcmrunset4.Text.Trim().Length==0)
			{
				strErr+="tcmrunset4不能为空！\\n";	
			}
			if(this.txttcmrunset5.Text.Trim().Length==0)
			{
				strErr+="tcmrunset5不能为空！\\n";	
			}
			if(this.txttcmrunset6.Text.Trim().Length==0)
			{
				strErr+="tcmrunset6不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_address=this.txtcommunity_address.Text;
			string community_id=this.lblcommunity_id.Text;
			string community_manage_charge_person_name=this.txtcommunity_manage_charge_person_name.Text;
			string community_manage_charge_person_telphone=this.txtcommunity_manage_charge_person_telphone.Text;
			string community_monitor_charge_person_name=this.txtcommunity_monitor_charge_person_name.Text;
			string community_monitor_charge_person_telphone=this.txtcommunity_monitor_charge_person_telphone.Text;
			string community_contacts_telephone=this.txtcommunity_contacts_telephone.Text;
			string community_staff_telephone=this.txtcommunity_staff_telephone.Text;
			string tcmrunset1=this.txttcmrunset1.Text;
			string tcmrunset2=this.txttcmrunset2.Text;
			string tcmrunset3=this.txttcmrunset3.Text;
			string tcmrunset4=this.txttcmrunset4.Text;
			string tcmrunset5=this.txttcmrunset5.Text;
			string tcmrunset6=this.txttcmrunset6.Text;


			TTG.Model.TTGWeb.community_management_responsible model=new TTG.Model.TTGWeb.community_management_responsible();
			model.community_address=community_address;
			model.community_id=community_id;
			model.community_manage_charge_person_name=community_manage_charge_person_name;
			model.community_manage_charge_person_telphone=community_manage_charge_person_telphone;
			model.community_monitor_charge_person_name=community_monitor_charge_person_name;
			model.community_monitor_charge_person_telphone=community_monitor_charge_person_telphone;
			model.community_contacts_telephone=community_contacts_telephone;
			model.community_staff_telephone=community_staff_telephone;
			model.tcmrunset1=tcmrunset1;
			model.tcmrunset2=tcmrunset2;
			model.tcmrunset3=tcmrunset3;
			model.tcmrunset4=tcmrunset4;
			model.tcmrunset5=tcmrunset5;
			model.tcmrunset6=tcmrunset6;

			TTG.BLL.TTGWeb.community_management_responsible bll=new TTG.BLL.TTGWeb.community_management_responsible();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
