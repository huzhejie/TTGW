using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace TTG.DAL.READ
{
    public class read_imple_continued
    {
        private const string excel_name = "小区效果标准表续表";
        private const int start_row1 = 6;
        private read_excel re;
        private read_tools rt;

        public read_imple_continued(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }
        /// <summary>
        /// 读取小区幼儿园问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_kindergarten_problem read_kinder(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_kindergarten_problem";
            Model.TTGWeb.community_kindergarten_problem model = new Model.TTGWeb.community_kindergarten_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取小区医疗问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_medical_problem read_medical(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_medical_problem";
            Model.TTGWeb.community_medical_problem model = new Model.TTGWeb.community_medical_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取小区文体问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_cultrue_sports_problem read_culture(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_cultrue_sports_problem";
            Model.TTGWeb.community_cultrue_sports_problem model = new Model.TTGWeb.community_cultrue_sports_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取社区服务问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_commerce_service_problem read_commerce(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_commerce_service_problem";
            Model.TTGWeb.community_commerce_service_problem model = new Model.TTGWeb.community_commerce_service_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取小区商气人气问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_business_pop_problem read_business(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_business_pop_problem";
            Model.TTGWeb.community_business_pop_problem model = new Model.TTGWeb.community_business_pop_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取小区服务问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_service_problem read_service(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_service_problem";
            Model.TTGWeb.community_service_problem model = new Model.TTGWeb.community_service_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取小区停车场问题表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fill_type"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_parking_problem read_parking(string id, string fill_type, int row, string year)
        {
            const string table_name = "T_community_parking_problem";
            Model.TTGWeb.community_parking_problem model = new Model.TTGWeb.community_parking_problem()
            {
                community_id = id,
                community_fill_type = fill_type,
                statistics_date = year.Equals("") ? Convert.ToDateTime("2013年") : Convert.ToDateTime(year)
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        
        /// <summary>
        /// 读取幼儿园问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_kindergarten_problem_finished read_kinder_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_kindergarten_problem_finished";
            Model.TTGWeb.community_kindergarten_problem_finished model = new Model.TTGWeb.community_kindergarten_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取小区医疗问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_medical_problem_finished read_medical_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_medical_problem_finished";
            Model.TTGWeb.community_medical_problem_finished model = new Model.TTGWeb.community_medical_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 小区文体问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_cultrue_sports_problem_finished read_culture_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_cultrue_sports_problem_finished";
            Model.TTGWeb.community_cultrue_sports_problem_finished model = new Model.TTGWeb.community_cultrue_sports_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 社区服务问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_commerce_service_problem_finished read_commerce_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_commerce_service_problem_finished";
            Model.TTGWeb.community_commerce_service_problem_finished model = new Model.TTGWeb.community_commerce_service_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 小区商气人气问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_business_pop_problem_finished read_business_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_business_pop_problem_finished";
            Model.TTGWeb.community_business_pop_problem_finished model = new Model.TTGWeb.community_business_pop_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取小区服务问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_service_problem_finished read_service_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_service_problem_finished";
            Model.TTGWeb.community_service_problem_finished model = new Model.TTGWeb.community_service_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取小区停车场问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        /// <param name="year"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_parking_problem_finished read_parking_f(string id, int row, string year, string project)
        {
            const string table_name = "T_community_parking_problem_finished";
            Model.TTGWeb.community_parking_problem_finished model = new Model.TTGWeb.community_parking_problem_finished()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime(year),
                project_name = project
            };
            List<TTG.Model.TTGWeb.excel_structure> list = new TTG.DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] info = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm =
                    new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, info);
                if (index != -1)
                {
                    string type = info[index].PropertyType.Name;
                    object obj = re.readcell(row, list[i].row_column_num);
                    if (type.Equals("String"))
                        info[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        info[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        info[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            info[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            info[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段的类型：" + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段：" + attname);
            }
            return model;
        }
        /// <summary>
        /// 读取并插入问题表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int read_insert_problem(string id)
        {
            int row = start_row1;
            int column = 0;
            string content = Convert.ToString(re.readcell(row, column++));
            string s1, s2, temp1 = "", temp2 = "";
            string fill_type, year;
            while (!content.Equals("年度"))
            {
                if (content.Equals("0"))
                    content = temp1;
                if (content.Equals("问题总量"))
                {
                    year = "2013年";
                }
                else if (content.Equals("解决总量"))
                {
                    year = "2016年2月";
                }
                else
                {
                    year = content;
                }
                temp1 = content;

                s1 = Convert.ToString(re.readcell(row, column++));
                s2 = Convert.ToString(re.readcell(row, column));
                if (s2.Equals("0"))
                {
                    fill_type = s1;
                }
                else if (s1.Equals("0"))
                {
                    fill_type = temp2 + s2;
                }
                else
                {
                    fill_type = s1 + s2;
                }
                temp2 = s1;
                column = 0;

                //读取表
                if (!new TTGWeb.community_kindergarten_problem().Add(read_kinder(id, fill_type, row, year)))
                    throw new Exception("小区幼儿园问题表插入失败！");
                if (!new TTGWeb.community_medical_problem().Add(read_medical(id, fill_type, row, year)))
                    throw new Exception("小区医疗问题表插入失败！");
                if (!new TTGWeb.community_cultrue_sports_problem().Add(read_culture(id, fill_type, row, year)))
                    throw new Exception("小区文体问题表插入失败！");
                if (!new TTGWeb.community_commerce_service_problem().Add(read_commerce(id, fill_type, row, year)))
                    throw new Exception("社区服务问题表插入失败！");
                if (!new TTGWeb.community_business_pop_problem().Add(read_business(id, fill_type, row, year)))
                    throw new Exception("小区商气人气问题表插入失败！");
                if (!new TTGWeb.community_service_problem().Add(read_service(id, fill_type, row, year)))
                    throw new Exception("小区服务问题表插入失败！");
                if (!new TTGWeb.community_parking_problem().Add(read_parking(id, fill_type, row, year)))
                    throw new Exception("小区停车场问题表插入失败！");

                row++;
                content = Convert.ToString(re.readcell(row, column++));
            }
            return row + 2;
        }
        /// <summary>
        /// 读取并插入问题完成表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="row"></param>
        private void read_insert_finished(string id, int row)
        {
            int column = 0;
            int trow = row;
            string year = "", project;
            string content = Convert.ToString(re.readcell(row, column));
            while (!content.Equals("合计"))
            {
                while (!content.Contains("年"))
                {
                    content = Convert.ToString(re.readcell(++trow, column));
                }
                year = content;
                content = Convert.ToString(re.readcell(row, column));
                while (!content.Contains("年"))
                {
                    content = Convert.ToString(re.readcell(row, column));
                    if (content.Contains("年"))
                    {
                        year = content + "2月";
                        project = "0";
                    }
                    else
                    {
                        project = content;
                    }

                    //读取表
                    if (!new DAL.TTGWeb.community_kindergarten_problem_finished().Add(read_kinder_f(id, row, year, project)))
                        throw new Exception("幼儿园问题完成表插入失败！");
                    if (!new TTGWeb.community_medical_problem_finished().Add(read_medical_f(id, row, year, project)))
                        throw new Exception("小区医疗问题完成表插入失败！");
                    if (!new TTGWeb.community_cultrue_sports_problem_finished().Add(read_culture_f(id, row, year, project)))
                        throw new Exception("小区文体问题完成表插入失败！");
                    if (!new TTGWeb.community_commerce_service_problem_finished().Add(read_commerce_f(id, row, year, project)))
                        throw new Exception("小区商贸问题完成表插入失败！");
                    if (!new TTGWeb.community_business_pop_problem_finished().Add(read_business_f(id, row, year, project)))
                        throw new Exception("小区商气人气问题完成表插入失败！");
                    if (!new TTGWeb.community_service_problem_finished().Add(read_service_f(id, row, year, project)))
                        throw new Exception("小区社区服务问题完成表插入失败！");
                    if (!new TTGWeb.community_parking_problem_finished().Add(read_parking_f(id, row, year, project)))
                        throw new Exception("小区停车场问题完成表插入失败");
                    
                    row++;
                }

                content = Convert.ToString(re.readcell(row, column));
            }

            year += "2日";
            project = "0";

            //读取表
            if (!new DAL.TTGWeb.community_kindergarten_problem_finished().Add(read_kinder_f(id, row, year, project)))
                throw new Exception("幼儿园问题完成表插入失败！");
            if (!new TTGWeb.community_medical_problem_finished().Add(read_medical_f(id, row, year, project)))
                throw new Exception("小区医疗问题完成表插入失败！");
            if (!new TTGWeb.community_cultrue_sports_problem_finished().Add(read_culture_f(id, row, year, project)))
                throw new Exception("小区文体问题完成表插入失败！");
            if (!new TTGWeb.community_commerce_service_problem_finished().Add(read_commerce_f(id, row, year, project)))
                throw new Exception("小区商贸问题完成表插入失败！");
            if (!new TTGWeb.community_business_pop_problem_finished().Add(read_business_f(id, row, year, project)))
                throw new Exception("小区商气人气问题完成表插入失败！");
            if (!new TTGWeb.community_service_problem_finished().Add(read_service_f(id, row, year, project)))
                throw new Exception("小区社区服务问题完成表插入失败！");
            if (!new TTGWeb.community_parking_problem_finished().Add(read_parking_f(id, row, year, project)))
                throw new Exception("小区停车场问题完成表插入失败");
        }
        /// <summary>
        /// 读取并插入
        /// </summary>
        /// <param name="id"></param>
        public void read_and_insert(string id)
        {
            read_insert_finished(id, read_insert_problem(id));
        }
        /// <summary>
        /// 插入一列
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="column"></param>
        /// <param name="attname"></param>
        /// <param name="unit"></param>
        public void insert_line(int flag, int column, string attname, string unit)
        {
            //获取被修改的表名
            string table_name = new DAL.TTGWeb.excel_datatable().getTable(excel_name, column, flag);
            //修改alter_field表
            TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            Model.TTGWeb.alter_field afm = new Model.TTGWeb.alter_field()
            {
                table_name = table_name,
                field_name = attname,
                alter_field_unit = unit,
                alter_field_name = "tciunset" + (count + 1),
                alter_type = "add"
            };
            if (!af.Add(afm))
                throw new Exception("预留字段对应表插入失败！");

            List<Model.TTGWeb.excel_datatable> list = new TTGWeb.excel_datatable().getModelList(excel_name, column, flag);
            TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            //更新excel_datatable表
            for (int i = 0; i < list.Count; i++)
            {
                list[i].table_start_column++;
                list[i].table_end_column++;
            }
            Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
            edm.table_end_column++;
            list.Add(edm);
            for (int i = 0; i < list.Count; i++)
            {
                if (!new TTGWeb.excel_datatable().Update(list[i]))
                    throw new Exception(list[i].table_name + "： 数据库范围表更新失败！");
            }
            //更新excle_structure表
            for (int i = 0; i < list.Count; i++)
            {
                List<Model.TTGWeb.excel_structure> les = es.getMessage(excel_name, list[i].table_name);
                for (int j = 0; j < les.Count; j++)
                {
                    if (les[j].row_column_num >= column)
                    {
                        les[j].row_column_num++;
                        if (!es.Update(les[j]))
                            throw new Exception(les[j].table_name + "表" + les[j].property + "字段更新失败！");
                    }
                }
            }
            //插入字段
            if (!es.Add(new Model.TTGWeb.excel_structure()
            {
                table_name = table_name,
                excel_name = excel_name,
                property = attname,
                row_column_num = column
            }))
                throw new Exception("新增字段插入失败！");
        }
        /// <summary>
        /// 删除一列
        /// </summary>
        /// <param name="column"></param>
        /// <param name="flag"></param>
        public void delete_line(int column, int flag)
        {
            //获取被删除的字段所在表
            string table_name = new TTGWeb.excel_datatable().getTable(excel_name, column, flag);
            //更新alter_filed表，如果有必要的话
            string attname = new TTGWeb.excel_structure().getProperty(excel_name, table_name, column);
            TTGWeb.alter_field af = new TTGWeb.alter_field();
            if (af.isExist(attname, table_name))
            {
                if (!af.Delete(attname, table_name))
                    throw new Exception("预留字段对应表删除失败！");
            }

            //更新excel_datatable表
            List<Model.TTGWeb.excel_datatable> list = new TTGWeb.excel_datatable().getModelList(excel_name, column, flag);
            for (int i = 0; i < list.Count; i++)
            {
                list[i].table_start_column--;
                list[i].table_end_column--;
            }
            Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
            edm.table_end_column--;
            list.Add(edm);
            for (int i = 0; i < list.Count; i++)
            {
                if (!new TTGWeb.excel_datatable().Update(list[i]))
                    throw new Exception(list[i].table_name + "： 数据库范围表更新失败！");
            }

            //删除字段
            TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            if (!es.delete(column, table_name))
                throw new Exception(attname + "字段删除失败！");

            //更新excel_structure表
            for (int i = 0; i < list.Count; i++)
            {
                List<Model.TTGWeb.excel_structure> les = es.getMessage(excel_name, list[i].table_name);
                for (int j = 0; j < les.Count; j++)
                {
                    if (les[j].row_column_num > column)
                    {
                        les[j].row_column_num--;
                        if (!es.Update(les[j]))
                            throw new Exception(les[j].table_name + "表" + les[j].property + "字段更新失败！");
                    }
                }
            }
        }
    }
}
