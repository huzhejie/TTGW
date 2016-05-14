using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_greening_problem_finished
	/// </summary>
	public partial class community_greening_problem_finished
	{
		public community_greening_problem_finished()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date,string project_name)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_greening_problem_finished");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;
			parameters[2].Value = project_name;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_greening_problem_finished model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_greening_problem_finished(");
			strSql.Append("community_id,community_added_road_resi_green_tree_num,community_added_road_resi_green_area,community_govern_green_tree_num,community_govern_green_area,community_small_garden_num,community_small_garden_area,community_park_num,community_park_area,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,lock_tables,project_name)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_added_road_resi_green_tree_num,@community_added_road_resi_green_area,@community_govern_green_tree_num,@community_govern_green_area,@community_small_garden_num,@community_small_garden_area,@community_park_num,@community_park_area,@statistics_date,@check_status,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@tciunset7,@tciunset8,@tciunset9,@tciunset10,@lock_tables,@project_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_added_road_resi_green_tree_num", SqlDbType.Int,4),
					new SqlParameter("@community_added_road_resi_green_area", SqlDbType.Float,8),
					new SqlParameter("@community_govern_green_tree_num", SqlDbType.Int,4),
					new SqlParameter("@community_govern_green_area", SqlDbType.Float,8),
					new SqlParameter("@community_small_garden_num", SqlDbType.Int,4),
					new SqlParameter("@community_small_garden_area", SqlDbType.Float,8),
					new SqlParameter("@community_park_num", SqlDbType.Int,4),
					new SqlParameter("@community_park_area", SqlDbType.Float,8),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset10", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_added_road_resi_green_tree_num;
			parameters[2].Value = model.community_added_road_resi_green_area;
			parameters[3].Value = model.community_govern_green_tree_num;
			parameters[4].Value = model.community_govern_green_area;
			parameters[5].Value = model.community_small_garden_num;
			parameters[6].Value = model.community_small_garden_area;
			parameters[7].Value = model.community_park_num;
			parameters[8].Value = model.community_park_area;
			parameters[9].Value = model.statistics_date;
			parameters[10].Value = model.check_status;
			parameters[11].Value = model.tciunset1;
			parameters[12].Value = model.tciunset2;
			parameters[13].Value = model.tciunset3;
			parameters[14].Value = model.tciunset4;
			parameters[15].Value = model.tciunset5;
			parameters[16].Value = model.tciunset6;
			parameters[17].Value = model.tciunset7;
			parameters[18].Value = model.tciunset8;
			parameters[19].Value = model.tciunset9;
			parameters[20].Value = model.tciunset10;
			parameters[21].Value = model.lock_tables;
			parameters[22].Value = model.project_name;

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
		public bool Update(TTG.Model.TTGWeb.community_greening_problem_finished model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_greening_problem_finished set ");
			strSql.Append("community_added_road_resi_green_tree_num=@community_added_road_resi_green_tree_num,");
			strSql.Append("community_added_road_resi_green_area=@community_added_road_resi_green_area,");
			strSql.Append("community_govern_green_tree_num=@community_govern_green_tree_num,");
			strSql.Append("community_govern_green_area=@community_govern_green_area,");
			strSql.Append("community_small_garden_num=@community_small_garden_num,");
			strSql.Append("community_small_garden_area=@community_small_garden_area,");
			strSql.Append("community_park_num=@community_park_num,");
			strSql.Append("community_park_area=@community_park_area,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("tciunset1=@tciunset1,");
			strSql.Append("tciunset2=@tciunset2,");
			strSql.Append("tciunset3=@tciunset3,");
			strSql.Append("tciunset4=@tciunset4,");
			strSql.Append("tciunset5=@tciunset5,");
			strSql.Append("tciunset6=@tciunset6,");
			strSql.Append("tciunset7=@tciunset7,");
			strSql.Append("tciunset8=@tciunset8,");
			strSql.Append("tciunset9=@tciunset9,");
			strSql.Append("tciunset10=@tciunset10,");
			strSql.Append("lock_tables=@lock_tables");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_added_road_resi_green_tree_num", SqlDbType.Int,4),
					new SqlParameter("@community_added_road_resi_green_area", SqlDbType.Float,8),
					new SqlParameter("@community_govern_green_tree_num", SqlDbType.Int,4),
					new SqlParameter("@community_govern_green_area", SqlDbType.Float,8),
					new SqlParameter("@community_small_garden_num", SqlDbType.Int,4),
					new SqlParameter("@community_small_garden_area", SqlDbType.Float,8),
					new SqlParameter("@community_park_num", SqlDbType.Int,4),
					new SqlParameter("@community_park_area", SqlDbType.Float,8),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@tciunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset10", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_added_road_resi_green_tree_num;
			parameters[1].Value = model.community_added_road_resi_green_area;
			parameters[2].Value = model.community_govern_green_tree_num;
			parameters[3].Value = model.community_govern_green_area;
			parameters[4].Value = model.community_small_garden_num;
			parameters[5].Value = model.community_small_garden_area;
			parameters[6].Value = model.community_park_num;
			parameters[7].Value = model.community_park_area;
			parameters[8].Value = model.check_status;
			parameters[9].Value = model.tciunset1;
			parameters[10].Value = model.tciunset2;
			parameters[11].Value = model.tciunset3;
			parameters[12].Value = model.tciunset4;
			parameters[13].Value = model.tciunset5;
			parameters[14].Value = model.tciunset6;
			parameters[15].Value = model.tciunset7;
			parameters[16].Value = model.tciunset8;
			parameters[17].Value = model.tciunset9;
			parameters[18].Value = model.tciunset10;
			parameters[19].Value = model.lock_tables;
			parameters[20].Value = model.community_id;
			parameters[21].Value = model.statistics_date;
			parameters[22].Value = model.project_name;

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
		public bool Delete(string community_id,DateTime statistics_date,string project_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_greening_problem_finished ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;
			parameters[2].Value = project_name;

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
		public TTG.Model.TTGWeb.community_greening_problem_finished GetModel(string community_id,DateTime statistics_date,string project_name)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_added_road_resi_green_tree_num,community_added_road_resi_green_area,community_govern_green_tree_num,community_govern_green_area,community_small_garden_num,community_small_garden_area,community_park_num,community_park_area,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,lock_tables,project_name from T_community_greening_problem_finished ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date and project_name=@project_name ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@project_name", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;
			parameters[2].Value = project_name;

			TTG.Model.TTGWeb.community_greening_problem_finished model=new TTG.Model.TTGWeb.community_greening_problem_finished();
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
		public TTG.Model.TTGWeb.community_greening_problem_finished DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_greening_problem_finished model=new TTG.Model.TTGWeb.community_greening_problem_finished();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_added_road_resi_green_tree_num"]!=null && row["community_added_road_resi_green_tree_num"].ToString()!="")
				{
					model.community_added_road_resi_green_tree_num=int.Parse(row["community_added_road_resi_green_tree_num"].ToString());
				}
				if(row["community_added_road_resi_green_area"]!=null && row["community_added_road_resi_green_area"].ToString()!="")
				{
					model.community_added_road_resi_green_area=decimal.Parse(row["community_added_road_resi_green_area"].ToString());
				}
				if(row["community_govern_green_tree_num"]!=null && row["community_govern_green_tree_num"].ToString()!="")
				{
					model.community_govern_green_tree_num=int.Parse(row["community_govern_green_tree_num"].ToString());
				}
				if(row["community_govern_green_area"]!=null && row["community_govern_green_area"].ToString()!="")
				{
					model.community_govern_green_area=decimal.Parse(row["community_govern_green_area"].ToString());
				}
				if(row["community_small_garden_num"]!=null && row["community_small_garden_num"].ToString()!="")
				{
					model.community_small_garden_num=int.Parse(row["community_small_garden_num"].ToString());
				}
				if(row["community_small_garden_area"]!=null && row["community_small_garden_area"].ToString()!="")
				{
					model.community_small_garden_area=decimal.Parse(row["community_small_garden_area"].ToString());
				}
				if(row["community_park_num"]!=null && row["community_park_num"].ToString()!="")
				{
					model.community_park_num=int.Parse(row["community_park_num"].ToString());
				}
				if(row["community_park_area"]!=null && row["community_park_area"].ToString()!="")
				{
					model.community_park_area=decimal.Parse(row["community_park_area"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["tciunset1"]!=null)
				{
					model.tciunset1=row["tciunset1"].ToString();
				}
				if(row["tciunset2"]!=null)
				{
					model.tciunset2=row["tciunset2"].ToString();
				}
				if(row["tciunset3"]!=null)
				{
					model.tciunset3=row["tciunset3"].ToString();
				}
				if(row["tciunset4"]!=null)
				{
					model.tciunset4=row["tciunset4"].ToString();
				}
				if(row["tciunset5"]!=null)
				{
					model.tciunset5=row["tciunset5"].ToString();
				}
				if(row["tciunset6"]!=null)
				{
					model.tciunset6=row["tciunset6"].ToString();
				}
				if(row["tciunset7"]!=null)
				{
					model.tciunset7=row["tciunset7"].ToString();
				}
				if(row["tciunset8"]!=null)
				{
					model.tciunset8=row["tciunset8"].ToString();
				}
				if(row["tciunset9"]!=null)
				{
					model.tciunset9=row["tciunset9"].ToString();
				}
				if(row["tciunset10"]!=null)
				{
					model.tciunset10=row["tciunset10"].ToString();
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
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
			strSql.Append("select community_id,community_added_road_resi_green_tree_num,community_added_road_resi_green_area,community_govern_green_tree_num,community_govern_green_area,community_small_garden_num,community_small_garden_area,community_park_num,community_park_area,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,lock_tables,project_name ");
			strSql.Append(" FROM T_community_greening_problem_finished ");
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
			strSql.Append(" community_id,community_added_road_resi_green_tree_num,community_added_road_resi_green_area,community_govern_green_tree_num,community_govern_green_area,community_small_garden_num,community_small_garden_area,community_park_num,community_park_area,statistics_date,check_status,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,lock_tables,project_name ");
			strSql.Append(" FROM T_community_greening_problem_finished ");
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
			strSql.Append("select count(1) FROM T_community_greening_problem_finished ");
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
				strSql.Append("order by T.project_name desc");
			}
			strSql.Append(")AS Row, T.*  from T_community_greening_problem_finished T ");
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
			parameters[0].Value = "T_community_greening_problem_finished";
			parameters[1].Value = "project_name";
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

