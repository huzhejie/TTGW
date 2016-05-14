using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NPOI.XWPF.UserModel;

namespace TTG.DAL.READ
{
    public class write_word
    {
        private XWPFDocument doc;           //创建word文档
        private FileStream file;            //创建写入流
        public write_word(string path)
        {
            file = File.Create(path);
            doc = new XWPFDocument();
        }
        /// <summary>
        /// 创建段落
        /// </summary>
        /// <param name="content">段落内容</param>
        public void write_paragraph(string content)
        {
            XWPFParagraph paragraph = doc.CreateParagraph();        //向doc中添加段落
            XWPFRun text = paragraph.CreateRun();               //向该段落中添加文字
            text.SetText(content);                  //设置段落文字为
            //doc.Write(file);                    //将文字写入文件
        }
        
        /// <summary>
        /// 关闭文件流
        /// </summary>
        public void close()
        {
            doc.Write(file);
            file.Close();
        }
    }
}
