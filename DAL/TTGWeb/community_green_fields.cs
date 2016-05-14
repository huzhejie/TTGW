using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_green_fields
	/// </summary>
	public partial class community_green_fields
	{
		public community_green_fields()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_green_fields");
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
		public bool Add(TTG.Model.TTGWeb.community_green_fields model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_green_fields(");
			strSql.Append("community_id,community_green_fields_area,community_park_green_fields_area,community_garden_green_fields_area,community_other_green_fields_area,statistics_date,community_green_fields_bet_dwellings_area,community_road_green_fields_area,community_public_accomm_green_fields_area,tcgfunset1,tcgfunset2,tcgfunset3,tcgfunset4,tcgfunset5,tcgfunset6,tcgfunset7,lock_tables,check_status,green_rate_goal)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_green_fields_area,@community_park_green_fields_area,@community_garden_green_fields_area,@community_other_green_fields_area,@statistics_date,@community_green_fields_bet_dwellings_area,@community_road_green_fields_area,@community_public_accomm_green_fields_area,@tcgfunset1,@tcgfunset2,@tcgfunset3,@tcgfunset4,@tcgfunset5,@tcgfunset6,@tcgfunset7,@lock_tables,@check_status,@green_rate_goal)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_park_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_garden_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_other_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@community_green_fields_bet_dwellings_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_public_accomm_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@tcgfunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset7", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@green_rate_goal", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_green_fields_area;
			parameters[2].Value = model.community_park_green_fields_area;
			parameters[3].Value = model.community_garden_green_fields_area;
			parameters[4].Value = model.community_other_green_fields_area;
			parameters[5].Value = model.statistics_date;
			parameters[6].Value = model.community_green_fields_bet_dwellings_area;
			parameters[7].Value = model.community_road_green_fields_area;
			parameters[8].Value = model.community_public_accomm_green_fields_area;
			parameters[9].Value = model.tcgfunset1;
			parameters[10].Value = model.tcgfunset2;
			parameters[11].Value = model.tcgfunset3;
			parameters[12].Value = model.tcgfunset4;
			parameters[13].Value = model.tcgfunset5;
			parameters[14].Value = model.tcgfunset6;
			parameters[15].Value = model.tcgfunset7;
			parameters[16].Value = model.lock_tables;
			parameters[17].Value = model.check_status;
			parameters[18].Value = model.green_rate_goal;

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
		public bool Update(TTG.Model.TTGWeb.community_green_fields model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_green_fields set ");
			strSql.Append("community_green_fields_area=@community_green_fields_area,");
			strSql.Append("community_park_green_fields_area=@community_park_green_fields_area,");
			strSql.Append("community_garden_green_fields_area=@community_garden_green_fields_area,");
			strSql.Append("community_other_green_fields_area=@community_other_green_fields_area,");
			strSql.Append("community_green_fields_bet_dwellings_area=@community_green_fields_bet_dwellings_area,");
			strSql.Append("community_road_green_fields_area=@community_road_green_fields_area,");
			strSql.Append("community_public_accomm_green_fields_area=@community_public_accomm_green_fields_area,");
			strSql.Append("tcgfunset1=@tcgfunset1,");
			strSql.Append("tcgfunset2=@tcgfunset2,");
			strSql.Append("tcgfunset3=@tcgfunset3,");
			strSql.Append("tcgfunset4=@tcgfunset4,");
			strSql.Append("tcgfunset5=@tcgfunset5,");
			strSql.Append("tcgfunset6=@tcgfunset6,");
			strSql.Append("tcgfunset7=@tcgfunset7,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("green_rate_goal=@green_rate_goal");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_park_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_garden_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_other_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_green_fields_bet_dwellings_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@community_public_accomm_green_fields_area", SqlDbType.Float,8),
					new SqlParameter("@tcgfunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcgfunset7", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@green_rate_goal", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_green_fields_area;
			parameters[1].Value = model.community_park_green_fields_area;
			parameters[2].Value = model.community_garden_green_fields_area;
			parameters[3].Value = model.community_other_green_fields_area;
			parameters[4].Value = model.community_green_fields_bet_dwellings_area;
			parameters[5].Value = model.community_road_green_fields_area;
			parameters[6].Value = model.community_public_accomm_green_fields_area;
			parameters[7].Value = model.tcgfunset1;
			parameters[8].Value = model.tcgfunset2;
			parameters[9].Value = model.tcgfunset3;
			parameters[10].Value = model.tcgfunset4;
			parameters[11].Value = model.tcgfunset5;
			parameters[12].Value = model.tcgfunset6;
			parameters[13].Value = model.tcgfunset7;
			parameters[14].Value = model.lock_tables;
			parameters[15].Value = model.check_status;
			parameters[16].Value = model.green_rate_goal;
			parameters[17].Value = model.community_id;
			parameters[18].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_green_fields ");
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
		public TTG.Model.TTGWeb.community_green_fields GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_green_fields_area,community_park_green_fields_area,community_garden_green_fields_area,community_other_green_fields_area,statistics_date,community_green_fields_bet_dwellings_area,community_road_green_fields_area,community_public_accomm_green_fields_area,tcgfunset1,tcgfunset2,tcgfunset3,tcgfunset4,tcgfunset5,tcgfunset6,tcgfunset7,lock_tables,check_status,green_rate_goal from T_community_green_fields ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_green_fields model=new TTG.Model.TTGWeb.community_green_fields();
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
		public TTG.Model.TTGWeb.community_green_fields DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_green_fields model=new TTG.Model.TTGWeb.community_green_fields();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_green_fields_area"]!=null && row["community_green_fields_area"].ToString()!="")
				{
					model.community_green_fields_area=decimal.Parse(row["community_green_fields_area"].ToString());
				}
				if(row["community_park_green_fields_area"]!=null && row["community_park_green_fields_area"].ToString()!="")
				{
					model.community_park_green_fields_area=decimal.Parse(row["community_park_green_fields_area"].ToString());
				}
				if(row["community_garden_green_fields_area"]!=null && row["community_garden_green_fields_area"].ToString()!="")
				{
					model.community_garden_green_fields_area=decimal.Parse(row["community_garden_green_fields_area"].ToString());
				}
				if(row["community_other_green_fields_area"]!=null && row["community_other_green_fields_area"].ToString()!="")
				{
					model.community_other_green_fields_area=decimal.Parse(row["community_other_green_fields_area"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["community_green_fields_bet_dwellings_area"]!=null && row["community_green_fields_bet_dwellings_area"].ToString()!="")
				{
					model.community_green_fields_bet_dwellings_area=decimal.Parse(row["community_green_fields_bet_dwellings_area"].ToString());
				}
				if(row["community_road_green_fields_area"]!=null && row["community_road_green_fields_area"].ToString()!="")
				{
					model.community_road_green_fields_area=decimal.Parse(row["community_road_green_fields_area"].ToString());
				}
				if(row["community_public_accomm_green_fields_area"]!=null && row["community_public_accomm_green_fields_area"].ToString()!="")
				{
					model.community_public_accomm_green_fields_area=decimal.Parse(row["community_public_accomm_green_fields_area"].ToString());
				}
				if(row["tcgfunset1"]!=null)
				{
					model.tcgfunset1=row["tcgfunset1"].ToString();
				}
				if(row["tcgfunset2"]!=null)
				{
					model.tcgfunset2=row["tcgfunset2"].ToString();
				}
				if(row["tcgfunset3"]!=null)
				{
					model.tcgfunset3=row["tcgfunset3"].ToString();
				}
				if(row["tcgfunset4"]!=null)
				{
					model.tcgfunset4=row["tcgfunset4"].ToString();
				}
				if(row["tcgfunset5"]!=null)
				{
					model.tcgfunset5=row["tcgfunset5"].ToString();
				}
				if(row["tcgfunset6"]!=null)
				{
					model.tcgfunset6=row["tcgfunset6"].ToString();
				}
				if(row["tcgfunset7"]!=null)
				{
					model.tcgfunset7=row["tcgfunset7"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["green_rate_goal"]!=null && row["green_rate_goal"].ToString()!="")
				{
					model.green_rate_goal=decimal.Parse(row["green_rate_goal"].ToString());
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
			strSql.Append("select community_id,community_green_fields_area,community_park_green_fields_area,community_garden_green_fields_area,community_other_green_fields_area,statistics_date,community_green_fields_bet_dwellings_area,community_road_green_fields_area,community_public_accomm_green_fields_area,tcgfunset1,tcgfunset2,tcgfunset3,tcgfunset4,tcgfunset5,tcgfunset6,tcgfunset7,lock_tables,check_status,green_rate_goal ");
			strSql.Append(" FROM T_community_green_fields ");
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
			strSql.Append(" community_id,community_green_fields_area,community_park_green_fields_area,community_garden_green_fields_area,community_other_green_fields_area,statistics_date,community_green_fields_bet_dwellings_area,community_road_green_fields_area,community_public_accomm_green_fields_area,tcgfunset1,tcgfunset2,tcgfunset3,tcgfunset4,tcgfunset5,tcgfunset6,tcgfunset7,lock_tables,check_status,green_rate_goal ");
			strSql.Append(" FROM T_community_green_fields ");
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
			strSql.Append("select count(1) FROM T_community_green_fields ");
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
			strSql.Append(")AS Row, T.*  from T_community_green_fields T ");
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
			parameters[0].Value = "T_community_green_fields";
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

