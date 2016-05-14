using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_concil_house
	/// </summary>
	public partial class community_concil_house
	{
		public community_concil_house()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_concil_house");
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
		public bool Add(TTG.Model.TTGWeb.community_concil_house model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_concil_house(");
			strSql.Append("community_id,community_council_buil_num,community_conhou_gfa,community_conhou_fs,community_conhou_unit_num,community_conhou_floor_num,community_conhou_suite_num,community_conhou_family_num,community_conhou_people_num,statistics_date,tcchunset1,tcchunset2,tcchunset3,tcchunset4,tcchunset5,tcchunset6,tcchunset8,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_council_buil_num,@community_conhou_gfa,@community_conhou_fs,@community_conhou_unit_num,@community_conhou_floor_num,@community_conhou_suite_num,@community_conhou_family_num,@community_conhou_people_num,@statistics_date,@tcchunset1,@tcchunset2,@tcchunset3,@tcchunset4,@tcchunset5,@tcchunset6,@tcchunset8,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_council_buil_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_fs", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_unit_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_floor_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_suite_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_family_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_people_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcchunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset8", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_council_buil_num;
			parameters[2].Value = model.community_conhou_gfa;
			parameters[3].Value = model.community_conhou_fs;
			parameters[4].Value = model.community_conhou_unit_num;
			parameters[5].Value = model.community_conhou_floor_num;
			parameters[6].Value = model.community_conhou_suite_num;
			parameters[7].Value = model.community_conhou_family_num;
			parameters[8].Value = model.community_conhou_people_num;
			parameters[9].Value = model.statistics_date;
			parameters[10].Value = model.tcchunset1;
			parameters[11].Value = model.tcchunset2;
			parameters[12].Value = model.tcchunset3;
			parameters[13].Value = model.tcchunset4;
			parameters[14].Value = model.tcchunset5;
			parameters[15].Value = model.tcchunset6;
			parameters[16].Value = model.tcchunset8;
			parameters[17].Value = model.lock_tables;
			parameters[18].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_concil_house model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_concil_house set ");
			strSql.Append("community_council_buil_num=@community_council_buil_num,");
			strSql.Append("community_conhou_gfa=@community_conhou_gfa,");
			strSql.Append("community_conhou_fs=@community_conhou_fs,");
			strSql.Append("community_conhou_unit_num=@community_conhou_unit_num,");
			strSql.Append("community_conhou_floor_num=@community_conhou_floor_num,");
			strSql.Append("community_conhou_suite_num=@community_conhou_suite_num,");
			strSql.Append("community_conhou_family_num=@community_conhou_family_num,");
			strSql.Append("community_conhou_people_num=@community_conhou_people_num,");
			strSql.Append("tcchunset1=@tcchunset1,");
			strSql.Append("tcchunset2=@tcchunset2,");
			strSql.Append("tcchunset3=@tcchunset3,");
			strSql.Append("tcchunset4=@tcchunset4,");
			strSql.Append("tcchunset5=@tcchunset5,");
			strSql.Append("tcchunset6=@tcchunset6,");
			strSql.Append("tcchunset8=@tcchunset8,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_council_buil_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_gfa", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_fs", SqlDbType.Float,8),
					new SqlParameter("@community_conhou_unit_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_floor_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_suite_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_family_num", SqlDbType.Int,4),
					new SqlParameter("@community_conhou_people_num", SqlDbType.Int,4),
					new SqlParameter("@tcchunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcchunset8", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_council_buil_num;
			parameters[1].Value = model.community_conhou_gfa;
			parameters[2].Value = model.community_conhou_fs;
			parameters[3].Value = model.community_conhou_unit_num;
			parameters[4].Value = model.community_conhou_floor_num;
			parameters[5].Value = model.community_conhou_suite_num;
			parameters[6].Value = model.community_conhou_family_num;
			parameters[7].Value = model.community_conhou_people_num;
			parameters[8].Value = model.tcchunset1;
			parameters[9].Value = model.tcchunset2;
			parameters[10].Value = model.tcchunset3;
			parameters[11].Value = model.tcchunset4;
			parameters[12].Value = model.tcchunset5;
			parameters[13].Value = model.tcchunset6;
			parameters[14].Value = model.tcchunset8;
			parameters[15].Value = model.lock_tables;
			parameters[16].Value = model.check_status;
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
			strSql.Append("delete from T_community_concil_house ");
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
		public TTG.Model.TTGWeb.community_concil_house GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_council_buil_num,community_conhou_gfa,community_conhou_fs,community_conhou_unit_num,community_conhou_floor_num,community_conhou_suite_num,community_conhou_family_num,community_conhou_people_num,statistics_date,tcchunset1,tcchunset2,tcchunset3,tcchunset4,tcchunset5,tcchunset6,tcchunset8,lock_tables,check_status from T_community_concil_house ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_concil_house model=new TTG.Model.TTGWeb.community_concil_house();
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
		public TTG.Model.TTGWeb.community_concil_house DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_concil_house model=new TTG.Model.TTGWeb.community_concil_house();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_council_buil_num"]!=null && row["community_council_buil_num"].ToString()!="")
				{
					model.community_council_buil_num=int.Parse(row["community_council_buil_num"].ToString());
				}
				if(row["community_conhou_gfa"]!=null && row["community_conhou_gfa"].ToString()!="")
				{
					model.community_conhou_gfa=decimal.Parse(row["community_conhou_gfa"].ToString());
				}
				if(row["community_conhou_fs"]!=null && row["community_conhou_fs"].ToString()!="")
				{
					model.community_conhou_fs=decimal.Parse(row["community_conhou_fs"].ToString());
				}
				if(row["community_conhou_unit_num"]!=null && row["community_conhou_unit_num"].ToString()!="")
				{
					model.community_conhou_unit_num=int.Parse(row["community_conhou_unit_num"].ToString());
				}
				if(row["community_conhou_floor_num"]!=null && row["community_conhou_floor_num"].ToString()!="")
				{
					model.community_conhou_floor_num=int.Parse(row["community_conhou_floor_num"].ToString());
				}
				if(row["community_conhou_suite_num"]!=null && row["community_conhou_suite_num"].ToString()!="")
				{
					model.community_conhou_suite_num=int.Parse(row["community_conhou_suite_num"].ToString());
				}
				if(row["community_conhou_family_num"]!=null && row["community_conhou_family_num"].ToString()!="")
				{
					model.community_conhou_family_num=int.Parse(row["community_conhou_family_num"].ToString());
				}
				if(row["community_conhou_people_num"]!=null && row["community_conhou_people_num"].ToString()!="")
				{
					model.community_conhou_people_num=int.Parse(row["community_conhou_people_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcchunset1"]!=null)
				{
					model.tcchunset1=row["tcchunset1"].ToString();
				}
				if(row["tcchunset2"]!=null)
				{
					model.tcchunset2=row["tcchunset2"].ToString();
				}
				if(row["tcchunset3"]!=null)
				{
					model.tcchunset3=row["tcchunset3"].ToString();
				}
				if(row["tcchunset4"]!=null)
				{
					model.tcchunset4=row["tcchunset4"].ToString();
				}
				if(row["tcchunset5"]!=null)
				{
					model.tcchunset5=row["tcchunset5"].ToString();
				}
				if(row["tcchunset6"]!=null)
				{
					model.tcchunset6=row["tcchunset6"].ToString();
				}
				if(row["tcchunset8"]!=null)
				{
					model.tcchunset8=row["tcchunset8"].ToString();
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
			strSql.Append("select community_id,community_council_buil_num,community_conhou_gfa,community_conhou_fs,community_conhou_unit_num,community_conhou_floor_num,community_conhou_suite_num,community_conhou_family_num,community_conhou_people_num,statistics_date,tcchunset1,tcchunset2,tcchunset3,tcchunset4,tcchunset5,tcchunset6,tcchunset8,lock_tables,check_status ");
			strSql.Append(" FROM T_community_concil_house ");
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
			strSql.Append(" community_id,community_council_buil_num,community_conhou_gfa,community_conhou_fs,community_conhou_unit_num,community_conhou_floor_num,community_conhou_suite_num,community_conhou_family_num,community_conhou_people_num,statistics_date,tcchunset1,tcchunset2,tcchunset3,tcchunset4,tcchunset5,tcchunset6,tcchunset8,lock_tables,check_status ");
			strSql.Append(" FROM T_community_concil_house ");
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
			strSql.Append("select count(1) FROM T_community_concil_house ");
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
			strSql.Append(")AS Row, T.*  from T_community_concil_house T ");
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
			parameters[0].Value = "T_community_concil_house";
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
        /// <summary>
        /// 查询sql语句执行的结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet sqlQuery(string sql)
        {
            return DbHelperSQL.Query(sql);
        }

		#endregion  ExtensionMethod
	}
}

