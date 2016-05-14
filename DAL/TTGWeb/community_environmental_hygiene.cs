using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_environmental_hygiene
	/// </summary>
	public partial class community_environmental_hygiene
	{
		public community_environmental_hygiene()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_environmental_hygiene");
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
		public bool Add(TTG.Model.TTGWeb.community_environmental_hygiene model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_environmental_hygiene(");
			strSql.Append("community_id,community_refuse_transfer_station_num,community_refuse_transfer_station_dis_ots,community_refuse_collection_point_num,community_dustbin_num,rubbish_produce_amount,live_rubbish_produce_year_amount,solid_rubbish_produce_amount,rubbish_collection_plan_num,community_public_toilet_num,community_public_toilet_space_num,community_public_toilet_inside_300m_num,statistics_date,community_public_toilet_cover_road_length,tcehunset1,tcehunset2,tcehunset3,tcehunset4,tcehunset5,tcehunset6,tcehunset7,tcehunset8,tcehunset9,tcehunset10,tcehunset11,lock_tables,check_status,community_public_toilet_area_num,community_public_toilet_plan_num)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_refuse_transfer_station_num,@community_refuse_transfer_station_dis_ots,@community_refuse_collection_point_num,@community_dustbin_num,@rubbish_produce_amount,@live_rubbish_produce_year_amount,@solid_rubbish_produce_amount,@rubbish_collection_plan_num,@community_public_toilet_num,@community_public_toilet_space_num,@community_public_toilet_inside_300m_num,@statistics_date,@community_public_toilet_cover_road_length,@tcehunset1,@tcehunset2,@tcehunset3,@tcehunset4,@tcehunset5,@tcehunset6,@tcehunset7,@tcehunset8,@tcehunset9,@tcehunset10,@tcehunset11,@lock_tables,@check_status,@community_public_toilet_area_num,@community_public_toilet_plan_num)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_refuse_transfer_station_num", SqlDbType.Int,4),
					new SqlParameter("@community_refuse_transfer_station_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_refuse_collection_point_num", SqlDbType.Int,4),
					new SqlParameter("@community_dustbin_num", SqlDbType.Int,4),
					new SqlParameter("@rubbish_produce_amount", SqlDbType.Float,8),
					new SqlParameter("@live_rubbish_produce_year_amount", SqlDbType.Float,8),
					new SqlParameter("@solid_rubbish_produce_amount", SqlDbType.Float,8),
					new SqlParameter("@rubbish_collection_plan_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_space_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_inside_300m_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@community_public_toilet_cover_road_length", SqlDbType.Float,8),
					new SqlParameter("@tcehunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset11", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_area_num", SqlDbType.Float,8),
					new SqlParameter("@community_public_toilet_plan_num", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_refuse_transfer_station_num;
			parameters[2].Value = model.community_refuse_transfer_station_dis_ots;
			parameters[3].Value = model.community_refuse_collection_point_num;
			parameters[4].Value = model.community_dustbin_num;
			parameters[5].Value = model.rubbish_produce_amount;
			parameters[6].Value = model.live_rubbish_produce_year_amount;
			parameters[7].Value = model.solid_rubbish_produce_amount;
			parameters[8].Value = model.rubbish_collection_plan_num;
			parameters[9].Value = model.community_public_toilet_num;
			parameters[10].Value = model.community_public_toilet_space_num;
			parameters[11].Value = model.community_public_toilet_inside_300m_num;
			parameters[12].Value = model.statistics_date;
			parameters[13].Value = model.community_public_toilet_cover_road_length;
			parameters[14].Value = model.tcehunset1;
			parameters[15].Value = model.tcehunset2;
			parameters[16].Value = model.tcehunset3;
			parameters[17].Value = model.tcehunset4;
			parameters[18].Value = model.tcehunset5;
			parameters[19].Value = model.tcehunset6;
			parameters[20].Value = model.tcehunset7;
			parameters[21].Value = model.tcehunset8;
			parameters[22].Value = model.tcehunset9;
			parameters[23].Value = model.tcehunset10;
			parameters[24].Value = model.tcehunset11;
			parameters[25].Value = model.lock_tables;
			parameters[26].Value = model.check_status;
			parameters[27].Value = model.community_public_toilet_area_num;
			parameters[28].Value = model.community_public_toilet_plan_num;

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
		public bool Update(TTG.Model.TTGWeb.community_environmental_hygiene model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_environmental_hygiene set ");
			strSql.Append("community_refuse_transfer_station_num=@community_refuse_transfer_station_num,");
			strSql.Append("community_refuse_transfer_station_dis_ots=@community_refuse_transfer_station_dis_ots,");
			strSql.Append("community_refuse_collection_point_num=@community_refuse_collection_point_num,");
			strSql.Append("community_dustbin_num=@community_dustbin_num,");
			strSql.Append("rubbish_produce_amount=@rubbish_produce_amount,");
			strSql.Append("live_rubbish_produce_year_amount=@live_rubbish_produce_year_amount,");
			strSql.Append("solid_rubbish_produce_amount=@solid_rubbish_produce_amount,");
			strSql.Append("rubbish_collection_plan_num=@rubbish_collection_plan_num,");
			strSql.Append("community_public_toilet_num=@community_public_toilet_num,");
			strSql.Append("community_public_toilet_space_num=@community_public_toilet_space_num,");
			strSql.Append("community_public_toilet_inside_300m_num=@community_public_toilet_inside_300m_num,");
			strSql.Append("community_public_toilet_cover_road_length=@community_public_toilet_cover_road_length,");
			strSql.Append("tcehunset1=@tcehunset1,");
			strSql.Append("tcehunset2=@tcehunset2,");
			strSql.Append("tcehunset3=@tcehunset3,");
			strSql.Append("tcehunset4=@tcehunset4,");
			strSql.Append("tcehunset5=@tcehunset5,");
			strSql.Append("tcehunset6=@tcehunset6,");
			strSql.Append("tcehunset7=@tcehunset7,");
			strSql.Append("tcehunset8=@tcehunset8,");
			strSql.Append("tcehunset9=@tcehunset9,");
			strSql.Append("tcehunset10=@tcehunset10,");
			strSql.Append("tcehunset11=@tcehunset11,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("community_public_toilet_area_num=@community_public_toilet_area_num,");
			strSql.Append("community_public_toilet_plan_num=@community_public_toilet_plan_num");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_refuse_transfer_station_num", SqlDbType.Int,4),
					new SqlParameter("@community_refuse_transfer_station_dis_ots", SqlDbType.Float,8),
					new SqlParameter("@community_refuse_collection_point_num", SqlDbType.Int,4),
					new SqlParameter("@community_dustbin_num", SqlDbType.Int,4),
					new SqlParameter("@rubbish_produce_amount", SqlDbType.Float,8),
					new SqlParameter("@live_rubbish_produce_year_amount", SqlDbType.Float,8),
					new SqlParameter("@solid_rubbish_produce_amount", SqlDbType.Float,8),
					new SqlParameter("@rubbish_collection_plan_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_space_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_inside_300m_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_cover_road_length", SqlDbType.Float,8),
					new SqlParameter("@tcehunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcehunset11", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_public_toilet_area_num", SqlDbType.Float,8),
					new SqlParameter("@community_public_toilet_plan_num", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_refuse_transfer_station_num;
			parameters[1].Value = model.community_refuse_transfer_station_dis_ots;
			parameters[2].Value = model.community_refuse_collection_point_num;
			parameters[3].Value = model.community_dustbin_num;
			parameters[4].Value = model.rubbish_produce_amount;
			parameters[5].Value = model.live_rubbish_produce_year_amount;
			parameters[6].Value = model.solid_rubbish_produce_amount;
			parameters[7].Value = model.rubbish_collection_plan_num;
			parameters[8].Value = model.community_public_toilet_num;
			parameters[9].Value = model.community_public_toilet_space_num;
			parameters[10].Value = model.community_public_toilet_inside_300m_num;
			parameters[11].Value = model.community_public_toilet_cover_road_length;
			parameters[12].Value = model.tcehunset1;
			parameters[13].Value = model.tcehunset2;
			parameters[14].Value = model.tcehunset3;
			parameters[15].Value = model.tcehunset4;
			parameters[16].Value = model.tcehunset5;
			parameters[17].Value = model.tcehunset6;
			parameters[18].Value = model.tcehunset7;
			parameters[19].Value = model.tcehunset8;
			parameters[20].Value = model.tcehunset9;
			parameters[21].Value = model.tcehunset10;
			parameters[22].Value = model.tcehunset11;
			parameters[23].Value = model.lock_tables;
			parameters[24].Value = model.check_status;
			parameters[25].Value = model.community_public_toilet_area_num;
			parameters[26].Value = model.community_public_toilet_plan_num;
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
			strSql.Append("delete from T_community_environmental_hygiene ");
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
		public TTG.Model.TTGWeb.community_environmental_hygiene GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_refuse_transfer_station_num,community_refuse_transfer_station_dis_ots,community_refuse_collection_point_num,community_dustbin_num,rubbish_produce_amount,live_rubbish_produce_year_amount,solid_rubbish_produce_amount,rubbish_collection_plan_num,community_public_toilet_num,community_public_toilet_space_num,community_public_toilet_inside_300m_num,statistics_date,community_public_toilet_cover_road_length,tcehunset1,tcehunset2,tcehunset3,tcehunset4,tcehunset5,tcehunset6,tcehunset7,tcehunset8,tcehunset9,tcehunset10,tcehunset11,lock_tables,check_status,community_public_toilet_area_num,community_public_toilet_plan_num from T_community_environmental_hygiene ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_environmental_hygiene model=new TTG.Model.TTGWeb.community_environmental_hygiene();
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
		public TTG.Model.TTGWeb.community_environmental_hygiene DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_environmental_hygiene model=new TTG.Model.TTGWeb.community_environmental_hygiene();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_refuse_transfer_station_num"]!=null && row["community_refuse_transfer_station_num"].ToString()!="")
				{
					model.community_refuse_transfer_station_num=int.Parse(row["community_refuse_transfer_station_num"].ToString());
				}
				if(row["community_refuse_transfer_station_dis_ots"]!=null && row["community_refuse_transfer_station_dis_ots"].ToString()!="")
				{
					model.community_refuse_transfer_station_dis_ots=decimal.Parse(row["community_refuse_transfer_station_dis_ots"].ToString());
				}
				if(row["community_refuse_collection_point_num"]!=null && row["community_refuse_collection_point_num"].ToString()!="")
				{
					model.community_refuse_collection_point_num=int.Parse(row["community_refuse_collection_point_num"].ToString());
				}
				if(row["community_dustbin_num"]!=null && row["community_dustbin_num"].ToString()!="")
				{
					model.community_dustbin_num=int.Parse(row["community_dustbin_num"].ToString());
				}
				if(row["rubbish_produce_amount"]!=null && row["rubbish_produce_amount"].ToString()!="")
				{
					model.rubbish_produce_amount=decimal.Parse(row["rubbish_produce_amount"].ToString());
				}
				if(row["live_rubbish_produce_year_amount"]!=null && row["live_rubbish_produce_year_amount"].ToString()!="")
				{
					model.live_rubbish_produce_year_amount=decimal.Parse(row["live_rubbish_produce_year_amount"].ToString());
				}
				if(row["solid_rubbish_produce_amount"]!=null && row["solid_rubbish_produce_amount"].ToString()!="")
				{
					model.solid_rubbish_produce_amount=decimal.Parse(row["solid_rubbish_produce_amount"].ToString());
				}
				if(row["rubbish_collection_plan_num"]!=null && row["rubbish_collection_plan_num"].ToString()!="")
				{
					model.rubbish_collection_plan_num=int.Parse(row["rubbish_collection_plan_num"].ToString());
				}
				if(row["community_public_toilet_num"]!=null && row["community_public_toilet_num"].ToString()!="")
				{
					model.community_public_toilet_num=int.Parse(row["community_public_toilet_num"].ToString());
				}
				if(row["community_public_toilet_space_num"]!=null && row["community_public_toilet_space_num"].ToString()!="")
				{
					model.community_public_toilet_space_num=int.Parse(row["community_public_toilet_space_num"].ToString());
				}
				if(row["community_public_toilet_inside_300m_num"]!=null && row["community_public_toilet_inside_300m_num"].ToString()!="")
				{
					model.community_public_toilet_inside_300m_num=int.Parse(row["community_public_toilet_inside_300m_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["community_public_toilet_cover_road_length"]!=null && row["community_public_toilet_cover_road_length"].ToString()!="")
				{
					model.community_public_toilet_cover_road_length=decimal.Parse(row["community_public_toilet_cover_road_length"].ToString());
				}
				if(row["tcehunset1"]!=null)
				{
					model.tcehunset1=row["tcehunset1"].ToString();
				}
				if(row["tcehunset2"]!=null)
				{
					model.tcehunset2=row["tcehunset2"].ToString();
				}
				if(row["tcehunset3"]!=null)
				{
					model.tcehunset3=row["tcehunset3"].ToString();
				}
				if(row["tcehunset4"]!=null)
				{
					model.tcehunset4=row["tcehunset4"].ToString();
				}
				if(row["tcehunset5"]!=null)
				{
					model.tcehunset5=row["tcehunset5"].ToString();
				}
				if(row["tcehunset6"]!=null)
				{
					model.tcehunset6=row["tcehunset6"].ToString();
				}
				if(row["tcehunset7"]!=null)
				{
					model.tcehunset7=row["tcehunset7"].ToString();
				}
				if(row["tcehunset8"]!=null)
				{
					model.tcehunset8=row["tcehunset8"].ToString();
				}
				if(row["tcehunset9"]!=null)
				{
					model.tcehunset9=row["tcehunset9"].ToString();
				}
				if(row["tcehunset10"]!=null)
				{
					model.tcehunset10=row["tcehunset10"].ToString();
				}
				if(row["tcehunset11"]!=null)
				{
					model.tcehunset11=row["tcehunset11"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["community_public_toilet_area_num"]!=null && row["community_public_toilet_area_num"].ToString()!="")
				{
					model.community_public_toilet_area_num=decimal.Parse(row["community_public_toilet_area_num"].ToString());
				}
				if(row["community_public_toilet_plan_num"]!=null && row["community_public_toilet_plan_num"].ToString()!="")
				{
					model.community_public_toilet_plan_num=int.Parse(row["community_public_toilet_plan_num"].ToString());
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
			strSql.Append("select community_id,community_refuse_transfer_station_num,community_refuse_transfer_station_dis_ots,community_refuse_collection_point_num,community_dustbin_num,rubbish_produce_amount,live_rubbish_produce_year_amount,solid_rubbish_produce_amount,rubbish_collection_plan_num,community_public_toilet_num,community_public_toilet_space_num,community_public_toilet_inside_300m_num,statistics_date,community_public_toilet_cover_road_length,tcehunset1,tcehunset2,tcehunset3,tcehunset4,tcehunset5,tcehunset6,tcehunset7,tcehunset8,tcehunset9,tcehunset10,tcehunset11,lock_tables,check_status,community_public_toilet_area_num,community_public_toilet_plan_num ");
			strSql.Append(" FROM T_community_environmental_hygiene ");
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
			strSql.Append(" community_id,community_refuse_transfer_station_num,community_refuse_transfer_station_dis_ots,community_refuse_collection_point_num,community_dustbin_num,rubbish_produce_amount,live_rubbish_produce_year_amount,solid_rubbish_produce_amount,rubbish_collection_plan_num,community_public_toilet_num,community_public_toilet_space_num,community_public_toilet_inside_300m_num,statistics_date,community_public_toilet_cover_road_length,tcehunset1,tcehunset2,tcehunset3,tcehunset4,tcehunset5,tcehunset6,tcehunset7,tcehunset8,tcehunset9,tcehunset10,tcehunset11,lock_tables,check_status,community_public_toilet_area_num,community_public_toilet_plan_num ");
			strSql.Append(" FROM T_community_environmental_hygiene ");
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
			strSql.Append("select count(1) FROM T_community_environmental_hygiene ");
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
			strSql.Append(")AS Row, T.*  from T_community_environmental_hygiene T ");
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
			parameters[0].Value = "T_community_environmental_hygiene";
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

