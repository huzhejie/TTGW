using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTG.DAL.TTGWeb;
using System.Data;

namespace TTG.Web
{
    public partial class LeaderIndex : System.Web.UI.Page
    {

        TTG.DAL.GET.get_search DGS = new DAL.GET.get_search();
        public string excelProvince = "";
        public string excelCounty = "";
       /// <summary>
       /// 初始化页面数据
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
        
            hideBtn1.Attributes.Add("style", "display:none");
            hideBtn2.Attributes.Add("style", "display:none");
            
            string[] Pro = new string[2];
            Pro[0] = "湖北省";
            Pro[1] = "重庆市";

            
            if (!Page.IsPostBack)
            {
                ////给button1添加客户端事件
                //Button2.Attributes.Add("OnClick", "return btnClick()");               

                this.RepeaterForPro.DataSource = Pro;
                this.RepeaterForPro.DataBind();
              
                prov.Value = "";
                county.Value = "";
                village.Value = "";
                getTotal();          
            }
           
        }

        /// <summary>
        /// 获得总数据
        /// </summary>
        private void getTotal() {
            //页面加载页面生成total数据echart
            #region 总数据
           
            
            DAL.GET.get_whole_msg model = new DAL.GET.get_whole_msg();
            //小区总数
            Labeltotalcommunity_num.Text = model.Totalcommunity_num;
            //县城小区
            Labeltotalcounty_community_num.Text = model.Totalcounty_community_num;
            //所有项目覆盖小区
            Labeltotalcover_community_num.Text = model.Totalcover_community_num;
            //人均可支配2013年情况
            Labeltotaldisposable_income_2013.Text = model.Totaldisposable_income_2013;
            //人均可支配当前年情况
            Labeltotaldisposable_income_now.Text = model.Totaldisposable_income_now;
            //其中移民总户数
            Labeltotalimmigrant_family_num.Text = model.Totalimmigrant_family_num;
            //其中移民总人数
            Labeltotalimmigrant_people_num.Text = model.Totalimmigrant_people_num;
            //人居可支配收入变化
            Labeltotalincome_change.Text = model.Totalincome_change;
            //劳动力就业率
            Labeltotallf_having_job_rate.Text = model.Totallf_having_job_rate;
            //低保人口比例
            Labeltotalpoor_people_rate.Text = model.Totalpoor_people_rate;
            //专项资金项目覆盖小区
            Labeltotalspecial_cover_community_num.Text = model.Totalspecial_cover_community_num;
            //居民总户数
            Labeltotaltotal_family_num.Text = model.Totaltotal_family_num;
            //居民总人数
            Labeltotaltotal_people_num.Text = model.Totaltotal_people_num;
            //集镇小区
            Labeltotaltown_community_num.Text = model.Totaltown_community_num;
            //房屋租金平均水平
            Labeltotalaverage_house_area.Text = model.Totalaverage_house_area;

            //2013年及之前专项资金项目个数
            Labelproject_num_2013.Text = model.project_num_2013;

            //2014年及之后专项资金项目个数
            Labelproject_num_2014.Text = model.project_num_2014;
            //2013年项目完工比例
            Labelproject_com_rate_2013.Text = model.project_com_rate_2013;
            //2014年项目完工比例
            Labelproject_com_rate_2014.Text = model.project_com_rate_2014;
            //累积专项资金下达
            Labelfounds_down.Text = model.founds_down;
            //累积专项资金完成
            Labelfounds_com.Text = model.founds_com;
            //专项资金完成比例
            Labelfounds_rate.Text = model.founds_rate;
            //2013年待建项目
            Labelbefore_cons_2013.Text = model.before_cons_2013;
            //2013年在建项目
            Labelin_cons_2013.Text = model.in_cons_2013;
            ///2013年完建项目
            Labelcom_cons_2013.Text = model.com_cons_2013;
            //2014待建项目
            Labelbefore_cons_2014.Text = model.before_cons_2014;
            //2014在建项目
            Labelin_cons_2014.Text = model.in_cons_2014;
            //2014完建项目
            Labelcom_cons_2014.Text = model.com_cons_2014;


            TextBoxTotalBefore.Text = model.before_cons_2013 + "-" + model.before_cons_2014 + "-";
            TextBoxTotalIn.Text = model.in_cons_2013 + "-" + model.in_cons_2014 + "-";
            TextBoxTotalCom.Text = model.com_cons_2013 + "-" + model.com_cons_2014 + "-";

            
            double[] investment_plan2 = model.Plan2;
            string investmentplan2 = "";
            for (int i = 0; i < investment_plan2.Length; i++)
            {
                investmentplan2 += investment_plan2[i] + "-";
            }
            LabelTotalPlan21.Text = investment_plan2[0].ToString();
            LabelTotalPlan22.Text = investment_plan2[1].ToString();
            LabelTotalPlan23.Text = investment_plan2[2].ToString();
            LabelTotalPlan24.Text = investment_plan2[3].ToString();
            LabelTotalPlan25.Text = investment_plan2[4].ToString();
            TextBoxTotalPlan2.Text = investmentplan2;

            double[] investment_finished2 = model.Finished2;
            string investmentfinished2 = "";
            for (int i = 0; i < investment_finished2.Length; i++)
            {
                investmentfinished2 += investment_finished2[i] + "-";
            }
            LabelTotalFinished21.Text = investment_finished2[0].ToString();
            LabelTotalFinished22.Text = investment_finished2[1].ToString();
            LabelTotalFinished23.Text = investment_finished2[2].ToString();
            LabelTotalFinished24.Text = investment_finished2[3].ToString();
            LabelTotalFinished25.Text = investment_finished2[4].ToString();
            TextBoxTotalFinished2.Text = investmentfinished2;
            #endregion 总数据

            ClientScript.RegisterStartupScript(ClientScript.GetType(), "showTotal", "<script>showTotal();</script>");
          
        }

        private void getProvince(string strProv) {
            #region 省市总数据
           

            TTG.DAL.GET.get_province_msg btngpm = new DAL.GET.get_province_msg(strProv.ToString());
            //小区总数
            Labelprovincecommunity_num.Text = btngpm.provincecommunity_num;
            //县城小区
            Labelprovincecounty_community_num.Text = btngpm.provincecounty_community_num;
            //所有项目覆盖小区
            Labelprovincecover_community_num.Text = btngpm.provincetown_community_num;
            //人均可支配2013年情况
            Labelprovincedisposable_income_2013.Text = btngpm.provincedisposable_income_2013;
            //人均可支配当前年情况
            Labelprovincedisposable_income_now.Text = btngpm.provincedisposable_income_now;
            //其中移民总户数
            Labelprovinceimmigrant_family_num.Text = btngpm.provinceimmigrant_family_num;
            //其中移民总人数
            Labelprovinceimmigrant_people_num.Text = btngpm.provinceimmigrant_people_num;
            //人居可支配收入变化
            Labelprovinceincome_change.Text = btngpm.provinceincome_change;
            //劳动力就业率
            Labelprovincelf_having_job_rate.Text = btngpm.provincelf_having_job_rate;
            //低保人口比例
            Labelprovincepoor_people_rate.Text = btngpm.provincepoor_people_rate;
            //专项资金项目覆盖小区
            Labelprovincespecial_cover_community_num.Text = btngpm.provincespecial_cover_community_num;
            //居民总户数
            Labelprovincetotal_family_num.Text = btngpm.provincetotal_family_num;
            //居民总人数
            Labelprovincetotal_people_num.Text = btngpm.provincetotal_people_num;
            //集镇小区
            Labelprovincetown_community_num.Text = btngpm.provincetown_community_num;
            //房屋租金平均水平
            Labelprovinceaverage_house_area.Text = btngpm.provinceaverage_house_area;
            //2013年及之前专项资金项目个数
            Labelprovince_project_num_2013.Text = btngpm.project_num_2013;

            //2014年及之后专项资金项目个数
            Labelprovince_project_num_2014.Text = btngpm.project_num_2014;
            //2013年项目完工比例
            Labelprovince_project_com_rate_2013.Text = btngpm.project_com_rate_2013;
            //2014年项目完工比例
            Labelprovince_project_com_rate_2014.Text = btngpm.project_com_rate_2014;
            //累积专项资金下达
            Labelprovince_founds_down.Text = btngpm.founds_down;
            //累积专项资金完成
            Labelprovince_founds_com.Text = btngpm.founds_com;
            //专项资金完成比例
            Labelprovince_founds_rate.Text = btngpm.founds_rate;
            //2013年待建项目
            Labelprovince_before_cons_2013.Text = btngpm.before_cons_2013;
            //2013年在建项目
            Labelprovince_in_cons_2013.Text = btngpm.in_cons_2013;
            ///2013年完建项目
            Labelprovince_com_cons_2013.Text = btngpm.com_cons_2013;
            //2014待建项目
            Labelprovince_before_cons_2014.Text = btngpm.before_cons_2014;
            //2014在建项目
            Labelprovince_in_cons_2014.Text = btngpm.in_cons_2014;
            //2014完建项目
            Labelprovince_com_cons_2014.Text = btngpm.com_cons_2014;

            TextBoxProvinceBefore.Text = btngpm.before_cons_2013 + "-" + btngpm.before_cons_2014 + "-";
            TextBoxProvinceIn.Text = btngpm.in_cons_2013 + "-" + btngpm.in_cons_2014 + "-";
            TextBoxProvinceCom.Text = btngpm.com_cons_2013 + "-" + btngpm.com_cons_2014 + "-";

            double[] investment_plan2 = btngpm.plan2;
            string investmentplan2 = "";
            for (int i = 0; i < investment_plan2.Length; i++)
            {
                investmentplan2 += investment_plan2[i] + "-";
            }
            LabelProvincePlan21.Text = investment_plan2[0].ToString();
            LabelProvincePlan22.Text = investment_plan2[1].ToString();
            LabelProvincePlan23.Text = investment_plan2[2].ToString();
            LabelProvincePlan24.Text = investment_plan2[3].ToString();
            LabelProvincePlan25.Text = investment_plan2[4].ToString();
            TextBoxProvincePlan2.Text = investmentplan2;

            double[] investment_finished2 = btngpm.finished2;
            string investmentfinished2 = "";
            for (int i = 0; i < investment_finished2.Length; i++)
            {
                investmentfinished2 += investment_finished2[i] + "-";
            }
            LabelProvinceFinished21.Text = investment_finished2[0].ToString();
            LabelProvinceFinished22.Text = investment_finished2[1].ToString();
            LabelProvinceFinished23.Text = investment_finished2[2].ToString();
            LabelProvinceFinished24.Text = investment_finished2[3].ToString();
            LabelProvinceFinished25.Text = investment_finished2[4].ToString();
            TextBoxProvinceFinished2.Text = investmentfinished2;
            #endregion 省市总数据
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "showProvince", "<script>showProvince();</script>");
                
        }
        /// <summary>
        /// 区县总数据
        /// </summary>
        private void getCounty() {
            #region 区县总数据

            TTG.DAL.GET.get_county_main dgcm = new DAL.GET.get_county_main();
            //小区数量
            Labelcountycommunity_num.Text = dgcm.Community_num.ToString();
            //县城（城市）小区
            Labelcountycounty_community_num.Text = dgcm.County_community_num.ToString();
            //所有项目覆盖小区
            Labelcountycover_community_num.Text = dgcm.Project_cover_num.ToString();
            //人居可支配收入2013
            Labelcountydisposable_income_2013.Text = dgcm.Average_income_2013.ToString();
            //人均可支配现在
            Labelcountydisposable_income_now.Text = dgcm.Average_income.ToString();
            //移民户数
            Labelcountyimmigrant_family_num.Text = dgcm.Immigrant_family_num.ToString();
            //移民人数
            Labelcountyimmigrant_people_num.Text = dgcm.Immigrant_people_num.ToString();
            //人均可支配变化
            Labelcountyincome_change.Text = Convert.ToDouble(dgcm.Income_change_situation).ToString("0.00");
            //劳动力就业率
            Labelcountylf_having_job_rate.Text = dgcm.Employment_rate.ToString();
            //低保人口比例
            Labelcountypoor_people_rate.Text = dgcm.Poor_rate.ToString();
            //专项资金项目覆盖小区
            Labelcountyspecial_cover_community_num.Text = dgcm.Special_cover_num.ToString();
            //总户数
            Labelcountytotal_family_num.Text = dgcm.Family_num.ToString();
            //总人数
            Labelcountytotal_people_num.Text = dgcm.People_num.ToString();
            //集镇小区
            Labelcountytown_community_num.Text = dgcm.Town_community_num.ToString();
            //人均住房面积
            Labelcountyaverage_house_area.Text = dgcm.Average_house_area.ToString();

            Labelcounty_project_num_2013.Text = dgcm.project_num_2013;
            //2014年及之后专项资金项目个数
            Labelcounty_project_num_2014.Text = dgcm.project_num_2014;
            //2013年项目完工比例
            Labelcounty_project_com_rate_2013.Text = dgcm.project_com_rate_2013;
            //2014年项目完工比例
            Labelcounty_project_com_rate_2014.Text = dgcm.project_com_rate_2014;
            //累积专项资金下达
            Labelcounty_founds_down.Text = dgcm.founds_down;
            //累积专项资金完成
            Labelcounty_founds_com.Text = dgcm.founds_com;
            //专项资金完成比例
            Labelcounty_founds_rate.Text = dgcm.founds_rate;
            //2013年待建项目
            Labelcounty_before_cons_2013.Text = dgcm.before_cons_2013;
            //2013年在建项目
            Labelcounty_in_cons_2013.Text = dgcm.in_cons_2013;
            ///2013年完建项目
            Labelcounty_com_cons_2013.Text = dgcm.com_cons_2013;
            //2014待建项目
            Labelcounty_before_cons_2014.Text = dgcm.before_cons_2014;
            //2014在建项目
            Labelcounty_in_cons_2014.Text = dgcm.in_cons_2014;
            //2014完建项目
            Labelcounty_com_cons_2014.Text = dgcm.com_cons_2014;


            //恩格尔系数
            Labelegr.Text = dgcm.Enger_figuer.ToString();
            

            TextBoxCountyBefore.Text = dgcm.before_cons_2013 + "-" + dgcm.before_cons_2014 + "-";
            TextBoxCountyIn.Text = dgcm.in_cons_2013 + "-" + dgcm.in_cons_2014 + "-";
            TextBoxCountyCom.Text = dgcm.com_cons_2013 + "-" + dgcm.com_cons_2014 + "-";

            double[] investment_plan2 = { dgcm.Plan_house_safe, dgcm.Plan_base_fac, dgcm.Plan_envir_pro, dgcm.Plan_public_fac, dgcm.Plan_busin };
            string investmentplan2 = "";
            for (int i = 0; i < investment_plan2.Length; i++)
            {
                investmentplan2 += investment_plan2[i] + "-";
            }
            LabelCouPlan21.Text = investment_plan2[0].ToString();
            LabelCouPlan22.Text = investment_plan2[1].ToString();
            LabelCouPlan23.Text = investment_plan2[2].ToString();
            LabelCouPlan24.Text = investment_plan2[3].ToString();
            LabelCouPlan25.Text = investment_plan2[4].ToString();
            TextBoxCouPlan2.Text = investmentplan2;

            double[] investment_finished2 = { dgcm.Com_house_safe, dgcm.Com_base_fac, dgcm.Com_envir_pro, dgcm.Com_public_fac, dgcm.Com_busin };
            string investmentfinished2 = "";
            for (int i = 0; i < investment_finished2.Length; i++)
            {
                investmentfinished2 += investment_finished2[i] + "-";
            }
            LabelCouFinished21.Text = investment_finished2[0].ToString();
            LabelCouFinished22.Text = investment_finished2[1].ToString();
            LabelCouFinished23.Text = investment_finished2[2].ToString();
            LabelCouFinished24.Text = investment_finished2[3].ToString();
            LabelCouFinished25.Text = investment_finished2[4].ToString();
            TextBoxCouFinished2.Text = investmentfinished2;
            #endregion 区县总数据
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "showCommunity", "<script>showCommunity();</script>");
          
        }
        /// <summary>
        /// 选择省市并找到对应的区县
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void hideBtn1_Click(object sender, EventArgs e)
        {
            
            string selectpro = prov.Value.ToString();
            DataSet ds = DGS.get_county(selectpro);
            this.RepeaterForCou.DataSource = ds;
            this.RepeaterForCou.DataBind();
        }


        /// <summary>
        /// 选择区县，找到对应的小区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void hideBtn2_Click(object sender, EventArgs e)
        {
          
            string selectVil = county.Value.ToString();
            string selectpro = prov.Value.ToString();
            DataSet ds = DGS.get_community(selectpro, selectVil);
            this.RepeaterForVil.DataSource = ds;
            this.RepeaterForVil.DataBind();
        }


        /// <summary>
        /// 根据条件加载不同的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void retirevalBtn_Click(object sender, EventArgs e)
        {
            string strProv = prov.Value.ToString();
            string strCou = county.Value.ToString();
            string strVil = village.Value.ToString();
            if (strProv == "" && strCou == "" && strVil == "")
            {
                bom1.Style["Display"] = "Block";
                bom2.Style["Display"] = "None";
                bom3.Style["Display"] = "None";
                //此处添加综合信息页面的相关信息
                getTotal();
            }
            else if (strProv != "" && strCou == "" && strVil == "")
            {
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "chooseBgimg", "<script>chooseBgimg();</script>");
                bom1.Style["Display"] = "None";
                bom2.Style["Display"] = "Block";
                bom3.Style["Display"] = "None";
                LabelPro.Text = strProv.ToString();
                //此处添加省市页面的相关信息
                getProvince(strProv);

            }
            else if (strProv != "" && strCou != "" && strVil == "")
            {
                bom1.Style["Display"] = "None";
                bom2.Style["Display"] = "None";
                bom3.Style["Display"] = "Block";
                LabelPro2.Text = strProv.ToString();
                LabelCou.Text = strCou.ToString();
                //此处添加区县页面相关信息
                excelProvince = strProv.ToString();
                excelCounty = strCou.ToString();
                getCounty();
            }
            else if (strProv != "" && strCou != "" && strVil != "")
            {
                string url = "community.aspx?pro=" + strProv + "&cou=" + strCou + "&vil=" + strVil;

                Response.Write("<script language='javascript'>window.open('" + url + "');</script>");
                bom1.Style["Display"] = "None";
                bom2.Style["Display"] = "None";
                bom3.Style["Display"] = "Block";
                LabelPro2.Text = strProv.ToString();
                LabelCou.Text = strCou.ToString();
                //这里添加县级信息
                //#region 区县总数据
                getCounty();
            }
            //未知的问题，在这个点击事件发生时会将searchresult的样式显示为block
            //在这里用于隐藏他
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "hideSr", "<script>hideSr();</script>");
        }

        /// <summary>
        /// 根据输入内容搜索小区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void vaguebutton_Click(object sender, EventArgs e)
        {
            string Vilname = vagueInput.Value.ToString();
            DataSet ds = DGS.get_province_and_county(Vilname);
            this.RepeaterCom.DataSource = ds;
            this.RepeaterCom.DataBind();
            //通过小区名搜索小区
            int vilNum = 0;
            if (ds.Tables[0].Rows.Count == 1)
            {
                vilNum = 1;
            }
            else if (ds.Tables[0].Rows.Count >1)
            {
                vilNum = 2;
            }
            if (vilNum == 0)
            {

                ScriptManager.RegisterStartupScript(UpdatePanel4, UpdatePanel4.GetType(), "", "alert('您搜索的小区不存在！')", true);
            }
            else if (vilNum == 1)
            {
                string strp = ds.Tables[0].Rows[0]["community_province"].ToString();
                string strc = ds.Tables[0].Rows[0]["community_county"].ToString();
                string url = "Community.aspx?pro=" + strp + "&cou=" + strc + "&vil=" + Vilname;
                ScriptManager.RegisterStartupScript(UpdatePanel4, UpdatePanel4.GetType(), "windowopen", "<script language='javascript'>window.open('" + url + "');</script>", false);
            }
            else if (vilNum > 1)
            {
                ScriptManager.RegisterStartupScript(UpdatePanel4, UpdatePanel4.GetType(), "showSr", "showSr()", true);
            }

        }

    }
}