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
namespace TTG.Web.TTGWeb.community_water_supply_problem
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
		TTG.BLL.TTGWeb.community_water_supply_problem bll=new TTG.BLL.TTGWeb.community_water_supply_problem();
		TTG.Model.TTGWeb.community_water_supply_problem model=bll.GetModel(community_id,community_fill_type,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.lblcommunity_fill_type.Text=model.community_fill_type;
		this.lblcommunity_insuf_ws_res_num.Text=model.community_insuf_ws_res_num.ToString();
		this.lblcommunity_insuf_ws_house_num.Text=model.community_insuf_ws_house_num.ToString();
		this.lblcommunity_insuf_wp_res_num.Text=model.community_insuf_wp_res_num.ToString();
		this.lblcommunity_insuf_wp_house_num.Text=model.community_insuf_wp_house_num.ToString();
		this.lblcommunity_not_imple_ohot_res_num.Text=model.community_not_imple_ohot_res_num.ToString();
		this.lblcommunity_not_imple_ohot_house_num.Text=model.community_not_imple_ohot_house_num.ToString();
		this.lblcommunity_insuf_pipe_size_num.Text=model.community_insuf_pipe_size_num.ToString();
		this.lblcommunity_insuf_pipe_size_length.Text=model.community_insuf_pipe_size_length.ToString();
		this.lblcommunity_damage_leakage_pipe_num.Text=model.community_damage_leakage_pipe_num.ToString();
		this.lblcommunity_damage_leakage_pipe_house_num.Text=model.community_damage_leakage_pipe_house_num.ToString();
		this.lblcommunity_aging_corrosion_pipe_length.Text=model.community_aging_corrosion_pipe_length.ToString();
		this.lblcommunity_aging_corrosion_pipe_house_num.Text=model.community_aging_corrosion_pipe_house_num.ToString();
		this.lblcommunity_insuf_pn_coverage.Text=model.community_insuf_pn_coverage;
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
		this.lbltciunset9.Text=model.tciunset9;
		this.lbltciunset10.Text=model.tciunset10;
		this.lbltciunset11.Text=model.tciunset11;
		this.lbltciunset12.Text=model.tciunset12;
		this.lbltciunset13.Text=model.tciunset13;
		this.lbltciunset14.Text=model.tciunset14;
		this.lbltciunset15.Text=model.tciunset15;
		this.lbltciunset16.Text=model.tciunset16;
		this.lbllock_tables.Text=model.lock_tables.ToString();

	}


    }
}