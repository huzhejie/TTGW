﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace TTG.DAL.READ
{
    public class read_community_culture_sports
    {
        private const string excel_name = "小区商贸及社区服务基本情况";
        private read_excel re;
        private read_tools rt;
        private const int column2 = 6;

        public read_community_culture_sports(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }
        /// <summary>
        /// 读取小区文体表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_culture_sports read_culture(string id)
        {
            string table_name = "T_community_culture_sports";
            Model.TTGWeb.community_culture_sports ccs = new Model.TTGWeb.community_culture_sports()
            {
                //statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                //statistics_date = Convert.ToDateTime("2013/1/1")
                statistics_date = Convert.ToDateTime("2014/1/1"),
                community_id = id
            };
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] culture_info = ccs.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, culture_info);
                if (index != -1)
                {
                    string type = culture_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, 2);
                    if (type.Equals("String"))
                        culture_info[index].SetValue(ccs, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        culture_info[index].SetValue(ccs, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        culture_info[index].SetValue(ccs, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(culture_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            culture_info[index].SetValue(ccs, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            culture_info[index].SetValue(ccs, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return ccs;
        }
        /// <summary>
        /// 读取社区服务表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_service read_service(string id)
        {
            const string table_name = "T_community_service";
            Model.TTGWeb.community_service cs = new Model.TTGWeb.community_service()
            {
                community_id = id,
                //statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
                //statistics_date = Convert.ToDateTime("2013/1/1")
                statistics_date = Convert.ToDateTime("2014/1/1")
            };
            List<Model.TTGWeb.excel_span_structure> list = new DAL.TTGWeb.excel_span_structure().getMessage(excel_name, table_name);
            PropertyInfo[] service_info = cs.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, service_info);
                if (index != -1)
                {
                    string type = service_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_num, list[i].column_num);
                    if (type.Equals("String"))
                        service_info[index].SetValue(cs, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        service_info[index].SetValue(cs, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        service_info[index].SetValue(cs, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(service_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            service_info[index].SetValue(cs, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            service_info[index].SetValue(cs, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return cs;
        }
        /// <summary>
        /// 读取小区商贸表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Model.TTGWeb.community_commerce read_commerce(string id)
        {
            const string table_name = "T_community_commerce";
            Model.TTGWeb.community_commerce cc = new Model.TTGWeb.community_commerce()
            {
                community_id = id,
                //statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
                //statistics_date = Convert.ToDateTime("2013/1/1")
                statistics_date = Convert.ToDateTime("2014/1/1")
            };
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] commerce_info = cc.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                Model.TTGWeb.alter_field afm = new DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname, commerce_info);
                if (index != -1)
                {
                    string type = commerce_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, 6);
                    if (type.Equals("String"))
                        commerce_info[index].SetValue(cc, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        commerce_info[index].SetValue(cc, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        commerce_info[index].SetValue(cc, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(commerce_info[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            commerce_info[index].SetValue(cc, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            commerce_info[index].SetValue(cc, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            }
            return cc;
        }
        /// <summary>
        /// 读取并插入
        /// </summary>
        /// <param name="id"></param>
        public void read_and_insert(string id)
        {
            if (!new DAL.TTGWeb.community_culture_sports().Add(read_culture(id)))
                throw new Exception("小区文体表插入失败！");

            if (!new DAL.TTGWeb.community_service().Add(read_service(id)))
                throw new Exception("社区服务表插入失败！");

            if (!new DAL.TTGWeb.community_commerce().Add(read_commerce(id)))
                throw new Exception("小区商贸表插入失败！");
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
            if (table_name.Equals("T_community_culture_sports"))
                afm.alter_field_name = "tccsunset" + (count + 1);
            else if (table_name.Equals("T_community_service"))
                afm.alter_field_name = "tcsrunset" + (count + 1);
            else if (table_name.Equals("T_community_commerce"))
                afm.alter_field_name = "tccunset" + (count + 1);
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