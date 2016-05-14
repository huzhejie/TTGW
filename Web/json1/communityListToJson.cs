using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTG.Web.json1
{
    public class communityListToJson :jsonTools
    {
        Model.TTGWeb.Community_Base community;
        DAL.TTGWeb.Community_Base communityBase;
        private StringBuilder result = new StringBuilder();

        public String getResult()
        {

            return result.ToString();
        }

        public void addAttribute(string attr)
        {
            result.Append("\"" + attr + "\":");
            throw new NotImplementedException();
        }

        public void addValue(string value)
        {
            if (value == null || value == "")
            {
                value = "--";
            }
            result.Append("\"" + value + "\"");
            throw new NotImplementedException();
        }

        public void addValue(double value)
        {
            result.Append("\"" + value + "\"");
        }

        public void addValue(int value)
        {
            result.Append("\"" + value + "\"");
        }
    }
}