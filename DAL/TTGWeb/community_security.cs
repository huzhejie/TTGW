using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_security
	/// </summary>
	public partial class community_security
	{
		public community_security()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_security");
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
		public bool Add(TTG.Model.TTGWeb.community_security model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_security(");
			strSql.Append("community_id,community_unit_can_build_guard_room_num,community_unit_with_guard_room_num,community_unit_can_install_mf_num,community_unit_with_mf_num,community_unit_can_build_fence_num,community_unit_with_fence_num,community_emergency_shelter_area,community_civil_air_defence_facilities_num,community_civil_air_defence_facilities_area,statistics_date,community_unit_can_build_gate_num,community_with_gate_num,tcsunset1,tcsunset2,tcsunset3,tcsunset4,tcsunset5,tcsunset6,tcsunset7,tcsunset8,tcsunset9,tcsunset10,tcsunset11,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_unit_can_build_guard_room_num,@community_unit_with_guard_room_num,@community_unit_can_install_mf_num,@community_unit_with_mf_num,@community_unit_can_build_fence_num,@community_unit_with_fence_num,@community_emergency_shelter_area,@community_civil_air_defence_facilities_num,@community_civil_air_defence_facilities_area,@statistics_date,@community_unit_can_build_gate_num,@community_with_gate_num,@tcsunset1,@tcsunset2,@tcsunset3,@tcsunset4,@tcsunset5,@tcsunset6,@tcsunset7,@tcsunset8,@tcsunset9,@tcsunset10,@tcsunset11,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_unit_can_build_guard_room_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_with_guard_room_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_can_install_mf_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_with_mf_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_can_build_fence_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_with_fence_num", SqlDbType.Int,4),
					new SqlParameter("@community_emergency_shelter_area", SqlDbType.Float,8),
					new SqlParameter("@community_civil_air_defence_facilities_num", SqlDbType.Int,4),
					new SqlParameter("@community_civil_air_defence_facilities_area", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@community_unit_can_build_gate_num", SqlDbType.Int,4),
					new SqlParameter("@community_with_gate_num", SqlDbType.Int,4),
					new SqlParameter("@tcsunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset11", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_unit_can_build_guard_room_num;
			parameters[2].Value = model.community_unit_with_guard_room_num;
			parameters[3].Value = model.community_unit_can_install_mf_num;
			parameters[4].Value = model.community_unit_with_mf_num;
			parameters[5].Value = model.community_unit_can_build_fence_num;
			parameters[6].Value = model.community_unit_with_fence_num;
			parameters[7].Value = model.community_emergency_shelter_area;
			parameters[8].Value = model.community_civil_air_defence_facilities_num;
			parameters[9].Value = model.community_civil_air_defence_facilities_area;
			parameters[10].Value = model.statistics_date;
			parameters[11].Value = model.community_unit_can_build_gate_num;
			parameters[12].Value = model.community_with_gate_num;
			parameters[13].Value = model.tcsunset1;
			parameters[14].Value = model.tcsunset2;
			parameters[15].Value = model.tcsunset3;
			parameters[16].Value = model.tcsunset4;
			parameters[17].Value = model.tcsunset5;
			parameters[18].Value = model.tcsunset6;
			parameters[19].Value = model.tcsunset7;
			parameters[20].Value = model.tcsunset8;
			parameters[21].Value = model.tcsunset9;
			parameters[22].Value = model.tcsunset10;
			parameters[23].Value = model.tcsunset11;
			parameters[24].Value = model.lock_tables;
			parameters[25].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_security model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_security set ");
			strSql.Append("community_unit_can_build_guard_room_num=@community_unit_can_build_guard_room_num,");
			strSql.Append("community_unit_with_guard_room_num=@community_unit_with_guard_room_num,");
			strSql.Append("community_unit_can_install_mf_num=@community_unit_can_install_mf_num,");
			strSql.Append("community_unit_with_mf_num=@community_unit_with_mf_num,");
			strSql.Append("community_unit_can_build_fence_num=@community_unit_can_build_fence_num,");
			strSql.Append("community_unit_with_fence_num=@community_unit_with_fence_num,");
			strSql.Append("community_emergency_shelter_area=@community_emergency_shelter_area,");
			strSql.Append("community_civil_air_defence_facilities_num=@community_civil_air_defence_facilities_num,");
			strSql.Append("community_civil_air_defence_facilities_area=@community_civil_air_defence_facilities_area,");
			strSql.Append("community_unit_can_build_gate_num=@community_unit_can_build_gate_num,");
			strSql.Append("community_with_gate_num=@community_with_gate_num,");
			strSql.Append("tcsunset1=@tcsunset1,");
			strSql.Append("tcsunset2=@tcsunset2,");
			strSql.Append("tcsunset3=@tcsunset3,");
			strSql.Append("tcsunset4=@tcsunset4,");
			strSql.Append("tcsunset5=@tcsunset5,");
			strSql.Append("tcsunset6=@tcsunset6,");
			strSql.Append("tcsunset7=@tcsunset7,");
			strSql.Append("tcsunset8=@tcsunset8,");
			strSql.Append("tcsunset9=@tcsunset9,");
			strSql.Append("tcsunset10=@tcsunset10,");
			strSql.Append("tcsunset11=@tcsunset11,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_unit_can_build_guard_room_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_with_guard_room_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_can_install_mf_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_with_mf_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_can_build_fence_num", SqlDbType.Int,4),
					new SqlParameter("@community_unit_with_fence_num", SqlDbType.Int,4),
					new SqlParameter("@community_emergency_shelter_area", SqlDbType.Float,8),
					new SqlParameter("@community_civil_air_defence_facilities_num", SqlDbType.Int,4),
					new SqlParameter("@community_civil_air_defence_facilities_area", SqlDbType.Float,8),
					new SqlParameter("@community_unit_can_build_gate_num", SqlDbType.Int,4),
					new SqlParameter("@community_with_gate_num", SqlDbType.Int,4),
					new SqlParameter("@tcsunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcsunset11", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_unit_can_build_guard_room_num;
			parameters[1].Value = model.community_unit_with_guard_room_num;
			parameters[2].Value = model.community_unit_can_install_mf_num;
			parameters[3].Value = model.community_unit_with_mf_num;
			parameters[4].Value = model.community_unit_can_build_fence_num;
			parameters[5].Value = model.community_unit_with_fence_num;
			parameters[6].Value = model.community_emergency_shelter_area;
			parameters[7].Value = model.community_civil_air_defence_facilities_num;
			parameters[8].Value = model.community_civil_air_defence_facilities_area;
			parameters[9].Value = model.community_unit_can_build_gate_num;
			parameters[10].Value = model.community_with_gate_num;
			parameters[11].Value = model.tcsunset1;
			parameters[12].Value = model.tcsunset2;
			parameters[13].Value = model.tcsunset3;
			parameters[14].Value = model.tcsunset4;
			parameters[15].Value = model.tcsunset5;
			parameters[16].Value = model.tcsunset6;
			parameters[17].Value = model.tcsunset7;
			parameters[18].Value = model.tcsunset8;
			parameters[19].Value = model.tcsunset9;
			parameters[20].Value = model.tcsunset10;
			parameters[21].Value = model.tcsunset11;
			parameters[22].Value = model.lock_tables;
			parameters[23].Value = model.check_status;
			parameters[24].Value = model.community_id;
			parameters[25].Value = model.statistics_date;

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
			strSql.Append("delete from T_community_security ");
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
		public TTG.Model.TTGWeb.community_security GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_unit_can_build_guard_room_num,community_unit_with_guard_room_num,community_unit_can_install_mf_num,community_unit_with_mf_num,community_unit_can_build_fence_num,community_unit_with_fence_num,community_emergency_shelter_area,community_civil_air_defence_facilities_num,community_civil_air_defence_facilities_area,statistics_date,community_unit_can_build_gate_num,community_with_gate_num,tcsunset1,tcsunset2,tcsunset3,tcsunset4,tcsunset5,tcsunset6,tcsunset7,tcsunset8,tcsunset9,tcsunset10,tcsunset11,lock_tables,check_status from T_community_security ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_security model=new TTG.Model.TTGWeb.community_security();
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
		public TTG.Model.TTGWeb.community_security DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_security model=new TTG.Model.TTGWeb.community_security();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_unit_can_build_guard_room_num"]!=null && row["community_unit_can_build_guard_room_num"].ToString()!="")
				{
					model.community_unit_can_build_guard_room_num=int.Parse(row["community_unit_can_build_guard_room_num"].ToString());
				}
				if(row["community_unit_with_guard_room_num"]!=null && row["community_unit_with_guard_room_num"].ToString()!="")
				{
					model.community_unit_with_guard_room_num=int.Parse(row["community_unit_with_guard_room_num"].ToString());
				}
				if(row["community_unit_can_install_mf_num"]!=null && row["community_unit_can_install_mf_num"].ToString()!="")
				{
					model.community_unit_can_install_mf_num=int.Parse(row["community_unit_can_install_mf_num"].ToString());
				}
				if(row["community_unit_with_mf_num"]!=null && row["community_unit_with_mf_num"].ToString()!="")
				{
					model.community_unit_with_mf_num=int.Parse(row["community_unit_with_mf_num"].ToString());
				}
				if(row["community_unit_can_build_fence_num"]!=null && row["community_unit_can_build_fence_num"].ToString()!="")
				{
					model.community_unit_can_build_fence_num=int.Parse(row["community_unit_can_build_fence_num"].ToString());
				}
				if(row["community_unit_with_fence_num"]!=null && row["community_unit_with_fence_num"].ToString()!="")
				{
					model.community_unit_with_fence_num=int.Parse(row["community_unit_with_fence_num"].ToString());
				}
				if(row["community_emergency_shelter_area"]!=null && row["community_emergency_shelter_area"].ToString()!="")
				{
					model.community_emergency_shelter_area=decimal.Parse(row["community_emergency_shelter_area"].ToString());
				}
				if(row["community_civil_air_defence_facilities_num"]!=null && row["community_civil_air_defence_facilities_num"].ToString()!="")
				{
					model.community_civil_air_defence_facilities_num=int.Parse(row["community_civil_air_defence_facilities_num"].ToString());
				}
				if(row["community_civil_air_defence_facilities_area"]!=null && row["community_civil_air_defence_facilities_area"].ToString()!="")
				{
					model.community_civil_air_defence_facilities_area=decimal.Parse(row["community_civil_air_defence_facilities_area"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["community_unit_can_build_gate_num"]!=null && row["community_unit_can_build_gate_num"].ToString()!="")
				{
					model.community_unit_can_build_gate_num=int.Parse(row["community_unit_can_build_gate_num"].ToString());
				}
				if(row["community_with_gate_num"]!=null && row["community_with_gate_num"].ToString()!="")
				{
					model.community_with_gate_num=int.Parse(row["community_with_gate_num"].ToString());
				}
				if(row["tcsunset1"]!=null)
				{
					model.tcsunset1=row["tcsunset1"].ToString();
				}
				if(row["tcsunset2"]!=null)
				{
					model.tcsunset2=row["tcsunset2"].ToString();
				}
				if(row["tcsunset3"]!=null)
				{
					model.tcsunset3=row["tcsunset3"].ToString();
				}
				if(row["tcsunset4"]!=null)
				{
					model.tcsunset4=row["tcsunset4"].ToString();
				}
				if(row["tcsunset5"]!=null)
				{
					model.tcsunset5=row["tcsunset5"].ToString();
				}
				if(row["tcsunset6"]!=null)
				{
					model.tcsunset6=row["tcsunset6"].ToString();
				}
				if(row["tcsunset7"]!=null)
				{
					model.tcsunset7=row["tcsunset7"].ToString();
				}
				if(row["tcsunset8"]!=null)
				{
					model.tcsunset8=row["tcsunset8"].ToString();
				}
				if(row["tcsunset9"]!=null)
				{
					model.tcsunset9=row["tcsunset9"].ToString();
				}
				if(row["tcsunset10"]!=null)
				{
					model.tcsunset10=row["tcsunset10"].ToString();
				}
				if(row["tcsunset11"]!=null)
				{
					model.tcsunset11=row["tcsunset11"].ToString();
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
			strSql.Append("select community_id,community_unit_can_build_guard_room_num,community_unit_with_guard_room_num,community_unit_can_install_mf_num,community_unit_with_mf_num,community_unit_can_build_fence_num,community_unit_with_fence_num,community_emergency_shelter_area,community_civil_air_defence_facilities_num,community_civil_air_defence_facilities_area,statistics_date,community_unit_can_build_gate_num,community_with_gate_num,tcsunset1,tcsunset2,tcsunset3,tcsunset4,tcsunset5,tcsunset6,tcsunset7,tcsunset8,tcsunset9,tcsunset10,tcsunset11,lock_tables,check_status ");
			strSql.Append(" FROM T_community_security ");
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
			strSql.Append(" community_id,community_unit_can_build_guard_room_num,community_unit_with_guard_room_num,community_unit_can_install_mf_num,community_unit_with_mf_num,community_unit_can_build_fence_num,community_unit_with_fence_num,community_emergency_shelter_area,community_civil_air_defence_facilities_num,community_civil_air_defence_facilities_area,statistics_date,community_unit_can_build_gate_num,community_with_gate_num,tcsunset1,tcsunset2,tcsunset3,tcsunset4,tcsunset5,tcsunset6,tcsunset7,tcsunset8,tcsunset9,tcsunset10,tcsunset11,lock_tables,check_status ");
			strSql.Append(" FROM T_community_security ");
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
			strSql.Append("select count(1) FROM T_community_security ");
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
			strSql.Append(")AS Row, T.*  from T_community_security T ");
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
			parameters[0].Value = "T_community_security";
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

