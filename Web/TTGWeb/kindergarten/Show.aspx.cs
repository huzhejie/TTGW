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
namespace TTG.Web.TTGWeb.kindergarten
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string name = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					name= Request.Params["id0"];
				}
				string community = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					community= Request.Params["id1"];
				}
				DateTime statistics_date = "";
				if (Request.Params["id2"] != null && Request.Params["id2"].Trim() != "")
				{
					statistics_date= Request.Params["id2"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(name,community,statistics_date);
			}
		}
		
	private void ShowInfo(string name,string community,DateTime statistics_date)
	{
		TTG.BLL.TTGWeb.kindergarten bll=new TTG.BLL.TTGWeb.kindergarten();
		TTG.Model.TTGWeb.kindergarten model=bll.GetModel(name,community,statistics_date);
		this.lblname.Text=model.name;
		this.lblcommunity.Text=model.community;
		this.lbltype.Text=model.type;
		this.lblfloor_space.Text=model.floor_space.ToString();
		this.lblgross_floor_area.Text=model.gross_floor_area.ToString();
		this.lblstudents_amount.Text=model.students_amount.ToString();
		this.lblteachers_amount.Text=model.teachers_amount.ToString();
		this.lblclass_amount.Text=model.class_amount.ToString();
		this.lblteachers_students_rate.Text=model.teachers_students_rate.ToString();
		this.lblactivity_room_area.Text=model.activity_room_area.ToString();
		this.lblactivity_room_area_if_suff.Text=model.activity_room_area_if_suff;
		this.lblotds_activity_room_area.Text=model.otds_activity_room_area.ToString();
		this.lblotds_activity_room_area_if_suff.Text=model.otds_activity_room_area_if_suff;
		this.lblafforest_area.Text=model.afforest_area.ToString();
		this.lblafforest_area_if_suff.Text=model.afforest_area_if_suff;
		this.lblschool_bus_amount.Text=model.school_bus_amount.ToString();
		this.lblpick_up_students_amount_daily.Text=model.pick_up_students_amount_daily.ToString();
		this.lblnote_information.Text=model.note_information;
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.lbllock_tables.Text=model.lock_tables.ToString();
		this.lblcheck_status.Text=model.check_status.ToString();
		this.lbltkunset1.Text=model.tkunset1;
		this.lbltkunset2.Text=model.tkunset2;
		this.lbltkunset3.Text=model.tkunset3;
		this.lbltkunset4.Text=model.tkunset4;
		this.lbltkunset5.Text=model.tkunset5;
		this.lbltkunset6.Text=model.tkunset6;
		this.lbltkunset7.Text=model.tkunset7;
		this.lbltkunset8.Text=model.tkunset8;
		this.lbltkunset9.Text=model.tkunset9;
		this.lbltkunset10.Text=model.tkunset10;
		this.lbltkunset11.Text=model.tkunset11;
		this.lbltkunset12.Text=model.tkunset12;
		this.lbltkunset13.Text=model.tkunset13;
		this.lbltkunset14.Text=model.tkunset14;
		this.lbltkunset15.Text=model.tkunset15;
		this.lbltkunset16.Text=model.tkunset16;
		this.lbltkunset17.Text=model.tkunset17;

	}


    }
}
