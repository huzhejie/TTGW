using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:subproject_physical_finish_situation
	/// </summary>
	public partial class subproject_physical_finish_situation
	{
		public subproject_physical_finish_situation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string subproject_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_subproject_physical_finish_situation");
			strSql.Append(" where subproject_id=@subproject_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = subproject_id;
			parameters[1].Value = statistics_date;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.subproject_physical_finish_situation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_subproject_physical_finish_situation(");
			strSql.Append("subproject_id,subproject_no,subproject_name,county_name,project_name,subproject_category,community,physical_class,physical_subclass,physical_class_content,plan_quantity,note_information,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,check_status,lock_tables,new_add,project_category)");
			strSql.Append(" values (");
			strSql.Append("@subproject_id,@subproject_no,@subproject_name,@county_name,@project_name,@subproject_category,@community,@physical_class,@physical_subclass,@physical_class_content,@plan_quantity,@note_information,@statistics_date,@tciunset1,@tciunset2,@tciunset3,@tciunset4,@tciunset5,@tciunset6,@tciunset7,@tciunset8,@tciunset9,@tciunset10,@tciunset11,@tciunset12,@tciunset13,@check_status,@lock_tables,@new_add,@project_category)");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_no", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_name", SqlDbType.VarChar,100),
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@subproject_category", SqlDbType.VarChar,20),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@physical_class", SqlDbType.VarChar,20),
					new SqlParameter("@physical_subclass", SqlDbType.VarChar,20),
					new SqlParameter("@physical_class_content", SqlDbType.VarChar,100),
					new SqlParameter("@plan_quantity", SqlDbType.Float,8),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
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
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@new_add", SqlDbType.VarChar,20),
					new SqlParameter("@project_category", SqlDbType.VarChar,20)};
			parameters[0].Value = model.subproject_id;
			parameters[1].Value = model.subproject_no;
			parameters[2].Value = model.subproject_name;
			parameters[3].Value = model.county_name;
			parameters[4].Value = model.project_name;
			parameters[5].Value = model.subproject_category;
			parameters[6].Value = model.community;
			parameters[7].Value = model.physical_class;
			parameters[8].Value = model.physical_subclass;
			parameters[9].Value = model.physical_class_content;
			parameters[10].Value = model.plan_quantity;
			parameters[11].Value = model.note_information;
			parameters[12].Value = model.statistics_date;
			parameters[13].Value = model.tciunset1;
			parameters[14].Value = model.tciunset2;
			parameters[15].Value = model.tciunset3;
			parameters[16].Value = model.tciunset4;
			parameters[17].Value = model.tciunset5;
			parameters[18].Value = model.tciunset6;
			parameters[19].Value = model.tciunset7;
			parameters[20].Value = model.tciunset8;
			parameters[21].Value = model.tciunset9;
			parameters[22].Value = model.tciunset10;
			parameters[23].Value = model.tciunset11;
			parameters[24].Value = model.tciunset12;
			parameters[25].Value = model.tciunset13;
			parameters[26].Value = model.check_status;
			parameters[27].Value = model.lock_tables;
			parameters[28].Value = model.new_add;
			parameters[29].Value = model.project_category;

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
		public bool Update(TTG.Model.TTGWeb.subproject_physical_finish_situation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_subproject_physical_finish_situation set ");
			strSql.Append("subproject_no=@subproject_no,");
			strSql.Append("subproject_name=@subproject_name,");
			strSql.Append("county_name=@county_name,");
			strSql.Append("project_name=@project_name,");
			strSql.Append("subproject_category=@subproject_category,");
			strSql.Append("community=@community,");
			strSql.Append("physical_class=@physical_class,");
			strSql.Append("physical_subclass=@physical_subclass,");
			strSql.Append("physical_class_content=@physical_class_content,");
			strSql.Append("plan_quantity=@plan_quantity,");
			strSql.Append("note_information=@note_information,");
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
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("new_add=@new_add,");
			strSql.Append("project_category=@project_category");
			strSql.Append(" where subproject_id=@subproject_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_no", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_name", SqlDbType.VarChar,100),
					new SqlParameter("@county_name", SqlDbType.VarChar,50),
					new SqlParameter("@project_name", SqlDbType.VarChar,50),
					new SqlParameter("@subproject_category", SqlDbType.VarChar,20),
					new SqlParameter("@community", SqlDbType.VarChar,50),
					new SqlParameter("@physical_class", SqlDbType.VarChar,20),
					new SqlParameter("@physical_subclass", SqlDbType.VarChar,20),
					new SqlParameter("@physical_class_content", SqlDbType.VarChar,100),
					new SqlParameter("@plan_quantity", SqlDbType.Float,8),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
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
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@new_add", SqlDbType.VarChar,20),
					new SqlParameter("@project_category", SqlDbType.VarChar,20),
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.subproject_no;
			parameters[1].Value = model.subproject_name;
			parameters[2].Value = model.county_name;
			parameters[3].Value = model.project_name;
			parameters[4].Value = model.subproject_category;
			parameters[5].Value = model.community;
			parameters[6].Value = model.physical_class;
			parameters[7].Value = model.physical_subclass;
			parameters[8].Value = model.physical_class_content;
			parameters[9].Value = model.plan_quantity;
			parameters[10].Value = model.note_information;
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
			parameters[24].Value = model.check_status;
			parameters[25].Value = model.lock_tables;
			parameters[26].Value = model.new_add;
			parameters[27].Value = model.project_category;
			parameters[28].Value = model.subproject_id;
			parameters[29].Value = model.statistics_date;

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
		public bool Delete(string subproject_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_subproject_physical_finish_situation ");
			strSql.Append(" where subproject_id=@subproject_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = subproject_id;
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
		public TTG.Model.TTGWeb.subproject_physical_finish_situation GetModel(string subproject_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 subproject_id,subproject_no,subproject_name,county_name,project_name,subproject_category,community,physical_class,physical_subclass,physical_class_content,plan_quantity,note_information,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,check_status,lock_tables,new_add,project_category from T_subproject_physical_finish_situation ");
			strSql.Append(" where subproject_id=@subproject_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@subproject_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = subproject_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.subproject_physical_finish_situation model=new TTG.Model.TTGWeb.subproject_physical_finish_situation();
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
		public TTG.Model.TTGWeb.subproject_physical_finish_situation DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.subproject_physical_finish_situation model=new TTG.Model.TTGWeb.subproject_physical_finish_situation();
			if (row != null)
			{
				if(row["subproject_id"]!=null)
				{
					model.subproject_id=row["subproject_id"].ToString();
				}
				if(row["subproject_no"]!=null)
				{
					model.subproject_no=row["subproject_no"].ToString();
				}
				if(row["subproject_name"]!=null)
				{
					model.subproject_name=row["subproject_name"].ToString();
				}
				if(row["county_name"]!=null)
				{
					model.county_name=row["county_name"].ToString();
				}
				if(row["project_name"]!=null)
				{
					model.project_name=row["project_name"].ToString();
				}
				if(row["subproject_category"]!=null)
				{
					model.subproject_category=row["subproject_category"].ToString();
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
				if(row["plan_quantity"]!=null && row["plan_quantity"].ToString()!="")
				{
					model.plan_quantity=decimal.Parse(row["plan_quantity"].ToString());
				}
				if(row["note_information"]!=null)
				{
					model.note_information=row["note_information"].ToString();
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
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
				if(row["check_status"]!=null && row["check_status"].ToString()!="")
				{
					model.check_status=int.Parse(row["check_status"].ToString());
				}
				if(row["lock_tables"]!=null && row["lock_tables"].ToString()!="")
				{
					model.lock_tables=int.Parse(row["lock_tables"].ToString());
				}
				if(row["new_add"]!=null)
				{
					model.new_add=row["new_add"].ToString();
				}
				if(row["project_category"]!=null)
				{
					model.project_category=row["project_category"].ToString();
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
			strSql.Append("select subproject_id,subproject_no,subproject_name,county_name,project_name,subproject_category,community,physical_class,physical_subclass,physical_class_content,plan_quantity,note_information,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,check_status,lock_tables,new_add,project_category ");
			strSql.Append(" FROM T_subproject_physical_finish_situation ");
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
			strSql.Append(" subproject_id,subproject_no,subproject_name,county_name,project_name,subproject_category,community,physical_class,physical_subclass,physical_class_content,plan_quantity,note_information,statistics_date,tciunset1,tciunset2,tciunset3,tciunset4,tciunset5,tciunset6,tciunset7,tciunset8,tciunset9,tciunset10,tciunset11,tciunset12,tciunset13,check_status,lock_tables,new_add,project_category ");
			strSql.Append(" FROM T_subproject_physical_finish_situation ");
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
			strSql.Append("select count(1) FROM T_subproject_physical_finish_situation ");
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
			strSql.Append(")AS Row, T.*  from T_subproject_physical_finish_situation T ");
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
			parameters[0].Value = "T_subproject_physical_finish_situation";
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

