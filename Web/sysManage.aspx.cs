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
    public partial class sysManage : System.Web.UI.Page
    {
        TTG.DAL.TTGWeb.notification_info DNOI = new DAL.TTGWeb.notification_info();
        TTG.Model.TTGWeb.notification_info MNOI = new Model.TTGWeb.notification_info();
        TTG.DAL.TTGWeb.file DFI = new DAL.TTGWeb.file();
        TTG.Model.TTGWeb.file MTF = new Model.TTGWeb.file();
        TTG.DAL.TTGWeb.errorLog DELOG = new DAL.TTGWeb.errorLog();
        TTG.DAL.TTGWeb.loginLog DLLOG = new DAL.TTGWeb.loginLog();
        TTG.DAL.TTGWeb.right DRIG = new DAL.TTGWeb.right();
        TTG.Model.TTGWeb.right MRIG = new Model.TTGWeb.right();
        TTG.DAL.TTGWeb.user DUSER = new DAL.TTGWeb.user();
        TTG.Model.TTGWeb.user MUSER = new Model.TTGWeb.user();
        TTG.DAL.TTGWeb.excel_message DEXCELMS = new DAL.TTGWeb.excel_message();
        TTG.Model.TTGWeb.excel_message MEXCELMS = new Model.TTGWeb.excel_message();
        public string publisher="";
        public string anntype="";
        public string time="";
        public string selectTime="";
        public string err="";
        public bool addblank = true;
        public bool addblankr = true;

        /// <summary>
        /// 初始化页面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Search.Attributes.Add("OnClick","return deliver()");
            publishBtn.Attributes.Add("OnClick", "return saveText()");
            uploadFileBtn.Attributes.Add("OnClick", "return checkFile()");
          
            //计算数据总量得到分页数量
            AspNetPager1.PageSize = 14;
            AspNetPager2.PageSize = 14;
            AspNetPager3.PageSize = 14;           
            if (!IsPostBack)
            {
                DataSet dsDepart = DNOI.GetDepart("");
                this.DropDownListPublisher.DataSource = dsDepart.Tables[0];
                this.DropDownListPublisher.DataTextField = "nf_depart";
                this.DropDownListPublisher.DataBind();
                this.DropDownListPublisher.Items.Insert(0, new ListItem("所有发布单位", ""));
                searchNotification();
                searchFile();
                searchStantardFile();
                //登陆日志
                DataSet loginlogDs = DLLOG.GetAll();
                this.GridViewLoginLog.DataSource = loginlogDs;
                this.GridViewLoginLog.DataBind();
                addblankfunl();
                //错误日志
                DataSet errorlogDs = DELOG.GetAll();
                this.GridViewErrLog.DataSource = errorlogDs;
                this.GridViewErrLog.DataBind();
                addblankfune();
                //用户管理
                GridViewUsrdata();
                addblankfun();
                //权限管理
                GridViewRigdata();
                addblankfunr();
            }
          
        }
        
       
        
        /// <summary>
        /// //查找通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Search_Click(object sender, EventArgs e)
        {
            searchNotification();
        }
        /// <summary>
        /// //查找文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SearchFileBtn_Click(object sender, EventArgs e)
        {
            searchFile();
        }
       /// <summary>
        ///  //发布通知公告
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void publishBtn_Click(object sender, EventArgs e)
        {
            //获取标题
            if (Texttitle.Value != "")
            {
                MNOI.nf_title = Texttitle.Value;
            }
            else {
                err += "标题不能为空";
            }
            //获取公告内容
            if (mytext.Value != "")
            {

                MNOI.nf_content = mytext.Value;
             
            }
            else
            {
                err += "内容不能为空";
            }
            //公告类型
            if (DropDownListPName.SelectedValue == "所有公告")
            {
                err += "公告类型不能为所有公告";
            }
            else
            {
                MNOI.nf_type = DropDownListPName.SelectedValue;
            }

            //发布单位
            if (publisherName.Value != "")
            {
                MNOI.nf_depart = publisherName.Value;
            }
            else
            {
                err += "发布单位不能为空";
            }
            if (string.IsNullOrEmpty(err.Trim()))
            {
                MNOI.nf_time = DateTime.Now;
                MNOI.nf_image = null;
                DNOI.Add(MNOI);
                

            }
            Response.Redirect("sysManage.aspx");
            //Texttitle.Value = "";
            //mytext.Value = "";
            //DropDownListPName.SelectedValue="所有公告";
            //publisherName.Value = "";
            //ClientScript.RegisterStartupScript(ClientScript.GetType(), "showscript", "<script>show(1);</script>");
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
                anno = anno.Substring(0,5) + "...";
                return anno;
            }
            return anno;
        }

       /// <summary>
        ///  //删除通知公告
       /// </summary>
       /// <param name="source"></param>
       /// <param name="e"></param>
        protected void RepeaterInf_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "d")
            {
                int nf_id = Convert.ToInt32(e.CommandArgument.ToString());
                DNOI.Delete(nf_id);
               searchNotification();
      
            }
            else if (e.CommandName == "m")
            {
                string a = e.CommandArgument.ToString();
                Response.Redirect("EditAnnounce.aspx?nfid="+a);
                //Response.Write("<script language='javascript'>window.open('LeaderIndex.aspx');</script>");
               // ClientScript.RegisterStartupScript(ClientScript.GetType(), "mysecscript", "<script>window.open('LeaderIndex.aspx');</script>");
           
            }
        }
        /// <summary>
        /// //删除文件
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void Repeaterfile_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "d")
            {
                int fileid = Convert.ToInt32(e.CommandArgument.ToString());
                DFI.Delete(fileid);
                searchFile();
 
            }
        }
        ///// <summary>
        ///// 修改
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //protected void modifyBtn_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("sysManage.aspx");
        //}
       
        /// <summary>
        /// 按条件查找通知公告
        /// </summary>
        public void searchNotification()
        {
            publisher = DropDownListPublisher.SelectedValue;
            anntype = DropDownListType.SelectedValue;
            time = demoTime.Value;
            if (publisher == "" || publisher == "所有发布单位")
            {
                publisher = "";
            }

            if (anntype == "" || anntype == "所有公告")
            {
                anntype = "";
            }
            if (time == "")
            {
                selectTime = "";
            }
            else
            {
                selectTime = time;
            }
            int recordCount = DNOI.GetRecordCount(anntype, publisher, selectTime);
            AspNetPager1.RecordCount = recordCount;
            AspNetPager1.CurrentPageIndex = 1;
            DataSet dsInf = DNOI.GetListByPage(anntype, publisher, selectTime, 1, 14);
            //这里添加首次需要加载的12条数据
            //综合帮扶信息数据
            this.RepeaterInf.DataSource = dsInf;
            this.RepeaterInf.DataBind();
        }

        /// <summary>
        ///  //分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            int StartIndex = AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager1.PageSize - 1;
            publisher = DropDownListPublisher.SelectedValue;
            anntype = DropDownListType.SelectedValue;
            time = demoTime.Value;
            if (publisher == "" || publisher == "所有发布单位")
            {
                publisher = "";
            }

            if (anntype == "" || anntype == "所有公告")
            {
                anntype = "";
            }
            if (time == "")
            {
                selectTime = "";
            }
            else
            {
                selectTime = time;
            }
            int recordCount = DNOI.GetRecordCount(anntype, publisher, selectTime);
            AspNetPager1.RecordCount = recordCount;
            DataSet dsInf = DNOI.GetListByPage(anntype, publisher, selectTime, StartIndex, EndIndex);
            this.RepeaterInf.DataSource = dsInf;
            this.RepeaterInf.DataBind();

        }
        
        /// <summary>
        /// 按条件查找文件
        /// </summary>
        public void searchFile() {
            string filetype = DropDownListFileType.SelectedValue;
            if (filetype == "" || filetype.Equals("所有文件"))
            {
                filetype = "";
            }
            int recordCount = DFI.GetRecordCount(filetype);
            AspNetPager2.RecordCount = recordCount;
            AspNetPager2.CurrentPageIndex = 1;
            DataSet dsFile = DFI.GetListByPage(filetype,1,14);
            this.Repeaterfile.DataSource = dsFile;
            this.Repeaterfile.DataBind();
        }

        /// <summary>
        ///  //分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager2_PageChanged(object sender, EventArgs e)
        {
           
            int StartIndex = AspNetPager2.PageSize * (AspNetPager2.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager2.PageSize - 1;
            string filetype = DropDownListFileType.SelectedValue;
            if (filetype == "" || filetype.Equals("所有文件"))
            {
                filetype = "";
            }
            int recordCount = DFI.GetRecordCount(filetype);
            AspNetPager2.RecordCount = recordCount;
            DataSet dsFile = DFI.GetListByPage(filetype, StartIndex, EndIndex);
            this.Repeaterfile.DataSource = dsFile;
            this.Repeaterfile.DataBind();

        }       
        
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void uploadFileBtn_Click(object sender, EventArgs e)
        {
            string severpath = "";
            string filename = "";
            string fileaddress = "";
            string fileExtension = "";
            if (FileUploadForFile.HasFile)
            {
                string filetype = DropDownListupType.SelectedValue;
                if (filetype != "" && !filetype.Equals("文件类型"))
                {
                    if (filetype == "居住环境规程规范")
                    {
                        severpath = Server.MapPath("~/主页可下载文件/居住环境规程规范");
                        fileExtension = System.IO.Path.GetExtension(FileUploadForFile.FileName).ToLower();
                        fileaddress = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "-" + System.IO.Path.GetFileNameWithoutExtension(FileUploadForFile.PostedFile.FileName) + fileExtension;
                        FileUploadForFile.SaveAs(severpath + "\\" + fileaddress);//上传文件
                        filename = FileUploadForFile.FileName;
                        MTF.file_name = filename;
                        MTF.file_address = fileaddress;
                        MTF.file_type = filetype;
                        MTF.time = DateTime.Now;
                        DFI.Add(MTF);
                        //Response.Redirect("sysManage.aspx");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>show(7);</script>");
                        searchFile();
                    }
                    else if (filetype == "小区帮扶标准规范")
                    {
                        severpath = Server.MapPath("~/主页可下载文件/小区帮扶标准规范");
                        fileExtension = System.IO.Path.GetExtension(FileUploadForFile.FileName).ToLower();
                        fileaddress = DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+"-"+DateTime.Now.Hour+"-"+DateTime.Now.Minute+"-"+DateTime.Now.Second+ "-" + System.IO.Path.GetFileNameWithoutExtension(FileUploadForFile.PostedFile.FileName)+fileExtension;
                        FileUploadForFile.SaveAs(severpath + "\\" + fileaddress);//上传文件
                        filename = FileUploadForFile.FileName;
                        MTF.file_name = filename;
                        MTF.file_address = fileaddress;
                        MTF.file_type = filetype;
                        MTF.time = DateTime.Now;
                        DFI.Add(MTF);
                        //Response.Redirect("sysManage.aspx");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>show(7);</script>");
                        searchFile();
                    }
                    else
                    {
                        Response.Write("<scropt>alert('上传出错！')</script>");
                    }
 
                }
              
            }
            
        }
        #region 标准表
        /// <summary>
        /// 查找标准表
        /// </summary>
        public void searchStantardFile()
        {
            int recordCount = DEXCELMS.GetRecordCount();
            AspNetPager3.RecordCount = recordCount;
            AspNetPager3.CurrentPageIndex = 1;
            DataSet dsFile = DEXCELMS.GetListByPage(1, 14);
            this.RepeaterStantard.DataSource = dsFile;
            this.RepeaterStantard.DataBind();
        }


        /// <summary>
        /// 标准表分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager3_PageChanged(object sender, EventArgs e)
        {
            int recordCount = DEXCELMS.GetRecordCount();
            AspNetPager3.RecordCount = recordCount;
            int StartIndex = AspNetPager3.PageSize * (AspNetPager3.CurrentPageIndex - 1) + 1;
            int EndIndex = StartIndex + AspNetPager3.PageSize - 1;         
            DataSet dsFile = DEXCELMS.GetListByPage(StartIndex, EndIndex);
            this.RepeaterStantard.DataSource = dsFile;
            this.RepeaterStantard.DataBind();

        }
  
        /// <summary>
        /// 上传标准表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void StantardUplBtn_Click(object sender, EventArgs e)
        {
            string severpath = "";
            if (FileUploadStantard.HasFile)
            {
                MEXCELMS.table_name = System.IO.Path.GetFileNameWithoutExtension(FileUploadStantard.FileName);
                MEXCELMS.table_path = System.IO.Path.GetFileName(FileUploadStantard.FileName);
                bool flag = DEXCELMS.Exists(MEXCELMS);
                if (!flag)
                {
                    severpath = Server.MapPath("~/标准表");
                    FileUploadStantard.SaveAs(severpath + "\\" + MEXCELMS.table_path);//上传文件    
                    
                    DEXCELMS.Add(MEXCELMS);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(UpdatePanel9, UpdatePanel9.GetType(), "", "<script>alert('存在同名文件，如果更改原文件，请先删除！');</script>", false);
                }
                
            }
            else {
                ScriptManager.RegisterStartupScript(UpdatePanel9, UpdatePanel9.GetType(), "", "<script>alert('您还没有选择文件或者选择的文件大小为0K！');</script>", false);
            }
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>show(8);</script>");

            searchStantardFile();
        }
        /// <summary>
        /// 删除标准表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void RepeaterStantard_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "delStantard")
            {
                int fileid = Convert.ToInt32(e.CommandArgument.ToString());
                DEXCELMS.Delete(fileid);
                searchStantardFile();
            }
        }

        #endregion 标准表
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
                bool adduserreturn= DUSER.Add(MUSER);
                if (adduserreturn)
                {
                    Tbuserid.Text = "";
                    Tbusername.Text = "";
                    Tbuserpwd.Text = "";
                    DropDownListAddUser.SelectedValue= "";
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
            string edit_com_id= this.GridViewRig.DataKeys[e.RowIndex].Value.ToString();
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
        /// <summary>
        /// //返回主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gobackrig_Click(object sender, EventArgs e)
        {
            TextBoxCom.Text = "";
            TextBoxInves.Text = "";
            TextBoxResp.Text = "";          
            GridViewRigdata();
            addblankfunr();
            this.GridViewRig.PageIndex = 0;
            UpdatePanel6.Update();
        }
        /// <summary>
        /// //增加权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void addRig_Click(object sender, EventArgs e)
        {
            string editcomid = TextBoxCom.Text.Trim();
            string editcominv = TextBoxCom.Text.Trim();
            string editcomresp = TextBoxResp.Text.Trim();
            if (editcomid != "" && editcominv != "" && editcomresp != "")
            {
                MRIG.community_id = TextBoxCom.Text.Trim();
                MRIG.investigator_id = TextBoxInves.Text.Trim();
                MRIG.areaChief_id = TextBoxResp.Text.Trim();
                bool addrigreturn= DRIG.Add(MRIG);
                if (addrigreturn)
                {
                    TextBoxCom.Text = "";
                    TextBoxInves.Text = "";
                    TextBoxResp.Text = "";
                    ScriptManager.RegisterStartupScript(UpdatePanel8, UpdatePanel8.GetType(), "", "<script>alert('添加成功！');</script>", false);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(UpdatePanel8, UpdatePanel8.GetType(), "", "<script>alert('请确保所有数据都已经填写！');</script>", false);
            }
        }
        /// <summary>
        /// //清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cleartxtRig_Click(object sender, EventArgs e)
        {
            TextBoxCom.Text = "";
            TextBoxInves.Text = "";
            TextBoxResp.Text = "";
        }
        #endregion  用户权限管理

        #region  登陆日志
        /// <summary>
        /// //初始化登陆日志gridview
        /// </summary>
        private void grigviewloginlogdata()
        {
            DataSet errorlogDs = DELOG.GetAll();
            this.GridViewErrLog.DataSource = errorlogDs;
            this.GridViewErrLog.DataBind();
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
            for (int i = 0; i < 7- GridViewErrLog.Rows.Count; i++)
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