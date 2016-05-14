using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_elec_supply
	/// </summary>
	public partial class community_elec_supply
	{
		public community_elec_supply()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id,DateTime statistics_date)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_elec_supply");
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
		public bool Add(TTG.Model.TTGWeb.community_elec_supply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_elec_supply(");
			strSql.Append("community_id,community_load_dispatching_office_num,community_transformer_num,below_100kva_transformer_num,at_100_500kva_transformer_num,at_500_1000kva_transformer_num,more_1000kva_transformer_num,community_elec_supply_wireways_length,community_power_transmission_line_length,community_high_voltage_distr_line_legth,community_low_voltage_distr_line_legth,community_elec_supply_consumption,community_resident_elec_consumption,no_elec_days,statistics_date,tcesunset1,tcesunset2,tcesunset3,tcesunset4,tcesunset5,tcesunset6,tcesunset7,tcesunset8,tcesunset9,tcesunset10,tcesunset11,tcesunset12,tcesunset13,lock_tables,check_status)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@community_load_dispatching_office_num,@community_transformer_num,@below_100kva_transformer_num,@at_100_500kva_transformer_num,@at_500_1000kva_transformer_num,@more_1000kva_transformer_num,@community_elec_supply_wireways_length,@community_power_transmission_line_length,@community_high_voltage_distr_line_legth,@community_low_voltage_distr_line_legth,@community_elec_supply_consumption,@community_resident_elec_consumption,@no_elec_days,@statistics_date,@tcesunset1,@tcesunset2,@tcesunset3,@tcesunset4,@tcesunset5,@tcesunset6,@tcesunset7,@tcesunset8,@tcesunset9,@tcesunset10,@tcesunset11,@tcesunset12,@tcesunset13,@lock_tables,@check_status)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_load_dispatching_office_num", SqlDbType.Int,4),
					new SqlParameter("@community_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@below_100kva_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@at_100_500kva_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@at_500_1000kva_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@more_1000kva_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@community_elec_supply_wireways_length", SqlDbType.Float,8),
					new SqlParameter("@community_power_transmission_line_length", SqlDbType.Float,8),
					new SqlParameter("@community_high_voltage_distr_line_legth", SqlDbType.Float,8),
					new SqlParameter("@community_low_voltage_distr_line_legth", SqlDbType.Float,8),
					new SqlParameter("@community_elec_supply_consumption", SqlDbType.Float,8),
					new SqlParameter("@community_resident_elec_consumption", SqlDbType.Float,8),
					new SqlParameter("@no_elec_days", SqlDbType.Int,4),
					new SqlParameter("@statistics_date", SqlDbType.Date,3),
					new SqlParameter("@tcesunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.community_load_dispatching_office_num;
			parameters[2].Value = model.community_transformer_num;
			parameters[3].Value = model.below_100kva_transformer_num;
			parameters[4].Value = model.at_100_500kva_transformer_num;
			parameters[5].Value = model.at_500_1000kva_transformer_num;
			parameters[6].Value = model.more_1000kva_transformer_num;
			parameters[7].Value = model.community_elec_supply_wireways_length;
			parameters[8].Value = model.community_power_transmission_line_length;
			parameters[9].Value = model.community_high_voltage_distr_line_legth;
			parameters[10].Value = model.community_low_voltage_distr_line_legth;
			parameters[11].Value = model.community_elec_supply_consumption;
			parameters[12].Value = model.community_resident_elec_consumption;
			parameters[13].Value = model.no_elec_days;
			parameters[14].Value = model.statistics_date;
			parameters[15].Value = model.tcesunset1;
			parameters[16].Value = model.tcesunset2;
			parameters[17].Value = model.tcesunset3;
			parameters[18].Value = model.tcesunset4;
			parameters[19].Value = model.tcesunset5;
			parameters[20].Value = model.tcesunset6;
			parameters[21].Value = model.tcesunset7;
			parameters[22].Value = model.tcesunset8;
			parameters[23].Value = model.tcesunset9;
			parameters[24].Value = model.tcesunset10;
			parameters[25].Value = model.tcesunset11;
			parameters[26].Value = model.tcesunset12;
			parameters[27].Value = model.tcesunset13;
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
		public bool Update(TTG.Model.TTGWeb.community_elec_supply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_elec_supply set ");
			strSql.Append("community_load_dispatching_office_num=@community_load_dispatching_office_num,");
			strSql.Append("community_transformer_num=@community_transformer_num,");
			strSql.Append("below_100kva_transformer_num=@below_100kva_transformer_num,");
			strSql.Append("at_100_500kva_transformer_num=@at_100_500kva_transformer_num,");
			strSql.Append("at_500_1000kva_transformer_num=@at_500_1000kva_transformer_num,");
			strSql.Append("more_1000kva_transformer_num=@more_1000kva_transformer_num,");
			strSql.Append("community_elec_supply_wireways_length=@community_elec_supply_wireways_length,");
			strSql.Append("community_power_transmission_line_length=@community_power_transmission_line_length,");
			strSql.Append("community_high_voltage_distr_line_legth=@community_high_voltage_distr_line_legth,");
			strSql.Append("community_low_voltage_distr_line_legth=@community_low_voltage_distr_line_legth,");
			strSql.Append("community_elec_supply_consumption=@community_elec_supply_consumption,");
			strSql.Append("community_resident_elec_consumption=@community_resident_elec_consumption,");
			strSql.Append("no_elec_days=@no_elec_days,");
			strSql.Append("tcesunset1=@tcesunset1,");
			strSql.Append("tcesunset2=@tcesunset2,");
			strSql.Append("tcesunset3=@tcesunset3,");
			strSql.Append("tcesunset4=@tcesunset4,");
			strSql.Append("tcesunset5=@tcesunset5,");
			strSql.Append("tcesunset6=@tcesunset6,");
			strSql.Append("tcesunset7=@tcesunset7,");
			strSql.Append("tcesunset8=@tcesunset8,");
			strSql.Append("tcesunset9=@tcesunset9,");
			strSql.Append("tcesunset10=@tcesunset10,");
			strSql.Append("tcesunset11=@tcesunset11,");
			strSql.Append("tcesunset12=@tcesunset12,");
			strSql.Append("tcesunset13=@tcesunset13,");
			strSql.Append("lock_tables=@lock_tables,");
			strSql.Append("check_status=@check_status");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_load_dispatching_office_num", SqlDbType.Int,4),
					new SqlParameter("@community_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@below_100kva_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@at_100_500kva_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@at_500_1000kva_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@more_1000kva_transformer_num", SqlDbType.Int,4),
					new SqlParameter("@community_elec_supply_wireways_length", SqlDbType.Float,8),
					new SqlParameter("@community_power_transmission_line_length", SqlDbType.Float,8),
					new SqlParameter("@community_high_voltage_distr_line_legth", SqlDbType.Float,8),
					new SqlParameter("@community_low_voltage_distr_line_legth", SqlDbType.Float,8),
					new SqlParameter("@community_elec_supply_consumption", SqlDbType.Float,8),
					new SqlParameter("@community_resident_elec_consumption", SqlDbType.Float,8),
					new SqlParameter("@no_elec_days", SqlDbType.Int,4),
					new SqlParameter("@tcesunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset6", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset7", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset8", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset9", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset10", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset11", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset12", SqlDbType.VarChar,50),
					new SqlParameter("@tcesunset13", SqlDbType.VarChar,50),
					new SqlParameter("@lock_tables", SqlDbType.Int,4),
					new SqlParameter("@check_status", SqlDbType.Int,4),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)};
			parameters[0].Value = model.community_load_dispatching_office_num;
			parameters[1].Value = model.community_transformer_num;
			parameters[2].Value = model.below_100kva_transformer_num;
			parameters[3].Value = model.at_100_500kva_transformer_num;
			parameters[4].Value = model.at_500_1000kva_transformer_num;
			parameters[5].Value = model.more_1000kva_transformer_num;
			parameters[6].Value = model.community_elec_supply_wireways_length;
			parameters[7].Value = model.community_power_transmission_line_length;
			parameters[8].Value = model.community_high_voltage_distr_line_legth;
			parameters[9].Value = model.community_low_voltage_distr_line_legth;
			parameters[10].Value = model.community_elec_supply_consumption;
			parameters[11].Value = model.community_resident_elec_consumption;
			parameters[12].Value = model.no_elec_days;
			parameters[13].Value = model.tcesunset1;
			parameters[14].Value = model.tcesunset2;
			parameters[15].Value = model.tcesunset3;
			parameters[16].Value = model.tcesunset4;
			parameters[17].Value = model.tcesunset5;
			parameters[18].Value = model.tcesunset6;
			parameters[19].Value = model.tcesunset7;
			parameters[20].Value = model.tcesunset8;
			parameters[21].Value = model.tcesunset9;
			parameters[22].Value = model.tcesunset10;
			parameters[23].Value = model.tcesunset11;
			parameters[24].Value = model.tcesunset12;
			parameters[25].Value = model.tcesunset13;
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
			strSql.Append("delete from T_community_elec_supply ");
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
		public TTG.Model.TTGWeb.community_elec_supply GetModel(string community_id,DateTime statistics_date)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,community_load_dispatching_office_num,community_transformer_num,below_100kva_transformer_num,at_100_500kva_transformer_num,at_500_1000kva_transformer_num,more_1000kva_transformer_num,community_elec_supply_wireways_length,community_power_transmission_line_length,community_high_voltage_distr_line_legth,community_low_voltage_distr_line_legth,community_elec_supply_consumption,community_resident_elec_consumption,no_elec_days,statistics_date,tcesunset1,tcesunset2,tcesunset3,tcesunset4,tcesunset5,tcesunset6,tcesunset7,tcesunset8,tcesunset9,tcesunset10,tcesunset11,tcesunset12,tcesunset13,lock_tables,check_status from T_community_elec_supply ");
			strSql.Append(" where community_id=@community_id and statistics_date=@statistics_date ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@statistics_date", SqlDbType.Date,3)			};
			parameters[0].Value = community_id;
			parameters[1].Value = statistics_date;

			TTG.Model.TTGWeb.community_elec_supply model=new TTG.Model.TTGWeb.community_elec_supply();
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
		public TTG.Model.TTGWeb.community_elec_supply DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_elec_supply model=new TTG.Model.TTGWeb.community_elec_supply();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_load_dispatching_office_num"]!=null && row["community_load_dispatching_office_num"].ToString()!="")
				{
					model.community_load_dispatching_office_num=int.Parse(row["community_load_dispatching_office_num"].ToString());
				}
				if(row["community_transformer_num"]!=null && row["community_transformer_num"].ToString()!="")
				{
					model.community_transformer_num=int.Parse(row["community_transformer_num"].ToString());
				}
				if(row["below_100kva_transformer_num"]!=null && row["below_100kva_transformer_num"].ToString()!="")
				{
					model.below_100kva_transformer_num=int.Parse(row["below_100kva_transformer_num"].ToString());
				}
				if(row["at_100_500kva_transformer_num"]!=null && row["at_100_500kva_transformer_num"].ToString()!="")
				{
					model.at_100_500kva_transformer_num=int.Parse(row["at_100_500kva_transformer_num"].ToString());
				}
				if(row["at_500_1000kva_transformer_num"]!=null && row["at_500_1000kva_transformer_num"].ToString()!="")
				{
					model.at_500_1000kva_transformer_num=int.Parse(row["at_500_1000kva_transformer_num"].ToString());
				}
				if(row["more_1000kva_transformer_num"]!=null && row["more_1000kva_transformer_num"].ToString()!="")
				{
					model.more_1000kva_transformer_num=int.Parse(row["more_1000kva_transformer_num"].ToString());
				}
				if(row["community_elec_supply_wireways_length"]!=null && row["community_elec_supply_wireways_length"].ToString()!="")
				{
					model.community_elec_supply_wireways_length=decimal.Parse(row["community_elec_supply_wireways_length"].ToString());
				}
				if(row["community_power_transmission_line_length"]!=null && row["community_power_transmission_line_length"].ToString()!="")
				{
					model.community_power_transmission_line_length=decimal.Parse(row["community_power_transmission_line_length"].ToString());
				}
				if(row["community_high_voltage_distr_line_legth"]!=null && row["community_high_voltage_distr_line_legth"].ToString()!="")
				{
					model.community_high_voltage_distr_line_legth=decimal.Parse(row["community_high_voltage_distr_line_legth"].ToString());
				}
				if(row["community_low_voltage_distr_line_legth"]!=null && row["community_low_voltage_distr_line_legth"].ToString()!="")
				{
					model.community_low_voltage_distr_line_legth=decimal.Parse(row["community_low_voltage_distr_line_legth"].ToString());
				}
				if(row["community_elec_supply_consumption"]!=null && row["community_elec_supply_consumption"].ToString()!="")
				{
					model.community_elec_supply_consumption=decimal.Parse(row["community_elec_supply_consumption"].ToString());
				}
				if(row["community_resident_elec_consumption"]!=null && row["community_resident_elec_consumption"].ToString()!="")
				{
					model.community_resident_elec_consumption=decimal.Parse(row["community_resident_elec_consumption"].ToString());
				}
				if(row["no_elec_days"]!=null && row["no_elec_days"].ToString()!="")
				{
					model.no_elec_days=int.Parse(row["no_elec_days"].ToString());
				}
				if(row["statistics_date"]!=null && row["statistics_date"].ToString()!="")
				{
					model.statistics_date=DateTime.Parse(row["statistics_date"].ToString());
				}
				if(row["tcesunset1"]!=null)
				{
					model.tcesunset1=row["tcesunset1"].ToString();
				}
				if(row["tcesunset2"]!=null)
				{
					model.tcesunset2=row["tcesunset2"].ToString();
				}
				if(row["tcesunset3"]!=null)
				{
					model.tcesunset3=row["tcesunset3"].ToString();
				}
				if(row["tcesunset4"]!=null)
				{
					model.tcesunset4=row["tcesunset4"].ToString();
				}
				if(row["tcesunset5"]!=null)
				{
					model.tcesunset5=row["tcesunset5"].ToString();
				}
				if(row["tcesunset6"]!=null)
				{
					model.tcesunset6=row["tcesunset6"].ToString();
				}
				if(row["tcesunset7"]!=null)
				{
					model.tcesunset7=row["tcesunset7"].ToString();
				}
				if(row["tcesunset8"]!=null)
				{
					model.tcesunset8=row["tcesunset8"].ToString();
				}
				if(row["tcesunset9"]!=null)
				{
					model.tcesunset9=row["tcesunset9"].ToString();
				}
				if(row["tcesunset10"]!=null)
				{
					model.tcesunset10=row["tcesunset10"].ToString();
				}
				if(row["tcesunset11"]!=null)
				{
					model.tcesunset11=row["tcesunset11"].ToString();
				}
				if(row["tcesunset12"]!=null)
				{
					model.tcesunset12=row["tcesunset12"].ToString();
				}
				if(row["tcesunset13"]!=null)
				{
					model.tcesunset13=row["tcesunset13"].ToString();
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
			strSql.Append("select community_id,community_load_dispatching_office_num,community_transformer_num,below_100kva_transformer_num,at_100_500kva_transformer_num,at_500_1000kva_transformer_num,more_1000kva_transformer_num,community_elec_supply_wireways_length,community_power_transmission_line_length,community_high_voltage_distr_line_legth,community_low_voltage_distr_line_legth,community_elec_supply_consumption,community_resident_elec_consumption,no_elec_days,statistics_date,tcesunset1,tcesunset2,tcesunset3,tcesunset4,tcesunset5,tcesunset6,tcesunset7,tcesunset8,tcesunset9,tcesunset10,tcesunset11,tcesunset12,tcesunset13,lock_tables,check_status ");
			strSql.Append(" FROM T_community_elec_supply ");
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
			strSql.Append(" community_id,community_load_dispatching_office_num,community_transformer_num,below_100kva_transformer_num,at_100_500kva_transformer_num,at_500_1000kva_transformer_num,more_1000kva_transformer_num,community_elec_supply_wireways_length,community_power_transmission_line_length,community_high_voltage_distr_line_legth,community_low_voltage_distr_line_legth,community_elec_supply_consumption,community_resident_elec_consumption,no_elec_days,statistics_date,tcesunset1,tcesunset2,tcesunset3,tcesunset4,tcesunset5,tcesunset6,tcesunset7,tcesunset8,tcesunset9,tcesunset10,tcesunset11,tcesunset12,tcesunset13,lock_tables,check_status ");
			strSql.Append(" FROM T_community_elec_supply ");
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
			strSql.Append("select count(1) FROM T_community_elec_supply ");
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
			strSql.Append(")AS Row, T.*  from T_community_elec_supply T ");
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
			parameters[0].Value = "T_community_elec_supply";
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

