﻿using System;
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
namespace TTG.Web.TTGWeb.community_medical_problem
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
				string community_fill_type = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					community_fill_type= Request.Params["id1"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id2"] != null && Request.Params["id2"].Trim() != "")
				{
					statistics_date= Request.Params["id2"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(community_id,community_fill_type,statistics_date);
			}
		}
		
	private void ShowInfo(string community_id,string community_fill_type,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.community_medical_problem bll=new TTG.BLL.TTGWeb.community_medical_problem();
		TTG.Model.TTGWeb.community_medical_problem model=bll.GetModel(community_id,community_fill_type,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_fill_type.Text=model.community_fill_type;
		this.lblcommunity_wout_mp_res_unit.Text=model.community_wout_mp_res_unit.ToString();
		this.lblcommunity_less_mp_res_unit.Text=model.community_less_mp_res_unit.ToString();
		this.lblcommunity_far_domt_res_unit.Text=model.community_far_domt_res_unit.ToString();
		this.lblcommunity_hs_area_shortage_num.Text=model.community_hs_area_shortage_num.ToString();
		this.lblcommunity_hs_faci_imperfect_num.Text=model.community_hs_faci_imperfect_num.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbltciunset1.Text=model.tciunset1;
		this.lbltciunset2.Text=model.tciunset2;
		this.lbltciunset3.Text=model.tciunset3;
		this.lbltciunset4.Text=model.tciunset4;
		this.lbltciunset5.Text=model.tciunset5;
		this.lbltciunset6.Text=model.tciunset6;
		this.lbltciunset7.Text=model.tciunset7;
		this.lbltciunset8.Text=model.tciunset8;
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}
