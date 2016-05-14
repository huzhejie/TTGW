using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:labor_force
	/// </summary>
	public partial class labor_force
	{
		public labor_force()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_labor_force");
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
		public bool Add(TTG.Model.TTGWeb.labor_force model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_labor_force(");
			strSql.Append("id,county,community,lf_have_a_job_pop,lf_have_a_steady_job_pop,empm_information_platform_num,empm_information_platform_information_num,public_spirited_job_pop,clean_keeping_pop,security_guard_pop,farm_produce_fair_administrator_pop,other_job_pop,enp_supportive_num,small_manual_processing_enp_num,food_enp_num,sewing_embroidery_enp_num,other_enp_supportive_num,note_information,statistics_date,tlfunset1,tlfunset2,tlfunset3,tlfunset4,tlfunset5,tlfunset6,tlfunset7,tlfunset8,tlfunset9,tlfunset10,tlfunset11,tlfunset12,tlfunset13,tlfunset14,tlfunset15,tlfunset16,tlfunset17,check_status,lock_tables)");
			strSql.Append(" values (");
			strSql.Append("@id,@county,@community,@lf_have_a_job_pop,@lf_have_a_steady_job_pop,@empm_information_platform_num,@empm_information_platform_information_num,@public_spirited_job_pop,@clean_keeping_pop,@security_guard_pop,@farm_produce_fair_administrator_pop,@other_job_pop,@enp_supportive_num,@small_manual_processing_enp_num,@food_enp_num,@sewing_embroidery_enp_num,@other_enp_supportive_num,@note_information,@statistics_date,@tlfunset1,@tlfunset2,@tlfunset3,@tlfunset4,@tlfunset5,@tlfunset6,@tlfunset7,@tlfunset8,@tlfunset9,@tlfunset10,@tlfunset11,@tlfunset12,@tlfunset13,@tlfunset14,@tlfunset15,@tlfunset16,@tlfunset17,@check_status,@lock_tables)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@county", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@lf_have_a_job_pop", SqlDbType.Int,4),
					new SqlParameter("@lf_have_a_steady_job_pop", SqlDbType.Int,4),
					new SqlParameter("@empm_information_platform_num", SqlDbType.Int,4),
					new SqlParameter("@empm_information_platform_information_num", SqlDbType.Int,4),
					new SqlParameter("@public_spirited_job_pop", SqlDbType.Int,4),
					new SqlParameter("@clean_keeping_pop", SqlDbType.Int,4),
					new SqlParameter("@security_guard_pop", SqlDbType.Int,4),
					new SqlParameter("@farm_produce_fair_administrator_pop", SqlDbType.Int,4),
					new SqlParameter("@other_job_pop", SqlDbType.Int,4),
					new SqlParameter("@enp_supportive_num", SqlDbType.Int,4),
					new SqlParameter("@small_manual_processing_enp_num", SqlDbType.Int,4),
					new SqlParameter("@food_enp_num", SqlDbType.Int,4),
					new SqlParameter("@sewing_embroidery_enp_num", SqlDbType.Int,4),
					new SqlParameter("@other_enp_supportive_num", SqlDbType.Int,4),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tlfunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset17", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.county;
			parameters[2].Value = model.community;
			parameters[3].Value = model.lf_have_a_job_pop;
			parameters[4].Value = model.lf_have_a_steady_job_pop;
			parameters[5].Value = model.empm_information_platform_num;
			parameters[6].Value = model.empm_information_platform_information_num;
			parameters[7].Value = model.public_spirited_job_pop;
			parameters[8].Value = model.clean_keeping_pop;
			parameters[9].Value = model.security_guard_pop;
			parameters[10].Value = model.farm_produce_fair_administrator_pop;
			parameters[11].Value = model.other_job_pop;
			parameters[12].Value = model.enp_supportive_num;
			parameters[13].Value = model.small_manual_processing_enp_num;
			parameters[14].Value = model.food_enp_num;
			parameters[15].Value = model.sewing_embroidery_enp_num;
			parameters[16].Value = model.other_enp_supportive_num;
			parameters[17].Value = model.note_information;
			parameters[18].Value = model.statistics_date;
			parameters[19].Value = model.tlfunset1;
			parameters[20].Value = model.tlfunset2;
			parameters[21].Value = model.tlfunset3;
			parameters[22].Value = model.tlfunset4;
			parameters[23].Value = model.tlfunset5;
			parameters[24].Value = model.tlfunset6;
			parameters[25].Value = model.tlfunset7;
			parameters[26].Value = model.tlfunset8;
			parameters[27].Value = model.tlfunset9;
			parameters[28].Value = model.tlfunset10;
			parameters[29].Value = model.tlfunset11;
			parameters[30].Value = model.tlfunset12;
			parameters[31].Value = model.tlfunset13;
			parameters[32].Value = model.tlfunset14;
			parameters[33].Value = model.tlfunset15;
			parameters[34].Value = model.tlfunset16;
			parameters[35].Value = model.tlfunset17;
			parameters[36].Value = model.check_status;
			parameters[37].Value = model.lock_tables;

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
		public bool Update(TTG.Model.TTGWeb.labor_force model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_labor_force set ");
			strSql.Append("county=@county,");
			strSql.Append("community=@community,");
			strSql.Append("lf_have_a_job_pop=@lf_have_a_job_pop,");
			strSql.Append("lf_have_a_steady_job_pop=@lf_have_a_steady_job_pop,");
			strSql.Append("empm_information_platform_num=@empm_information_platform_num,");
			strSql.Append("empm_information_platform_information_num=@empm_information_platform_information_num,");
			strSql.Append("public_spirited_job_pop=@public_spirited_job_pop,");
			strSql.Append("clean_keeping_pop=@clean_keeping_pop,");
			strSql.Append("security_guard_pop=@security_guard_pop,");
			strSql.Append("farm_produce_fair_administrator_pop=@farm_produce_fair_administrator_pop,");
			strSql.Append("other_job_pop=@other_job_pop,");
			strSql.Append("enp_supportive_num=@enp_supportive_num,");
			strSql.Append("small_manual_processing_enp_num=@small_manual_processing_enp_num,");
			strSql.Append("food_enp_num=@food_enp_num,");
			strSql.Append("sewing_embroidery_enp_num=@sewing_embroidery_enp_num,");
			strSql.Append("other_enp_supportive_num=@other_enp_supportive_num,");
			strSql.Append("note_information=@note_information,");
			strSql.Append("tlfunset1=@tlfunset1,");
			strSql.Append("tlfunset2=@tlfunset2,");
			strSql.Append("tlfunset3=@tlfunset3,");
			strSql.Append("tlfunset4=@tlfunset4,");
			strSql.Append("tlfunset5=@tlfunset5,");
			strSql.Append("tlfunset6=@tlfunset6,");
			strSql.Append("tlfunset7=@tlfunset7,");
			strSql.Append("tlfunset8=@tlfunset8,");
			strSql.Append("tlfunset9=@tlfunset9,");
			strSql.Append("tlfunset10=@tlfunset10,");
			strSql.Append("tlfunset11=@tlfunset11,");
			strSql.Append("tlfunset12=@tlfunset12,");
			strSql.Append("tlfunset13=@tlfunset13,");
			strSql.Append("tlfunset14=@tlfunset14,");
			strSql.Append("tlfunset15=@tlfunset15,");
			strSql.Append("tlfunset16=@tlfunset16,");
			strSql.Append("tlfunset17=@tlfunset17,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@county", SqlDbType.VarChar,50),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@lf_have_a_job_pop", SqlDbType.Int,4),
					new SqlParameter("@lf_have_a_steady_job_pop", SqlDbType.Int,4),
					new SqlParameter("@empm_information_platform_num", SqlDbType.Int,4),
					new SqlParameter("@empm_information_platform_information_num", SqlDbType.Int,4),
					new SqlParameter("@public_spirited_job_pop", SqlDbType.Int,4),
					new SqlParameter("@clean_keeping_pop", SqlDbType.Int,4),
					new SqlParameter("@security_guard_pop", SqlDbType.Int,4),
					new SqlParameter("@farm_produce_fair_administrator_pop", SqlDbType.Int,4),
					new SqlParameter("@other_job_pop", SqlDbType.Int,4),
					new SqlParameter("@enp_supportive_num", SqlDbType.Int,4),
					new SqlParameter("@small_manual_processing_enp_num", SqlDbType.Int,4),
					new SqlParameter("@food_enp_num", SqlDbType.Int,4),
					new SqlParameter("@sewing_embroidery_enp_num", SqlDbType.Int,4),
					new SqlParameter("@other_enp_supportive_num", SqlDbType.Int,4),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@tlfunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset14", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset15", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset16", SqlDbType.VarChar,50),
					new SqlParameter("@tlfunset17", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.county;
			parameters[1].Value = model.community;
			parameters[2].Value = model.lf_have_a_job_pop;
			parameters[3].Value = model.lf_have_a_steady_job_pop;
			parameters[4].Value = model.empm_information_platform_num;
			parameters[5].Value = model.empm_information_platform_information_num;
			parameters[6].Value = model.public_spirited_job_pop;
			parameters[7].Value = model.clean_keeping_pop;
			parameters[8].Value = model.security_guard_pop;
			parameters[9].Value = model.farm_produce_fair_administrator_pop;
			parameters[10].Value = model.other_job_pop;
			parameters[11].Value = model.enp_supportive_num;
			parameters[12].Value = model.small_manual_processing_enp_num;
			parameters[13].Value = model.food_enp_num;
			parameters[14].Value = model.sewing_embroidery_enp_num;
			parameters[15].Value = model.other_enp_supportive_num;
			parameters[16].Value = model.note_information;
			parameters[17].Value = model.tlfunset1;
			parameters[18].Value = model.tlfunset2;
			parameters[19].Value = model.tlfunset3;
			parameters[20].Value = model.tlfunset4;
			parameters[21].Value = model.tlfunset5;
			parameters[22].Value = model.tlfunset6;
			parameters[23].Value = model.tlfunset7;
			parameters[24].Value = model.tlfunset8;
			parameters[25].Value = model.tlfunset9;
			parameters[26].Value = model.tlfunset10;
			parameters[27].Value = model.tlfunset11;
			parameters[28].Value = model.tlfunset12;
			parameters[29].Value = model.tlfunset13;
			parameters[30].Value = model.tlfunset14;
			parameters[31].Value = model.tlfunset15;
			parameters[32].Value = model.tlfunset16;
			parameters[33].Value = model.tlfunset17;
			parameters[34].Value = model.check_status;
			parameters[35].Value = model.lock_tables;
			parameters[36].Value = model.id;
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
		public bool Delete(string id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_labor_force ");
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
		public TTG.Model.TTGWeb.labor_force GetModel(string id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,county,community,lf_have_a_job_pop,lf_have_a_steady_job_pop,empm_information_platform_num,empm_information_platform_information_num,public_spirited_job_pop,clean_keeping_pop,security_guard_pop,farm_produce_fair_administrator_pop,other_job_pop,enp_supportive_num,small_manual_processing_enp_num,food_enp_num,sewing_embroidery_enp_num,other_enp_supportive_num,note_information,statistics_date,tlfunset1,tlfunset2,tlfunset3,tlfunset4,tlfunset5,tlfunset6,tlfunset7,tlfunset8,tlfunset9,tlfunset10,tlfunset11,tlfunset12,tlfunset13,tlfunset14,tlfunset15,tlfunset16,tlfunset17,check_status,lock_tables from T_labor_force ");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.labor_force model=new TTG.Model.TTGWeb.labor_force();
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
		public TTG.Model.TTGWeb.labor_force DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.labor_force model=new TTG.Model.TTGWeb.labor_force();
			if (row != null)
			{
				if(row["id"]!=null)
				{
					model.id=row["id"].ToString();
				}
				if(row["county"]!=null)
				{
					model.county=row["county"].ToString();
				}
				if(row["community"]!=null)
				{
					model.community=row["community"].ToString();
				}
				if(row["lf_have_a_job_pop"]!=null && row["lf_have_a_job_pop"].ToString()!="")
				{
					model.lf_have_a_job_pop=int.Parse(row["lf_have_a_job_pop"].ToString());
				}
				if(row["lf_have_a_steady_job_pop"]!=null && row["lf_have_a_steady_job_pop"].ToString()!="")
				{
					model.lf_have_a_steady_job_pop=int.Parse(row["lf_have_a_steady_job_pop"].ToString());
				}
				if(row["empm_information_platform_num"]!=null && row["empm_information_platform_num"].ToString()!="")
				{
					model.empm_information_platform_num=int.Parse(row["empm_information_platform_num"].ToString());
				}
				if(row["empm_information_platform_information_num"]!=null && row["empm_information_platform_information_num"].ToString()!="")
				{
					model.empm_information_platform_information_num=int.Parse(row["empm_information_platform_information_num"].ToString());
				}
				if(row["public_spirited_job_pop"]!=null && row["public_spirited_job_pop"].ToString()!="")
				{
					model.public_spirited_job_pop=int.Parse(row["public_spirited_job_pop"].ToString());
				}
				if(row["clean_keeping_pop"]!=null && row["clean_keeping_pop"].ToString()!="")
				{
					model.clean_keeping_pop=int.Parse(row["clean_keeping_pop"].ToString());
				}
				if(row["security_guard_pop"]!=null && row["security_guard_pop"].ToString()!="")
				{
					model.security_guard_pop=int.Parse(row["security_guard_pop"].ToString());
				}
				if(row["farm_produce_fair_administrator_pop"]!=null && row["farm_produce_fair_administrator_pop"].ToString()!="")
				{
					model.farm_produce_fair_administrator_pop=int.Parse(row["farm_produce_fair_administrator_pop"].ToString());
				}
				if(row["other_job_pop"]!=null && row["other_job_pop"].ToString()!="")
				{
					model.other_job_pop=int.Parse(row["other_job_pop"].ToString());
				}
				if(row["enp_supportive_num"]!=null && row["enp_supportive_num"].ToString()!="")
				{
					model.enp_supportive_num=int.Parse(row["enp_supportive_num"].ToString());
				}
				if(row["small_manual_processing_enp_num"]!=null && row["small_manual_processing_enp_num"].ToString()!="")
				{
					model.small_manual_processing_enp_num=int.Parse(row["small_manual_processing_enp_num"].ToString());
				}
				if(row["food_enp_num"]!=null && row["food_enp_num"].ToString()!="")
				{
					model.food_enp_num=int.Parse(row["food_enp_num"].ToString());
				}
				if(row["sewing_embroidery_enp_num"]!=null && row["sewing_embroidery_enp_num"].ToString()!="")
				{
					model.sewing_embroidery_enp_num=int.Parse(row["sewing_embroidery_enp_num"].ToString());
				}
				if(row["other_enp_supportive_num"]!=null && row["other_enp_supportive_num"].ToString()!="")
				{
					model.other_enp_supportive_num=int.Parse(row["other_enp_supportive_num"].ToString());
				}
				if(row["note_information"]!=null)
				{
					model.note_information=row["note_information"].ToString();
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tlfunset1"]!=null)
				{
					model.tlfunset1=row["tlfunset1"].ToString();
				}
				if(row["tlfunset2"]!=null)
				{
					model.tlfunset2=row["tlfunset2"].ToString();
				}
				if(row["tlfunset3"]!=null)
				{
					model.tlfunset3=row["tlfunset3"].ToString();
				}
				if(row["tlfunset4"]!=null)
				{
					model.tlfunset4=row["tlfunset4"].ToString();
				}
				if(row["tlfunset5"]!=null)
				{
					model.tlfunset5=row["tlfunset5"].ToString();
				}
				if(row["tlfunset6"]!=null)
				{
					model.tlfunset6=row["tlfunset6"].ToString();
				}
				if(row["tlfunset7"]!=null)
				{
					model.tlfunset7=row["tlfunset7"].ToString();
				}
				if(row["tlfunset8"]!=null)
				{
					model.tlfunset8=row["tlfunset8"].ToString();
				}
				if(row["tlfunset9"]!=null)
				{
					model.tlfunset9=row["tlfunset9"].ToString();
				}
				if(row["tlfunset10"]!=null)
				{
					model.tlfunset10=row["tlfunset10"].ToString();
				}
				if(row["tlfunset11"]!=null)
				{
					model.tlfunset11=row["tlfunset11"].ToString();
				}
				if(row["tlfunset12"]!=null)
				{
					model.tlfunset12=row["tlfunset12"].ToString();
				}
				if(row["tlfunset13"]!=null)
				{
					model.tlfunset13=row["tlfunset13"].ToString();
				}
				if(row["tlfunset14"]!=null)
				{
					model.tlfunset14=row["tlfunset14"].ToString();
				}
				if(row["tlfunset15"]!=null)
				{
					model.tlfunset15=row["tlfunset15"].ToString();
				}
				if(row["tlfunset16"]!=null)
				{
					model.tlfunset16=row["tlfunset16"].ToString();
				}
				if(row["tlfunset17"]!=null)
				{
					model.tlfunset17=row["tlfunset17"].ToString();
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
			strSql.Append("select id,county,community,lf_have_a_job_pop,lf_have_a_steady_job_pop,empm_information_platform_num,empm_information_platform_information_num,public_spirited_job_pop,clean_keeping_pop,security_guard_pop,farm_produce_fair_administrator_pop,other_job_pop,enp_supportive_num,small_manual_processing_enp_num,food_enp_num,sewing_embroidery_enp_num,other_enp_supportive_num,note_information,statistics_date,tlfunset1,tlfunset2,tlfunset3,tlfunset4,tlfunset5,tlfunset6,tlfunset7,tlfunset8,tlfunset9,tlfunset10,tlfunset11,tlfunset12,tlfunset13,tlfunset14,tlfunset15,tlfunset16,tlfunset17,check_status,lock_tables ");
			strSql.Append(" FROM T_labor_force ");
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
			strSql.Append(" id,county,community,lf_have_a_job_pop,lf_have_a_steady_job_pop,empm_information_platform_num,empm_information_platform_information_num,public_spirited_job_pop,clean_keeping_pop,security_guard_pop,farm_produce_fair_administrator_pop,other_job_pop,enp_supportive_num,small_manual_processing_enp_num,food_enp_num,sewing_embroidery_enp_num,other_enp_supportive_num,note_information,statistics_date,tlfunset1,tlfunset2,tlfunset3,tlfunset4,tlfunset5,tlfunset6,tlfunset7,tlfunset8,tlfunset9,tlfunset10,tlfunset11,tlfunset12,tlfunset13,tlfunset14,tlfunset15,tlfunset16,tlfunset17,check_status,lock_tables ");
			strSql.Append(" FROM T_labor_force ");
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
			strSql.Append("select count(1) FROM T_labor_force ");
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
			strSql.Append(")AS Row, T.*  from T_labor_force T ");
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
			parameters[0].Value = "T_labor_force";
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

