using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Maticsoft.DBUtility;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_tools
    {
        /// <summary>
        /// 数据库查询语句
        /// </summary>
        /// <param name="sql_str">sql语句</param>
        /// <param name="parameter">sql参数</param>
        /// <returns>查询结果</returns>
        public DataSet sql_query(string sql_str, SqlParameter[] parameter)
        {
            return DbHelperSQL.Query(sql_str, parameter);
        }
        /// <summary>
        /// 返回结果集中字段名为property的字段对应的值
        /// </summary>
        /// <param name="result">结果集</param>
        /// <param name="propety">字段名</param>
        /// <returns>值</returns>
        public object get_content(DataSet result, string propety)
        {
            return result.Tables[0].Rows[0][propety];
        }
        /// <summary>
        /// 获取结果集的第一行
        /// </summary>
        /// <param name="result">结果集</param>
        /// <returns>结果集第一行</returns>
        public DataRow get_content(DataSet result)
        {
            return result.Tables[0].Rows[0];
        }
        /// <summary>
        /// 执行sql语句并获取结果集的第一行
        /// </summary>
        /// <param name="sql_str">sql语句</param>
        /// <param name="parameter">参数</param>
        /// <returns>结果集第一行</returns>
        public DataRow get_content(string sql_str, SqlParameter[] parameter)
        {
            return DbHelperSQL.Query(sql_str, parameter).Tables[0].Rows[0];
        }
    }
}
