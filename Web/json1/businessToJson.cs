using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTG.Web.json1
{
    public class businessToJson : json1.jsonTools
    {
        private DAL.GET.get_business gb;
        private StringBuilder result = new StringBuilder();

        public businessToJson(String province, String county, String community)
        {
            gb = new DAL.GET.get_business(province, county, community);
        }
        public String getResult()
        {
            result.Append("{");
            addAttribute("basicSituation");
            #region basicSituation
            result.Append("{");
            addAttribute("base");
            #region situation2013
            result.Append("{");
            addAttribute("community_shop_front_num");
            addValue(gb.Facade_num_2013);
            result.Append(",");
            addAttribute("community_immigrant_rent_out_sm_shop_front_num");
            addValue(gb.Rent_facade_2013);
            result.Append(",");
            addAttribute("community_average_rent_of_shop_front");
            addValue(gb.Average_rent_2013);
            result.Append(",");
            addAttribute("community_block_scene_bad");
            addValue(gb.Block_2013);
            result.Append(",");
            addAttribute("community_lack_prof_market");
            addValue(gb.Professional_2013);
            result.Append("},");
            #endregion
            addAttribute("present");
            #region situationNow
            result.Append("{");
            addAttribute("community_shop_front_num");
            addValue(gb.Facade_num_now);
            result.Append(",");
            addAttribute("community_immigrant_rent_out_sm_shop_front_num");
            addValue(gb.Rent_facade_now);
            result.Append(",");
            addAttribute("community_average_rent_of_shop_front");
            addValue(gb.Average_rent_now);
            result.Append(",");
            addAttribute("community_block_scene_bad");
            addValue(gb.Block_now);
            result.Append(",");
            addAttribute("community_lack_prof_market");
            addValue(gb.Professional_now);           
            result.Append("}");
            #endregion
            result.Append("},");
            #endregion
            addAttribute("implementSituation");
            #region implementSituation
            result.Append("{");
            addAttribute("plan");
            #region
            result.Append("{");
            addAttribute("community_recon_shop_front_num");
            addValue(gb.Change_facade_plan);
            result.Append(",");
            addAttribute("community_recon_shop_front_area");
            addValue(gb.Change_facade_area_plan);
            result.Append(",");
            addAttribute("community_recon_block_len");
            addValue(gb.Change_block_plan);
            result.Append(",");
            addAttribute("community_recon_facade");
            addValue(gb.Change_out_plan);
            result.Append(",");
            addAttribute("community_market_area");
            addValue(gb.Change_market_plan);
            result.Append(",");
            addAttribute("community_ins_merchant_num");
            addValue(gb.Business_num_plan);
            result.Append("},");
            #endregion achievement
            addAttribute("achievement");
            #region
            result.Append("{");
            addAttribute("community_recon_shop_front_num");
            addValue(gb.Change_facade_com);
            result.Append(",");
            addAttribute("community_recon_shop_front_area");
            addValue(gb.Change_facade_area_com);
            result.Append(",");
            addAttribute("community_recon_block_len");
            addValue(gb.Change_block_com);
            result.Append(",");
            addAttribute("community_recon_facade");
            addValue(gb.Change_out_com);
            result.Append(",");
            addAttribute("community_market_area");
            addValue(gb.Change_market_com);
            result.Append(",");
            addAttribute("community_ins_merchant_num");
            addValue(gb.Business_num_com);
            result.Append("}");
            #endregion
            result.Append("},");
            #endregion
            addAttribute("achievementSituation");
            #region achievementSituation
            result.Append("{");
            addAttribute("base");
            #region
            result.Append("{");
            addAttribute("shop_front_use_rate");
            addValue(gb.Facade_num_2013);
            result.Append(",");
            addAttribute("shop_front_rent_level");
            addValue(gb.Rent_level_2013);
            result.Append("},");
            #endregion
            addAttribute("present");
            #region
            result.Append("{");
            addAttribute("shop_front_use_rate");
            addValue(gb.Facade_num_now);
            result.Append(",");
            addAttribute("shop_front_rent_level");
            addValue(gb.Rent_level_now);
            result.Append("}");
            #endregion
            result.Append("}");
            #endregion
            result.Append("}");
            return result.ToString();
        }

        public void addAttribute(String attr)
        {
            result.Append("\"" + attr + "\":");
        }


        public void addValue(String value)
        {
            if (value == null || value == "")
            {
                value = "--";
            }
            else
            result.Append("\"" + value + "\"");
        }

        public void addValue(double value)
        {
            if (value.ToString() == "非数字")
            {
                result.Append("--");
            }
            else
                result.Append("\"" + value.ToString("0.00") + "\"");
        }

        public void addValue(int value)
        {
            result.Append("\"" + value + "\"");
        }

    }
}