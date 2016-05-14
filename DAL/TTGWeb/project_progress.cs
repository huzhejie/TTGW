﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:project_progress
	/// </summary>
	public partial class project_progress
	{
		public project_progress()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string project_id,DateTime time)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_project_progress");
			strSql.Append(" where project_id=@project_id and time=@time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3)			};
			parameters[0].Value = project_id;
			parameters[1].Value = time;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.project_progress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_project_progress(");
			strSql.Append("project_id,project_name,project_image_progress,project_build_stage,time,tciunset1,tciunset2,tciunset3,tciunset4,check_status,lock_tables)");
			strSql.Append(" values (");
			strSql.Append("@project_id,@project_name,@project_image_progress,@project_build_stage,@time,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@check_status,@lock_tables)");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_image_progress", SqlDbType.VarChar,200),
					new SqlParameter("@project_build_stage", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.project_name;
			parameters[2].Value = model.project_image_progress;
			parameters[3].Value = model.project_build_stage;
			parameters[4].Value = model.time;
			parameters[5].Value = model.tciunset1;
			parameters[6].Value = model.tciunset2;
			parameters[7].Value = model.tciunset3;
			parameters[8].Value = model.tciunset4;
			parameters[9].Value = model.check_status;
			parameters[10].Value = model.lock_tables;

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
		public bool Update(TTG.Model.TTGWeb.project_progress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_project_progress set ");
			strSql.Append("project_name=@project_name,");
			strSql.Append("project_image_progress=@project_image_progress,");
			strSql.Append("project_build_stage=@project_build_stage,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where project_id=@project_id and time=@time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_image_progress", SqlDbType.VarChar,200),
					new SqlParameter("@project_build_stage", SqlDbType.VarChar,20),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3)};
			parameters[0].Value = model.project_name;
			parameters[1].Value = model.project_image_progress;
			parameters[2].Value = model.project_build_stage;
			parameters[3].Value = model.tciunset1;
			parameters[4].Value = model.tciunset2;
			parameters[5].Value = model.tciunset3;
			parameters[6].Value = model.tciunset4;
			parameters[7].Value = model.check_status;
			parameters[8].Value = model.lock_tables;
			parameters[9].Value = model.project_id;
			parameters[10].Value = model.time;

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
		public bool Delete(string project_id,DateTime time)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_project_progress ");
			strSql.Append(" where project_id=@project_id and time=@time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3)			};
			parameters[0].Value = project_id;
			parameters[1].Value = time;

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
		public TTG.Model.TTGWeb.project_progress GetModel(string project_id,DateTime time)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 project_id,project_name,project_image_progress,project_build_stage,time,tciunset1,tciunset2,tciunset3,tciunset4,check_status,lock_tables from T_project_progress ");
			strSql.Append(" where project_id=@project_id and time=@time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@time", SqlDbType.Date,3)			};
			parameters[0].Value = project_id;
			parameters[1].Value = time;

			TTG.Model.TTGWeb.project_progress model=new TTG.Model.TTGWeb.project_progress();
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
		public TTG.Model.TTGWeb.project_progress DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.project_progress model=new TTG.Model.TTGWeb.project_progress();
			if (row != null)
			{
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["project_image_progress"]!=null)
				{
					model.project_image_progress=row["project_image_progress"].ToString();
				}
				if(row["project_build_stage"]!=null)
				{
					model.project_build_stage=row["project_build_stage"].ToString();
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
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
			strSql.Append("select project_id,project_name,project_image_progress,project_build_stage,time,tciunset1,tciunset2,tciunset3,tciunset4,check_status,lock_tables ");
			strSql.Append(" FROM T_project_progress ");
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
			strSql.Append(" project_id,project_name,project_image_progress,project_build_stage,time,tciunset1,tciunset2,tciunset3,tciunset4,check_status,lock_tables ");
			strSql.Append(" FROM T_project_progress ");
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
			strSql.Append("select count(1) FROM T_project_progress ");
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
				strSql.Append("order by T.time desc");
			}
			strSql.Append(")AS Row, T.*  from T_project_progress T ");
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
			parameters[0].Value = "T_project_progress";
			parameters[1].Value = "time";
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
