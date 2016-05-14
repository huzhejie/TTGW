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
    public partial class AreaResponsiblePerson : System.Web.UI.Page
    {
     
        TTG.DAL.TTGWeb.excel_status DEXCEL = new DAL.TTGWeb.excel_status();
        TTG.DAL.TTGWeb.right DRIGHT = new DAL.TTGWeb.right();
        TTG.DAL.TTGWeb.user DUSER = new DAL.TTGWeb.user();
        public string areaChief_id = "PQFZR01";

        /// <summary>
        /// 初始化页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            areaChief_id = Session["userId"].ToString();
            //确定可以选择的调查员和小区
            if (!IsPostBack)
            {
                //调查员
                DataSet dsForListIn = DRIGHT.GetListForDdlIn(areaChief_id);
                this.DropDownListInvs.DataSource = dsForListIn.Tables[0];
                this.DropDownListInvs.DataTextField = "ListInves";
                this.DropDownListInvs.DataBind();
                this.DropDownListInvs.Items.Insert(0, new ListItem("所有调查员", ""));

                //小区
                DataSet dsForListCom = DRIGHT.GetListForDdlCom(areaChief_id);
                this.DropDownListCom.DataSource = dsForListCom.Tables[0];
                this.DropDownListCom.DataTextField = "ListCom";
                this.DropDownListCom.DataBind();
                this.DropDownListCom.Items.Insert(0, new ListItem("所有小区", ""));
                getdata(1, 18);

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
        /// 获取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQueryRig_Click(object sender, EventArgs e)
        {
            getdata(1, 18);
        }


        /// <summary>
        /// 根据不同条件获取不同的数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void getdata(int start, int end)
        {
            string inv = DropDownListInvs.SelectedValue.ToString();
            string com = DropDownListCom.SelectedValue.ToString();
            string investicator_id;
            string comid;
            if (inv != "")
            {
                investicator_id = inv.Substring(inv.IndexOf("(") + 1, inv.Length - inv.IndexOf("(") - 2);
            }
            else
            {
                investicator_id = "";
            }
            if (com != "")
            {
                comid = com.Substring(com.IndexOf("(") + 1, com.Length - com.IndexOf("(") - 2);
            }
            else
            {
                comid = "";
            }
            //计算数据总量得到分页数量，
            int recordCount = DEXCEL.GetRecordCount(areaChief_id, investicator_id, comid, 0, 0);//0表示未审核的数据
            AspNetPager1.RecordCount = recordCount;
            AspNetPager1.PageSize = 18;
            DataSet ds = DEXCEL.GetListByPage(areaChief_id, investicator_id, comid, 0, 0, start, end);//0表示未审核的数据
            //这里添加首次需要加载的24条数据
            //综合帮扶信息数据
            this.RepeaterAidInf.DataSource = ds;
            this.RepeaterAidInf.DataBind();

        }
    }
}