using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TTG.DAL.TTGWeb
{
    /// <summary>
    /// 数据访问类:notification_info
    /// </summary>
    public partial class notification_info
    {
        public notification_info()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        //public bool Add(TTG.Model.TTGWeb.notification_info model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("insert into T_notification_info(");
        //    strSql.Append("nf_id,nf_title,nf_content,nf_time,nf_depart,nf_type,nf_image)");
        //    strSql.Append(" values (");
        //    strSql.Append("@nf_id,@nf_title,@nf_content,@nf_time,@nf_depart,@nf_type,@nf_image)");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@nf_id", SqlDbType.Int,4),
        //            new SqlParameter("@nf_title", SqlDbType.VarChar,100),
        //            new SqlParameter("@nf_content", SqlDbType.VarChar,1000),
        //            new SqlParameter("@nf_time", SqlDbType.Date,3),
        //            new SqlParameter("@nf_depart", SqlDbType.VarChar,20),
        //            new SqlParameter("@nf_type", SqlDbType.VarChar,20),
        //            new SqlParameter("@nf_image", SqlDbType.Int,4)};
        //    parameters[0].Value = model.nf_id;
        //    parameters[1].Value = model.nf_title;
        //    parameters[2].Value = model.nf_content;
        //    parameters[3].Value = model.nf_time;
        //    parameters[4].Value = model.nf_depart;
        //    parameters[5].Value = model.nf_type;
        //    parameters[6].Value = model.nf_image;

        //    int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        //    if (rows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool Add(TTG.Model.TTGWeb.notification_info model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("insert into T_notification_info(");
        //    strSql.Append("nf_title,nf_content,nf_time,nf_depart,nf_type,nf_image)");
        //    strSql.Append(" values (");
        //    strSql.Append("@nf_title,@nf_content,@nf_time,@nf_depart,@nf_type,@nf_image)");
        //    SqlParameter[] parameters = {
					
        //            new SqlParameter("@nf_title", SqlDbType.VarChar,100),
        //            new SqlParameter("@nf_content", SqlDbType.VarChar,1000),
        //            new SqlParameter("@nf_time", SqlDbType.Date,3),
        //            new SqlParameter("@nf_depart", SqlDbType.VarChar,20),
        //            new SqlParameter("@nf_type", SqlDbType.VarChar,20),
        //            new SqlParameter("@nf_image", SqlDbType.Int,4)};
           
        //    parameters[0].Value = model.nf_title;
        //    parameters[1].Value = model.nf_content;
        //    parameters[2].Value = model.nf_time;
        //    parameters[3].Value = model.nf_depart;
        //    parameters[4].Value = model.nf_type;
        //    parameters[5].Value = model.nf_image;

        //    int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        //    if (rows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool Add(TTG.Model.TTGWeb.notification_info model)
        {
            string sql = "insert into T_notification_info (nf_title,nf_content,nf_time,nf_depart,nf_type,nf_image) values ('" + model.nf_title + "','" + model.nf_content + "','" + model.nf_time+"','"+model.nf_depart+"','"+model.nf_type+"','"+model.nf_image+"')";
            DbHelperSQL.Query(sql);
            return true;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        //public bool Update(TTG.Model.TTGWeb.notification_info model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("update T_notification_info set ");           
        //    strSql.Append("nf_title=@nf_title,");
        //    strSql.Append("nf_content=@nf_content,");
        //    strSql.Append("nf_time=@nf_time,");
        //    strSql.Append("nf_depart=@nf_depart,");
        //    strSql.Append("nf_type=@nf_type,");
        //    strSql.Append("nf_image=@nf_image");
        //    strSql.Append(" where nf_id=@nf_id");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@nf_id", SqlDbType.Int,4),
        //            new SqlParameter("@nf_title", SqlDbType.VarChar,100),
        //            new SqlParameter("@nf_content", SqlDbType.VarChar,1000),
        //            new SqlParameter("@nf_time", SqlDbType.Date,3),
        //            new SqlParameter("@nf_depart", SqlDbType.VarChar,20),
        //            new SqlParameter("@nf_type", SqlDbType.VarChar,20),
        //            new SqlParameter("@nf_image", SqlDbType.Int,4)};
        //    parameters[0].Value = model.nf_id;
        //    parameters[1].Value = model.nf_title;
        //    parameters[2].Value = model.nf_content;
        //    parameters[3].Value = model.nf_time;
        //    parameters[4].Value = model.nf_depart;
        //    parameters[5].Value = model.nf_type;
        //    parameters[6].Value = model.nf_image;

        //    int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        //    if (rows > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public bool Update(TTG.Model.TTGWeb.notification_info model)
        {
            string sql = "update T_notification_info set nf_title='" + model.nf_title + "',nf_content='" + model.nf_content + "',nf_time='" + model.nf_time + "',nf_depart='" + model.nf_depart + "',nf_type='" + model.nf_type + "',nf_image='" + model.nf_image + "' where nf_id='"+model.nf_id+"'";
            DbHelperSQL.Query(sql);
            return true;
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_notification_info ");
            strSql.Append(" where nf_id="+id);
            SqlParameter[] parameters = {
               };
       
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
        /// 得到一个对象实体
        /// </summary>
        public TTG.Model.TTGWeb.notification_info GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 nf_id,nf_title,nf_content,nf_time,nf_depart,nf_type,nf_image from T_notification_info ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

            TTG.Model.TTGWeb.notification_info model = new TTG.Model.TTGWeb.notification_info();
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TTG.Model.TTGWeb.notification_info DataRowToModel(DataRow row)
        {
            TTG.Model.TTGWeb.notification_info model = new TTG.Model.TTGWeb.notification_info();
            if (row != null)
            {
                if (row["nf_id"] != null && row["nf_id"].ToString() != "")
                {
                    model.nf_id = int.Parse(row["nf_id"].ToString());
                }
                if (row["nf_title"] != null)
                {
                    model.nf_title = row["nf_title"].ToString();
                }
                if (row["nf_content"] != null)
                {
                    model.nf_content = row["nf_content"].ToString();
                }
                if (row["nf_time"] != null && row["nf_time"].ToString() != "")
                {
                    model.nf_time = DateTime.Parse(row["nf_time"].ToString());
                }
                if (row["nf_depart"] != null)
                {
                    model.nf_depart = row["nf_depart"].ToString();
                }
                if (row["nf_type"] != null)
                {
                    model.nf_type = row["nf_type"].ToString();
                }
                if (row["nf_image"] != null && row["nf_image"].ToString() != "")
                {
                    model.nf_image = int.Parse(row["nf_image"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nf_id,nf_title,nf_content,nf_time,nf_depart,nf_type,nf_image ");
            strSql.Append(" FROM T_notification_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" nf_id,nf_title,nf_content,convert(varchar(10),nf_time,120) as date,nf_depart,nf_type,nf_image ");
            strSql.Append(" FROM T_notification_info");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where nf_type='" + strWhere+"'");
            }
            //strSql.Append(" order by " + filedOrder);
            strSql.Append(" order by nf_time desc");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得某行数据
        /// </summary>
        public DataSet GetOne(int intWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" nf_id,nf_title,nf_content,convert(varchar(10),nf_time,120) as date,nf_depart,nf_type,nf_image ");
            strSql.Append(" FROM T_notification_info ");
            if (intWhere != null)
            {
                strSql.Append(" where nf_id='" + intWhere + "'");
            }
            //strSql.Append(" order by " + filedOrder);
            strSql.Append(" order by nf_time desc");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_notification_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where nf_type='" + strWhere + "'");
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

     
        public int GetRecordCount(string strWhere1, string strWhere2, string strWhere3)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_notification_info where 1=1 ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" AND nf_type='" + strWhere1 + "'");
            }
            if (!string.IsNullOrEmpty(strWhere2.Trim()))
            {
                strSql.Append(" AND nf_depart='" + strWhere2 + "'");
            }

            if (!string.IsNullOrEmpty(strWhere3.Trim()))
            {
                strSql.Append(" AND convert(varchar(10),nf_time,120) ='" + strWhere3 + "'");
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from T_notification_info T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere,int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append("order by T.nf_time");                  
            strSql.Append(")AS Row, T.*  from T_notification_info T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE T.nf_type='" + strWhere + "'");
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据条件分页获取数据列表(类型，发布者，发布时间)
        /// </summary>
        public DataSet GetListByPage(string strWhere1, string strWhere2, string strWhere3, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            strSql.Append("order by T.nf_time desc");
            strSql.Append(")AS Row, T.*  from T_notification_info T WHERE 1=1 ");
            if (!string.IsNullOrEmpty(strWhere1.Trim()))
            {
                strSql.Append(" AND T.nf_type='" + strWhere1+ "'");
            }
            if (!string.IsNullOrEmpty(strWhere2.Trim()))
            {
                strSql.Append(" AND T.nf_depart='" + strWhere2 + "'");
            }
            if (!string.IsNullOrEmpty(strWhere3.Trim()))
            {
                strSql.Append(" AND convert(varchar(10),nf_time,120) = '" + strWhere3 + "'");
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
            parameters[0].Value = "T_notification_info";
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetDepart(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct nf_depart");
            strSql.Append(" FROM T_notification_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion  ExtensionMethod
    }
}

