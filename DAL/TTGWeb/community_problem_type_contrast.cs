using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_problem_type_contrast
	/// </summary>
	public partial class community_problem_type_contrast
	{
		public community_problem_type_contrast()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string question_content)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_problem_type_contrast");
			strSql.Append(" where question_content=@question_content ");
			SqlParameter[] parameters = {
					new SqlParameter("@question_content", SqlDbType.VarChar,128)			};
			parameters[0].Value = question_content;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_problem_type_contrast model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_problem_type_contrast(");
			strSql.Append("question_content,table_belong_to,unit,problem_nature,check_status,tciunset1,tciunset2,tciunset3,tciunset4,lock_tables)");
			strSql.Append(" values (");
			strSql.Append("@question_content,@table_belong_to,@unit,@problem_nature,@check_status,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@lock_tables)");
			SqlParameter[] parameters = {
					new SqlParameter("@question_content", SqlDbType.VarChar,128),
					new SqlParameter("@table_belong_to", SqlDbType.VarChar,128),
					new SqlParameter("@unit", SqlDbType.VarChar,20),
					new SqlParameter("@problem_nature", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4)};
			parameters[0].Value = model.question_content;
			parameters[1].Value = model.table_belong_to;
			parameters[2].Value = model.unit;
			parameters[3].Value = model.problem_nature;
			parameters[4].Value = model.check_status;
			parameters[5].Value = model.tciunset1;
			parameters[6].Value = model.tciunset2;
			parameters[7].Value = model.tciunset3;
			parameters[8].Value = model.tciunset4;
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
		public bool Update(TTG.Model.TTGWeb.community_problem_type_contrast model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_problem_type_contrast set ");
			strSql.Append("table_belong_to=@table_belong_to,");
			strSql.Append("unit=@unit,");
			strSql.Append("problem_nature=@problem_nature,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where question_content=@question_content ");
			SqlParameter[] parameters = {
					new SqlParameter("@table_belong_to", SqlDbType.VarChar,128),
					new SqlParameter("@unit", SqlDbType.VarChar,20),
					new SqlParameter("@problem_nature", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@question_content", SqlDbType.VarChar,128)};
			parameters[0].Value = model.table_belong_to;
			parameters[1].Value = model.unit;
			parameters[2].Value = model.problem_nature;
			parameters[3].Value = model.check_status;
			parameters[4].Value = model.tciunset1;
			parameters[5].Value = model.tciunset2;
			parameters[6].Value = model.tciunset3;
			parameters[7].Value = model.tciunset4;
			parameters[8].Value = model.lock_tables;
			parameters[9].Value = model.question_content;

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
		public bool Delete(string question_content)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_problem_type_contrast ");
			strSql.Append(" where question_content=@question_content ");
			SqlParameter[] parameters = {
					new SqlParameter("@question_content", SqlDbType.VarChar,128)			};
			parameters[0].Value = question_content;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string question_contentlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_problem_type_contrast ");
			strSql.Append(" where question_content in ("+question_contentlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public TTG.Model.TTGWeb.community_problem_type_contrast GetModel(string question_content)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 question_content,table_belong_to,unit,problem_nature,check_status,tciunset1,tciunset2,tciunset3,tciunset4,lock_tables from T_community_problem_type_contrast ");
			strSql.Append(" where question_content=@question_content ");
			SqlParameter[] parameters = {
					new SqlParameter("@question_content", SqlDbType.VarChar,128)			};
			parameters[0].Value = question_content;

			TTG.Model.TTGWeb.community_problem_type_contrast model=new TTG.Model.TTGWeb.community_problem_type_contrast();
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
		public TTG.Model.TTGWeb.community_problem_type_contrast DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_problem_type_contrast model=new TTG.Model.TTGWeb.community_problem_type_contrast();
			if (row != null)
			{
				if(row["question_content"]!=null)
				{
					model.question_content=row["question_content"].ToString();
				}
				if(row["table_belong_to"]!=null)
				{
					model.table_belong_to=row["table_belong_to"].ToString();
				}
				if(row["unit"]!=null)
				{
					model.unit=row["unit"].ToString();
				}
				if(row["problem_nature"]!=null)
				{
					model.problem_nature=row["problem_nature"].ToString();
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
			strSql.Append("select question_content,table_belong_to,unit,problem_nature,check_status,tciunset1,tciunset2,tciunset3,tciunset4,lock_tables ");
			strSql.Append(" FROM T_community_problem_type_contrast ");
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
			strSql.Append(" question_content,table_belong_to,unit,problem_nature,check_status,tciunset1,tciunset2,tciunset3,tciunset4,lock_tables ");
			strSql.Append(" FROM T_community_problem_type_contrast ");
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
			strSql.Append("select count(1) FROM T_community_problem_type_contrast ");
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
				strSql.Append("order by T.question_content desc");
			}
			strSql.Append(")AS Row, T.*  from T_community_problem_type_contrast T ");
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
			parameters[0].Value = "T_community_problem_type_contrast";
			parameters[1].Value = "question_content";
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

