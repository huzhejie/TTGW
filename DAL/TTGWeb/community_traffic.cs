using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_traffic
	/// </summary>
	public partial class community_traffic
	{
		public community_traffic()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_traffic");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_traffic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_traffic(");
			strSql.Append("community_id,community_passenger_station_num,community_station_waiting_room_area,community_station_parking_lot_area,community_bus_trips,community_quay_num,community_passenger_and_goods_quay_num,community_goods_quay_num,community_passenger_quay_num,community_docking_point,community_passenger_quay_waiting_room_area,community_passenger_quay_parking_lot_area,community_passenger_quay_ship_trips,community_passenger_quay_dis_to_county,statistics_date,tctunset1,tctunset2,tctunset3,tctunset4,tctunset5,tctunset6,tctunset7,tctunset8,tctunset9,tctunset10,tctunset11,tctunset12,tctunset13,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_passenger_station_num,@community_station_waiting_room_area,@community_station_parking_lot_area,@community_bus_trips,@community_quay_num,@community_passenger_and_goods_quay_num,@community_goods_quay_num,@community_passenger_quay_num,@community_docking_point,@community_passenger_quay_waiting_room_area,@community_passenger_quay_parking_lot_area,@community_passenger_quay_ship_trips,@community_passenger_quay_dis_to_county,@statistics_date,@tctunset1,@tctunset2,@tctunset3,@tctunset4,@tctunset5,@tctunset6,@tctunset7,@tctunset8,@tctunset9,@tctunset10,@tctunset11,@tctunset12,@tctunset13,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_passenger_station_num", SqlDbType.Int,4),
					new SqlParameter("@community_station_waiting_room_area", SqlDbType.Float,8),
					new SqlParameter("@community_station_parking_lot_area", SqlDbType.Float,8),
					new SqlParameter("@community_bus_trips", SqlDbType.Int,4),
					new SqlParameter("@community_quay_num", SqlDbType.Int,4),
					new SqlParameter("@community_passenger_and_goods_quay_num", SqlDbType.Int,4),
					new SqlParameter("@community_goods_quay_num", SqlDbType.Int,4),
					new SqlParameter("@community_passenger_quay_num", SqlDbType.Int,4),
					new SqlParameter("@community_docking_point", SqlDbType.Int,4),
					new SqlParameter("@community_passenger_quay_waiting_room_area", SqlDbType.Float,8),
					new SqlParameter("@community_passenger_quay_parking_lot_area", SqlDbType.Float,8),
					new SqlParameter("@community_passenger_quay_ship_trips", SqlDbType.Float,8),
					new SqlParameter("@community_passenger_quay_dis_to_county", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tctunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_passenger_station_num;
			parameters[2].Value = model.community_station_waiting_room_area;
			parameters[3].Value = model.community_station_parking_lot_area;
			parameters[4].Value = model.community_bus_trips;
			parameters[5].Value = model.community_quay_num;
			parameters[6].Value = model.community_passenger_and_goods_quay_num;
			parameters[7].Value = model.community_goods_quay_num;
			parameters[8].Value = model.community_passenger_quay_num;
			parameters[9].Value = model.community_docking_point;
			parameters[10].Value = model.community_passenger_quay_waiting_room_area;
			parameters[11].Value = model.community_passenger_quay_parking_lot_area;
			parameters[12].Value = model.community_passenger_quay_ship_trips;
			parameters[13].Value = model.community_passenger_quay_dis_to_county;
			parameters[14].Value = model.statistics_date;
			parameters[15].Value = model.tctunset1;
			parameters[16].Value = model.tctunset2;
			parameters[17].Value = model.tctunset3;
			parameters[18].Value = model.tctunset4;
			parameters[19].Value = model.tctunset5;
			parameters[20].Value = model.tctunset6;
			parameters[21].Value = model.tctunset7;
			parameters[22].Value = model.tctunset8;
			parameters[23].Value = model.tctunset9;
			parameters[24].Value = model.tctunset10;
			parameters[25].Value = model.tctunset11;
			parameters[26].Value = model.tctunset12;
			parameters[27].Value = model.tctunset13;
			parameters[28].Value = model.lock_tables;
			parameters[29].Value = model.check_status;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.community_traffic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_traffic set ");
			strSql.Append("community_passenger_station_num=@community_passenger_station_num,");
			strSql.Append("community_station_waiting_room_area=@community_station_waiting_room_area,");
			strSql.Append("community_station_parking_lot_area=@community_station_parking_lot_area,");
			strSql.Append("community_bus_trips=@community_bus_trips,");
			strSql.Append("community_quay_num=@community_quay_num,");
			strSql.Append("community_passenger_and_goods_quay_num=@community_passenger_and_goods_quay_num,");
			strSql.Append("community_goods_quay_num=@community_goods_quay_num,");
			strSql.Append("community_passenger_quay_num=@community_passenger_quay_num,");
			strSql.Append("community_docking_point=@community_docking_point,");
			strSql.Append("community_passenger_quay_waiting_room_area=@community_passenger_quay_waiting_room_area,");
			strSql.Append("community_passenger_quay_parking_lot_area=@community_passenger_quay_parking_lot_area,");
			strSql.Append("community_passenger_quay_ship_trips=@community_passenger_quay_ship_trips,");
			strSql.Append("community_passenger_quay_dis_to_county=@community_passenger_quay_dis_to_county,");
			strSql.Append("tctunset1=@tctunset1,");
			strSql.Append("tctunset2=@tctunset2,");
			strSql.Append("tctunset3=@tctunset3,");
			strSql.Append("tctunset4=@tctunset4,");
			strSql.Append("tctunset5=@tctunset5,");
			strSql.Append("tctunset6=@tctunset6,");
			strSql.Append("tctunset7=@tctunset7,");
			strSql.Append("tctunset8=@tctunset8,");
			strSql.Append("tctunset9=@tctunset9,");
			strSql.Append("tctunset10=@tctunset10,");
			strSql.Append("tctunset11=@tctunset11,");
			strSql.Append("tctunset12=@tctunset12,");
			strSql.Append("tctunset13=@tctunset13,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_passenger_station_num", SqlDbType.Int,4),
					new SqlParameter("@community_station_waiting_room_area", SqlDbType.Float,8),
					new SqlParameter("@community_station_parking_lot_area", SqlDbType.Float,8),
					new SqlParameter("@community_bus_trips", SqlDbType.Int,4),
					new SqlParameter("@community_quay_num", SqlDbType.Int,4),
					new SqlParameter("@community_passenger_and_goods_quay_num", SqlDbType.Int,4),
					new SqlParameter("@community_goods_quay_num", SqlDbType.Int,4),
					new SqlParameter("@community_passenger_quay_num", SqlDbType.Int,4),
					new SqlParameter("@community_docking_point", SqlDbType.Int,4),
					new SqlParameter("@community_passenger_quay_waiting_room_area", SqlDbType.Float,8),
					new SqlParameter("@community_passenger_quay_parking_lot_area", SqlDbType.Float,8),
					new SqlParameter("@community_passenger_quay_ship_trips", SqlDbType.Float,8),
					new SqlParameter("@community_passenger_quay_dis_to_county", SqlDbType.Float,8),
					new SqlParameter("@tctunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tctunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_passenger_station_num;
			parameters[1].Value = model.community_station_waiting_room_area;
			parameters[2].Value = model.community_station_parking_lot_area;
			parameters[3].Value = model.community_bus_trips;
			parameters[4].Value = model.community_quay_num;
			parameters[5].Value = model.community_passenger_and_goods_quay_num;
			parameters[6].Value = model.community_goods_quay_num;
			parameters[7].Value = model.community_passenger_quay_num;
			parameters[8].Value = model.community_docking_point;
			parameters[9].Value = model.community_passenger_quay_waiting_room_area;
			parameters[10].Value = model.community_passenger_quay_parking_lot_area;
			parameters[11].Value = model.community_passenger_quay_ship_trips;
			parameters[12].Value = model.community_passenger_quay_dis_to_county;
			parameters[13].Value = model.tctunset1;
			parameters[14].Value = model.tctunset2;
			parameters[15].Value = model.tctunset3;
			parameters[16].Value = model.tctunset4;
			parameters[17].Value = model.tctunset5;
			parameters[18].Value = model.tctunset6;
			parameters[19].Value = model.tctunset7;
			parameters[20].Value = model.tctunset8;
			parameters[21].Value = model.tctunset9;
			parameters[22].Value = model.tctunset10;
			parameters[23].Value = model.tctunset11;
			parameters[24].Value = model.tctunset12;
			parameters[25].Value = model.tctunset13;
			parameters[26].Value = model.lock_tables;
			parameters[27].Value = model.check_status;
			parameters[28].Value = model.community_id;
			parameters[29].Value = model.statistics_date;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_traffic ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.community_traffic GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_passenger_station_num,community_station_waiting_room_area,community_station_parking_lot_area,community_bus_trips,community_quay_num,community_passenger_and_goods_quay_num,community_goods_quay_num,community_passenger_quay_num,community_docking_point,community_passenger_quay_waiting_room_area,community_passenger_quay_parking_lot_area,community_passenger_quay_ship_trips,community_passenger_quay_dis_to_county,statistics_date,tctunset1,tctunset2,tctunset3,tctunset4,tctunset5,tctunset6,tctunset7,tctunset8,tctunset9,tctunset10,tctunset11,tctunset12,tctunset13,lock_tables,check_status from T_community_traffic ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_traffic model=new TTG.Model.TTGWeb.community_traffic();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TTG.Model.TTGWeb.community_traffic DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_traffic model=new TTG.Model.TTGWeb.community_traffic();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_passenger_station_num"]!=null && row["community_passenger_station_num"].ToString()!="")
				{
					model.community_passenger_station_num=int.Parse(row["community_passenger_station_num"].ToString());
				}
				if(row["community_station_waiting_room_area"]!=null && row["community_station_waiting_room_area"].ToString()!="")
				{
					model.community_station_waiting_room_area=decimal.Parse(row["community_station_waiting_room_area"].ToString());
				}
				if(row["community_station_parking_lot_area"]!=null && row["community_station_parking_lot_area"].ToString()!="")
				{
					model.community_station_parking_lot_area=decimal.Parse(row["community_station_parking_lot_area"].ToString());
				}
				if(row["community_bus_trips"]!=null && row["community_bus_trips"].ToString()!="")
				{
					model.community_bus_trips=int.Parse(row["community_bus_trips"].ToString());
				}
				if(row["community_quay_num"]!=null && row["community_quay_num"].ToString()!="")
				{
					model.community_quay_num=int.Parse(row["community_quay_num"].ToString());
				}
				if(row["community_passenger_and_goods_quay_num"]!=null && row["community_passenger_and_goods_quay_num"].ToString()!="")
				{
					model.community_passenger_and_goods_quay_num=int.Parse(row["community_passenger_and_goods_quay_num"].ToString());
				}
				if(row["community_goods_quay_num"]!=null && row["community_goods_quay_num"].ToString()!="")
				{
					model.community_goods_quay_num=int.Parse(row["community_goods_quay_num"].ToString());
				}
				if(row["community_passenger_quay_num"]!=null && row["community_passenger_quay_num"].ToString()!="")
				{
					model.community_passenger_quay_num=int.Parse(row["community_passenger_quay_num"].ToString());
				}
				if(row["community_docking_point"]!=null && row["community_docking_point"].ToString()!="")
				{
					model.community_docking_point=int.Parse(row["community_docking_point"].ToString());
				}
				if(row["community_passenger_quay_waiting_room_area"]!=null && row["community_passenger_quay_waiting_room_area"].ToString()!="")
				{
					model.community_passenger_quay_waiting_room_area=decimal.Parse(row["community_passenger_quay_waiting_room_area"].ToString());
				}
				if(row["community_passenger_quay_parking_lot_area"]!=null && row["community_passenger_quay_parking_lot_area"].ToString()!="")
				{
					model.community_passenger_quay_parking_lot_area=decimal.Parse(row["community_passenger_quay_parking_lot_area"].ToString());
				}
				if(row["community_passenger_quay_ship_trips"]!=null && row["community_passenger_quay_ship_trips"].ToString()!="")
				{
					model.community_passenger_quay_ship_trips=decimal.Parse(row["community_passenger_quay_ship_trips"].ToString());
				}
				if(row["community_passenger_quay_dis_to_county"]!=null && row["community_passenger_quay_dis_to_county"].ToString()!="")
				{
					model.community_passenger_quay_dis_to_county=decimal.Parse(row["community_passenger_quay_dis_to_county"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tctunset1"]!=null)
				{
					model.tctunset1=row["tctunset1"].ToString();
				}
				if(row["tctunset2"]!=null)
				{
					model.tctunset2=row["tctunset2"].ToString();
				}
				if(row["tctunset3"]!=null)
				{
					model.tctunset3=row["tctunset3"].ToString();
				}
				if(row["tctunset4"]!=null)
				{
					model.tctunset4=row["tctunset4"].ToString();
				}
				if(row["tctunset5"]!=null)
				{
					model.tctunset5=row["tctunset5"].ToString();
				}
				if(row["tctunset6"]!=null)
				{
					model.tctunset6=row["tctunset6"].ToString();
				}
				if(row["tctunset7"]!=null)
				{
					model.tctunset7=row["tctunset7"].ToString();
				}
				if(row["tctunset8"]!=null)
				{
					model.tctunset8=row["tctunset8"].ToString();
				}
				if(row["tctunset9"]!=null)
				{
					model.tctunset9=row["tctunset9"].ToString();
				}
				if(row["tctunset10"]!=null)
				{
					model.tctunset10=row["tctunset10"].ToString();
				}
				if(row["tctunset11"]!=null)
				{
					model.tctunset11=row["tctunset11"].ToString();
				}
				if(row["tctunset12"]!=null)
				{
					model.tctunset12=row["tctunset12"].ToString();
				}
				if(row["tctunset13"]!=null)
				{
					model.tctunset13=row["tctunset13"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select community_id,community_passenger_station_num,community_station_waiting_room_area,community_station_parking_lot_area,community_bus_trips,community_quay_num,community_passenger_and_goods_quay_num,community_goods_quay_num,community_passenger_quay_num,community_docking_point,community_passenger_quay_waiting_room_area,community_passenger_quay_parking_lot_area,community_passenger_quay_ship_trips,community_passenger_quay_dis_to_county,statistics_date,tctunset1,tctunset2,tctunset3,tctunset4,tctunset5,tctunset6,tctunset7,tctunset8,tctunset9,tctunset10,tctunset11,tctunset12,tctunset13,lock_tables,check_status ");
			strSql.Append(" FROM T_community_traffic ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" community_id,community_passenger_station_num,community_station_waiting_room_area,community_station_parking_lot_area,community_bus_trips,community_quay_num,community_passenger_and_goods_quay_num,community_goods_quay_num,community_passenger_quay_num,community_docking_point,community_passenger_quay_waiting_room_area,community_passenger_quay_parking_lot_area,community_passenger_quay_ship_trips,community_passenger_quay_dis_to_county,statistics_date,tctunset1,tctunset2,tctunset3,tctunset4,tctunset5,tctunset6,tctunset7,tctunset8,tctunset9,tctunset10,tctunset11,tctunset12,tctunset13,lock_tables,check_status ");
			strSql.Append(" FROM T_community_traffic ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_community_traffic ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.statistics_date desc");
			}
			strSql.Append(")AS Row, T.*  from T_community_traffic T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_community_traffic";
			parameters[1].Value = "statistics_date";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

