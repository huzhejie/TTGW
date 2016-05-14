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
    public partial class Site : System.Web.UI.MasterPage
    {
        TTG.DAL.TTGWeb.user DUSER = new DAL.TTGWeb.user();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LoadingBtn_Click(object sender, EventArgs e)
        {
            string user = userId.Value.ToString();
            string pass = password.Value.ToString();
            string ccode = Code.Value.ToString();
            if (user == "" || pass == "")
            {
                ScriptManager.RegisterStartupScript(UpdatePanel1, this.GetType(), "alertScript", "alert('请先输入用户名和密码');", true);
            }
            else
            {
                if (Session["CheckCode"].ToString() == ccode.ToLower())
                {
                    DataSet userInfo = DUSER.GetOne(user, pass);
                    //验证用户名密码是否正确
                    int recordcount = userInfo.Tables[0].Rows.Count;
                    //正确
                    if (recordcount > 0)
                    {
                        Session["userId"] = userInfo.Tables[0].Rows[0][3].ToString();
                        Session["username"] = userInfo.Tables[0].Rows[0][0].ToString();

                        string userType = userInfo.Tables[0].Rows[0][2].ToString();
                        if (userType == "调查员")
                        {

                            //ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "", "<script language='javascript'>window.open('Investigator.aspx');</script>", false);
                            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "", "<script language='javascript'>openIndex('Investigator.aspx');</script>", false);
                        }
                        else if (userType == "片区负责人")
                        {
                            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "", "<script language='javascript'>openIndex('AreaResponsiblePerson.aspx');</script>", false);
                        }
                        else if (userType == "综合分析员")
                        {
                            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "", "<script language='javascript'>openIndex('MutipleAnalysis.aspx');</script>", false);
                        }
                        else if (userType == "内部领导")
                        {
                            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "", "<script language='javascript'>openIndex('LeaderIndex.aspx');</script>", false);
                        }
                        else if (userType == "外部领导")
                        {
                            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "", "<script language='javascript'>openIndex('LeaderIndex.aspx');</script>", false);
                        }
                        else if (userType == "系统管理员")
                        {
                            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "", "<script language='javascript'>openIndex('allAnno.aspx');</script>", false);
                        }
                        Code.Value = "";
                        password.Value = "";
                        userId.Value = "";
                       
                  


                    }
                    else//错误
                    {
                        ScriptManager.RegisterStartupScript(UpdatePanel1, this.GetType(), "alertScript", "alert('对不起，用户名或密码错误！请重新输入');", true);
                        Code.Value = "";
                        password.Value = "";
                        userId.Value = "";
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(UpdatePanel1, this.GetType(), "alertScript", "alert('对不起，验证码错误！请重新输入');", true);
                    Code.Value = "";
                    password.Value = "";
                }
            }
        }
    }
}