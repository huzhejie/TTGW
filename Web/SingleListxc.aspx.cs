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
using System.IO;

namespace TTG.Web
{
    public partial class SingleListxc : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.file DFILE = new DAL.TTGWeb.file();
        TTG.DAL.TTGWeb.notification_info DNOI = new DAL.TTGWeb.notification_info();
        protected void Page_Load(object sender, EventArgs e)
        {
             //计算数据总量得到分页数量
            int recordCount = DNOI.GetRecordCount("现场检测动态");
            AspNetPager1.RecordCount = recordCount;

            AspNetPager1.PageSize = 18;
            if (!IsPostBack)
            {
                
                //这里添加首次需要加载的24条数据
                DataSet dsFielddetection = DNOI.GetListByPage("现场检测动态", 1, 18);
                //现场检测动态数据
                this.RepeaterFielddetection.DataSource = dsFielddetection;
                this.RepeaterFielddetection.DataBind();
            }
        }

        /// <summary>
        /// 换页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {

            int StartIndex = AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager1.PageSize - 1;
            DataSet dsFielddetection = DNOI.GetListByPage("现场检测动态", StartIndex, EndIndex);
            this.RepeaterFielddetection.DataSource = dsFielddetection;
            this.RepeaterFielddetection.DataBind();
        }


        /// <summary>
        /// 截取字符串
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

    }
}