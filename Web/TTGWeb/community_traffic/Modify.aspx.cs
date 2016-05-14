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
namespace TTG.Web.TTGWeb.community_traffic
{
    public partial class Modify : Page
    {       

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
		TTG.BLL.TTGWeb.community_traffic bll=new TTG.BLL.TTGWeb.community_traffic();
		TTG.Model.TTGWeb.community_traffic model=bll.GetModel(community_id,statistics_date);
		this.lblcommunity_id.Text=model.community_id;
		this.txtcommunity_passenger_station_num.Text=model.community_passenger_station_num.ToString();
		this.txtcommunity_station_waiting_room_area.Text=model.community_station_waiting_room_area.ToString();
		this.txtcommunity_station_parking_lot_area.Text=model.community_station_parking_lot_area.ToString();
		this.txtcommunity_bus_trips.Text=model.community_bus_trips.ToString();
		this.txtcommunity_quay_num.Text=model.community_quay_num.ToString();
		this.txtcommunity_passenger_and_goods_quay_num.Text=model.community_passenger_and_goods_quay_num.ToString();
		this.txtcommunity_goods_quay_num.Text=model.community_goods_quay_num.ToString();
		this.txtcommunity_passenger_quay_num.Text=model.community_passenger_quay_num.ToString();
		this.txtcommunity_docking_point.Text=model.community_docking_point.ToString();
		this.txtcommunity_passenger_quay_waiting_room_area.Text=model.community_passenger_quay_waiting_room_area.ToString();
		this.txtcommunity_passenger_quay_parking_lot_area.Text=model.community_passenger_quay_parking_lot_area.ToString();
		this.txtcommunity_passenger_quay_ship_trips.Text=model.community_passenger_quay_ship_trips.ToString();
		this.txtcommunity_passenger_quay_dis_to_county.Text=model.community_passenger_quay_dis_to_county.ToString();
		this.lblstatistics_date.Text=model.statistics_date.ToString();
		this.txttctunset1.Text=model.tctunset1;
		this.txttctunset2.Text=model.tctunset2;
		this.txttctunset3.Text=model.tctunset3;
		this.txttctunset4.Text=model.tctunset4;
		this.txttctunset5.Text=model.tctunset5;
		this.txttctunset6.Text=model.tctunset6;
		this.txttctunset7.Text=model.tctunset7;
		this.txttctunset8.Text=model.tctunset8;
		this.txttctunset9.Text=model.tctunset9;
		this.txttctunset10.Text=model.tctunset10;
		this.txttctunset11.Text=model.tctunset11;
		this.txttctunset12.Text=model.tctunset12;
		this.txttctunset13.Text=model.tctunset13;
		this.txtlock_tables.Text=model.lock_tables.ToString();
		this.txtcheck_status.Text=model.check_status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcommunity_passenger_station_num.Text))
			{
				strErr+="community_passenger_station_num格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_station_waiting_room_area.Text))
			{
				strErr+="community_station_waiting_room_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_station_parking_lot_area.Text))
			{
				strErr+="community_station_parking_lot_area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_bus_trips.Text))
			{
				strErr+="community_bus_trips格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_quay_num.Text))
			{
				strErr+="community_quay_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_passenger_and_goods_quay_num.Text))
			{
				strErr+="community_passenger_and_goods_quay_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_goods_quay_num.Text))
			{
				strErr+="community_goods_quay_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_passenger_quay_num.Text))
			{
				strErr+="community_passenger_quay_num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommunity_docking_point.Text))
			{
				strErr+="community_docking_point格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_passenger_quay_waiting_room_area.Text))
			{
				strErr+="community_passenger_quay_waiting_room_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_passenger_quay_parking_lot_area.Text))
			{
				strErr+="community_passenger_quay_parking_lot_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_passenger_quay_ship_trips.Text))
			{
				strErr+="community_passenger_quay_ship_trips格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcommunity_passenger_quay_dis_to_county.Text))
			{
				strErr+="community_passenger_quay_dis_to_county格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(this.txttctunset1.Text.Trim().Length==0)
			{
				strErr+="tctunset1不能为空！\\n";	
			}
			if(this.txttctunset2.Text.Trim().Length==0)
			{
				strErr+="tctunset2不能为空！\\n";	
			}
			if(this.txttctunset3.Text.Trim().Length==0)
			{
				strErr+="tctunset3不能为空！\\n";	
			}
			if(this.txttctunset4.Text.Trim().Length==0)
			{
				strErr+="tctunset4不能为空！\\n";	
			}
			if(this.txttctunset5.Text.Trim().Length==0)
			{
				strErr+="tctunset5不能为空！\\n";	
			}
			if(this.txttctunset6.Text.Trim().Length==0)
			{
				strErr+="tctunset6不能为空！\\n";	
			}
			if(this.txttctunset7.Text.Trim().Length==0)
			{
				strErr+="tctunset7不能为空！\\n";	
			}
			if(this.txttctunset8.Text.Trim().Length==0)
			{
				strErr+="tctunset8不能为空！\\n";	
			}
			if(this.txttctunset9.Text.Trim().Length==0)
			{
				strErr+="tctunset9不能为空！\\n";	
			}
			if(this.txttctunset10.Text.Trim().Length==0)
			{
				strErr+="tctunset10不能为空！\\n";	
			}
			if(this.txttctunset11.Text.Trim().Length==0)
			{
				strErr+="tctunset11不能为空！\\n";	
			}
			if(this.txttctunset12.Text.Trim().Length==0)
			{
				strErr+="tctunset12不能为空！\\n";	
			}
			if(this.txttctunset13.Text.Trim().Length==0)
			{
				strErr+="tctunset13不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string community_id=this.lblcommunity_id.Text;
			int community_passenger_station_num=int.Parse(this.txtcommunity_passenger_station_num.Text);
			decimal community_station_waiting_room_area=decimal.Parse(this.txtcommunity_station_waiting_room_area.Text);
			decimal community_station_parking_lot_area=decimal.Parse(this.txtcommunity_station_parking_lot_area.Text);
			int community_bus_trips=int.Parse(this.txtcommunity_bus_trips.Text);
			int community_quay_num=int.Parse(this.txtcommunity_quay_num.Text);
			int community_passenger_and_goods_quay_num=int.Parse(this.txtcommunity_passenger_and_goods_quay_num.Text);
			int community_goods_quay_num=int.Parse(this.txtcommunity_goods_quay_num.Text);
			int community_passenger_quay_num=int.Parse(this.txtcommunity_passenger_quay_num.Text);
			int community_docking_point=int.Parse(this.txtcommunity_docking_point.Text);
			decimal community_passenger_quay_waiting_room_area=decimal.Parse(this.txtcommunity_passenger_quay_waiting_room_area.Text);
			decimal community_passenger_quay_parking_lot_area=decimal.Parse(this.txtcommunity_passenger_quay_parking_lot_area.Text);
			decimal community_passenger_quay_ship_trips=decimal.Parse(this.txtcommunity_passenger_quay_ship_trips.Text);
			decimal community_passenger_quay_dis_to_county=decimal.Parse(this.txtcommunity_passenger_quay_dis_to_county.Text);
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			string tctunset1=this.txttctunset1.Text;
			string tctunset2=this.txttctunset2.Text;
			string tctunset3=this.txttctunset3.Text;
			string tctunset4=this.txttctunset4.Text;
			string tctunset5=this.txttctunset5.Text;
			string tctunset6=this.txttctunset6.Text;
			string tctunset7=this.txttctunset7.Text;
			string tctunset8=this.txttctunset8.Text;
			string tctunset9=this.txttctunset9.Text;
			string tctunset10=this.txttctunset10.Text;
			string tctunset11=this.txttctunset11.Text;
			string tctunset12=this.txttctunset12.Text;
			string tctunset13=this.txttctunset13.Text;
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);


			TTG.Model.TTGWeb.community_traffic model=new TTG.Model.TTGWeb.community_traffic();
			model.community_id=community_id;
			model.community_passenger_station_num=community_passenger_station_num;
			model.community_station_waiting_room_area=community_station_waiting_room_area;
			model.community_station_parking_lot_area=community_station_parking_lot_area;
			model.community_bus_trips=community_bus_trips;
			model.community_quay_num=community_quay_num;
			model.community_passenger_and_goods_quay_num=community_passenger_and_goods_quay_num;
			model.community_goods_quay_num=community_goods_quay_num;
			model.community_passenger_quay_num=community_passenger_quay_num;
			model.community_docking_point=community_docking_point;
			model.community_passenger_quay_waiting_room_area=community_passenger_quay_waiting_room_area;
			model.community_passenger_quay_parking_lot_area=community_passenger_quay_parking_lot_area;
			model.community_passenger_quay_ship_trips=community_passenger_quay_ship_trips;
			model.community_passenger_quay_dis_to_county=community_passenger_quay_dis_to_county;
			model.statistics_date=statistics_date;
			model.tctunset1=tctunset1;
			model.tctunset2=tctunset2;
			model.tctunset3=tctunset3;
			model.tctunset4=tctunset4;
			model.tctunset5=tctunset5;
			model.tctunset6=tctunset6;
			model.tctunset7=tctunset7;
			model.tctunset8=tctunset8;
			model.tctunset9=tctunset9;
			model.tctunset10=tctunset10;
			model.tctunset11=tctunset11;
			model.tctunset12=tctunset12;
			model.tctunset13=tctunset13;
			model.lock_tables=lock_tables;
			model.check_status=check_status;

			TTG.BLL.TTGWeb.community_traffic bll=new TTG.BLL.TTGWeb.community_traffic();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
