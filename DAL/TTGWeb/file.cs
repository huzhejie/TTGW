using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:file
	/// </summary>
	public partial class file
	{
		public file()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string file_no)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_file");
			strSql.Append(" where file_no=@file_no ");
			SqlParameter[] parameters = {
					new SqlParameter("@file_no", SqlDbType.VarChar,20)			};
			parameters[0].Value = file_no;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.file model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_file(");
			strSql.Append("file_name,file_address,time,file_type)");
			strSql.Append(" values (");
            strSql.Append("@file_name,@file_address,@time,@file_type)");
			SqlParameter[] parameters = {
					new SqlParameter("@file_no", SqlDbType.VarChar,20),
					new SqlParameter("@file_name", SqlDbType.VarChar,50),
					new SqlParameter("@file_address", SqlDbType.VarChar,300),
					new SqlParameter("@time", SqlDbType.Date,3),
                    new SqlParameter("@file_type", SqlDbType.VarChar,20)};

			parameters[0].Value = model.file_no;
			parameters[1].Value = model.file_name;
			parameters[2].Value = model.file_address;
			parameters[3].Value = model.time;
            parameters[4].Value = model.file_type;
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
		public bool Update(TTG.Model.TTGWeb.file model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_file set ");
			strSql.Append("file_name=@file_name,");
			strSql.Append("file_address=@file_address,");
			strSql.Append("time=@time");
			strSql.Append(" where file_no=@file_no ");
			SqlParameter[] parameters = {
					new SqlParameter("@file_name", SqlDbType.VarChar,50),
					new SqlParameter("@file_address", SqlDbType.VarChar,300),
					new SqlParameter("@time", SqlDbType.Date,3),
					new SqlParameter("@file_no", SqlDbType.VarChar,20)};
			parameters[0].Value = model.file_name;
			parameters[1].Value = model.file_address;
			parameters[2].Value = model.time;
			parameters[3].Value = model.file_no;

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
		public bool Delete(int file_no)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_file ");
			strSql.Append(" where file_no=@file_no ");
			SqlParameter[] parameters = {
					new SqlParameter("@file_no", SqlDbType.VarChar,20)			};
			parameters[0].Value = file_no;

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
		public bool DeleteList(string file_nolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_file ");
			strSql.Append(" where file_no in ("+file_nolist + ")  ");
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
		public TTG.Model.TTGWeb.file GetModel(string file_no)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 file_no,file_name,file_address,time from T_file ");
			strSql.Append(" where file_no=@file_no ");
			SqlParameter[] parameters = {
					new SqlParameter("@file_no", SqlDbType.VarChar,20)			};
			parameters[0].Value = file_no;

			TTG.Model.TTGWeb.file model=new TTG.Model.TTGWeb.file();
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
		public TTG.Model.TTGWeb.file DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.file model=new TTG.Model.TTGWeb.file();
			if (row != null)
			{
				if(row["file_no"]!=null)
				{
					model.file_no=Convert.ToInt32(row["file_no"]);
				}
				if(row["file_name"]!=null)
				{
					model.file_name=row["file_name"].ToString();
				}
				if(row["file_address"]!=null)
				{
					model.file_address=row["file_address"].ToString();
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
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
			strSql.Append("select file_no,file_name,file_address,time ");
			strSql.Append(" FROM T_file ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where file_type='"+strWhere+"'");
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" file_no,file_name,file_address,time ");
			strSql.Append(" FROM T_file");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" where file_type='" + strWhere + "'");
			}
			strSql.Append(" order by time");
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_file ");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" where file_type='" + strWhere + "'");
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
				strSql.Append("order by T.file_no desc");
			}
			strSql.Append(")AS Row, T.*  from T_file T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
                strSql.Append(" where file_type='" + strWhere + "'");
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

        public DataSet GetListByPage(string strWhere, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append("order by T.time desc");         
            strSql.Append(")AS Row, T.*  from T_file T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" where T.file_type='" + strWhere + "'");
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
			parameters[0].Value = "T_file";
			parameters[1].Value = "file_no";
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

