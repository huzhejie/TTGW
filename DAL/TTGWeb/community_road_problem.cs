using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_road_problem
	/// </summary>
	public partial class community_road_problem
	{
		public community_road_problem()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,string community_fill_type,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_road_problem");
			strSql.Append(" where community_id=@community_id and community_fill_type=@community_fill_type and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime)			};
			parameters[0].Value = community_id;
			parameters[1].Value = community_fill_type;
			parameters[2].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_road_problem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_road_problem(");
			strSql.Append("community_id,community_fill_type,community_road_not_hardening_area,community_road_large_slope_length,community_road_insuf_width_length,community_road_pavement_damage_area,community_sidewalk_cb_damage_area,community_broken_road_num,community_sarea_lack_lroad,community_to_city_pasway_pavement_damage,community_to_city_pasway_pavement_insuf_width,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,lock_tables,complete_year)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_fill_type,@community_road_not_hardening_area,@community_road_large_slope_length,@community_road_insuf_width_length,@community_road_pavement_damage_area,@community_sidewalk_cb_damage_area,@community_broken_road_num,@community_sarea_lack_lroad,@community_to_city_pasway_pavement_damage,@community_to_city_pasway_pavement_insuf_width,@statistics_date,@check_status,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@tciunset7,@tciunset8,@tciunset9,@tciunset10,@tciunset11,@tciunset12,@tciunset13,@lock_tables,@complete_year)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@community_road_not_hardening_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_large_slope_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_insuf_width_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_pavement_damage_area", SqlDbType.Float,8),
					new SqlParameter("@community_sidewalk_cb_damage_area", SqlDbType.Float,8),
					new SqlParameter("@community_broken_road_num", SqlDbType.Int,4),
					new SqlParameter("@community_sarea_lack_lroad", SqlDbType.Int,4),
					new SqlParameter("@community_to_city_pasway_pavement_damage", SqlDbType.Float,8),
					new SqlParameter("@community_to_city_pasway_pavement_insuf_width", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.DateTime),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@complete_year", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_fill_type;
			parameters[2].Value = model.community_road_not_hardening_area;
			parameters[3].Value = model.community_road_large_slope_length;
			parameters[4].Value = model.community_road_insuf_width_length;
			parameters[5].Value = model.community_road_pavement_damage_area;
			parameters[6].Value = model.community_sidewalk_cb_damage_area;
			parameters[7].Value = model.community_broken_road_num;
			parameters[8].Value = model.community_sarea_lack_lroad;
			parameters[9].Value = model.community_to_city_pasway_pavement_damage;
			parameters[10].Value = model.community_to_city_pasway_pavement_insuf_width;
			parameters[11].Value = model.statistics_date;
			parameters[12].Value = model.check_status;
			parameters[13].Value = model.tciunset1;
			parameters[14].Value = model.tciunset2;
			parameters[15].Value = model.tciunset3;
			parameters[16].Value = model.tciunset4;
			parameters[17].Value = model.tciunset5;
			parameters[18].Value = model.tciunset6;
			parameters[19].Value = model.tciunset7;
			parameters[20].Value = model.tciunset8;
			parameters[21].Value = model.tciunset9;
			parameters[22].Value = model.tciunset10;
			parameters[23].Value = model.tciunset11;
			parameters[24].Value = model.tciunset12;
			parameters[25].Value = model.tciunset13;
			parameters[26].Value = model.lock_tables;
			parameters[27].Value = model.complete_year;

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
		public bool Update(TTG.Model.TTGWeb.community_road_problem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_road_problem set ");
			strSql.Append("community_road_not_hardening_area=@community_road_not_hardening_area,");
			strSql.Append("community_road_large_slope_length=@community_road_large_slope_length,");
			strSql.Append("community_road_insuf_width_length=@community_road_insuf_width_length,");
			strSql.Append("community_road_pavement_damage_area=@community_road_pavement_damage_area,");
			strSql.Append("community_sidewalk_cb_damage_area=@community_sidewalk_cb_damage_area,");
			strSql.Append("community_broken_road_num=@community_broken_road_num,");
			strSql.Append("community_sarea_lack_lroad=@community_sarea_lack_lroad,");
			strSql.Append("community_to_city_pasway_pavement_damage=@community_to_city_pasway_pavement_damage,");
			strSql.Append("community_to_city_pasway_pavement_insuf_width=@community_to_city_pasway_pavement_insuf_width,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("tciunset5=@tciunset5,");
			strSql.Append("tciunset6=@tciunset6,");
			strSql.Append("tciunset7=@tciunset7,");
			strSql.Append("tciunset8=@tciunset8,");
			strSql.Append("tciunset9=@tciunset9,");
			strSql.Append("tciunset10=@tciunset10,");
			strSql.Append("tciunset11=@tciunset11,");
			strSql.Append("tciunset12=@tciunset12,");
			strSql.Append("tciunset13=@tciunset13,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("complete_year=@complete_year");
			strSql.Append(" where community_id=@community_id and community_fill_type=@community_fill_type and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_road_not_hardening_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_large_slope_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_insuf_width_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_pavement_damage_area", SqlDbType.Float,8),
					new SqlParameter("@community_sidewalk_cb_damage_area", SqlDbType.Float,8),
					new SqlParameter("@community_broken_road_num", SqlDbType.Int,4),
					new SqlParameter("@community_sarea_lack_lroad", SqlDbType.Int,4),
					new SqlParameter("@community_to_city_pasway_pavement_damage", SqlDbType.Float,8),
					new SqlParameter("@community_to_city_pasway_pavement_insuf_width", SqlDbType.Float,8),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@complete_year", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime)};
			parameters[0].Value = model.community_road_not_hardening_area;
			parameters[1].Value = model.community_road_large_slope_length;
			parameters[2].Value = model.community_road_insuf_width_length;
			parameters[3].Value = model.community_road_pavement_damage_area;
			parameters[4].Value = model.community_sidewalk_cb_damage_area;
			parameters[5].Value = model.community_broken_road_num;
			parameters[6].Value = model.community_sarea_lack_lroad;
			parameters[7].Value = model.community_to_city_pasway_pavement_damage;
			parameters[8].Value = model.community_to_city_pasway_pavement_insuf_width;
			parameters[9].Value = model.check_status;
			parameters[10].Value = model.tciunset1;
			parameters[11].Value = model.tciunset2;
			parameters[12].Value = model.tciunset3;
			parameters[13].Value = model.tciunset4;
			parameters[14].Value = model.tciunset5;
			parameters[15].Value = model.tciunset6;
			parameters[16].Value = model.tciunset7;
			parameters[17].Value = model.tciunset8;
			parameters[18].Value = model.tciunset9;
			parameters[19].Value = model.tciunset10;
			parameters[20].Value = model.tciunset11;
			parameters[21].Value = model.tciunset12;
			parameters[22].Value = model.tciunset13;
			parameters[23].Value = model.lock_tables;
			parameters[24].Value = model.complete_year;
			parameters[25].Value = model.community_id;
			parameters[26].Value = model.community_fill_type;
			parameters[27].Value = model.statistics_date;

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
		public bool Delete(string community_id,string community_fill_type,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_road_problem ");
			strSql.Append(" where community_id=@community_id and community_fill_type=@community_fill_type and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime)			};
			parameters[0].Value = community_id;
			parameters[1].Value = community_fill_type;
			parameters[2].Value = statistics_date;

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
		public TTG.Model.TTGWeb.community_road_problem GetModel(string community_id,string community_fill_type,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_fill_type,community_road_not_hardening_area,community_road_large_slope_length,community_road_insuf_width_length,community_road_pavement_damage_area,community_sidewalk_cb_damage_area,community_broken_road_num,community_sarea_lack_lroad,community_to_city_pasway_pavement_damage,community_to_city_pasway_pavement_insuf_width,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,lock_tables,complete_year from T_community_road_problem ");
			strSql.Append(" where community_id=@community_id and community_fill_type=@community_fill_type and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime)			};
			parameters[0].Value = community_id;
			parameters[1].Value = community_fill_type;
			parameters[2].Value = statistics_date;

			TTG.Model.TTGWeb.community_road_problem model=new TTG.Model.TTGWeb.community_road_problem();
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
		public TTG.Model.TTGWeb.community_road_problem DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_road_problem model=new TTG.Model.TTGWeb.community_road_problem();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_fill_type"]!=null)
				{
					model.community_fill_type=row["community_fill_type"].ToString();
				}
				if(row["community_road_not_hardening_area"]!=null && row["community_road_not_hardening_area"].ToString()!="")
				{
					model.community_road_not_hardening_area=decimal.Parse(row["community_road_not_hardening_area"].ToString());
				}
				if(row["community_road_large_slope_length"]!=null && row["community_road_large_slope_length"].ToString()!="")
				{
					model.community_road_large_slope_length=decimal.Parse(row["community_road_large_slope_length"].ToString());
				}
				if(row["community_road_insuf_width_length"]!=null && row["community_road_insuf_width_length"].ToString()!="")
				{
					model.community_road_insuf_width_length=decimal.Parse(row["community_road_insuf_width_length"].ToString());
				}
				if(row["community_road_pavement_damage_area"]!=null && row["community_road_pavement_damage_area"].ToString()!="")
				{
					model.community_road_pavement_damage_area=decimal.Parse(row["community_road_pavement_damage_area"].ToString());
				}
				if(row["community_sidewalk_cb_damage_area"]!=null && row["community_sidewalk_cb_damage_area"].ToString()!="")
				{
					model.community_sidewalk_cb_damage_area=decimal.Parse(row["community_sidewalk_cb_damage_area"].ToString());
				}
				if(row["community_broken_road_num"]!=null && row["community_broken_road_num"].ToString()!="")
				{
					model.community_broken_road_num=int.Parse(row["community_broken_road_num"].ToString());
				}
				if(row["community_sarea_lack_lroad"]!=null && row["community_sarea_lack_lroad"].ToString()!="")
				{
					model.community_sarea_lack_lroad=int.Parse(row["community_sarea_lack_lroad"].ToString());
				}
				if(row["community_to_city_pasway_pavement_damage"]!=null && row["community_to_city_pasway_pavement_damage"].ToString()!="")
				{
					model.community_to_city_pasway_pavement_damage=decimal.Parse(row["community_to_city_pasway_pavement_damage"].ToString());
				}
				if(row["community_to_city_pasway_pavement_insuf_width"]!=null && row["community_to_city_pasway_pavement_insuf_width"].ToString()!="")
				{
					model.community_to_city_pasway_pavement_insuf_width=decimal.Parse(row["community_to_city_pasway_pavement_insuf_width"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["tciunset1"]!=null)
				{
					model.tciunset1=row["tciunset1"].ToString();
				}
				if(row["tciunset2"]!=null)
				{
					model.tciunset2=row["tciunset2"].ToString();
				}
				if(row["tciunset3"]!=null)
				{
					model.tciunset3=row["tciunset3"].ToString();
				}
				if(row["tciunset4"]!=null)
				{
					model.tciunset4=row["tciunset4"].ToString();
				}
				if(row["tciunset5"]!=null)
				{
					model.tciunset5=row["tciunset5"].ToString();
				}
				if(row["tciunset6"]!=null)
				{
					model.tciunset6=row["tciunset6"].ToString();
				}
				if(row["tciunset7"]!=null)
				{
					model.tciunset7=row["tciunset7"].ToString();
				}
				if(row["tciunset8"]!=null)
				{
					model.tciunset8=row["tciunset8"].ToString();
				}
				if(row["tciunset9"]!=null)
				{
					model.tciunset9=row["tciunset9"].ToString();
				}
				if(row["tciunset10"]!=null)
				{
					model.tciunset10=row["tciunset10"].ToString();
				}
				if(row["tciunset11"]!=null)
				{
					model.tciunset11=row["tciunset11"].ToString();
				}
				if(row["tciunset12"]!=null)
				{
					model.tciunset12=row["tciunset12"].ToString();
				}
				if(row["tciunset13"]!=null)
				{
					model.tciunset13=row["tciunset13"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["complete_year"]!=null && row["complete_year"].ToString()!="")
				{
					model.complete_year=int.Parse(row["complete_year"].ToString());
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
			strSql.Append("select community_id,community_fill_type,community_road_not_hardening_area,community_road_large_slope_length,community_road_insuf_width_length,community_road_pavement_damage_area,community_sidewalk_cb_damage_area,community_broken_road_num,community_sarea_lack_lroad,community_to_city_pasway_pavement_damage,community_to_city_pasway_pavement_insuf_width,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,lock_tables,complete_year ");
			strSql.Append(" FROM T_community_road_problem ");
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
			strSql.Append(" community_id,community_fill_type,community_road_not_hardening_area,community_road_large_slope_length,community_road_insuf_width_length,community_road_pavement_damage_area,community_sidewalk_cb_damage_area,community_broken_road_num,community_sarea_lack_lroad,community_to_city_pasway_pavement_damage,community_to_city_pasway_pavement_insuf_width,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,lock_tables,complete_year ");
			strSql.Append(" FROM T_community_road_problem ");
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
			strSql.Append("select count(1) FROM T_community_road_problem ");
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
			strSql.Append(")AS Row, T.*  from T_community_road_problem T ");
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
			parameters[0].Value = "T_community_road_problem";
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

