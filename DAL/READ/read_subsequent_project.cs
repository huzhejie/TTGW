using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.International.Converters.PinYinConverter;

namespace TTG.DAL.READ
{
    public class read_subsequent_project
    {
        private read_excel re = new read_excel();
        private const int title_row = 1;
        private int start_row = 5;
        private const string excel_name = "2014及之后项目";
        private Model.TTGWeb.subsequent_project model;              //父项目
        private Model.TTGWeb.subproject_new submodel;               //子项目
        private Model.TTGWeb.grandson_project gramodel;             //孙项目

        public read_subsequent_project(string path)
        {
            re.init(path);
        }
        /// <summary>
        /// 读取并插入
        /// </summary>
        public void read_and_insert()
        {
            int maxrow = re.getMaxRow();
            int temp = start_row;
            string str = Convert.ToString(re.readcell(temp, 1));
            while (temp < maxrow && !str.Equals("0"))
            {
                int seed = read_project();
                if (!new DAL.TTGWeb.subsequent_project().Add(model))
                    throw new Exception("2014及之后专项资金表插入失败！");
                temp += seed;
                try
                {
                    str = Convert.ToString(re.readcell(temp, 1));
                }
                catch
                {
                    break;
                }

            }
        }
        /// <summary>
        /// 读取父项目表
        /// </summary>
        /// <returns>父项目横跨行数</returns>
        private int read_project()
        {
            int span_rows = re.getSpanRows(start_row, 1);
            int column = 0;
            model = new Model.TTGWeb.subsequent_project()
            {
                fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
            };
            string title = Convert.ToString(re.readcell(title_row, column));
            while (!title.Equals("单项工程情况"))
            {
                if (title.Equals("计划投资（万元）"))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        title = Convert.ToString(re.readcell(title_row + 1, column));
                        add_data_project(column, title);
                        column++;
                    }
                }
                else if (is_exist(title, "到位投资"))
                {
                    int[] date = get_two_nums(title);
                    Model.TTGWeb.investment_place_situation ips = new Model.TTGWeb.investment_place_situation()
                    {
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        project_id = model.project_id,
                        year = date[0],
                        month = date[1],
                        special_support_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        conterpart_founds = Convert.ToDecimal(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.investment_place_situation().Add(ips))
                        throw new Exception("投资到位表插入失败！");
                }
                else if (title.Equals("年份"))
                {
                    add_data_project(column, title);
                    int year = Convert.ToInt32(re.readcell(start_row, column++));
                    string county = model.county_name;
                }
                else if (title.Equals("项目编号"))
                {
                    add_data_project(column, title);
                    column++;
                }
                else if (title.Equals("项目总体形象进度"))
                {
                    title = Convert.ToString(re.readcell(title_row + 1, column));
                    int year = get_one_num(title);
                    Model.TTGWeb.figure_progress fp = new Model.TTGWeb.figure_progress()
                    {
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        project_id = model.project_id,
                        year = year,
                        march_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                        june_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                        september_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                        december_progress = Convert.ToDecimal(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.figure_progress().Add(fp))
                        throw new Exception("项目总体形象进度表插入失败！");
                }
                else
                {
                    add_data_project(column, title);
                    column++;
                }

                title = Convert.ToString(re.readcell(title_row, column));
            }

            //读取子项目表
            int temp = 0;
            while (temp < span_rows)
            {
                try
                {
                    string content = Convert.ToString(re.readcell(start_row, column + 1));
                    if (!content.Equals("0"))
                    {
                        int seed = read_subproject(column);
                        if (!new DAL.TTGWeb.subproject_new().Add(submodel))
                            throw new Exception("子项目表插入失败！");
                        temp += seed;
                    }
                    else
                    {
                        break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
                
            }

            return span_rows;
        }
        /// <summary>
        /// 读取子项目表
        /// </summary>
        /// <param name="column">子项目开始列号</param>
        /// <returns>子项目横跨行数</returns>
        private int read_subproject(int column)
        {
            int span_rows = re.getSpanRows(start_row, ++column);

            //读取子项目表
            DAL.TTGWeb.subproject_new sn = new TTGWeb.subproject_new();
            int spnum = sn.GetProjectCount(model.project_id);
            submodel = new Model.TTGWeb.subproject_new()            
            {
                fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                project_id = model.project_id,
                subproject_id =Convert.ToString(re.readcell(start_row,column-1)),
                subproject_name = Convert.ToString(re.readcell(start_row, column++)),
                involve_community = Convert.ToString(re.readcell(start_row,column++)),
                project_owner = Convert.ToString(re.readcell(start_row,column++)),
                main_construct_content = Convert.ToString(re.readcell(start_row,column++)),
                start_date = Convert.ToString(re.readcell(start_row,column+8)),
                finish_date = Convert.ToString(re.readcell(start_row,column+9)),
                project_community_description = Convert.ToString(re.readcell(start_row,column+10)),
                radial_project = Convert.ToString(re.readcell(start_row,column+11))
            };

            string title = Convert.ToString(re.readcell(title_row+2,column));
            Model.TTGWeb.figure_progress fpm = new Model.TTGWeb.figure_progress()
            {
                fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                year = get_one_num(title),
                project_id = submodel.subproject_id,
                march_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                june_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                september_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                december_progress = Convert.ToDecimal(re.readcell(start_row, column++))
            };
            if (!new DAL.TTGWeb.figure_progress().Add(fpm))
                throw new Exception("项目形象进度表插入失败！");
            title = Convert.ToString(re.readcell(title_row + 2, column));
            Model.TTGWeb.construction_phase cp = new Model.TTGWeb.construction_phase()
            {
                project_id = submodel.subproject_id,
                fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                year = get_one_num(title),
                march_phase = Convert.ToString(re.readcell(start_row, column++)),
                june_phase = Convert.ToString(re.readcell(start_row, column++)),
                september_phase = Convert.ToString(re.readcell(start_row, column++)),
                december_phase = Convert.ToString(re.readcell(start_row, column++))
            };
            if (!new DAL.TTGWeb.construction_phase().Add(cp))
                throw new Exception("项目建设阶段表插入失败！");
            column = column+3;
            //读取孙项目表
            for (int i = 0; i < span_rows; i++)
            {
                try
                {
                    string content = Convert.ToString(re.readcell(start_row, column + 1));
                    if (!content.Equals("0"))
                    {
                        read_grandson_project(column+1);
                        if (!new DAL.TTGWeb.grandson_project().Add(gramodel))
                            throw new Exception("孙项目表插入失败！");
                        start_row++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
                
            }
            return span_rows;
        }
        /// <summary>
        /// 读取孙项目表
        /// </summary>
        /// <param name="column">孙项目表起始行</param>
        private void read_grandson_project(int column)
        {
            gramodel = new Model.TTGWeb.grandson_project()
            {
                fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                subproject_id = submodel.subproject_id,
                grandson_project_id = submodel.subproject_id+"-"+Convert.ToString(re.readcell(start_row,column)),
                grandson_project_type = Convert.ToString(re.readcell(start_row,column+1)),
                remark = Convert.ToString(re.readcell(start_row,column+26))
            };
            column = column + 2;
            int maxcolumn = re.getMaxColNum(start_row);
            string title = Convert.ToString(re.readcell(title_row + 2, column));
            while (true)
            {
                
                if (title.Equals("工程类别投资构成（万元）"))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        title = Convert.ToString(re.readcell(title_row + 3, column));
                        add_data_grandproject(column++, title + "s");
                    }

                }
                else if (is_exist(title, "完成投资情况"))
                {
                    int[] date = get_two_nums(title);
                    Model.TTGWeb.investment_finish_situation ifs = new Model.TTGWeb.investment_finish_situation()
                    {
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        project_id = gramodel.grandson_project_id,
                        year = date[0],
                        month = date[1],
                        summary = Convert.ToDecimal(re.readcell(start_row, column++)),
                        special_support_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        conterpart_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        other_matching_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        other_founds = Convert.ToDecimal(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.investment_finish_situation().Add(ifs))
                        throw new Exception("项目完成投资情况表插入失败！");

                }
                if (column >= maxcolumn-1)
                    break;
                title = Convert.ToString(re.readcell(title_row + 2, column));
            }
        }
        /// <summary>
        /// 向孙项目表中添加数据
        /// </summary>
        /// <param name="column">列号</param>
        /// <param name="title">标题</param>
        private void add_data_grandproject(int column, string title)
        {
            DAL.TTGWeb.excel_special_structure ess = new TTGWeb.excel_special_structure();
            Model.TTGWeb.excel_special_structure essmodel = ess.GetModel(title, excel_name);

            PropertyInfo[] properties = gramodel.GetType().GetProperties();
            int index = 0;
            for (; index < properties.Length; index++)
            {
                if (properties[index].Name.Equals(essmodel.property))
                {
                    break;
                }
            }

            if (index != -1)
            {
                string type = properties[index].PropertyType.Name;
                object obj = re.readcell(start_row, column);
                if (type.Equals("String"))
                    properties[index].SetValue(gramodel, re.replaceBlank(Convert.ToString(obj)), null);
                else if (type.Equals("Int32"))
                    properties[index].SetValue(gramodel, Convert.ToInt32(obj), null);
                else if (type.Equals("Decimal"))
                    properties[index].SetValue(gramodel, Convert.ToDecimal(obj), null);
                else if (type.Equals("DateTime"))
                    properties[index].SetValue(gramodel, DateTime.FromOADate(Convert.ToDouble(obj)), null);
                else
                {
                    string in_type = Nullable.GetUnderlyingType(properties[index].PropertyType).ToString();
                    if (in_type.Equals("System.Int32"))
                        properties[index].SetValue(gramodel, Convert.ToInt32(obj), null);
                    else if (in_type.Equals("System.Decimal"))
                        properties[index].SetValue(gramodel, Convert.ToDecimal(obj), null);
                    else if (in_type.Equals("System.DateTime"))
                        properties[index].SetValue(gramodel, DateTime.FromOADate(Convert.ToDouble(obj)), null);
                    else
                        throw new Exception("找不到字段的类型：" + in_type);
                }
            }
            else
            {
                throw new Exception("找不到字段：" + essmodel.property);
            }
        }
        /// <summary>
        /// 向父项目表中添加数据
        /// </summary>
        /// <param name="column">列号</param>
        /// <param name="title">标题</param>
        private void add_data_project(int column, string title)
        {
            DAL.TTGWeb.excel_special_structure ess = new TTGWeb.excel_special_structure();
            Model.TTGWeb.excel_special_structure essmodel = ess.GetModel(title, excel_name);

            PropertyInfo[] properties = model.GetType().GetProperties();
            int index = 0;
            for (; index < properties.Length; index++)
            {
                if (properties[index].Name.Equals(essmodel.property))
                {
                    break;
                }
            }

            if (index != -1)
            {
                string type = properties[index].PropertyType.Name;
                object obj = re.readcell(start_row, column);
                if (type.Equals("String"))
                    properties[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                else if (type.Equals("Int32"))
                    properties[index].SetValue(model, Convert.ToInt32(obj), null);
                else if (type.Equals("Decimal"))
                    properties[index].SetValue(model, Convert.ToDecimal(obj), null);
                else if (type.Equals("DateTime"))
                    properties[index].SetValue(model, DateTime.FromOADate(Convert.ToDouble(obj)), null);
                else
                {
                    string in_type = Nullable.GetUnderlyingType(properties[index].PropertyType).ToString();
                    if (in_type.Equals("System.Int32"))
                        properties[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (in_type.Equals("System.Decimal"))
                        properties[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else if (in_type.Equals("System.DateTime"))
                        properties[index].SetValue(model, DateTime.FromOADate(Convert.ToDouble(obj)), null);
                    else
                        throw new Exception("找不到字段的类型：" + in_type);
                }
            }
            else
            {
                throw new Exception("找不到字段：" + essmodel.property);
            }
        }
        /// <summary>
        /// 字符串str是否包含子字符串cstr
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="cstr">子字符串</param>
        /// <returns>是否包含</returns>
        private bool is_exist(string str, string cstr)
        {
            int index = str.IndexOf(cstr);
            if (index == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 从字符串str中提取年月份
        /// </summary>
        /// <param name="str">目标字符串</param>
        /// <returns>包含年月份的int数组</returns>
        private int[] get_two_nums(string str)
        {
            int[] num = new int[2];
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    string tnum = "";
                    while (Char.IsDigit(str[i]))
                    {
                        tnum += str[i++];
                    }
                    num[count++] = Convert.ToInt32(tnum);
                }
                if (count == 2)
                    break;
            }
            return num;
        }

        /// <summary>
        /// 获取区县的首字母大写
        /// </summary>
        /// <param name="county">区县名</param>
        /// <returns>区县名的首字母大写</returns>
        private string getPinyin(string county)
        {
            string pin = "";

            int index = county.IndexOf("县");
            if (index == county.Length - 1 && county.Length > 2)
            {
                county = county.Substring(0, county.Length - 1);
            }

            foreach (char x in county)
            {
                try
                {
                    ChineseChar chinese = new ChineseChar(x);
                    string pinyin = chinese.Pinyins[0].ToString();
                    pin += pinyin.Substring(0, 1);
                }
                catch
                {
                    pin += x.ToString().ToUpper();
                }
            }

            return pin;
        }
        /// <summary>
        /// 将项目编号编程三位格式的字符串
        /// </summary>
        /// <param name="count">项目编号的数字形式</param>
        /// <returns>项目编号的字符串形式</returns>
        private string addNumBits(int count)
        {
            string num = "";
            if (count < 10)
            {
                num = "00" + count.ToString();
            }
            else if (count < 100)
            {
                num = "0" + count.ToString();
            }
            else
            {
                num = count.ToString();
            }
            return num;
        }
        /// <summary>
        /// 获取子项目或孙项目编号
        /// </summary>
        /// <param name="id">父项目编号</param>
        /// <param name="num">子项目个数</param>
        /// <returns>子项目编号</returns>
        private string get_subproject_id(string id, int num)
        {
            string nums = num > 9 ? num.ToString() : "0" + num.ToString();
            return id + "-" + nums;
        }
        /// <summary>
        /// 获取字符串s中的第一个数字
        /// </summary>
        /// <param name="s">目标字符串</param>
        /// <returns>字符串中的第一个数字</returns>
        private int get_one_num(string s)
        {
            string num = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]))
                {
                    for (; i < s.Length && Char.IsNumber(s[i]); i++)
                    {
                        num += s[i];
                    }
                    break;
                }
            }
            return Convert.ToInt32(num);
        }
        /// <summary>
        /// 将百分数字符串转换成小数
        /// </summary>
        /// <param name="percent">百分数字符串</param>
        /// <returns>小数</returns>
        private decimal change_percentage(string percent)
        {
            string temp = percent.Substring(0, percent.Length - 1);
            return Convert.ToDecimal(temp);
        }
    }
}
