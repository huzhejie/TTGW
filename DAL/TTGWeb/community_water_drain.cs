using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_water_drain
	/// </summary>
	public partial class community_water_drain
	{
		public community_water_drain()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_water_drain");
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
		public bool Add(TTG.Model.TTGWeb.community_water_drain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_water_drain(");
			strSql.Append("community_id,community_water_drain_mechanism,community_domestic_sewage_consumption,community_water_drain_pipe_length,community_water_drain_main_pipe_length,community_water_drain_pipe_branch_length,community_water_drain_service_pipe_length,community_water_drain_canal_length,community_water_open_drain_canal_length,community_septic_tank_num,community_septic_tank_capacity,statistics_date,tcwdunset1,tcwdunset2,tcwdunset3,tcwdunset4,tcwdunset5,tcwdunset6,tcwdunset7,tcwdunset8,tcwdunset9,tcwdunset10,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_water_drain_mechanism,@community_domestic_sewage_consumption,@community_water_drain_pipe_length,@community_water_drain_main_pipe_length,@community_water_drain_pipe_branch_length,@community_water_drain_service_pipe_length,@community_water_drain_canal_length,@community_water_open_drain_canal_length,@community_septic_tank_num,@community_septic_tank_capacity,@statistics_date,@tcwdunset1,@tcwdunset2,@tcwdunset3,@tcwdunset4,@tcwdunset5,@tcwdunset6,@tcwdunset7,@tcwdunset8,@tcwdunset9,@tcwdunset10,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_water_drain_mechanism", SqlDbType.VarChar,20),
					new SqlParameter("@community_domestic_sewage_consumption", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_main_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_pipe_branch_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_service_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_canal_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_open_drain_canal_length", SqlDbType.Float,8),
					new SqlParameter("@community_septic_tank_num", SqlDbType.Float,8),
					new SqlParameter("@community_septic_tank_capacity", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcwdunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset10", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_water_drain_mechanism;
			parameters[2].Value = model.community_domestic_sewage_consumption;
			parameters[3].Value = model.community_water_drain_pipe_length;
			parameters[4].Value = model.community_water_drain_main_pipe_length;
			parameters[5].Value = model.community_water_drain_pipe_branch_length;
			parameters[6].Value = model.community_water_drain_service_pipe_length;
			parameters[7].Value = model.community_water_drain_canal_length;
			parameters[8].Value = model.community_water_open_drain_canal_length;
			parameters[9].Value = model.community_septic_tank_num;
			parameters[10].Value = model.community_septic_tank_capacity;
			parameters[11].Value = model.statistics_date;
			parameters[12].Value = model.tcwdunset1;
			parameters[13].Value = model.tcwdunset2;
			parameters[14].Value = model.tcwdunset3;
			parameters[15].Value = model.tcwdunset4;
			parameters[16].Value = model.tcwdunset5;
			parameters[17].Value = model.tcwdunset6;
			parameters[18].Value = model.tcwdunset7;
			parameters[19].Value = model.tcwdunset8;
			parameters[20].Value = model.tcwdunset9;
			parameters[21].Value = model.tcwdunset10;
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
		public bool Update(TTG.Model.TTGWeb.community_water_drain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_water_drain set ");
			strSql.Append("community_water_drain_mechanism=@community_water_drain_mechanism,");
			strSql.Append("community_domestic_sewage_consumption=@community_domestic_sewage_consumption,");
			strSql.Append("community_water_drain_pipe_length=@community_water_drain_pipe_length,");
			strSql.Append("community_water_drain_main_pipe_length=@community_water_drain_main_pipe_length,");
			strSql.Append("community_water_drain_pipe_branch_length=@community_water_drain_pipe_branch_length,");
			strSql.Append("community_water_drain_service_pipe_length=@community_water_drain_service_pipe_length,");
			strSql.Append("community_water_drain_canal_length=@community_water_drain_canal_length,");
			strSql.Append("community_water_open_drain_canal_length=@community_water_open_drain_canal_length,");
			strSql.Append("community_septic_tank_num=@community_septic_tank_num,");
			strSql.Append("community_septic_tank_capacity=@community_septic_tank_capacity,");
			strSql.Append("tcwdunset1=@tcwdunset1,");
			strSql.Append("tcwdunset2=@tcwdunset2,");
			strSql.Append("tcwdunset3=@tcwdunset3,");
			strSql.Append("tcwdunset4=@tcwdunset4,");
			strSql.Append("tcwdunset5=@tcwdunset5,");
			strSql.Append("tcwdunset6=@tcwdunset6,");
			strSql.Append("tcwdunset7=@tcwdunset7,");
			strSql.Append("tcwdunset8=@tcwdunset8,");
			strSql.Append("tcwdunset9=@tcwdunset9,");
			strSql.Append("tcwdunset10=@tcwdunset10,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_water_drain_mechanism", SqlDbType.VarChar,20),
					new SqlParameter("@community_domestic_sewage_consumption", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_main_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_pipe_branch_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_service_pipe_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_drain_canal_length", SqlDbType.Float,8),
					new SqlParameter("@community_water_open_drain_canal_length", SqlDbType.Float,8),
					new SqlParameter("@community_septic_tank_num", SqlDbType.Float,8),
					new SqlParameter("@community_septic_tank_capacity", SqlDbType.Float,8),
					new SqlParameter("@tcwdunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcwdunset10", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_water_drain_mechanism;
			parameters[1].Value = model.community_domestic_sewage_consumption;
			parameters[2].Value = model.community_water_drain_pipe_length;
			parameters[3].Value = model.community_water_drain_main_pipe_length;
			parameters[4].Value = model.community_water_drain_pipe_branch_length;
			parameters[5].Value = model.community_water_drain_service_pipe_length;
			parameters[6].Value = model.community_water_drain_canal_length;
			parameters[7].Value = model.community_water_open_drain_canal_length;
			parameters[8].Value = model.community_septic_tank_num;
			parameters[9].Value = model.community_septic_tank_capacity;
			parameters[10].Value = model.tcwdunset1;
			parameters[11].Value = model.tcwdunset2;
			parameters[12].Value = model.tcwdunset3;
			parameters[13].Value = model.tcwdunset4;
			parameters[14].Value = model.tcwdunset5;
			parameters[15].Value = model.tcwdunset6;
			parameters[16].Value = model.tcwdunset7;
			parameters[17].Value = model.tcwdunset8;
			parameters[18].Value = model.tcwdunset9;
			parameters[19].Value = model.tcwdunset10;
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
			strSql.Append("delete from T_community_water_drain ");
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
		public TTG.Model.TTGWeb.community_water_drain GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_water_drain_mechanism,community_domestic_sewage_consumption,community_water_drain_pipe_length,community_water_drain_main_pipe_length,community_water_drain_pipe_branch_length,community_water_drain_service_pipe_length,community_water_drain_canal_length,community_water_open_drain_canal_length,community_septic_tank_num,community_septic_tank_capacity,statistics_date,tcwdunset1,tcwdunset2,tcwdunset3,tcwdunset4,tcwdunset5,tcwdunset6,tcwdunset7,tcwdunset8,tcwdunset9,tcwdunset10,lock_tables,check_status from T_community_water_drain ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_water_drain model=new TTG.Model.TTGWeb.community_water_drain();
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
		public TTG.Model.TTGWeb.community_water_drain DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_water_drain model=new TTG.Model.TTGWeb.community_water_drain();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_water_drain_mechanism"]!=null)
				{
					model.community_water_drain_mechanism=row["community_water_drain_mechanism"].ToString();
				}
				if(row["community_domestic_sewage_consumption"]!=null && row["community_domestic_sewage_consumption"].ToString()!="")
				{
					model.community_domestic_sewage_consumption=decimal.Parse(row["community_domestic_sewage_consumption"].ToString());
				}
				if(row["community_water_drain_pipe_length"]!=null && row["community_water_drain_pipe_length"].ToString()!="")
				{
					model.community_water_drain_pipe_length=decimal.Parse(row["community_water_drain_pipe_length"].ToString());
				}
				if(row["community_water_drain_main_pipe_length"]!=null && row["community_water_drain_main_pipe_length"].ToString()!="")
				{
					model.community_water_drain_main_pipe_length=decimal.Parse(row["community_water_drain_main_pipe_length"].ToString());
				}
				if(row["community_water_drain_pipe_branch_length"]!=null && row["community_water_drain_pipe_branch_length"].ToString()!="")
				{
					model.community_water_drain_pipe_branch_length=decimal.Parse(row["community_water_drain_pipe_branch_length"].ToString());
				}
				if(row["community_water_drain_service_pipe_length"]!=null && row["community_water_drain_service_pipe_length"].ToString()!="")
				{
					model.community_water_drain_service_pipe_length=decimal.Parse(row["community_water_drain_service_pipe_length"].ToString());
				}
				if(row["community_water_drain_canal_length"]!=null && row["community_water_drain_canal_length"].ToString()!="")
				{
					model.community_water_drain_canal_length=decimal.Parse(row["community_water_drain_canal_length"].ToString());
				}
				if(row["community_water_open_drain_canal_length"]!=null && row["community_water_open_drain_canal_length"].ToString()!="")
				{
					model.community_water_open_drain_canal_length=decimal.Parse(row["community_water_open_drain_canal_length"].ToString());
				}
				if(row["community_septic_tank_num"]!=null && row["community_septic_tank_num"].ToString()!="")
				{
					model.community_septic_tank_num=decimal.Parse(row["community_septic_tank_num"].ToString());
				}
				if(row["community_septic_tank_capacity"]!=null && row["community_septic_tank_capacity"].ToString()!="")
				{
					model.community_septic_tank_capacity=decimal.Parse(row["community_septic_tank_capacity"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcwdunset1"]!=null)
				{
					model.tcwdunset1=row["tcwdunset1"].ToString();
				}
				if(row["tcwdunset2"]!=null)
				{
					model.tcwdunset2=row["tcwdunset2"].ToString();
				}
				if(row["tcwdunset3"]!=null)
				{
					model.tcwdunset3=row["tcwdunset3"].ToString();
				}
				if(row["tcwdunset4"]!=null)
				{
					model.tcwdunset4=row["tcwdunset4"].ToString();
				}
				if(row["tcwdunset5"]!=null)
				{
					model.tcwdunset5=row["tcwdunset5"].ToString();
				}
				if(row["tcwdunset6"]!=null)
				{
					model.tcwdunset6=row["tcwdunset6"].ToString();
				}
				if(row["tcwdunset7"]!=null)
				{
					model.tcwdunset7=row["tcwdunset7"].ToString();
				}
				if(row["tcwdunset8"]!=null)
				{
					model.tcwdunset8=row["tcwdunset8"].ToString();
				}
				if(row["tcwdunset9"]!=null)
				{
					model.tcwdunset9=row["tcwdunset9"].ToString();
				}
				if(row["tcwdunset10"]!=null)
				{
					model.tcwdunset10=row["tcwdunset10"].ToString();
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
			strSql.Append("select community_id,community_water_drain_mechanism,community_domestic_sewage_consumption,community_water_drain_pipe_length,community_water_drain_main_pipe_length,community_water_drain_pipe_branch_length,community_water_drain_service_pipe_length,community_water_drain_canal_length,community_water_open_drain_canal_length,community_septic_tank_num,community_septic_tank_capacity,statistics_date,tcwdunset1,tcwdunset2,tcwdunset3,tcwdunset4,tcwdunset5,tcwdunset6,tcwdunset7,tcwdunset8,tcwdunset9,tcwdunset10,lock_tables,check_status ");
			strSql.Append(" FROM T_community_water_drain ");
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
			strSql.Append(" community_id,community_water_drain_mechanism,community_domestic_sewage_consumption,community_water_drain_pipe_length,community_water_drain_main_pipe_length,community_water_drain_pipe_branch_length,community_water_drain_service_pipe_length,community_water_drain_canal_length,community_water_open_drain_canal_length,community_septic_tank_num,community_septic_tank_capacity,statistics_date,tcwdunset1,tcwdunset2,tcwdunset3,tcwdunset4,tcwdunset5,tcwdunset6,tcwdunset7,tcwdunset8,tcwdunset9,tcwdunset10,lock_tables,check_status ");
			strSql.Append(" FROM T_community_water_drain ");
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
			strSql.Append("select count(1) FROM T_community_water_drain ");
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
			strSql.Append(")AS Row, T.*  from T_community_water_drain T ");
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
			parameters[0].Value = "T_community_water_drain";
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

