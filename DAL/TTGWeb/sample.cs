using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:sample
	/// </summary>
	public partial class sample
	{
		public sample()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_sample");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.sample model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_sample(");
			strSql.Append("community_id,sample_house_num,sample_family_pop,sample_labor_force_pop,sample_employment_lf_pop,sample_primary_industry_lf_pop,sample_secondary_industry_lf_pop,sample_tertiary_industry_lf_pop,sample_PCDI,sample_wages_income,sample_family_run_pure_income,sample_property_income,sample_transfer_income,sample_CONSP,tsunset1,tsunset2,tsunset3,tsunset4,tsunset5,tsunset6,tsunset7,tsunset8,tsunset9,tsunset10,tsunset11,tsunset12,lock_tables,check_status,statistics_date)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@sample_house_num,@sample_family_pop,@sample_labor_force_pop,@sample_employment_lf_pop,@sample_primary_industry_lf_pop,@sample_secondary_industry_lf_pop,@sample_tertiary_industry_lf_pop,@sample_PCDI,@sample_wages_income,@sample_family_run_pure_income,@sample_property_income,@sample_transfer_income,@sample_CONSP,@tsunset1,@tsunset2,@tsunset3,@tsunset4,@tsunset5,@tsunset6,@tsunset7,@tsunset8,@tsunset9,@tsunset10,@tsunset11,@tsunset12,@lock_tables,@check_status,@statistics_date)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@sample_house_num", SqlDbType.Int,4),
					new SqlParameter("@sample_family_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_labor_force_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_employment_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_primary_industry_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_secondary_industry_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_tertiary_industry_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_PCDI", SqlDbType.Float,8),
					new SqlParameter("@sample_wages_income", SqlDbType.Float,8),
					new SqlParameter("@sample_family_run_pure_income", SqlDbType.Float,8),
					new SqlParameter("@sample_property_income", SqlDbType.Float,8),
					new SqlParameter("@sample_transfer_income", SqlDbType.Float,8),
					new SqlParameter("@sample_CONSP", SqlDbType.Float,8),
					new SqlParameter("@tsunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset12", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.sample_house_num;
			parameters[2].Value = model.sample_family_pop;
			parameters[3].Value = model.sample_labor_force_pop;
			parameters[4].Value = model.sample_employment_lf_pop;
			parameters[5].Value = model.sample_primary_industry_lf_pop;
			parameters[6].Value = model.sample_secondary_industry_lf_pop;
			parameters[7].Value = model.sample_tertiary_industry_lf_pop;
			parameters[8].Value = model.sample_PCDI;
			parameters[9].Value = model.sample_wages_income;
			parameters[10].Value = model.sample_family_run_pure_income;
			parameters[11].Value = model.sample_property_income;
			parameters[12].Value = model.sample_transfer_income;
			parameters[13].Value = model.sample_CONSP;
			parameters[14].Value = model.tsunset1;
			parameters[15].Value = model.tsunset2;
			parameters[16].Value = model.tsunset3;
			parameters[17].Value = model.tsunset4;
			parameters[18].Value = model.tsunset5;
			parameters[19].Value = model.tsunset6;
			parameters[20].Value = model.tsunset7;
			parameters[21].Value = model.tsunset8;
			parameters[22].Value = model.tsunset9;
			parameters[23].Value = model.tsunset10;
			parameters[24].Value = model.tsunset11;
			parameters[25].Value = model.tsunset12;
			parameters[26].Value = model.lock_tables;
			parameters[27].Value = model.check_status;
			parameters[28].Value = model.statistics_date;

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
		public bool Update(TTG.Model.TTGWeb.sample model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_sample set ");
			strSql.Append("sample_house_num=@sample_house_num,");
			strSql.Append("sample_family_pop=@sample_family_pop,");
			strSql.Append("sample_labor_force_pop=@sample_labor_force_pop,");
			strSql.Append("sample_employment_lf_pop=@sample_employment_lf_pop,");
			strSql.Append("sample_primary_industry_lf_pop=@sample_primary_industry_lf_pop,");
			strSql.Append("sample_secondary_industry_lf_pop=@sample_secondary_industry_lf_pop,");
			strSql.Append("sample_tertiary_industry_lf_pop=@sample_tertiary_industry_lf_pop,");
			strSql.Append("sample_PCDI=@sample_PCDI,");
			strSql.Append("sample_wages_income=@sample_wages_income,");
			strSql.Append("sample_family_run_pure_income=@sample_family_run_pure_income,");
			strSql.Append("sample_property_income=@sample_property_income,");
			strSql.Append("sample_transfer_income=@sample_transfer_income,");
			strSql.Append("sample_CONSP=@sample_CONSP,");
			strSql.Append("tsunset1=@tsunset1,");
			strSql.Append("tsunset2=@tsunset2,");
			strSql.Append("tsunset3=@tsunset3,");
			strSql.Append("tsunset4=@tsunset4,");
			strSql.Append("tsunset5=@tsunset5,");
			strSql.Append("tsunset6=@tsunset6,");
			strSql.Append("tsunset7=@tsunset7,");
			strSql.Append("tsunset8=@tsunset8,");
			strSql.Append("tsunset9=@tsunset9,");
			strSql.Append("tsunset10=@tsunset10,");
			strSql.Append("tsunset11=@tsunset11,");
			strSql.Append("tsunset12=@tsunset12,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@sample_house_num", SqlDbType.Int,4),
					new SqlParameter("@sample_family_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_labor_force_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_employment_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_primary_industry_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_secondary_industry_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_tertiary_industry_lf_pop", SqlDbType.Int,4),
					new SqlParameter("@sample_PCDI", SqlDbType.Float,8),
					new SqlParameter("@sample_wages_income", SqlDbType.Float,8),
					new SqlParameter("@sample_family_run_pure_income", SqlDbType.Float,8),
					new SqlParameter("@sample_property_income", SqlDbType.Float,8),
					new SqlParameter("@sample_transfer_income", SqlDbType.Float,8),
					new SqlParameter("@sample_CONSP", SqlDbType.Float,8),
					new SqlParameter("@tsunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tsunset12", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.sample_house_num;
			parameters[1].Value = model.sample_family_pop;
			parameters[2].Value = model.sample_labor_force_pop;
			parameters[3].Value = model.sample_employment_lf_pop;
			parameters[4].Value = model.sample_primary_industry_lf_pop;
			parameters[5].Value = model.sample_secondary_industry_lf_pop;
			parameters[6].Value = model.sample_tertiary_industry_lf_pop;
			parameters[7].Value = model.sample_PCDI;
			parameters[8].Value = model.sample_wages_income;
			parameters[9].Value = model.sample_family_run_pure_income;
			parameters[10].Value = model.sample_property_income;
			parameters[11].Value = model.sample_transfer_income;
			parameters[12].Value = model.sample_CONSP;
			parameters[13].Value = model.tsunset1;
			parameters[14].Value = model.tsunset2;
			parameters[15].Value = model.tsunset3;
			parameters[16].Value = model.tsunset4;
			parameters[17].Value = model.tsunset5;
			parameters[18].Value = model.tsunset6;
			parameters[19].Value = model.tsunset7;
			parameters[20].Value = model.tsunset8;
			parameters[21].Value = model.tsunset9;
			parameters[22].Value = model.tsunset10;
			parameters[23].Value = model.tsunset11;
			parameters[24].Value = model.tsunset12;
			parameters[25].Value = model.lock_tables;
			parameters[26].Value = model.check_status;
			parameters[27].Value = model.community_id;
			parameters[28].Value = model.statistics_date;

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
			strSql.Append("delete from T_sample ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
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
		public TTG.Model.TTGWeb.sample GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,sample_house_num,sample_family_pop,sample_labor_force_pop,sample_employment_lf_pop,sample_primary_industry_lf_pop,sample_secondary_industry_lf_pop,sample_tertiary_industry_lf_pop,sample_PCDI,sample_wages_income,sample_family_run_pure_income,sample_property_income,sample_transfer_income,sample_CONSP,tsunset1,tsunset2,tsunset3,tsunset4,tsunset5,tsunset6,tsunset7,tsunset8,tsunset9,tsunset10,tsunset11,tsunset12,lock_tables,check_status,statistics_date from T_sample ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.sample model=new TTG.Model.TTGWeb.sample();
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
		public TTG.Model.TTGWeb.sample DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.sample model=new TTG.Model.TTGWeb.sample();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["sample_house_num"]!=null && row["sample_house_num"].ToString()!="")
				{
					model.sample_house_num=int.Parse(row["sample_house_num"].ToString());
				}
				if(row["sample_family_pop"]!=null && row["sample_family_pop"].ToString()!="")
				{
					model.sample_family_pop=int.Parse(row["sample_family_pop"].ToString());
				}
				if(row["sample_labor_force_pop"]!=null && row["sample_labor_force_pop"].ToString()!="")
				{
					model.sample_labor_force_pop=int.Parse(row["sample_labor_force_pop"].ToString());
				}
				if(row["sample_employment_lf_pop"]!=null && row["sample_employment_lf_pop"].ToString()!="")
				{
					model.sample_employment_lf_pop=int.Parse(row["sample_employment_lf_pop"].ToString());
				}
				if(row["sample_primary_industry_lf_pop"]!=null && row["sample_primary_industry_lf_pop"].ToString()!="")
				{
					model.sample_primary_industry_lf_pop=int.Parse(row["sample_primary_industry_lf_pop"].ToString());
				}
				if(row["sample_secondary_industry_lf_pop"]!=null && row["sample_secondary_industry_lf_pop"].ToString()!="")
				{
					model.sample_secondary_industry_lf_pop=int.Parse(row["sample_secondary_industry_lf_pop"].ToString());
				}
				if(row["sample_tertiary_industry_lf_pop"]!=null && row["sample_tertiary_industry_lf_pop"].ToString()!="")
				{
					model.sample_tertiary_industry_lf_pop=int.Parse(row["sample_tertiary_industry_lf_pop"].ToString());
				}
				if(row["sample_PCDI"]!=null && row["sample_PCDI"].ToString()!="")
				{
					model.sample_PCDI=decimal.Parse(row["sample_PCDI"].ToString());
				}
				if(row["sample_wages_income"]!=null && row["sample_wages_income"].ToString()!="")
				{
					model.sample_wages_income=decimal.Parse(row["sample_wages_income"].ToString());
				}
				if(row["sample_family_run_pure_income"]!=null && row["sample_family_run_pure_income"].ToString()!="")
				{
					model.sample_family_run_pure_income=decimal.Parse(row["sample_family_run_pure_income"].ToString());
				}
				if(row["sample_property_income"]!=null && row["sample_property_income"].ToString()!="")
				{
					model.sample_property_income=decimal.Parse(row["sample_property_income"].ToString());
				}
				if(row["sample_transfer_income"]!=null && row["sample_transfer_income"].ToString()!="")
				{
					model.sample_transfer_income=decimal.Parse(row["sample_transfer_income"].ToString());
				}
				if(row["sample_CONSP"]!=null && row["sample_CONSP"].ToString()!="")
				{
					model.sample_CONSP=decimal.Parse(row["sample_CONSP"].ToString());
				}
				if(row["tsunset1"]!=null)
				{
					model.tsunset1=row["tsunset1"].ToString();
				}
				if(row["tsunset2"]!=null)
				{
					model.tsunset2=row["tsunset2"].ToString();
				}
				if(row["tsunset3"]!=null)
				{
					model.tsunset3=row["tsunset3"].ToString();
				}
				if(row["tsunset4"]!=null)
				{
					model.tsunset4=row["tsunset4"].ToString();
				}
				if(row["tsunset5"]!=null)
				{
					model.tsunset5=row["tsunset5"].ToString();
				}
				if(row["tsunset6"]!=null)
				{
					model.tsunset6=row["tsunset6"].ToString();
				}
				if(row["tsunset7"]!=null)
				{
					model.tsunset7=row["tsunset7"].ToString();
				}
				if(row["tsunset8"]!=null)
				{
					model.tsunset8=row["tsunset8"].ToString();
				}
				if(row["tsunset9"]!=null)
				{
					model.tsunset9=row["tsunset9"].ToString();
				}
				if(row["tsunset10"]!=null)
				{
					model.tsunset10=row["tsunset10"].ToString();
				}
				if(row["tsunset11"]!=null)
				{
					model.tsunset11=row["tsunset11"].ToString();
				}
				if(row["tsunset12"]!=null)
				{
					model.tsunset12=row["tsunset12"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
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
			strSql.Append("select community_id,sample_house_num,sample_family_pop,sample_labor_force_pop,sample_employment_lf_pop,sample_primary_industry_lf_pop,sample_secondary_industry_lf_pop,sample_tertiary_industry_lf_pop,sample_PCDI,sample_wages_income,sample_family_run_pure_income,sample_property_income,sample_transfer_income,sample_CONSP,tsunset1,tsunset2,tsunset3,tsunset4,tsunset5,tsunset6,tsunset7,tsunset8,tsunset9,tsunset10,tsunset11,tsunset12,lock_tables,check_status,statistics_date ");
			strSql.Append(" FROM T_sample ");
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
			strSql.Append(" community_id,sample_house_num,sample_family_pop,sample_labor_force_pop,sample_employment_lf_pop,sample_primary_industry_lf_pop,sample_secondary_industry_lf_pop,sample_tertiary_industry_lf_pop,sample_PCDI,sample_wages_income,sample_family_run_pure_income,sample_property_income,sample_transfer_income,sample_CONSP,tsunset1,tsunset2,tsunset3,tsunset4,tsunset5,tsunset6,tsunset7,tsunset8,tsunset9,tsunset10,tsunset11,tsunset12,lock_tables,check_status,statistics_date ");
			strSql.Append(" FROM T_sample ");
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
			strSql.Append("select count(1) FROM T_sample ");
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
			strSql.Append(")AS Row, T.*  from T_sample T ");
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
			parameters[0].Value = "T_sample";
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
        /// 获取特定时间内的信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="start_time"></param>
        /// <param name="end_time"></param>
        /// <returns></returns>
        public DataSet getListByTime(string id, DateTime start_time, DateTime end_time)
        {
            string sql = "select sample_PCDI, statistics_date from T_sample " +
                "where community_id = '" + id + "' and statistics_date>=" + start_time + " and statistics_date<" + end_time;
            return DbHelperSQL.Query(sql);
        }
		#endregion  ExtensionMethod
	}
}

