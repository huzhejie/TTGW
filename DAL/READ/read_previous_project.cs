using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.International.Converters.PinYinConverter;

namespace TTG.DAL.READ
{
    public class read_previous_project
    {
        private read_excel re = new read_excel();
        private const int title_row = 1;
        private int start_row = 4;
        private const string excel_name = "2013及之前专项资金项目";
        private Model.TTGWeb.previously_special_project model;

        public read_previous_project(string path)
        {
            re.init(path);
        }
        /// <summary>
        /// 读取一行
        /// </summary>
        private void read_and_insert_one_line(){
            model = new Model.TTGWeb.previously_special_project()
            {
                fill_time = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day)
            };
            int column = 0;
            string title = Convert.ToString(re.readcell(title_row, column));        //读取第一个title
            int maxColumn = re.getMaxColNum(start_row);
            while (!title.Equals("0"))
            {
                if (title.Equals("规划及计划情况"))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        title = Convert.ToString(re.readcell(title_row + 1, column));
                        if (title.Equals("项目投资（万元）"))
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                title = Convert.ToString(re.readcell(title_row + 2, column));
                                add_data(column, title);
                                column++;
                            }
                        }
                        else if (title.Equals("后规年度投资计划（万元）"))
                        {
                            //读取并插入 后归年度投资计划表
                            title = Convert.ToString(re.readcell(title_row + 2, column));
                            while (!title.Equals("0"))
                            {
                                decimal content = Convert.ToDecimal(re.readcell(start_row, column));
                                if (content != 0)
                                {
                                    int year = get_one_num(title);
                                    Model.TTGWeb.follow_up_investment_plan fuip = new Model.TTGWeb.follow_up_investment_plan()
                                    {
                                        year = year,
                                        plan_investment = content,
                                        project_id = model.project_id,
                                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
                                    };
                                    if (!new DAL.TTGWeb.follow_up_investment_plan().Add(fuip))
                                        throw new Exception("后归年度投资计划插入失败！");
                                }
                                title = Convert.ToString(re.readcell(title_row + 2, ++column));
                            }
                        }
                    }
                }
                else if (title.Equals("涉及小区"))
                {
                    string content = Convert.ToString(re.readcell(start_row, column));
                    string[] community = spilt_string(content);
                    for (int i = 0; i < community.Length; i++)
                    {
                        Model.TTGWeb.project_community pc = new Model.TTGWeb.project_community()
                        {
                            community_name = community[i],
                            county_name = model.county_name,
                            project_id = model.project_id,
                            fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
                        };
                        if (!new DAL.TTGWeb.project_community().Add(pc))
                            throw new Exception("小区项目对应表插入失败！");
                    }
                    column++;
                }
                else if (title.Equals("建设基础信息"))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            string content = Convert.ToString(re.readcell(start_row, column++));
                            model.project_owner = content;
                        }
                        else if (i == 1)
                        {
                            string content = Convert.ToString(re.readcell(start_row, column++));
                            model.main_construct_properties = content;
                        }

                        else
                        {
                            title = Convert.ToString(re.readcell(title_row + 1, column));
                            int year = get_one_num(title);
                            Model.TTGWeb.figure_progress fp = new Model.TTGWeb.figure_progress()
                            {
                                fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                                project_id = model.project_id,
                                year = year,
                                //march_progress = change_percentage(Convert.ToString(re.readcell(start_row, column++))),
                                //june_progress = change_percentage(Convert.ToString(re.readcell(start_row, column++))),
                                //september_progress = change_percentage(Convert.ToString(re.readcell(start_row, column++))),
                                //december_progress = change_percentage(Convert.ToString(re.readcell(start_row, column++)))
                                march_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                                june_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                                september_progress = Convert.ToDecimal(re.readcell(start_row, column++)),
                                december_progress = Convert.ToDecimal(re.readcell(start_row, column++))
                            };
                            if (!new DAL.TTGWeb.figure_progress().Add(fp))
                                throw new Exception("项目形象进度表插入失败！");
                        }
                    }
                }
                else if (title.Equals("工程进度"))
                {
                    title = Convert.ToString(re.readcell(title_row + 1, column));
                    Model.TTGWeb.construction_phase cp = new Model.TTGWeb.construction_phase()
                    {
                        project_id = model.project_id,
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        year = get_one_num(title),
                        march_phase = Convert.ToString(re.readcell(start_row,column++)),
                        june_phase = Convert.ToString(re.readcell(start_row,column++)),
                        september_phase = Convert.ToString(re.readcell(start_row, column++)),
                        december_phase = Convert.ToString(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.construction_phase().Add(cp))
                        throw new Exception("项目建设阶段表插入失败！");

                    for (int i = 0; i < 10; i++)
                    {
                        title = Convert.ToString(re.readcell(title_row + 1, column));
                        add_data(column, title);
                        column++;
                    }
                }
                else if (isExist(title, "投资到位情况"))          //投资到位表
                {
                    int[] time = get_two_nums(title);
                    Model.TTGWeb.investment_place_situation ips = new Model.TTGWeb.investment_place_situation()
                    {
                        year = time[0],
                        month = time[1],
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        project_id = model.project_id,
                        special_support_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        conterpart_founds = Convert.ToDecimal(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.investment_place_situation().Add(ips))
                        throw new Exception("项目投资到位情况插入失败！");
                }
                else if (isExist(title, "投资完成情况"))
                {
                    int[] time = get_two_nums(title);
                    Model.TTGWeb.investment_finish_situation ifs = new Model.TTGWeb.investment_finish_situation()
                    {
                        year = time[0],
                        month = time[1],
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        project_id = model.project_id,
                        summary = Convert.ToDecimal(re.readcell(start_row, column++)),
                        special_support_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        conterpart_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        other_matching_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        other_founds = Convert.ToDecimal(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.investment_finish_situation().Add(ifs))
                        throw new Exception("项目投资完成情况插入失败！");
                }
                else if (title.Equals("年份"))
                {
                    //计算project_id
                    add_data(column, title);
                    int year = Convert.ToInt32(re.readcell(start_row, column++));
                    string county = model.county_name;
                    //model.project_id = getProjectId(county, year);
                }
                else if (title.Equals("项目编号"))
                {
                    add_data(column, title);
                    column++;
                }
                else
                {
                    add_data(column, title);
                    column++;
                }
                if (column >= maxColumn)
                    break;
                title = Convert.ToString(re.readcell(title_row, column));
            }
        }
        /// <summary>
        /// 自动获取指定单元格的数据并将其插入数据库表中
        /// </summary>
        /// <param name="column"></param>
        /// <param name="title"></param>
        private void add_data(int column, string title)
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
                    properties[index].SetValue(model, Convert.ToDateTime(obj), null);
                else
                {
                    string in_type = Nullable.GetUnderlyingType(properties[index].PropertyType).ToString();
                    if (in_type.Equals("System.Int32"))
                        properties[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (in_type.Equals("System.Decimal"))
                        properties[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else if (in_type.Equals("System.DateTime")){
                        try{
                            properties[index].SetValue(model, Convert.ToDateTime(obj), null);
                        }
                        catch (Exception)
                        {
                            properties[index].SetValue(model, DateTime.FromOADate(Convert.ToDouble(obj)), null);
                        }
                    }
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
        /// 获取字符串中的第一个数字
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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
        /// 以‘，’符号分割字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string[] spilt_string(string str)
        {
            //return str.Replace(',', '，').Split('，');
            return str.Split('、');
        }
        /// <summary>
        /// 判断字符串str是否包含子字符串cstr
        /// </summary>
        /// <param name="str"></param>
        /// <param name="cstr"></param>
        /// <returns></returns>
        private bool isExist(string str, string cstr)
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
        /// 提取字符串中的年月份
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
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
        /// 自动生成项目编号
        /// </summary>
        /// <param name="county">区县名</param>
        /// <param name="year">项目年份</param>
        /// <returns>项目编号</returns>
        private string getProjectId(string county, int year)
        {
            string pinyin = getPinyin(county);
            string num = addNumBits(new DAL.TTGWeb.previously_special_project().GetProjectCount(county, year) + 1);
            return pinyin + year.ToString() + num + "-Z";
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
        /// 将百分数字符串转换成小数
        /// </summary>
        /// <param name="percent">百分数字符串</param>
        /// <returns>小数</returns>
        private decimal change_percentage(string percent)
        {
            string temp = percent.Substring(0, percent.Length - 1);
            return Convert.ToDecimal(temp) / 100;
        }

        /// <summary>
        /// 将整个表读取并插入数据库中
        /// </summary>
        public void read_and_insert()
        {
            int max_row = re.getMaxRow();
            for (int i = 0; i < max_row; i++)
            {
                string temp = Convert.ToString(re.readcell(start_row, 1));
                if (temp.Equals("0"))
                {
                    break;
                }
                else
                {
                    read_and_insert_one_line();
                    if (new DAL.TTGWeb.previously_special_project().Add(model) == 0)
                        throw new Exception("2013年及之前专项资金项目表插入失败！");
                    start_row++;
                }
            }
        }
    }
}
