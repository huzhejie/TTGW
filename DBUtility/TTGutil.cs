using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace TTG.DBUtility
{
    public class TTGutil
    {
        public static SortedList NAME_OBJECT = new SortedList();
        public static String getchinese(String english)
        {
            String translation = null;
            String sqlstr = " SELECT chinese FROM effiect_translate where english = '" + english + "'";
            SqlDataReader sdr = Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(sqlstr);
            if (!sdr.HasRows)
            {
                return null;
            }
            else
            {
                if (sdr.Read())
                {

                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        translation = sdr.GetString(0);
                    }
                }
            }
            sdr.Close();
            return translation;
        }
        public static String getenglish(String chinese)
        {
            String translation = null;
            String sqlstr = " SELECT english FROM effiect_translate where chinese = '" + chinese + "'";
            SqlDataReader sdr = Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(sqlstr);
            if (!sdr.HasRows)
            {
                return null;
            }
            else
            {
                if (sdr.Read())
                {

                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        translation = sdr.GetString(0);
                    }
                }
            }
            sdr.Close();
            return translation;
        }
        public static DateTime getLastestDate()
        {
            DateTime dt = new DateTime();
            String sqlstr = "SELECT MAX(statistics_date) FROM T_community_Base ";
            SqlDataReader sdr = Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(sqlstr);
            if (!sdr.HasRows)
            {
                throw new Exception("查询出错");
            }
            else
            {
                if (sdr.Read())
                {

                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        dt = sdr.GetDateTime(0);

                    }
                }
            }
            sdr.Close();
            return new DateTime(dt.Year, dt.Month, dt.Day);
        }
        public static ArrayList GetStatisticsDates(String table_name, String community_id, DateTime statistics_date_start, DateTime statistics_date_end)
        {
            String sqlstr = "SELECT DISTINCT statistics_date FROM T_community_Base WHERE community_id=" + community_id + " AND (statistics_date BETWEEN " + statistics_date_start + " AND" + statistics_date_end + ")";//(SELECT MAX(statistics_date) FROM  T_community_population_info)
            SqlDataReader sdr = Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(sqlstr);
            ArrayList dt = new ArrayList();
            if (!sdr.HasRows)
            {
                throw new Exception("查询出错");
            }
            else
            {
                while (sdr.Read())
                {

                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        dt.Add(new DateTime(sdr.GetDateTime(0).Year, sdr.GetDateTime(0).Month, sdr.GetDateTime(0).Day));

                    }
                }
            }
            sdr.Close();
            return dt;
        }





    }
}
