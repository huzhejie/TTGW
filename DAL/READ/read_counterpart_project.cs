using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.International.Converters.PinYinConverter;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_counterpart_project
    {
        private read_excel re = new read_excel();
        private const string excel_name = "对口支援及其他项目";
        private const int title_row = 1;
        private int start_row = 4;
        private Model.TTGWeb.counterpart_and_other_project model;
        

        public read_counterpart_project(string path)
        {
            re.init(path);
        }
        /// <summary>
        /// 读取并插入
        /// </summary>
        public void read_and_insert()
        {
            string title = Convert.ToString(re.readcell(start_row, 1));
            while (!title.Equals("0"))
            {
                read_counterpart();
                if (new DAL.TTGWeb.counterpart_and_other_project().Add(model) <= 0)
                    throw new Exception("对口支援及其他项目表插入失败！");
                try
                {
                    title = Convert.ToString(re.readcell(++start_row, 1));
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
        /// <summary>
        /// 读取对口支援及其他项目
        /// </summary>
        private void read_counterpart()
        {
            int column = 1;
            model = new Model.TTGWeb.counterpart_and_other_project()
            {
                fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
            };
            string title = Convert.ToString(re.readcell(title_row, column));
            while (true)
            {
                if (title.Equals("计划投资（万元）"))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        title = Convert.ToString(re.readcell(title_row + 1, column));
                        add_data(column++, title);
                    }
                }
                else if (title.Equals("工程建设情况"))
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
                        throw new Exception("项目形象进度表插入失败！");

                    title = Convert.ToString(re.readcell(title_row + 1, column));
                    year = get_one_num(title);
                    Model.TTGWeb.construction_phase cp = new Model.TTGWeb.construction_phase()
                    {
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        project_id = model.project_id,
                        year = year,
                        march_phase = Convert.ToString(re.readcell(start_row, column++)),
                        june_phase = Convert.ToString(re.readcell(start_row, column++)),
                        september_phase = Convert.ToString(re.readcell(start_row, column++)),
                        december_phase = Convert.ToString(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.construction_phase().Add(cp))
                        throw new Exception("项目建设阶段表插入失败！");

                    title = Convert.ToString(re.readcell(title_row + 1, column));
                    while (!title.Equals("0"))
                    {
                        add_data(column++, title);
                        title = Convert.ToString(re.readcell(title_row + 1, column));
                    }
                }
                else if (is_exist(title, "对口支援投资到位情况"))
                {
                    Model.TTGWeb.counterpart_investment_placed_situation cips = new Model.TTGWeb.counterpart_investment_placed_situation()
                    {
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        year = get_one_num(title),
                        project_id = model.project_id,
                        march_investment = Convert.ToDecimal(re.readcell(start_row, column++)),
                        june_investment = Convert.ToDecimal(re.readcell(start_row, column++)),
                        september_investment = Convert.ToDecimal(re.readcell(start_row, column++)),
                        december_investment = Convert.ToDecimal(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.counterpart_investment_placed_situation().Add(cips))
                        throw new Exception("对口支援投资到位情况表插入失败！");
                }
                else if (is_exist(title, "投资完成情况"))
                {
                    int[] date = get_two_nums(title);
                    Model.TTGWeb.counterpart_investment_finished_situation cifs = new Model.TTGWeb.counterpart_investment_finished_situation()
                    {
                        fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        year = date[0],
                        month = date[1],
                        project_id = model.project_id,
                        summary = Convert.ToDecimal(re.readcell(start_row, column++)),
                        counterpart_founds = Convert.ToDecimal(re.readcell(start_row, column++)),
                        other_matching_founds = Convert.ToDecimal(re.readcell(start_row, column++))
                    };
                    if (!new DAL.TTGWeb.counterpart_investment_finished_situation().Add(cifs))
                        throw new Exception("投资完成情况表插入失败！");
                }
                else if (title.Equals("涉及小区"))
                {
                    string[] community = spilt_string(Convert.ToString(re.readcell(start_row, column++)));
                    for (int i = 0; i < community.Length; i++)
                    {
                        Model.TTGWeb.project_community pc = new Model.TTGWeb.project_community()
                        {
                            project_id = model.project_id,
                            fill_time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                            community_name = community[i],
                            county_name = model.county_name
                        };
                        if (!new DAL.TTGWeb.project_community().Add(pc))
                            throw new Exception("项目小区关联表插入失败！");
                    }
                }
                else if (title.Equals("年份"))
                {
                    //计算项目编号
                    int year = Convert.ToInt32(re.readcell(start_row, column));
                    add_data(column++, title);
                    model.project_id = get_project_id(model.county_name, model.is_counterpart_project, year);
                }
                else
                {
                    add_data(column++, title);
                }

                try
                {
                    title = Convert.ToString(re.readcell(title_row, column));
                }
                catch(Exception)
                {
                    break;
                }
            }
        }
        /// <summary>
        /// 将第column列数据插入到数据库中
        /// </summary>
        /// <param name="column">列号</param>
        /// <param name="title">字段名</param>
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
                    properties[index].SetValue(model, DateTime.FromOADate(Convert.ToDouble(obj)), null);
                else
                {
                    string in_type = Nullable.GetUnderlyingType(properties[index].PropertyType).ToString();
                    if (in_type.Equals("System.Int32"))
                        properties[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (in_type.Equals("System.Decimal"))
                        properties[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else if (in_type.Equals("System.DateTime"))
                        try{
                            DateTime time = Convert.ToDateTime(obj);
                            if (time.Year == 1)
                            {
                                properties[index].SetValue(model, null, null);
                            }
                            else
                            {
                                properties[index].SetValue(model, Convert.ToDateTime(obj), null);
                            }
                        }
                        catch (Exception)
                        {
                            double time = Convert.ToDouble(obj);
                            if (time == 0)
                            {
                                properties[index].SetValue(model, null, null);
                            }
                            else
                            {
                                properties[index].SetValue(model, DateTime.FromOADate(time), null);
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
        /// 将多个小区名组成的字符串分割成单个小区名数组
        /// </summary>
        /// <param name="str">目标字符串</param>
        /// <returns>字符串数组</returns>
        private string[] spilt_string(string str)
        {
            //return str.Replace(',', '，').Split('，');
            return str.Split('、');
        }
        /// <summary>
        /// 获取项目编号
        /// </summary>
        /// <param name="county">区县名</param>
        /// <param name="counterpart">是否为对口支援项目</param>
        /// <param name="year">年份</param>
        /// <returns>项目编号</returns>
        private string get_project_id(string county, string counterpart, int year)
        {
            int count = new DAL.TTGWeb.counterpart_and_other_project().GetProjectCount(county, counterpart, year);
            string pin = getPinyin(county);
            string nums = addNumBits(count + 1);
            if (counterpart.Equals("0"))
                return pin + year.ToString() + nums + "-Q";
            else
                return pin + year.ToString() + nums + "-D";
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
    }
}
