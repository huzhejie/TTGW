using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_management
    {
        private const string excel_name = "小区管理及监测人员";
        private const string table_name = "T_community_management_responsible";
        private read_excel re;
        private read_tools rt;

        public read_management(string path)
        {
            re = new read_excel();
            re.init(path);
            rt = new read_tools();
        }

        private Model.TTGWeb.community_management_responsible read_line()
        {
            Model.TTGWeb.community_management_responsible model = new Model.TTGWeb.community_management_responsible();
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                int index = rt.getIndex(attname, properties);
                if (index != -1)
                {
                    string type = properties[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, 1);
                    if (type.Equals("String"))
                        properties[index].SetValue(model, re.replaceBlank(Convert.ToString(obj)), null);
                    else if (type.Equals("Int32"))
                        properties[index].SetValue(model, Convert.ToInt32(obj), null);
                    else if (type.Equals("Decimal"))
                        properties[index].SetValue(model, Convert.ToDecimal(obj), null);
                    else
                    {
                        string in_type = Nullable.GetUnderlyingType(properties[index].PropertyType).ToString();
                        if (in_type.Equals("System.Int32"))
                            properties[index].SetValue(model, Convert.ToInt32(obj), null);
                        else if (in_type.Equals("System.Decimal"))
                            properties[index].SetValue(model, Convert.ToDecimal(obj), null);
                        else
                            throw new Exception("找不到字段类型： " + in_type);
                    }
                }
                else
                    throw new Exception("找不到字段： " + attname);
            
            }
            return model;
        }

        public void read_and_insert()
        {
            if (!new DAL.TTGWeb.community_management_responsible().Add(read_line()))
                throw new Exception("小区联系人表插入失败！");
        }
    }
}
