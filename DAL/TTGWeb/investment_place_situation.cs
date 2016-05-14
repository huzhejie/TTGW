﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:investment_place_situation
	/// </summary>
	public partial class investment_place_situation
	{
		public investment_place_situation()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.investment_place_situation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_investment_place_situation(");
			strSql.Append("project_id,year,month,special_support_founds,conterpart_founds,fill_time)");
			strSql.Append(" values (");
			strSql.Append("@project_id,@year,@month,@special_support_founds,@conterpart_founds,@fill_time)");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,50),
					new SqlParameter("@year", SqlDbType.Int,4),
					new SqlParameter("@month", SqlDbType.Int,4),
					new SqlParameter("@special_support_founds", SqlDbType.Float,8),
					new SqlParameter("@conterpart_founds", SqlDbType.Float,8),
					new SqlParameter("@fill_time", SqlDbType.DateTime)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.year;
			parameters[2].Value = model.month;
			parameters[3].Value = model.special_support_founds;
			parameters[4].Value = model.conterpart_founds;
			parameters[5].Value = model.fill_time;

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
		public bool Update(TTG.Model.TTGWeb.investment_place_situation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_investment_place_situation set ");
			strSql.Append("project_id=@project_id,");
			strSql.Append("year=@year,");
			strSql.Append("month=@month,");
			strSql.Append("special_support_founds=@special_support_founds,");
			strSql.Append("conterpart_founds=@conterpart_founds,");
			strSql.Append("fill_time=@fill_time");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,50),
					new SqlParameter("@year", SqlDbType.Int,4),
					new SqlParameter("@month", SqlDbType.Int,4),
					new SqlParameter("@special_support_founds", SqlDbType.Float,8),
					new SqlParameter("@conterpart_founds", SqlDbType.Float,8),
					new SqlParameter("@fill_time", SqlDbType.DateTime)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.year;
			parameters[2].Value = model.month;
			parameters[3].Value = model.special_support_founds;
			parameters[4].Value = model.conterpart_founds;
			parameters[5].Value = model.fill_time;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_investment_place_situation ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public TTG.Model.TTGWeb.investment_place_situation GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 project_id,year,month,special_support_founds,conterpart_founds,fill_time from T_investment_place_situation ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			TTG.Model.TTGWeb.investment_place_situation model=new TTG.Model.TTGWeb.investment_place_situation();
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
		public TTG.Model.TTGWeb.investment_place_situation DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.investment_place_situation model=new TTG.Model.TTGWeb.investment_place_situation();
			if (row != null)
			{
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["year"]!=null && row["year"].ToString()!="")
				{
					model.year=int.Parse(row["year"].ToString());
				}
				if(row["month"]!=null && row["month"].ToString()!="")
				{
					model.month=int.Parse(row["month"].ToString());
				}
				if(row["special_support_founds"]!=null && row["special_support_founds"].ToString()!="")
				{
					model.special_support_founds=decimal.Parse(row["special_support_founds"].ToString());
				}
				if(row["conterpart_founds"]!=null && row["conterpart_founds"].ToString()!="")
				{
					model.conterpart_founds=decimal.Parse(row["conterpart_founds"].ToString());
				}
				if(row["fill_time"]!=null && row["fill_time"].ToString()!="")
				{
					model.fill_time=DateTime.Parse(row["fill_time"].ToString());
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
			strSql.Append("select project_id,year,month,special_support_founds,conterpart_founds,fill_time ");
			strSql.Append(" FROM T_investment_place_situation ");
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
			strSql.Append(" project_id,year,month,special_support_founds,conterpart_founds,fill_time ");
			strSql.Append(" FROM T_investment_place_situation ");
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
			strSql.Append("select count(1) FROM T_investment_place_situation ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from T_investment_place_situation T ");
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
			parameters[0].Value = "T_investment_place_situation";
			parameters[1].Value = "id";
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

