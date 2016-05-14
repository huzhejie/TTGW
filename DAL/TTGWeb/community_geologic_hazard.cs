using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_geologic_hazard
	/// </summary>
	public partial class community_geologic_hazard
	{
		public community_geologic_hazard()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_geologic_hazard");
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
		public bool Add(TTG.Model.TTGWeb.community_geologic_hazard model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_geologic_hazard(");
			strSql.Append("community_id,serious_geologic_hazard_num,serious_geologic_hazard_handle_num,influence_house_area,protect_house_area,statistics_date,tcghunset1,tcghunset2,tcghunset3,tcghunset4,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@serious_geologic_hazard_num,@serious_geologic_hazard_handle_num,@influence_house_area,@protect_house_area,@statistics_date,@tcghunset1,@tcghunset2,@tcghunset3,@tcghunset4,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@serious_geologic_hazard_num", SqlDbType.Int,4),
					new SqlParameter("@serious_geologic_hazard_handle_num", SqlDbType.Int,4),
					new SqlParameter("@influence_house_area", SqlDbType.Float,8),
					new SqlParameter("@protect_house_area", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcghunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcghunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcghunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcghunset4", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.serious_geologic_hazard_num;
			parameters[2].Value = model.serious_geologic_hazard_handle_num;
			parameters[3].Value = model.influence_house_area;
			parameters[4].Value = model.protect_house_area;
			parameters[5].Value = model.statistics_date;
			parameters[6].Value = model.tcghunset1;
			parameters[7].Value = model.tcghunset2;
			parameters[8].Value = model.tcghunset3;
			parameters[9].Value = model.tcghunset4;
			parameters[10].Value = model.lock_tables;
			parameters[11].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_geologic_hazard model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_geologic_hazard set ");
			strSql.Append("serious_geologic_hazard_num=@serious_geologic_hazard_num,");
			strSql.Append("serious_geologic_hazard_handle_num=@serious_geologic_hazard_handle_num,");
			strSql.Append("influence_house_area=@influence_house_area,");
			strSql.Append("protect_house_area=@protect_house_area,");
			strSql.Append("tcghunset1=@tcghunset1,");
			strSql.Append("tcghunset2=@tcghunset2,");
			strSql.Append("tcghunset3=@tcghunset3,");
			strSql.Append("tcghunset4=@tcghunset4,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@serious_geologic_hazard_num", SqlDbType.Int,4),
					new SqlParameter("@serious_geologic_hazard_handle_num", SqlDbType.Int,4),
					new SqlParameter("@influence_house_area", SqlDbType.Float,8),
					new SqlParameter("@protect_house_area", SqlDbType.Float,8),
					new SqlParameter("@tcghunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcghunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcghunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcghunset4", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.serious_geologic_hazard_num;
			parameters[1].Value = model.serious_geologic_hazard_handle_num;
			parameters[2].Value = model.influence_house_area;
			parameters[3].Value = model.protect_house_area;
			parameters[4].Value = model.tcghunset1;
			parameters[5].Value = model.tcghunset2;
			parameters[6].Value = model.tcghunset3;
			parameters[7].Value = model.tcghunset4;
			parameters[8].Value = model.lock_tables;
			parameters[9].Value = model.check_status;
			parameters[10].Value = model.community_id;
			parameters[11].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_geologic_hazard ");
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
		public TTG.Model.TTGWeb.community_geologic_hazard GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,serious_geologic_hazard_num,serious_geologic_hazard_handle_num,influence_house_area,protect_house_area,statistics_date,tcghunset1,tcghunset2,tcghunset3,tcghunset4,lock_tables,check_status from T_community_geologic_hazard ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_geologic_hazard model=new TTG.Model.TTGWeb.community_geologic_hazard();
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
		public TTG.Model.TTGWeb.community_geologic_hazard DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_geologic_hazard model=new TTG.Model.TTGWeb.community_geologic_hazard();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["serious_geologic_hazard_num"]!=null && row["serious_geologic_hazard_num"].ToString()!="")
				{
					model.serious_geologic_hazard_num=int.Parse(row["serious_geologic_hazard_num"].ToString());
				}
				if(row["serious_geologic_hazard_handle_num"]!=null && row["serious_geologic_hazard_handle_num"].ToString()!="")
				{
					model.serious_geologic_hazard_handle_num=int.Parse(row["serious_geologic_hazard_handle_num"].ToString());
				}
				if(row["influence_house_area"]!=null && row["influence_house_area"].ToString()!="")
				{
					model.influence_house_area=decimal.Parse(row["influence_house_area"].ToString());
				}
				if(row["protect_house_area"]!=null && row["protect_house_area"].ToString()!="")
				{
					model.protect_house_area=decimal.Parse(row["protect_house_area"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcghunset1"]!=null)
				{
					model.tcghunset1=row["tcghunset1"].ToString();
				}
				if(row["tcghunset2"]!=null)
				{
					model.tcghunset2=row["tcghunset2"].ToString();
				}
				if(row["tcghunset3"]!=null)
				{
					model.tcghunset3=row["tcghunset3"].ToString();
				}
				if(row["tcghunset4"]!=null)
				{
					model.tcghunset4=row["tcghunset4"].ToString();
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
			strSql.Append("select community_id,serious_geologic_hazard_num,serious_geologic_hazard_handle_num,influence_house_area,protect_house_area,statistics_date,tcghunset1,tcghunset2,tcghunset3,tcghunset4,lock_tables,check_status ");
			strSql.Append(" FROM T_community_geologic_hazard ");
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
			strSql.Append(" community_id,serious_geologic_hazard_num,serious_geologic_hazard_handle_num,influence_house_area,protect_house_area,statistics_date,tcghunset1,tcghunset2,tcghunset3,tcghunset4,lock_tables,check_status ");
			strSql.Append(" FROM T_community_geologic_hazard ");
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
			strSql.Append("select count(1) FROM T_community_geologic_hazard ");
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
			strSql.Append(")AS Row, T.*  from T_community_geologic_hazard T ");
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
			parameters[0].Value = "T_community_geologic_hazard";
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

