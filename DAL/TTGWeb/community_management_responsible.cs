using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:community_management_responsible
	/// </summary>
	public partial class community_management_responsible
	{
		public community_management_responsible()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_community_management_responsible");
			strSql.Append(" where community_id=@community_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.community_management_responsible model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_community_management_responsible(");
            strSql.Append("community_address,community_id,community_manage_charge_person_name,community_manage_charge_person_telphone,community_monitor_charge_person_name,community_monitor_charge_person_telphone,community_contacts_telephone,community_staff_telephone,tcmrunset1,tcmrunset2,tcmrunset3,tcmrunset4,tcmrunset5,tcmrunset6,community_name,community_contacts_name,community_manage_person_name)");
			strSql.Append(" values (");
            strSql.Append("@community_address,@community_id,@community_manage_charge_person_name,@community_manage_charge_person_telphone,@community_monitor_charge_person_name,@community_monitor_charge_person_telphone,@community_contacts_telephone,@community_staff_telephone,@tcmrunset1,@tcmrunset2,@tcmrunset3,@tcmrunset4,@tcmrunset5,@tcmrunset6,@community_name,@community_contacts_name,@community_manage_person_name)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_address", SqlDbType.NVarChar,200),
					new SqlParameter("@community_id", SqlDbType.VarChar,50),
					new SqlParameter("@community_manage_charge_person_name", SqlDbType.VarChar,20),
					new SqlParameter("@community_manage_charge_person_telphone", SqlDbType.VarChar,20),
					new SqlParameter("@community_monitor_charge_person_name", SqlDbType.VarChar,20),
					new SqlParameter("@community_monitor_charge_person_telphone", SqlDbType.VarChar,20),
					new SqlParameter("@community_contacts_telephone", SqlDbType.VarChar,20),
					new SqlParameter("@community_staff_telephone", SqlDbType.VarChar,20),
					new SqlParameter("@tcmrunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset6", SqlDbType.VarChar,50),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
                    new SqlParameter("@community_manage_person_name", SqlDbType.VarChar,50),
                    new SqlParameter("@community_contacts_name", SqlDbType.VarChar,50),
                                        };
			parameters[0].Value = model.community_address;
			parameters[1].Value = model.community_id;
			parameters[2].Value = model.community_manage_charge_person_name;
			parameters[3].Value = model.community_manage_charge_person_telphone;
			parameters[4].Value = model.community_monitor_charge_person_name;
			parameters[5].Value = model.community_monitor_charge_person_telphone;
			parameters[6].Value = model.community_contacts_telephone;
			parameters[7].Value = model.community_staff_telephone;
			parameters[8].Value = model.tcmrunset1;
			parameters[9].Value = model.tcmrunset2;
			parameters[10].Value = model.tcmrunset3;
			parameters[11].Value = model.tcmrunset4;
			parameters[12].Value = model.tcmrunset5;
			parameters[13].Value = model.tcmrunset6;
			parameters[14].Value = model.community_name;
            parameters[15].Value = model.community_manage_person_name;
            parameters[16].Value = model.community_contacts_name;

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
		public bool Update(TTG.Model.TTGWeb.community_management_responsible model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_community_management_responsible set ");
			strSql.Append("community_address=@community_address,");
			strSql.Append("community_manage_charge_person_name=@community_manage_charge_person_name,");
			strSql.Append("community_manage_charge_person_telphone=@community_manage_charge_person_telphone,");
			strSql.Append("community_monitor_charge_person_name=@community_monitor_charge_person_name,");
			strSql.Append("community_monitor_charge_person_telphone=@community_monitor_charge_person_telphone,");
			strSql.Append("community_contacts_telephone=@community_contacts_telephone,");
			strSql.Append("community_staff_telephone=@community_staff_telephone,");
			strSql.Append("tcmrunset1=@tcmrunset1,");
			strSql.Append("tcmrunset2=@tcmrunset2,");
			strSql.Append("tcmrunset3=@tcmrunset3,");
			strSql.Append("tcmrunset4=@tcmrunset4,");
			strSql.Append("tcmrunset5=@tcmrunset5,");
			strSql.Append("tcmrunset6=@tcmrunset6,");
			strSql.Append("community_name=@community_name");
			strSql.Append(" where community_id=@community_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_address", SqlDbType.NVarChar,200),
					new SqlParameter("@community_manage_charge_person_name", SqlDbType.VarChar,20),
					new SqlParameter("@community_manage_charge_person_telphone", SqlDbType.VarChar,20),
					new SqlParameter("@community_monitor_charge_person_name", SqlDbType.VarChar,20),
					new SqlParameter("@community_monitor_charge_person_telphone", SqlDbType.VarChar,20),
					new SqlParameter("@community_contacts_telephone", SqlDbType.VarChar,20),
					new SqlParameter("@community_staff_telephone", SqlDbType.VarChar,20),
					new SqlParameter("@tcmrunset1", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset2", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset3", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset4", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset5", SqlDbType.VarChar,50),
					new SqlParameter("@tcmrunset6", SqlDbType.VarChar,50),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@community_id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_address;
			parameters[1].Value = model.community_manage_charge_person_name;
			parameters[2].Value = model.community_manage_charge_person_telphone;
			parameters[3].Value = model.community_monitor_charge_person_name;
			parameters[4].Value = model.community_monitor_charge_person_telphone;
			parameters[5].Value = model.community_contacts_telephone;
			parameters[6].Value = model.community_staff_telephone;
			parameters[7].Value = model.tcmrunset1;
			parameters[8].Value = model.tcmrunset2;
			parameters[9].Value = model.tcmrunset3;
			parameters[10].Value = model.tcmrunset4;
			parameters[11].Value = model.tcmrunset5;
			parameters[12].Value = model.tcmrunset6;
			parameters[13].Value = model.community_name;
			parameters[14].Value = model.community_id;

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
		public bool Delete(string community_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_management_responsible ");
			strSql.Append(" where community_id=@community_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;

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
		public bool DeleteList(string community_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_community_management_responsible ");
			strSql.Append(" where community_id in ("+community_idlist + ")  ");
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
		public TTG.Model.TTGWeb.community_management_responsible GetModel(string community_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_address,community_id,community_manage_charge_person_name,community_manage_charge_person_telphone,community_monitor_charge_person_name,community_monitor_charge_person_telphone,community_contacts_telephone,community_staff_telephone,tcmrunset1,tcmrunset2,tcmrunset3,tcmrunset4,tcmrunset5,tcmrunset6,community_name from T_community_management_responsible ");
			strSql.Append(" where community_id=@community_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,50)			};
			parameters[0].Value = community_id;

			TTG.Model.TTGWeb.community_management_responsible model=new TTG.Model.TTGWeb.community_management_responsible();
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
		public TTG.Model.TTGWeb.community_management_responsible DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.community_management_responsible model=new TTG.Model.TTGWeb.community_management_responsible();
			if (row != null)
			{
				if(row["community_address"]!=null)
				{
					model.community_address=row["community_address"].ToString();
				}
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_manage_charge_person_name"]!=null)
				{
					model.community_manage_charge_person_name=row["community_manage_charge_person_name"].ToString();
				}
				if(row["community_manage_charge_person_telphone"]!=null)
				{
					model.community_manage_charge_person_telphone=row["community_manage_charge_person_telphone"].ToString();
				}
				if(row["community_monitor_charge_person_name"]!=null)
				{
					model.community_monitor_charge_person_name=row["community_monitor_charge_person_name"].ToString();
				}
				if(row["community_monitor_charge_person_telphone"]!=null)
				{
					model.community_monitor_charge_person_telphone=row["community_monitor_charge_person_telphone"].ToString();
				}
				if(row["community_contacts_telephone"]!=null)
				{
					model.community_contacts_telephone=row["community_contacts_telephone"].ToString();
				}
				if(row["community_staff_telephone"]!=null)
				{
					model.community_staff_telephone=row["community_staff_telephone"].ToString();
				}
				if(row["tcmrunset1"]!=null)
				{
					model.tcmrunset1=row["tcmrunset1"].ToString();
				}
				if(row["tcmrunset2"]!=null)
				{
					model.tcmrunset2=row["tcmrunset2"].ToString();
				}
				if(row["tcmrunset3"]!=null)
				{
					model.tcmrunset3=row["tcmrunset3"].ToString();
				}
				if(row["tcmrunset4"]!=null)
				{
					model.tcmrunset4=row["tcmrunset4"].ToString();
				}
				if(row["tcmrunset5"]!=null)
				{
					model.tcmrunset5=row["tcmrunset5"].ToString();
				}
				if(row["tcmrunset6"]!=null)
				{
					model.tcmrunset6=row["tcmrunset6"].ToString();
				}
				if(row["community_name"]!=null)
				{
					model.community_name=row["community_name"].ToString();
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
			strSql.Append("select community_address,community_id,community_manage_charge_person_name,community_manage_charge_person_telphone,community_monitor_charge_person_name,community_monitor_charge_person_telphone,community_contacts_telephone,community_staff_telephone,tcmrunset1,tcmrunset2,tcmrunset3,tcmrunset4,tcmrunset5,tcmrunset6,community_name ");
			strSql.Append(" FROM T_community_management_responsible ");
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
			strSql.Append(" community_address,community_id,community_manage_charge_person_name,community_manage_charge_person_telphone,community_monitor_charge_person_name,community_monitor_charge_person_telphone,community_contacts_telephone,community_staff_telephone,tcmrunset1,tcmrunset2,tcmrunset3,tcmrunset4,tcmrunset5,tcmrunset6,community_name ");
			strSql.Append(" FROM T_community_management_responsible ");
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
			strSql.Append("select count(1) FROM T_community_management_responsible ");
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
				strSql.Append("order by T.community_id desc");
			}
			strSql.Append(")AS Row, T.*  from T_community_management_responsible T ");
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
			parameters[0].Value = "T_community_management_responsible";
			parameters[1].Value = "community_id";
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

