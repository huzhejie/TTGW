using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:Community_Base
	/// </summary>
	public partial class Community_Base
	{
		public Community_Base()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Community_Base");
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
		public bool Add(TTG.Model.TTGWeb.Community_Base model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Community_Base(");
			strSql.Append("community_id,community_name,community_location,community_county,community_type,community_feature,community_function_area,community_function_type,distance_to_county,distance_to_street_committees,distance_to_main_business_area,distance_to_main_education_area,distance_to_railway_station,distance_to_coach_station,distance_to_passenger_quay,distance_to_main_street,distance_to_collector_street,statistics_date,tbcunset1,tbcunset2,tbcunset3,tbcunset4,tbcunset5,tbcunset6,tbcunset7,tbcunset8,tbcunset9,tbcunset10,tbcunset11,tbcunset12,tbcunset13,tbcunset14,tbcunset15,tbcunset16,tbcunset17,check_status,lock_tables,community_wcommunity,community_category,community_construct_year,community_province)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_name,@community_location,@community_county,@community_type,@community_feature,@community_function_area,@community_function_type,@distance_to_county,@distance_to_street_committees,@distance_to_main_business_area,@distance_to_main_education_area,@distance_to_railway_station,@distance_to_coach_station,@distance_to_passenger_quay,@distance_to_main_street,@distance_to_collector_street,@statistics_date,@tbcunset1,@tbcunset2,@tbcunset3,@tbcunset4,@tbcunset5,@tbcunset6,@tbcunset7,@tbcunset8,@tbcunset9,@tbcunset10,@tbcunset11,@tbcunset12,@tbcunset13,@tbcunset14,@tbcunset15,@tbcunset16,@tbcunset17,@check_status,@lock_tables,@community_wcommunity,@community_category,@community_construct_year,@community_province)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@community_location", SqlDbType.VarChar,200),
					new SqlParameter("@community_county", SqlDbType.VarChar,50),
					new SqlParameter("@community_type", SqlDbType.VarChar,20),
					new SqlParameter("@community_feature", SqlDbType.VarChar,100),
					new SqlParameter("@community_function_area", SqlDbType.VarChar,50),
					new SqlParameter("@community_function_type", SqlDbType.VarChar,50),
					new SqlParameter("@distance_to_county", SqlDbType.Float,8),
					new SqlParameter("@distance_to_street_committees", SqlDbType.Float,8),
					new SqlParameter("@distance_to_main_business_area", SqlDbType.Float,8),
					new SqlParameter("@distance_to_main_education_area", SqlDbType.Float,8),
					new SqlParameter("@distance_to_railway_station", SqlDbType.Float,8),
					new SqlParameter("@distance_to_coach_station", SqlDbType.Float,8),
					new SqlParameter("@distance_to_passenger_quay", SqlDbType.Float,8),
					new SqlParameter("@distance_to_main_street", SqlDbType.Float,8),
					new SqlParameter("@distance_to_collector_street", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tbcunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset17", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_wcommunity", SqlDbType.VarChar,50),
					new SqlParameter("@community_category", SqlDbType.VarChar,20),
					new SqlParameter("@community_construct_year", SqlDbType.Int,4),
					new SqlParameter("@community_province", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_name;
			parameters[2].Value = model.community_location;
			parameters[3].Value = model.community_county;
			parameters[4].Value = model.community_type;
			parameters[5].Value = model.community_feature;
			parameters[6].Value = model.community_function_area;
			parameters[7].Value = model.community_function_type;
			parameters[8].Value = model.distance_to_county;
			parameters[9].Value = model.distance_to_street_committees;
			parameters[10].Value = model.distance_to_main_business_area;
			parameters[11].Value = model.distance_to_main_education_area;
			parameters[12].Value = model.distance_to_railway_station;
			parameters[13].Value = model.distance_to_coach_station;
			parameters[14].Value = model.distance_to_passenger_quay;
			parameters[15].Value = model.distance_to_main_street;
			parameters[16].Value = model.distance_to_collector_street;
			parameters[17].Value = model.statistics_date;
			parameters[18].Value = model.tbcunset1;
			parameters[19].Value = model.tbcunset2;
			parameters[20].Value = model.tbcunset3;
			parameters[21].Value = model.tbcunset4;
			parameters[22].Value = model.tbcunset5;
			parameters[23].Value = model.tbcunset6;
			parameters[24].Value = model.tbcunset7;
			parameters[25].Value = model.tbcunset8;
			parameters[26].Value = model.tbcunset9;
			parameters[27].Value = model.tbcunset10;
			parameters[28].Value = model.tbcunset11;
			parameters[29].Value = model.tbcunset12;
			parameters[30].Value = model.tbcunset13;
			parameters[31].Value = model.tbcunset14;
			parameters[32].Value = model.tbcunset15;
			parameters[33].Value = model.tbcunset16;
			parameters[34].Value = model.tbcunset17;
			parameters[35].Value = model.check_status;
			parameters[36].Value = model.lock_tables;
			parameters[37].Value = model.community_wcommunity;
			parameters[38].Value = model.community_category;
			parameters[39].Value = model.community_construct_year;
			parameters[40].Value = model.community_province;

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
		public bool Update(TTG.Model.TTGWeb.Community_Base model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Community_Base set ");
			strSql.Append("community_name=@community_name,");
			strSql.Append("community_location=@community_location,");
			strSql.Append("community_county=@community_county,");
			strSql.Append("community_type=@community_type,");
			strSql.Append("community_feature=@community_feature,");
			strSql.Append("community_function_area=@community_function_area,");
			strSql.Append("community_function_type=@community_function_type,");
			strSql.Append("distance_to_county=@distance_to_county,");
			strSql.Append("distance_to_street_committees=@distance_to_street_committees,");
			strSql.Append("distance_to_main_business_area=@distance_to_main_business_area,");
			strSql.Append("distance_to_main_education_area=@distance_to_main_education_area,");
			strSql.Append("distance_to_railway_station=@distance_to_railway_station,");
			strSql.Append("distance_to_coach_station=@distance_to_coach_station,");
			strSql.Append("distance_to_passenger_quay=@distance_to_passenger_quay,");
			strSql.Append("distance_to_main_street=@distance_to_main_street,");
			strSql.Append("distance_to_collector_street=@distance_to_collector_street,");
			strSql.Append("tbcunset1=@tbcunset1,");
			strSql.Append("tbcunset2=@tbcunset2,");
			strSql.Append("tbcunset3=@tbcunset3,");
			strSql.Append("tbcunset4=@tbcunset4,");
			strSql.Append("tbcunset5=@tbcunset5,");
			strSql.Append("tbcunset6=@tbcunset6,");
			strSql.Append("tbcunset7=@tbcunset7,");
			strSql.Append("tbcunset8=@tbcunset8,");
			strSql.Append("tbcunset9=@tbcunset9,");
			strSql.Append("tbcunset10=@tbcunset10,");
			strSql.Append("tbcunset11=@tbcunset11,");
			strSql.Append("tbcunset12=@tbcunset12,");
			strSql.Append("tbcunset13=@tbcunset13,");
			strSql.Append("tbcunset14=@tbcunset14,");
			strSql.Append("tbcunset15=@tbcunset15,");
			strSql.Append("tbcunset16=@tbcunset16,");
			strSql.Append("tbcunset17=@tbcunset17,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("community_wcommunity=@community_wcommunity,");
			strSql.Append("community_category=@community_category,");
			strSql.Append("community_construct_year=@community_construct_year,");
			strSql.Append("community_province=@community_province");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@community_location", SqlDbType.VarChar,200),
					new SqlParameter("@community_county", SqlDbType.VarChar,50),
					new SqlParameter("@community_type", SqlDbType.VarChar,20),
					new SqlParameter("@community_feature", SqlDbType.VarChar,100),
					new SqlParameter("@community_function_area", SqlDbType.VarChar,50),
					new SqlParameter("@community_function_type", SqlDbType.VarChar,50),
					new SqlParameter("@distance_to_county", SqlDbType.Float,8),
					new SqlParameter("@distance_to_street_committees", SqlDbType.Float,8),
					new SqlParameter("@distance_to_main_business_area", SqlDbType.Float,8),
					new SqlParameter("@distance_to_main_education_area", SqlDbType.Float,8),
					new SqlParameter("@distance_to_railway_station", SqlDbType.Float,8),
					new SqlParameter("@distance_to_coach_station", SqlDbType.Float,8),
					new SqlParameter("@distance_to_passenger_quay", SqlDbType.Float,8),
					new SqlParameter("@distance_to_main_street", SqlDbType.Float,8),
					new SqlParameter("@distance_to_collector_street", SqlDbType.Float,8),
					new SqlParameter("@tbcunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tbcunset17", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_wcommunity", SqlDbType.VarChar,50),
					new SqlParameter("@community_category", SqlDbType.VarChar,20),
					new SqlParameter("@community_construct_year", SqlDbType.Int,4),
					new SqlParameter("@community_province", SqlDbType.VarChar,50),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_name;
			parameters[1].Value = model.community_location;
			parameters[2].Value = model.community_county;
			parameters[3].Value = model.community_type;
			parameters[4].Value = model.community_feature;
			parameters[5].Value = model.community_function_area;
			parameters[6].Value = model.community_function_type;
			parameters[7].Value = model.distance_to_county;
			parameters[8].Value = model.distance_to_street_committees;
			parameters[9].Value = model.distance_to_main_business_area;
			parameters[10].Value = model.distance_to_main_education_area;
			parameters[11].Value = model.distance_to_railway_station;
			parameters[12].Value = model.distance_to_coach_station;
			parameters[13].Value = model.distance_to_passenger_quay;
			parameters[14].Value = model.distance_to_main_street;
			parameters[15].Value = model.distance_to_collector_street;
			parameters[16].Value = model.tbcunset1;
			parameters[17].Value = model.tbcunset2;
			parameters[18].Value = model.tbcunset3;
			parameters[19].Value = model.tbcunset4;
			parameters[20].Value = model.tbcunset5;
			parameters[21].Value = model.tbcunset6;
			parameters[22].Value = model.tbcunset7;
			parameters[23].Value = model.tbcunset8;
			parameters[24].Value = model.tbcunset9;
			parameters[25].Value = model.tbcunset10;
			parameters[26].Value = model.tbcunset11;
			parameters[27].Value = model.tbcunset12;
			parameters[28].Value = model.tbcunset13;
			parameters[29].Value = model.tbcunset14;
			parameters[30].Value = model.tbcunset15;
			parameters[31].Value = model.tbcunset16;
			parameters[32].Value = model.tbcunset17;
			parameters[33].Value = model.check_status;
			parameters[34].Value = model.lock_tables;
			parameters[35].Value = model.community_wcommunity;
			parameters[36].Value = model.community_category;
			parameters[37].Value = model.community_construct_year;
			parameters[38].Value = model.community_province;
			parameters[39].Value = model.community_id;
			parameters[40].Value = model.statistics_date;

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
			strSql.Append("delete from T_Community_Base ");
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
		public TTG.Model.TTGWeb.Community_Base GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_name,community_location,community_county,community_type,community_feature,community_function_area,community_function_type,distance_to_county,distance_to_street_committees,distance_to_main_business_area,distance_to_main_education_area,distance_to_railway_station,distance_to_coach_station,distance_to_passenger_quay,distance_to_main_street,distance_to_collector_street,statistics_date,tbcunset1,tbcunset2,tbcunset3,tbcunset4,tbcunset5,tbcunset6,tbcunset7,tbcunset8,tbcunset9,tbcunset10,tbcunset11,tbcunset12,tbcunset13,tbcunset14,tbcunset15,tbcunset16,tbcunset17,check_status,lock_tables,community_wcommunity,community_category,community_construct_year,community_province from T_Community_Base ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.Community_Base model=new TTG.Model.TTGWeb.Community_Base();
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
		public TTG.Model.TTGWeb.Community_Base DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.Community_Base model=new TTG.Model.TTGWeb.Community_Base();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_name"]!=null)
				{
					model.community_name=row["community_name"].ToString();
				}
				if(row["community_location"]!=null)
				{
					model.community_location=row["community_location"].ToString();
				}
				if(row["community_county"]!=null)
				{
					model.community_county=row["community_county"].ToString();
				}
				if(row["community_type"]!=null)
				{
					model.community_type=row["community_type"].ToString();
				}
				if(row["community_feature"]!=null)
				{
					model.community_feature=row["community_feature"].ToString();
				}
				if(row["community_function_area"]!=null)
				{
					model.community_function_area=row["community_function_area"].ToString();
				}
				if(row["community_function_type"]!=null)
				{
					model.community_function_type=row["community_function_type"].ToString();
				}
				if(row["distance_to_county"]!=null && row["distance_to_county"].ToString()!="")
				{
					model.distance_to_county=decimal.Parse(row["distance_to_county"].ToString());
				}
				if(row["distance_to_street_committees"]!=null && row["distance_to_street_committees"].ToString()!="")
				{
					model.distance_to_street_committees=decimal.Parse(row["distance_to_street_committees"].ToString());
				}
				if(row["distance_to_main_business_area"]!=null && row["distance_to_main_business_area"].ToString()!="")
				{
					model.distance_to_main_business_area=decimal.Parse(row["distance_to_main_business_area"].ToString());
				}
				if(row["distance_to_main_education_area"]!=null && row["distance_to_main_education_area"].ToString()!="")
				{
					model.distance_to_main_education_area=decimal.Parse(row["distance_to_main_education_area"].ToString());
				}
				if(row["distance_to_railway_station"]!=null && row["distance_to_railway_station"].ToString()!="")
				{
					model.distance_to_railway_station=decimal.Parse(row["distance_to_railway_station"].ToString());
				}
				if(row["distance_to_coach_station"]!=null && row["distance_to_coach_station"].ToString()!="")
				{
					model.distance_to_coach_station=decimal.Parse(row["distance_to_coach_station"].ToString());
				}
				if(row["distance_to_passenger_quay"]!=null && row["distance_to_passenger_quay"].ToString()!="")
				{
					model.distance_to_passenger_quay=decimal.Parse(row["distance_to_passenger_quay"].ToString());
				}
				if(row["distance_to_main_street"]!=null && row["distance_to_main_street"].ToString()!="")
				{
					model.distance_to_main_street=decimal.Parse(row["distance_to_main_street"].ToString());
				}
				if(row["distance_to_collector_street"]!=null && row["distance_to_collector_street"].ToString()!="")
				{
					model.distance_to_collector_street=decimal.Parse(row["distance_to_collector_street"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tbcunset1"]!=null)
				{
					model.tbcunset1=row["tbcunset1"].ToString();
				}
				if(row["tbcunset2"]!=null)
				{
					model.tbcunset2=row["tbcunset2"].ToString();
				}
				if(row["tbcunset3"]!=null)
				{
					model.tbcunset3=row["tbcunset3"].ToString();
				}
				if(row["tbcunset4"]!=null)
				{
					model.tbcunset4=row["tbcunset4"].ToString();
				}
				if(row["tbcunset5"]!=null)
				{
					model.tbcunset5=row["tbcunset5"].ToString();
				}
				if(row["tbcunset6"]!=null)
				{
					model.tbcunset6=row["tbcunset6"].ToString();
				}
				if(row["tbcunset7"]!=null)
				{
					model.tbcunset7=row["tbcunset7"].ToString();
				}
				if(row["tbcunset8"]!=null)
				{
					model.tbcunset8=row["tbcunset8"].ToString();
				}
				if(row["tbcunset9"]!=null)
				{
					model.tbcunset9=row["tbcunset9"].ToString();
				}
				if(row["tbcunset10"]!=null)
				{
					model.tbcunset10=row["tbcunset10"].ToString();
				}
				if(row["tbcunset11"]!=null)
				{
					model.tbcunset11=row["tbcunset11"].ToString();
				}
				if(row["tbcunset12"]!=null)
				{
					model.tbcunset12=row["tbcunset12"].ToString();
				}
				if(row["tbcunset13"]!=null)
				{
					model.tbcunset13=row["tbcunset13"].ToString();
				}
				if(row["tbcunset14"]!=null)
				{
					model.tbcunset14=row["tbcunset14"].ToString();
				}
				if(row["tbcunset15"]!=null)
				{
					model.tbcunset15=row["tbcunset15"].ToString();
				}
				if(row["tbcunset16"]!=null)
				{
					model.tbcunset16=row["tbcunset16"].ToString();
				}
				if(row["tbcunset17"]!=null)
				{
					model.tbcunset17=row["tbcunset17"].ToString();
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["community_wcommunity"]!=null)
				{
					model.community_wcommunity=row["community_wcommunity"].ToString();
				}
				if(row["community_category"]!=null)
				{
					model.community_category=row["community_category"].ToString();
				}
				if(row["community_construct_year"]!=null && row["community_construct_year"].ToString()!="")
				{
					model.community_construct_year=int.Parse(row["community_construct_year"].ToString());
				}
				if(row["community_province"]!=null)
				{
					model.community_province=row["community_province"].ToString();
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
			strSql.Append("select community_id,community_name,community_location,community_county,community_type,community_feature,community_function_area,community_function_type,distance_to_county,distance_to_street_committees,distance_to_main_business_area,distance_to_main_education_area,distance_to_railway_station,distance_to_coach_station,distance_to_passenger_quay,distance_to_main_street,distance_to_collector_street,statistics_date,tbcunset1,tbcunset2,tbcunset3,tbcunset4,tbcunset5,tbcunset6,tbcunset7,tbcunset8,tbcunset9,tbcunset10,tbcunset11,tbcunset12,tbcunset13,tbcunset14,tbcunset15,tbcunset16,tbcunset17,check_status,lock_tables,community_wcommunity,community_category,community_construct_year,community_province ");
			strSql.Append(" FROM T_Community_Base ");
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
			strSql.Append(" community_id,community_name,community_location,community_county,community_type,community_feature,community_function_area,community_function_type,distance_to_county,distance_to_street_committees,distance_to_main_business_area,distance_to_main_education_area,distance_to_railway_station,distance_to_coach_station,distance_to_passenger_quay,distance_to_main_street,distance_to_collector_street,statistics_date,tbcunset1,tbcunset2,tbcunset3,tbcunset4,tbcunset5,tbcunset6,tbcunset7,tbcunset8,tbcunset9,tbcunset10,tbcunset11,tbcunset12,tbcunset13,tbcunset14,tbcunset15,tbcunset16,tbcunset17,check_status,lock_tables,community_wcommunity,community_category,community_construct_year,community_province ");
			strSql.Append(" FROM T_Community_Base ");
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
			strSql.Append("select count(1) FROM T_Community_Base ");
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
			strSql.Append(")AS Row, T.*  from T_Community_Base T ");
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
			parameters[0].Value = "T_Community_Base";
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
        //查询小区的名称
        public String getName(String community_id)
        {
            Community_Base dcb = new Community_Base();
            Model.TTGWeb.Community_Base mcb = dcb.GetModel(community_id, TTG.DBUtility.TTGutil.getLastestDate());
            return mcb.community_name;
        }
        //查询小区的id
        public String getId(String name)
        {
            String community_id = null;
            String sqlstr = "SELECT community_id FROM T_community_Base WHERE community_name='" + name + "'";
            SqlDataReader sdr = Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(sqlstr);
            if (!sdr.HasRows)
            {
                throw new Exception("查询失败");
            }
            else
            {
                if (sdr.Read())
                {

                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        community_id = sdr.GetString(0);

                    }
                }
                sdr.Close();
                return community_id;
            }

        }
        /// <summary>
        /// 返回小区实体类
        /// </summary>
        /// <param name="provice_name"></param>
        /// <param name="county_name"></param>
        /// <param name="community_name"></param>
        /// <returns></returns>
        public Model.TTGWeb.Community_Base getModel(string province_name, string county_name, string community_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 community_id,community_name,community_location,community_county,community_type,community_feature,community_function_area,community_function_type,distance_to_county,distance_to_street_committees,distance_to_main_business_area,distance_to_main_education_area,distance_to_railway_station,distance_to_coach_station,distance_to_passenger_quay,distance_to_main_street,distance_to_collector_street,statistics_date,tbcunset1,tbcunset2,tbcunset3,tbcunset4,tbcunset5,tbcunset6,tbcunset7,tbcunset8,tbcunset9,tbcunset10,tbcunset11,tbcunset12,tbcunset13,tbcunset14,tbcunset15,tbcunset16,tbcunset17,check_status,lock_tables,community_wcommunity,community_category,community_construct_year,community_province from T_Community_Base ");
            strSql.Append(" where community_province = @province and community_county = @county and community_name = @community ");
            SqlParameter[] parameters = {
					new SqlParameter("@province", SqlDbType.VarChar,50),
					new SqlParameter("@county", SqlDbType.VarChar,50),
                    new SqlParameter("@community", SqlDbType.VarChar,50)                    };
            parameters[0].Value = province_name;
            parameters[1].Value = county_name;
            parameters[2].Value = community_name;

            TTG.Model.TTGWeb.Community_Base model = new TTG.Model.TTGWeb.Community_Base();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据小区id查询小区相关信息
        /// </summary>
        /// <param name="community_id">小区id</param>        
        /// <returns></returns>
        public DataSet getCommunityInfo(string community_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct community_county,community_name,community_province from T_Community_Base");
            strSql.Append(" where community_id=@community_id");
            SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)
					};
            parameters[0].Value = community_id;
            return DbHelperSQL.Query(strSql.ToString(), parameters);           
        }
		#endregion  ExtensionMethod
	}
}

