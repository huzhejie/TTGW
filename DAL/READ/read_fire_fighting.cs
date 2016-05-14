using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace TTG.DAL.READ
{
    public class read_fire_fighting
    {
        private const string excel_name = "小区消防、环卫、安防及其他基本情况";
        private read_excel re;
        private read_tools rt;
        private const int column1 = 2, column2 = 6;
        public read_fire_fighting(string path){
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }
        /// <summary>
        /// 读取小区消防表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_fire_fighting read_fire(string id)
        {
            string table_name = "T_community_fire_fighting";
            Model.TTGWeb.community_fire_fighting cff = new Model.TTGWeb.community_fire_fighting()
            {
                community_id = id,
                statistics_date = Convert.ToDateTime("2014/1/1")
                //statistics_date = Convert.ToDateTime("2013/1/1")
                //statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] fire_info = cff.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, fire_info);
                if (index != -1)
                {
                    string type = fire_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, column1);
                    if (type.Equals("String"))
                        fire_info[index].SetValue(cff, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        fire_info[index].SetValue(cff, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        fire_info[index].SetValue(cff, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(fire_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            fire_info[index].SetValue(cff, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            fire_info[index].SetValue(cff, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return cff;
        }
        /// <summary>
        /// 读取小区环境卫生表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_environmental_hygiene read_envir(string id)
        {
            const string table_name = "T_community_environmental_hygiene";
            Model.TTGWeb.community_environmental_hygiene ceh = new Model.TTGWeb.community_environmental_hygiene()
            {
                community_id = id,
                //statistics_date = Convert.ToDateTime("2013/1/1")
                statistics_date = Convert.ToDateTime("2014/1/1")
                //statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };
            List<Model.TTGWeb.excel_span_structure> list = new DAL.TTGWeb.excel_span_structure().getMessage(excel_name, table_name);
            PropertyInfo[] envir_info = ceh.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, envir_info);
                if (index != -1)
                {
                    string type = envir_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_num, list[i].column_num);
                    if (type.Equals("String"))
                        envir_info[index].SetValue(ceh, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        envir_info[index].SetValue(ceh, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        envir_info[index].SetValue(ceh, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(envir_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            envir_info[index].SetValue(ceh, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            envir_info[index].SetValue(ceh, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return ceh;
        }
        /// <summary>
        /// 读取小区天然气表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_natural_gas read_natural(string id)
        {
            const string table_name = "T_community_natural_gas";
            Model.TTGWeb.community_natural_gas cng = new Model.TTGWeb.community_natural_gas()
            {
                community_id = id,
                //statistics_date = Convert.ToDateTime("2013/1/1")
                statistics_date = Convert.ToDateTime("2014/1/1")
                //statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] natural_info = cng.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, natural_info);
                if (index != -1)
                {
                    string type = natural_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, 6);
                    if (type.Equals("String"))
                        natural_info[index].SetValue(cng, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        natural_info[index].SetValue(cng, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        natural_info[index].SetValue(cng, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(natural_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            natural_info[index].SetValue(cng, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            natural_info[index].SetValue(cng, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return cng;
        }
        /// <summary>
        /// 读取小区安防表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_security read_security(string id)
        {
            const string table_name = "T_community_security";
            Model.TTGWeb.community_security csm = new Model.TTGWeb.community_security()
            {
                community_id = id,
                //statistics_date = Convert.ToDateTime("2013/1/1")
                statistics_date = Convert.ToDateTime("2014/1/1")
                //statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] sec_info = csm.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, sec_info);
                if (index != -1)
                {
                    string type = sec_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, 6);
                    if (type.Equals("String"))
                        sec_info[index].SetValue(csm, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        sec_info[index].SetValue(csm, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        sec_info[index].SetValue(csm, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(sec_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            sec_info[index].SetValue(csm, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            sec_info[index].SetValue(csm, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return csm;
        }
        /// <summary>
        /// 读取小区地质灾害表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_geologic_hazard read_geologic(string id)
        {
            const string table_name = "T_community_geologic_hazard";
            Model.TTGWeb.community_geologic_hazard cgh = new Model.TTGWeb.community_geologic_hazard()
            {
                community_id = id,
                //statistics_date = Convert.ToDateTime("2013/1/1")
                statistics_date = Convert.ToDateTime("2014/1/1")
                //statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] geo_info = cgh.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, geo_info);
                if (index != -1)
                {
                    string type = geo_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, 6);
                    if (type.Equals("String"))
                        geo_info[index].SetValue(cgh, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        geo_info[index].SetValue(cgh, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        geo_info[index].SetValue(cgh, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(geo_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            geo_info[index].SetValue(cgh, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            geo_info[index].SetValue(cgh, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return cgh;
        }
        /// <summary>
        /// 读取并插入
        /// </summary>
        /// <param name="id"></param>
        public void read_and_insert(string id)
        {
            if (!new DAL.TTGWeb.community_fire_fighting().Add(read_fire(id)))
                throw new Exception("小区消防表插入失败！");

            if (!new DAL.TTGWeb.community_environmental_hygiene().Add(read_envir(id)))
                throw new Exception("小区环境卫生表插入失败！");

            if (!new DAL.TTGWeb.community_natural_gas().Add(read_natural(id)))
                throw new Exception("小区天然气表插入失败！");

            if (!new DAL.TTGWeb.community_security().Add(read_security(id)))
                throw new Exception("小区安防表插入失败！");

            if (!new DAL.TTGWeb.community_geologic_hazard().Add(read_geologic(id)))
                throw new Exception("小区地质灾害表插入失败！");
        }
        /// <summary>
        /// 插入一行
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="attname"></param>
        /// <param name="unit"></param>
        public void insert_line(int row, int column, string attname, string unit)
        {
            string table_name = new DAL.TTGWeb.excel_datatable().getTableName(excel_name, row, column);
            if (table_name == null)
                throw new Exception("找不到相关数据表！");
            //更新alter_filed表
            TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            Model.TTGWeb.alter_field afm = new Model.TTGWeb.alter_field()
            {
                table_name = table_name,
                alter_field_unit = unit,
                alter_type = "add",
                field_name = attname,
                //alter_field_name = table_name.Equals("T_community_water_supply") ? "tcwsunset" + (count + 1) : "tcwdunset" + (count + 1)
            };
            if (table_name.Equals("T_community_fire_fighting"))
                afm.alter_field_name = "tcffunset" + (count + 1);
            else if (table_name.Equals("T_community_environmental_hygiene"))
                afm.alter_field_name = "tcehunset" + (count + 1);
            else if (table_name.Equals("T_community_natural_gas"))
                afm.alter_field_name = "tcngunset" + (count + 1);
            else if (table_name.Equals("T_community_security"))
                afm.alter_field_name = "tcsunset" + (count + 1);
            else if (table_name.Equals("T_community_geologic_hazard"))
                afm.alter_field_name = "tcghunset" + (count + 1);
            if (!af.Add(afm))
                throw new Exception("预留字段对应表插入失败！");
            DAL.TTGWeb.excel_span_structure ess = new TTGWeb.excel_span_structure();
            List<Model.TTGWeb.excel_datatable> list = new DAL.TTGWeb.excel_datatable().getModel(column, excel_name, row);
            if (!ess.isExist(table_name) || column == 6)        //如果表示跨列表而且是被插入字段位于第二列时，不用更新excel_structure和excel_datatable表
            {
                //更新excel_datatable表
                for (int i = 0; i < list.Count; i++)
                {
                    if (ess.isExist(list[i].table_name))
                        list[i].table_start_row++;
                    else
                    {
                        list[i].table_start_row++;
                        list[i].table_end_row++;
                    }
                }
                Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
                edm.table_end_row++;
                list.Add(edm);
                for (int i = 0; i < list.Count; i++)
                {
                    if (!new DAL.TTGWeb.excel_datatable().Update(list[i]))
                        throw new Exception("数据库范围表更新失败！");
                }
                //更新excel_structure表
                DAL.TTGWeb.excel_structure es = new TTGWeb.excel_structure();
                for (int i = 0; i < list.Count; i++)
                {
                    List<Model.TTGWeb.excel_structure> les = es.getMessage(excel_name, list[i].table_name);
                    for (int j = 0; j < les.Count; j++)
                    {
                        if (les[j].row_column_num >= row)
                            les[j].row_column_num++;
                        if (!es.Update(les[j]))
                            throw new Exception(les[j].table_name + "表" + les[j].property + "字段更新失败！");
                    }
                }
                //向excel_structure表中插入新增字段
                if (!es.Add(new Model.TTGWeb.excel_structure()
                {
                    table_name = table_name,
                    excel_name = excel_name,
                    property = attname,
                    row_column_num = row
                }))
                    throw new Exception("新增字段插入失败！");
            }
            //更新excel_span_structure表
            DataSet ds2 = ess.GetList("excel_name='" + excel_name + "' and row_num>=" + row + " and column_num=" + column);
            int num2 = ds2.Tables[0].Rows.Count;
            List<TTG.Model.TTGWeb.excel_span_structure> less = new List<Model.TTGWeb.excel_span_structure>();
            for (int i = 0; i < num2; i++)
            {
                less.Add(rt.DataRowToSSModel(ds2.Tables[0].Rows[i]));
                less[i].row_num++;
            }
            for (int i = 0; i < num2; i++)
            {
                if (!ess.Update(less[i]))
                {
                    throw new Exception(less[i].table_name + "表" + less[i].property + "字段更新失败！");
                }
            }
            //如果插入的是跨列表，在跨列表上新增一行
            if (ess.isExist(table_name))
            {
                if (!ess.Add(new Model.TTGWeb.excel_span_structure()
                {
                    table_name = table_name,
                    excel_name = excel_name,
                    property = attname,
                    row_num = row,
                    column_num = column
                }))
                    throw new Exception("新增字段插入失败！");
            }
        }

        /// <summary>
        /// 删除一行
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void delete_line(int row, int column)
        {
            //被删除的表名
            string table_name = new DAL.TTGWeb.excel_datatable().getTableName(excel_name, row, column);
            DAL.TTGWeb.excel_span_structure ess = new TTGWeb.excel_span_structure();
            List<Model.TTGWeb.excel_datatable> list = new DAL.TTGWeb.excel_datatable().getModel(column, excel_name, row);

            //删除对应预留字段
            if (ess.isExist(table_name))
            {
                string property = ess.getProperty(excel_name, table_name, row, column);
                DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
                if (af.isExist(property, table_name))
                {
                    if (!af.Delete(property, table_name))
                        throw new Exception("预留字段对应表中字段删除失败！");
                }
            }
            else
            {
                string property = new DAL.TTGWeb.excel_structure().getProperty(excel_name, table_name, row);
                DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
                if (af.isExist(property, table_name))
                {
                    if (!af.Delete(property, table_name))
                        throw new Exception("预留字段对应表中的字段删除失败！");
                }
            }

            //如果被删除的表不是跨列表或者是跨列表但是位于第二列，那么需要更新excel_structure表和excel_datatable表
            if (!ess.isExist(table_name) || column == column2)
            {
                //更新excel_datatable表
                for (int i = 0; i < list.Count; i++)
                {
                    if (ess.isExist(list[i].table_name))
                        list[i].table_start_row--;
                    else
                    {
                        list[i].table_start_row--;
                        list[i].table_end_row--;
                    }
                }
                Model.TTGWeb.excel_datatable edm = new DAL.TTGWeb.excel_datatable().GetModel(table_name);
                edm.table_end_row--;
                list.Add(edm);
                for (int i = 0; i < list.Count; i++)
                {
                    if (!new DAL.TTGWeb.excel_datatable().Update(list[i]))
                        throw new Exception("数据库范围表" + list[i].table_name + ": 更新失败！");
                }
                //从excel_表中删除字段
                if (!new DAL.TTGWeb.excel_structure().delete(row, table_name))
                    throw new Exception(table_name + "表第" + row + "行数据删除失败！");
                //更新excel_structure表
                for (int i = 0; i < list.Count; i++)
                {
                    List<Model.TTGWeb.excel_structure> les = new DAL.TTGWeb.excel_structure().getMessage(excel_name, list[i].table_name);
                    for (int j = 0; j < les.Count; j++)
                    {
                        if (les[j].row_column_num > row)
                        {
                            les[j].row_column_num--;
                            if (!new DAL.TTGWeb.excel_structure().Update(les[j]))
                                throw new Exception(les[j].table_name + "表" + les[j].property + "字段更新失败！");
                        }
                    }
                }
            }

            //如果被删除的表是跨列表，在跨列表上删除一行
            if (ess.isExist(table_name))
                if (!ess.delete(row, column, table_name))
                    throw new Exception(table_name + "表第" + row + "行数据删除失败！");

            //更新excel_span_structure表
            DataSet ds2 = ess.GetList("excel_name='" + excel_name + "' and row_num>" + row + " and column_num=" + column);
            int num2 = ds2.Tables[0].Rows.Count;
            List<TTG.Model.TTGWeb.excel_span_structure> less = new List<Model.TTGWeb.excel_span_structure>();
            for (int i = 0; i < num2; i++)
            {
                less.Add(rt.DataRowToSSModel(ds2.Tables[0].Rows[i]));
                less[i].row_num--;
            }
            for (int i = 0; i < num2; i++)
            {
                if (!ess.Update(less[i]))
                {
                    throw new Exception(less[i].table_name + "表" + less[i].property + "字段更新失败！");
                }
            }
        }
    }
}
