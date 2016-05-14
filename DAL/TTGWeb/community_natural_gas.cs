using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_natural_gas
	/// </summary>
	public partial class community_natural_gas
	{
		public community_natural_gas()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_natural_gas");
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
		public bool Add(TTG.Model.TTGWeb.community_natural_gas model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_natural_gas(");
			strSql.Append("community_id,community_gas_regulating_station_num,community_natural_gas_pipe_length,low_pressure_natural_gas_pipe_length,middle_pressuse_natural_gas_pipe_length,intermediate_pressure_natural_gas_pipe_length,statistics_date,tcngunset1,tcngunset2,tcngunset3,tcngunset4,tcngunset5,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_gas_regulating_station_num,@community_natural_gas_pipe_length,@low_pressure_natural_gas_pipe_length,@middle_pressuse_natural_gas_pipe_length,@intermediate_pressure_natural_gas_pipe_length,@statistics_date,@tcngunset1,@tcngunset2,@tcngunset3,@tcngunset4,@tcngunset5,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_gas_regulating_station_num", SqlDbType.Int,4),
					new SqlParameter("@community_natural_gas_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@low_pressure_natural_gas_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@middle_pressuse_natural_gas_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@intermediate_pressure_natural_gas_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcngunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcngunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcngunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcngunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcngunset5", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_gas_regulating_station_num;
			parameters[2].Value = model.community_natural_gas_pipe_length;
			parameters[3].Value = model.low_pressure_natural_gas_pipe_length;
			parameters[4].Value = model.middle_pressuse_natural_gas_pipe_length;
			parameters[5].Value = model.intermediate_pressure_natural_gas_pipe_length;
			parameters[6].Value = model.statistics_date;
			parameters[7].Value = model.tcngunset1;
			parameters[8].Value = model.tcngunset2;
			parameters[9].Value = model.tcngunset3;
			parameters[10].Value = model.tcngunset4;
			parameters[11].Value = model.tcngunset5;
			parameters[12].Value = model.lock_tables;
			parameters[13].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_natural_gas model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_natural_gas set ");
			strSql.Append("community_gas_regulating_station_num=@community_gas_regulating_station_num,");
			strSql.Append("community_natural_gas_pipe_length=@community_natural_gas_pipe_length,");
			strSql.Append("low_pressure_natural_gas_pipe_length=@low_pressure_natural_gas_pipe_length,");
			strSql.Append("middle_pressuse_natural_gas_pipe_length=@middle_pressuse_natural_gas_pipe_length,");
			strSql.Append("intermediate_pressure_natural_gas_pipe_length=@intermediate_pressure_natural_gas_pipe_length,");
			strSql.Append("tcngunset1=@tcngunset1,");
			strSql.Append("tcngunset2=@tcngunset2,");
			strSql.Append("tcngunset3=@tcngunset3,");
			strSql.Append("tcngunset4=@tcngunset4,");
			strSql.Append("tcngunset5=@tcngunset5,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_gas_regulating_station_num", SqlDbType.Int,4),
					new SqlParameter("@community_natural_gas_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@low_pressure_natural_gas_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@middle_pressuse_natural_gas_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@intermediate_pressure_natural_gas_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@tcngunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcngunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcngunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcngunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcngunset5", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_gas_regulating_station_num;
			parameters[1].Value = model.community_natural_gas_pipe_length;
			parameters[2].Value = model.low_pressure_natural_gas_pipe_length;
			parameters[3].Value = model.middle_pressuse_natural_gas_pipe_length;
			parameters[4].Value = model.intermediate_pressure_natural_gas_pipe_length;
			parameters[5].Value = model.tcngunset1;
			parameters[6].Value = model.tcngunset2;
			parameters[7].Value = model.tcngunset3;
			parameters[8].Value = model.tcngunset4;
			parameters[9].Value = model.tcngunset5;
			parameters[10].Value = model.lock_tables;
			parameters[11].Value = model.check_status;
			parameters[12].Value = model.community_id;
			parameters[13].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_natural_gas ");
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
		public TTG.Model.TTGWeb.community_natural_gas GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_gas_regulating_station_num,community_natural_gas_pipe_length,low_pressure_natural_gas_pipe_length,middle_pressuse_natural_gas_pipe_length,intermediate_pressure_natural_gas_pipe_length,statistics_date,tcngunset1,tcngunset2,tcngunset3,tcngunset4,tcngunset5,lock_tables,check_status from T_community_natural_gas ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_natural_gas model=new TTG.Model.TTGWeb.community_natural_gas();
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
		public TTG.Model.TTGWeb.community_natural_gas DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_natural_gas model=new TTG.Model.TTGWeb.community_natural_gas();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_gas_regulating_station_num"]!=null && row["community_gas_regulating_station_num"].ToString()!="")
				{
					model.community_gas_regulating_station_num=int.Parse(row["community_gas_regulating_station_num"].ToString());
				}
				if(row["community_natural_gas_pipe_length"]!=null && row["community_natural_gas_pipe_length"].ToString()!="")
				{
					model.community_natural_gas_pipe_length=decimal.Parse(row["community_natural_gas_pipe_length"].ToString());
				}
				if(row["low_pressure_natural_gas_pipe_length"]!=null && row["low_pressure_natural_gas_pipe_length"].ToString()!="")
				{
					model.low_pressure_natural_gas_pipe_length=decimal.Parse(row["low_pressure_natural_gas_pipe_length"].ToString());
				}
				if(row["middle_pressuse_natural_gas_pipe_length"]!=null && row["middle_pressuse_natural_gas_pipe_length"].ToString()!="")
				{
					model.middle_pressuse_natural_gas_pipe_length=decimal.Parse(row["middle_pressuse_natural_gas_pipe_length"].ToString());
				}
				if(row["intermediate_pressure_natural_gas_pipe_length"]!=null && row["intermediate_pressure_natural_gas_pipe_length"].ToString()!="")
				{
					model.intermediate_pressure_natural_gas_pipe_length=decimal.Parse(row["intermediate_pressure_natural_gas_pipe_length"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcngunset1"]!=null)
				{
					model.tcngunset1=row["tcngunset1"].ToString();
				}
				if(row["tcngunset2"]!=null)
				{
					model.tcngunset2=row["tcngunset2"].ToString();
				}
				if(row["tcngunset3"]!=null)
				{
					model.tcngunset3=row["tcngunset3"].ToString();
				}
				if(row["tcngunset4"]!=null)
				{
					model.tcngunset4=row["tcngunset4"].ToString();
				}
				if(row["tcngunset5"]!=null)
				{
					model.tcngunset5=row["tcngunset5"].ToString();
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
			strSql.Append("select community_id,community_gas_regulating_station_num,community_natural_gas_pipe_length,low_pressure_natural_gas_pipe_length,middle_pressuse_natural_gas_pipe_length,intermediate_pressure_natural_gas_pipe_length,statistics_date,tcngunset1,tcngunset2,tcngunset3,tcngunset4,tcngunset5,lock_tables,check_status ");
			strSql.Append(" FROM T_community_natural_gas ");
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
			strSql.Append(" community_id,community_gas_regulating_station_num,community_natural_gas_pipe_length,low_pressure_natural_gas_pipe_length,middle_pressuse_natural_gas_pipe_length,intermediate_pressure_natural_gas_pipe_length,statistics_date,tcngunset1,tcngunset2,tcngunset3,tcngunset4,tcngunset5,lock_tables,check_status ");
			strSql.Append(" FROM T_community_natural_gas ");
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
			strSql.Append("select count(1) FROM T_community_natural_gas ");
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
			strSql.Append(")AS Row, T.*  from T_community_natural_gas T ");
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
			parameters[0].Value = "T_community_natural_gas";
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

