using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:important_figures
	/// </summary>
	public partial class important_figures
	{
		public important_figures()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime fill_time)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_important_figures");
			strSql.Append(" where community_id=@community_id and fill_time=@fill_time ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@fill_time", SqlDbType.DateTime)			};
			parameters[0].Value = community_id;
			parameters[1].Value = fill_time;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.important_figures model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_important_figures(");
			strSql.Append("community_id,help_figure,develop_figure,disposable_money_per_people,facade_num,rent_facade_num,average_rent,county_average_rent,labor_num,employed_labor_num,poor_people_num,fill_time,house_rent,positon_advantage,problem_solution,community_kindergarden_capacity,community_manage_house_area,community_medical_bed_capacity,community_stop_car_capacity,community_convinience_store_area,community_food_market_area,community_recreation_and_sports_area,community_pension_facilities_area,background_value_added)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@help_figure,@develop_figure,@disposable_money_per_people,@facade_num,@rent_facade_num,@average_rent,@county_average_rent,@labor_num,@employed_labor_num,@poor_people_num,@fill_time,@house_rent,@positon_advantage,@problem_solution,@community_kindergarden_capacity,@community_manage_house_area,@community_medical_bed_capacity,@community_stop_car_capacity,@community_convinience_store_area,@community_food_market_area,@community_recreation_and_sports_area,@community_pension_facilities_area,@background_value_added)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@help_figure", SqlDbType.Float,8),
					new SqlParameter("@develop_figure", SqlDbType.Float,8),
					new SqlParameter("@disposable_money_per_people", SqlDbType.Float,8),
					new SqlParameter("@facade_num", SqlDbType.Int,4),
					new SqlParameter("@rent_facade_num", SqlDbType.Int,4),
					new SqlParameter("@average_rent", SqlDbType.Float,8),
					new SqlParameter("@county_average_rent", SqlDbType.Float,8),
					new SqlParameter("@labor_num", SqlDbType.Int,4),
					new SqlParameter("@employed_labor_num", SqlDbType.Int,4),
					new SqlParameter("@poor_people_num", SqlDbType.Int,4),
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@house_rent", SqlDbType.Int,4),
					new SqlParameter("@positon_advantage", SqlDbType.NVarChar,200),
					new SqlParameter("@problem_solution", SqlDbType.NVarChar,200),
					new SqlParameter("@community_kindergarden_capacity", SqlDbType.Int,4),
					new SqlParameter("@community_manage_house_area", SqlDbType.Int,4),
					new SqlParameter("@community_medical_bed_capacity", SqlDbType.Int,4),
					new SqlParameter("@community_stop_car_capacity", SqlDbType.Int,4),
					new SqlParameter("@community_convinience_store_area", SqlDbType.Int,4),
					new SqlParameter("@community_food_market_area", SqlDbType.Int,4),
					new SqlParameter("@community_recreation_and_sports_area", SqlDbType.Int,4),
					new SqlParameter("@community_pension_facilities_area", SqlDbType.Int,4),
					new SqlParameter("@background_value_added", SqlDbType.Float,8)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.help_figure;
			parameters[2].Value = model.develop_figure;
			parameters[3].Value = model.disposable_money_per_people;
			parameters[4].Value = model.facade_num;
			parameters[5].Value = model.rent_facade_num;
			parameters[6].Value = model.average_rent;
			parameters[7].Value = model.county_average_rent;
			parameters[8].Value = model.labor_num;
			parameters[9].Value = model.employed_labor_num;
			parameters[10].Value = model.poor_people_num;
			parameters[11].Value = model.fill_time;
			parameters[12].Value = model.house_rent;
			parameters[13].Value = model.positon_advantage;
			parameters[14].Value = model.problem_solution;
			parameters[15].Value = model.community_kindergarden_capacity;
			parameters[16].Value = model.community_manage_house_area;
			parameters[17].Value = model.community_medical_bed_capacity;
			parameters[18].Value = model.community_stop_car_capacity;
			parameters[19].Value = model.community_convinience_store_area;
			parameters[20].Value = model.community_food_market_area;
			parameters[21].Value = model.community_recreation_and_sports_area;
			parameters[22].Value = model.community_pension_facilities_area;
			parameters[23].Value = model.background_value_added;

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
		public bool Update(TTG.Model.TTGWeb.important_figures model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_important_figures set ");
			strSql.Append("help_figure=@help_figure,");
			strSql.Append("develop_figure=@develop_figure,");
			strSql.Append("disposable_money_per_people=@disposable_money_per_people,");
			strSql.Append("facade_num=@facade_num,");
			strSql.Append("rent_facade_num=@rent_facade_num,");
			strSql.Append("average_rent=@average_rent,");
			strSql.Append("county_average_rent=@county_average_rent,");
			strSql.Append("labor_num=@labor_num,");
			strSql.Append("employed_labor_num=@employed_labor_num,");
			strSql.Append("poor_people_num=@poor_people_num,");
			strSql.Append("house_rent=@house_rent,");
			strSql.Append("positon_advantage=@positon_advantage,");
			strSql.Append("problem_solution=@problem_solution,");
			strSql.Append("community_kindergarden_capacity=@community_kindergarden_capacity,");
			strSql.Append("community_manage_house_area=@community_manage_house_area,");
			strSql.Append("community_medical_bed_capacity=@community_medical_bed_capacity,");
			strSql.Append("community_stop_car_capacity=@community_stop_car_capacity,");
			strSql.Append("community_convinience_store_area=@community_convinience_store_area,");
			strSql.Append("community_food_market_area=@community_food_market_area,");
			strSql.Append("community_recreation_and_sports_area=@community_recreation_and_sports_area,");
			strSql.Append("community_pension_facilities_area=@community_pension_facilities_area,");
			strSql.Append("background_value_added=@background_value_added");
			strSql.Append(" where community_id=@community_id and fill_time=@fill_time ");
			SqlParameter[] parameters = {
					new SqlParameter("@help_figure", SqlDbType.Float,8),
					new SqlParameter("@develop_figure", SqlDbType.Float,8),
					new SqlParameter("@disposable_money_per_people", SqlDbType.Float,8),
					new SqlParameter("@facade_num", SqlDbType.Int,4),
					new SqlParameter("@rent_facade_num", SqlDbType.Int,4),
					new SqlParameter("@average_rent", SqlDbType.Float,8),
					new SqlParameter("@county_average_rent", SqlDbType.Float,8),
					new SqlParameter("@labor_num", SqlDbType.Int,4),
					new SqlParameter("@employed_labor_num", SqlDbType.Int,4),
					new SqlParameter("@poor_people_num", SqlDbType.Int,4),
					new SqlParameter("@house_rent", SqlDbType.Int,4),
					new SqlParameter("@positon_advantage", SqlDbType.NVarChar,200),
					new SqlParameter("@problem_solution", SqlDbType.NVarChar,200),
					new SqlParameter("@community_kindergarden_capacity", SqlDbType.Int,4),
					new SqlParameter("@community_manage_house_area", SqlDbType.Int,4),
					new SqlParameter("@community_medical_bed_capacity", SqlDbType.Int,4),
					new SqlParameter("@community_stop_car_capacity", SqlDbType.Int,4),
					new SqlParameter("@community_convinience_store_area", SqlDbType.Int,4),
					new SqlParameter("@community_food_market_area", SqlDbType.Int,4),
					new SqlParameter("@community_recreation_and_sports_area", SqlDbType.Int,4),
					new SqlParameter("@community_pension_facilities_area", SqlDbType.Int,4),
					new SqlParameter("@background_value_added", SqlDbType.Float,8),
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@fill_time", SqlDbType.DateTime)};
			parameters[0].Value = model.help_figure;
			parameters[1].Value = model.develop_figure;
			parameters[2].Value = model.disposable_money_per_people;
			parameters[3].Value = model.facade_num;
			parameters[4].Value = model.rent_facade_num;
			parameters[5].Value = model.average_rent;
			parameters[6].Value = model.county_average_rent;
			parameters[7].Value = model.labor_num;
			parameters[8].Value = model.employed_labor_num;
			parameters[9].Value = model.poor_people_num;
			parameters[10].Value = model.house_rent;
			parameters[11].Value = model.positon_advantage;
			parameters[12].Value = model.problem_solution;
			parameters[13].Value = model.community_kindergarden_capacity;
			parameters[14].Value = model.community_manage_house_area;
			parameters[15].Value = model.community_medical_bed_capacity;
			parameters[16].Value = model.community_stop_car_capacity;
			parameters[17].Value = model.community_convinience_store_area;
			parameters[18].Value = model.community_food_market_area;
			parameters[19].Value = model.community_recreation_and_sports_area;
			parameters[20].Value = model.community_pension_facilities_area;
			parameters[21].Value = model.background_value_added;
			parameters[22].Value = model.community_id;
			parameters[23].Value = model.fill_time;

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
		public bool Delete(string community_id,DateTime fill_time)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_important_figures ");
			strSql.Append(" where community_id=@community_id and fill_time=@fill_time ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@fill_time", SqlDbType.DateTime)			};
			parameters[0].Value = community_id;
			parameters[1].Value = fill_time;

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
		public TTG.Model.TTGWeb.important_figures GetModel(string community_id,DateTime fill_time)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,help_figure,develop_figure,disposable_money_per_people,facade_num,rent_facade_num,average_rent,county_average_rent,labor_num,employed_labor_num,poor_people_num,fill_time,house_rent,positon_advantage,problem_solution,community_kindergarden_capacity,community_manage_house_area,community_medical_bed_capacity,community_stop_car_capacity,community_convinience_store_area,community_food_market_area,community_recreation_and_sports_area,community_pension_facilities_area,background_value_added from T_important_figures ");
			strSql.Append(" where community_id=@community_id and fill_time=@fill_time ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@fill_time", SqlDbType.DateTime)			};
			parameters[0].Value = community_id;
			parameters[1].Value = fill_time;

			TTG.Model.TTGWeb.important_figures model=new TTG.Model.TTGWeb.important_figures();
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
		public TTG.Model.TTGWeb.important_figures DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.important_figures model=new TTG.Model.TTGWeb.important_figures();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["help_figure"]!=null && row["help_figure"].ToString()!="")
				{
					model.help_figure=decimal.Parse(row["help_figure"].ToString());
				}
				if(row["develop_figure"]!=null && row["develop_figure"].ToString()!="")
				{
					model.develop_figure=decimal.Parse(row["develop_figure"].ToString());
				}
				if(row["disposable_money_per_people"]!=null && row["disposable_money_per_people"].ToString()!="")
				{
					model.disposable_money_per_people=decimal.Parse(row["disposable_money_per_people"].ToString());
				}
				if(row["facade_num"]!=null && row["facade_num"].ToString()!="")
				{
					model.facade_num=int.Parse(row["facade_num"].ToString());
				}
				if(row["rent_facade_num"]!=null && row["rent_facade_num"].ToString()!="")
				{
					model.rent_facade_num=int.Parse(row["rent_facade_num"].ToString());
				}
				if(row["average_rent"]!=null && row["average_rent"].ToString()!="")
				{
					model.average_rent=decimal.Parse(row["average_rent"].ToString());
				}
				if(row["county_average_rent"]!=null && row["county_average_rent"].ToString()!="")
				{
					model.county_average_rent=decimal.Parse(row["county_average_rent"].ToString());
				}
				if(row["labor_num"]!=null && row["labor_num"].ToString()!="")
				{
					model.labor_num=int.Parse(row["labor_num"].ToString());
				}
				if(row["employed_labor_num"]!=null && row["employed_labor_num"].ToString()!="")
				{
					model.employed_labor_num=int.Parse(row["employed_labor_num"].ToString());
				}
				if(row["poor_people_num"]!=null && row["poor_people_num"].ToString()!="")
				{
					model.poor_people_num=int.Parse(row["poor_people_num"].ToString());
				}
				if(row["fill_time"]!=null && row["fill_time"].ToString()!="")
				{
					model.fill_time=DateTime.Parse(row["fill_time"].ToString());
				}
				if(row["house_rent"]!=null && row["house_rent"].ToString()!="")
				{
					model.house_rent=int.Parse(row["house_rent"].ToString());
				}
				if(row["positon_advantage"]!=null)
				{
					model.positon_advantage=row["positon_advantage"].ToString();
				}
				if(row["problem_solution"]!=null)
				{
					model.problem_solution=row["problem_solution"].ToString();
				}
				if(row["community_kindergarden_capacity"]!=null && row["community_kindergarden_capacity"].ToString()!="")
				{
					model.community_kindergarden_capacity=int.Parse(row["community_kindergarden_capacity"].ToString());
				}
				if(row["community_manage_house_area"]!=null && row["community_manage_house_area"].ToString()!="")
				{
					model.community_manage_house_area=int.Parse(row["community_manage_house_area"].ToString());
				}
				if(row["community_medical_bed_capacity"]!=null && row["community_medical_bed_capacity"].ToString()!="")
				{
					model.community_medical_bed_capacity=int.Parse(row["community_medical_bed_capacity"].ToString());
				}
				if(row["community_stop_car_capacity"]!=null && row["community_stop_car_capacity"].ToString()!="")
				{
					model.community_stop_car_capacity=int.Parse(row["community_stop_car_capacity"].ToString());
				}
				if(row["community_convinience_store_area"]!=null && row["community_convinience_store_area"].ToString()!="")
				{
					model.community_convinience_store_area=int.Parse(row["community_convinience_store_area"].ToString());
				}
				if(row["community_food_market_area"]!=null && row["community_food_market_area"].ToString()!="")
				{
					model.community_food_market_area=int.Parse(row["community_food_market_area"].ToString());
				}
				if(row["community_recreation_and_sports_area"]!=null && row["community_recreation_and_sports_area"].ToString()!="")
				{
					model.community_recreation_and_sports_area=int.Parse(row["community_recreation_and_sports_area"].ToString());
				}
				if(row["community_pension_facilities_area"]!=null && row["community_pension_facilities_area"].ToString()!="")
				{
					model.community_pension_facilities_area=int.Parse(row["community_pension_facilities_area"].ToString());
				}
				if(row["background_value_added"]!=null && row["background_value_added"].ToString()!="")
				{
					model.background_value_added=decimal.Parse(row["background_value_added"].ToString());
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
			strSql.Append("select community_id,help_figure,develop_figure,disposable_money_per_people,facade_num,rent_facade_num,average_rent,county_average_rent,labor_num,employed_labor_num,poor_people_num,fill_time,house_rent,positon_advantage,problem_solution,community_kindergarden_capacity,community_manage_house_area,community_medical_bed_capacity,community_stop_car_capacity,community_convinience_store_area,community_food_market_area,community_recreation_and_sports_area,community_pension_facilities_area,background_value_added ");
			strSql.Append(" FROM T_important_figures ");
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
			strSql.Append(" community_id,help_figure,develop_figure,disposable_money_per_people,facade_num,rent_facade_num,average_rent,county_average_rent,labor_num,employed_labor_num,poor_people_num,fill_time,house_rent,positon_advantage,problem_solution,community_kindergarden_capacity,community_manage_house_area,community_medical_bed_capacity,community_stop_car_capacity,community_convinience_store_area,community_food_market_area,community_recreation_and_sports_area,community_pension_facilities_area,background_value_added ");
			strSql.Append(" FROM T_important_figures ");
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
			strSql.Append("select count(1) FROM T_important_figures ");
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
				strSql.Append("order by T.fill_time desc");
			}
			strSql.Append(")AS Row, T.*  from T_important_figures T ");
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
			parameters[0].Value = "T_important_figures";
			parameters[1].Value = "fill_time";
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

