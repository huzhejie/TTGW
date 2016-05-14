using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:road
	/// </summary>
	public partial class road
	{
		public road()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_road");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = id;
			parameters[1].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.road model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_road(");
			strSql.Append("id,name,community,road_class,width,pavement_width,community_road_length,structure,is_dead_end_road,damage_road_length,large_slope_road_length,no_hard_road_length,lack_width_road_length,is_somewhere_no_link,no_afforest_road_length,less_afforest_road_length,street_light_amount,good_street_light_amount,road_hydrant_amount,good_road_hydrant_amount,road_dustbin_amount,good_road_dustbin_amount,road_parking_space_num,parking_space_use_rate,note_information,statistics_date,check_status,lock_tables,trunset1,trunset2,trunset3,trunset4,trunset5,trunset6,trunset7,trunset8,trunset9,trunset10,trunset11,trunset12,trunset13,trunset14,trunset15,trunset16,trunset17,trunset18,trunset19,trunset20,trunset21,trunset22,trunset23,trunset24)");
			strSql.Append(" values (");
			strSql.Append("@id,@name,@community,@road_class,@width,@pavement_width,@community_road_length,@structure,@is_dead_end_road,@damage_road_length,@large_slope_road_length,@no_hard_road_length,@lack_width_road_length,@is_somewhere_no_link,@no_afforest_road_length,@less_afforest_road_length,@street_light_amount,@good_street_light_amount,@road_hydrant_amount,@good_road_hydrant_amount,@road_dustbin_amount,@good_road_dustbin_amount,@road_parking_space_num,@parking_space_use_rate,@note_information,@statistics_date,@check_status,@lock_tables,@trunset1,@trunset2,@trunset3,@trunset4,@trunset5,@trunset6,@trunset7,@trunset8,@trunset9,@trunset10,@trunset11,@trunset12,@trunset13,@trunset14,@trunset15,@trunset16,@trunset17,@trunset18,@trunset19,@trunset20,@trunset21,@trunset22,@trunset23,@trunset24)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@road_class", SqlDbType.VarChar,10),
					new SqlParameter("@width", SqlDbType.Float,8),
					new SqlParameter("@pavement_width", SqlDbType.Float,8),
					new SqlParameter("@community_road_length", SqlDbType.Float,8),
					new SqlParameter("@structure", SqlDbType.VarChar,20),
					new SqlParameter("@is_dead_end_road", SqlDbType.VarChar,5),
					new SqlParameter("@damage_road_length", SqlDbType.Float,8),
					new SqlParameter("@large_slope_road_length", SqlDbType.Float,8),
					new SqlParameter("@no_hard_road_length", SqlDbType.Float,8),
					new SqlParameter("@lack_width_road_length", SqlDbType.Float,8),
					new SqlParameter("@is_somewhere_no_link", SqlDbType.VarChar,5),
					new SqlParameter("@no_afforest_road_length", SqlDbType.Float,8),
					new SqlParameter("@less_afforest_road_length", SqlDbType.Float,8),
					new SqlParameter("@street_light_amount", SqlDbType.Int,4),
					new SqlParameter("@good_street_light_amount", SqlDbType.Int,4),
					new SqlParameter("@road_hydrant_amount", SqlDbType.Int,4),
					new SqlParameter("@good_road_hydrant_amount", SqlDbType.Int,4),
					new SqlParameter("@road_dustbin_amount", SqlDbType.Int,4),
					new SqlParameter("@good_road_dustbin_amount", SqlDbType.Int,4),
					new SqlParameter("@road_parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@parking_space_use_rate", SqlDbType.Int,4),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@trunset1", SqlDbType.VarChar,50),
					new SqlParameter("@trunset2", SqlDbType.VarChar,50),
					new SqlParameter("@trunset3", SqlDbType.VarChar,50),
					new SqlParameter("@trunset4", SqlDbType.VarChar,50),
					new SqlParameter("@trunset5", SqlDbType.VarChar,50),
					new SqlParameter("@trunset6", SqlDbType.VarChar,50),
					new SqlParameter("@trunset7", SqlDbType.VarChar,50),
					new SqlParameter("@trunset8", SqlDbType.VarChar,50),
					new SqlParameter("@trunset9", SqlDbType.VarChar,50),
					new SqlParameter("@trunset10", SqlDbType.VarChar,50),
					new SqlParameter("@trunset11", SqlDbType.VarChar,50),
					new SqlParameter("@trunset12", SqlDbType.VarChar,50),
					new SqlParameter("@trunset13", SqlDbType.VarChar,50),
					new SqlParameter("@trunset14", SqlDbType.VarChar,50),
					new SqlParameter("@trunset15", SqlDbType.VarChar,50),
					new SqlParameter("@trunset16", SqlDbType.VarChar,50),
					new SqlParameter("@trunset17", SqlDbType.VarChar,50),
					new SqlParameter("@trunset18", SqlDbType.VarChar,50),
					new SqlParameter("@trunset19", SqlDbType.VarChar,50),
					new SqlParameter("@trunset20", SqlDbType.VarChar,50),
					new SqlParameter("@trunset21", SqlDbType.VarChar,50),
					new SqlParameter("@trunset22", SqlDbType.VarChar,50),
					new SqlParameter("@trunset23", SqlDbType.VarChar,50),
					new SqlParameter("@trunset24", SqlDbType.VarChar,50)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.name;
			parameters[2].Value = model.community;
			parameters[3].Value = model.road_class;
			parameters[4].Value = model.width;
			parameters[5].Value = model.pavement_width;
			parameters[6].Value = model.community_road_length;
			parameters[7].Value = model.structure;
			parameters[8].Value = model.is_dead_end_road;
			parameters[9].Value = model.damage_road_length;
			parameters[10].Value = model.large_slope_road_length;
			parameters[11].Value = model.no_hard_road_length;
			parameters[12].Value = model.lack_width_road_length;
			parameters[13].Value = model.is_somewhere_no_link;
			parameters[14].Value = model.no_afforest_road_length;
			parameters[15].Value = model.less_afforest_road_length;
			parameters[16].Value = model.street_light_amount;
			parameters[17].Value = model.good_street_light_amount;
			parameters[18].Value = model.road_hydrant_amount;
			parameters[19].Value = model.good_road_hydrant_amount;
			parameters[20].Value = model.road_dustbin_amount;
			parameters[21].Value = model.good_road_dustbin_amount;
			parameters[22].Value = model.road_parking_space_num;
			parameters[23].Value = model.parking_space_use_rate;
			parameters[24].Value = model.note_information;
			parameters[25].Value = model.statistics_date;
			parameters[26].Value = model.check_status;
			parameters[27].Value = model.lock_tables;
			parameters[28].Value = model.trunset1;
			parameters[29].Value = model.trunset2;
			parameters[30].Value = model.trunset3;
			parameters[31].Value = model.trunset4;
			parameters[32].Value = model.trunset5;
			parameters[33].Value = model.trunset6;
			parameters[34].Value = model.trunset7;
			parameters[35].Value = model.trunset8;
			parameters[36].Value = model.trunset9;
			parameters[37].Value = model.trunset10;
			parameters[38].Value = model.trunset11;
			parameters[39].Value = model.trunset12;
			parameters[40].Value = model.trunset13;
			parameters[41].Value = model.trunset14;
			parameters[42].Value = model.trunset15;
			parameters[43].Value = model.trunset16;
			parameters[44].Value = model.trunset17;
			parameters[45].Value = model.trunset18;
			parameters[46].Value = model.trunset19;
			parameters[47].Value = model.trunset20;
			parameters[48].Value = model.trunset21;
			parameters[49].Value = model.trunset22;
			parameters[50].Value = model.trunset23;
			parameters[51].Value = model.trunset24;

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
		public bool Update(TTG.Model.TTGWeb.road model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_road set ");
			strSql.Append("name=@name,");
			strSql.Append("community=@community,");
			strSql.Append("road_class=@road_class,");
			strSql.Append("width=@width,");
			strSql.Append("pavement_width=@pavement_width,");
			strSql.Append("community_road_length=@community_road_length,");
			strSql.Append("structure=@structure,");
			strSql.Append("is_dead_end_road=@is_dead_end_road,");
			strSql.Append("damage_road_length=@damage_road_length,");
			strSql.Append("large_slope_road_length=@large_slope_road_length,");
			strSql.Append("no_hard_road_length=@no_hard_road_length,");
			strSql.Append("lack_width_road_length=@lack_width_road_length,");
			strSql.Append("is_somewhere_no_link=@is_somewhere_no_link,");
			strSql.Append("no_afforest_road_length=@no_afforest_road_length,");
			strSql.Append("less_afforest_road_length=@less_afforest_road_length,");
			strSql.Append("street_light_amount=@street_light_amount,");
			strSql.Append("good_street_light_amount=@good_street_light_amount,");
			strSql.Append("road_hydrant_amount=@road_hydrant_amount,");
			strSql.Append("good_road_hydrant_amount=@good_road_hydrant_amount,");
			strSql.Append("road_dustbin_amount=@road_dustbin_amount,");
			strSql.Append("good_road_dustbin_amount=@good_road_dustbin_amount,");
			strSql.Append("road_parking_space_num=@road_parking_space_num,");
			strSql.Append("parking_space_use_rate=@parking_space_use_rate,");
			strSql.Append("note_information=@note_information,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("trunset1=@trunset1,");
			strSql.Append("trunset2=@trunset2,");
			strSql.Append("trunset3=@trunset3,");
			strSql.Append("trunset4=@trunset4,");
			strSql.Append("trunset5=@trunset5,");
			strSql.Append("trunset6=@trunset6,");
			strSql.Append("trunset7=@trunset7,");
			strSql.Append("trunset8=@trunset8,");
			strSql.Append("trunset9=@trunset9,");
			strSql.Append("trunset10=@trunset10,");
			strSql.Append("trunset11=@trunset11,");
			strSql.Append("trunset12=@trunset12,");
			strSql.Append("trunset13=@trunset13,");
			strSql.Append("trunset14=@trunset14,");
			strSql.Append("trunset15=@trunset15,");
			strSql.Append("trunset16=@trunset16,");
			strSql.Append("trunset17=@trunset17,");
			strSql.Append("trunset18=@trunset18,");
			strSql.Append("trunset19=@trunset19,");
			strSql.Append("trunset20=@trunset20,");
			strSql.Append("trunset21=@trunset21,");
			strSql.Append("trunset22=@trunset22,");
			strSql.Append("trunset23=@trunset23,");
			strSql.Append("trunset24=@trunset24");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@road_class", SqlDbType.VarChar,10),
					new SqlParameter("@width", SqlDbType.Float,8),
					new SqlParameter("@pavement_width", SqlDbType.Float,8),
					new SqlParameter("@community_road_length", SqlDbType.Float,8),
					new SqlParameter("@structure", SqlDbType.VarChar,20),
					new SqlParameter("@is_dead_end_road", SqlDbType.VarChar,5),
					new SqlParameter("@damage_road_length", SqlDbType.Float,8),
					new SqlParameter("@large_slope_road_length", SqlDbType.Float,8),
					new SqlParameter("@no_hard_road_length", SqlDbType.Float,8),
					new SqlParameter("@lack_width_road_length", SqlDbType.Float,8),
					new SqlParameter("@is_somewhere_no_link", SqlDbType.VarChar,5),
					new SqlParameter("@no_afforest_road_length", SqlDbType.Float,8),
					new SqlParameter("@less_afforest_road_length", SqlDbType.Float,8),
					new SqlParameter("@street_light_amount", SqlDbType.Int,4),
					new SqlParameter("@good_street_light_amount", SqlDbType.Int,4),
					new SqlParameter("@road_hydrant_amount", SqlDbType.Int,4),
					new SqlParameter("@good_road_hydrant_amount", SqlDbType.Int,4),
					new SqlParameter("@road_dustbin_amount", SqlDbType.Int,4),
					new SqlParameter("@good_road_dustbin_amount", SqlDbType.Int,4),
					new SqlParameter("@road_parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@parking_space_use_rate", SqlDbType.Int,4),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@trunset1", SqlDbType.VarChar,50),
					new SqlParameter("@trunset2", SqlDbType.VarChar,50),
					new SqlParameter("@trunset3", SqlDbType.VarChar,50),
					new SqlParameter("@trunset4", SqlDbType.VarChar,50),
					new SqlParameter("@trunset5", SqlDbType.VarChar,50),
					new SqlParameter("@trunset6", SqlDbType.VarChar,50),
					new SqlParameter("@trunset7", SqlDbType.VarChar,50),
					new SqlParameter("@trunset8", SqlDbType.VarChar,50),
					new SqlParameter("@trunset9", SqlDbType.VarChar,50),
					new SqlParameter("@trunset10", SqlDbType.VarChar,50),
					new SqlParameter("@trunset11", SqlDbType.VarChar,50),
					new SqlParameter("@trunset12", SqlDbType.VarChar,50),
					new SqlParameter("@trunset13", SqlDbType.VarChar,50),
					new SqlParameter("@trunset14", SqlDbType.VarChar,50),
					new SqlParameter("@trunset15", SqlDbType.VarChar,50),
					new SqlParameter("@trunset16", SqlDbType.VarChar,50),
					new SqlParameter("@trunset17", SqlDbType.VarChar,50),
					new SqlParameter("@trunset18", SqlDbType.VarChar,50),
					new SqlParameter("@trunset19", SqlDbType.VarChar,50),
					new SqlParameter("@trunset20", SqlDbType.VarChar,50),
					new SqlParameter("@trunset21", SqlDbType.VarChar,50),
					new SqlParameter("@trunset22", SqlDbType.VarChar,50),
					new SqlParameter("@trunset23", SqlDbType.VarChar,50),
					new SqlParameter("@trunset24", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.community;
			parameters[2].Value = model.road_class;
			parameters[3].Value = model.width;
			parameters[4].Value = model.pavement_width;
			parameters[5].Value = model.community_road_length;
			parameters[6].Value = model.structure;
			parameters[7].Value = model.is_dead_end_road;
			parameters[8].Value = model.damage_road_length;
			parameters[9].Value = model.large_slope_road_length;
			parameters[10].Value = model.no_hard_road_length;
			parameters[11].Value = model.lack_width_road_length;
			parameters[12].Value = model.is_somewhere_no_link;
			parameters[13].Value = model.no_afforest_road_length;
			parameters[14].Value = model.less_afforest_road_length;
			parameters[15].Value = model.street_light_amount;
			parameters[16].Value = model.good_street_light_amount;
			parameters[17].Value = model.road_hydrant_amount;
			parameters[18].Value = model.good_road_hydrant_amount;
			parameters[19].Value = model.road_dustbin_amount;
			parameters[20].Value = model.good_road_dustbin_amount;
			parameters[21].Value = model.road_parking_space_num;
			parameters[22].Value = model.parking_space_use_rate;
			parameters[23].Value = model.note_information;
			parameters[24].Value = model.check_status;
			parameters[25].Value = model.lock_tables;
			parameters[26].Value = model.trunset1;
			parameters[27].Value = model.trunset2;
			parameters[28].Value = model.trunset3;
			parameters[29].Value = model.trunset4;
			parameters[30].Value = model.trunset5;
			parameters[31].Value = model.trunset6;
			parameters[32].Value = model.trunset7;
			parameters[33].Value = model.trunset8;
			parameters[34].Value = model.trunset9;
			parameters[35].Value = model.trunset10;
			parameters[36].Value = model.trunset11;
			parameters[37].Value = model.trunset12;
			parameters[38].Value = model.trunset13;
			parameters[39].Value = model.trunset14;
			parameters[40].Value = model.trunset15;
			parameters[41].Value = model.trunset16;
			parameters[42].Value = model.trunset17;
			parameters[43].Value = model.trunset18;
			parameters[44].Value = model.trunset19;
			parameters[45].Value = model.trunset20;
			parameters[46].Value = model.trunset21;
			parameters[47].Value = model.trunset22;
			parameters[48].Value = model.trunset23;
			parameters[49].Value = model.trunset24;
			parameters[50].Value = model.id;
			parameters[51].Value = model.statistics_date;

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
		public bool Delete(string id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_road ");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = id;
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
		public TTG.Model.TTGWeb.road GetModel(string id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,community,road_class,width,pavement_width,community_road_length,structure,is_dead_end_road,damage_road_length,large_slope_road_length,no_hard_road_length,lack_width_road_length,is_somewhere_no_link,no_afforest_road_length,less_afforest_road_length,street_light_amount,good_street_light_amount,road_hydrant_amount,good_road_hydrant_amount,road_dustbin_amount,good_road_dustbin_amount,road_parking_space_num,parking_space_use_rate,note_information,statistics_date,check_status,lock_tables,trunset1,trunset2,trunset3,trunset4,trunset5,trunset6,trunset7,trunset8,trunset9,trunset10,trunset11,trunset12,trunset13,trunset14,trunset15,trunset16,trunset17,trunset18,trunset19,trunset20,trunset21,trunset22,trunset23,trunset24 from T_road ");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.road model=new TTG.Model.TTGWeb.road();
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
		public TTG.Model.TTGWeb.road DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.road model=new TTG.Model.TTGWeb.road();
			if (row != null)
			{
				if(row["id"]!=null)
				{
					model.id=row["id"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["community"]!=null)
				{
					model.community=row["community"].ToString();
				}
				if(row["road_class"]!=null)
				{
					model.road_class=row["road_class"].ToString();
				}
				if(row["width"]!=null && row["width"].ToString()!="")
				{
					model.width=decimal.Parse(row["width"].ToString());
				}
				if(row["pavement_width"]!=null && row["pavement_width"].ToString()!="")
				{
					model.pavement_width=decimal.Parse(row["pavement_width"].ToString());
				}
				if(row["community_road_length"]!=null && row["community_road_length"].ToString()!="")
				{
					model.community_road_length=decimal.Parse(row["community_road_length"].ToString());
				}
				if(row["structure"]!=null)
				{
					model.structure=row["structure"].ToString();
				}
				if(row["is_dead_end_road"]!=null)
				{
					model.is_dead_end_road=row["is_dead_end_road"].ToString();
				}
				if(row["damage_road_length"]!=null && row["damage_road_length"].ToString()!="")
				{
					model.damage_road_length=decimal.Parse(row["damage_road_length"].ToString());
				}
				if(row["large_slope_road_length"]!=null && row["large_slope_road_length"].ToString()!="")
				{
					model.large_slope_road_length=decimal.Parse(row["large_slope_road_length"].ToString());
				}
				if(row["no_hard_road_length"]!=null && row["no_hard_road_length"].ToString()!="")
				{
					model.no_hard_road_length=decimal.Parse(row["no_hard_road_length"].ToString());
				}
				if(row["lack_width_road_length"]!=null && row["lack_width_road_length"].ToString()!="")
				{
					model.lack_width_road_length=decimal.Parse(row["lack_width_road_length"].ToString());
				}
				if(row["is_somewhere_no_link"]!=null)
				{
					model.is_somewhere_no_link=row["is_somewhere_no_link"].ToString();
				}
				if(row["no_afforest_road_length"]!=null && row["no_afforest_road_length"].ToString()!="")
				{
					model.no_afforest_road_length=decimal.Parse(row["no_afforest_road_length"].ToString());
				}
				if(row["less_afforest_road_length"]!=null && row["less_afforest_road_length"].ToString()!="")
				{
					model.less_afforest_road_length=decimal.Parse(row["less_afforest_road_length"].ToString());
				}
				if(row["street_light_amount"]!=null && row["street_light_amount"].ToString()!="")
				{
					model.street_light_amount=int.Parse(row["street_light_amount"].ToString());
				}
				if(row["good_street_light_amount"]!=null && row["good_street_light_amount"].ToString()!="")
				{
					model.good_street_light_amount=int.Parse(row["good_street_light_amount"].ToString());
				}
				if(row["road_hydrant_amount"]!=null && row["road_hydrant_amount"].ToString()!="")
				{
					model.road_hydrant_amount=int.Parse(row["road_hydrant_amount"].ToString());
				}
				if(row["good_road_hydrant_amount"]!=null && row["good_road_hydrant_amount"].ToString()!="")
				{
					model.good_road_hydrant_amount=int.Parse(row["good_road_hydrant_amount"].ToString());
				}
				if(row["road_dustbin_amount"]!=null && row["road_dustbin_amount"].ToString()!="")
				{
					model.road_dustbin_amount=int.Parse(row["road_dustbin_amount"].ToString());
				}
				if(row["good_road_dustbin_amount"]!=null && row["good_road_dustbin_amount"].ToString()!="")
				{
					model.good_road_dustbin_amount=int.Parse(row["good_road_dustbin_amount"].ToString());
				}
				if(row["road_parking_space_num"]!=null && row["road_parking_space_num"].ToString()!="")
				{
					model.road_parking_space_num=int.Parse(row["road_parking_space_num"].ToString());
				}
				if(row["parking_space_use_rate"]!=null && row["parking_space_use_rate"].ToString()!="")
				{
					model.parking_space_use_rate=int.Parse(row["parking_space_use_rate"].ToString());
				}
				if(row["note_information"]!=null)
				{
					model.note_information=row["note_information"].ToString();
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["trunset1"]!=null)
				{
					model.trunset1=row["trunset1"].ToString();
				}
				if(row["trunset2"]!=null)
				{
					model.trunset2=row["trunset2"].ToString();
				}
				if(row["trunset3"]!=null)
				{
					model.trunset3=row["trunset3"].ToString();
				}
				if(row["trunset4"]!=null)
				{
					model.trunset4=row["trunset4"].ToString();
				}
				if(row["trunset5"]!=null)
				{
					model.trunset5=row["trunset5"].ToString();
				}
				if(row["trunset6"]!=null)
				{
					model.trunset6=row["trunset6"].ToString();
				}
				if(row["trunset7"]!=null)
				{
					model.trunset7=row["trunset7"].ToString();
				}
				if(row["trunset8"]!=null)
				{
					model.trunset8=row["trunset8"].ToString();
				}
				if(row["trunset9"]!=null)
				{
					model.trunset9=row["trunset9"].ToString();
				}
				if(row["trunset10"]!=null)
				{
					model.trunset10=row["trunset10"].ToString();
				}
				if(row["trunset11"]!=null)
				{
					model.trunset11=row["trunset11"].ToString();
				}
				if(row["trunset12"]!=null)
				{
					model.trunset12=row["trunset12"].ToString();
				}
				if(row["trunset13"]!=null)
				{
					model.trunset13=row["trunset13"].ToString();
				}
				if(row["trunset14"]!=null)
				{
					model.trunset14=row["trunset14"].ToString();
				}
				if(row["trunset15"]!=null)
				{
					model.trunset15=row["trunset15"].ToString();
				}
				if(row["trunset16"]!=null)
				{
					model.trunset16=row["trunset16"].ToString();
				}
				if(row["trunset17"]!=null)
				{
					model.trunset17=row["trunset17"].ToString();
				}
				if(row["trunset18"]!=null)
				{
					model.trunset18=row["trunset18"].ToString();
				}
				if(row["trunset19"]!=null)
				{
					model.trunset19=row["trunset19"].ToString();
				}
				if(row["trunset20"]!=null)
				{
					model.trunset20=row["trunset20"].ToString();
				}
				if(row["trunset21"]!=null)
				{
					model.trunset21=row["trunset21"].ToString();
				}
				if(row["trunset22"]!=null)
				{
					model.trunset22=row["trunset22"].ToString();
				}
				if(row["trunset23"]!=null)
				{
					model.trunset23=row["trunset23"].ToString();
				}
				if(row["trunset24"]!=null)
				{
					model.trunset24=row["trunset24"].ToString();
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
			strSql.Append("select id,name,community,road_class,width,pavement_width,community_road_length,structure,is_dead_end_road,damage_road_length,large_slope_road_length,no_hard_road_length,lack_width_road_length,is_somewhere_no_link,no_afforest_road_length,less_afforest_road_length,street_light_amount,good_street_light_amount,road_hydrant_amount,good_road_hydrant_amount,road_dustbin_amount,good_road_dustbin_amount,road_parking_space_num,parking_space_use_rate,note_information,statistics_date,check_status,lock_tables,trunset1,trunset2,trunset3,trunset4,trunset5,trunset6,trunset7,trunset8,trunset9,trunset10,trunset11,trunset12,trunset13,trunset14,trunset15,trunset16,trunset17,trunset18,trunset19,trunset20,trunset21,trunset22,trunset23,trunset24 ");
			strSql.Append(" FROM T_road ");
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
			strSql.Append(" id,name,community,road_class,width,pavement_width,community_road_length,structure,is_dead_end_road,damage_road_length,large_slope_road_length,no_hard_road_length,lack_width_road_length,is_somewhere_no_link,no_afforest_road_length,less_afforest_road_length,street_light_amount,good_street_light_amount,road_hydrant_amount,good_road_hydrant_amount,road_dustbin_amount,good_road_dustbin_amount,road_parking_space_num,parking_space_use_rate,note_information,statistics_date,check_status,lock_tables,trunset1,trunset2,trunset3,trunset4,trunset5,trunset6,trunset7,trunset8,trunset9,trunset10,trunset11,trunset12,trunset13,trunset14,trunset15,trunset16,trunset17,trunset18,trunset19,trunset20,trunset21,trunset22,trunset23,trunset24 ");
			strSql.Append(" FROM T_road ");
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
			strSql.Append("select count(1) FROM T_road ");
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
			strSql.Append(")AS Row, T.*  from T_road T ");
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
			parameters[0].Value = "T_road";
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

