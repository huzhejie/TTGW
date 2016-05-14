using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_land
	/// </summary>
	public partial class community_land
	{
		public community_land()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_land");
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
		public bool Add(TTG.Model.TTGWeb.community_land model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_land(");
			strSql.Append("community_id,community_total_land_area,community_house_land_area,community_public_building_land_area,community_road_land_area,community_public_greenland_area,community_industry_land_area,community_warehousing_land_area,community_traffic_land_area,community_municipal_administration_land_area,community_other_land_area,statistics_date,tclunset1,tclunset2,tclunset3,tclunset4,tclunset5,tclunset6,tclunset7,tclunset8,tclunset9,tclunset10,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_total_land_area,@community_house_land_area,@community_public_building_land_area,@community_road_land_area,@community_public_greenland_area,@community_industry_land_area,@community_warehousing_land_area,@community_traffic_land_area,@community_municipal_administration_land_area,@community_other_land_area,@statistics_date,@tclunset1,@tclunset2,@tclunset3,@tclunset4,@tclunset5,@tclunset6,@tclunset7,@tclunset8,@tclunset9,@tclunset10,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_total_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_house_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_public_building_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_public_greenland_area", SqlDbType.Float,8),
					new SqlParameter("@community_industry_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_warehousing_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_traffic_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_municipal_administration_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_other_land_area", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tclunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset10", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_total_land_area;
			parameters[2].Value = model.community_house_land_area;
			parameters[3].Value = model.community_public_building_land_area;
			parameters[4].Value = model.community_road_land_area;
			parameters[5].Value = model.community_public_greenland_area;
			parameters[6].Value = model.community_industry_land_area;
			parameters[7].Value = model.community_warehousing_land_area;
			parameters[8].Value = model.community_traffic_land_area;
			parameters[9].Value = model.community_municipal_administration_land_area;
			parameters[10].Value = model.community_other_land_area;
			parameters[11].Value = model.statistics_date;
			parameters[12].Value = model.tclunset1;
			parameters[13].Value = model.tclunset2;
			parameters[14].Value = model.tclunset3;
			parameters[15].Value = model.tclunset4;
			parameters[16].Value = model.tclunset5;
			parameters[17].Value = model.tclunset6;
			parameters[18].Value = model.tclunset7;
			parameters[19].Value = model.tclunset8;
			parameters[20].Value = model.tclunset9;
			parameters[21].Value = model.tclunset10;
			parameters[22].Value = model.lock_tables;
			parameters[23].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_land model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_land set ");
			strSql.Append("community_total_land_area=@community_total_land_area,");
			strSql.Append("community_house_land_area=@community_house_land_area,");
			strSql.Append("community_public_building_land_area=@community_public_building_land_area,");
			strSql.Append("community_road_land_area=@community_road_land_area,");
			strSql.Append("community_public_greenland_area=@community_public_greenland_area,");
			strSql.Append("community_industry_land_area=@community_industry_land_area,");
			strSql.Append("community_warehousing_land_area=@community_warehousing_land_area,");
			strSql.Append("community_traffic_land_area=@community_traffic_land_area,");
			strSql.Append("community_municipal_administration_land_area=@community_municipal_administration_land_area,");
			strSql.Append("community_other_land_area=@community_other_land_area,");
			strSql.Append("tclunset1=@tclunset1,");
			strSql.Append("tclunset2=@tclunset2,");
			strSql.Append("tclunset3=@tclunset3,");
			strSql.Append("tclunset4=@tclunset4,");
			strSql.Append("tclunset5=@tclunset5,");
			strSql.Append("tclunset6=@tclunset6,");
			strSql.Append("tclunset7=@tclunset7,");
			strSql.Append("tclunset8=@tclunset8,");
			strSql.Append("tclunset9=@tclunset9,");
			strSql.Append("tclunset10=@tclunset10,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_total_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_house_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_public_building_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_public_greenland_area", SqlDbType.Float,8),
					new SqlParameter("@community_industry_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_warehousing_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_traffic_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_municipal_administration_land_area", SqlDbType.Float,8),
					new SqlParameter("@community_other_land_area", SqlDbType.Float,8),
					new SqlParameter("@tclunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tclunset10", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_total_land_area;
			parameters[1].Value = model.community_house_land_area;
			parameters[2].Value = model.community_public_building_land_area;
			parameters[3].Value = model.community_road_land_area;
			parameters[4].Value = model.community_public_greenland_area;
			parameters[5].Value = model.community_industry_land_area;
			parameters[6].Value = model.community_warehousing_land_area;
			parameters[7].Value = model.community_traffic_land_area;
			parameters[8].Value = model.community_municipal_administration_land_area;
			parameters[9].Value = model.community_other_land_area;
			parameters[10].Value = model.tclunset1;
			parameters[11].Value = model.tclunset2;
			parameters[12].Value = model.tclunset3;
			parameters[13].Value = model.tclunset4;
			parameters[14].Value = model.tclunset5;
			parameters[15].Value = model.tclunset6;
			parameters[16].Value = model.tclunset7;
			parameters[17].Value = model.tclunset8;
			parameters[18].Value = model.tclunset9;
			parameters[19].Value = model.tclunset10;
			parameters[20].Value = model.lock_tables;
			parameters[21].Value = model.check_status;
			parameters[22].Value = model.community_id;
			parameters[23].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_land ");
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
		public TTG.Model.TTGWeb.community_land GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_total_land_area,community_house_land_area,community_public_building_land_area,community_road_land_area,community_public_greenland_area,community_industry_land_area,community_warehousing_land_area,community_traffic_land_area,community_municipal_administration_land_area,community_other_land_area,statistics_date,tclunset1,tclunset2,tclunset3,tclunset4,tclunset5,tclunset6,tclunset7,tclunset8,tclunset9,tclunset10,lock_tables,check_status from T_community_land ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_land model=new TTG.Model.TTGWeb.community_land();
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
		public TTG.Model.TTGWeb.community_land DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_land model=new TTG.Model.TTGWeb.community_land();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_total_land_area"]!=null && row["community_total_land_area"].ToString()!="")
				{
					model.community_total_land_area=decimal.Parse(row["community_total_land_area"].ToString());
				}
				if(row["community_house_land_area"]!=null && row["community_house_land_area"].ToString()!="")
				{
					model.community_house_land_area=decimal.Parse(row["community_house_land_area"].ToString());
				}
				if(row["community_public_building_land_area"]!=null && row["community_public_building_land_area"].ToString()!="")
				{
					model.community_public_building_land_area=decimal.Parse(row["community_public_building_land_area"].ToString());
				}
				if(row["community_road_land_area"]!=null && row["community_road_land_area"].ToString()!="")
				{
					model.community_road_land_area=decimal.Parse(row["community_road_land_area"].ToString());
				}
				if(row["community_public_greenland_area"]!=null && row["community_public_greenland_area"].ToString()!="")
				{
					model.community_public_greenland_area=decimal.Parse(row["community_public_greenland_area"].ToString());
				}
				if(row["community_industry_land_area"]!=null && row["community_industry_land_area"].ToString()!="")
				{
					model.community_industry_land_area=decimal.Parse(row["community_industry_land_area"].ToString());
				}
				if(row["community_warehousing_land_area"]!=null && row["community_warehousing_land_area"].ToString()!="")
				{
					model.community_warehousing_land_area=decimal.Parse(row["community_warehousing_land_area"].ToString());
				}
				if(row["community_traffic_land_area"]!=null && row["community_traffic_land_area"].ToString()!="")
				{
					model.community_traffic_land_area=decimal.Parse(row["community_traffic_land_area"].ToString());
				}
				if(row["community_municipal_administration_land_area"]!=null && row["community_municipal_administration_land_area"].ToString()!="")
				{
					model.community_municipal_administration_land_area=decimal.Parse(row["community_municipal_administration_land_area"].ToString());
				}
				if(row["community_other_land_area"]!=null && row["community_other_land_area"].ToString()!="")
				{
					model.community_other_land_area=decimal.Parse(row["community_other_land_area"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tclunset1"]!=null)
				{
					model.tclunset1=row["tclunset1"].ToString();
				}
				if(row["tclunset2"]!=null)
				{
					model.tclunset2=row["tclunset2"].ToString();
				}
				if(row["tclunset3"]!=null)
				{
					model.tclunset3=row["tclunset3"].ToString();
				}
				if(row["tclunset4"]!=null)
				{
					model.tclunset4=row["tclunset4"].ToString();
				}
				if(row["tclunset5"]!=null)
				{
					model.tclunset5=row["tclunset5"].ToString();
				}
				if(row["tclunset6"]!=null)
				{
					model.tclunset6=row["tclunset6"].ToString();
				}
				if(row["tclunset7"]!=null)
				{
					model.tclunset7=row["tclunset7"].ToString();
				}
				if(row["tclunset8"]!=null)
				{
					model.tclunset8=row["tclunset8"].ToString();
				}
				if(row["tclunset9"]!=null)
				{
					model.tclunset9=row["tclunset9"].ToString();
				}
				if(row["tclunset10"]!=null)
				{
					model.tclunset10=row["tclunset10"].ToString();
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
			strSql.Append("select community_id,community_total_land_area,community_house_land_area,community_public_building_land_area,community_road_land_area,community_public_greenland_area,community_industry_land_area,community_warehousing_land_area,community_traffic_land_area,community_municipal_administration_land_area,community_other_land_area,statistics_date,tclunset1,tclunset2,tclunset3,tclunset4,tclunset5,tclunset6,tclunset7,tclunset8,tclunset9,tclunset10,lock_tables,check_status ");
			strSql.Append(" FROM T_community_land ");
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
			strSql.Append(" community_id,community_total_land_area,community_house_land_area,community_public_building_land_area,community_road_land_area,community_public_greenland_area,community_industry_land_area,community_warehousing_land_area,community_traffic_land_area,community_municipal_administration_land_area,community_other_land_area,statistics_date,tclunset1,tclunset2,tclunset3,tclunset4,tclunset5,tclunset6,tclunset7,tclunset8,tclunset9,tclunset10,lock_tables,check_status ");
			strSql.Append(" FROM T_community_land ");
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
			strSql.Append("select count(1) FROM T_community_land ");
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
			strSql.Append(")AS Row, T.*  from T_community_land T ");
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
			parameters[0].Value = "T_community_land";
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

