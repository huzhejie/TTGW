using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace TTG.Web
{
    public partial class upload : System.Web.UI.Page
    {
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Files.Count > 0)
            {
                HttpPostedFile file = Request.Files[0];
                string comID = Request["comID"].ToString();
                TTG.DAL.TTGWeb.Community_Base DCB = new DAL.TTGWeb.Community_Base();
                DataSet ds = DCB.getCommunityInfo(comID);
                string communityName = ds.Tables[0].Rows[0]["community_name"].ToString();
                string comProvince = ds.Tables[0].Rows[0]["community_province"].ToString();
                string comCounty = ds.Tables[0].Rows[0]["community_county"].ToString();
                string FileName = Server.UrlDecode(Request.Params["fileName"]);
                string folder = Server.MapPath("~/数据表/" + comProvince + "\\" + comCounty + "\\" + comCounty + DateTime.Now.Year + "\\" + comID + communityName);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                string uurl = Server.MapPath("~/数据表/" + comProvince + "\\" + comCounty + "\\" + comCounty + DateTime.Now.Year + "\\" + comID + communityName + "\\" + FileName + ".xlsx");
                file.SaveAs(uurl);

                int state = Convert.ToInt32(Request["state"].ToString());
                if (state != 7)
                {
                    TTG.DAL.TTGWeb.excel_status DES = new DAL.TTGWeb.excel_status();
                    TTG.Model.TTGWeb.excel_status MES = new Model.TTGWeb.excel_status();
                    MES.community_id = comID;
                    MES.community_name = ds.Tables[0].Rows[0]["community_name"].ToString();
                    MES.state = state;
                    MES.excel_name = FileName + ".xlsx";
                    MES.investigator_id = Request["inID"].ToString();
                    if (state == 0)
                    {
                        DES.Add(MES);
                    }
                    else if (state == 1)
                    {
                        DES.UpdateState(MES);
                    }
                    else if (state == 2)
                    {
                        DES.UpdateState(MES);
                        string path="~/数据表/" + comProvince + "\\" + comCounty + "\\" + comCounty + DateTime.Now.Year + "\\" + comID + communityName + "\\" + FileName + ".xlsx";
                        adapter(FileName + ".xlsx", comID, path);
                    }
                }
            }
        }
        /// <summary>
        /// 文件对应的读取方法
        /// </summary>
        /// <param name="file">文件名</param>
        /// <param name="id">小区编号</param>
        public void adapter(string file, string id,string severPath)
        {
            string path = severPath;
            if (file.Equals("社区调查表.xls"))
            {
                DAL.READ.read_wcommunity model = new DAL.READ.read_wcommunity(path);
                model.read_and_insert();
            }
            else if (file.Equals("小区给排水基本情况.xlsx"))
            {
                DAL.READ.read_water_supply model = new DAL.READ.read_water_supply(path);
                model.read_and_insert(id);
            }
            else if (file.Equals("小区功能定位及人口基本情况.xlsx"))
            {
                DAL.READ.read_community_base model = new DAL.READ.read_community_base(path);
                model.read_and_insert(id);
            }
            else if (file.Equals("小区供电、照明及绿化基本情况.xlsx"))
            {
                new DAL.READ.read_elec_supply(path).read_and_insert(id);
            }
            else if (file.Equals("小区管理及监测人员.xlsx"))
                new DAL.READ.read_management(path).read_and_insert();
            else if (file.Equals("小区交通基本情况.xlsx"))
                new DAL.READ.read_community_road(path).read_and_insert(id);
            else if (file.Equals("小区教育及医疗基本情况.xlsx"))
                new DAL.READ.read_community_education(path).read_and_insert(id);
            else if (file.Equals("小区商贸及社区服务基本情况.xlsx"))
                new DAL.READ.read_community_culture_sports(path).read_and_insert(id);
            else if (file.Equals("小区消防、环卫、安防及其他基本情况.xlsx"))
                new DAL.READ.read_fire_fighting(path).read_and_insert(id);
            else if (file.Equals("小区效果标准表-填写.xlsx"))
                new DAL.READ.read_problems_first(path).read_and_insert(id);
            else if (file.Equals("小区效果标准表续表-填写.xlsx"))
                new DAL.READ.read_problem_second(path).read_and_insert(id);
            else if (file.Equals("小区移民门面经营及劳动力就业基本情况.xlsx"))
                new DAL.READ.read_shop_front(path).read_and_insert(id);
            else if (file.Equals("小区用地、住房基本情况.xlsx"))
                new DAL.READ.read_community_land(path).read_and_insert(id);
            else if (file.Equals("重要指标年度更新.xlsx"))
                new DAL.READ.read_important_figures(path).read_and_insert(id);
            else if (file.Equals("2013及之前专项资金项目.xlsx"))
                new DAL.READ.read_previous_project(path).read_and_insert();
            else if (file.Equals("2014及以后专项资金项目.xlsx"))
                new DAL.READ.read_subsequent_project(path).read_and_insert();
            else if (file.Equals("对口支援及其他项目.xlsx"))
                new DAL.READ.read_counterpart_project(path).read_and_insert();
            else if (file.Equals("小区项目实物表.xlsx"))
                new DAL.READ.read_project_physical(path).read_and_insert();
        }

    }
}
