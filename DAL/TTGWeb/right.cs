using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:right
	/// </summary>
	public partial class right
	{
		public right()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string community_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_right");
			strSql.Append(" where community_id=@community_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = community_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.right model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_right(");
			strSql.Append("community_id,investigator_id,areaChief_id)");
			strSql.Append(" values (");
			strSql.Append("@community_id,@investigator_id,@areaChief_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@investigator_id", SqlDbType.VarChar,50),
					new SqlParameter("@areaChief_id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.community_id;
			parameters[1].Value = model.investigator_id;
			parameters[2].Value = model.areaChief_id;

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
		public bool Update(TTG.Model.TTGWeb.right model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_right set ");
			strSql.Append("investigator_id=@investigator_id,");
			strSql.Append("areaChief_id=@areaChief_id");
			strSql.Append(" where community_id=@community_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@investigator_id", SqlDbType.VarChar,50),
					new SqlParameter("@areaChief_id", SqlDbType.VarChar,50),
					new SqlParameter("@community_id", SqlDbType.VarChar,20)};
			parameters[0].Value = model.investigator_id;
			parameters[1].Value = model.areaChief_id;
			parameters[2].Value = model.community_id;

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
			strSql.Append("delete from T_right ");
			strSql.Append(" where community_id=@community_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)			};
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
			strSql.Append("delete from T_right ");
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
		public TTG.Model.TTGWeb.right GetModel(string community_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 community_id,investigator_id,areaChief_id from T_right ");
			strSql.Append(" where community_id=@community_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20)			};
			parameters[0].Value = community_id;

			TTG.Model.TTGWeb.right model=new TTG.Model.TTGWeb.right();
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
		public TTG.Model.TTGWeb.right DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.right model=new TTG.Model.TTGWeb.right();
			if (row != null)
			{
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["investigator_id"]!=null)
				{
					model.investigator_id=row["investigator_id"].ToString();
				}
				if(row["areaChief_id"]!=null)
				{
					model.areaChief_id=row["areaChief_id"].ToString();
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
			strSql.Append("select *");
			strSql.Append(" FROM T_right ");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" where investigator_id='" + strWhere+"'");
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
			strSql.Append(" community_id,investigator_id,areaChief_id ");
			strSql.Append(" FROM T_right ");
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
			strSql.Append("select count(1) FROM T_right ");
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
			strSql.Append(")AS Row, T.*  from T_right T ");
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
			parameters[0].Value = "T_right";
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
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM T_right");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 条件获取数据
        /// </summary>
        /// <param name="strWhereId"></param>
        /// <param name="strWhereName"></param>
        /// <param name="strWhereType"></param>
        /// <returns></returns>
        public DataSet GetConditionalData(string strWhereCom, string strWhereInv, string strWhereResp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *");
            strSql.Append(" FROM T_right where 1=1");
            if (strWhereCom.Trim() != "")
            {
                strSql.Append(" AND community_name='" + strWhereCom + "'");
            }
            if (strWhereInv.Trim() != "")
            {
                strSql.Append(" AND investigator_id='" + strWhereInv + "'");
            }
            if (strWhereResp.Trim() != "")
            {
                strSql.Append(" AND areaChief_id='" + strWhereResp + "'");
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取调查员负责小区的相关信息
        /// </summary>
        /// <param name="investigator_id"></param>
        /// <returns></returns>
        public DataSet get_community_msg(string investigator_id)
        {
            SqlParameter[] parameter = {
                                           new SqlParameter("@inves_id",SqlDbType.VarChar,50)
                                       };
            parameter[0].Value = investigator_id;

            string sql = "select community_id,community_name from T_right where investigator_id = @inves_id";
            return DbHelperSQL.Query(sql, parameter);
        }
        /// <summary>
        /// 根据片区负责人id查找所负责的小区
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetListForDdlCom(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct");
            strSql.Append(" community_id,areaChief_id,community_name");
            strSql.Append(" FROM T_right ");
            SqlParameter[] parameter = {
                                           new SqlParameter("@areaChief_id",SqlDbType.VarChar,50)
                                       };
            parameter[0].Value = strWhere;
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where areaChief_id=@areaChief_id");
            }
            DataSet ds = DbHelperSQL.Query(strSql.ToString(),parameter);
            //ds.Tables[0].Columns.Add("ListInves");
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    SqlParameter[] parameter1 = {
            //                               new SqlParameter("@userId",SqlDbType.VarChar,50)
            //                           };
            //    parameter1[0].Value = ds.Tables[0].Rows[i]["investigator_id"].ToString();
            //    String invesSql = "select userName from T_user where userId=@userId";
            //    DataSet dsinves = DbHelperSQL.Query(invesSql.ToString(), parameter1);
            //    ds.Tables[0].Rows[i]["ListInves"] = Convert.ToString(dsinves.Tables[0].Rows[0][0].ToString() + "(" + ds.Tables[0].Rows[i]["investigator_id"].ToString() + ")");
            //}
            ds.Tables[0].Columns.Add("ListCom");
            for (int m = 0; m < ds.Tables[0].Rows.Count; m++)
            {
                ds.Tables[0].Rows[m]["ListCom"] = Convert.ToString(ds.Tables[0].Rows[m]["community_name"].ToString() + "(" + ds.Tables[0].Rows[m]["community_id"].ToString() + ")");
            }
            return ds;
        }
        /// <summary>
        /// 根据片区负责人id查找相应的调查员
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetListForDdlIn(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct");
            strSql.Append(" investigator_id,areaChief_id");
            strSql.Append(" FROM T_right ");
            SqlParameter[] parameter = {
                                           new SqlParameter("@areaChief_id",SqlDbType.VarChar,50)
                                       };
            parameter[0].Value = strWhere;
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where areaChief_id=@areaChief_id");
            }
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameter);
            ds.Tables[0].Columns.Add("ListInves");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                SqlParameter[] parameter1 = {
                                           new SqlParameter("@userId",SqlDbType.VarChar,50)
                                       };
                parameter1[0].Value = ds.Tables[0].Rows[i]["investigator_id"].ToString();
                String invesSql = "select userName from T_user where userId=@userId";
                DataSet dsinves = DbHelperSQL.Query(invesSql.ToString(), parameter1);
                ds.Tables[0].Rows[i]["ListInves"] = Convert.ToString(dsinves.Tables[0].Rows[0][0].ToString() + "(" + ds.Tables[0].Rows[i]["investigator_id"].ToString() + ")");
            }
            ds.Tables[0].Columns.Add("ListCom");
            //for (int m = 0; m < ds.Tables[0].Rows.Count; m++)
            //{
            //    ds.Tables[0].Rows[m]["ListCom"] = Convert.ToString(ds.Tables[0].Rows[m]["community_name"].ToString() + "(" + ds.Tables[0].Rows[m]["community_id"].ToString() + ")");
            //}
            return ds;
        }
        //临时插入数据用，可删除
        public DataSet Existsssss()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct community_id,community_name,community_county,community_province from T_Community_Base");

            return DbHelperSQL.Query(strSql.ToString());
        }
        public void insertData() {
            DataSet ds = Existsssss();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (!Exists(ds.Tables[0].Rows[i][0].ToString()))
                {
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("insert into T_right(");
                    strSql.Append("community_id,community_name,community_county,community_province)");
                    strSql.Append(" values (");
                    strSql.Append("@community_id,@community_name,@community_county,@community_province)");
                    SqlParameter[] parameters = {
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@community_county", SqlDbType.VarChar,50),
                    new SqlParameter("@community_province", SqlDbType.VarChar,50)
                                        };
                    parameters[0].Value = ds.Tables[0].Rows[i][0].ToString();
                    parameters[1].Value = ds.Tables[0].Rows[i][1].ToString();
                    parameters[2].Value = ds.Tables[0].Rows[i][2].ToString();
                    parameters[3].Value = ds.Tables[0].Rows[i][3].ToString();
                    DbHelperSQL.Query(strSql.ToString(), parameters);
                }
            }
        }
		#endregion  ExtensionMethod
	}
}

