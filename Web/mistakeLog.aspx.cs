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
    public partial class mistakeLog : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.errorLog DELOG = new DAL.TTGWeb.errorLog();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                //错误日志
                DataSet errorlogDs = DELOG.GetAll();
                this.GridViewErrLog.DataSource = errorlogDs;
                this.GridViewErrLog.DataBind();
                addblankfune();
            }
        }

        #region  错误日志
        /// <summary>
        /// //初始化错误日志
        /// </summary>
        private void gridviewerrlogdata()
        {
            DataSet errorlogDs = DELOG.GetAll();
            this.GridViewErrLog.DataSource = errorlogDs;
            this.GridViewErrLog.DataBind();
        }
        /// <summary>
        /// //行数不够时添加空格
        /// </summary>
        private void addblankfune()
        {
            //设置底部分页一直存在(为了保证样式整齐)
            this.GridViewErrLog.BottomPagerRow.Visible = true;
            //当Gridview行不足n时，填充空白行
            for (int i = 0; i < 7 - GridViewErrLog.Rows.Count; i++)
            {
                int rowIndex = GridViewErrLog.Rows.Count + i + 1;
                GridViewRow row = new GridViewRow(rowIndex, -1, DataControlRowType.EmptyDataRow, DataControlRowState.Normal);
                for (int j = 0; j < GridViewErrLog.Columns.Count; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = "&nbsp;";
                    row.Controls.Add(cell);
                    row.Attributes.Add("BorderColor ", "#d2d2d2");
                    row.Attributes.Add("Height", "50px");
                }

                GridViewErrLog.Controls[0].Controls.AddAt(rowIndex, row);

            }

        }
        /// <summary>
        /// //全选/全取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkAllErr_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= GridViewErrLog.Rows.Count - 1; i++)
            {
                //建立模板列中CheckBox控件的引用
                CheckBox chkErr = (CheckBox)GridViewErrLog.Rows[i].FindControl("chkCheckErr");
                CheckBox chkAllErr = (CheckBox)GridViewErrLog.HeaderRow.FindControl("chkAllErr");
                if (chkAllErr.Checked == true)
                {
                    chkErr.Checked = true;
                }
                else
                {
                    chkErr.Checked = false;
                }
            }
        }
        /// <summary>
        /// //显示每行数据的行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void errorLog_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Text =
                Convert.ToString(GridViewErrLog.PageSize * GridViewErrLog.PageIndex + e.Row.RowIndex + 1);
            }
        }
        /// <summary>
        /// //分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void NavigateToPageErr(object sender, CommandEventArgs e)
        {
            switch (e.CommandArgument.ToString())
            {
                case "First":
                    this.GridViewErrLog.PageIndex = 0;
                    gridviewerrlogdata();
                    if (this.GridViewErrLog.PageIndex == this.GridViewErrLog.PageCount - 1)
                    {

                        addblankfune();
                    }
                    break;
                case "Prev":
                    if (this.GridViewErrLog.PageIndex > 0)
                        this.GridViewErrLog.PageIndex -= 1;
                    gridviewerrlogdata();
                    if (this.GridViewErrLog.PageIndex == this.GridViewErrLog.PageCount - 1)
                    {

                        addblankfune();
                    }
                    break;
                case "Next":
                    if (this.GridViewErrLog.PageIndex < (this.GridViewErrLog.PageCount - 1))
                        this.GridViewErrLog.PageIndex += 1;
                    gridviewerrlogdata();
                    if (this.GridViewErrLog.PageIndex == this.GridViewErrLog.PageCount - 1)
                    {

                        addblankfune();
                    }
                    break;
                case "Last":
                    this.GridViewErrLog.PageIndex = this.GridViewErrLog.PageCount - 1;
                    gridviewerrlogdata();
                    addblankfune();
                    break;

            }

        }
        /// <summary>
        /// //删除选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbDeleteErr_Click(object sender, EventArgs e)
        {
            //定义deleteCount变量用来计数选中行数
            int deleteCount = 0;
            for (int i = 0; i <= GridViewErrLog.Rows.Count - 1; i++)
            {
                CheckBox cb = (CheckBox)GridViewErrLog.Rows[i].FindControl("chkCheckErr");
                if (cb != null && cb.Checked)
                {
                    deleteCount++;
                    int errorlog_id = Convert.ToInt32(GridViewErrLog.DataKeys[i].Value);
                    bool deleteResult = DELOG.Delete(errorlog_id);
                    if (deleteResult)
                    {
                        ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "", "<script>alert('删除成功！');</script>", false);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "", "<script>alert('删除失败！');</script>", false);
                    }


                }
            }
            if (deleteCount == 0) ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "", "<script>alert('请先选择要删除的日志！');</script>", false);
            gridviewerrlogdata();
            addblankfune();
        }
        #endregion  错误日志
    }
}