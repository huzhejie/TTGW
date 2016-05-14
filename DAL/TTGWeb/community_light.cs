using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_light
	/// </summary>
	public partial class community_light
	{
		public community_light()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_light");
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
		public bool Add(TTG.Model.TTGWeb.community_light model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_light(");
			strSql.Append("community_id,community_streetlight_num,community_energy_efficient_streetlight_num,community_good_streetlight_rate,community_otd_exercise_yard_light_num,community_otd_good_exercise_yard_light_rate,community_passageway_light_num,community_good_passageway_light_rate,statistics_date,tcltunset1,tcltunset2,tcltunset3,tcltunset4,tcltunset5,tcltunset6,tcltunset7,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_streetlight_num,@community_energy_efficient_streetlight_num,@community_good_streetlight_rate,@community_otd_exercise_yard_light_num,@community_otd_good_exercise_yard_light_rate,@community_passageway_light_num,@community_good_passageway_light_rate,@statistics_date,@tcltunset1,@tcltunset2,@tcltunset3,@tcltunset4,@tcltunset5,@tcltunset6,@tcltunset7,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_streetlight_num", SqlDbType.Int,4),
					new SqlParameter("@community_energy_efficient_streetlight_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_streetlight_rate", SqlDbType.Float,8),
					new SqlParameter("@community_otd_exercise_yard_light_num", SqlDbType.Int,4),
					new SqlParameter("@community_otd_good_exercise_yard_light_rate", SqlDbType.Float,8),
					new SqlParameter("@community_passageway_light_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_passageway_light_rate", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcltunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset7", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_streetlight_num;
			parameters[2].Value = model.community_energy_efficient_streetlight_num;
			parameters[3].Value = model.community_good_streetlight_rate;
			parameters[4].Value = model.community_otd_exercise_yard_light_num;
			parameters[5].Value = model.community_otd_good_exercise_yard_light_rate;
			parameters[6].Value = model.community_passageway_light_num;
			parameters[7].Value = model.community_good_passageway_light_rate;
			parameters[8].Value = model.statistics_date;
			parameters[9].Value = model.tcltunset1;
			parameters[10].Value = model.tcltunset2;
			parameters[11].Value = model.tcltunset3;
			parameters[12].Value = model.tcltunset4;
			parameters[13].Value = model.tcltunset5;
			parameters[14].Value = model.tcltunset6;
			parameters[15].Value = model.tcltunset7;
			parameters[16].Value = model.lock_tables;
			parameters[17].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_light model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_light set ");
			strSql.Append("community_streetlight_num=@community_streetlight_num,");
			strSql.Append("community_energy_efficient_streetlight_num=@community_energy_efficient_streetlight_num,");
			strSql.Append("community_good_streetlight_rate=@community_good_streetlight_rate,");
			strSql.Append("community_otd_exercise_yard_light_num=@community_otd_exercise_yard_light_num,");
			strSql.Append("community_otd_good_exercise_yard_light_rate=@community_otd_good_exercise_yard_light_rate,");
			strSql.Append("community_passageway_light_num=@community_passageway_light_num,");
			strSql.Append("community_good_passageway_light_rate=@community_good_passageway_light_rate,");
			strSql.Append("tcltunset1=@tcltunset1,");
			strSql.Append("tcltunset2=@tcltunset2,");
			strSql.Append("tcltunset3=@tcltunset3,");
			strSql.Append("tcltunset4=@tcltunset4,");
			strSql.Append("tcltunset5=@tcltunset5,");
			strSql.Append("tcltunset6=@tcltunset6,");
			strSql.Append("tcltunset7=@tcltunset7,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_streetlight_num", SqlDbType.Int,4),
					new SqlParameter("@community_energy_efficient_streetlight_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_streetlight_rate", SqlDbType.Float,8),
					new SqlParameter("@community_otd_exercise_yard_light_num", SqlDbType.Int,4),
					new SqlParameter("@community_otd_good_exercise_yard_light_rate", SqlDbType.Float,8),
					new SqlParameter("@community_passageway_light_num", SqlDbType.Int,4),
					new SqlParameter("@community_good_passageway_light_rate", SqlDbType.Float,8),
					new SqlParameter("@tcltunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcltunset7", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_streetlight_num;
			parameters[1].Value = model.community_energy_efficient_streetlight_num;
			parameters[2].Value = model.community_good_streetlight_rate;
			parameters[3].Value = model.community_otd_exercise_yard_light_num;
			parameters[4].Value = model.community_otd_good_exercise_yard_light_rate;
			parameters[5].Value = model.community_passageway_light_num;
			parameters[6].Value = model.community_good_passageway_light_rate;
			parameters[7].Value = model.tcltunset1;
			parameters[8].Value = model.tcltunset2;
			parameters[9].Value = model.tcltunset3;
			parameters[10].Value = model.tcltunset4;
			parameters[11].Value = model.tcltunset5;
			parameters[12].Value = model.tcltunset6;
			parameters[13].Value = model.tcltunset7;
			parameters[14].Value = model.lock_tables;
			parameters[15].Value = model.check_status;
			parameters[16].Value = model.community_id;
			parameters[17].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_light ");
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
		public TTG.Model.TTGWeb.community_light GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_streetlight_num,community_energy_efficient_streetlight_num,community_good_streetlight_rate,community_otd_exercise_yard_light_num,community_otd_good_exercise_yard_light_rate,community_passageway_light_num,community_good_passageway_light_rate,statistics_date,tcltunset1,tcltunset2,tcltunset3,tcltunset4,tcltunset5,tcltunset6,tcltunset7,lock_tables,check_status from T_community_light ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_light model=new TTG.Model.TTGWeb.community_light();
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
		public TTG.Model.TTGWeb.community_light DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_light model=new TTG.Model.TTGWeb.community_light();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_streetlight_num"]!=null && row["community_streetlight_num"].ToString()!="")
				{
					model.community_streetlight_num=int.Parse(row["community_streetlight_num"].ToString());
				}
				if(row["community_energy_efficient_streetlight_num"]!=null && row["community_energy_efficient_streetlight_num"].ToString()!="")
				{
					model.community_energy_efficient_streetlight_num=int.Parse(row["community_energy_efficient_streetlight_num"].ToString());
				}
				if(row["community_good_streetlight_rate"]!=null && row["community_good_streetlight_rate"].ToString()!="")
				{
					model.community_good_streetlight_rate=decimal.Parse(row["community_good_streetlight_rate"].ToString());
				}
				if(row["community_otd_exercise_yard_light_num"]!=null && row["community_otd_exercise_yard_light_num"].ToString()!="")
				{
					model.community_otd_exercise_yard_light_num=int.Parse(row["community_otd_exercise_yard_light_num"].ToString());
				}
				if(row["community_otd_good_exercise_yard_light_rate"]!=null && row["community_otd_good_exercise_yard_light_rate"].ToString()!="")
				{
					model.community_otd_good_exercise_yard_light_rate=decimal.Parse(row["community_otd_good_exercise_yard_light_rate"].ToString());
				}
				if(row["community_passageway_light_num"]!=null && row["community_passageway_light_num"].ToString()!="")
				{
					model.community_passageway_light_num=int.Parse(row["community_passageway_light_num"].ToString());
				}
				if(row["community_good_passageway_light_rate"]!=null && row["community_good_passageway_light_rate"].ToString()!="")
				{
					model.community_good_passageway_light_rate=decimal.Parse(row["community_good_passageway_light_rate"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcltunset1"]!=null)
				{
					model.tcltunset1=row["tcltunset1"].ToString();
				}
				if(row["tcltunset2"]!=null)
				{
					model.tcltunset2=row["tcltunset2"].ToString();
				}
				if(row["tcltunset3"]!=null)
				{
					model.tcltunset3=row["tcltunset3"].ToString();
				}
				if(row["tcltunset4"]!=null)
				{
					model.tcltunset4=row["tcltunset4"].ToString();
				}
				if(row["tcltunset5"]!=null)
				{
					model.tcltunset5=row["tcltunset5"].ToString();
				}
				if(row["tcltunset6"]!=null)
				{
					model.tcltunset6=row["tcltunset6"].ToString();
				}
				if(row["tcltunset7"]!=null)
				{
					model.tcltunset7=row["tcltunset7"].ToString();
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
			strSql.Append("select community_id,community_streetlight_num,community_energy_efficient_streetlight_num,community_good_streetlight_rate,community_otd_exercise_yard_light_num,community_otd_good_exercise_yard_light_rate,community_passageway_light_num,community_good_passageway_light_rate,statistics_date,tcltunset1,tcltunset2,tcltunset3,tcltunset4,tcltunset5,tcltunset6,tcltunset7,lock_tables,check_status ");
			strSql.Append(" FROM T_community_light ");
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
			strSql.Append(" community_id,community_streetlight_num,community_energy_efficient_streetlight_num,community_good_streetlight_rate,community_otd_exercise_yard_light_num,community_otd_good_exercise_yard_light_rate,community_passageway_light_num,community_good_passageway_light_rate,statistics_date,tcltunset1,tcltunset2,tcltunset3,tcltunset4,tcltunset5,tcltunset6,tcltunset7,lock_tables,check_status ");
			strSql.Append(" FROM T_community_light ");
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
			strSql.Append("select count(1) FROM T_community_light ");
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
			strSql.Append(")AS Row, T.*  from T_community_light T ");
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
			parameters[0].Value = "T_community_light";
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

