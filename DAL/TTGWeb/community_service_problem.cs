using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_service_problem
	/// </summary>
	public partial class community_service_problem
	{
		public community_service_problem()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("complete_year", "T_community_service_problem"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,string community_fill_type,DateTime statistics_date,int complete_year)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_service_problem");
			strSql.Append(" where community_id=@community_id and community_fill_type=@community_fill_type and statistics_date=@statistics_date and complete_year=@complete_year ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime),
					new SqlParameter("@complete_year", SqlDbType.Int,4)			};
			parameters[0].Value = community_id;
			parameters[1].Value = community_fill_type;
			parameters[2].Value = statistics_date;
			parameters[3].Value = complete_year;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_service_problem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_service_problem(");
			strSql.Append("community_id,community_fill_type,community_comp_mana_insuf_house,community_insuf_pension_faci,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,lock_tables,complete_year)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_fill_type,@community_comp_mana_insuf_house,@community_insuf_pension_faci,@statistics_date,@check_status,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@lock_tables,@complete_year)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@community_comp_mana_insuf_house", SqlDbType.VarChar,20),
					new SqlParameter("@community_insuf_pension_faci", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@complete_year", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_fill_type;
			parameters[2].Value = model.community_comp_mana_insuf_house;
			parameters[3].Value = model.community_insuf_pension_faci;
			parameters[4].Value = model.statistics_date;
			parameters[5].Value = model.check_status;
			parameters[6].Value = model.tciunset1;
			parameters[7].Value = model.tciunset2;
			parameters[8].Value = model.tciunset3;
			parameters[9].Value = model.tciunset4;
			parameters[10].Value = model.tciunset5;
			parameters[11].Value = model.lock_tables;
			parameters[12].Value = model.complete_year;

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
		public bool Update(TTG.Model.TTGWeb.community_service_problem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_service_problem set ");
			strSql.Append("community_comp_mana_insuf_house=@community_comp_mana_insuf_house,");
			strSql.Append("community_insuf_pension_faci=@community_insuf_pension_faci,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("tciunset5=@tciunset5,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where community_id=@community_id and community_fill_type=@community_fill_type and statistics_date=@statistics_date and complete_year=@complete_year ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_comp_mana_insuf_house", SqlDbType.VarChar,20),
					new SqlParameter("@community_insuf_pension_faci", SqlDbType.VarChar,20),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime),
					new SqlParameter("@complete_year", SqlDbType.Int,4)};
			parameters[0].Value = model.community_comp_mana_insuf_house;
			parameters[1].Value = model.community_insuf_pension_faci;
			parameters[2].Value = model.check_status;
			parameters[3].Value = model.tciunset1;
			parameters[4].Value = model.tciunset2;
			parameters[5].Value = model.tciunset3;
			parameters[6].Value = model.tciunset4;
			parameters[7].Value = model.tciunset5;
			parameters[8].Value = model.lock_tables;
			parameters[9].Value = model.community_id;
			parameters[10].Value = model.community_fill_type;
			parameters[11].Value = model.statistics_date;
			parameters[12].Value = model.complete_year;

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
		public bool Delete(string community_id,string community_fill_type,DateTime statistics_date,int complete_year)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_service_problem ");
			strSql.Append(" where community_id=@community_id and community_fill_type=@community_fill_type and statistics_date=@statistics_date and complete_year=@complete_year ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime),
					new SqlParameter("@complete_year", SqlDbType.Int,4)			};
			parameters[0].Value = community_id;
			parameters[1].Value = community_fill_type;
			parameters[2].Value = statistics_date;
			parameters[3].Value = complete_year;

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
		public TTG.Model.TTGWeb.community_service_problem GetModel(string community_id,string community_fill_type,DateTime statistics_date,int complete_year)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_fill_type,community_comp_mana_insuf_house,community_insuf_pension_faci,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,lock_tables,complete_year from T_community_service_problem ");
			strSql.Append(" where community_id=@community_id and community_fill_type=@community_fill_type and statistics_date=@statistics_date and complete_year=@complete_year ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_fill_type", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.DateTime),
					new SqlParameter("@complete_year", SqlDbType.Int,4)			};
			parameters[0].Value = community_id;
			parameters[1].Value = community_fill_type;
			parameters[2].Value = statistics_date;
			parameters[3].Value = complete_year;

			TTG.Model.TTGWeb.community_service_problem model=new TTG.Model.TTGWeb.community_service_problem();
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
		public TTG.Model.TTGWeb.community_service_problem DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_service_problem model=new TTG.Model.TTGWeb.community_service_problem();
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
				if(row["community_comp_mana_insuf_house"]!=null)
				{
					model.community_comp_mana_insuf_house=row["community_comp_mana_insuf_house"].ToString();
				}
				if(row["community_insuf_pension_faci"]!=null)
				{
					model.community_insuf_pension_faci=row["community_insuf_pension_faci"].ToString();
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
			strSql.Append("select community_id,community_fill_type,community_comp_mana_insuf_house,community_insuf_pension_faci,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,lock_tables,complete_year ");
			strSql.Append(" FROM T_community_service_problem ");
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
			strSql.Append(" community_id,community_fill_type,community_comp_mana_insuf_house,community_insuf_pension_faci,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,lock_tables,complete_year ");
			strSql.Append(" FROM T_community_service_problem ");
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
			strSql.Append("select count(1) FROM T_community_service_problem ");
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
				strSql.Append("order by T.complete_year desc");
			}
			strSql.Append(")AS Row, T.*  from T_community_service_problem T ");
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
			parameters[0].Value = "T_community_service_problem";
			parameters[1].Value = "complete_year";
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

