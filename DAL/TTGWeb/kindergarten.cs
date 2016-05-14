using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:kindergarten
	/// </summary>
	public partial class kindergarten
	{
		public kindergarten()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string name,string community,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_kindergarten");
			strSql.Append(" where name=@name and community=@community and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = name;
			parameters[1].Value = community;
			parameters[2].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.kindergarten model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_kindergarten(");
			strSql.Append("name,community,type,floor_space,gross_floor_area,students_amount,teachers_amount,class_amount,teachers_students_rate,activity_room_area,activity_room_area_if_suff,otds_activity_room_area,otds_activity_room_area_if_suff,afforest_area,afforest_area_if_suff,school_bus_amount,pick_up_students_amount_daily,note_information,statistics_date,lock_tables,check_status,tkunset1,tkunset2,tkunset3,tkunset4,tkunset5,tkunset6,tkunset7,tkunset8,tkunset9,tkunset10,tkunset11,tkunset12,tkunset13,tkunset14,tkunset15,tkunset16,tkunset17)");
			strSql.Append(" values (");
			strSql.Append("@name,@community,@type,@floor_space,@gross_floor_area,@students_amount,@teachers_amount,@class_amount,@teachers_students_rate,@activity_room_area,@activity_room_area_if_suff,@otds_activity_room_area,@otds_activity_room_area_if_suff,@afforest_area,@afforest_area_if_suff,@school_bus_amount,@pick_up_students_amount_daily,@note_information,@statistics_date,@lock_tables,@check_status,@tkunset1,@tkunset2,@tkunset3,@tkunset4,@tkunset5,@tkunset6,@tkunset7,@tkunset8,@tkunset9,@tkunset10,@tkunset11,@tkunset12,@tkunset13,@tkunset14,@tkunset15,@tkunset16,@tkunset17)");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@type", SqlDbType.VarChar,20),
					new SqlParameter("@floor_space", SqlDbType.Float,8),
					new SqlParameter("@gross_floor_area", SqlDbType.Float,8),
					new SqlParameter("@students_amount", SqlDbType.Int,4),
					new SqlParameter("@teachers_amount", SqlDbType.Int,4),
					new SqlParameter("@class_amount", SqlDbType.Int,4),
					new SqlParameter("@teachers_students_rate", SqlDbType.Float,8),
					new SqlParameter("@activity_room_area", SqlDbType.Float,8),
					new SqlParameter("@activity_room_area_if_suff", SqlDbType.VarChar,5),
					new SqlParameter("@otds_activity_room_area", SqlDbType.Float,8),
					new SqlParameter("@otds_activity_room_area_if_suff", SqlDbType.VarChar,5),
					new SqlParameter("@afforest_area", SqlDbType.Float,8),
					new SqlParameter("@afforest_area_if_suff", SqlDbType.VarChar,5),
					new SqlParameter("@school_bus_amount", SqlDbType.Int,4),
					new SqlParameter("@pick_up_students_amount_daily", SqlDbType.Float,8),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tkunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset17", SqlDbType.VarChar,50)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.community;
			parameters[2].Value = model.type;
			parameters[3].Value = model.floor_space;
			parameters[4].Value = model.gross_floor_area;
			parameters[5].Value = model.students_amount;
			parameters[6].Value = model.teachers_amount;
			parameters[7].Value = model.class_amount;
			parameters[8].Value = model.teachers_students_rate;
			parameters[9].Value = model.activity_room_area;
			parameters[10].Value = model.activity_room_area_if_suff;
			parameters[11].Value = model.otds_activity_room_area;
			parameters[12].Value = model.otds_activity_room_area_if_suff;
			parameters[13].Value = model.afforest_area;
			parameters[14].Value = model.afforest_area_if_suff;
			parameters[15].Value = model.school_bus_amount;
			parameters[16].Value = model.pick_up_students_amount_daily;
			parameters[17].Value = model.note_information;
			parameters[18].Value = model.statistics_date;
			parameters[19].Value = model.lock_tables;
			parameters[20].Value = model.check_status;
			parameters[21].Value = model.tkunset1;
			parameters[22].Value = model.tkunset2;
			parameters[23].Value = model.tkunset3;
			parameters[24].Value = model.tkunset4;
			parameters[25].Value = model.tkunset5;
			parameters[26].Value = model.tkunset6;
			parameters[27].Value = model.tkunset7;
			parameters[28].Value = model.tkunset8;
			parameters[29].Value = model.tkunset9;
			parameters[30].Value = model.tkunset10;
			parameters[31].Value = model.tkunset11;
			parameters[32].Value = model.tkunset12;
			parameters[33].Value = model.tkunset13;
			parameters[34].Value = model.tkunset14;
			parameters[35].Value = model.tkunset15;
			parameters[36].Value = model.tkunset16;
			parameters[37].Value = model.tkunset17;

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
		public bool Update(TTG.Model.TTGWeb.kindergarten model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_kindergarten set ");
			strSql.Append("type=@type,");
			strSql.Append("floor_space=@floor_space,");
			strSql.Append("gross_floor_area=@gross_floor_area,");
			strSql.Append("students_amount=@students_amount,");
			strSql.Append("teachers_amount=@teachers_amount,");
			strSql.Append("class_amount=@class_amount,");
			strSql.Append("teachers_students_rate=@teachers_students_rate,");
			strSql.Append("activity_room_area=@activity_room_area,");
			strSql.Append("activity_room_area_if_suff=@activity_room_area_if_suff,");
			strSql.Append("otds_activity_room_area=@otds_activity_room_area,");
			strSql.Append("otds_activity_room_area_if_suff=@otds_activity_room_area_if_suff,");
			strSql.Append("afforest_area=@afforest_area,");
			strSql.Append("afforest_area_if_suff=@afforest_area_if_suff,");
			strSql.Append("school_bus_amount=@school_bus_amount,");
			strSql.Append("pick_up_students_amount_daily=@pick_up_students_amount_daily,");
			strSql.Append("note_information=@note_information,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("tkunset1=@tkunset1,");
			strSql.Append("tkunset2=@tkunset2,");
			strSql.Append("tkunset3=@tkunset3,");
			strSql.Append("tkunset4=@tkunset4,");
			strSql.Append("tkunset5=@tkunset5,");
			strSql.Append("tkunset6=@tkunset6,");
			strSql.Append("tkunset7=@tkunset7,");
			strSql.Append("tkunset8=@tkunset8,");
			strSql.Append("tkunset9=@tkunset9,");
			strSql.Append("tkunset10=@tkunset10,");
			strSql.Append("tkunset11=@tkunset11,");
			strSql.Append("tkunset12=@tkunset12,");
			strSql.Append("tkunset13=@tkunset13,");
			strSql.Append("tkunset14=@tkunset14,");
			strSql.Append("tkunset15=@tkunset15,");
			strSql.Append("tkunset16=@tkunset16,");
			strSql.Append("tkunset17=@tkunset17");
			strSql.Append(" where name=@name and community=@community and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@type", SqlDbType.VarChar,20),
					new SqlParameter("@floor_space", SqlDbType.Float,8),
					new SqlParameter("@gross_floor_area", SqlDbType.Float,8),
					new SqlParameter("@students_amount", SqlDbType.Int,4),
					new SqlParameter("@teachers_amount", SqlDbType.Int,4),
					new SqlParameter("@class_amount", SqlDbType.Int,4),
					new SqlParameter("@teachers_students_rate", SqlDbType.Float,8),
					new SqlParameter("@activity_room_area", SqlDbType.Float,8),
					new SqlParameter("@activity_room_area_if_suff", SqlDbType.VarChar,5),
					new SqlParameter("@otds_activity_room_area", SqlDbType.Float,8),
					new SqlParameter("@otds_activity_room_area_if_suff", SqlDbType.VarChar,5),
					new SqlParameter("@afforest_area", SqlDbType.Float,8),
					new SqlParameter("@afforest_area_if_suff", SqlDbType.VarChar,5),
					new SqlParameter("@school_bus_amount", SqlDbType.Int,4),
					new SqlParameter("@pick_up_students_amount_daily", SqlDbType.Float,8),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tkunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tkunset17", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.type;
			parameters[1].Value = model.floor_space;
			parameters[2].Value = model.gross_floor_area;
			parameters[3].Value = model.students_amount;
			parameters[4].Value = model.teachers_amount;
			parameters[5].Value = model.class_amount;
			parameters[6].Value = model.teachers_students_rate;
			parameters[7].Value = model.activity_room_area;
			parameters[8].Value = model.activity_room_area_if_suff;
			parameters[9].Value = model.otds_activity_room_area;
			parameters[10].Value = model.otds_activity_room_area_if_suff;
			parameters[11].Value = model.afforest_area;
			parameters[12].Value = model.afforest_area_if_suff;
			parameters[13].Value = model.school_bus_amount;
			parameters[14].Value = model.pick_up_students_amount_daily;
			parameters[15].Value = model.note_information;
			parameters[16].Value = model.lock_tables;
			parameters[17].Value = model.check_status;
			parameters[18].Value = model.tkunset1;
			parameters[19].Value = model.tkunset2;
			parameters[20].Value = model.tkunset3;
			parameters[21].Value = model.tkunset4;
			parameters[22].Value = model.tkunset5;
			parameters[23].Value = model.tkunset6;
			parameters[24].Value = model.tkunset7;
			parameters[25].Value = model.tkunset8;
			parameters[26].Value = model.tkunset9;
			parameters[27].Value = model.tkunset10;
			parameters[28].Value = model.tkunset11;
			parameters[29].Value = model.tkunset12;
			parameters[30].Value = model.tkunset13;
			parameters[31].Value = model.tkunset14;
			parameters[32].Value = model.tkunset15;
			parameters[33].Value = model.tkunset16;
			parameters[34].Value = model.tkunset17;
			parameters[35].Value = model.name;
			parameters[36].Value = model.community;
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
		public bool Delete(string name,string community,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_kindergarten ");
			strSql.Append(" where name=@name and community=@community and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = name;
			parameters[1].Value = community;
			parameters[2].Value = statistics_date;

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
		public TTG.Model.TTGWeb.kindergarten GetModel(string name,string community,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 name,community,type,floor_space,gross_floor_area,students_amount,teachers_amount,class_amount,teachers_students_rate,activity_room_area,activity_room_area_if_suff,otds_activity_room_area,otds_activity_room_area_if_suff,afforest_area,afforest_area_if_suff,school_bus_amount,pick_up_students_amount_daily,note_information,statistics_date,lock_tables,check_status,tkunset1,tkunset2,tkunset3,tkunset4,tkunset5,tkunset6,tkunset7,tkunset8,tkunset9,tkunset10,tkunset11,tkunset12,tkunset13,tkunset14,tkunset15,tkunset16,tkunset17 from T_kindergarten ");
			strSql.Append(" where name=@name and community=@community and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = name;
			parameters[1].Value = community;
			parameters[2].Value = statistics_date;

			TTG.Model.TTGWeb.kindergarten model=new TTG.Model.TTGWeb.kindergarten();
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
		public TTG.Model.TTGWeb.kindergarten DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.kindergarten model=new TTG.Model.TTGWeb.kindergarten();
			if (row != null)
			{
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["community"]!=null)
				{
					model.community=row["community"].ToString();
				}
				if(row["type"]!=null)
				{
					model.type=row["type"].ToString();
				}
				if(row["floor_space"]!=null && row["floor_space"].ToString()!="")
				{
					model.floor_space=decimal.Parse(row["floor_space"].ToString());
				}
				if(row["gross_floor_area"]!=null && row["gross_floor_area"].ToString()!="")
				{
					model.gross_floor_area=decimal.Parse(row["gross_floor_area"].ToString());
				}
				if(row["students_amount"]!=null && row["students_amount"].ToString()!="")
				{
					model.students_amount=int.Parse(row["students_amount"].ToString());
				}
				if(row["teachers_amount"]!=null && row["teachers_amount"].ToString()!="")
				{
					model.teachers_amount=int.Parse(row["teachers_amount"].ToString());
				}
				if(row["class_amount"]!=null && row["class_amount"].ToString()!="")
				{
					model.class_amount=int.Parse(row["class_amount"].ToString());
				}
				if(row["teachers_students_rate"]!=null && row["teachers_students_rate"].ToString()!="")
				{
					model.teachers_students_rate=decimal.Parse(row["teachers_students_rate"].ToString());
				}
				if(row["activity_room_area"]!=null && row["activity_room_area"].ToString()!="")
				{
					model.activity_room_area=decimal.Parse(row["activity_room_area"].ToString());
				}
				if(row["activity_room_area_if_suff"]!=null)
				{
					model.activity_room_area_if_suff=row["activity_room_area_if_suff"].ToString();
				}
				if(row["otds_activity_room_area"]!=null && row["otds_activity_room_area"].ToString()!="")
				{
					model.otds_activity_room_area=decimal.Parse(row["otds_activity_room_area"].ToString());
				}
				if(row["otds_activity_room_area_if_suff"]!=null)
				{
					model.otds_activity_room_area_if_suff=row["otds_activity_room_area_if_suff"].ToString();
				}
				if(row["afforest_area"]!=null && row["afforest_area"].ToString()!="")
				{
					model.afforest_area=decimal.Parse(row["afforest_area"].ToString());
				}
				if(row["afforest_area_if_suff"]!=null)
				{
					model.afforest_area_if_suff=row["afforest_area_if_suff"].ToString();
				}
				if(row["school_bus_amount"]!=null && row["school_bus_amount"].ToString()!="")
				{
					model.school_bus_amount=int.Parse(row["school_bus_amount"].ToString());
				}
				if(row["pick_up_students_amount_daily"]!=null && row["pick_up_students_amount_daily"].ToString()!="")
				{
					model.pick_up_students_amount_daily=decimal.Parse(row["pick_up_students_amount_daily"].ToString());
				}
				if(row["note_information"]!=null)
				{
					model.note_information=row["note_information"].ToString();
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["tkunset1"]!=null)
				{
					model.tkunset1=row["tkunset1"].ToString();
				}
				if(row["tkunset2"]!=null)
				{
					model.tkunset2=row["tkunset2"].ToString();
				}
				if(row["tkunset3"]!=null)
				{
					model.tkunset3=row["tkunset3"].ToString();
				}
				if(row["tkunset4"]!=null)
				{
					model.tkunset4=row["tkunset4"].ToString();
				}
				if(row["tkunset5"]!=null)
				{
					model.tkunset5=row["tkunset5"].ToString();
				}
				if(row["tkunset6"]!=null)
				{
					model.tkunset6=row["tkunset6"].ToString();
				}
				if(row["tkunset7"]!=null)
				{
					model.tkunset7=row["tkunset7"].ToString();
				}
				if(row["tkunset8"]!=null)
				{
					model.tkunset8=row["tkunset8"].ToString();
				}
				if(row["tkunset9"]!=null)
				{
					model.tkunset9=row["tkunset9"].ToString();
				}
				if(row["tkunset10"]!=null)
				{
					model.tkunset10=row["tkunset10"].ToString();
				}
				if(row["tkunset11"]!=null)
				{
					model.tkunset11=row["tkunset11"].ToString();
				}
				if(row["tkunset12"]!=null)
				{
					model.tkunset12=row["tkunset12"].ToString();
				}
				if(row["tkunset13"]!=null)
				{
					model.tkunset13=row["tkunset13"].ToString();
				}
				if(row["tkunset14"]!=null)
				{
					model.tkunset14=row["tkunset14"].ToString();
				}
				if(row["tkunset15"]!=null)
				{
					model.tkunset15=row["tkunset15"].ToString();
				}
				if(row["tkunset16"]!=null)
				{
					model.tkunset16=row["tkunset16"].ToString();
				}
				if(row["tkunset17"]!=null)
				{
					model.tkunset17=row["tkunset17"].ToString();
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
			strSql.Append("select name,community,type,floor_space,gross_floor_area,students_amount,teachers_amount,class_amount,teachers_students_rate,activity_room_area,activity_room_area_if_suff,otds_activity_room_area,otds_activity_room_area_if_suff,afforest_area,afforest_area_if_suff,school_bus_amount,pick_up_students_amount_daily,note_information,statistics_date,lock_tables,check_status,tkunset1,tkunset2,tkunset3,tkunset4,tkunset5,tkunset6,tkunset7,tkunset8,tkunset9,tkunset10,tkunset11,tkunset12,tkunset13,tkunset14,tkunset15,tkunset16,tkunset17 ");
			strSql.Append(" FROM T_kindergarten ");
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
			strSql.Append(" name,community,type,floor_space,gross_floor_area,students_amount,teachers_amount,class_amount,teachers_students_rate,activity_room_area,activity_room_area_if_suff,otds_activity_room_area,otds_activity_room_area_if_suff,afforest_area,afforest_area_if_suff,school_bus_amount,pick_up_students_amount_daily,note_information,statistics_date,lock_tables,check_status,tkunset1,tkunset2,tkunset3,tkunset4,tkunset5,tkunset6,tkunset7,tkunset8,tkunset9,tkunset10,tkunset11,tkunset12,tkunset13,tkunset14,tkunset15,tkunset16,tkunset17 ");
			strSql.Append(" FROM T_kindergarten ");
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
			strSql.Append("select count(1) FROM T_kindergarten ");
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
			strSql.Append(")AS Row, T.*  from T_kindergarten T ");
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
			parameters[0].Value = "T_kindergarten";
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

