using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TTG.DAL.READ
{
    public class read_important_figures
    {
        private read_excel re = new read_excel();
        private read_tools rt = new read_tools();

        private const string table_name = "T_important_figures";
        private const string excel_name = "重要指标年度更新";

        public read_important_figures(string path)
        {
            re.init(path);
        }

        private Model.TTGWeb.important_figures read_line(string id)
        {
            Model.TTGWeb.important_figures model = new Model.TTGWeb.important_figures()
            {
                community_id = id,
                //fill_time = new DateTime(DateTime.Now.Year, 1, 1)
                fill_time = new DateTime(2013,1,1)
            };
            List<Model.TTGWeb.excel_structure> list = new DAL.TTGWeb.excel_structure().getMessage(excel_name, table_name);
            PropertyInfo[] properties = model.GetType().GetProperties();
            for (int i = 0; i < list.Count; i++)
            {
                string attname = list[i].property;
                int index = rt.getIndex(attname, properties);
                if (index != -1)
                {
                    string type = properties[index].PropertyType.Name;
                    object obj = re.readcell(list[i].row_column_num, 2);
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

        public void read_and_insert(string id)
        {
            if (!new DAL.TTGWeb.important_figures().Add(read_line(id)))
                throw new Exception("重要指标表插入失败！");
        }
    }
}
