using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_immigrant
	/// </summary>
	public partial class community_immigrant
	{
		public community_immigrant()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_immigrant");
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
		public bool Add(TTG.Model.TTGWeb.community_immigrant model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_immigrant(");
			strSql.Append("community_id,immigrant_total_family_num,immigrant_total_population,community_pure_resident_pop,community_depart_pop,community_enp_staves,community_enp_laidoff_staves,community_have_land_pop,community_rural_to_town_pop,statistics_date,tcimunset1,tcimunset2,tcimunset3,tcimunset4,tcimunset5,tcimunset6,tcimunset7,check_status,lock_tables)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@immigrant_total_family_num,@immigrant_total_population,@community_pure_resident_pop,@community_depart_pop,@community_enp_staves,@community_enp_laidoff_staves,@community_have_land_pop,@community_rural_to_town_pop,@statistics_date,@tcimunset1,@tcimunset2,@tcimunset3,@tcimunset4,@tcimunset5,@tcimunset6,@tcimunset7,@check_status,@lock_tables)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@immigrant_total_family_num", SqlDbType.Int,4),
					new SqlParameter("@immigrant_total_population", SqlDbType.Int,4),
					new SqlParameter("@community_pure_resident_pop", SqlDbType.Int,4),
					new SqlParameter("@community_depart_pop", SqlDbType.Int,4),
					new SqlParameter("@community_enp_staves", SqlDbType.Int,4),
					new SqlParameter("@community_enp_laidoff_staves", SqlDbType.Int,4),
					new SqlParameter("@community_have_land_pop", SqlDbType.Int,4),
					new SqlParameter("@community_rural_to_town_pop", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcimunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset7", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.immigrant_total_family_num;
			parameters[2].Value = model.immigrant_total_population;
			parameters[3].Value = model.community_pure_resident_pop;
			parameters[4].Value = model.community_depart_pop;
			parameters[5].Value = model.community_enp_staves;
			parameters[6].Value = model.community_enp_laidoff_staves;
			parameters[7].Value = model.community_have_land_pop;
			parameters[8].Value = model.community_rural_to_town_pop;
			parameters[9].Value = model.statistics_date;
			parameters[10].Value = model.tcimunset1;
			parameters[11].Value = model.tcimunset2;
			parameters[12].Value = model.tcimunset3;
			parameters[13].Value = model.tcimunset4;
			parameters[14].Value = model.tcimunset5;
			parameters[15].Value = model.tcimunset6;
			parameters[16].Value = model.tcimunset7;
			parameters[17].Value = model.check_status;
			parameters[18].Value = model.lock_tables;

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
		public bool Update(TTG.Model.TTGWeb.community_immigrant model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_immigrant set ");
			strSql.Append("immigrant_total_family_num=@immigrant_total_family_num,");
			strSql.Append("immigrant_total_population=@immigrant_total_population,");
			strSql.Append("community_pure_resident_pop=@community_pure_resident_pop,");
			strSql.Append("community_depart_pop=@community_depart_pop,");
			strSql.Append("community_enp_staves=@community_enp_staves,");
			strSql.Append("community_enp_laidoff_staves=@community_enp_laidoff_staves,");
			strSql.Append("community_have_land_pop=@community_have_land_pop,");
			strSql.Append("community_rural_to_town_pop=@community_rural_to_town_pop,");
			strSql.Append("tcimunset1=@tcimunset1,");
			strSql.Append("tcimunset2=@tcimunset2,");
			strSql.Append("tcimunset3=@tcimunset3,");
			strSql.Append("tcimunset4=@tcimunset4,");
			strSql.Append("tcimunset5=@tcimunset5,");
			strSql.Append("tcimunset6=@tcimunset6,");
			strSql.Append("tcimunset7=@tcimunset7,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@immigrant_total_family_num", SqlDbType.Int,4),
					new SqlParameter("@immigrant_total_population", SqlDbType.Int,4),
					new SqlParameter("@community_pure_resident_pop", SqlDbType.Int,4),
					new SqlParameter("@community_depart_pop", SqlDbType.Int,4),
					new SqlParameter("@community_enp_staves", SqlDbType.Int,4),
					new SqlParameter("@community_enp_laidoff_staves", SqlDbType.Int,4),
					new SqlParameter("@community_have_land_pop", SqlDbType.Int,4),
					new SqlParameter("@community_rural_to_town_pop", SqlDbType.Int,4),
					new SqlParameter("@tcimunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcimunset7", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.immigrant_total_family_num;
			parameters[1].Value = model.immigrant_total_population;
			parameters[2].Value = model.community_pure_resident_pop;
			parameters[3].Value = model.community_depart_pop;
			parameters[4].Value = model.community_enp_staves;
			parameters[5].Value = model.community_enp_laidoff_staves;
			parameters[6].Value = model.community_have_land_pop;
			parameters[7].Value = model.community_rural_to_town_pop;
			parameters[8].Value = model.tcimunset1;
			parameters[9].Value = model.tcimunset2;
			parameters[10].Value = model.tcimunset3;
			parameters[11].Value = model.tcimunset4;
			parameters[12].Value = model.tcimunset5;
			parameters[13].Value = model.tcimunset6;
			parameters[14].Value = model.tcimunset7;
			parameters[15].Value = model.check_status;
			parameters[16].Value = model.lock_tables;
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
			strSql.Append("delete from T_community_immigrant ");
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
		public TTG.Model.TTGWeb.community_immigrant GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,immigrant_total_family_num,immigrant_total_population,community_pure_resident_pop,community_depart_pop,community_enp_staves,community_enp_laidoff_staves,community_have_land_pop,community_rural_to_town_pop,statistics_date,tcimunset1,tcimunset2,tcimunset3,tcimunset4,tcimunset5,tcimunset6,tcimunset7,check_status,lock_tables from T_community_immigrant ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_immigrant model=new TTG.Model.TTGWeb.community_immigrant();
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
		public TTG.Model.TTGWeb.community_immigrant DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_immigrant model=new TTG.Model.TTGWeb.community_immigrant();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["immigrant_total_family_num"]!=null && row["immigrant_total_family_num"].ToString()!="")
				{
					model.immigrant_total_family_num=int.Parse(row["immigrant_total_family_num"].ToString());
				}
				if(row["immigrant_total_population"]!=null && row["immigrant_total_population"].ToString()!="")
				{
					model.immigrant_total_population=int.Parse(row["immigrant_total_population"].ToString());
				}
				if(row["community_pure_resident_pop"]!=null && row["community_pure_resident_pop"].ToString()!="")
				{
					model.community_pure_resident_pop=int.Parse(row["community_pure_resident_pop"].ToString());
				}
				if(row["community_depart_pop"]!=null && row["community_depart_pop"].ToString()!="")
				{
					model.community_depart_pop=int.Parse(row["community_depart_pop"].ToString());
				}
				if(row["community_enp_staves"]!=null && row["community_enp_staves"].ToString()!="")
				{
					model.community_enp_staves=int.Parse(row["community_enp_staves"].ToString());
				}
				if(row["community_enp_laidoff_staves"]!=null && row["community_enp_laidoff_staves"].ToString()!="")
				{
					model.community_enp_laidoff_staves=int.Parse(row["community_enp_laidoff_staves"].ToString());
				}
				if(row["community_have_land_pop"]!=null && row["community_have_land_pop"].ToString()!="")
				{
					model.community_have_land_pop=int.Parse(row["community_have_land_pop"].ToString());
				}
				if(row["community_rural_to_town_pop"]!=null && row["community_rural_to_town_pop"].ToString()!="")
				{
					model.community_rural_to_town_pop=int.Parse(row["community_rural_to_town_pop"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcimunset1"]!=null)
				{
					model.tcimunset1=row["tcimunset1"].ToString();
				}
				if(row["tcimunset2"]!=null)
				{
					model.tcimunset2=row["tcimunset2"].ToString();
				}
				if(row["tcimunset3"]!=null)
				{
					model.tcimunset3=row["tcimunset3"].ToString();
				}
				if(row["tcimunset4"]!=null)
				{
					model.tcimunset4=row["tcimunset4"].ToString();
				}
				if(row["tcimunset5"]!=null)
				{
					model.tcimunset5=row["tcimunset5"].ToString();
				}
				if(row["tcimunset6"]!=null)
				{
					model.tcimunset6=row["tcimunset6"].ToString();
				}
				if(row["tcimunset7"]!=null)
				{
					model.tcimunset7=row["tcimunset7"].ToString();
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
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
			strSql.Append("select community_id,immigrant_total_family_num,immigrant_total_population,community_pure_resident_pop,community_depart_pop,community_enp_staves,community_enp_laidoff_staves,community_have_land_pop,community_rural_to_town_pop,statistics_date,tcimunset1,tcimunset2,tcimunset3,tcimunset4,tcimunset5,tcimunset6,tcimunset7,check_status,lock_tables ");
			strSql.Append(" FROM T_community_immigrant ");
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
			strSql.Append(" community_id,immigrant_total_family_num,immigrant_total_population,community_pure_resident_pop,community_depart_pop,community_enp_staves,community_enp_laidoff_staves,community_have_land_pop,community_rural_to_town_pop,statistics_date,tcimunset1,tcimunset2,tcimunset3,tcimunset4,tcimunset5,tcimunset6,tcimunset7,check_status,lock_tables ");
			strSql.Append(" FROM T_community_immigrant ");
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
			strSql.Append("select count(1) FROM T_community_immigrant ");
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
			strSql.Append(")AS Row, T.*  from T_community_immigrant T ");
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
			parameters[0].Value = "T_community_immigrant";
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
        /// 得到一个对象实体
        /// </summary>
        /// <param name="community_id"></param>
        /// <returns></returns>
        public TTG.Model.TTGWeb.community_immigrant getModel(string community_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 community_id,immigrant_total_family_num,immigrant_total_population,community_pure_resident_pop,community_depart_pop,community_enp_staves,community_enp_laidoff_staves,community_have_land_pop,community_rural_to_town_pop,statistics_date,tcimunset1,tcimunset2,tcimunset3,tcimunset4,tcimunset5,tcimunset6,tcimunset7,check_status,lock_tables from T_community_immigrant ");
            strSql.Append(" where community_id=@community_id order by statistics_date desc");
            SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)		};
            parameters[0].Value = community_id;

            TTG.Model.TTGWeb.community_immigrant model = new TTG.Model.TTGWeb.community_immigrant();
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
		#endregion  ExtensionMethod
	}
}

