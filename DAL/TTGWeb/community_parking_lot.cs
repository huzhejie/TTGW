using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_parking_lot
	/// </summary>
	public partial class community_parking_lot
	{
		public community_parking_lot()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_parking_lot");
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
		public bool Add(TTG.Model.TTGWeb.community_parking_lot model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_parking_lot(");
			strSql.Append("community_id,community_parking_space_num,community_parking_rate,community_parking_space_use_rate,community_public_parking_lot_num,community_public_grand_parking_lot_num,community_public_underg_parking_lot_num,community_public_overg_parking_lot_num,community_public_parking_lot_area,community_public_parking_space_num,community_public_parking_lot_area_rate,dis_150m_public_parking_lot_num,dis_150m_public_parking_lot_area,dis_150m_public_parking_space_num,statistics_date,tcplunset1,tcplunset2,tcplunset3,tcplunset4,tcplunset5,tcplunset6,tcplunset7,tcplunset8,tcplunset9,tcplunset10,tcplunset11,tcplunset12,tcplunset13,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_parking_space_num,@community_parking_rate,@community_parking_space_use_rate,@community_public_parking_lot_num,@community_public_grand_parking_lot_num,@community_public_underg_parking_lot_num,@community_public_overg_parking_lot_num,@community_public_parking_lot_area,@community_public_parking_space_num,@community_public_parking_lot_area_rate,@dis_150m_public_parking_lot_num,@dis_150m_public_parking_lot_area,@dis_150m_public_parking_space_num,@statistics_date,@tcplunset1,@tcplunset2,@tcplunset3,@tcplunset4,@tcplunset5,@tcplunset6,@tcplunset7,@tcplunset8,@tcplunset9,@tcplunset10,@tcplunset11,@tcplunset12,@tcplunset13,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@community_parking_rate", SqlDbType.Float,8),
					new SqlParameter("@community_parking_space_use_rate", SqlDbType.Float,8),
					new SqlParameter("@community_public_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_grand_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_underg_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_overg_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_parking_lot_area", SqlDbType.Float,8),
					new SqlParameter("@community_public_parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_parking_lot_area_rate", SqlDbType.Float,8),
					new SqlParameter("@dis_150m_public_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@dis_150m_public_parking_lot_area", SqlDbType.Float,8),
					new SqlParameter("@dis_150m_public_parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcplunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_parking_space_num;
			parameters[2].Value = model.community_parking_rate;
			parameters[3].Value = model.community_parking_space_use_rate;
			parameters[4].Value = model.community_public_parking_lot_num;
			parameters[5].Value = model.community_public_grand_parking_lot_num;
			parameters[6].Value = model.community_public_underg_parking_lot_num;
			parameters[7].Value = model.community_public_overg_parking_lot_num;
			parameters[8].Value = model.community_public_parking_lot_area;
			parameters[9].Value = model.community_public_parking_space_num;
			parameters[10].Value = model.community_public_parking_lot_area_rate;
			parameters[11].Value = model.dis_150m_public_parking_lot_num;
			parameters[12].Value = model.dis_150m_public_parking_lot_area;
			parameters[13].Value = model.dis_150m_public_parking_space_num;
			parameters[14].Value = model.statistics_date;
			parameters[15].Value = model.tcplunset1;
			parameters[16].Value = model.tcplunset2;
			parameters[17].Value = model.tcplunset3;
			parameters[18].Value = model.tcplunset4;
			parameters[19].Value = model.tcplunset5;
			parameters[20].Value = model.tcplunset6;
			parameters[21].Value = model.tcplunset7;
			parameters[22].Value = model.tcplunset8;
			parameters[23].Value = model.tcplunset9;
			parameters[24].Value = model.tcplunset10;
			parameters[25].Value = model.tcplunset11;
			parameters[26].Value = model.tcplunset12;
			parameters[27].Value = model.tcplunset13;
			parameters[28].Value = model.lock_tables;
			parameters[29].Value = model.check_status;

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
		public bool Update(TTG.Model.TTGWeb.community_parking_lot model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_parking_lot set ");
			strSql.Append("community_parking_space_num=@community_parking_space_num,");
			strSql.Append("community_parking_rate=@community_parking_rate,");
			strSql.Append("community_parking_space_use_rate=@community_parking_space_use_rate,");
			strSql.Append("community_public_parking_lot_num=@community_public_parking_lot_num,");
			strSql.Append("community_public_grand_parking_lot_num=@community_public_grand_parking_lot_num,");
			strSql.Append("community_public_underg_parking_lot_num=@community_public_underg_parking_lot_num,");
			strSql.Append("community_public_overg_parking_lot_num=@community_public_overg_parking_lot_num,");
			strSql.Append("community_public_parking_lot_area=@community_public_parking_lot_area,");
			strSql.Append("community_public_parking_space_num=@community_public_parking_space_num,");
			strSql.Append("community_public_parking_lot_area_rate=@community_public_parking_lot_area_rate,");
			strSql.Append("dis_150m_public_parking_lot_num=@dis_150m_public_parking_lot_num,");
			strSql.Append("dis_150m_public_parking_lot_area=@dis_150m_public_parking_lot_area,");
			strSql.Append("dis_150m_public_parking_space_num=@dis_150m_public_parking_space_num,");
			strSql.Append("tcplunset1=@tcplunset1,");
			strSql.Append("tcplunset2=@tcplunset2,");
			strSql.Append("tcplunset3=@tcplunset3,");
			strSql.Append("tcplunset4=@tcplunset4,");
			strSql.Append("tcplunset5=@tcplunset5,");
			strSql.Append("tcplunset6=@tcplunset6,");
			strSql.Append("tcplunset7=@tcplunset7,");
			strSql.Append("tcplunset8=@tcplunset8,");
			strSql.Append("tcplunset9=@tcplunset9,");
			strSql.Append("tcplunset10=@tcplunset10,");
			strSql.Append("tcplunset11=@tcplunset11,");
			strSql.Append("tcplunset12=@tcplunset12,");
			strSql.Append("tcplunset13=@tcplunset13,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@community_parking_rate", SqlDbType.Float,8),
					new SqlParameter("@community_parking_space_use_rate", SqlDbType.Float,8),
					new SqlParameter("@community_public_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_grand_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_underg_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_overg_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_parking_lot_area", SqlDbType.Float,8),
					new SqlParameter("@community_public_parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@community_public_parking_lot_area_rate", SqlDbType.Float,8),
					new SqlParameter("@dis_150m_public_parking_lot_num", SqlDbType.Int,4),
					new SqlParameter("@dis_150m_public_parking_lot_area", SqlDbType.Float,8),
					new SqlParameter("@dis_150m_public_parking_space_num", SqlDbType.Int,4),
					new SqlParameter("@tcplunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcplunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_parking_space_num;
			parameters[1].Value = model.community_parking_rate;
			parameters[2].Value = model.community_parking_space_use_rate;
			parameters[3].Value = model.community_public_parking_lot_num;
			parameters[4].Value = model.community_public_grand_parking_lot_num;
			parameters[5].Value = model.community_public_underg_parking_lot_num;
			parameters[6].Value = model.community_public_overg_parking_lot_num;
			parameters[7].Value = model.community_public_parking_lot_area;
			parameters[8].Value = model.community_public_parking_space_num;
			parameters[9].Value = model.community_public_parking_lot_area_rate;
			parameters[10].Value = model.dis_150m_public_parking_lot_num;
			parameters[11].Value = model.dis_150m_public_parking_lot_area;
			parameters[12].Value = model.dis_150m_public_parking_space_num;
			parameters[13].Value = model.tcplunset1;
			parameters[14].Value = model.tcplunset2;
			parameters[15].Value = model.tcplunset3;
			parameters[16].Value = model.tcplunset4;
			parameters[17].Value = model.tcplunset5;
			parameters[18].Value = model.tcplunset6;
			parameters[19].Value = model.tcplunset7;
			parameters[20].Value = model.tcplunset8;
			parameters[21].Value = model.tcplunset9;
			parameters[22].Value = model.tcplunset10;
			parameters[23].Value = model.tcplunset11;
			parameters[24].Value = model.tcplunset12;
			parameters[25].Value = model.tcplunset13;
			parameters[26].Value = model.lock_tables;
			parameters[27].Value = model.check_status;
			parameters[28].Value = model.community_id;
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
		public bool Delete(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_parking_lot ");
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
		public TTG.Model.TTGWeb.community_parking_lot GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_parking_space_num,community_parking_rate,community_parking_space_use_rate,community_public_parking_lot_num,community_public_grand_parking_lot_num,community_public_underg_parking_lot_num,community_public_overg_parking_lot_num,community_public_parking_lot_area,community_public_parking_space_num,community_public_parking_lot_area_rate,dis_150m_public_parking_lot_num,dis_150m_public_parking_lot_area,dis_150m_public_parking_space_num,statistics_date,tcplunset1,tcplunset2,tcplunset3,tcplunset4,tcplunset5,tcplunset6,tcplunset7,tcplunset8,tcplunset9,tcplunset10,tcplunset11,tcplunset12,tcplunset13,lock_tables,check_status from T_community_parking_lot ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_parking_lot model=new TTG.Model.TTGWeb.community_parking_lot();
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
		public TTG.Model.TTGWeb.community_parking_lot DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_parking_lot model=new TTG.Model.TTGWeb.community_parking_lot();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_parking_space_num"]!=null && row["community_parking_space_num"].ToString()!="")
				{
					model.community_parking_space_num=int.Parse(row["community_parking_space_num"].ToString());
				}
				if(row["community_parking_rate"]!=null && row["community_parking_rate"].ToString()!="")
				{
					model.community_parking_rate=decimal.Parse(row["community_parking_rate"].ToString());
				}
				if(row["community_parking_space_use_rate"]!=null && row["community_parking_space_use_rate"].ToString()!="")
				{
					model.community_parking_space_use_rate=decimal.Parse(row["community_parking_space_use_rate"].ToString());
				}
				if(row["community_public_parking_lot_num"]!=null && row["community_public_parking_lot_num"].ToString()!="")
				{
					model.community_public_parking_lot_num=int.Parse(row["community_public_parking_lot_num"].ToString());
				}
				if(row["community_public_grand_parking_lot_num"]!=null && row["community_public_grand_parking_lot_num"].ToString()!="")
				{
					model.community_public_grand_parking_lot_num=int.Parse(row["community_public_grand_parking_lot_num"].ToString());
				}
				if(row["community_public_underg_parking_lot_num"]!=null && row["community_public_underg_parking_lot_num"].ToString()!="")
				{
					model.community_public_underg_parking_lot_num=int.Parse(row["community_public_underg_parking_lot_num"].ToString());
				}
				if(row["community_public_overg_parking_lot_num"]!=null && row["community_public_overg_parking_lot_num"].ToString()!="")
				{
					model.community_public_overg_parking_lot_num=int.Parse(row["community_public_overg_parking_lot_num"].ToString());
				}
				if(row["community_public_parking_lot_area"]!=null && row["community_public_parking_lot_area"].ToString()!="")
				{
					model.community_public_parking_lot_area=decimal.Parse(row["community_public_parking_lot_area"].ToString());
				}
				if(row["community_public_parking_space_num"]!=null && row["community_public_parking_space_num"].ToString()!="")
				{
					model.community_public_parking_space_num=int.Parse(row["community_public_parking_space_num"].ToString());
				}
				if(row["community_public_parking_lot_area_rate"]!=null && row["community_public_parking_lot_area_rate"].ToString()!="")
				{
					model.community_public_parking_lot_area_rate=decimal.Parse(row["community_public_parking_lot_area_rate"].ToString());
				}
				if(row["dis_150m_public_parking_lot_num"]!=null && row["dis_150m_public_parking_lot_num"].ToString()!="")
				{
					model.dis_150m_public_parking_lot_num=int.Parse(row["dis_150m_public_parking_lot_num"].ToString());
				}
				if(row["dis_150m_public_parking_lot_area"]!=null && row["dis_150m_public_parking_lot_area"].ToString()!="")
				{
					model.dis_150m_public_parking_lot_area=decimal.Parse(row["dis_150m_public_parking_lot_area"].ToString());
				}
				if(row["dis_150m_public_parking_space_num"]!=null && row["dis_150m_public_parking_space_num"].ToString()!="")
				{
					model.dis_150m_public_parking_space_num=int.Parse(row["dis_150m_public_parking_space_num"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcplunset1"]!=null)
				{
					model.tcplunset1=row["tcplunset1"].ToString();
				}
				if(row["tcplunset2"]!=null)
				{
					model.tcplunset2=row["tcplunset2"].ToString();
				}
				if(row["tcplunset3"]!=null)
				{
					model.tcplunset3=row["tcplunset3"].ToString();
				}
				if(row["tcplunset4"]!=null)
				{
					model.tcplunset4=row["tcplunset4"].ToString();
				}
				if(row["tcplunset5"]!=null)
				{
					model.tcplunset5=row["tcplunset5"].ToString();
				}
				if(row["tcplunset6"]!=null)
				{
					model.tcplunset6=row["tcplunset6"].ToString();
				}
				if(row["tcplunset7"]!=null)
				{
					model.tcplunset7=row["tcplunset7"].ToString();
				}
				if(row["tcplunset8"]!=null)
				{
					model.tcplunset8=row["tcplunset8"].ToString();
				}
				if(row["tcplunset9"]!=null)
				{
					model.tcplunset9=row["tcplunset9"].ToString();
				}
				if(row["tcplunset10"]!=null)
				{
					model.tcplunset10=row["tcplunset10"].ToString();
				}
				if(row["tcplunset11"]!=null)
				{
					model.tcplunset11=row["tcplunset11"].ToString();
				}
				if(row["tcplunset12"]!=null)
				{
					model.tcplunset12=row["tcplunset12"].ToString();
				}
				if(row["tcplunset13"]!=null)
				{
					model.tcplunset13=row["tcplunset13"].ToString();
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
			strSql.Append("select community_id,community_parking_space_num,community_parking_rate,community_parking_space_use_rate,community_public_parking_lot_num,community_public_grand_parking_lot_num,community_public_underg_parking_lot_num,community_public_overg_parking_lot_num,community_public_parking_lot_area,community_public_parking_space_num,community_public_parking_lot_area_rate,dis_150m_public_parking_lot_num,dis_150m_public_parking_lot_area,dis_150m_public_parking_space_num,statistics_date,tcplunset1,tcplunset2,tcplunset3,tcplunset4,tcplunset5,tcplunset6,tcplunset7,tcplunset8,tcplunset9,tcplunset10,tcplunset11,tcplunset12,tcplunset13,lock_tables,check_status ");
			strSql.Append(" FROM T_community_parking_lot ");
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
			strSql.Append(" community_id,community_parking_space_num,community_parking_rate,community_parking_space_use_rate,community_public_parking_lot_num,community_public_grand_parking_lot_num,community_public_underg_parking_lot_num,community_public_overg_parking_lot_num,community_public_parking_lot_area,community_public_parking_space_num,community_public_parking_lot_area_rate,dis_150m_public_parking_lot_num,dis_150m_public_parking_lot_area,dis_150m_public_parking_space_num,statistics_date,tcplunset1,tcplunset2,tcplunset3,tcplunset4,tcplunset5,tcplunset6,tcplunset7,tcplunset8,tcplunset9,tcplunset10,tcplunset11,tcplunset12,tcplunset13,lock_tables,check_status ");
			strSql.Append(" FROM T_community_parking_lot ");
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
			strSql.Append("select count(1) FROM T_community_parking_lot ");
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
			strSql.Append(")AS Row, T.*  from T_community_parking_lot T ");
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
			parameters[0].Value = "T_community_parking_lot";
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
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="community_id"></param>
        /// <returns></returns>
        public TTG.Model.TTGWeb.community_parking_lot getModel(string community_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 community_id,community_parking_space_num,community_parking_rate,community_parking_space_use_rate,community_public_parking_lot_num,community_public_grand_parking_lot_num,community_public_underg_parking_lot_num,community_public_overg_parking_lot_num,community_public_parking_lot_area,community_public_parking_space_num,community_public_parking_lot_area_rate,dis_150m_public_parking_lot_num,dis_150m_public_parking_lot_area,dis_150m_public_parking_space_num,statistics_date,tcplunset1,tcplunset2,tcplunset3,tcplunset4,tcplunset5,tcplunset6,tcplunset7,tcplunset8,tcplunset9,tcplunset10,tcplunset11,tcplunset12,tcplunset13,lock_tables,check_status from T_community_parking_lot ");
            strSql.Append(" where community_id=@community_id order by statistics_date desc");
            SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)			};
            parameters[0].Value = community_id;

            TTG.Model.TTGWeb.community_parking_lot model = new TTG.Model.TTGWeb.community_parking_lot();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
		#endregion  ExtensionMethod
	}
}

