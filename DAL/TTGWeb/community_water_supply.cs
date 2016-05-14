using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_water_supply
	/// </summary>
	public partial class community_water_supply
	{
		public community_water_supply()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_water_supply");
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
		public bool Add(TTG.Model.TTGWeb.community_water_supply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_water_supply(");
			strSql.Append("community_id,community_water_supply_pipe_length,community_water_supply_main_pipe_length,community_water_supply_pipe_branch_length,community_water_supply_service_pipe_length,community_water_supply_consumption,community_per_capita_water_supply_consumption,statistics_date,tcwsunset1,tcwsunset2,tcwsunset3,tcwsunset4,tcwsunset5,tcwsunset6,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_water_supply_pipe_length,@community_water_supply_main_pipe_length,@community_water_supply_pipe_branch_length,@community_water_supply_service_pipe_length,@community_water_supply_consumption,@community_per_capita_water_supply_consumption,@statistics_date,@tcwsunset1,@tcwsunset2,@tcwsunset3,@tcwsunset4,@tcwsunset5,@tcwsunset6,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_water_supply_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_supply_main_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_supply_pipe_branch_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_supply_service_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_supply_consumption", SqlDbType.Float,8),
					new SqlParameter("@community_per_capita_water_supply_consumption", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcwsunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset6", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_water_supply_pipe_length;
			parameters[2].Value = model.community_water_supply_main_pipe_length;
			parameters[3].Value = model.community_water_supply_pipe_branch_length;
			parameters[4].Value = model.community_water_supply_service_pipe_length;
			parameters[5].Value = model.community_water_supply_consumption;
			parameters[6].Value = model.community_per_capita_water_supply_consumption;
			parameters[7].Value = model.statistics_date;
			parameters[8].Value = model.tcwsunset1;
			parameters[9].Value = model.tcwsunset2;
			parameters[10].Value = model.tcwsunset3;
			parameters[11].Value = model.tcwsunset4;
			parameters[12].Value = model.tcwsunset5;
			parameters[13].Value = model.tcwsunset6;
			parameters[14].Value = model.lock_tables;
			parameters[15].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_water_supply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_water_supply set ");
			strSql.Append("community_water_supply_pipe_length=@community_water_supply_pipe_length,");
			strSql.Append("community_water_supply_main_pipe_length=@community_water_supply_main_pipe_length,");
			strSql.Append("community_water_supply_pipe_branch_length=@community_water_supply_pipe_branch_length,");
			strSql.Append("community_water_supply_service_pipe_length=@community_water_supply_service_pipe_length,");
			strSql.Append("community_water_supply_consumption=@community_water_supply_consumption,");
			strSql.Append("community_per_capita_water_supply_consumption=@community_per_capita_water_supply_consumption,");
			strSql.Append("tcwsunset1=@tcwsunset1,");
			strSql.Append("tcwsunset2=@tcwsunset2,");
			strSql.Append("tcwsunset3=@tcwsunset3,");
			strSql.Append("tcwsunset4=@tcwsunset4,");
			strSql.Append("tcwsunset5=@tcwsunset5,");
			strSql.Append("tcwsunset6=@tcwsunset6,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_water_supply_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_supply_main_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_supply_pipe_branch_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_supply_service_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_supply_consumption", SqlDbType.Float,8),
					new SqlParameter("@community_per_capita_water_supply_consumption", SqlDbType.Float,8),
					new SqlParameter("@tcwsunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcwsunset6", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_water_supply_pipe_length;
			parameters[1].Value = model.community_water_supply_main_pipe_length;
			parameters[2].Value = model.community_water_supply_pipe_branch_length;
			parameters[3].Value = model.community_water_supply_service_pipe_length;
			parameters[4].Value = model.community_water_supply_consumption;
			parameters[5].Value = model.community_per_capita_water_supply_consumption;
			parameters[6].Value = model.tcwsunset1;
			parameters[7].Value = model.tcwsunset2;
			parameters[8].Value = model.tcwsunset3;
			parameters[9].Value = model.tcwsunset4;
			parameters[10].Value = model.tcwsunset5;
			parameters[11].Value = model.tcwsunset6;
			parameters[12].Value = model.lock_tables;
			parameters[13].Value = model.check_status;
			parameters[14].Value = model.community_id;
			parameters[15].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_water_supply ");
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
		public TTG.Model.TTGWeb.community_water_supply GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_water_supply_pipe_length,community_water_supply_main_pipe_length,community_water_supply_pipe_branch_length,community_water_supply_service_pipe_length,community_water_supply_consumption,community_per_capita_water_supply_consumption,statistics_date,tcwsunset1,tcwsunset2,tcwsunset3,tcwsunset4,tcwsunset5,tcwsunset6,lock_tables,check_status from T_community_water_supply ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_water_supply model=new TTG.Model.TTGWeb.community_water_supply();
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
		public TTG.Model.TTGWeb.community_water_supply DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_water_supply model=new TTG.Model.TTGWeb.community_water_supply();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_water_supply_pipe_length"]!=null && row["community_water_supply_pipe_length"].ToString()!="")
				{
					model.community_water_supply_pipe_length=decimal.Parse(row["community_water_supply_pipe_length"].ToString());
				}
				if(row["community_water_supply_main_pipe_length"]!=null && row["community_water_supply_main_pipe_length"].ToString()!="")
				{
					model.community_water_supply_main_pipe_length=decimal.Parse(row["community_water_supply_main_pipe_length"].ToString());
				}
				if(row["community_water_supply_pipe_branch_length"]!=null && row["community_water_supply_pipe_branch_length"].ToString()!="")
				{
					model.community_water_supply_pipe_branch_length=decimal.Parse(row["community_water_supply_pipe_branch_length"].ToString());
				}
				if(row["community_water_supply_service_pipe_length"]!=null && row["community_water_supply_service_pipe_length"].ToString()!="")
				{
					model.community_water_supply_service_pipe_length=decimal.Parse(row["community_water_supply_service_pipe_length"].ToString());
				}
				if(row["community_water_supply_consumption"]!=null && row["community_water_supply_consumption"].ToString()!="")
				{
					model.community_water_supply_consumption=decimal.Parse(row["community_water_supply_consumption"].ToString());
				}
				if(row["community_per_capita_water_supply_consumption"]!=null && row["community_per_capita_water_supply_consumption"].ToString()!="")
				{
					model.community_per_capita_water_supply_consumption=decimal.Parse(row["community_per_capita_water_supply_consumption"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcwsunset1"]!=null)
				{
					model.tcwsunset1=row["tcwsunset1"].ToString();
				}
				if(row["tcwsunset2"]!=null)
				{
					model.tcwsunset2=row["tcwsunset2"].ToString();
				}
				if(row["tcwsunset3"]!=null)
				{
					model.tcwsunset3=row["tcwsunset3"].ToString();
				}
				if(row["tcwsunset4"]!=null)
				{
					model.tcwsunset4=row["tcwsunset4"].ToString();
				}
				if(row["tcwsunset5"]!=null)
				{
					model.tcwsunset5=row["tcwsunset5"].ToString();
				}
				if(row["tcwsunset6"]!=null)
				{
					model.tcwsunset6=row["tcwsunset6"].ToString();
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
			strSql.Append("select community_id,community_water_supply_pipe_length,community_water_supply_main_pipe_length,community_water_supply_pipe_branch_length,community_water_supply_service_pipe_length,community_water_supply_consumption,community_per_capita_water_supply_consumption,statistics_date,tcwsunset1,tcwsunset2,tcwsunset3,tcwsunset4,tcwsunset5,tcwsunset6,lock_tables,check_status ");
			strSql.Append(" FROM T_community_water_supply ");
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
			strSql.Append(" community_id,community_water_supply_pipe_length,community_water_supply_main_pipe_length,community_water_supply_pipe_branch_length,community_water_supply_service_pipe_length,community_water_supply_consumption,community_per_capita_water_supply_consumption,statistics_date,tcwsunset1,tcwsunset2,tcwsunset3,tcwsunset4,tcwsunset5,tcwsunset6,lock_tables,check_status ");
			strSql.Append(" FROM T_community_water_supply ");
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
			strSql.Append("select count(1) FROM T_community_water_supply ");
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
			strSql.Append(")AS Row, T.*  from T_community_water_supply T ");
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
			parameters[0].Value = "T_community_water_supply";
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

