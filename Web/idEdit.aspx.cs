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
    public partial class idEdit : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.user DUSER = new DAL.TTGWeb.user();
        TTG.Model.TTGWeb.user MUSER = new Model.TTGWeb.user();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //用户管理
                GridViewUsrdata();
                addblankfun();
            }
        }

        #region  用户账号管理


        /// <summary>
        /// //根据条件初始化用户管理gridview
        /// </summary>
        private void GridViewUsrdata()
        {
            //DataSet userDs = DUSER.GetAll();
            //this.GridViewUsr.DataSource = userDs;
            //this.GridViewUsr.DataBind();
            string strId = txtSearchId.Text.Trim();
            string strName = txtSearchName.Text.Trim();
            string strType = DropDownListUser.SelectedValue.ToString();
            if (strType == "全部类型")
            {
                strType = "";
            }
            else
            {
                strType = DropDownListUser.SelectedValue.ToString();
            }
            DataSet userconditionalDs = DUSER.GetConditionalData(strId, strName, strType);
            GridViewUsr.DataSource = userconditionalDs;
            GridViewUsr.DataBind();
        }

        /// <summary>
        /// //行数不够时添加空格
        /// </summary>
        private void addblankfun()
        {
            //设置底部分页一直存在(为了保证样式整齐)
            this.GridViewUsr.BottomPagerRow.Visible = true;
            //当Gridview行不足n时，填充空白行
            for (int i = 0; i < 10 - GridViewUsr.Rows.Count; i++)
            {
                int rowIndex = GridViewUsr.Rows.Count + i + 1;
                GridViewRow row = new GridViewRow(rowIndex, -1, DataControlRowType.EmptyDataRow, DataControlRowState.Normal);
                for (int j = 0; j < GridViewUsr.Columns.Count; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = "&nbsp;";
                    row.Controls.Add(cell);
                    row.Attributes.Add("BorderColor ", "#d2d2d2");
                    row.Attributes.Add("Height", "36px");
                }

                GridViewUsr.Controls[0].Controls.AddAt(rowIndex, row);

            }

        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQueryUsr_Click(object sender, EventArgs e)
        {
            GridViewUsrdata();
            addblankfun();
        }

        /// <summary>
        /// //分页绑定数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewUsr_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewUsr.PageIndex = e.NewPageIndex;
            GridViewUsrdata();
        }

        /// <summary>
        /// //编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewUsr_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUsr.EditIndex = e.NewEditIndex;
            GridViewUsrdata();
            addblankfun();
        }

        /// <summary>
        /// //取消编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewUsr_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewUsr.EditIndex = -1;
            GridViewUsrdata();
            addblankfun();
        }
        /// <summary>
        ///  //更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewUsr_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string edit_userid = this.GridViewUsr.DataKeys[e.RowIndex].Value.ToString();
            string edit_username = ((TextBox)(GridViewUsr.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
            string edit_userpwd = ((TextBox)(GridViewUsr.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();
            string edit_usertype = ((TextBox)(GridViewUsr.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim();
            MUSER.userId = edit_userid;
            MUSER.userName = edit_username;
            MUSER.userPwd = edit_userpwd;
            MUSER.userType = edit_usertype;
            DUSER.Update(MUSER);
            GridViewUsr.EditIndex = -1;
            GridViewUsrdata();
            addblankfun();
        }
        /// <summary>
        ///  //删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewUsr_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string edit_userid = this.GridViewUsr.DataKeys[e.RowIndex].Value.ToString();
            DUSER.Delete(edit_userid);
            GridViewUsrdata();
            addblankfun();
        }
        /// <summary>
        ///  //全选/全取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkAllUsr_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= GridViewUsr.Rows.Count - 1; i++)
            {
                //建立模板列中CheckBox控件的引用
                CheckBox chkUsr = (CheckBox)GridViewUsr.Rows[i].FindControl("chkCheckUsr");
                CheckBox chkAllUsr = (CheckBox)GridViewUsr.HeaderRow.FindControl("chkAllUsr");
                if (chkAllUsr.Checked == true)
                {
                    chkUsr.Checked = true;
                }
                else
                {
                    chkUsr.Checked = false;
                }
            }
        }
        /// <summary>
        /// //显示每行数据的行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void userUsr_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Text =
                Convert.ToString(GridViewUsr.PageSize * GridViewUsr.PageIndex + e.Row.RowIndex + 1);
            }

        }
        /// <summary>
        /// //分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void NavigateToPageUsr(object sender, CommandEventArgs e)
        {
            switch (e.CommandArgument.ToString())
            {

                case "First":
                    this.GridViewUsr.PageIndex = 0;
                    GridViewUsrdata();
                    if (this.GridViewUsr.PageIndex == this.GridViewUsr.PageCount - 1)
                    {
                        addblankfun();
                    }
                    break;
                case "Prev":
                    if (this.GridViewUsr.PageIndex > 0)
                        this.GridViewUsr.PageIndex -= 1;
                    GridViewUsrdata();
                    if (this.GridViewUsr.PageIndex == this.GridViewUsr.PageCount - 1)
                    {
                        addblankfun();
                    }
                    break;
                case "Next":
                    if (this.GridViewUsr.PageIndex < (this.GridViewUsr.PageCount - 1))
                        this.GridViewUsr.PageIndex += 1;
                    GridViewUsrdata();
                    if (this.GridViewUsr.PageIndex == this.GridViewUsr.PageCount - 1)
                    {
                        addblankfun();
                    }
                    break;
                case "Last":
                    this.GridViewUsr.PageIndex = this.GridViewUsr.PageCount - 1;
                    GridViewUsrdata();
                    addblankfun();
                    break;
            }


        }
        /// <summary>
        /// //删除选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbDeleteUsr_Click(object sender, EventArgs e)
        {
            //定义deleteCount变量用来计数选中行数
            int deleteCount = 0;
            for (int i = 0; i <= GridViewUsr.Rows.Count - 1; i++)
            {
                CheckBox cb = (CheckBox)GridViewUsr.Rows[i].FindControl("chkCheckUsr");
                if (cb != null && cb.Checked)
                {
                    string deleteuserstr = Convert.ToString(GridViewUsr.DataKeys[i].Value);
                    DUSER.Delete(deleteuserstr);
                    deleteCount += 1;
                }
            }

            if (deleteCount == 0)
            {
                Response.Write("<script>alert('请先选择要删除的用户！');</script>");
            }
            GridViewUsrdata();
            addblankfun();
        }
        /// <summary>
        /// //返回主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void goback_Click(object sender, EventArgs e)
        {
            Tbuserid.Text = "";
            Tbusername.Text = "";
            Tbuserpwd.Text = "";
            DropDownListAddUser.SelectedValue = "";
            GridViewUsrdata();
            addblankfun();
            this.GridViewUsr.PageIndex = 0;
            UpdatePanel5.Update();
        }
        /// <summary>
        ///  //增加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void addUser_Click(object sender, EventArgs e)
        {
            string useraddid = Tbuserid.Text.ToString();
            string useraddname = Tbusername.Text.ToString();
            string useraddpwd = Tbuserpwd.Text.ToString();
            string useraddtype = DropDownListAddUser.SelectedValue.ToString();
            if (useraddid != "" && useraddname != "" && useraddpwd != "" && useraddtype != "")
            {
                MUSER.userId = Tbuserid.Text.ToString();
                MUSER.userName = Tbusername.Text.ToString();
                MUSER.userPwd = Tbuserpwd.Text.ToString();
                MUSER.userType = DropDownListAddUser.SelectedValue.ToString();
                bool adduserreturn = DUSER.Add(MUSER);
                if (adduserreturn)
                {
                    Tbuserid.Text = "";
                    Tbusername.Text = "";
                    Tbuserpwd.Text = "";
                    DropDownListAddUser.SelectedValue = "";
                    ScriptManager.RegisterStartupScript(UpdatePanel7, UpdatePanel7.GetType(), "", "<script>alert('添加成功！');</script>", false);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(UpdatePanel7, UpdatePanel7.GetType(), "", "<script>alert('请确保所有数据都已经填写！');</script>", false);
            }
        }
        /// <summary>
        /// //清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cleartxt_Click(object sender, EventArgs e)
        {
            Tbuserid.Text = "";
            Tbusername.Text = "";
            Tbuserpwd.Text = "";
            DropDownListAddUser.SelectedValue = "";
        }
        #endregion  用户账号管理
    }
}