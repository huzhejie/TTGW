using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:project_physical
	/// </summary>
	public partial class project_physical
	{
		public project_physical()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string project_id,DateTime fill_time)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_project_physical");
			strSql.Append(" where project_id=@project_id and fill_time=@fill_time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@fill_time", SqlDbType.DateTime)			};
			parameters[0].Value = project_id;
			parameters[1].Value = fill_time;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.project_physical model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_project_physical(");
			strSql.Append("project_id,county_name,project_name,project_time,project_investment_type,sub_project_id,sub_project_name,community,physical_class,physical_subclass,physical_class_content,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,check_status,lock_tables,summary,solve_question_objects,improve_objects,last_year_quantity,year,june_quantity,december_quantity,remark,fill_time)");
			strSql.Append(" values (");
            strSql.Append("@project_id,@county_name,@project_name,@project_time,@project_investment_type,@sub_project_id,@sub_project_name,@community,@physical_class,@physical_subclass,@physical_class_content,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@tciunset7,@tciunset8,@tciunset9,@tciunset10,@tciunset11,@tciunset12,@tciunset13,@tciunset14,@check_status,@lock_tables,@summary,@solve_question_objects,@improve_objects,@last_year_quantity,@year,@june_quantity,@december_quantity,@remark,@fill_time)");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_time", SqlDbType.Int,4),
					new SqlParameter("@project_investment_type", SqlDbType.VarChar,20),
					new SqlParameter("@sub_project_id", SqlDbType.VarChar,50),
					new SqlParameter("@sub_project_name", SqlDbType.VarChar,100),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@physical_class", SqlDbType.VarChar,20),
					new SqlParameter("@physical_subclass", SqlDbType.VarChar,20),
					new SqlParameter("@physical_class_content", SqlDbType.VarChar,100),
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
					new SqlParameter("@tciunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset14", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@summary", SqlDbType.Float,8),
					new SqlParameter("@solve_question_objects", SqlDbType.Float,8),
					new SqlParameter("@improve_objects", SqlDbType.Float,8),
					new SqlParameter("@last_year_quantity", SqlDbType.Float,8),
					new SqlParameter("@year", SqlDbType.Int,4),
					new SqlParameter("@june_quantity", SqlDbType.Float,8),
					new SqlParameter("@december_quantity", SqlDbType.Float,8),
					new SqlParameter("@remark", SqlDbType.NVarChar,200),
					new SqlParameter("@fill_time", SqlDbType.DateTime)};
			parameters[0].Value = model.project_id;
			parameters[1].Value = model.county_name;
			parameters[2].Value = model.project_name;
			parameters[3].Value = model.project_time;
			parameters[4].Value = model.project_investment_type;
			parameters[5].Value = model.sub_project_id;
			parameters[6].Value = model.sub_project_name;
			parameters[7].Value = model.community;
			parameters[8].Value = model.physical_class;
			parameters[9].Value = model.physical_subclass;
			parameters[10].Value = model.physical_class_content;
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
			parameters[21].Value = model.tciunset11;
			parameters[22].Value = model.tciunset12;
			parameters[23].Value = model.tciunset13;
			parameters[24].Value = model.tciunset14;
			parameters[25].Value = model.check_status;
			parameters[26].Value = model.lock_tables;
			parameters[27].Value = model.summary;
			parameters[28].Value = model.solve_question_objects;
			parameters[29].Value = model.improve_objects;
			parameters[30].Value = model.last_year_quantity;
			parameters[31].Value = model.year;
			parameters[32].Value = model.june_quantity;
			parameters[33].Value = model.december_quantity;
			parameters[34].Value = model.remark;
			parameters[35].Value = model.fill_time;

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
		public bool Update(TTG.Model.TTGWeb.project_physical model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_project_physical set ");
			strSql.Append("county_name=@county_name,");
			strSql.Append("project_name=@project_name,");
			strSql.Append("project_time=@project_time,");
			strSql.Append("project_investment_type=@project_investment_type,");
			strSql.Append("sub_project_id=@sub_project_id,");
			strSql.Append("sub_project_name=@sub_project_name,");
			strSql.Append("community=@community,");
			strSql.Append("physical_class=@physical_class,");
			strSql.Append("physical_subclass=@physical_subclass,");
			strSql.Append("physical_class_content=@physical_class_content,");
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
			strSql.Append("tciunset11=@tciunset11,");
			strSql.Append("tciunset12=@tciunset12,");
			strSql.Append("tciunset13=@tciunset13,");
			strSql.Append("tciunset14=@tciunset14,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("summary=@summary,");
            strSql.Append("solve_question_objects=@solve_question_objects,");
            strSql.Append("improve_objects=@improve_objects,");
			strSql.Append("last_year_quantity=@last_year_quantity,");
			strSql.Append("year=@year,");
			strSql.Append("june_quantity=@june_quantity,");
			strSql.Append("december_quantity=@december_quantity,");
			strSql.Append("remark=@remark");
			strSql.Append(" where project_id=@project_id and fill_time=@fill_time ");
			SqlParameter[] parameters = {
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_time", SqlDbType.Int,4),
					new SqlParameter("@project_investment_type", SqlDbType.VarChar,20),
					new SqlParameter("@sub_project_id", SqlDbType.VarChar,50),
					new SqlParameter("@sub_project_name", SqlDbType.VarChar,100),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@physical_class", SqlDbType.VarChar,20),
					new SqlParameter("@physical_subclass", SqlDbType.VarChar,20),
					new SqlParameter("@physical_class_content", SqlDbType.VarChar,100),
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
					new SqlParameter("@tciunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset13", SqlDbType.VarChar,50),
					new SqlParameter("@tciunset14", SqlDbType.VarChar,50),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@summary", SqlDbType.Float,8),
					new SqlParameter("@solve_question_objects", SqlDbType.Float,8),
					new SqlParameter("@improve_objects", SqlDbType.Float,8),
					new SqlParameter("@last_year_quantity", SqlDbType.Float,8),
					new SqlParameter("@year", SqlDbType.Int,4),
					new SqlParameter("@june_quantity", SqlDbType.Float,8),
					new SqlParameter("@december_quantity", SqlDbType.Float,8),
					new SqlParameter("@remark", SqlDbType.NVarChar,200),
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@fill_time", SqlDbType.DateTime)};
			parameters[0].Value = model.county_name;
			parameters[1].Value = model.project_name;
			parameters[2].Value = model.project_time;
			parameters[3].Value = model.project_investment_type;
			parameters[4].Value = model.sub_project_id;
			parameters[5].Value = model.sub_project_name;
			parameters[6].Value = model.community;
			parameters[7].Value = model.physical_class;
			parameters[8].Value = model.physical_subclass;
			parameters[9].Value = model.physical_class_content;
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
			parameters[21].Value = model.tciunset11;
			parameters[22].Value = model.tciunset12;
			parameters[23].Value = model.tciunset13;
			parameters[24].Value = model.tciunset14;
			parameters[25].Value = model.check_status;
			parameters[26].Value = model.lock_tables;
			parameters[27].Value = model.summary;
			parameters[28].Value = model.solve_question_objects;
			parameters[29].Value = model.improve_objects;
			parameters[30].Value = model.last_year_quantity;
			parameters[31].Value = model.year;
			parameters[32].Value = model.june_quantity;
			parameters[33].Value = model.december_quantity;
			parameters[34].Value = model.remark;
			parameters[35].Value = model.project_id;
			parameters[36].Value = model.fill_time;

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
		public bool Delete(string project_id,DateTime fill_time)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_project_physical ");
			strSql.Append(" where project_id=@project_id and fill_time=@fill_time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@fill_time", SqlDbType.DateTime)			};
			parameters[0].Value = project_id;
			parameters[1].Value = fill_time;

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
		public TTG.Model.TTGWeb.project_physical GetModel(string project_id,DateTime fill_time)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 project_id,county_name,project_name,project_time,project_investment_type,sub_project_id,sub_project_name,community,physical_class,physical_subclass,physical_class_content,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,check_status,lock_tables,summary,solve_question_objects,improve_objects,last_year_quantity,year,june_quantity,december_quantity,remark,fill_time from T_project_physical ");
			strSql.Append(" where project_id=@project_id and fill_time=@fill_time ");
			SqlParameter[] parameters = {
					new SqlParameter("@project_id", SqlDbType.VarChar,20),
					new SqlParameter("@fill_time", SqlDbType.DateTime)			};
			parameters[0].Value = project_id;
			parameters[1].Value = fill_time;

			TTG.Model.TTGWeb.project_physical model=new TTG.Model.TTGWeb.project_physical();
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
		public TTG.Model.TTGWeb.project_physical DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.project_physical model=new TTG.Model.TTGWeb.project_physical();
			if (row != null)
			{
				if(row["project_id"]!=null)
				{
					model.project_id=row["project_id"].ToString();
				}
				if(row["county_name"]!=null)
				{
					model.county_name=row["county_name"].ToString();
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["project_time"]!=null && row["project_time"].ToString()!="")
				{
					model.project_time=int.Parse(row["project_time"].ToString());
				}
				if(row["project_investment_type"]!=null)
				{
					model.project_investment_type=row["project_investment_type"].ToString();
				}
				if(row["sub_project_id"]!=null)
				{
					model.sub_project_id=row["sub_project_id"].ToString();
				}
				if(row["sub_project_name"]!=null)
				{
					model.sub_project_name=row["sub_project_name"].ToString();
				}
				if(row["community"]!=null)
				{
					model.community=row["community"].ToString();
				}
				if(row["physical_class"]!=null)
				{
					model.physical_class=row["physical_class"].ToString();
				}
				if(row["physical_subclass"]!=null)
				{
					model.physical_subclass=row["physical_subclass"].ToString();
				}
				if(row["physical_class_content"]!=null)
				{
					model.physical_class_content=row["physical_class_content"].ToString();
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
				if(row["tciunset11"]!=null)
				{
					model.tciunset11=row["tciunset11"].ToString();
				}
				if(row["tciunset12"]!=null)
				{
					model.tciunset12=row["tciunset12"].ToString();
				}
				if(row["tciunset13"]!=null)
				{
					model.tciunset13=row["tciunset13"].ToString();
				}
				if(row["tciunset14"]!=null)
				{
					model.tciunset14=row["tciunset14"].ToString();
				}
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["summary"]!=null && row["summary"].ToString()!="")
				{
                    model.summary = decimal.Parse(row["summary"].ToString());
				}
				if(row["solve_question_objects"]!=null&&row["solve_question_objects"].ToString()!="")
				{
                    model.solve_question_objects = decimal.Parse(row["solve_question_objects"].ToString());
				}
                if (row["improve_objects"] != null && row["improve_objects"].ToString() != "")
				{
                    model.improve_objects = decimal.Parse(row["improve_objects"].ToString());
				}
				if(row["last_year_quantity"]!=null && row["last_year_quantity"].ToString()!="")
				{
					model.last_year_quantity=decimal.Parse(row["last_year_quantity"].ToString());
				}
				if(row["year"]!=null && row["year"].ToString()!="")
				{
					model.year=int.Parse(row["year"].ToString());
				}
				if(row["june_quantity"]!=null && row["june_quantity"].ToString()!="")
				{
					model.june_quantity=decimal.Parse(row["june_quantity"].ToString());
				}
				if(row["december_quantity"]!=null && row["december_quantity"].ToString()!="")
				{
					model.december_quantity=decimal.Parse(row["december_quantity"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["fill_time"]!=null && row["fill_time"].ToString()!="")
				{
					model.fill_time=DateTime.Parse(row["fill_time"].ToString());
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
            strSql.Append("select project_id,county_name,project_name,project_time,project_investment_type,sub_project_id,sub_project_name,community,physical_class,physical_subclass,physical_class_content,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,check_status,lock_tables,summary,solve_question_objects,improve_objects,last_year_quantity,year,june_quantity,december_quantity,remark,fill_time ");
			strSql.Append(" FROM T_project_physical ");
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
            strSql.Append(" project_id,county_name,project_name,project_time,project_investment_type,sub_project_id,sub_project_name,community,physical_class,physical_subclass,physical_class_content,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,tciunset14,check_status,lock_tables,summary,solve_question_objects,improve_objects,last_year_quantity,year,june_quantity,december_quantity,remark,fill_time ");
			strSql.Append(" FROM T_project_physical ");
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
			strSql.Append("select count(1) FROM T_project_physical ");
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
				strSql.Append("order by T.fill_time desc");
			}
			strSql.Append(")AS Row, T.*  from T_project_physical T ");
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
			parameters[0].Value = "T_project_physical";
			parameters[1].Value = "fill_time";
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

