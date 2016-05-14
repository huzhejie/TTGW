using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_community_sample
    {
        private read_excel re;
        private read_tools rt;
        private const int column = 3;
        private const string excel = "城镇居民小区居民收入及劳动力指标";
        private TTG.Model.TTGWeb.sample sm = new Model.TTGWeb.sample();         //入户调查表实体类
        private TTG.DAL.TTGWeb.excel_structure es = new TTGWeb.excel_structure();       //表结构表
        public read_community_sample(string path)
        {
            rt = new read_tools();
            re = new read_excel();
            re.init(path);
        }

        /// <summary>
        /// 读取并插入数据库
        /// </summary>
        /// <param name="id"></param>
        public void read_and_insert(string id)
        {
            read_sample(id);
            insert_sample();
        }       
        /// <summary>
        /// 读取入户调查表
        /// </summary>
        private void read_sample(string id)
        {
            string table_name = "T_sample";
            List<TTG.Model.TTGWeb.excel_structure> list = es.getMessage(excel, table_name);
            sm.community_id = id;
            sm.statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            PropertyInfo[] samplepro = sm.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm = new TTG.DAL.TTGWeb.alter_field().GetModel(attname, table_name);
                if (afm != null)
                    attname = afm.alter_field_name;
                int index = rt.getIndex(attname,samplepro);
                if (index != -1)
                {
                    string type = samplepro[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, column);
                    if (type.Equals("String"))
                        samplepro[index].SetValue(sm, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        samplepro[index].SetValue(sm, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        samplepro[index].SetValue(sm, Convert.ToDecimal(obj), null);
                    else
                    {
                        Type out_type = samplepro[index].PropertyType;
                        string in_type = Nullable.GetUnderlyingType(out_type).ToString();
                        if (in_type.Equals("System.Int32"))
                            samplepro[index].SetValue(sm, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            samplepro[index].SetValue(sm, Convert.ToDecimal(obj), null);
                    }
                }
                else
                {
                    throw new Exception("找不到字段: "+attname);
                }
            }
        }
        /// <summary>
        /// 插入入户调查表
        /// </summary>
        private void insert_sample()
        {
            if (!new TTG.DAL.TTGWeb.sample().Add(sm))
            {
                throw new Exception("入户调查表插入失败！");
            }
        }
        /// <summary>
        /// 向入户调查表中插入新的字段
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="attname"></param>
        /// <param name="unit"></param>
        public void insert_line(int row,int column,string attname,string unit)
        {
            string table_name="T_sample";
            //更新alter_filed表
            TTG.DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            if(!af.Add(new Model.TTGWeb.alter_field()
            {
                field_name = attname,
                table_name = table_name,
                alter_field_unit = unit,
                alter_type = "add",
                alter_field_name = "tsunset" + (count + 1)
            }))
            {
                throw new Exception("预留字段对应表插入失败！");
            }
            //更新excel_datatable表
            TTG.DAL.TTGWeb.excel_datatable ed = new TTGWeb.excel_datatable();
            TTG.Model.TTGWeb.excel_datatable edm = ed.GetModel(table_name);
            edm.table_end_row++;
            if (!ed.Update(edm))
            {
                throw new Exception("数据库范围表更新失败！");
            }
            //更新excel_structure表
            TTG.DAL.TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            List<TTG.Model.TTGWeb.excel_structure> list = es.getMessage(excel, table_name);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].row_column_num >= row)
                    list[i].row_column_num++;
            }
            for (int i = 0; i < list.Count; i++)
                if (!es.Update(list[i]))
                    throw new Exception(list[i].table_name + "表" + list[i].property + "字段插入失败！");
            if (!es.Add(new Model.TTGWeb.excel_structure()
            {
                table_name = table_name,
                excel_name = excel,
                property = attname,
                row_column_num = row
            }))
                throw new Exception("新增字段插入失败！");
        }
        /// <summary>
        /// 删除一行
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void delete_line(int row, int column)
        {
            const string table_name = "T_sample";
            DAL.TTGWeb.excel_structure es = new TTGWeb.excel_structure();
            string property = es.getProperty(excel, table_name, row);
            //更新alter_filed表
            DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            if (af.isExist(property, table_name))
            {
                if (!af.Delete(property, table_name))
                    throw new Exception("预留字段对应表删除失败！");
            }
            //更新excel_datatable表
            TTG.DAL.TTGWeb.excel_datatable ed = new TTGWeb.excel_datatable();
            TTG.Model.TTGWeb.excel_datatable edm = ed.GetModel(table_name);
            edm.table_end_row--;
            if (!ed.Update(edm))
            {
                throw new Exception("数据库范围表更新失败！");
            }
            //删除字段
            if (!es.delete(row, table_name))
                throw new Exception("字段删除失败！");
            //更新excel_structure表
            List<TTG.Model.TTGWeb.excel_structure> list = es.getMessage(excel, table_name);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].row_column_num > row)
                    list[i].row_column_num--;
            }
            for (int i = 0; i < list.Count; i++)
                if (!es.Update(list[i]))
                    throw new Exception(list[i].table_name + "表" + list[i].property + "字段插入失败！");
        }
    }
}
