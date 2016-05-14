using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_letter_view
	/// </summary>
	public partial class community_letter_view
	{
		public community_letter_view()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_letter_view");
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
		public bool Add(TTG.Model.TTGWeb.community_letter_view model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_letter_view(");
			strSql.Append("community_id,community_lv_num,community_lv_pop,community_lv_county_government_num,community_lv_county_government_pop,community_lv_county_industry_num,community_lv_county_industry_pop,community_lv_street_agency_num,community_lv_street_agency_pop,community_lv_neighborhood_committee_num,community_lv_neighborhood_committee_pop,community_lv_immigration_num,community_lv_basic_fac_num,community_lv_service_fac_num,community_lv_livelihood_difficulty_num,community_lv_disputes_complaints_num,statistics_date,tclvunset1,tclvunset2,tclvunset3,tclvunset4,tclvunset5,tclvunset6,tclvunset7,tclvunset8,tclvunset9,tclvunset10,tclvunset11,tclvunset12,tclvunset13,tclvunset14,tclvunset15,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_lv_num,@community_lv_pop,@community_lv_county_government_num,@community_lv_county_government_pop,@community_lv_county_industry_num,@community_lv_county_industry_pop,@community_lv_street_agency_num,@community_lv_street_agency_pop,@community_lv_neighborhood_committee_num,@community_lv_neighborhood_committee_pop,@community_lv_immigration_num,@community_lv_basic_fac_num,@community_lv_service_fac_num,@community_lv_livelihood_difficulty_num,@community_lv_disputes_complaints_num,@statistics_date,@tclvunset1,@tclvunset2,@tclvunset3,@tclvunset4,@tclvunset5,@tclvunset6,@tclvunset7,@tclvunset8,@tclvunset9,@tclvunset10,@tclvunset11,@tclvunset12,@tclvunset13,@tclvunset14,@tclvunset15,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_lv_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_county_government_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_county_government_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_county_industry_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_county_industry_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_street_agency_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_street_agency_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_neighborhood_committee_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_neighborhood_committee_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_immigration_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_basic_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_service_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_livelihood_difficulty_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_disputes_complaints_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tclvunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset15", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_lv_num;
			parameters[2].Value = model.community_lv_pop;
			parameters[3].Value = model.community_lv_county_government_num;
			parameters[4].Value = model.community_lv_county_government_pop;
			parameters[5].Value = model.community_lv_county_industry_num;
			parameters[6].Value = model.community_lv_county_industry_pop;
			parameters[7].Value = model.community_lv_street_agency_num;
			parameters[8].Value = model.community_lv_street_agency_pop;
			parameters[9].Value = model.community_lv_neighborhood_committee_num;
			parameters[10].Value = model.community_lv_neighborhood_committee_pop;
			parameters[11].Value = model.community_lv_immigration_num;
			parameters[12].Value = model.community_lv_basic_fac_num;
			parameters[13].Value = model.community_lv_service_fac_num;
			parameters[14].Value = model.community_lv_livelihood_difficulty_num;
			parameters[15].Value = model.community_lv_disputes_complaints_num;
			parameters[16].Value = model.statistics_date;
			parameters[17].Value = model.tclvunset1;
			parameters[18].Value = model.tclvunset2;
			parameters[19].Value = model.tclvunset3;
			parameters[20].Value = model.tclvunset4;
			parameters[21].Value = model.tclvunset5;
			parameters[22].Value = model.tclvunset6;
			parameters[23].Value = model.tclvunset7;
			parameters[24].Value = model.tclvunset8;
			parameters[25].Value = model.tclvunset9;
			parameters[26].Value = model.tclvunset10;
			parameters[27].Value = model.tclvunset11;
			parameters[28].Value = model.tclvunset12;
			parameters[29].Value = model.tclvunset13;
			parameters[30].Value = model.tclvunset14;
			parameters[31].Value = model.tclvunset15;
			parameters[32].Value = model.lock_tables;
			parameters[33].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_letter_view model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_letter_view set ");
			strSql.Append("community_lv_num=@community_lv_num,");
			strSql.Append("community_lv_pop=@community_lv_pop,");
			strSql.Append("community_lv_county_government_num=@community_lv_county_government_num,");
			strSql.Append("community_lv_county_government_pop=@community_lv_county_government_pop,");
			strSql.Append("community_lv_county_industry_num=@community_lv_county_industry_num,");
			strSql.Append("community_lv_county_industry_pop=@community_lv_county_industry_pop,");
			strSql.Append("community_lv_street_agency_num=@community_lv_street_agency_num,");
			strSql.Append("community_lv_street_agency_pop=@community_lv_street_agency_pop,");
			strSql.Append("community_lv_neighborhood_committee_num=@community_lv_neighborhood_committee_num,");
			strSql.Append("community_lv_neighborhood_committee_pop=@community_lv_neighborhood_committee_pop,");
			strSql.Append("community_lv_immigration_num=@community_lv_immigration_num,");
			strSql.Append("community_lv_basic_fac_num=@community_lv_basic_fac_num,");
			strSql.Append("community_lv_service_fac_num=@community_lv_service_fac_num,");
			strSql.Append("community_lv_livelihood_difficulty_num=@community_lv_livelihood_difficulty_num,");
			strSql.Append("community_lv_disputes_complaints_num=@community_lv_disputes_complaints_num,");
			strSql.Append("tclvunset1=@tclvunset1,");
			strSql.Append("tclvunset2=@tclvunset2,");
			strSql.Append("tclvunset3=@tclvunset3,");
			strSql.Append("tclvunset4=@tclvunset4,");
			strSql.Append("tclvunset5=@tclvunset5,");
			strSql.Append("tclvunset6=@tclvunset6,");
			strSql.Append("tclvunset7=@tclvunset7,");
			strSql.Append("tclvunset8=@tclvunset8,");
			strSql.Append("tclvunset9=@tclvunset9,");
			strSql.Append("tclvunset10=@tclvunset10,");
			strSql.Append("tclvunset11=@tclvunset11,");
			strSql.Append("tclvunset12=@tclvunset12,");
			strSql.Append("tclvunset13=@tclvunset13,");
			strSql.Append("tclvunset14=@tclvunset14,");
			strSql.Append("tclvunset15=@tclvunset15,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_lv_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_county_government_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_county_government_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_county_industry_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_county_industry_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_street_agency_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_street_agency_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_neighborhood_committee_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_neighborhood_committee_pop", SqlDbType.Int,4),
					new SqlParameter("@community_lv_immigration_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_basic_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_service_fac_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_livelihood_difficulty_num", SqlDbType.Int,4),
					new SqlParameter("@community_lv_disputes_complaints_num", SqlDbType.Int,4),
					new SqlParameter("@tclvunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tclvunset15", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_lv_num;
			parameters[1].Value = model.community_lv_pop;
			parameters[2].Value = model.community_lv_county_government_num;
			parameters[3].Value = model.community_lv_county_government_pop;
			parameters[4].Value = model.community_lv_county_industry_num;
			parameters[5].Value = model.community_lv_county_industry_pop;
			parameters[6].Value = model.community_lv_street_agency_num;
			parameters[7].Value = model.community_lv_street_agency_pop;
			parameters[8].Value = model.community_lv_neighborhood_committee_num;
			parameters[9].Value = model.community_lv_neighborhood_committee_pop;
			parameters[10].Value = model.community_lv_immigration_num;
			parameters[11].Value = model.community_lv_basic_fac_num;
			parameters[12].Value = model.community_lv_service_fac_num;
			parameters[13].Value = model.community_lv_livelihood_difficulty_num;
			parameters[14].Value = model.community_lv_disputes_complaints_num;
			parameters[15].Value = model.tclvunset1;
			parameters[16].Value = model.tclvunset2;
			parameters[17].Value = model.tclvunset3;
			parameters[18].Value = model.tclvunset4;
			parameters[19].Value = model.tclvunset5;
			parameters[20].Value = model.tclvunset6;
			parameters[21].Value = model.tclvunset7;
			parameters[22].Value = model.tclvunset8;
			parameters[23].Value = model.tclvunset9;
			parameters[24].Value = model.tclvunset10;
			parameters[25].Value = model.tclvunset11;
			parameters[26].Value = model.tclvunset12;
			parameters[27].Value = model.tclvunset13;
			parameters[28].Value = model.tclvunset14;
			parameters[29].Value = model.tclvunset15;
			parameters[30].Value = model.lock_tables;
			parameters[31].Value = model.check_status;
			parameters[32].Value = model.community_id;
			parameters[33].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_letter_view ");
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
		public TTG.Model.TTGWeb.community_letter_view GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_lv_num,community_lv_pop,community_lv_county_government_num,community_lv_county_government_pop,community_lv_county_industry_num,community_lv_county_industry_pop,community_lv_street_agency_num,community_lv_street_agency_pop,community_lv_neighborhood_committee_num,community_lv_neighborhood_committee_pop,community_lv_immigration_num,community_lv_basic_fac_num,community_lv_service_fac_num,community_lv_livelihood_difficulty_num,community_lv_disputes_complaints_num,statistics_date,tclvunset1,tclvunset2,tclvunset3,tclvunset4,tclvunset5,tclvunset6,tclvunset7,tclvunset8,tclvunset9,tclvunset10,tclvunset11,tclvunset12,tclvunset13,tclvunset14,tclvunset15,lock_tables,check_status from T_community_letter_view ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_letter_view model=new TTG.Model.TTGWeb.community_letter_view();
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
		public TTG.Model.TTGWeb.community_letter_view DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_letter_view model=new TTG.Model.TTGWeb.community_letter_view();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_lv_num"]!=null && row["community_lv_num"].ToString()!="")
				{
					model.community_lv_num=int.Parse(row["community_lv_num"].ToString());
				}
				if(row["community_lv_pop"]!=null && row["community_lv_pop"].ToString()!="")
				{
					model.community_lv_pop=int.Parse(row["community_lv_pop"].ToString());
				}
				if(row["community_lv_county_government_num"]!=null && row["community_lv_county_government_num"].ToString()!="")
				{
					model.community_lv_county_government_num=int.Parse(row["community_lv_county_government_num"].ToString());
				}
				if(row["community_lv_county_government_pop"]!=null && row["community_lv_county_government_pop"].ToString()!="")
				{
					model.community_lv_county_government_pop=int.Parse(row["community_lv_county_government_pop"].ToString());
				}
				if(row["community_lv_county_industry_num"]!=null && row["community_lv_county_industry_num"].ToString()!="")
				{
					model.community_lv_county_industry_num=int.Parse(row["community_lv_county_industry_num"].ToString());
				}
				if(row["community_lv_county_industry_pop"]!=null && row["community_lv_county_industry_pop"].ToString()!="")
				{
					model.community_lv_county_industry_pop=int.Parse(row["community_lv_county_industry_pop"].ToString());
				}
				if(row["community_lv_street_agency_num"]!=null && row["community_lv_street_agency_num"].ToString()!="")
				{
					model.community_lv_street_agency_num=int.Parse(row["community_lv_street_agency_num"].ToString());
				}
				if(row["community_lv_street_agency_pop"]!=null && row["community_lv_street_agency_pop"].ToString()!="")
				{
					model.community_lv_street_agency_pop=int.Parse(row["community_lv_street_agency_pop"].ToString());
				}
				if(row["community_lv_neighborhood_committee_num"]!=null && row["community_lv_neighborhood_committee_num"].ToString()!="")
				{
					model.community_lv_neighborhood_committee_num=int.Parse(row["community_lv_neighborhood_committee_num"].ToString());
				}
				if(row["community_lv_neighborhood_committee_pop"]!=null && row["community_lv_neighborhood_committee_pop"].ToString()!="")
				{
					model.community_lv_neighborhood_committee_pop=int.Parse(row["community_lv_neighborhood_committee_pop"].ToString());
				}
				if(row["community_lv_immigration_num"]!=null && row["community_lv_immigration_num"].ToString()!="")
				{
					model.community_lv_immigration_num=int.Parse(row["community_lv_immigration_num"].ToString());
				}
				if(row["community_lv_basic_fac_num"]!=null && row["community_lv_basic_fac_num"].ToString()!="")
				{
					model.community_lv_basic_fac_num=int.Parse(row["community_lv_basic_fac_num"].ToString());
				}
				if(row["community_lv_service_fac_num"]!=null && row["community_lv_service_fac_num"].ToString()!="")
				{
					model.community_lv_service_fac_num=int.Parse(row["community_lv_service_fac_num"].ToString());
				}
				if(row["community_lv_livelihood_difficulty_num"]!=null && row["community_lv_livelihood_difficulty_num"].ToString()!="")
				{
					model.community_lv_livelihood_difficulty_num=int.Parse(row["community_lv_livelihood_difficulty_num"].ToString());
				}
				if(row["community_lv_disputes_complaints_num"]!=null && row["community_lv_disputes_complaints_num"].ToString()!="")
				{
					model.community_lv_disputes_complaints_num=int.Parse(row["community_lv_disputes_complaints_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tclvunset1"]!=null)
				{
					model.tclvunset1=row["tclvunset1"].ToString();
				}
				if(row["tclvunset2"]!=null)
				{
					model.tclvunset2=row["tclvunset2"].ToString();
				}
				if(row["tclvunset3"]!=null)
				{
					model.tclvunset3=row["tclvunset3"].ToString();
				}
				if(row["tclvunset4"]!=null)
				{
					model.tclvunset4=row["tclvunset4"].ToString();
				}
				if(row["tclvunset5"]!=null)
				{
					model.tclvunset5=row["tclvunset5"].ToString();
				}
				if(row["tclvunset6"]!=null)
				{
					model.tclvunset6=row["tclvunset6"].ToString();
				}
				if(row["tclvunset7"]!=null)
				{
					model.tclvunset7=row["tclvunset7"].ToString();
				}
				if(row["tclvunset8"]!=null)
				{
					model.tclvunset8=row["tclvunset8"].ToString();
				}
				if(row["tclvunset9"]!=null)
				{
					model.tclvunset9=row["tclvunset9"].ToString();
				}
				if(row["tclvunset10"]!=null)
				{
					model.tclvunset10=row["tclvunset10"].ToString();
				}
				if(row["tclvunset11"]!=null)
				{
					model.tclvunset11=row["tclvunset11"].ToString();
				}
				if(row["tclvunset12"]!=null)
				{
					model.tclvunset12=row["tclvunset12"].ToString();
				}
				if(row["tclvunset13"]!=null)
				{
					model.tclvunset13=row["tclvunset13"].ToString();
				}
				if(row["tclvunset14"]!=null)
				{
					model.tclvunset14=row["tclvunset14"].ToString();
				}
				if(row["tclvunset15"]!=null)
				{
					model.tclvunset15=row["tclvunset15"].ToString();
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
			strSql.Append("select community_id,community_lv_num,community_lv_pop,community_lv_county_government_num,community_lv_county_government_pop,community_lv_county_industry_num,community_lv_county_industry_pop,community_lv_street_agency_num,community_lv_street_agency_pop,community_lv_neighborhood_committee_num,community_lv_neighborhood_committee_pop,community_lv_immigration_num,community_lv_basic_fac_num,community_lv_service_fac_num,community_lv_livelihood_difficulty_num,community_lv_disputes_complaints_num,statistics_date,tclvunset1,tclvunset2,tclvunset3,tclvunset4,tclvunset5,tclvunset6,tclvunset7,tclvunset8,tclvunset9,tclvunset10,tclvunset11,tclvunset12,tclvunset13,tclvunset14,tclvunset15,lock_tables,check_status ");
			strSql.Append(" FROM T_community_letter_view ");
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
			strSql.Append(" community_id,community_lv_num,community_lv_pop,community_lv_county_government_num,community_lv_county_government_pop,community_lv_county_industry_num,community_lv_county_industry_pop,community_lv_street_agency_num,community_lv_street_agency_pop,community_lv_neighborhood_committee_num,community_lv_neighborhood_committee_pop,community_lv_immigration_num,community_lv_basic_fac_num,community_lv_service_fac_num,community_lv_livelihood_difficulty_num,community_lv_disputes_complaints_num,statistics_date,tclvunset1,tclvunset2,tclvunset3,tclvunset4,tclvunset5,tclvunset6,tclvunset7,tclvunset8,tclvunset9,tclvunset10,tclvunset11,tclvunset12,tclvunset13,tclvunset14,tclvunset15,lock_tables,check_status ");
			strSql.Append(" FROM T_community_letter_view ");
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
			strSql.Append("select count(1) FROM T_community_letter_view ");
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
			strSql.Append(")AS Row, T.*  from T_community_letter_view T ");
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
			parameters[0].Value = "T_community_letter_view";
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

