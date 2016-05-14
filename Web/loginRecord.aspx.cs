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
    public partial class loginRecord : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.loginLog DLLOG = new DAL.TTGWeb.loginLog();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                //登陆日志
                DataSet loginlogDs = DLLOG.GetAll();
                this.GridViewLoginLog.DataSource = loginlogDs;
                this.GridViewLoginLog.DataBind();
                addblankfunl();
            }

        }

        #region  登陆日志
        /// <summary>
        /// //初始化登陆日志gridview
        /// </summary>
        private void grigviewloginlogdata()
        {
            DataSet loginlogDs = DLLOG.GetAll();
            this.GridViewLoginLog.DataSource = loginlogDs;
            this.GridViewLoginLog.DataBind();
        }
        /// <summary>
        /// //行数不够时添加空格
        /// </summary>
        private void addblankfunl()
        {
            //设置底部分页一直存在(为了保证样式整齐)
            this.GridViewLoginLog.BottomPagerRow.Visible = true;
            //当Gridview行不足n时，填充空白行
            for (int i = 0; i < 10 - GridViewLoginLog.Rows.Count; i++)
            {
                int rowIndex = GridViewLoginLog.Rows.Count + i + 1;
                GridViewRow row = new GridViewRow(rowIndex, -1, DataControlRowType.EmptyDataRow, DataControlRowState.Normal);
                for (int j = 0; j < GridViewLoginLog.Columns.Count; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = "&nbsp;";
                    row.Controls.Add(cell);
                    row.Attributes.Add("BorderColor ", "#d2d2d2");
                    row.Attributes.Add("Height", "36px");
                }

                GridViewLoginLog.Controls[0].Controls.AddAt(rowIndex, row);

            }

        }
        /// <summary>
        ///  //全选/全取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkAllLog_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= GridViewLoginLog.Rows.Count - 1; i++)
            {
                //建立模板列中CheckBox控件的引用
                CheckBox chkLog = (CheckBox)GridViewLoginLog.Rows[i].FindControl("chkCheckLod");
                CheckBox chkAllLog = (CheckBox)GridViewLoginLog.HeaderRow.FindControl("chkAllLog");
                if (chkAllLog.Checked == true)
                {
                    chkLog.Checked = true;
                }
                else
                {
                    chkLog.Checked = false;
                }
            }
        }
        /// <summary>
        /// //显示每行数据的行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void loginLog_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Text =
                Convert.ToString(GridViewLoginLog.PageSize * GridViewLoginLog.PageIndex + e.Row.RowIndex + 1);
            }
        }
        /// <summary>
        /// //分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void NavigateToPageLog(object sender, CommandEventArgs e)
        {
            switch (e.CommandArgument.ToString())
            {

                case "First":
                    this.GridViewLoginLog.PageIndex = 0;
                    grigviewloginlogdata();
                    if (this.GridViewLoginLog.PageIndex == this.GridViewLoginLog.PageCount - 1)
                    {

                        addblankfunl();
                    }
                    break;
                case "Prev":
                    if (this.GridViewLoginLog.PageIndex > 0)
                        this.GridViewLoginLog.PageIndex -= 1;
                    grigviewloginlogdata();
                    if (this.GridViewLoginLog.PageIndex == this.GridViewLoginLog.PageCount - 1)
                    {

                        addblankfunl();
                    }
                    break;
                case "Next":
                    if (this.GridViewLoginLog.PageIndex < (this.GridViewLoginLog.PageCount - 1))
                        this.GridViewLoginLog.PageIndex += 1;
                    grigviewloginlogdata();
                    if (this.GridViewLoginLog.PageIndex == this.GridViewLoginLog.PageCount - 1)
                    {

                        addblankfunl();
                    }
                    break;
                case "Last":
                    this.GridViewLoginLog.PageIndex = this.GridViewLoginLog.PageCount - 1;
                    grigviewloginlogdata();
                    addblankfunl();
                    break;

            }

        }
        /// <summary>
        ///  //删除选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbDeleteLog_Click(object sender, EventArgs e)
        {
            //定义deleteCount变量用来计数选中行数
            int deleteCount = 0;
            for (int i = 0; i <= GridViewLoginLog.Rows.Count - 1; i++)
            {
                CheckBox cb = (CheckBox)GridViewLoginLog.Rows[i].FindControl("chkCheckLog");
                if (cb != null && cb.Checked)
                {
                    deleteCount++;
                    int loginlog_id = Convert.ToInt32(GridViewLoginLog.DataKeys[i].Value);
                    bool deleteResult = DLLOG.Delete(loginlog_id);
                    if (deleteResult)
                    {
                        ScriptManager.RegisterStartupScript(UpdatePanel4, UpdatePanel4.GetType(), "", "<script>alert('删除成功！');</script>", false);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(UpdatePanel4, UpdatePanel4.GetType(), "", "<script>alert('删除失败！');</script>", false);
                    }
                }
            }
            if (deleteCount == 0) ScriptManager.RegisterStartupScript(UpdatePanel4, UpdatePanel4.GetType(), "", "<script>alert('请先选择要删除的日志！');</script>", false);
            grigviewloginlogdata();
            addblankfunl();
        }
        #endregion  登陆日志
    }
}