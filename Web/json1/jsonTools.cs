using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTG.Web.json1
{
    public interface jsonTools
    {
        
      void addAttribute(String attr);

      void addValue(String value);

      void addValue(int value);

      void addValue(double value);

      String getResult();
    }
}
