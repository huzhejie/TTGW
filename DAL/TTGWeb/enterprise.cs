using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:enterprise
	/// </summary>
	public partial class enterprise
	{
		public enterprise()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_enterprise");
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
		public bool Add(TTG.Model.TTGWeb.enterprise model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_enterprise(");
			strSql.Append("id,county,communty,name,address,distance_to_community,type,main_product,area,stuff_amount,immigrant_stuff_amount,lf_average_salary,note_information,statistics_date,check_status,lock_tables,teunset1,teunset2,teunset3,teunset4,teunset5,teunset6,teunset7,teunset8,teunset9,teunset10,teunset11,teunset12)");
			strSql.Append(" values (");
			strSql.Append("@id,@county,@communty,@name,@address,@distance_to_community,@type,@main_product,@area,@stuff_amount,@immigrant_stuff_amount,@lf_average_salary,@note_information,@statistics_date,@check_status,@lock_tables,@teunset1,@teunset2,@teunset3,@teunset4,@teunset5,@teunset6,@teunset7,@teunset8,@teunset9,@teunset10,@teunset11,@teunset12)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@county", SqlDbType.VarChar,50),
					new SqlParameter("@communty", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,100),
					new SqlParameter("@address", SqlDbType.VarChar,300),
					new SqlParameter("@distance_to_community", SqlDbType.Float,8),
					new SqlParameter("@type", SqlDbType.VarChar,20),
					new SqlParameter("@main_product", SqlDbType.VarChar,60),
					new SqlParameter("@area", SqlDbType.Float,8),
					new SqlParameter("@stuff_amount", SqlDbType.Int,4),
					new SqlParameter("@immigrant_stuff_amount", SqlDbType.Int,4),
					new SqlParameter("@lf_average_salary", SqlDbType.Float,8),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@teunset1", SqlDbType.VarChar,50),
					new SqlParameter("@teunset2", SqlDbType.VarChar,50),
					new SqlParameter("@teunset3", SqlDbType.VarChar,50),
					new SqlParameter("@teunset4", SqlDbType.VarChar,50),
					new SqlParameter("@teunset5", SqlDbType.VarChar,50),
					new SqlParameter("@teunset6", SqlDbType.VarChar,50),
					new SqlParameter("@teunset7", SqlDbType.VarChar,50),
					new SqlParameter("@teunset8", SqlDbType.VarChar,50),
					new SqlParameter("@teunset9", SqlDbType.VarChar,50),
					new SqlParameter("@teunset10", SqlDbType.VarChar,50),
					new SqlParameter("@teunset11", SqlDbType.VarChar,50),
					new SqlParameter("@teunset12", SqlDbType.VarChar,50)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.county;
			parameters[2].Value = model.communty;
			parameters[3].Value = model.name;
			parameters[4].Value = model.address;
			parameters[5].Value = model.distance_to_community;
			parameters[6].Value = model.type;
			parameters[7].Value = model.main_product;
			parameters[8].Value = model.area;
			parameters[9].Value = model.stuff_amount;
			parameters[10].Value = model.immigrant_stuff_amount;
			parameters[11].Value = model.lf_average_salary;
			parameters[12].Value = model.note_information;
			parameters[13].Value = model.statistics_date;
			parameters[14].Value = model.check_status;
			parameters[15].Value = model.lock_tables;
			parameters[16].Value = model.teunset1;
			parameters[17].Value = model.teunset2;
			parameters[18].Value = model.teunset3;
			parameters[19].Value = model.teunset4;
			parameters[20].Value = model.teunset5;
			parameters[21].Value = model.teunset6;
			parameters[22].Value = model.teunset7;
			parameters[23].Value = model.teunset8;
			parameters[24].Value = model.teunset9;
			parameters[25].Value = model.teunset10;
			parameters[26].Value = model.teunset11;
			parameters[27].Value = model.teunset12;

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
		public bool Update(TTG.Model.TTGWeb.enterprise model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_enterprise set ");
			strSql.Append("county=@county,");
			strSql.Append("communty=@communty,");
			strSql.Append("name=@name,");
			strSql.Append("address=@address,");
			strSql.Append("distance_to_community=@distance_to_community,");
			strSql.Append("type=@type,");
			strSql.Append("main_product=@main_product,");
			strSql.Append("area=@area,");
			strSql.Append("stuff_amount=@stuff_amount,");
			strSql.Append("immigrant_stuff_amount=@immigrant_stuff_amount,");
			strSql.Append("lf_average_salary=@lf_average_salary,");
			strSql.Append("note_information=@note_information,");
			strSql.Append("check_status=@check_status,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("teunset1=@teunset1,");
			strSql.Append("teunset2=@teunset2,");
			strSql.Append("teunset3=@teunset3,");
			strSql.Append("teunset4=@teunset4,");
			strSql.Append("teunset5=@teunset5,");
			strSql.Append("teunset6=@teunset6,");
			strSql.Append("teunset7=@teunset7,");
			strSql.Append("teunset8=@teunset8,");
			strSql.Append("teunset9=@teunset9,");
			strSql.Append("teunset10=@teunset10,");
			strSql.Append("teunset11=@teunset11,");
			strSql.Append("teunset12=@teunset12");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@county", SqlDbType.VarChar,50),
					new SqlParameter("@communty", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,100),
					new SqlParameter("@address", SqlDbType.VarChar,300),
					new SqlParameter("@distance_to_community", SqlDbType.Float,8),
					new SqlParameter("@type", SqlDbType.VarChar,20),
					new SqlParameter("@main_product", SqlDbType.VarChar,60),
					new SqlParameter("@area", SqlDbType.Float,8),
					new SqlParameter("@stuff_amount", SqlDbType.Int,4),
					new SqlParameter("@immigrant_stuff_amount", SqlDbType.Int,4),
					new SqlParameter("@lf_average_salary", SqlDbType.Float,8),
					new SqlParameter("@note_information", SqlDbType.VarChar,200),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@teunset1", SqlDbType.VarChar,50),
					new SqlParameter("@teunset2", SqlDbType.VarChar,50),
					new SqlParameter("@teunset3", SqlDbType.VarChar,50),
					new SqlParameter("@teunset4", SqlDbType.VarChar,50),
					new SqlParameter("@teunset5", SqlDbType.VarChar,50),
					new SqlParameter("@teunset6", SqlDbType.VarChar,50),
					new SqlParameter("@teunset7", SqlDbType.VarChar,50),
					new SqlParameter("@teunset8", SqlDbType.VarChar,50),
					new SqlParameter("@teunset9", SqlDbType.VarChar,50),
					new SqlParameter("@teunset10", SqlDbType.VarChar,50),
					new SqlParameter("@teunset11", SqlDbType.VarChar,50),
					new SqlParameter("@teunset12", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.county;
			parameters[1].Value = model.communty;
			parameters[2].Value = model.name;
			parameters[3].Value = model.address;
			parameters[4].Value = model.distance_to_community;
			parameters[5].Value = model.type;
			parameters[6].Value = model.main_product;
			parameters[7].Value = model.area;
			parameters[8].Value = model.stuff_amount;
			parameters[9].Value = model.immigrant_stuff_amount;
			parameters[10].Value = model.lf_average_salary;
			parameters[11].Value = model.note_information;
			parameters[12].Value = model.check_status;
			parameters[13].Value = model.lock_tables;
			parameters[14].Value = model.teunset1;
			parameters[15].Value = model.teunset2;
			parameters[16].Value = model.teunset3;
			parameters[17].Value = model.teunset4;
			parameters[18].Value = model.teunset5;
			parameters[19].Value = model.teunset6;
			parameters[20].Value = model.teunset7;
			parameters[21].Value = model.teunset8;
			parameters[22].Value = model.teunset9;
			parameters[23].Value = model.teunset10;
			parameters[24].Value = model.teunset11;
			parameters[25].Value = model.teunset12;
			parameters[26].Value = model.id;
			parameters[27].Value = model.statistics_date;

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
			strSql.Append("delete from T_enterprise ");
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
		public TTG.Model.TTGWeb.enterprise GetModel(string id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,county,communty,name,address,distance_to_community,type,main_product,area,stuff_amount,immigrant_stuff_amount,lf_average_salary,note_information,statistics_date,check_status,lock_tables,teunset1,teunset2,teunset3,teunset4,teunset5,teunset6,teunset7,teunset8,teunset9,teunset10,teunset11,teunset12 from T_enterprise ");
			strSql.Append(" where id=@id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.enterprise model=new TTG.Model.TTGWeb.enterprise();
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
		public TTG.Model.TTGWeb.enterprise DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.enterprise model=new TTG.Model.TTGWeb.enterprise();
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
				if(row["communty"]!=null)
				{
					model.communty=row["communty"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["distance_to_community"]!=null && row["distance_to_community"].ToString()!="")
				{
					model.distance_to_community=decimal.Parse(row["distance_to_community"].ToString());
				}
				if(row["type"]!=null)
				{
					model.type=row["type"].ToString();
				}
				if(row["main_product"]!=null)
				{
					model.main_product=row["main_product"].ToString();
				}
				if(row["area"]!=null && row["area"].ToString()!="")
				{
					model.area=decimal.Parse(row["area"].ToString());
				}
				if(row["stuff_amount"]!=null && row["stuff_amount"].ToString()!="")
				{
					model.stuff_amount=int.Parse(row["stuff_amount"].ToString());
				}
				if(row["immigrant_stuff_amount"]!=null && row["immigrant_stuff_amount"].ToString()!="")
				{
					model.immigrant_stuff_amount=int.Parse(row["immigrant_stuff_amount"].ToString());
				}
				if(row["lf_average_salary"]!=null && row["lf_average_salary"].ToString()!="")
				{
					model.lf_average_salary=decimal.Parse(row["lf_average_salary"].ToString());
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
				if(row["teunset1"]!=null)
				{
					model.teunset1=row["teunset1"].ToString();
				}
				if(row["teunset2"]!=null)
				{
					model.teunset2=row["teunset2"].ToString();
				}
				if(row["teunset3"]!=null)
				{
					model.teunset3=row["teunset3"].ToString();
				}
				if(row["teunset4"]!=null)
				{
					model.teunset4=row["teunset4"].ToString();
				}
				if(row["teunset5"]!=null)
				{
					model.teunset5=row["teunset5"].ToString();
				}
				if(row["teunset6"]!=null)
				{
					model.teunset6=row["teunset6"].ToString();
				}
				if(row["teunset7"]!=null)
				{
					model.teunset7=row["teunset7"].ToString();
				}
				if(row["teunset8"]!=null)
				{
					model.teunset8=row["teunset8"].ToString();
				}
				if(row["teunset9"]!=null)
				{
					model.teunset9=row["teunset9"].ToString();
				}
				if(row["teunset10"]!=null)
				{
					model.teunset10=row["teunset10"].ToString();
				}
				if(row["teunset11"]!=null)
				{
					model.teunset11=row["teunset11"].ToString();
				}
				if(row["teunset12"]!=null)
				{
					model.teunset12=row["teunset12"].ToString();
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
			strSql.Append("select id,county,communty,name,address,distance_to_community,type,main_product,area,stuff_amount,immigrant_stuff_amount,lf_average_salary,note_information,statistics_date,check_status,lock_tables,teunset1,teunset2,teunset3,teunset4,teunset5,teunset6,teunset7,teunset8,teunset9,teunset10,teunset11,teunset12 ");
			strSql.Append(" FROM T_enterprise ");
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
			strSql.Append(" id,county,communty,name,address,distance_to_community,type,main_product,area,stuff_amount,immigrant_stuff_amount,lf_average_salary,note_information,statistics_date,check_status,lock_tables,teunset1,teunset2,teunset3,teunset4,teunset5,teunset6,teunset7,teunset8,teunset9,teunset10,teunset11,teunset12 ");
			strSql.Append(" FROM T_enterprise ");
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
			strSql.Append("select count(1) FROM T_enterprise ");
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
			strSql.Append(")AS Row, T.*  from T_enterprise T ");
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
			parameters[0].Value = "T_enterprise";
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

