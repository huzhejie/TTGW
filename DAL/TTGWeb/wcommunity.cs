using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:wcommunity
	/// </summary>
	public partial class wcommunity
	{
		public wcommunity()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string wcommunity_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_wcommunity");
			strSql.Append(" where wcommunity_id=@wcommunity_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@wcommunity_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = wcommunity_id;
			parameters[1].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.wcommunity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_wcommunity(");
			strSql.Append("wcommunity_id,wcommunity_name,kindergarten_capacity,integrated_management_building_area,medical_bed_num,parking_space_num,convenience_stores_area,vegetable_market_area,culture_fitness_facility_area,facilities_for_elders_area,twunset1,twunset2,twunset3,twunset4,twunset5,twunset6,twunset7,twunset8,twunset9,lock_tables,check_status,statistics_date,wcommunity_family_num,community_name,wcommunity_people_num)");
			strSql.Append(" values (");
			strSql.Append("@wcommunity_id,@wcommunity_name,@kindergarten_capacity,@integrated_management_building_area,@medical_bed_num,@parking_space_num,@convenience_stores_area,@vegetable_market_area,@culture_fitness_facility_area,@facilities_for_elders_area,@twunset1,@twunset2,@twunset3,@twunset4,@twunset5,@twunset6,@twunset7,@twunset8,@twunset9,@lock_tables,@check_status,@statistics_date,@wcommunity_family_num,@community_name,@wcommunity_people_num)");
			SqlParameter[] parameters = {
					new SqlParameter("@wcommunity_id", SqlDbType.VarChar,20),
					new SqlParameter("@wcommunity_name", SqlDbType.VarChar,50),
					new SqlParameter("@kindergarten_capacity", SqlDbType.Float,8),
					new SqlParameter("@integrated_management_building_area", SqlDbType.Float,8),
					new SqlParameter("@medical_bed_num", SqlDbType.Int,4),
					new SqlParameter("@parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@convenience_stores_area", SqlDbType.Float,8),
					new SqlParameter("@vegetable_market_area", SqlDbType.Float,8),
					new SqlParameter("@culture_fitness_facility_area", SqlDbType.Float,8),
					new SqlParameter("@facilities_for_elders_area", SqlDbType.Float,8),
					new SqlParameter("@twunset1", SqlDbType.VarChar,50),
					new SqlParameter("@twunset2", SqlDbType.VarChar,50),
					new SqlParameter("@twunset3", SqlDbType.VarChar,50),
					new SqlParameter("@twunset4", SqlDbType.VarChar,50),
					new SqlParameter("@twunset5", SqlDbType.VarChar,50),
					new SqlParameter("@twunset6", SqlDbType.VarChar,50),
					new SqlParameter("@twunset7", SqlDbType.VarChar,50),
					new SqlParameter("@twunset8", SqlDbType.VarChar,50),
					new SqlParameter("@twunset9", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@wcommunity_family_num", SqlDbType.Int,4),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@wcommunity_people_num", SqlDbType.Int,4)};
			parameters[0].Value = model.wcommunity_id;
			parameters[1].Value = model.wcommunity_name;
			parameters[2].Value = model.kindergarten_capacity;
			parameters[3].Value = model.integrated_management_building_area;
			parameters[4].Value = model.medical_bed_num;
			parameters[5].Value = model.parking_space_num;
			parameters[6].Value = model.convenience_stores_area;
			parameters[7].Value = model.vegetable_market_area;
			parameters[8].Value = model.culture_fitness_facility_area;
			parameters[9].Value = model.facilities_for_elders_area;
			parameters[10].Value = model.twunset1;
			parameters[11].Value = model.twunset2;
			parameters[12].Value = model.twunset3;
			parameters[13].Value = model.twunset4;
			parameters[14].Value = model.twunset5;
			parameters[15].Value = model.twunset6;
			parameters[16].Value = model.twunset7;
			parameters[17].Value = model.twunset8;
			parameters[18].Value = model.twunset9;
			parameters[19].Value = model.lock_tables;
			parameters[20].Value = model.check_status;
			parameters[21].Value = model.statistics_date;
			parameters[22].Value = model.wcommunity_family_num;
			parameters[23].Value = model.community_name;
			parameters[24].Value = model.wcommunity_people_num;

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
		public bool Update(TTG.Model.TTGWeb.wcommunity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_wcommunity set ");
			strSql.Append("wcommunity_name=@wcommunity_name,");
			strSql.Append("kindergarten_capacity=@kindergarten_capacity,");
			strSql.Append("integrated_management_building_area=@integrated_management_building_area,");
			strSql.Append("medical_bed_num=@medical_bed_num,");
			strSql.Append("parking_space_num=@parking_space_num,");
			strSql.Append("convenience_stores_area=@convenience_stores_area,");
			strSql.Append("vegetable_market_area=@vegetable_market_area,");
			strSql.Append("culture_fitness_facility_area=@culture_fitness_facility_area,");
			strSql.Append("facilities_for_elders_area=@facilities_for_elders_area,");
			strSql.Append("twunset1=@twunset1,");
			strSql.Append("twunset2=@twunset2,");
			strSql.Append("twunset3=@twunset3,");
			strSql.Append("twunset4=@twunset4,");
			strSql.Append("twunset5=@twunset5,");
			strSql.Append("twunset6=@twunset6,");
			strSql.Append("twunset7=@twunset7,");
			strSql.Append("twunset8=@twunset8,");
			strSql.Append("twunset9=@twunset9,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("wcommunity_family_num=@wcommunity_family_num,");
			strSql.Append("community_name=@community_name,");
			strSql.Append("wcommunity_people_num=@wcommunity_people_num");
			strSql.Append(" where wcommunity_id=@wcommunity_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@wcommunity_name", SqlDbType.VarChar,50),
					new SqlParameter("@kindergarten_capacity", SqlDbType.Float,8),
					new SqlParameter("@integrated_management_building_area", SqlDbType.Float,8),
					new SqlParameter("@medical_bed_num", SqlDbType.Int,4),
					new SqlParameter("@parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@convenience_stores_area", SqlDbType.Float,8),
					new SqlParameter("@vegetable_market_area", SqlDbType.Float,8),
					new SqlParameter("@culture_fitness_facility_area", SqlDbType.Float,8),
					new SqlParameter("@facilities_for_elders_area", SqlDbType.Float,8),
					new SqlParameter("@twunset1", SqlDbType.VarChar,50),
					new SqlParameter("@twunset2", SqlDbType.VarChar,50),
					new SqlParameter("@twunset3", SqlDbType.VarChar,50),
					new SqlParameter("@twunset4", SqlDbType.VarChar,50),
					new SqlParameter("@twunset5", SqlDbType.VarChar,50),
					new SqlParameter("@twunset6", SqlDbType.VarChar,50),
					new SqlParameter("@twunset7", SqlDbType.VarChar,50),
					new SqlParameter("@twunset8", SqlDbType.VarChar,50),
					new SqlParameter("@twunset9", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@wcommunity_family_num", SqlDbType.Int,4),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@wcommunity_people_num", SqlDbType.Int,4),
					new SqlParameter("@wcommunity_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.wcommunity_name;
			parameters[1].Value = model.kindergarten_capacity;
			parameters[2].Value = model.integrated_management_building_area;
			parameters[3].Value = model.medical_bed_num;
			parameters[4].Value = model.parking_space_num;
			parameters[5].Value = model.convenience_stores_area;
			parameters[6].Value = model.vegetable_market_area;
			parameters[7].Value = model.culture_fitness_facility_area;
			parameters[8].Value = model.facilities_for_elders_area;
			parameters[9].Value = model.twunset1;
			parameters[10].Value = model.twunset2;
			parameters[11].Value = model.twunset3;
			parameters[12].Value = model.twunset4;
			parameters[13].Value = model.twunset5;
			parameters[14].Value = model.twunset6;
			parameters[15].Value = model.twunset7;
			parameters[16].Value = model.twunset8;
			parameters[17].Value = model.twunset9;
			parameters[18].Value = model.lock_tables;
			parameters[19].Value = model.check_status;
			parameters[20].Value = model.wcommunity_family_num;
			parameters[21].Value = model.community_name;
			parameters[22].Value = model.wcommunity_people_num;
			parameters[23].Value = model.wcommunity_id;
			parameters[24].Value = model.statistics_date;

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
		public bool Delete(string wcommunity_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_wcommunity ");
			strSql.Append(" where wcommunity_id=@wcommunity_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@wcommunity_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = wcommunity_id;
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
		public TTG.Model.TTGWeb.wcommunity GetModel(string wcommunity_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 wcommunity_id,wcommunity_name,kindergarten_capacity,integrated_management_building_area,medical_bed_num,parking_space_num,convenience_stores_area,vegetable_market_area,culture_fitness_facility_area,facilities_for_elders_area,twunset1,twunset2,twunset3,twunset4,twunset5,twunset6,twunset7,twunset8,twunset9,lock_tables,check_status,statistics_date,wcommunity_family_num,community_name,wcommunity_people_num from T_wcommunity ");
			strSql.Append(" where wcommunity_id=@wcommunity_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@wcommunity_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = wcommunity_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.wcommunity model=new TTG.Model.TTGWeb.wcommunity();
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
		public TTG.Model.TTGWeb.wcommunity DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.wcommunity model=new TTG.Model.TTGWeb.wcommunity();
			if (row != null)
			{
				if(row["wcommunity_id"]!=null)
				{
					model.wcommunity_id=row["wcommunity_id"].ToString();
				}
				if(row["wcommunity_name"]!=null)
				{
					model.wcommunity_name=row["wcommunity_name"].ToString();
				}
				if(row["kindergarten_capacity"]!=null && row["kindergarten_capacity"].ToString()!="")
				{
					model.kindergarten_capacity=decimal.Parse(row["kindergarten_capacity"].ToString());
				}
				if(row["integrated_management_building_area"]!=null && row["integrated_management_building_area"].ToString()!="")
				{
					model.integrated_management_building_area=decimal.Parse(row["integrated_management_building_area"].ToString());
				}
				if(row["medical_bed_num"]!=null && row["medical_bed_num"].ToString()!="")
				{
					model.medical_bed_num=int.Parse(row["medical_bed_num"].ToString());
				}
				if(row["parking_space_num"]!=null && row["parking_space_num"].ToString()!="")
				{
					model.parking_space_num=int.Parse(row["parking_space_num"].ToString());
				}
				if(row["convenience_stores_area"]!=null && row["convenience_stores_area"].ToString()!="")
				{
					model.convenience_stores_area=decimal.Parse(row["convenience_stores_area"].ToString());
				}
				if(row["vegetable_market_area"]!=null && row["vegetable_market_area"].ToString()!="")
				{
					model.vegetable_market_area=decimal.Parse(row["vegetable_market_area"].ToString());
				}
				if(row["culture_fitness_facility_area"]!=null && row["culture_fitness_facility_area"].ToString()!="")
				{
					model.culture_fitness_facility_area=decimal.Parse(row["culture_fitness_facility_area"].ToString());
				}
				if(row["facilities_for_elders_area"]!=null && row["facilities_for_elders_area"].ToString()!="")
				{
					model.facilities_for_elders_area=decimal.Parse(row["facilities_for_elders_area"].ToString());
				}
				if(row["twunset1"]!=null)
				{
					model.twunset1=row["twunset1"].ToString();
				}
				if(row["twunset2"]!=null)
				{
					model.twunset2=row["twunset2"].ToString();
				}
				if(row["twunset3"]!=null)
				{
					model.twunset3=row["twunset3"].ToString();
				}
				if(row["twunset4"]!=null)
				{
					model.twunset4=row["twunset4"].ToString();
				}
				if(row["twunset5"]!=null)
				{
					model.twunset5=row["twunset5"].ToString();
				}
				if(row["twunset6"]!=null)
				{
					model.twunset6=row["twunset6"].ToString();
				}
				if(row["twunset7"]!=null)
				{
					model.twunset7=row["twunset7"].ToString();
				}
				if(row["twunset8"]!=null)
				{
					model.twunset8=row["twunset8"].ToString();
				}
				if(row["twunset9"]!=null)
				{
					model.twunset9=row["twunset9"].ToString();
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
				if(row["wcommunity_family_num"]!=null && row["wcommunity_family_num"].ToString()!="")
				{
					model.wcommunity_family_num=int.Parse(row["wcommunity_family_num"].ToString());
				}
				if(row["community_name"]!=null)
				{
					model.community_name=row["community_name"].ToString();
				}
				if(row["wcommunity_people_num"]!=null && row["wcommunity_people_num"].ToString()!="")
				{
					model.wcommunity_people_num=int.Parse(row["wcommunity_people_num"].ToString());
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
			strSql.Append("select wcommunity_id,wcommunity_name,kindergarten_capacity,integrated_management_building_area,medical_bed_num,parking_space_num,convenience_stores_area,vegetable_market_area,culture_fitness_facility_area,facilities_for_elders_area,twunset1,twunset2,twunset3,twunset4,twunset5,twunset6,twunset7,twunset8,twunset9,lock_tables,check_status,statistics_date,wcommunity_family_num,community_name,wcommunity_people_num ");
			strSql.Append(" FROM T_wcommunity ");
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
			strSql.Append(" wcommunity_id,wcommunity_name,kindergarten_capacity,integrated_management_building_area,medical_bed_num,parking_space_num,convenience_stores_area,vegetable_market_area,culture_fitness_facility_area,facilities_for_elders_area,twunset1,twunset2,twunset3,twunset4,twunset5,twunset6,twunset7,twunset8,twunset9,lock_tables,check_status,statistics_date,wcommunity_family_num,community_name,wcommunity_people_num ");
			strSql.Append(" FROM T_wcommunity ");
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
			strSql.Append("select count(1) FROM T_wcommunity ");
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
			strSql.Append(")AS Row, T.*  from T_wcommunity T ");
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
			parameters[0].Value = "T_wcommunity";
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

