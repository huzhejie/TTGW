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
    public partial class MutipleAnalysis : System.Web.UI.Page
    {
     
        TTG.DAL.TTGWeb.excel_status DEXCEL = new DAL.TTGWeb.excel_status();
        TTG.DAL.TTGWeb.user DUSER = new DAL.TTGWeb.user();

        /// <summary>
        /// 初始化页面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!IsPostBack)
            {
                getdata(1, 18);
                //初始化检测日志
                DAL.TTGWeb.monitor_log dtm = new DAL.TTGWeb.monitor_log();
                int recordCount = dtm.GetRecordCount("");
                AspNetPager2.RecordCount = recordCount;
                AspNetPager2.PageSize = 18;
                DataSet ds = dtm.GetListByPage("",1,18);
                RepeaterLog.DataSource = ds;
                RepeaterLog.DataBind();
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
            getdata(StartIndex, EndIndex);

        }

        /// <summary>
        /// 换页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager2_PageChanged(object sender, EventArgs e)
        {

            int StartIndex = AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager1.PageSize - 1;
            DAL.TTGWeb.monitor_log dtm = new DAL.TTGWeb.monitor_log();
            DataSet ds = dtm.GetListByPage("", StartIndex, EndIndex);
            RepeaterLog.DataSource = ds;
            RepeaterLog.DataBind();

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
        /// <summary>
        /// 把ID翻译为name
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string toName(string str)
        {
            DataSet ds = DUSER.GetOneName(str);
            return ds.Tables[0].Rows[0][0].ToString(); 
        }

        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void getdata(int start, int end)
        {


            string com_id = TextBoxCom.Text.ToString();
            string inves_id = TextBoxInves.Text.ToString();
            string area_id = TextBoxArea.Text.ToString();


            //计算数据总量得到分页数量
            int recordCount = DEXCEL.GetRecordCountTotal(area_id, inves_id, com_id, 1);
            AspNetPager1.RecordCount = recordCount;
            AspNetPager1.PageSize = 18;
            DataSet ds = DEXCEL.GetListByPageTotal(area_id, inves_id, com_id, 1, start, end);
            //这里添加首次需要加载的24条数据
            //综合帮扶信息数据
            this.RepeaterAidInf.DataSource = ds;
            this.RepeaterAidInf.DataBind();

        }

        /// <summary>
        /// 根据条件筛选文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBg_Click(object sender, EventArgs e)
        {
            string name = "调查员名";
            string bgTitle = TextBoxBgTitle.Text;
            if (bgTitle == "")
            {
                bgTitle = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "上传";
            }

            if (FileUploadBg.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUploadBg.FileName).ToLower();
                {
                    if (fileExtension == ".doc" || fileExtension == ".docx")
                    {
                        //这里添加上传到数据库的内容
                        string severpath = Server.MapPath("~/工作报告/" + name);
                        if (!Directory.Exists(severpath))
                        {
                            Directory.CreateDirectory(severpath);
                        }

                        string fileaddress = name + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + System.IO.Path.GetFileNameWithoutExtension(FileUploadBg.PostedFile.FileName) + fileExtension;
                        FileUploadBg.SaveAs(severpath + "\\" + fileaddress);//上传文件
                        Response.Write("<script>alert('上传成功！')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('只能上传word文档！')</script>");
                    }
                }
                
            }
            else
            {
                Response.Write("<script>alert('请选择文件！')</script>");
            }
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "showdiv2", "<script>showdiv2();</script>");
        }


        /// <summary>
        /// 页面初始数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQueryRig_Click(object sender, EventArgs e)
        {
            getdata(1, 18);
        }
    }
}