using System;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Initialization;
namespace Csharp
{
    public class Update
    {
        //获取社区的编号用来查询社区的其他信息
        // 已经测试完成了
        public static string get_community_id
            (
            SqlConnection con,
            string province,
            string county_name,
            string community_name
            )
        {
            try
            {
                con.Open();
                string select_clause = "select community_id from T_Community_Base" +
                    " where community_province='{0}' and community_county='{1}'" +
                   " and community_name='{2}'";
                string sql = string.Format(select_clause, province, county_name, community_name);
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                string community_id = null;
                while (reader.Read())
                {
                    community_id = reader[0].ToString();
                    count++;
                }
                //if (count > 1)
                //{
                //    Console.WriteLine("小区名有重复或输入小区信息有错误！");
                //    community_id = null;
                //}
                con.Close();
                return community_id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                con.Close();
                return null;
            }
        }
        //获取每个表中每个字段的对应更新结果
        //已经测试过了
        public static float get_one_result(
            SqlConnection con,
            string county_name,
            string community_name,
            string result_column,
            int year
            )
        {
            try
            {
                con.Open();
                string select = "select last_year_quantity " +
                    " from T_project_physical  where  physical_class_content='{0}'"
                    + " and county_name='{1}' and " +
                    " community='{2}'";
                string sql = string.Format(select, result_column, county_name, community_name, year);
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                float result = 0;
                while (reader.Read())
                {
                    result += float.Parse(reader[0].ToString());
                }
                con.Close();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                con.Close();
                return -1;
            }
        }
        //更新一个表格的内容 （原数值加上结果值）
        //已经测试过了
        public static void update_community_info(
            SqlConnection con,
            int year,
            string county_name,
            string community_name,
            string community_id,
            string info_table,
            List<string> info,
            List<string> result_column
            )
        {
            try
            {
                //打开连接，进行查询
                con.Open();
                string select = "select * from {0}"
                    + " where community_id='{1}'" +
                   "and year(statistics_date)={2} order by statistics_date desc";
                string sql = string.Format(select, info_table, community_id, year);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable info_data = new DataTable();
                adapter.Fill(info_data);
                con.Close();   //下一个调用需要打开，所以此处先关闭连接
                DataRow new_row = info_data.NewRow();
                for (int j = 0; j < info_data.Columns.Count; j++)
                    new_row[j] = info_data.Rows[0][j];
                if (info.Count != result_column.Count)
                {
                    float add = 0;
                    for (int i = 0; i < info.Count-1; i++)
                    {
                        float data = get_one_result(con, county_name, community_name, result_column[i], year);
                        if (data == -1) throw new Exception();
                        new_row[info[i]] = float.Parse(new_row[info[i]].ToString()) + data;
                        if (i < 2) add += data;
                    }
                    new_row[info[info.Count - 1]] = float.Parse(new_row[info[info.Count - 1]].ToString()) + add;
                }
                else
                {
                    for (int i = 0; i < info.Count; i++)
                    {
                        float data = get_one_result(con, county_name, community_name, result_column[i], year);
                        if (data == -1) throw new Exception();
                        new_row[info[i]] = float.Parse(new_row[info[i]].ToString()) + data;
                    }
                }
                new_row["statistics_date"] = new DateTime(year + 1, 1, 1);
                info_data.Rows.Add(new_row);
                con.Open();
                SqlCommandBuilder cmdb = new SqlCommandBuilder(adapter);
                adapter.Update(info_data);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                con.Close();
            }
        }
        //public static void update_wcommunity(
        //   SqlConnection con,
        //   int year,
        //   string county_name,
        //   string community_name,
        //   string community_id,
        //   string info_table,
        //   List<string> info,
        //   List<string> result_column
        //   )
        //{
        //    try
        //    {
        //        //打开连接，进行查询
        //        con.Open();
        //        string select = "select * from {0}"
        //            + " where community_name='{1}'" +
        //           "and year(statistics_date)={2} order by statistics_date desc";
        //        string sql = string.Format(select, info_table, community_name, year);
        //        SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
        //        DataTable info_data = new DataTable();
        //        adapter.Fill(info_data);
        //        con.Close();   //下一个调用需要打开，所以此处先关闭连接
        //        DataRow new_row = info_data.NewRow();
        //        for (int j = 0; j < info_data.Columns.Count; j++)
        //            new_row[j] = info_data.Rows[0][j];
        //        if (info.Count != result_column.Count)
        //        {
        //            float add = 0;
        //            for (int i = 0; i < info.Count - 1; i++)
        //            {
        //                float data = get_one_result(con, county_name, community_name, result_column[i], year);
        //                if (data == -1) throw new Exception();
        //                new_row[info[i]] = float.Parse(new_row[info[i]].ToString()) + data;
        //                if (i < 2) add += data;
        //            }
        //            new_row[info[info.Count - 1]] = float.Parse(new_row[info[info.Count - 1]].ToString()) + add;
        //        }
        //        else
        //        {
        //            for (int i = 0; i < info.Count; i++)
        //            {
        //                float data = get_one_result(con, county_name, community_name, result_column[i], year);
        //                if (data == -1) throw new Exception();
        //                new_row[info[i]] = float.Parse(new_row[info[i]].ToString()) + data;
        //            }
        //        }
        //        new_row["statistics_date"] = new DateTime(year + 1, 1, 1);
        //        info_data.Rows.Add(new_row);
        //        con.Open();
        //        SqlCommandBuilder cmdb = new SqlCommandBuilder(adapter);
        //        adapter.Update(info_data);
        //        con.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.StackTrace);
        //        con.Close();
        //    }
        //}
        //另一种更新的方法（直接替代原数值）
        //已测试
        public static void update_community_info
                (
        SqlConnection con,
        int year,
        string community_id,
        string info_table,
        string result_table,
        List<string> info,
        List<string> result
        )
        {
            try
            {
                con.Open();
                string get_result = " select ";
                for (int i = 0; i < result.Count; i++)
                {
                    get_result += result[i] + ",";
                }
                get_result += "fill_time from {0} where community_id='{1}'" +
                  "and year(fill_time)={2} order by fill_time desc";
                string sql = string.Format(get_result, result_table, community_id, year);
                SqlDataAdapter result_adapter = new SqlDataAdapter(sql, con);
                DataTable result_data = new DataTable();
                result_adapter.Fill(result_data);
                string select = "select * from {0} where community_id='{1}' and "
                + " year(statistics_date)={2}  order by statistics_date desc";
                string sql2 = string.Format(select, info_table, community_id, year);
                SqlDataAdapter adapter = new SqlDataAdapter(sql2, con);
                DataTable info_data = new DataTable();
                adapter.Fill(info_data);
                DataRow new_row = info_data.NewRow();
                for (int i = 0; i < info_data.Columns.Count; i++)
                {
                    new_row[i] = info_data.Rows[0][i];
                }
                for (int i = 0; i < info.Count; i++)
                {
                    float data = float.Parse(result_data.Rows[0][result[i]].ToString());
                    if (data == -1) throw new Exception();
                    new_row[info[i]] = data;
                }
                new_row["statistics_date"] = new DateTime(year + 1, 1, 1);
                info_data.Rows.Add(new_row);
                SqlCommandBuilder cmdB = new SqlCommandBuilder(adapter);
                adapter.Update(info_data);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                con.Close();
            }
        }
        //这是更新fire_fighting表中的特殊的一项community_unreach_length
        public static void update_fire_fighting
           (
           SqlConnection con,
           string community_id,
           int year
           )
        {
            try
            {
                con.Open();
                string select = "select community_unreach_length from T_community_ff_problem where" +
                " community_id='{0}' community_fill_type='本底剩余' and complete_year={1}";
                select = string.Format(select, community_id, year + 1);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                float result = -1;
                while (reader.Read())
                {
                    result = reader.GetFloat(0);
                }
                reader.Close();
                string update = "update T_community_fire_fighting set community_ff_not_attain_pass_length={0} where " +
                    " community_id={1} and statistics_date={2}";
                update = string.Format(update, result, community_id, year + 1);
                SqlCommand update_table = new SqlCommand(update, con);
                update_table.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        //更新只需改动年份的表格
        public static void update_community_other_table
            (
            SqlConnection con,
            int year,
            string community_id,
            string table
            )
        {
            try
            {
                con.Open();
                string select = "select * from {0} where community_id='{1}' and year(statistics_date)={2} order by statistics_date desc";
                select = string.Format(select, table, community_id, year);
                SqlDataAdapter adapter = new SqlDataAdapter(select, con);
                DataTable info_data = new DataTable();
                adapter.Fill(info_data);
                DataRow new_row = info_data.NewRow();
                for (int i = 0; i < info_data.Columns.Count; i++)
                {
                    new_row[i] = info_data.Rows[0][i];
                }
                new_row["statistics_date"] = new DateTime(year + 1, 1, 1);
                info_data.Rows.Add(new_row);
                SqlCommandBuilder cmdB = new SqlCommandBuilder(adapter);
                adapter.Update(info_data);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                con.Close();
            }
        }
        //更新所有的只需更新年份的表格
        public static void update_community_all_other_table
           (
           SqlConnection con,
           int year,
           string community_id,
            List<string> tables
           )
        {
            for (int i = 0; i < tables.Count; i++)
            {
                update_community_other_table(con, year, community_id, tables[i]);
            }
        }

        
        //更新整个小区的所有的信息
        public static void update_community_all_info
            (
            SqlConnection con,
            string province_name,
            string county_name,
            string community_name,
            int year
            )
        {
            string community_id = get_community_id(con, province_name, county_name, community_name);
            if (community_id == null) throw new Exception();
            update_community_info(con, year, county_name, community_name, community_id,
                                  community_water_supply.water_supply_table,
                                  community_water_supply.info(), community_water_supply.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_water_drain.water_drain_table,
                                 community_water_drain.info(), community_water_drain.result());

            update_community_info(con, year, community_id, community_social_insurance.social_insurance_table,
                                 community_social_insurance.social_insurance_result_table,
                                 community_social_insurance.info(), community_social_insurance.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_electricity_supply.electricity_supply_table,
                                 community_electricity_supply.info(), community_electricity_supply.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_light.light_table,
                                 community_light.info(), community_light.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_greenland.greenland_table,
                                 community_greenland.info(), community_greenland.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_road.road_table,
                                 community_road.info(), community_road.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_parking_lot.parking_lot_table,
                                 community_parking_lot.info(), community_parking_lot.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_kindergarten.kindergarten_table,
                                 community_kindergarten.info(), community_kindergarten.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_medical.medical_talbe,
                                 community_medical.info(), community_medical.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                  community_sports.sports_table,
                                  community_sports.info(), community_sports.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_servece.service_table,
                                 community_servece.info(), community_servece.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_commerce.commerce_table,
                                 community_commerce.info(), community_commerce.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 community_water_supply.water_supply_table,
                                 community_water_supply.info(), community_water_supply.result());

            update_community_info(con, year, county_name, community_name, community_id,
                                 fire_fighting.fire_fighting_table,
                                 fire_fighting.info(), fire_fighting.result());
            update_fire_fighting(con, community_id, year);
            update_community_info(con, year, county_name, community_name, community_id,
                                 community_environment.environment_table,
                                 community_environment.info(), community_environment.result());
            update_community_info(con, year, community_id, community_store.store_table,
                                   community_store.store_result_table, community_store.info(),
                                   community_store.result());
            update_community_info(con, year, community_id, community_employment.employment_table,
                                  community_employment.employment_result_table, community_employment.info(),
                                  community_employment.result());
            update_community_all_other_table(con, year, community_id, OtherTables.getOtherTable());
        }
    }

}
