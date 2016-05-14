using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:previously_special_project
	/// </summary>
	public partial class previously_special_project
	{
		public previously_special_project()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "T_previously_special_project"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(DateTime fill_time,int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_previously_special_project");
			strSql.Append(" where fill_time=@fill_time and id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = fill_time;
			parameters[1].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(TTG.Model.TTGWeb.previously_special_project model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_previously_special_project(");
            strSql.Append("project_id,county_name,after_id,project_name,project_type,year_time,total_investment,follow_up_special_founds,plan_support_founds,other_matching_founds,project_owner,bidding_time,contract_period,start_date,finish_date,project_lag_reason,have_quality_safety_incident,incidents_process_situation,finish_accept_date,finish_accept_quality_level,is_transfer,radial_project,remark,lock_table,check_status,unset1,unset2,unset3,unset4,unset5,unset6,unset7,unset8,unset9,unset10,unset11,fill_time,main_construct_properties,project_community_description)");
			strSql.Append(" values (");
            strSql.Append("@project_id,@county_name,@after_id,@project_name,@project_type,@year_time,@total_investment,@follow_up_special_founds,@plan_support_founds,@other_matching_founds,@project_owner,@bidding_time,@contract_period,@start_date,@finish_date,@project_lag_reason,@have_quality_safety_incident,@incidents_process_situation,@finish_accept_date,@finish_accept_quality_level,@is_transfer,@radial_project,@remark,@lock_table,@check_status,@unset1,@unset2,@unset3,@unset4,@unset5,@unset6,@unset7,@unset8,@unset9,@unset10,@unset11,@fill_time,@main_construct_properties,@project_community_description)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,50),
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@after_id", SqlDbType.VarChar,50),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_type", SqlDbType.VarChar,20),
					new SqlParameter("@year_time", SqlDbType.Int,4),
					new SqlParameter("@total_investment", SqlDbType.Float,8),
					new SqlParameter("@follow_up_special_founds", SqlDbType.Float,8),
					new SqlParameter("@plan_support_founds", SqlDbType.Float,8),
					new SqlParameter("@other_matching_founds", SqlDbType.Float,8),
					new SqlParameter("@project_owner", SqlDbType.VarChar,20),
					new SqlParameter("@bidding_time", SqlDbType.VarChar,200),
					new SqlParameter("@contract_period", SqlDbType.Int,4),
					new SqlParameter("@start_date", SqlDbType.VarChar,200),
					new SqlParameter("@finish_date", SqlDbType.VarChar,200),
					new SqlParameter("@project_lag_reason", SqlDbType.NVarChar,200),
					new SqlParameter("@have_quality_safety_incident", SqlDbType.VarChar,50),
					new SqlParameter("@incidents_process_situation", SqlDbType.NVarChar,200),
					new SqlParameter("@finish_accept_date", SqlDbType.DateTime),
					new SqlParameter("@finish_accept_quality_level", SqlDbType.VarChar,50),
					new SqlParameter("@is_transfer", SqlDbType.VarChar,50),
					new SqlParameter("@radial_project", SqlDbType.VarChar,20),
					new SqlParameter("@remark", SqlDbType.NVarChar,200),
					new SqlParameter("@lock_table", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@unset1", SqlDbType.VarChar,50),
					new SqlParameter("@unset2", SqlDbType.VarChar,50),
					new SqlParameter("@unset3", SqlDbType.VarChar,50),
					new SqlParameter("@unset4", SqlDbType.VarChar,50),
					new SqlParameter("@unset5", SqlDbType.VarChar,50),
					new SqlParameter("@unset6", SqlDbType.VarChar,50),
					new SqlParameter("@unset7", SqlDbType.VarChar,50),
					new SqlParameter("@unset8", SqlDbType.VarChar,50),
					new SqlParameter("@unset9", SqlDbType.VarChar,50),
					new SqlParameter("@unset10", SqlDbType.VarChar,50),
					new SqlParameter("@unset11", SqlDbType.VarChar,50),
					new SqlParameter("@fill_time", SqlDbType.DateTime),
                    new SqlParameter("@project_community_description", SqlDbType.VarChar,50),
                    new SqlParameter("@main_construct_properties", SqlDbType.VarChar,50),};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.county_name;
			parameters[2].Value = model.after_id;
			parameters[3].Value = model.project_name;
			parameters[4].Value = model.project_type;
			parameters[5].Value = model.year_time;
			parameters[6].Value = model.total_investment;
			parameters[7].Value = model.follow_up_special_founds;
			parameters[8].Value = model.plan_support_founds;
			parameters[9].Value = model.other_matching_founds;
			parameters[10].Value = model.project_owner;
			parameters[11].Value = model.bidding_time;
			parameters[12].Value = model.contract_period;
			parameters[13].Value = model.start_date;
			parameters[14].Value = model.finish_date;
			parameters[15].Value = model.project_lag_reason;
			parameters[16].Value = model.have_quality_safety_incident;
			parameters[17].Value = model.incidents_process_situation;
			parameters[18].Value = model.finish_accept_date;
			parameters[19].Value = model.finish_accept_quality_level;
			parameters[20].Value = model.is_transfer;
			parameters[21].Value = model.radial_project;
			parameters[22].Value = model.remark;
			parameters[23].Value = model.lock_table;
			parameters[24].Value = model.check_status;
			parameters[25].Value = model.unset1;
			parameters[26].Value = model.unset2;
			parameters[27].Value = model.unset3;
			parameters[28].Value = model.unset4;
			parameters[29].Value = model.unset5;
			parameters[30].Value = model.unset6;
			parameters[31].Value = model.unset7;
			parameters[32].Value = model.unset8;
			parameters[33].Value = model.unset9;
			parameters[34].Value = model.unset10;
			parameters[35].Value = model.unset11;
			parameters[36].Value = model.fill_time;
            parameters[37].Value = model.main_construct_properties;
            parameters[38].Value = model.project_community_description;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(TTG.Model.TTGWeb.previously_special_project model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_previously_special_project set ");
			strSql.Append("project_id=@project_id,");
			strSql.Append("county_name=@county_name,");
			strSql.Append("after_id=@after_id,");
			strSql.Append("project_name=@project_name,");
			strSql.Append("project_type=@project_type,");
			strSql.Append("year_time=@year_time,");
			strSql.Append("total_investment=@total_investment,");
			strSql.Append("follow_up_special_founds=@follow_up_special_founds,");
			strSql.Append("plan_support_founds=@plan_support_founds,");
			strSql.Append("other_matching_founds=@other_matching_founds,");
			strSql.Append("project_owner=@project_owner,");
			strSql.Append("bidding_time=@bidding_time,");
			strSql.Append("contract_period=@contract_period,");
			strSql.Append("start_date=@start_date,");
			strSql.Append("finish_date=@finish_date,");
			strSql.Append("project_lag_reason=@project_lag_reason,");
			strSql.Append("have_quality_safety_incident=@have_quality_safety_incident,");
			strSql.Append("incidents_process_situation=@incidents_process_situation,");
			strSql.Append("finish_accept_date=@finish_accept_date,");
			strSql.Append("finish_accept_quality_level=@finish_accept_quality_level,");
			strSql.Append("is_transfer=@is_transfer,");
            strSql.Append("radial_project=@radial_project,");
			strSql.Append("remark=@remark,");
			strSql.Append("lock_table=@lock_table,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("unset1=@unset1,");
			strSql.Append("unset2=@unset2,");
			strSql.Append("unset3=@unset3,");
			strSql.Append("unset4=@unset4,");
			strSql.Append("unset5=@unset5,");
			strSql.Append("unset6=@unset6,");
			strSql.Append("unset7=@unset7,");
			strSql.Append("unset8=@unset8,");
			strSql.Append("unset9=@unset9,");
			strSql.Append("unset10=@unset10,");
			strSql.Append("unset11=@unset11");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,50),
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@after_id", SqlDbType.VarChar,50),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_type", SqlDbType.VarChar,20),
					new SqlParameter("@year_time", SqlDbType.Int,4),
					new SqlParameter("@total_investment", SqlDbType.Float,8),
					new SqlParameter("@follow_up_special_founds", SqlDbType.Float,8),
					new SqlParameter("@plan_support_founds", SqlDbType.Float,8),
					new SqlParameter("@other_matching_founds", SqlDbType.Float,8),
					new SqlParameter("@project_owner", SqlDbType.VarChar,20),
					new SqlParameter("@bidding_time", SqlDbType.DateTime),
					new SqlParameter("@contract_period", SqlDbType.Int,4),
					new SqlParameter("@start_date", SqlDbType.DateTime),
					new SqlParameter("@finish_date", SqlDbType.DateTime),
					new SqlParameter("@project_lag_reason", SqlDbType.NVarChar,200),
					new SqlParameter("@have_quality_safety_incident", SqlDbType.VarChar,50),
					new SqlParameter("@incidents_process_situation", SqlDbType.NVarChar,200),
					new SqlParameter("@finish_accept_date", SqlDbType.DateTime),
					new SqlParameter("@finish_accept_quality_level", SqlDbType.VarChar,50),
					new SqlParameter("@is_transfer", SqlDbType.VarChar,50),
					new SqlParameter("@radial_project", SqlDbType.VarChar,20),
					new SqlParameter("@remark", SqlDbType.NVarChar,200),
					new SqlParameter("@lock_table", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@unset1", SqlDbType.VarChar,50),
					new SqlParameter("@unset2", SqlDbType.VarChar,50),
					new SqlParameter("@unset3", SqlDbType.VarChar,50),
					new SqlParameter("@unset4", SqlDbType.VarChar,50),
					new SqlParameter("@unset5", SqlDbType.VarChar,50),
					new SqlParameter("@unset6", SqlDbType.VarChar,50),
					new SqlParameter("@unset7", SqlDbType.VarChar,50),
					new SqlParameter("@unset8", SqlDbType.VarChar,50),
					new SqlParameter("@unset9", SqlDbType.VarChar,50),
					new SqlParameter("@unset10", SqlDbType.VarChar,50),
					new SqlParameter("@unset11", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@fill_time", SqlDbType.DateTime)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.county_name;
			parameters[2].Value = model.after_id;
			parameters[3].Value = model.project_name;
			parameters[4].Value = model.project_type;
			parameters[5].Value = model.year_time;
			parameters[6].Value = model.total_investment;
			parameters[7].Value = model.follow_up_special_founds;
			parameters[8].Value = model.plan_support_founds;
			parameters[9].Value = model.other_matching_founds;
			parameters[10].Value = model.project_owner;
			parameters[11].Value = model.bidding_time;
			parameters[12].Value = model.contract_period;
			parameters[13].Value = model.start_date;
			parameters[14].Value = model.finish_date;
			parameters[15].Value = model.project_lag_reason;
			parameters[16].Value = model.have_quality_safety_incident;
			parameters[17].Value = model.incidents_process_situation;
			parameters[18].Value = model.finish_accept_date;
			parameters[19].Value = model.finish_accept_quality_level;
			parameters[20].Value = model.is_transfer;
			parameters[21].Value = model.radial_project;
			parameters[22].Value = model.remark;
			parameters[23].Value = model.lock_table;
			parameters[24].Value = model.check_status;
			parameters[25].Value = model.unset1;
			parameters[26].Value = model.unset2;
			parameters[27].Value = model.unset3;
			parameters[28].Value = model.unset4;
			parameters[29].Value = model.unset5;
			parameters[30].Value = model.unset6;
			parameters[31].Value = model.unset7;
			parameters[32].Value = model.unset8;
			parameters[33].Value = model.unset9;
			parameters[34].Value = model.unset10;
			parameters[35].Value = model.unset11;
			parameters[36].Value = model.id;
			parameters[37].Value = model.fill_time;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_previously_special_project ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

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
		public bool Delete(DateTime fill_time,int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_previously_special_project ");
			strSql.Append(" where fill_time=@fill_time and id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = fill_time;
			parameters[1].Value = id;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_previously_special_project ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public TTG.Model.TTGWeb.previously_special_project GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,project_id,county_name,after_id,project_name,project_type,year_time,total_investment,follow_up_special_founds,plan_support_founds,other_matching_founds,project_owner,bidding_time,contract_period,start_date,finish_date,project_lag_reason,have_quality_safety_incident,incidents_process_situation,finish_accept_date,finish_accept_quality_level,is_transfer,project_indirect_serve_community,remark,lock_table,check_status,unset1,unset2,unset3,unset4,unset5,unset6,unset7,unset8,unset9,unset10,unset11,fill_time from T_previously_special_project ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			TTG.Model.TTGWeb.previously_special_project model=new TTG.Model.TTGWeb.previously_special_project();
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
		public TTG.Model.TTGWeb.previously_special_project DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.previously_special_project model=new TTG.Model.TTGWeb.previously_special_project();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["county_name"]!=null)
				{
					model.county_name=row["county_name"].ToString();
				}
				if(row["after_id"]!=null)
				{
					model.after_id=row["after_id"].ToString();
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["project_type"]!=null)
				{
					model.project_type=row["project_type"].ToString();
				}
				if(row["year_time"]!=null && row["year_time"].ToString()!="")
				{
					model.year_time=int.Parse(row["year_time"].ToString());
				}
				if(row["total_investment"]!=null && row["total_investment"].ToString()!="")
				{
					model.total_investment=decimal.Parse(row["total_investment"].ToString());
				}
				if(row["follow_up_special_founds"]!=null && row["follow_up_special_founds"].ToString()!="")
				{
					model.follow_up_special_founds=decimal.Parse(row["follow_up_special_founds"].ToString());
				}
				if(row["plan_support_founds"]!=null && row["plan_support_founds"].ToString()!="")
				{
					model.plan_support_founds=decimal.Parse(row["plan_support_founds"].ToString());
				}
				if(row["other_matching_founds"]!=null && row["other_matching_founds"].ToString()!="")
				{
					model.other_matching_founds=decimal.Parse(row["other_matching_founds"].ToString());
				}
				if(row["project_owner"]!=null)
				{
					model.project_owner=row["project_owner"].ToString();
				}
				if(row["bidding_time"]!=null && row["bidding_time"].ToString()!="")
				{
					model.bidding_time=row["bidding_time"].ToString();
				}
				if(row["contract_period"]!=null && row["contract_period"].ToString()!="")
				{
					model.contract_period=int.Parse(row["contract_period"].ToString());
				}
				if(row["start_date"]!=null && row["start_date"].ToString()!="")
				{
					model.start_date=row["start_date"].ToString();
				}
				if(row["finish_date"]!=null && row["finish_date"].ToString()!="")
				{
					model.finish_date=row["finish_date"].ToString();
				}
				if(row["project_lag_reason"]!=null)
				{
					model.project_lag_reason=row["project_lag_reason"].ToString();
				}
				if(row["have_quality_safety_incident"]!=null)
				{
					model.have_quality_safety_incident=row["have_quality_safety_incident"].ToString();
				}
				if(row["incidents_process_situation"]!=null)
				{
					model.incidents_process_situation=row["incidents_process_situation"].ToString();
				}
				if(row["finish_accept_date"]!=null && row["finish_accept_date"].ToString()!="")
				{
					model.finish_accept_date=DateTime.Parse(row["finish_accept_date"].ToString());
				}
				if(row["finish_accept_quality_level"]!=null)
				{
					model.finish_accept_quality_level=row["finish_accept_quality_level"].ToString();
				}
				if(row["is_transfer"]!=null)
				{
					model.is_transfer=row["is_transfer"].ToString();
				}
				
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["lock_table"]!=null && row["lock_table"].ToString()!="")
				{
					model.lock_table=int.Parse(row["lock_table"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["unset1"]!=null)
				{
					model.unset1=row["unset1"].ToString();
				}
				if(row["unset2"]!=null)
				{
					model.unset2=row["unset2"].ToString();
				}
				if(row["unset3"]!=null)
				{
					model.unset3=row["unset3"].ToString();
				}
				if(row["unset4"]!=null)
				{
					model.unset4=row["unset4"].ToString();
				}
				if(row["unset5"]!=null)
				{
					model.unset5=row["unset5"].ToString();
				}
				if(row["unset6"]!=null)
				{
					model.unset6=row["unset6"].ToString();
				}
				if(row["unset7"]!=null)
				{
					model.unset7=row["unset7"].ToString();
				}
				if(row["unset8"]!=null)
				{
					model.unset8=row["unset8"].ToString();
				}
				if(row["unset9"]!=null)
				{
					model.unset9=row["unset9"].ToString();
				}
				if(row["unset10"]!=null)
				{
					model.unset10=row["unset10"].ToString();
				}
				if(row["unset11"]!=null)
				{
					model.unset11=row["unset11"].ToString();
				}
				if(row["fill_time"]!=null && row["fill_time"].ToString()!="")
				{
					model.fill_time=DateTime.Parse(row["fill_time"].ToString());
				}
                if (row["main_construct_properties"] != null && row["main_construct_properties"].ToString() != "")
                {
                    model.main_construct_properties = row["main_construct_properties"].ToString();
                }
                if (row["project_community_description"] != null && row["project_community_description"].ToString() != "")
                {
                    model.project_community_description = row["project_community_description"].ToString();
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
            strSql.Append("select id,project_id,county_name,after_id,project_name,project_type,year_time,total_investment,follow_up_special_founds,plan_support_founds,other_matching_founds,project_owner,bidding_time,contract_period,start_date,finish_date,project_lag_reason,have_quality_safety_incident,incidents_process_situation,finish_accept_date,finish_accept_quality_level,is_transfer,project_indirect_serve_community,remark,lock_table,check_status,unset1,unset2,unset3,unset4,unset5,unset6,unset7,unset8,unset9,unset10,unset11,fill_time,main_construct_properties,project_community_description ");
			strSql.Append(" FROM T_previously_special_project ");
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
            strSql.Append(" id,project_id,county_name,after_id,project_name,project_type,year_time,total_investment,follow_up_special_founds,plan_support_founds,other_matching_founds,project_owner,bidding_time,contract_period,start_date,finish_date,project_lag_reason,have_quality_safety_incident,incidents_process_situation,finish_accept_date,finish_accept_quality_level,is_transfer,project_indirect_serve_community,remark,lock_table,check_status,unset1,unset2,unset3,unset4,unset5,unset6,unset7,unset8,unset9,unset10,unset11,fill_time,main_construct_properties,project_community_description");
			strSql.Append(" FROM T_previously_special_project ");
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
			strSql.Append("select count(1) FROM T_previously_special_project ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from T_previously_special_project T ");
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
			parameters[0].Value = "T_previously_special_project";
			parameters[1].Value = "id";
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
        /// 获取county县在year年份的项目数量
        /// </summary>
        /// <param name="county">区县名</param>
        /// <param name="year">项目年份</param>
        /// <returns>项目数目</returns>
        public int GetProjectCount(string county, int year)
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@county", SqlDbType.VarChar, 50),
                                            new SqlParameter("@year", SqlDbType.Int, 4)
                                        };
            parameters[0].Value = county;
            parameters[1].Value = year;
            string sql = "select count(distinct project_id) from T_previously_special_project where county_name = @county and year_time = @year";
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql, parameters));
        }
		#endregion  ExtensionMethod
	}
}

