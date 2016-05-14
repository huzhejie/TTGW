using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTG.Model.TTGWeb;
using TTG.DAL.TTGWeb;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace TTG.DAL.READ 
{
    public class read_community_base
    {
        private const int column1 = 2;
        private const int column2 = 7;
        private const string excel_name = "小区功能定位及人口基本情况";
        private read_tools rt;
        private read_excel re;                      //读取excel的工具类

        private TTG.DAL.TTGWeb.excel_structure es = new TTGWeb.excel_structure();           //存储表结构的工具类
        private TTG.Model.TTGWeb.Community_Base cbm = new Model.TTGWeb.Community_Base();    //小区基本情况表的实体类
        List<TTG.Model.TTGWeb.excel_structure> list;                                        //用来存储表结构信息的集合
        private TTG.Model.TTGWeb.community_population cpm = new Model.TTGWeb.community_population();            //小区居民基本信息统计表的实体类
        private TTG.Model.TTGWeb.community_immigrant cim = new Model.TTGWeb.community_immigrant();              //小区移民表的实体类
        private TTG.Model.TTGWeb.community_social_insurance csim = new Model.TTGWeb.community_social_insurance();           //小区社会保障状况表的实体类
        /// <summary>
        /// 构造函数，初始化读取类
        /// </summary>
        public read_community_base(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }
        /// <summary>
        /// 读取插入
        /// </summary>
        /// <param name="id"></param>
        public void read_and_insert(string id)
        {
            read_cbm(id);
            insert_cbm();
            read_cpm(id);
            insert_cpm();
            read_cim(id);
            insert_cim();
            read_csim(id);
            insert_csim();
        }
        /// <summary>
        /// 获取指定字段在属性列表中的位置
        /// </summary>
        /// <param name="att"></param>
        /// <param name="prop"></param>
        /// <returns></returns>
        public int getIndex(string att,PropertyInfo[] prop)
        {
            for (int i = 0; i < prop.Length; i++)
            {
                if (prop[i].Name.Equals(att))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 读取小区基本情况表的内容
        /// </summary>
        /// <param name="id"></param>
        public void read_cbm(string id){
            list = es.getMessage(excel_name, "T_Community_Base");
            cbm.community_id = id;
            //cbm.statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //cbm.statistics_date = Convert.ToDateTime("2013/1/1");
            cbm.statistics_date = Convert.ToDateTime("2014/1/1");
            Type type = cbm.GetType();
            PropertyInfo[] cbmpro = type.GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                int row = list[i].row_column_num;
                string attName = list[i].property;
                TTG.DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
                TTG.Model.TTGWeb.alter_field afm = af.GetModel(attName, "T_Community_Base");
                if (afm != null)            //说明字段是新添加进去的，对应原来表中的预留字段
                {
                    attName = afm.alter_field_name;         //找到字段对应的预留字段
                }
                int index = getIndex(attName, cbmpro);          //找到字段在属性列表中的位置
                if (index == -1)
                {
                    throw new Exception("找不到字段：" + attName);
                }
                else
                {
                    String ptype = cbmpro[index].PropertyType.Name;                         //获取字段的数据类型
                    object obj = re.readcell(row, column1);
                    if (ptype.Equals("String"))                                        //数据类型为string
                    {
                        cbmpro[index].SetValue(cbm, re.replaceBlank(Convert.ToString(obj)), null);         //为字段赋值
                    }
                    else if (ptype.Equals("Int32"))
                    {
                        cbmpro[index].SetValue(cbm, Convert.ToInt32(obj), null);         //为字段赋值
                    }
                    else if (ptype.Equals("Decimal"))
                    {
                        cbmpro[index].SetValue(cbm, Convert.ToDecimal(obj), null);         //为字段赋值
                    }
                    else
                    {
                        //该数据类型是可为空的
                        Type property_type = cbmpro[index].PropertyType;                    //获取属性的表类型
                        String underly_type = Nullable.GetUnderlyingType(property_type).ToString();             //获取属性的里类型
                        if (underly_type.Equals("System.Int32"))            //int?类型
                        {
                            cbmpro[index].SetValue(cbm, Convert.ToInt32(obj), null);
                        }
                        else if (underly_type.Equals("System.Decimal"))         //decimal?类型
                        {
                            cbmpro[index].SetValue(cbm, Convert.ToDecimal(obj), null);
                        }
                    }
                    
                }
            }
        }
        /// <summary>
        /// 插入小区基本情况表
        /// </summary>
        public void insert_cbm()
        {
            TTG.DAL.TTGWeb.Community_Base cb = new TTGWeb.Community_Base();
            if (!cb.Add(cbm))
            {
                throw new Exception("小区基本情况表插入失败！");
            }
        }
        /// <summary>
        /// 读取小区居民基本信息表的内容
        /// </summary>
        /// <param name="id"></param>
        public void read_cpm(string id)
        {
            TTG.DAL.TTGWeb.excel_span_structure ess = new TTGWeb.excel_span_structure();
            List<TTG.Model.TTGWeb.excel_span_structure> list = ess.getMessage(excel_name, "T_community_population");         //获取小区居民基本信息的表结构
            cpm.community_id = id;
            //cpm.statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //cpm.statistics_date = Convert.ToDateTime("2013/1/1");
            cbm.statistics_date = Convert.ToDateTime("2014/1/1");
            Type cpm_type = cpm.GetType();
            PropertyInfo[] cpm_property = cpm_type.GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                int row = (int)list[i].row_num;
                int column = (int)list[i].column_num;
                string attname = list[i].property;
                TTG.DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
                TTG.Model.TTGWeb.alter_field afm = af.GetModel(attname, "T_community_population");
                if (afm != null)
                {
                    attname = afm.alter_field_name;
                }
                int index = getIndex(attname, cpm_property);
                if (index != -1)
                {
                    string type = cpm_property[index].PropertyType.Name;
                    object obj = re.readcell(row, column);
                    if (type.Equals("String"))
                    {
                        cpm_property[index].SetValue(cpm, Convert.ToString(obj), null);
                    }
                    else if (type.Equals("Int32"))
                    {
                        cpm_property[index].SetValue(cpm, Convert.ToInt32(obj), null);
                    }
                    else if (type.Equals("Decimal"))
                    {
                        cpm_property[index].SetValue(cpm, Convert.ToDecimal(obj), null);
                    }
                    else
                    {
                        Type property_type = cpm_property[index].PropertyType;
                        String underly_type = Nullable.GetUnderlyingType(property_type).ToString();
                        if (underly_type.Equals("System.Int32"))
                        {
                            cpm_property[index].SetValue(cpm, Convert.ToInt32(obj), null);
                        }
                        else if (underly_type.Equals("System.Decimal"))
                        {
                            cpm_property[index].SetValue(cpm, Convert.ToDecimal(obj), null);
                        }
                    }
                }
                else
                {
                    throw new Exception("找不到字段：" + attname);
                }
            }
        }
        /// <summary>
        /// 插入小区居民基本信息表
        /// </summary>
        public void insert_cpm()
        {
            TTG.DAL.TTGWeb.community_population cp = new TTGWeb.community_population();
            if (!cp.Add(cpm))
            {
                throw new Exception("小区居民信息基本表插入失败！");
            }
        }
        /// <summary>
        /// 读取小区移民表的内容
        /// </summary>
        /// <param name="id"></param>
        public void read_cim(string id)
        {
            list = es.getMessage(excel_name, "T_community_immigrant");          //获取小区移民表的表结构
            cim.community_id = id;
            //cim.statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //cim.statistics_date = Convert.ToDateTime("2013/1/1");
            cbm.statistics_date = Convert.ToDateTime("2014/1/1");
            PropertyInfo[] cim_property = cim.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm = new TTG.DAL.TTGWeb.alter_field().GetModel(attname,"T_community_immigrant");
                if (afm != null)
                {
                    attname = afm.alter_field_name;
                }
                int index = getIndex(attname, cim_property);
                if (index != -1)
                {
                    string type = cim_property[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, column2);
                    if (type.Equals("String"))
                    {
                        cim_property[index].SetValue(cim, re.replaceBlank(Convert.ToString(obj)), null);
                    }
                    else if (type.Equals("Int32"))
                    {
                        cim_property[index].SetValue(cim, Convert.ToInt32(obj), null);
                    }
                    else if (type.Equals("Decimal"))
                    {
                        cim_property[index].SetValue(cim, Convert.ToDecimal(obj), null);
                    }
                    else
                    {
                        Type out_type = cim_property[index].PropertyType;
                        String in_type = Nullable.GetUnderlyingType(out_type).ToString();
                        if (in_type.Equals("System.Int32"))
                            cim_property[index].SetValue(cim, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            cim_property[index].SetValue(cim, Convert.ToDecimal(obj), null);
                    }
                    
                }
                else
                {
                    throw new Exception("找不到字段：" + attname);
                }
            }
        }
        /// <summary>
        /// 插入小区移民表
        /// </summary>
        public void insert_cim()
        {
            if (!new TTG.DAL.TTGWeb.community_immigrant().Add(cim))
            {
                throw new Exception("小区移民表插入失败！");
            }
        }
        /// <summary>
        /// 读取小区社会保障信息表
        /// </summary>
        /// <param name="id"></param>
        public void read_csim(string id)
        {
            csim.community_id = id;
            //csim.statistics_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //csim.statistics_date = Convert.ToDateTime("2013/1/1");
            cbm.statistics_date = Convert.ToDateTime("2014/1/1");
            list = es.getMessage(excel_name, "T_community_social_insurance");
            PropertyInfo[] csim_info = csim.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                TTG.Model.TTGWeb.alter_field afm = new TTG.DAL.TTGWeb.alter_field().GetModel(attname, "T_community_social_insurance");
                if (afm != null)
                {
                    attname = afm.alter_field_name;
                }
                int index = getIndex(attname, csim_info);
                if (index != -1)
                {
                    string type = csim_info[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, column2);
                    if(type.Equals("String"))
                        csim_info[index].SetValue(csim, re.replaceBlank(Convert.ToString(obj)), null);
                    else if(type.Equals("Int32"))
                        csim_info[index].SetValue(csim, Convert.ToInt32(obj), null);
                    else if(type.Equals("Decimal"))
                        csim_info[index].SetValue(csim, Convert.ToDecimal(obj), null);
                    else
                    {
                        Type out_type = csim_info[index].PropertyType;
                        String in_type = Nullable.GetUnderlyingType(out_type).ToString();
                        if (in_type.Equals("System.Int32"))
                            csim_info[index].SetValue(csim, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            csim_info[index].SetValue(csim, Convert.ToDecimal(obj), null);
                    }
                }
                else
                {
                    throw new Exception("找不到字段：" + attname);
                }
            }
        }
        /// <summary>
        /// 插入小区社会保障状况表
        /// </summary>
        public void insert_csim()
        {
            if (!new TTG.DAL.TTGWeb.community_social_insurance().Add(csim))
            {
                throw new Exception("小区社会保障状况表插入失败！");
            }
        }
        /// <summary>
        /// excel表中插入字段
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="att_name"></param>
        /// <param name="unit"></param>
        public void insert_line(int row, int column,string att_name,string unit)
        {
            TTG.DAL.TTGWeb.excel_datatable ed = new TTGWeb.excel_datatable();
            string table_name = ed.getTableName(excel_name, row, column);           //获取需要添加的数据表名
            if (table_name == null)
            {
                throw new Exception("找不到相关数据表！");
            }
            //以下代码为插入预留字段与新增字段对应表的相关操作
            TTG.DAL.TTGWeb.alter_field af = new TTGWeb.alter_field();
            int count = af.getCount(table_name);
            TTG.Model.TTGWeb.alter_field afm = new Model.TTGWeb.alter_field();
            afm.field_name = att_name;
            afm.table_name = table_name;
            afm.alter_type = "add";
            afm.alter_field_unit = unit;
            if (table_name.Equals("T_Community_Base"))
            {
                afm.alter_field_name = "tbcunset" + (count + 1);
            }
            else if (table_name.Equals("T_community_population"))
                afm.alter_field_name = "tcpunset" + (count + 1);
            else if (table_name.Equals("T_community_immigrant"))
                afm.alter_field_name = "tciunset" + (count + 1);
            else if (table_name.Equals("T_community_social_insurance"))
                afm.alter_field_name = "tcsiunset" + (count + 1);
            else
                throw new Exception("找不到合适的预留字段");
            if (!af.Add(afm))
            {
                throw new Exception("预留字段对应表插入失败！");
            }
            //更新数据表范围表，如果有必要的话
            List<TTG.Model.TTGWeb.excel_datatable> list = ed.getModel(column, excel_name, row);             //需要更新的数据表列表
            TTG.DAL.TTGWeb.excel_span_structure ess = new TTGWeb.excel_span_structure();
            if ((!ess.isExist(table_name)) || column > 2)                 //被插入的数据表不是跨列表或者它是跨列表，或者插入的列号大于2
            {
                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (ess.isExist(list[i].table_name))            //数据表是否横跨两列
                        {
                            list[i].table_start_row++;
                        }
                        else
                        {
                            list[i].table_start_row++;
                            list[i].table_end_row++;
                        }
                    }
                }
                TTG.Model.TTGWeb.excel_datatable edm = ed.GetModel(table_name);
                edm.table_end_row++;
                list.Add(edm);
                for (int i = 0; i < list.Count; i++)
                {
                    if (!ed.Update(list[i]))
                    {
                        throw new Exception(list[i].table_name + "表字段更新失败！");
                    }
                    
                }
                //更新excel_structure;
                for (int i = 0; i < list.Count; i++)
                {
                    TTG.DAL.TTGWeb.excel_structure es = new TTGWeb.excel_structure();
                    DataSet ds = es.GetList("table_name='"+list[i].table_name+"'");
                    List<TTG.Model.TTGWeb.excel_structure> les = new List<Model.TTGWeb.excel_structure>();
                    int num = ds.Tables[0].Rows.Count;
                    for (int j = 0; j < num; j++)                           //获取某个数据表在excel_structure;表中的所有字段
                    {
                        les.Add(DataRowToModel(ds.Tables[0].Rows[j]));
                        if (les[j].row_column_num>=row)
                            les[j].row_column_num++;
                    }
                    for (int j = 0; j < num; j++)                           //更新excel_structure表
                    {
                        if (!es.Update(les[j]))
                        {
                            throw new Exception(les[j].table_name + "表"+les[j].property+"字段更新失败！");
                        }
                    }
                }
                //向excel_structure;表中添加一条数据，将新增字段添加进去
                TTG.Model.TTGWeb.excel_structure temp = new Model.TTGWeb.excel_structure(){table_name=table_name,row_column_num=row,excel_name=excel_name,property=att_name};
                if (!new TTG.DAL.TTGWeb.excel_structure().Add(temp))
                {
                    throw new Exception("新增字段插入失败！");
                }
            }
            //更新excel_span_structure表
            DataSet ds2 = ess.GetList("excel_name='" + excel_name + "' and row_num>=" + row + " and column_num=" + column);
            int num2 = ds2.Tables[0].Rows.Count;
            List<TTG.Model.TTGWeb.excel_span_structure> less = new List<Model.TTGWeb.excel_span_structure>();
            for (int i = 0; i < num2; i++)
            {
                less.Add(DataRowToModel2(ds2.Tables[0].Rows[i]));
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
                    property = att_name,
                    row_num = row,
                    column_num = column
                }))
                    throw new Exception("新增字段插入失败！");
            }
        }
        /// <summary>
        /// 得到一个对象实体excel_structure
        /// </summary>
        public TTG.Model.TTGWeb.excel_structure DataRowToModel(DataRow row)
        {
            TTG.Model.TTGWeb.excel_structure model = new TTG.Model.TTGWeb.excel_structure();
            if (row != null)
            {
                if (row["property"] != null)
                {
                    model.property = row["property"].ToString();
                }
                if (row["excel_name"] != null)
                {
                    model.excel_name = row["excel_name"].ToString();
                }
                if (row["row_column_num"] != null && row["row_column_num"].ToString() != "")
                {
                    model.row_column_num = int.Parse(row["row_column_num"].ToString());
                }
                if (row["table_name"] != null)
                {
                    model.table_name = row["table_name"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 得到一个对象实体 excel_span_structure
        /// </summary>
        public TTG.Model.TTGWeb.excel_span_structure DataRowToModel2(DataRow row)
        {
            TTG.Model.TTGWeb.excel_span_structure model = new TTG.Model.TTGWeb.excel_span_structure();
            if (row != null)
            {
                if (row["property"] != null)
                {
                    model.property = row["property"].ToString();
                }
                if (row["excel_name"] != null)
                {
                    model.excel_name = row["excel_name"].ToString();
                }
                if (row["table_name"] != null)
                {
                    model.table_name = row["table_name"].ToString();
                }
                if (row["row_num"] != null && row["row_num"].ToString() != "")
                {
                    model.row_num = int.Parse(row["row_num"].ToString());
                }
                if (row["column_num"] != null && row["column_num"].ToString() != "")
                {
                    model.column_num = int.Parse(row["column_num"].ToString());
                }
            }
            return model;
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
