using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_social_insurance
	/// </summary>
	public partial class community_social_insurance
	{
		public community_social_insurance()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_social_insurance");
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
		public bool Add(TTG.Model.TTGWeb.community_social_insurance model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_social_insurance(");
			strSql.Append("community_id,community_urban_min_living_sec_pop,community_very_poor_household_pop,community_large_med_resv_immg_pop,community_chongqing_immg_poor_pop,community_medicare_pop,community_endow_insu_pop,community_unemp_insu_pop,statistics_date,tcsiunset1,tcsiunset2,tcsiunset3,tcsiunset4,tcsiunset5,tcsiunset6,tcsiunset7,lock_tables,check_status,poor_people_rate)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_urban_min_living_sec_pop,@community_very_poor_household_pop,@community_large_med_resv_immg_pop,@community_chongqing_immg_poor_pop,@community_medicare_pop,@community_endow_insu_pop,@community_unemp_insu_pop,@statistics_date,@tcsiunset1,@tcsiunset2,@tcsiunset3,@tcsiunset4,@tcsiunset5,@tcsiunset6,@tcsiunset7,@lock_tables,@check_status,@poor_people_rate)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_urban_min_living_sec_pop", SqlDbType.Int,4),
					new SqlParameter("@community_very_poor_household_pop", SqlDbType.Int,4),
					new SqlParameter("@community_large_med_resv_immg_pop", SqlDbType.Int,4),
					new SqlParameter("@community_chongqing_immg_poor_pop", SqlDbType.Int,4),
					new SqlParameter("@community_medicare_pop", SqlDbType.Int,4),
					new SqlParameter("@community_endow_insu_pop", SqlDbType.Int,4),
					new SqlParameter("@community_unemp_insu_pop", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcsiunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset7", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@poor_people_rate", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_urban_min_living_sec_pop;
			parameters[2].Value = model.community_very_poor_household_pop;
			parameters[3].Value = model.community_large_med_resv_immg_pop;
			parameters[4].Value = model.community_chongqing_immg_poor_pop;
			parameters[5].Value = model.community_medicare_pop;
			parameters[6].Value = model.community_endow_insu_pop;
			parameters[7].Value = model.community_unemp_insu_pop;
			parameters[8].Value = model.statistics_date;
			parameters[9].Value = model.tcsiunset1;
			parameters[10].Value = model.tcsiunset2;
			parameters[11].Value = model.tcsiunset3;
			parameters[12].Value = model.tcsiunset4;
			parameters[13].Value = model.tcsiunset5;
			parameters[14].Value = model.tcsiunset6;
			parameters[15].Value = model.tcsiunset7;
			parameters[16].Value = model.lock_tables;
			parameters[17].Value = model.check_status;
			parameters[18].Value = model.poor_people_rate;

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
		public bool Update(TTG.Model.TTGWeb.community_social_insurance model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_social_insurance set ");
			strSql.Append("community_urban_min_living_sec_pop=@community_urban_min_living_sec_pop,");
			strSql.Append("community_very_poor_household_pop=@community_very_poor_household_pop,");
			strSql.Append("community_large_med_resv_immg_pop=@community_large_med_resv_immg_pop,");
			strSql.Append("community_chongqing_immg_poor_pop=@community_chongqing_immg_poor_pop,");
			strSql.Append("community_medicare_pop=@community_medicare_pop,");
			strSql.Append("community_endow_insu_pop=@community_endow_insu_pop,");
			strSql.Append("community_unemp_insu_pop=@community_unemp_insu_pop,");
			strSql.Append("tcsiunset1=@tcsiunset1,");
			strSql.Append("tcsiunset2=@tcsiunset2,");
			strSql.Append("tcsiunset3=@tcsiunset3,");
			strSql.Append("tcsiunset4=@tcsiunset4,");
			strSql.Append("tcsiunset5=@tcsiunset5,");
			strSql.Append("tcsiunset6=@tcsiunset6,");
			strSql.Append("tcsiunset7=@tcsiunset7,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("poor_people_rate=@poor_people_rate");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_urban_min_living_sec_pop", SqlDbType.Int,4),
					new SqlParameter("@community_very_poor_household_pop", SqlDbType.Int,4),
					new SqlParameter("@community_large_med_resv_immg_pop", SqlDbType.Int,4),
					new SqlParameter("@community_chongqing_immg_poor_pop", SqlDbType.Int,4),
					new SqlParameter("@community_medicare_pop", SqlDbType.Int,4),
					new SqlParameter("@community_endow_insu_pop", SqlDbType.Int,4),
					new SqlParameter("@community_unemp_insu_pop", SqlDbType.Int,4),
					new SqlParameter("@tcsiunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcsiunset7", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@poor_people_rate", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_urban_min_living_sec_pop;
			parameters[1].Value = model.community_very_poor_household_pop;
			parameters[2].Value = model.community_large_med_resv_immg_pop;
			parameters[3].Value = model.community_chongqing_immg_poor_pop;
			parameters[4].Value = model.community_medicare_pop;
			parameters[5].Value = model.community_endow_insu_pop;
			parameters[6].Value = model.community_unemp_insu_pop;
			parameters[7].Value = model.tcsiunset1;
			parameters[8].Value = model.tcsiunset2;
			parameters[9].Value = model.tcsiunset3;
			parameters[10].Value = model.tcsiunset4;
			parameters[11].Value = model.tcsiunset5;
			parameters[12].Value = model.tcsiunset6;
			parameters[13].Value = model.tcsiunset7;
			parameters[14].Value = model.lock_tables;
			parameters[15].Value = model.check_status;
			parameters[16].Value = model.poor_people_rate;
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
			strSql.Append("delete from T_community_social_insurance ");
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
		public TTG.Model.TTGWeb.community_social_insurance GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_urban_min_living_sec_pop,community_very_poor_household_pop,community_large_med_resv_immg_pop,community_chongqing_immg_poor_pop,community_medicare_pop,community_endow_insu_pop,community_unemp_insu_pop,statistics_date,tcsiunset1,tcsiunset2,tcsiunset3,tcsiunset4,tcsiunset5,tcsiunset6,tcsiunset7,lock_tables,check_status,poor_people_rate from T_community_social_insurance ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_social_insurance model=new TTG.Model.TTGWeb.community_social_insurance();
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
		public TTG.Model.TTGWeb.community_social_insurance DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_social_insurance model=new TTG.Model.TTGWeb.community_social_insurance();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_urban_min_living_sec_pop"]!=null && row["community_urban_min_living_sec_pop"].ToString()!="")
				{
					model.community_urban_min_living_sec_pop=int.Parse(row["community_urban_min_living_sec_pop"].ToString());
				}
				if(row["community_very_poor_household_pop"]!=null && row["community_very_poor_household_pop"].ToString()!="")
				{
					model.community_very_poor_household_pop=int.Parse(row["community_very_poor_household_pop"].ToString());
				}
				if(row["community_large_med_resv_immg_pop"]!=null && row["community_large_med_resv_immg_pop"].ToString()!="")
				{
					model.community_large_med_resv_immg_pop=int.Parse(row["community_large_med_resv_immg_pop"].ToString());
				}
				if(row["community_chongqing_immg_poor_pop"]!=null && row["community_chongqing_immg_poor_pop"].ToString()!="")
				{
					model.community_chongqing_immg_poor_pop=int.Parse(row["community_chongqing_immg_poor_pop"].ToString());
				}
				if(row["community_medicare_pop"]!=null && row["community_medicare_pop"].ToString()!="")
				{
					model.community_medicare_pop=int.Parse(row["community_medicare_pop"].ToString());
				}
				if(row["community_endow_insu_pop"]!=null && row["community_endow_insu_pop"].ToString()!="")
				{
					model.community_endow_insu_pop=int.Parse(row["community_endow_insu_pop"].ToString());
				}
				if(row["community_unemp_insu_pop"]!=null && row["community_unemp_insu_pop"].ToString()!="")
				{
					model.community_unemp_insu_pop=int.Parse(row["community_unemp_insu_pop"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcsiunset1"]!=null)
				{
					model.tcsiunset1=row["tcsiunset1"].ToString();
				}
				if(row["tcsiunset2"]!=null)
				{
					model.tcsiunset2=row["tcsiunset2"].ToString();
				}
				if(row["tcsiunset3"]!=null)
				{
					model.tcsiunset3=row["tcsiunset3"].ToString();
				}
				if(row["tcsiunset4"]!=null)
				{
					model.tcsiunset4=row["tcsiunset4"].ToString();
				}
				if(row["tcsiunset5"]!=null)
				{
					model.tcsiunset5=row["tcsiunset5"].ToString();
				}
				if(row["tcsiunset6"]!=null)
				{
					model.tcsiunset6=row["tcsiunset6"].ToString();
				}
				if(row["tcsiunset7"]!=null)
				{
					model.tcsiunset7=row["tcsiunset7"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["poor_people_rate"]!=null && row["poor_people_rate"].ToString()!="")
				{
					model.poor_people_rate=decimal.Parse(row["poor_people_rate"].ToString());
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
			strSql.Append("select community_id,community_urban_min_living_sec_pop,community_very_poor_household_pop,community_large_med_resv_immg_pop,community_chongqing_immg_poor_pop,community_medicare_pop,community_endow_insu_pop,community_unemp_insu_pop,statistics_date,tcsiunset1,tcsiunset2,tcsiunset3,tcsiunset4,tcsiunset5,tcsiunset6,tcsiunset7,lock_tables,check_status,poor_people_rate ");
			strSql.Append(" FROM T_community_social_insurance ");
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
			strSql.Append(" community_id,community_urban_min_living_sec_pop,community_very_poor_household_pop,community_large_med_resv_immg_pop,community_chongqing_immg_poor_pop,community_medicare_pop,community_endow_insu_pop,community_unemp_insu_pop,statistics_date,tcsiunset1,tcsiunset2,tcsiunset3,tcsiunset4,tcsiunset5,tcsiunset6,tcsiunset7,lock_tables,check_status,poor_people_rate ");
			strSql.Append(" FROM T_community_social_insurance ");
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
			strSql.Append("select count(1) FROM T_community_social_insurance ");
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
			strSql.Append(")AS Row, T.*  from T_community_social_insurance T ");
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
			parameters[0].Value = "T_community_social_insurance";
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
        /// 获取某一时间段内的信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="start_time"></param>
        /// <param name="end_time"></param>
        /// <returns></returns>
        public DataSet getListByTime(string id, DateTime start_time, DateTime end_time)
        {
            string sql = "select * from T_community_social_insurance where community_id = '" + id +
                "' and statistics_date>=" + start_time + " and statistics_date<" + end_time;
            return DbHelperSQL.Query(sql);
        }
        /// <summary>
        /// 获取某一个实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.TTGWeb.community_social_insurance getModel(string id)
        {
            string sql = "select * from T_community_social_insurance where community_id = '" + id + "' order by statistics_date desc";
            DataSet ds = DbHelperSQL.Query(sql);
            return DataRowToModel(ds.Tables[0].Rows[0]);
        }
		#endregion  ExtensionMethod
	}
}

