using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:concil_house
	/// </summary>
	public partial class concil_house
	{
		public concil_house()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_concil_house");
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
		public bool Add(TTG.Model.TTGWeb.concil_house model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_concil_house(");
			strSql.Append("id,community,building,unit,structure,floor,house,finish_time,gross_floor_area,tiled_wall_area,family_num,pop_num,slight_deform_cra_area,base_subs_area,dila_buil_area,stru_safety_prob_fam_num,slight_deform_cra_pop,seepage_buil_area,seepage_fam_num,seepage_pop,tile_paint_cra_holl_buil_area,note_information,statistics_date,tchunset1,tchunset2,tchunset3,tchunset4,tchunset5,tchunset6,tchunset7,tchunset8,tchunset9,tchunset10,tchunset11,tchunset12,tchunset13,tchunset14,tchunset15,tchunset16,tchunset17,tchunset18,tchunset19,tchunset20,tchunset21,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@id,@community,@building,@unit,@structure,@floor,@house,@finish_time,@gross_floor_area,@tiled_wall_area,@family_num,@pop_num,@slight_deform_cra_area,@base_subs_area,@dila_buil_area,@stru_safety_prob_fam_num,@slight_deform_cra_pop,@seepage_buil_area,@seepage_fam_num,@seepage_pop,@tile_paint_cra_holl_buil_area,@note_information,@statistics_date,@tchunset1,@tchunset2,@tchunset3,@tchunset4,@tchunset5,@tchunset6,@tchunset7,@tchunset8,@tchunset9,@tchunset10,@tchunset11,@tchunset12,@tchunset13,@tchunset14,@tchunset15,@tchunset16,@tchunset17,@tchunset18,@tchunset19,@tchunset20,@tchunset21,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@building", SqlDbType.Int,4),
					new SqlParameter("@unit", SqlDbType.Int,4),
					new SqlParameter("@structure", SqlDbType.VarChar,20),
					new SqlParameter("@floor", SqlDbType.Int,4),
					new SqlParameter("@house", SqlDbType.Int,4),
					new SqlParameter("@finish_time", SqlDbType.Date,3),
					new SqlParameter("@gross_floor_area", SqlDbType.Float,8),
					new SqlParameter("@tiled_wall_area", SqlDbType.Float,8),
					new SqlParameter("@family_num", SqlDbType.Int,4),
					new SqlParameter("@pop_num", SqlDbType.Int,4),
					new SqlParameter("@slight_deform_cra_area", SqlDbType.Float,8),
					new SqlParameter("@base_subs_area", SqlDbType.Float,8),
					new SqlParameter("@dila_buil_area", SqlDbType.Float,8),
					new SqlParameter("@stru_safety_prob_fam_num", SqlDbType.Int,4),
					new SqlParameter("@slight_deform_cra_pop", SqlDbType.Int,4),
					new SqlParameter("@seepage_buil_area", SqlDbType.Float,8),
					new SqlParameter("@seepage_fam_num", SqlDbType.Int,4),
					new SqlParameter("@seepage_pop", SqlDbType.Int,4),
					new SqlParameter("@tile_paint_cra_holl_buil_area", SqlDbType.Float,8),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tchunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset21", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.community;
			parameters[2].Value = model.building;
			parameters[3].Value = model.unit;
			parameters[4].Value = model.structure;
			parameters[5].Value = model.floor;
			parameters[6].Value = model.house;
			parameters[7].Value = model.finish_time;
			parameters[8].Value = model.gross_floor_area;
			parameters[9].Value = model.tiled_wall_area;
			parameters[10].Value = model.family_num;
			parameters[11].Value = model.pop_num;
			parameters[12].Value = model.slight_deform_cra_area;
			parameters[13].Value = model.base_subs_area;
			parameters[14].Value = model.dila_buil_area;
			parameters[15].Value = model.stru_safety_prob_fam_num;
			parameters[16].Value = model.slight_deform_cra_pop;
			parameters[17].Value = model.seepage_buil_area;
			parameters[18].Value = model.seepage_fam_num;
			parameters[19].Value = model.seepage_pop;
			parameters[20].Value = model.tile_paint_cra_holl_buil_area;
			parameters[21].Value = model.note_information;
			parameters[22].Value = model.statistics_date;
			parameters[23].Value = model.tchunset1;
			parameters[24].Value = model.tchunset2;
			parameters[25].Value = model.tchunset3;
			parameters[26].Value = model.tchunset4;
			parameters[27].Value = model.tchunset5;
			parameters[28].Value = model.tchunset6;
			parameters[29].Value = model.tchunset7;
			parameters[30].Value = model.tchunset8;
			parameters[31].Value = model.tchunset9;
			parameters[32].Value = model.tchunset10;
			parameters[33].Value = model.tchunset11;
			parameters[34].Value = model.tchunset12;
			parameters[35].Value = model.tchunset13;
			parameters[36].Value = model.tchunset14;
			parameters[37].Value = model.tchunset15;
			parameters[38].Value = model.tchunset16;
			parameters[39].Value = model.tchunset17;
			parameters[40].Value = model.tchunset18;
			parameters[41].Value = model.tchunset19;
			parameters[42].Value = model.tchunset20;
			parameters[43].Value = model.tchunset21;
			parameters[44].Value = model.lock_tables;
			parameters[45].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.concil_house model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_concil_house set ");
			strSql.Append("community=@community,");
			strSql.Append("building=@building,");
			strSql.Append("unit=@unit,");
			strSql.Append("structure=@structure,");
			strSql.Append("floor=@floor,");
			strSql.Append("house=@house,");
			strSql.Append("finish_time=@finish_time,");
			strSql.Append("gross_floor_area=@gross_floor_area,");
			strSql.Append("tiled_wall_area=@tiled_wall_area,");
			strSql.Append("family_num=@family_num,");
			strSql.Append("pop_num=@pop_num,");
			strSql.Append("slight_deform_cra_area=@slight_deform_cra_area,");
			strSql.Append("base_subs_area=@base_subs_area,");
			strSql.Append("dila_buil_area=@dila_buil_area,");
			strSql.Append("stru_safety_prob_fam_num=@stru_safety_prob_fam_num,");
			strSql.Append("slight_deform_cra_pop=@slight_deform_cra_pop,");
			strSql.Append("seepage_buil_area=@seepage_buil_area,");
			strSql.Append("seepage_fam_num=@seepage_fam_num,");
			strSql.Append("seepage_pop=@seepage_pop,");
			strSql.Append("tile_paint_cra_holl_buil_area=@tile_paint_cra_holl_buil_area,");
			strSql.Append("note_information=@note_information,");
			strSql.Append("tchunset1=@tchunset1,");
			strSql.Append("tchunset2=@tchunset2,");
			strSql.Append("tchunset3=@tchunset3,");
			strSql.Append("tchunset4=@tchunset4,");
			strSql.Append("tchunset5=@tchunset5,");
			strSql.Append("tchunset6=@tchunset6,");
			strSql.Append("tchunset7=@tchunset7,");
			strSql.Append("tchunset8=@tchunset8,");
			strSql.Append("tchunset9=@tchunset9,");
			strSql.Append("tchunset10=@tchunset10,");
			strSql.Append("tchunset11=@tchunset11,");
			strSql.Append("tchunset12=@tchunset12,");
			strSql.Append("tchunset13=@tchunset13,");
			strSql.Append("tchunset14=@tchunset14,");
			strSql.Append("tchunset15=@tchunset15,");
			strSql.Append("tchunset16=@tchunset16,");
			strSql.Append("tchunset17=@tchunset17,");
			strSql.Append("tchunset18=@tchunset18,");
			strSql.Append("tchunset19=@tchunset19,");
			strSql.Append("tchunset20=@tchunset20,");
			strSql.Append("tchunset21=@tchunset21,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@building", SqlDbType.Int,4),
					new SqlParameter("@unit", SqlDbType.Int,4),
					new SqlParameter("@structure", SqlDbType.VarChar,20),
					new SqlParameter("@floor", SqlDbType.Int,4),
					new SqlParameter("@house", SqlDbType.Int,4),
					new SqlParameter("@finish_time", SqlDbType.Date,3),
					new SqlParameter("@gross_floor_area", SqlDbType.Float,8),
					new SqlParameter("@tiled_wall_area", SqlDbType.Float,8),
					new SqlParameter("@family_num", SqlDbType.Int,4),
					new SqlParameter("@pop_num", SqlDbType.Int,4),
					new SqlParameter("@slight_deform_cra_area", SqlDbType.Float,8),
					new SqlParameter("@base_subs_area", SqlDbType.Float,8),
					new SqlParameter("@dila_buil_area", SqlDbType.Float,8),
					new SqlParameter("@stru_safety_prob_fam_num", SqlDbType.Int,4),
					new SqlParameter("@slight_deform_cra_pop", SqlDbType.Int,4),
					new SqlParameter("@seepage_buil_area", SqlDbType.Float,8),
					new SqlParameter("@seepage_fam_num", SqlDbType.Int,4),
					new SqlParameter("@seepage_pop", SqlDbType.Int,4),
					new SqlParameter("@tile_paint_cra_holl_buil_area", SqlDbType.Float,8),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@tchunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset17", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset18", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset19", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset20", SqlDbType.VarChar,50),
					new SqlParameter("@tchunset21", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community;
			parameters[1].Value = model.building;
			parameters[2].Value = model.unit;
			parameters[3].Value = model.structure;
			parameters[4].Value = model.floor;
			parameters[5].Value = model.house;
			parameters[6].Value = model.finish_time;
			parameters[7].Value = model.gross_floor_area;
			parameters[8].Value = model.tiled_wall_area;
			parameters[9].Value = model.family_num;
			parameters[10].Value = model.pop_num;
			parameters[11].Value = model.slight_deform_cra_area;
			parameters[12].Value = model.base_subs_area;
			parameters[13].Value = model.dila_buil_area;
			parameters[14].Value = model.stru_safety_prob_fam_num;
			parameters[15].Value = model.slight_deform_cra_pop;
			parameters[16].Value = model.seepage_buil_area;
			parameters[17].Value = model.seepage_fam_num;
			parameters[18].Value = model.seepage_pop;
			parameters[19].Value = model.tile_paint_cra_holl_buil_area;
			parameters[20].Value = model.note_information;
			parameters[21].Value = model.tchunset1;
			parameters[22].Value = model.tchunset2;
			parameters[23].Value = model.tchunset3;
			parameters[24].Value = model.tchunset4;
			parameters[25].Value = model.tchunset5;
			parameters[26].Value = model.tchunset6;
			parameters[27].Value = model.tchunset7;
			parameters[28].Value = model.tchunset8;
			parameters[29].Value = model.tchunset9;
			parameters[30].Value = model.tchunset10;
			parameters[31].Value = model.tchunset11;
			parameters[32].Value = model.tchunset12;
			parameters[33].Value = model.tchunset13;
			parameters[34].Value = model.tchunset14;
			parameters[35].Value = model.tchunset15;
			parameters[36].Value = model.tchunset16;
			parameters[37].Value = model.tchunset17;
			parameters[38].Value = model.tchunset18;
			parameters[39].Value = model.tchunset19;
			parameters[40].Value = model.tchunset20;
			parameters[41].Value = model.tchunset21;
			parameters[42].Value = model.lock_tables;
			parameters[43].Value = model.check_status;
			parameters[44].Value = model.id;
			parameters[45].Value = model.statistics_date;

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
			strSql.Append("delete from T_concil_house ");
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
		public TTG.Model.TTGWeb.concil_house GetModel(string id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,community,building,unit,structure,floor,house,finish_time,gross_floor_area,tiled_wall_area,family_num,pop_num,slight_deform_cra_area,base_subs_area,dila_buil_area,stru_safety_prob_fam_num,slight_deform_cra_pop,seepage_buil_area,seepage_fam_num,seepage_pop,tile_paint_cra_holl_buil_area,note_information,statistics_date,tchunset1,tchunset2,tchunset3,tchunset4,tchunset5,tchunset6,tchunset7,tchunset8,tchunset9,tchunset10,tchunset11,tchunset12,tchunset13,tchunset14,tchunset15,tchunset16,tchunset17,tchunset18,tchunset19,tchunset20,tchunset21,lock_tables,check_status from T_concil_house ");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.concil_house model=new TTG.Model.TTGWeb.concil_house();
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
		public TTG.Model.TTGWeb.concil_house DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.concil_house model=new TTG.Model.TTGWeb.concil_house();
			if (row != null)
			{
				if(row["id"]!=null)
				{
					model.id=row["id"].ToString();
				}
				if(row["community"]!=null)
				{
					model.community=row["community"].ToString();
				}
				if(row["building"]!=null && row["building"].ToString()!="")
				{
					model.building=int.Parse(row["building"].ToString());
				}
				if(row["unit"]!=null && row["unit"].ToString()!="")
				{
					model.unit=int.Parse(row["unit"].ToString());
				}
				if(row["structure"]!=null)
				{
					model.structure=row["structure"].ToString();
				}
				if(row["floor"]!=null && row["floor"].ToString()!="")
				{
					model.floor=int.Parse(row["floor"].ToString());
				}
				if(row["house"]!=null && row["house"].ToString()!="")
				{
					model.house=int.Parse(row["house"].ToString());
				}
				if(row["finish_time"]!=null && row["finish_time"].ToString()!="")
				{
					model.finish_time=DateTime.Parse(row["finish_time"].ToString());
				}
				if(row["gross_floor_area"]!=null && row["gross_floor_area"].ToString()!="")
				{
					model.gross_floor_area=decimal.Parse(row["gross_floor_area"].ToString());
				}
				if(row["tiled_wall_area"]!=null && row["tiled_wall_area"].ToString()!="")
				{
					model.tiled_wall_area=decimal.Parse(row["tiled_wall_area"].ToString());
				}
				if(row["family_num"]!=null && row["family_num"].ToString()!="")
				{
					model.family_num=int.Parse(row["family_num"].ToString());
				}
				if(row["pop_num"]!=null && row["pop_num"].ToString()!="")
				{
					model.pop_num=int.Parse(row["pop_num"].ToString());
				}
				if(row["slight_deform_cra_area"]!=null && row["slight_deform_cra_area"].ToString()!="")
				{
					model.slight_deform_cra_area=decimal.Parse(row["slight_deform_cra_area"].ToString());
				}
				if(row["base_subs_area"]!=null && row["base_subs_area"].ToString()!="")
				{
					model.base_subs_area=decimal.Parse(row["base_subs_area"].ToString());
				}
				if(row["dila_buil_area"]!=null && row["dila_buil_area"].ToString()!="")
				{
					model.dila_buil_area=decimal.Parse(row["dila_buil_area"].ToString());
				}
				if(row["stru_safety_prob_fam_num"]!=null && row["stru_safety_prob_fam_num"].ToString()!="")
				{
					model.stru_safety_prob_fam_num=int.Parse(row["stru_safety_prob_fam_num"].ToString());
				}
				if(row["slight_deform_cra_pop"]!=null && row["slight_deform_cra_pop"].ToString()!="")
				{
					model.slight_deform_cra_pop=int.Parse(row["slight_deform_cra_pop"].ToString());
				}
				if(row["seepage_buil_area"]!=null && row["seepage_buil_area"].ToString()!="")
				{
					model.seepage_buil_area=decimal.Parse(row["seepage_buil_area"].ToString());
				}
				if(row["seepage_fam_num"]!=null && row["seepage_fam_num"].ToString()!="")
				{
					model.seepage_fam_num=int.Parse(row["seepage_fam_num"].ToString());
				}
				if(row["seepage_pop"]!=null && row["seepage_pop"].ToString()!="")
				{
					model.seepage_pop=int.Parse(row["seepage_pop"].ToString());
				}
				if(row["tile_paint_cra_holl_buil_area"]!=null && row["tile_paint_cra_holl_buil_area"].ToString()!="")
				{
					model.tile_paint_cra_holl_buil_area=decimal.Parse(row["tile_paint_cra_holl_buil_area"].ToString());
				}
				if(row["note_information"]!=null)
				{
					model.note_information=row["note_information"].ToString();
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tchunset1"]!=null)
				{
					model.tchunset1=row["tchunset1"].ToString();
				}
				if(row["tchunset2"]!=null)
				{
					model.tchunset2=row["tchunset2"].ToString();
				}
				if(row["tchunset3"]!=null)
				{
					model.tchunset3=row["tchunset3"].ToString();
				}
				if(row["tchunset4"]!=null)
				{
					model.tchunset4=row["tchunset4"].ToString();
				}
				if(row["tchunset5"]!=null)
				{
					model.tchunset5=row["tchunset5"].ToString();
				}
				if(row["tchunset6"]!=null)
				{
					model.tchunset6=row["tchunset6"].ToString();
				}
				if(row["tchunset7"]!=null)
				{
					model.tchunset7=row["tchunset7"].ToString();
				}
				if(row["tchunset8"]!=null)
				{
					model.tchunset8=row["tchunset8"].ToString();
				}
				if(row["tchunset9"]!=null)
				{
					model.tchunset9=row["tchunset9"].ToString();
				}
				if(row["tchunset10"]!=null)
				{
					model.tchunset10=row["tchunset10"].ToString();
				}
				if(row["tchunset11"]!=null)
				{
					model.tchunset11=row["tchunset11"].ToString();
				}
				if(row["tchunset12"]!=null)
				{
					model.tchunset12=row["tchunset12"].ToString();
				}
				if(row["tchunset13"]!=null)
				{
					model.tchunset13=row["tchunset13"].ToString();
				}
				if(row["tchunset14"]!=null)
				{
					model.tchunset14=row["tchunset14"].ToString();
				}
				if(row["tchunset15"]!=null)
				{
					model.tchunset15=row["tchunset15"].ToString();
				}
				if(row["tchunset16"]!=null)
				{
					model.tchunset16=row["tchunset16"].ToString();
				}
				if(row["tchunset17"]!=null)
				{
					model.tchunset17=row["tchunset17"].ToString();
				}
				if(row["tchunset18"]!=null)
				{
					model.tchunset18=row["tchunset18"].ToString();
				}
				if(row["tchunset19"]!=null)
				{
					model.tchunset19=row["tchunset19"].ToString();
				}
				if(row["tchunset20"]!=null)
				{
					model.tchunset20=row["tchunset20"].ToString();
				}
				if(row["tchunset21"]!=null)
				{
					model.tchunset21=row["tchunset21"].ToString();
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
			strSql.Append("select id,community,building,unit,structure,floor,house,finish_time,gross_floor_area,tiled_wall_area,family_num,pop_num,slight_deform_cra_area,base_subs_area,dila_buil_area,stru_safety_prob_fam_num,slight_deform_cra_pop,seepage_buil_area,seepage_fam_num,seepage_pop,tile_paint_cra_holl_buil_area,note_information,statistics_date,tchunset1,tchunset2,tchunset3,tchunset4,tchunset5,tchunset6,tchunset7,tchunset8,tchunset9,tchunset10,tchunset11,tchunset12,tchunset13,tchunset14,tchunset15,tchunset16,tchunset17,tchunset18,tchunset19,tchunset20,tchunset21,lock_tables,check_status ");
			strSql.Append(" FROM T_concil_house ");
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
			strSql.Append(" id,community,building,unit,structure,floor,house,finish_time,gross_floor_area,tiled_wall_area,family_num,pop_num,slight_deform_cra_area,base_subs_area,dila_buil_area,stru_safety_prob_fam_num,slight_deform_cra_pop,seepage_buil_area,seepage_fam_num,seepage_pop,tile_paint_cra_holl_buil_area,note_information,statistics_date,tchunset1,tchunset2,tchunset3,tchunset4,tchunset5,tchunset6,tchunset7,tchunset8,tchunset9,tchunset10,tchunset11,tchunset12,tchunset13,tchunset14,tchunset15,tchunset16,tchunset17,tchunset18,tchunset19,tchunset20,tchunset21,lock_tables,check_status ");
			strSql.Append(" FROM T_concil_house ");
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
			strSql.Append("select count(1) FROM T_concil_house ");
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
			strSql.Append(")AS Row, T.*  from T_concil_house T ");
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
			parameters[0].Value = "T_concil_house";
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

