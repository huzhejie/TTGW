using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
	/// <summary>
	/// 数据访问类:excel_status
	/// </summary>
	public partial class excel_status
	{
		public excel_status()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TTG.Model.TTGWeb.excel_status model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_excel_status(");
			strSql.Append("fill_time,community_id,community_name,state,excel_name,investigator_id)");
			strSql.Append(" values (");
			strSql.Append("@fill_time,@community_id,@community_name,@state,@excel_name,@investigator_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50),
					new SqlParameter("@investigator_id", SqlDbType.VarChar,20)};
			parameters[0].Value = DateTime.Now.ToString();
			parameters[1].Value = model.community_id;
			parameters[2].Value = model.community_name;
			parameters[3].Value = model.state;
			parameters[4].Value = model.excel_name;
			parameters[5].Value = model.investigator_id;

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

        public bool Add(string id,string name,string file)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_excel_status(");
			strSql.Append("fill_time,community_id,community_name,state,excel_name,investigator_id)");
			strSql.Append(" values (");
			strSql.Append("@fill_time,@community_id,@community_name,@state,@excel_name,@investigator_id)");
            SqlParameter[] parameters = {
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50),
					new SqlParameter("@investigator_id", SqlDbType.VarChar,20)};
            parameters[0].Value = Convert.ToDateTime("2014/1/1");
            parameters[1].Value = id;
            parameters[2].Value = name;
            parameters[3].Value = 2;
            parameters[4].Value = file;
            parameters[5].Value = "DCY01";
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Update(TTG.Model.TTGWeb.excel_status model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_excel_status set ");
			strSql.Append("fill_time=@fill_time,");
			strSql.Append("community_id=@community_id,");
			strSql.Append("community_name=@community_name,");
			strSql.Append("state=@state,");
			strSql.Append("excel_name=@excel_name,");
			strSql.Append("investigator_id=@investigator_id");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50),
					new SqlParameter("@investigator_id", SqlDbType.VarChar,20)};
			parameters[0].Value = model.fill_time;
			parameters[1].Value = model.community_id;
			parameters[2].Value = model.community_name;
			parameters[3].Value = model.state;
			parameters[4].Value = model.excel_name;
			parameters[5].Value = model.investigator_id;

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
        /// 更新状态
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateState(TTG.Model.TTGWeb.excel_status model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_excel_status set ");
            strSql.Append("state=@state");     
            strSql.Append(" where community_name=@community_name and community_id=@community_id and excel_name=@excel_name and investigator_id=@investigator_id");
            SqlParameter[] parameters = {
					new SqlParameter("@fill_time", SqlDbType.DateTime),
					new SqlParameter("@community_id", SqlDbType.VarChar,20),
					new SqlParameter("@community_name", SqlDbType.VarChar,50),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@excel_name", SqlDbType.VarChar,50),
					new SqlParameter("@investigator_id", SqlDbType.VarChar,20)};
            parameters[0].Value = DateTime.Now.ToString();
            parameters[1].Value = model.community_id;
            parameters[2].Value = model.community_name;
            parameters[3].Value = model.state;
            parameters[4].Value = model.excel_name;
            parameters[5].Value = model.investigator_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_excel_status ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public TTG.Model.TTGWeb.excel_status GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 fill_time,community_id,community_name,state,excel_name,investigator_id from T_excel_status ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			TTG.Model.TTGWeb.excel_status model=new TTG.Model.TTGWeb.excel_status();
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
		public TTG.Model.TTGWeb.excel_status DataRowToModel(DataRow row)
		{
			TTG.Model.TTGWeb.excel_status model=new TTG.Model.TTGWeb.excel_status();
			if (row != null)
			{
				if(row["fill_time"]!=null && row["fill_time"].ToString()!="")
				{
					model.fill_time=DateTime.Parse(row["fill_time"].ToString());
				}
				if(row["community_id"]!=null)
				{
					model.community_id=row["community_id"].ToString();
				}
				if(row["community_name"]!=null)
				{
					model.community_name=row["community_name"].ToString();
				}
				if(row["state"]!=null && row["state"].ToString()!="")
				{
					model.state=int.Parse(row["state"].ToString());
				}
				if(row["excel_name"]!=null)
				{
					model.excel_name=row["excel_name"].ToString();
				}
				if(row["investigator_id"]!=null)
				{
					model.investigator_id=row["investigator_id"].ToString();
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
			strSql.Append("select fill_time,community_id,community_name,state,excel_name,investigator_id ");
			strSql.Append(" FROM T_excel_status ");
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
			strSql.Append(" fill_time,community_id,community_name,state,excel_name,investigator_id ");
			strSql.Append(" FROM T_excel_status ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 没有选择条件的记录总数
		/// </summary>
		/// <param name="strWhere"></param>
		/// <param name="sta"></param>
		/// <returns></returns>
		public int GetRecordCount(string strWhere,int sta)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) FROM T_excel_status WHERE 1=1");
            strSql.Append(" AND state=" + sta);     
			if(strWhere.Trim()!="")//in
			{
                strSql.Append(" AND investigator_id in(select distinct investigator_id FROM T_right WHERE areaChief_id='" + strWhere + "')");
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
        /// 只选择特定小区时相应的数据总数（一般情况下选择小区时已经确定了调查员，此处调查员按一般情况处理）
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="strcom"></param>
        /// <param name="sta"></param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere,string strInves,string strcom, int sta1,int sta2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_excel_status WHERE 1=1");
            if (strWhere.Trim() != "")//=
            {
                strSql.Append(" AND investigator_id in(SELECT DISTINCT investigator_id FROM T_right WHERE areaChief_id='" + strWhere + "')");
            }
            if (!string.IsNullOrEmpty(strInves.Trim()))
            {
                strSql.Append(" AND investigator_id='" + strInves + "'");
            }
            if (strcom.Trim() != "")
            {
                strSql.Append(" AND community_name='" + strcom + "'");
            }
            strSql.Append(" AND (state=" + sta1 + " OR state="+sta2+")");
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
        /// 综合分析员发布数据
        /// </summary>
        /// <param name="sta"></param>
        /// <returns></returns>
        public int GetRecordCountTotal(int sta)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_excel_status where 1=1");          
            strSql.Append(" AND state=" + sta);
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
        /// 综合分析员选择特定的小区或者调查员，此方法暂未使用
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="strcom"></param>
        /// <param name="sta"></param>
        /// <returns></returns>
        public int GetRecordCountTotal(string strinves,string strcom, int sta)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_excel_status WHERE 1=1");
            if (strinves.Trim() != "")
            {
                strSql.Append(" AND investigator_id in(select userId from T_user where userName= '" + strinves + "'");
            }
            if (strcom.Trim() != "")
            {
                strSql.Append(" AND community_name='" + strcom + "'");
            }
            strSql.Append(" AND state=" + sta);
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
        /// 综合分析员选定条件进行搜索
        /// </summary>
        /// <param name="strarea"></param>
        /// <param name="sta"></param>
        /// <returns></returns>
        public int GetRecordCountTotal(string strarea,string strinves,string strcom, int sta)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_excel_status WHERE 1=1");

            if (strarea.Trim() != "")
            {
                strSql.Append(" AND investigator_id in(SELECT DISTINCT investigator_id FROM T_right WHERE areaChief_id in(SELECT userId FROM T_user WHERE userName='" + strarea + "'))");
            }
            if (strinves.Trim() != "")
            {
                strSql.Append(" AND investigator_id in(select userId from T_user where userName='" + strinves + "')"); 
            }
            if (strcom.Trim() != "")
            {
                strSql.Append(" AND community_name='"+strcom+"'");
            }
            strSql.Append(" AND state=" + sta);
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
        //public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("SELECT * FROM ( ");
        //    strSql.Append(" SELECT ROW_NUMBER() OVER (");
        //    if (!string.IsNullOrEmpty(orderby.Trim()))
        //    {
        //        strSql.Append("order by T." + orderby );
        //    }
        //    else
        //    {
        //        strSql.Append("order by T. desc");
        //    }
        //    strSql.Append(")AS Row, T.*  from T_excel_status T ");
        //    if (!string.IsNullOrEmpty(strWhere.Trim()))
        //    {
        //        strSql.Append(" WHERE " + strWhere);
        //    }
        //    strSql.Append(" ) TT");
        //    strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
        //    return DbHelperSQL.Query(strSql.ToString());
        //}
       

        /// <summary>
        /// 选择特定的调查员时数据总数，调查员确定 则用”=“,此方法未使用
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="strcom"></param>
        /// <param name="sta"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
       	public DataSet GetListByPage2(string strWhere,int sta, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append(" ORDER BY fill_time desc");
            strSql.Append(")AS Row, T.*  from T_excel_status T WHERE 1=1");
			if (!string.IsNullOrEmpty(strWhere.Trim()))//=
			{
                strSql.Append(" AND investigator_id='" + strWhere + "'");
			}         
            strSql.Append(" AND state=" + sta);
             
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 在未审核页面用此方法，investigator_id in一个范围（暂时没有用这个方法）
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="sta"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataSet GetListByPage(string strWhere, int sta, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append(" ORDER BY fill_time desc");
            strSql.Append(")AS Row, T.*  from T_excel_status T WHERE 1=1");
            strSql.Append(" AND T.state=" + sta);
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append("AND T.investigator_id in(SELECT DISTINCT Tr.investigator_id FROM T_right Tr WHERE areaChief_id='" + strWhere + "')");
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 只选择特定小区时相应的数据（一般情况下选择小区时已经确定了调查员，此处调查员按一般情况处理）
        /// </summary>
        /// <param name="strWhereid"></param>
        /// <param name="strcom_Id"></param>
        /// <param name="sta"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataSet GetListByPage(string strWhereid,string str_inves_id,string strcom_Id, int sta1,int sta2, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append(" ORDER BY fill_time desc");
            strSql.Append(")AS Row, T.*  from T_excel_status T WHERE 1=1");
            if (!string.IsNullOrEmpty(strWhereid.Trim()))//片区负责人Id
            {
                strSql.Append(" AND T.investigator_id in(SELECT DISTINCT Tr.investigator_id FROM T_right Tr WHERE areaChief_id='" + strWhereid + "')");
            }
            if (!string.IsNullOrEmpty(str_inves_id.Trim()))//调查员Id
            {
                strSql.Append(" AND T.investigator_id='" + str_inves_id + "'");
            }
            if (!string.IsNullOrEmpty(strcom_Id.Trim()))//小区
            {
                strSql.Append(" AND T.community_id='" + strcom_Id + "'");
            }
            strSql.Append(" AND (T.state=" + sta1 + " OR T.state="+sta2+")");//表示已经审核的或者未审核的

            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 综合分析员未发布的数据
        /// </summary>
        /// <param name="sta"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataSet GetListByPageTotal(int sta, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append(" ORDER BY fill_time desc");
            strSql.Append(")AS Row, T.*  from T_excel_status T WHERE 1=1");
            strSql.Append(" AND state=" + sta);
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            ds.Tables[0].Columns.Add("areaChief_id");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string areaChiefSql = "select distinct areaChief_id from T_right where investigator_id='" + ds.Tables[0].Rows[i]["investigator_id"] + "'";
                DataSet ds2 = DbHelperSQL.Query(areaChiefSql.ToString());
                ds.Tables[0].Rows[i]["areaChief_id"] = ds2.Tables[0].Rows[0]["areaChief_id"];
            }
            return ds;
        }
        /// <summary>
        /// 综合分析员选择小区
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="sta"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataSet GetListByPageTotal(string strarea,string strinves,string strWhere, int sta, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append(" ORDER BY fill_time desc");
            strSql.Append(")AS Row, T.*  from T_excel_status T WHERE 1=1");
            if (strarea.Trim() != "")
            {
                strSql.Append(" AND T.investigator_id in(SELECT DISTINCT Tr.investigator_id FROM T_right Tr WHERE Tr.areaChief_id in(SELECT userId FROM T_user WHERE userName='" + strarea + "'))");
            }
            if (strinves.Trim() != "")
            {
                strSql.Append(" AND  T.investigator_id in(select userId from T_user where userName='" + strinves + "')");
            }
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND T.community_name='" + strWhere + "'");
            }
            strSql.Append(" AND T.state=" + sta);

            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            DataSet ds= DbHelperSQL.Query(strSql.ToString());
            ds.Tables[0].Columns.Add("areaChief_id");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string areaChiefSql = "select distinct areaChief_id from T_right where investigator_id='" + ds.Tables[0].Rows[i]["investigator_id"] + "'";
                DataSet ds2 = DbHelperSQL.Query(areaChiefSql.ToString());
                ds.Tables[0].Rows[i]["areaChief_id"] = ds2.Tables[0].Rows[0]["areaChief_id"];
            }
            return ds;
        }

        /// <summary>
        /// 选择了片区负责人后进行的相关搜索
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="sta"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public DataSet GetListByPageTotal(string strWhere, int sta, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append(" ORDER BY fill_time desc");
            strSql.Append(")AS Row, T.*  from T_excel_status T WHERE 1=1");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE investigator_id in(SELECT DISTINCT investigator_id FROM T_right WHERE areaChief_id in(SELECT userId FROM T_user WHERE userName='" + strWhere + "'))");
            }
          
            strSql.Append(" AND state=" + sta);

            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            ds.Tables[0].Columns.Add("areaChief_id");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string areaChiefSql = "select distinct areaChief_id from T_right where investigator_id='" + ds.Tables[0].Rows[i]["investigator_id"] + "'";
                DataSet ds2 = DbHelperSQL.Query(areaChiefSql.ToString());
                ds.Tables[0].Rows[i]["areaChief_id"] = ds2.Tables[0].Rows[0]["areaChief_id"];
            }
            return ds;
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
			parameters[0].Value = "T_excel_status";
			parameters[1].Value = "";
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
        /// 获取某一时间段内未审核的excel表名
        /// </summary>
        /// <returns></returns>
        public DataSet get_excel_msg(string inves_id, DateTime start, DateTime end, string community_id)
        {
            SqlParameter[] parameter = {
                                           new SqlParameter("@inves_id",SqlDbType.VarChar,20),
                                           new SqlParameter("@start",SqlDbType.DateTime),
                                           new SqlParameter("@end",SqlDbType.DateTime),
                                           new SqlParameter("@community_id",SqlDbType.VarChar,20)
                                       };
            parameter[0].Value = inves_id;
            parameter[1].Value = start;
            parameter[2].Value = end;
            parameter[3].Value = community_id;
            string sql = "select excel_name from T_excel_status where investigator_id = @inves_id and community_id = @community_id and fill_time>=@start and fill_time <= @end and state = 0";
            return DbHelperSQL.Query(sql, parameter);
        }


		#endregion  ExtensionMethod
	}
}

