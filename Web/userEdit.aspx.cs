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
    public partial class userEdit : System.Web.UI.Page
    {

        TTG.DAL.TTGWeb.right DRIG = new DAL.TTGWeb.right();
        TTG.Model.TTGWeb.right MRIG = new Model.TTGWeb.right();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                //权限管理
                GridViewRigdata();
                addblankfunr();
            }
        }

        #region  用户权限管理
        /// <summary>
        /// //根据条件初始化用户权限gridview 
        /// </summary>     
        private void GridViewRigdata()
        {
            //DataSet rigDs = DRIG.GetAll();
            //this.GridViewRig.DataSource = rigDs;
            //this.GridViewRig.DataBind();
            string com_name = txtRigComu.Text;
            string com_inves = txtRigInve.Text;
            string com_resp = txtRigResp.Text;
            DataSet rigconditionalDs = DRIG.GetConditionalData(com_name.Trim(), com_inves.Trim(), com_resp.Trim());
            this.GridViewRig.DataSource = rigconditionalDs;
            this.GridViewRig.DataBind();

        }
        /// <summary>
        /// //当Gridview行不足n时，填充空白行
        /// </summary>
        private void addblankfunr()
        {
            //设置底部分页一直存在(为了保证样式整齐)
            this.GridViewRig.BottomPagerRow.Visible = true;
            //当Gridview行不足n时，填充空白行
            for (int i = 0; i < 10 - GridViewRig.Rows.Count; i++)
            {
                int rowIndex = GridViewRig.Rows.Count + i + 1;
                GridViewRow row = new GridViewRow(rowIndex, -1, DataControlRowType.EmptyDataRow, DataControlRowState.Normal);
                for (int j = 0; j < GridViewRig.Columns.Count; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = "&nbsp;";
                    row.Controls.Add(cell);
                    row.Attributes.Add("BorderColor ", "#d2d2d2");
                    row.Attributes.Add("Height", "36px");
                }

                GridViewRig.Controls[0].Controls.AddAt(rowIndex, row);

            }
        }
        /// <summary>
        /// //查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQueryRig_Click(object sender, EventArgs e)
        {
            GridViewRigdata();
            addblankfunr();
        }
        /// <summary>
        ///  //全选/全取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkAllRig_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= GridViewRig.Rows.Count - 1; i++)
            {
                //建立模板列中CheckBox控件的引用
                CheckBox chkRig = (CheckBox)GridViewRig.Rows[i].FindControl("chkCheckRig");
                CheckBox chkAllRig = (CheckBox)GridViewRig.HeaderRow.FindControl("chkAllRig");
                if (chkAllRig.Checked == true)
                {
                    chkRig.Checked = true;
                }
                else
                {
                    chkRig.Checked = false;
                }
            }
        }
        /// <summary>
        /// //显示每行数据的行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void userRig_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Text =
                Convert.ToString(GridViewRig.PageSize * GridViewRig.PageIndex + e.Row.RowIndex + 1);
            }

        }
        /// <summary>
        ///  //分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void NavigateToPageRig(object sender, CommandEventArgs e)
        {
            switch (e.CommandArgument.ToString())
            {

                case "First":
                    this.GridViewRig.PageIndex = 0;
                    GridViewRigdata();
                    if (this.GridViewRig.PageIndex == this.GridViewRig.PageCount - 1)
                    {
                        addblankfunr();
                    }
                    break;
                case "Prev":
                    if (this.GridViewRig.PageIndex > 0)
                        this.GridViewRig.PageIndex -= 1;
                    GridViewRigdata();
                    if (this.GridViewRig.PageIndex == this.GridViewRig.PageCount - 1)
                    {
                        addblankfunr();
                    }
                    break;
                case "Next":
                    if (this.GridViewRig.PageIndex < (this.GridViewRig.PageCount - 1))
                        this.GridViewRig.PageIndex += 1;
                    GridViewRigdata();
                    if (this.GridViewRig.PageIndex == this.GridViewRig.PageCount - 1)
                    {
                        addblankfunr();
                    }
                    break;
                case "Last":
                    this.GridViewRig.PageIndex = this.GridViewRig.PageCount - 1;
                    GridViewRigdata();
                    addblankfunr();
                    break;
            }
        }
        /// <summary>
        /// //分页绑定数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewRig_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewRig.PageIndex = e.NewPageIndex;
            GridViewRigdata();
            addblankfunr();
        }
        /// <summary>
        ///  //编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewRig_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRig.EditIndex = e.NewEditIndex;
            GridViewRigdata();
            addblankfunr();
        }
        /// <summary>
        /// //取消编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewRig_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewRig.EditIndex = -1;
            GridViewRigdata();
            addblankfunr();
        }
        /// <summary>
        ///  //更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewRig_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string edit_com_id = this.GridViewRig.DataKeys[e.RowIndex].Value.ToString();
            string edit_com_inv = ((TextBox)(GridViewRig.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();
            string edit_com_resp = ((TextBox)(GridViewRig.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim();
            MRIG.community_id = edit_com_id;
            MRIG.investigator_id = edit_com_inv;
            MRIG.areaChief_id = edit_com_resp;
            DRIG.Update(MRIG);
            GridViewRig.EditIndex = -1;
            GridViewRigdata();
            addblankfunr();
        }
        /// <summary>
        /// //删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewRig_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string edit_comid = this.GridViewRig.DataKeys[e.RowIndex].Value.ToString();
            DRIG.Delete(edit_comid);
            GridViewRigdata();
            addblankfunr();
        }
        /// <summary>
        /// //删除选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbDeleteRig_Click(object sender, EventArgs e)
        {
            //定义deleteCount变量用来计数选中行数
            int deleteCount = 0;
            for (int i = 0; i <= GridViewRig.Rows.Count - 1; i++)
            {
                string deleteComId = Convert.ToString(GridViewRig.DataKeys[i].Value).Trim();
                DRIG.Delete(deleteComId);
                deleteCount += 1;
            }

            if (deleteCount == 0)
            {
                Response.Write("<script>alert('请先选择要删除的权限！');</script>");
            }
            GridViewRigdata();
            addblankfunr();
        }
        
        #endregion  用户权限管理
    }
}