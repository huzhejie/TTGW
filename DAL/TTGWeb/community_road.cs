using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_road
	/// </summary>
	public partial class community_road
	{
		public community_road()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_road");
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
		public bool Add(TTG.Model.TTGWeb.community_road model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_road(");
			strSql.Append("community_id,community_road_length,community_road_area,community_road_width_bet_14_and_24_length,community_road_width_bet_14_and_24_area,community_road_width_bet_10_and_14_length,community_road_width_bet_10_and_14_area,community_road_width_bet_6_and_9_length,community_road_width_bet_6_and_9_area,community_road_width_bet_3_and_5_length,community_road_width_bet_3_and_5_area,community_road_pavement_area,community_road_pavement_colorful_brick_area,community_road_bet_dwellings_length,community_road_bet_dwellings_area,community_pavement_length,community_pavement_area,statistics_date,community_road_num,tcrunset1,tcrunset2,tcrunset3,tcrunset4,tcrunset5,tcrunset6,tcrunset7,tcrunset8,tcrunset9,tcrunset10,tcrunset11,tcrunset12,tcrunset13,tcrunset14,tcrunset15,tcrunset16,tcrunset17,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_road_length,@community_road_area,@community_road_width_bet_14_and_24_length,@community_road_width_bet_14_and_24_area,@community_road_width_bet_10_and_14_length,@community_road_width_bet_10_and_14_area,@community_road_width_bet_6_and_9_length,@community_road_width_bet_6_and_9_area,@community_road_width_bet_3_and_5_length,@community_road_width_bet_3_and_5_area,@community_road_pavement_area,@community_road_pavement_colorful_brick_area,@community_road_bet_dwellings_length,@community_road_bet_dwellings_area,@community_pavement_length,@community_pavement_area,@statistics_date,@community_road_num,@tcrunset1,@tcrunset2,@tcrunset3,@tcrunset4,@tcrunset5,@tcrunset6,@tcrunset7,@tcrunset8,@tcrunset9,@tcrunset10,@tcrunset11,@tcrunset12,@tcrunset13,@tcrunset14,@tcrunset15,@tcrunset16,@tcrunset17,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_road_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_14_and_24_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_14_and_24_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_10_and_14_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_10_and_14_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_6_and_9_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_6_and_9_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_3_and_5_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_3_and_5_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_pavement_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_pavement_colorful_brick_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_bet_dwellings_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_bet_dwellings_area", SqlDbType.Float,8),
					new SqlParameter("@community_pavement_length", SqlDbType.Float,8),
					new SqlParameter("@community_pavement_area", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@community_road_num", SqlDbType.Int,4),
					new SqlParameter("@tcrunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset17", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_road_length;
			parameters[2].Value = model.community_road_area;
			parameters[3].Value = model.community_road_width_bet_14_and_24_length;
			parameters[4].Value = model.community_road_width_bet_14_and_24_area;
			parameters[5].Value = model.community_road_width_bet_10_and_14_length;
			parameters[6].Value = model.community_road_width_bet_10_and_14_area;
			parameters[7].Value = model.community_road_width_bet_6_and_9_length;
			parameters[8].Value = model.community_road_width_bet_6_and_9_area;
			parameters[9].Value = model.community_road_width_bet_3_and_5_length;
			parameters[10].Value = model.community_road_width_bet_3_and_5_area;
			parameters[11].Value = model.community_road_pavement_area;
			parameters[12].Value = model.community_road_pavement_colorful_brick_area;
			parameters[13].Value = model.community_road_bet_dwellings_length;
			parameters[14].Value = model.community_road_bet_dwellings_area;
			parameters[15].Value = model.community_pavement_length;
			parameters[16].Value = model.community_pavement_area;
			parameters[17].Value = model.statistics_date;
			parameters[18].Value = model.community_road_num;
			parameters[19].Value = model.tcrunset1;
			parameters[20].Value = model.tcrunset2;
			parameters[21].Value = model.tcrunset3;
			parameters[22].Value = model.tcrunset4;
			parameters[23].Value = model.tcrunset5;
			parameters[24].Value = model.tcrunset6;
			parameters[25].Value = model.tcrunset7;
			parameters[26].Value = model.tcrunset8;
			parameters[27].Value = model.tcrunset9;
			parameters[28].Value = model.tcrunset10;
			parameters[29].Value = model.tcrunset11;
			parameters[30].Value = model.tcrunset12;
			parameters[31].Value = model.tcrunset13;
			parameters[32].Value = model.tcrunset14;
			parameters[33].Value = model.tcrunset15;
			parameters[34].Value = model.tcrunset16;
			parameters[35].Value = model.tcrunset17;
			parameters[36].Value = model.lock_tables;
			parameters[37].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_road model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_road set ");
			strSql.Append("community_road_length=@community_road_length,");
			strSql.Append("community_road_area=@community_road_area,");
			strSql.Append("community_road_width_bet_14_and_24_length=@community_road_width_bet_14_and_24_length,");
			strSql.Append("community_road_width_bet_14_and_24_area=@community_road_width_bet_14_and_24_area,");
			strSql.Append("community_road_width_bet_10_and_14_length=@community_road_width_bet_10_and_14_length,");
			strSql.Append("community_road_width_bet_10_and_14_area=@community_road_width_bet_10_and_14_area,");
			strSql.Append("community_road_width_bet_6_and_9_length=@community_road_width_bet_6_and_9_length,");
			strSql.Append("community_road_width_bet_6_and_9_area=@community_road_width_bet_6_and_9_area,");
			strSql.Append("community_road_width_bet_3_and_5_length=@community_road_width_bet_3_and_5_length,");
			strSql.Append("community_road_width_bet_3_and_5_area=@community_road_width_bet_3_and_5_area,");
			strSql.Append("community_road_pavement_area=@community_road_pavement_area,");
			strSql.Append("community_road_pavement_colorful_brick_area=@community_road_pavement_colorful_brick_area,");
			strSql.Append("community_road_bet_dwellings_length=@community_road_bet_dwellings_length,");
			strSql.Append("community_road_bet_dwellings_area=@community_road_bet_dwellings_area,");
			strSql.Append("community_pavement_length=@community_pavement_length,");
			strSql.Append("community_pavement_area=@community_pavement_area,");
			strSql.Append("community_road_num=@community_road_num,");
			strSql.Append("tcrunset1=@tcrunset1,");
			strSql.Append("tcrunset2=@tcrunset2,");
			strSql.Append("tcrunset3=@tcrunset3,");
			strSql.Append("tcrunset4=@tcrunset4,");
			strSql.Append("tcrunset5=@tcrunset5,");
			strSql.Append("tcrunset6=@tcrunset6,");
			strSql.Append("tcrunset7=@tcrunset7,");
			strSql.Append("tcrunset8=@tcrunset8,");
			strSql.Append("tcrunset9=@tcrunset9,");
			strSql.Append("tcrunset10=@tcrunset10,");
			strSql.Append("tcrunset11=@tcrunset11,");
			strSql.Append("tcrunset12=@tcrunset12,");
			strSql.Append("tcrunset13=@tcrunset13,");
			strSql.Append("tcrunset14=@tcrunset14,");
			strSql.Append("tcrunset15=@tcrunset15,");
			strSql.Append("tcrunset16=@tcrunset16,");
			strSql.Append("tcrunset17=@tcrunset17,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_road_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_14_and_24_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_14_and_24_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_10_and_14_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_10_and_14_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_6_and_9_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_6_and_9_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_3_and_5_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_width_bet_3_and_5_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_pavement_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_pavement_colorful_brick_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_bet_dwellings_length", SqlDbType.Float,8),
					new SqlParameter("@community_road_bet_dwellings_area", SqlDbType.Float,8),
					new SqlParameter("@community_pavement_length", SqlDbType.Float,8),
					new SqlParameter("@community_pavement_area", SqlDbType.Float,8),
					new SqlParameter("@community_road_num", SqlDbType.Int,4),
					new SqlParameter("@tcrunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tcrunset17", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_road_length;
			parameters[1].Value = model.community_road_area;
			parameters[2].Value = model.community_road_width_bet_14_and_24_length;
			parameters[3].Value = model.community_road_width_bet_14_and_24_area;
			parameters[4].Value = model.community_road_width_bet_10_and_14_length;
			parameters[5].Value = model.community_road_width_bet_10_and_14_area;
			parameters[6].Value = model.community_road_width_bet_6_and_9_length;
			parameters[7].Value = model.community_road_width_bet_6_and_9_area;
			parameters[8].Value = model.community_road_width_bet_3_and_5_length;
			parameters[9].Value = model.community_road_width_bet_3_and_5_area;
			parameters[10].Value = model.community_road_pavement_area;
			parameters[11].Value = model.community_road_pavement_colorful_brick_area;
			parameters[12].Value = model.community_road_bet_dwellings_length;
			parameters[13].Value = model.community_road_bet_dwellings_area;
			parameters[14].Value = model.community_pavement_length;
			parameters[15].Value = model.community_pavement_area;
			parameters[16].Value = model.community_road_num;
			parameters[17].Value = model.tcrunset1;
			parameters[18].Value = model.tcrunset2;
			parameters[19].Value = model.tcrunset3;
			parameters[20].Value = model.tcrunset4;
			parameters[21].Value = model.tcrunset5;
			parameters[22].Value = model.tcrunset6;
			parameters[23].Value = model.tcrunset7;
			parameters[24].Value = model.tcrunset8;
			parameters[25].Value = model.tcrunset9;
			parameters[26].Value = model.tcrunset10;
			parameters[27].Value = model.tcrunset11;
			parameters[28].Value = model.tcrunset12;
			parameters[29].Value = model.tcrunset13;
			parameters[30].Value = model.tcrunset14;
			parameters[31].Value = model.tcrunset15;
			parameters[32].Value = model.tcrunset16;
			parameters[33].Value = model.tcrunset17;
			parameters[34].Value = model.lock_tables;
			parameters[35].Value = model.check_status;
			parameters[36].Value = model.community_id;
			parameters[37].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_road ");
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
		public TTG.Model.TTGWeb.community_road GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_road_length,community_road_area,community_road_width_bet_14_and_24_length,community_road_width_bet_14_and_24_area,community_road_width_bet_10_and_14_length,community_road_width_bet_10_and_14_area,community_road_width_bet_6_and_9_length,community_road_width_bet_6_and_9_area,community_road_width_bet_3_and_5_length,community_road_width_bet_3_and_5_area,community_road_pavement_area,community_road_pavement_colorful_brick_area,community_road_bet_dwellings_length,community_road_bet_dwellings_area,community_pavement_length,community_pavement_area,statistics_date,community_road_num,tcrunset1,tcrunset2,tcrunset3,tcrunset4,tcrunset5,tcrunset6,tcrunset7,tcrunset8,tcrunset9,tcrunset10,tcrunset11,tcrunset12,tcrunset13,tcrunset14,tcrunset15,tcrunset16,tcrunset17,lock_tables,check_status from T_community_road ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_road model=new TTG.Model.TTGWeb.community_road();
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
		public TTG.Model.TTGWeb.community_road DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_road model=new TTG.Model.TTGWeb.community_road();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_road_length"]!=null && row["community_road_length"].ToString()!="")
				{
					model.community_road_length=decimal.Parse(row["community_road_length"].ToString());
				}
				if(row["community_road_area"]!=null && row["community_road_area"].ToString()!="")
				{
					model.community_road_area=decimal.Parse(row["community_road_area"].ToString());
				}
				if(row["community_road_width_bet_14_and_24_length"]!=null && row["community_road_width_bet_14_and_24_length"].ToString()!="")
				{
					model.community_road_width_bet_14_and_24_length=decimal.Parse(row["community_road_width_bet_14_and_24_length"].ToString());
				}
				if(row["community_road_width_bet_14_and_24_area"]!=null && row["community_road_width_bet_14_and_24_area"].ToString()!="")
				{
					model.community_road_width_bet_14_and_24_area=decimal.Parse(row["community_road_width_bet_14_and_24_area"].ToString());
				}
				if(row["community_road_width_bet_10_and_14_length"]!=null && row["community_road_width_bet_10_and_14_length"].ToString()!="")
				{
					model.community_road_width_bet_10_and_14_length=decimal.Parse(row["community_road_width_bet_10_and_14_length"].ToString());
				}
				if(row["community_road_width_bet_10_and_14_area"]!=null && row["community_road_width_bet_10_and_14_area"].ToString()!="")
				{
					model.community_road_width_bet_10_and_14_area=decimal.Parse(row["community_road_width_bet_10_and_14_area"].ToString());
				}
				if(row["community_road_width_bet_6_and_9_length"]!=null && row["community_road_width_bet_6_and_9_length"].ToString()!="")
				{
					model.community_road_width_bet_6_and_9_length=decimal.Parse(row["community_road_width_bet_6_and_9_length"].ToString());
				}
				if(row["community_road_width_bet_6_and_9_area"]!=null && row["community_road_width_bet_6_and_9_area"].ToString()!="")
				{
					model.community_road_width_bet_6_and_9_area=decimal.Parse(row["community_road_width_bet_6_and_9_area"].ToString());
				}
				if(row["community_road_width_bet_3_and_5_length"]!=null && row["community_road_width_bet_3_and_5_length"].ToString()!="")
				{
					model.community_road_width_bet_3_and_5_length=decimal.Parse(row["community_road_width_bet_3_and_5_length"].ToString());
				}
				if(row["community_road_width_bet_3_and_5_area"]!=null && row["community_road_width_bet_3_and_5_area"].ToString()!="")
				{
					model.community_road_width_bet_3_and_5_area=decimal.Parse(row["community_road_width_bet_3_and_5_area"].ToString());
				}
				if(row["community_road_pavement_area"]!=null && row["community_road_pavement_area"].ToString()!="")
				{
					model.community_road_pavement_area=decimal.Parse(row["community_road_pavement_area"].ToString());
				}
				if(row["community_road_pavement_colorful_brick_area"]!=null && row["community_road_pavement_colorful_brick_area"].ToString()!="")
				{
					model.community_road_pavement_colorful_brick_area=decimal.Parse(row["community_road_pavement_colorful_brick_area"].ToString());
				}
				if(row["community_road_bet_dwellings_length"]!=null && row["community_road_bet_dwellings_length"].ToString()!="")
				{
					model.community_road_bet_dwellings_length=decimal.Parse(row["community_road_bet_dwellings_length"].ToString());
				}
				if(row["community_road_bet_dwellings_area"]!=null && row["community_road_bet_dwellings_area"].ToString()!="")
				{
					model.community_road_bet_dwellings_area=decimal.Parse(row["community_road_bet_dwellings_area"].ToString());
				}
				if(row["community_pavement_length"]!=null && row["community_pavement_length"].ToString()!="")
				{
					model.community_pavement_length=decimal.Parse(row["community_pavement_length"].ToString());
				}
				if(row["community_pavement_area"]!=null && row["community_pavement_area"].ToString()!="")
				{
					model.community_pavement_area=decimal.Parse(row["community_pavement_area"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["community_road_num"]!=null && row["community_road_num"].ToString()!="")
				{
					model.community_road_num=int.Parse(row["community_road_num"].ToString());
				}
				if(row["tcrunset1"]!=null)
				{
					model.tcrunset1=row["tcrunset1"].ToString();
				}
				if(row["tcrunset2"]!=null)
				{
					model.tcrunset2=row["tcrunset2"].ToString();
				}
				if(row["tcrunset3"]!=null)
				{
					model.tcrunset3=row["tcrunset3"].ToString();
				}
				if(row["tcrunset4"]!=null)
				{
					model.tcrunset4=row["tcrunset4"].ToString();
				}
				if(row["tcrunset5"]!=null)
				{
					model.tcrunset5=row["tcrunset5"].ToString();
				}
				if(row["tcrunset6"]!=null)
				{
					model.tcrunset6=row["tcrunset6"].ToString();
				}
				if(row["tcrunset7"]!=null)
				{
					model.tcrunset7=row["tcrunset7"].ToString();
				}
				if(row["tcrunset8"]!=null)
				{
					model.tcrunset8=row["tcrunset8"].ToString();
				}
				if(row["tcrunset9"]!=null)
				{
					model.tcrunset9=row["tcrunset9"].ToString();
				}
				if(row["tcrunset10"]!=null)
				{
					model.tcrunset10=row["tcrunset10"].ToString();
				}
				if(row["tcrunset11"]!=null)
				{
					model.tcrunset11=row["tcrunset11"].ToString();
				}
				if(row["tcrunset12"]!=null)
				{
					model.tcrunset12=row["tcrunset12"].ToString();
				}
				if(row["tcrunset13"]!=null)
				{
					model.tcrunset13=row["tcrunset13"].ToString();
				}
				if(row["tcrunset14"]!=null)
				{
					model.tcrunset14=row["tcrunset14"].ToString();
				}
				if(row["tcrunset15"]!=null)
				{
					model.tcrunset15=row["tcrunset15"].ToString();
				}
				if(row["tcrunset16"]!=null)
				{
					model.tcrunset16=row["tcrunset16"].ToString();
				}
				if(row["tcrunset17"]!=null)
				{
					model.tcrunset17=row["tcrunset17"].ToString();
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
			strSql.Append("select community_id,community_road_length,community_road_area,community_road_width_bet_14_and_24_length,community_road_width_bet_14_and_24_area,community_road_width_bet_10_and_14_length,community_road_width_bet_10_and_14_area,community_road_width_bet_6_and_9_length,community_road_width_bet_6_and_9_area,community_road_width_bet_3_and_5_length,community_road_width_bet_3_and_5_area,community_road_pavement_area,community_road_pavement_colorful_brick_area,community_road_bet_dwellings_length,community_road_bet_dwellings_area,community_pavement_length,community_pavement_area,statistics_date,community_road_num,tcrunset1,tcrunset2,tcrunset3,tcrunset4,tcrunset5,tcrunset6,tcrunset7,tcrunset8,tcrunset9,tcrunset10,tcrunset11,tcrunset12,tcrunset13,tcrunset14,tcrunset15,tcrunset16,tcrunset17,lock_tables,check_status ");
			strSql.Append(" FROM T_community_road ");
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
			strSql.Append(" community_id,community_road_length,community_road_area,community_road_width_bet_14_and_24_length,community_road_width_bet_14_and_24_area,community_road_width_bet_10_and_14_length,community_road_width_bet_10_and_14_area,community_road_width_bet_6_and_9_length,community_road_width_bet_6_and_9_area,community_road_width_bet_3_and_5_length,community_road_width_bet_3_and_5_area,community_road_pavement_area,community_road_pavement_colorful_brick_area,community_road_bet_dwellings_length,community_road_bet_dwellings_area,community_pavement_length,community_pavement_area,statistics_date,community_road_num,tcrunset1,tcrunset2,tcrunset3,tcrunset4,tcrunset5,tcrunset6,tcrunset7,tcrunset8,tcrunset9,tcrunset10,tcrunset11,tcrunset12,tcrunset13,tcrunset14,tcrunset15,tcrunset16,tcrunset17,lock_tables,check_status ");
			strSql.Append(" FROM T_community_road ");
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
			strSql.Append("select count(1) FROM T_community_road ");
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
			strSql.Append(")AS Row, T.*  from T_community_road T ");
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
			parameters[0].Value = "T_community_road";
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

