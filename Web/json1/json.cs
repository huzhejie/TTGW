using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

namespace TTG.Web.Json
{
    public class json
    {
        TTG.DAL.TTGWeb.notification_info DNOI = new DAL.TTGWeb.notification_info();
        TTG.Model.TTGWeb.notification_info MNOI = new Model.TTGWeb.notification_info();

        public string publisher;
        public string anntype;
        public string time;
        public string selectTime;
        public DataSet ds;

        public String DStoJson()
        {
            //String json = "";
            ds = DNOI.GetList("") ;
            System.Text.StringBuilder str = new System.Text.StringBuilder("[");
            for (int o = 0; o < ds.Tables.Count; o++)
            {
                str.Append("{");
                str.Append(string.Format("\"{0}\":[", ds.Tables[o].TableName));

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    str.Append("{");
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        str.Append(string.Format("\"{0}\":\"{1}\",", ds.Tables[0].Columns[j].ColumnName, ds.Tables[0].Rows[i][j].ToString()));
                    }
                    str.Remove(str.Length - 1, 1);
                    str.Append("},");
                }
                str.Remove(str.Length - 1, 1);
                str.Append("]},");
            }
            str.Remove(str.Length - 1, 1);
            str.Append("]");
            return str.ToString();


        }

        public String DStoXML()
        {
            ds = DNOI.GetList("");
            MemoryStream stream = null;
            XmlTextWriter writer = null;

            try
            {
                stream = new MemoryStream();
                //从stream装载到XmlTextReader
                writer = new XmlTextWriter(stream, Encoding.Unicode);

                //用WriteXml方法写入文件.
                ds.WriteXml(writer);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);

                UnicodeEncoding utf = new UnicodeEncoding();
                return utf.GetString(arr).Trim();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

       public void xmlFile(String xml,String file)
        {
            UnicodeEncoding utf = new UnicodeEncoding();
            StreamWriter sw = new StreamWriter(file);
            //sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine(xml);
            sw.Close();
        }

    }
}