using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:subproject_accomplish_quantity
	/// </summary>
	public partial class subproject_accomplish_quantity
	{
		public subproject_accomplish_quantity()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string subproject_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_subproject_accomplish_quantity");
			strSql.Append(" where subproject_id=@subproject_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = subproject_id;
			parameters[1].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.subproject_accomplish_quantity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_subproject_accomplish_quantity(");
			strSql.Append("subproject_id,subproject_name,subproject_finish_quantity,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,check_status,lock_tables)");
			strSql.Append(" values (");
			strSql.Append("@subproject_id,@subproject_name,@subproject_finish_quantity,@statistics_date,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@check_status,@lock_tables)");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_name", SqlDbType.VarChar,50),
					new SqlParameter("@subproject_finish_quantity", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4)};
			parameters[0].Value = model.subproject_id;
			parameters[1].Value = model.subproject_name;
			parameters[2].Value = model.subproject_finish_quantity;
			parameters[3].Value = model.statistics_date;
			parameters[4].Value = model.tciunset1;
			parameters[5].Value = model.tciunset2;
			parameters[6].Value = model.tciunset3;
			parameters[7].Value = model.tciunset4;
			parameters[8].Value = model.check_status;
			parameters[9].Value = model.lock_tables;

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
		public bool Update(TTG.Model.TTGWeb.subproject_accomplish_quantity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_subproject_accomplish_quantity set ");
			strSql.Append("subproject_name=@subproject_name,");
			strSql.Append("subproject_finish_quantity=@subproject_finish_quantity,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where subproject_id=@subproject_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_name", SqlDbType.VarChar,50),
					new SqlParameter("@subproject_finish_quantity", SqlDbType.Float,8),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.subproject_name;
			parameters[1].Value = model.subproject_finish_quantity;
			parameters[2].Value = model.tciunset1;
			parameters[3].Value = model.tciunset2;
			parameters[4].Value = model.tciunset3;
			parameters[5].Value = model.tciunset4;
			parameters[6].Value = model.check_status;
			parameters[7].Value = model.lock_tables;
			parameters[8].Value = model.subproject_id;
			parameters[9].Value = model.statistics_date;

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
		public bool Delete(string subproject_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_subproject_accomplish_quantity ");
			strSql.Append(" where subproject_id=@subproject_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = subproject_id;
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
		public TTG.Model.TTGWeb.subproject_accomplish_quantity GetModel(string subproject_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 subproject_id,subproject_name,subproject_finish_quantity,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,check_status,lock_tables from T_subproject_accomplish_quantity ");
			strSql.Append(" where subproject_id=@subproject_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = subproject_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.subproject_accomplish_quantity model=new TTG.Model.TTGWeb.subproject_accomplish_quantity();
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
		public TTG.Model.TTGWeb.subproject_accomplish_quantity DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.subproject_accomplish_quantity model=new TTG.Model.TTGWeb.subproject_accomplish_quantity();
			if (row != null)
			{
				if(row["subproject_id"]!=null)
				{
					model.subproject_id=row["subproject_id"].ToString();
				}
				if(row["subproject_name"]!=null)
				{
					model.subproject_name=row["subproject_name"].ToString();
				}
				if(row["subproject_finish_quantity"]!=null && row["subproject_finish_quantity"].ToString()!="")
				{
					model.subproject_finish_quantity=decimal.Parse(row["subproject_finish_quantity"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
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
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
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
			strSql.Append("select subproject_id,subproject_name,subproject_finish_quantity,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,check_status,lock_tables ");
			strSql.Append(" FROM T_subproject_accomplish_quantity ");
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
			strSql.Append(" subproject_id,subproject_name,subproject_finish_quantity,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,check_status,lock_tables ");
			strSql.Append(" FROM T_subproject_accomplish_quantity ");
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
			strSql.Append("select count(1) FROM T_subproject_accomplish_quantity ");
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
			strSql.Append(")AS Row, T.*  from T_subproject_accomplish_quantity T ");
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
			parameters[0].Value = "T_subproject_accomplish_quantity";
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

