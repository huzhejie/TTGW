using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.GET
{
    public class get_search
    {
        private get_tools gt = new get_tools();
        /// <summary>
        /// 根据省市查询区县
        /// </summary>
        /// <param name="province">省市名</param>
        /// <returns>区县名</returns>
        public DataSet get_county(string province)
        {
            string sql = "select distinct community_county from T_Community_Base where community_province = @province";
            SqlParameter[] parameter = {
                                           new SqlParameter("@province", SqlDbType.VarChar, 50){Value = province}
                                       };
            return gt.sql_query(sql, parameter);
        }
        /// <summary>
        /// 根据省市名区县名选择小区名
        /// </summary>
        /// <param name="province">省市名</param>
        /// <param name="county">区县名</param>
        /// <returns>小区名</returns>
        public DataSet get_community(string province, string county)
        {
            string sql = "select distinct community_name,community_county,community_province from T_Community_Base where community_province = @province and community_county = @county";
            SqlParameter[] parameter = {
                                           new SqlParameter("@province", SqlDbType.VarChar, 50){Value = province},
                                           new SqlParameter("@county", SqlDbType.VarChar, 50){Value = county}
                                       };
            return gt.sql_query(sql, parameter);
        }
        /// <summary>
        /// 根据小区名查询小区信息
        /// </summary>
        /// <param name="community">小区名</param>
        /// <returns>小区信息</returns>
        public DataSet get_province_and_county(string community)
        {
            string sql = "select distinct community_name,community_county,community_province  from T_Community_Base where community_name = @community";
            SqlParameter[] parameter = {
                                           new SqlParameter("@community", SqlDbType.VarChar, 50){Value = community}
                                       };
            return gt.sql_query(sql, parameter);
        }
    }
}
