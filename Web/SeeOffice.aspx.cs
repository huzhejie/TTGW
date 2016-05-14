using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTG.Web
{
    public partial class SeeOffice : System.Web.UI.Page
    {
        public string strNewPath="";
        public string title="";
        public string filename="";
        public string fileType="";
        
        protected void Page_Load(object sender, EventArgs e)
        {

            filename = Request["officeFile"].ToString();
            //获取文件路径
            string path = Request["path"].ToString();
            path = path.Replace(" ", "");
            //获取文件后缀名判断文件类型
            int dotIndex = filename.LastIndexOf(".");       
            string fileExtension = filename.Substring(dotIndex + 1);
            if (fileExtension == "xlsx" || fileExtension == "xls") {
                fileType = "xls";
                init(path);
            }else if(fileExtension == "docx" || fileExtension == "doc"){
                fileType="doc";
                init(path);
            }else{
                Response.Write("<script>alert('文件类型不符合要求');</script>");
            }
           
        }
       /// <summary>
        /// 初始化页面信息
       /// </summary>
       /// <param name="path"></param>
        private void init(string path) {
            
            Response.Write(path);
            strNewPath = "http://localhost:8878/"+path+"/"+ filename;
            string strFileType = System.IO.Path.GetExtension(filename).ToString().ToLower();
            title = filename.Substring(0, filename.Length - strFileType.Length);
            Label1.Text = title;

        }

    }
}