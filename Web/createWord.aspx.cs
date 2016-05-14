using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTG.BLL.TTGWeb;
using TTG.Model;
using TTG.DAL.TTGWeb;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace TTG.Web
{
    public partial class createWord : System.Web.UI.Page
    {
      
            /// <summary>
            /// 初始化页面数据
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected void Page_Load(object sender, EventArgs e)
            {
                
            }
          
            /// <summary>
            /// //截取过长的标题
            /// </summary>
            /// <param name="anno"></param>
            /// <returns></returns>
            public string trimanno(string anno)
            {
                if (anno.Length >= 25)
                {
                    anno = anno.Substring(0, 25) + "...";
                    return anno;
                }
                return anno;
            }

            /// <summary>
            /// //截取过长的标题
            /// </summary>
            /// <param name="anno"></param>
            /// <returns></returns>
            public string trimanno6(string anno)
            {
                if (anno.Length > 6)
                {
                    anno = anno.Substring(0, 5) + "...";
                    return anno;
                }
                return anno;
            }

           
           
        
    }
}