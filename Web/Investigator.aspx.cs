using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TTG.Web
{
    public partial class Investigator : System.Web.UI.Page
    {

        TTG.DAL.TTGWeb.excel_message DEXCELMS = new DAL.TTGWeb.excel_message();
        TTG.DAL.TTGWeb.right DRIGHT = new DAL.TTGWeb.right();
        TTG.DAL.TTGWeb.excel_status DEXCELST = new DAL.TTGWeb.excel_status();
        TTG.DAL.TTGWeb.image_info DIMG = new DAL.TTGWeb.image_info();
        TTG.Model.TTGWeb.image_info MIMG = new Model.TTGWeb.image_info();
        TTG.DAL.TTGWeb.Community_Base DCB = new DAL.TTGWeb.Community_Base();
        /// <summary>
        /// 初始化页面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                //找出所有的标准表
                DataSet dsStantard = DEXCELMS.GetList();              
                DropDownList2.DataSource = dsStantard.Tables[0].DefaultView;
                DropDownList2.DataTextField = "table_name";
                DropDownList2.DataValueField = "table_path";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--请选择--", ""));
                
               
                //transValue()是js函数
                string[] tempMonth = new string[1] { "还没有选择文件" };
                this.DropDownList1.DataSource = tempMonth;
                this.DropDownList1.DataBind();

                //选出负责的小区
                DataSet dsCommunity = DRIGHT.get_community_msg(Session["userId"].ToString());
                this.RepeaterCommunity.DataSource = dsCommunity;
                this.RepeaterCommunity.DataBind();
                btnOk.Attributes.Add("OnClick", "return transIdValue()");
                btnOk2.Attributes.Add("OnClick", "return transIdValue()");
                btnSearch.Attributes.Add("OnClick", "return transValue()");
                btnUpload.Attributes.Add("OnClick", "return transIdValue()");
            }

            // this.FileUpload1.Attributes.Add("onchange", Page.ClientScript.GetPostBackEventReference(this.FileUpload1, "onchange"));
            
        }

        /// <summary>
        /// 根据条件获取对应的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {            
            string starttime = hidestart.Value.ToString();
            string endtime = et.Value.ToString();
            DateTime dtStart = Convert.ToDateTime(starttime);
            DateTime dtEnd = Convert.ToDateTime(endtime);
            string mycommunityName = com.Value.ToString();
            int communityIdS = mycommunityName.IndexOf("(");
            string mycommunityId = mycommunityName.Substring(communityIdS + 1, mycommunityName.Length - 2 - communityIdS);
            DataSet dsCommunityExcel = DEXCELST.get_excel_msg(Session["userId"].ToString(), dtStart, dtEnd, mycommunityId);
            if (dsCommunityExcel.Tables[0].Rows.Count > 0)
            {
                this.DropDownList1.DataSource = dsCommunityExcel.Tables[0].DefaultView;
                this.DropDownList1.DataTextField = "excel_name";
                this.DropDownList1.DataValueField = "excel_name";
                this.DropDownList1.DataBind();
            }
            else {
                Response.Write("<script language='javascript'>alert('已选时间内没有未审核的数据表！');</script>");
            }
          

        }

        /// <summary>
        /// 进入修改数据表的页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            string mycommunityName = com.Value.ToString();
            if (mycommunityName == "")
            {
                Response.Write("<script language='javascript'>alert('请选择小区！');</script>");
            }
            else
            {
                int communityIdS = mycommunityName.IndexOf("(");
                string mycommunityId = mycommunityName.Substring(communityIdS + 1, mycommunityName.Length - 2 - communityIdS);
                string myfilename = DropDownList1.SelectedValue;
                if (myfilename == "还没有选择文件")
                {
                    Response.Write("<script language='javascript'>alert('没有选择数据表！');</script>");
                }
                else
                {
                    string url = "EditExcel.aspx?officeFile=" + myfilename + "&communityId=" + mycommunityId;
                    Response.Write("<script language='javascript'>window.open('" + url + "');</script>");
                }
            }
        }


        /// <summary>
        /// 进入增加数据表的页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk2_Click(object sender, EventArgs e)
        {
            string mycommunityName = com.Value.ToString();
            if (mycommunityName == "")
            {
                Response.Write("<script language='javascript'>alert('请选择小区！');</script>");
            }
            else
            {
                int communityIdS = mycommunityName.IndexOf("(");
                string mycommunityId = mycommunityName.Substring(communityIdS + 1, mycommunityName.Length - 2 - communityIdS);
                string myfilename = DropDownList2.SelectedValue;
                if (myfilename == "--请选择--")
                {
                    Response.Write("<script language='javascript'>alert('没有选择数据表！');</script>");
                }
                else
                {
                    string url = "StantardExcel.aspx?officeFile=" + myfilename + "&communityId=" + mycommunityId;
                    Response.Write("<script language='javascript'>window.open('" + url + "');</script>");
                }
            }
        }


        /// <summary>
        /// 上传小区对应的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMessage.Visible = false;
            string mycommunityName = com.Value.ToString();
            int communityIdS = mycommunityName.IndexOf("(");
            string mycommunityId = mycommunityName.Substring(communityIdS + 1, mycommunityName.Length - 2 - communityIdS);
            DataSet ds = DCB.getCommunityInfo(mycommunityId);
            
            string com_name = ds.Tables[0].Rows[0]["community_name"].ToString();
            string com_county = ds.Tables[0].Rows[0]["community_county"].ToString();
            string com_province = ds.Tables[0].Rows[0]["community_province"].ToString();
            System.Web.HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;
            System.Text.StringBuilder strmsg = new System.Text.StringBuilder("");
            int ifile;
            for (ifile = 0; ifile < files.Count; ifile++)
            {

                if (files[ifile].FileName.Length > 0)
                {
                    System.Web.HttpPostedFile postedfile = files[ifile];
                    if (postedfile.ContentLength / 1024 > 1024)//单个文件不能大于1024k
                    {
                        strmsg.Append(Path.GetFileName(postedfile.FileName) + "---不能大于1024k<br/>");

                    }
                    string fex = Path.GetExtension(postedfile.FileName);
                    if (fex != ".jpg" && fex != ".JPG" && fex != ".png" && fex != ".PNG")
                    {
                        strmsg.Append(Path.GetFileName(postedfile.FileName) + "---图片格式不对，只能是jpg或gif<br/>");

                    }
                }
            }


            if (strmsg.Length <= 0)//说明图片大小和格式都没问题
            {
                
                Random ro = new Random();
                int name = 0;
                for (int i = 0; i < files.Count; i++)
                {
                    System.Web.HttpPostedFile myFile = files[i];//rd[i]为对应的描述
                    string FileName = "";
                    string FileExtention = "";
                    FileName = System.IO.Path.GetFileName(myFile.FileName);
                    string stro = ro.Next(100, 100000000).ToString() + name.ToString();//产生一个随机数用于新命名的图片
                    string NewName = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + stro;
                    if (FileName.Length > 0)//有文件才执行上传操作再保存到数据库
                    {
                        FileExtention = System.IO.Path.GetExtension(myFile.FileName);
                        string filefolder = Server.MapPath("~/小区图片/" + com_province + "/" + com_county + "/" + com_name);
                        if (!Directory.Exists(filefolder))
                        {
                            Directory.CreateDirectory(filefolder);
                        }
                        string ppath = filefolder + "/" + NewName + FileExtention;
                        myFile.SaveAs(ppath);
                        //保存到数据库
                        MIMG.image_name = NewName;
                        MIMG.image_address = NewName;
                        MIMG.image_type = FileExtention;
                        //string mycommunityName = com.Value.ToString();
                        //int communityIdS = mycommunityName.IndexOf("(");
                        //string mycommunityId = mycommunityName.Substring(communityIdS + 1, mycommunityName.Length - 1 - communityIdS);
                        MIMG.community_id = mycommunityId;
                        DIMG.Add(MIMG);
                    }
                    name = name + 1;//用来重命名规则的变量
                }
                //Response.Write("<script>alert('恭喜，图片上传成功！')</script>");
                //Response.Redirect("Investigator.aspx");
                if (name > 0)
                {
                    Response.Write("<script>alert('恭喜，图片上传成功！');location='Investigator.aspx'</script>");
                }               
            }
            else
            {
                lblMessage.Text = strmsg.ToString();
                ///lblMessage.Text = rd.Length.ToString();
                lblMessage.Visible = true;
            }


        }


        /// <summary>
        /// 提交小区信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    TextBox1.Text = "yangkai";
        //    ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "", "alert('成功！')", true);
        //}

        
        /// <summary>
        /// 上传检测日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonRz_Click(object sender, EventArgs e)
        {
            string name = Session["username"].ToString();
            string Id = Session["userId"].ToString();
            string rzTitle = TextBoxRzTitle.Text;
            if (rzTitle == "")
            {
                Response.Write("<script>alert('文件名不能为空！')</script>");
                return;
                //rzTitle = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + "上传";
            }

            if (FileUploadRz.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUploadRz.FileName).ToLower();
                {
                    if (fileExtension == ".doc" || fileExtension == ".docx")
                    {
                        //这里添加上传到数据库的内容
                        Model.TTGWeb.monitor_log model = new Model.TTGWeb.monitor_log();
                        model.file_name = rzTitle;
                        string filePath=Id+ DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;
                        model.file_path = filePath + fileExtension;
                        model.investigator_id = Id;
                        model.fill_time = DateTime.Now;
                        DAL.TTGWeb.monitor_log dtm = new DAL.TTGWeb.monitor_log();
                        //上传到数据库
                        dtm.Add(model);
                        string severpath = Server.MapPath("~/监测日志/" + Id);
                        if (!Directory.Exists(severpath))
                        {
                            Directory.CreateDirectory(severpath);
                        }

                        string fileaddress = filePath + fileExtension;
                        FileUploadRz.SaveAs(severpath + "\\" + fileaddress);//上传文件
                        Response.Write("<script>alert('上传成功！')</script>");
                        return;
                    }
                    else
                    {
                        Response.Write("<script>alert('只能上传word文档！')</script>");
                        return;
                    }
                }

            }
            else
            {
                Response.Write("<script>alert('未选择文件或者文件大小为0！')</script>");
                return;
            }
        }

  
    }
}