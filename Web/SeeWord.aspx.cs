using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTG.Web
{
    public partial class SeeWord : System.Web.UI.Page
    {
        public string strNewPath;
        public string title;
        public string filename;
        protected void Page_Load(object sender, EventArgs e)
        {
            filename = Request["officeFile"].ToString();
            strNewPath = "http://localhost:8878/数据表/" + filename;
            string strFileType = System.IO.Path.GetExtension(filename).ToString().ToLower();
            title = filename.Substring(0, filename.Length - strFileType.Length);
            Label1.Text = title;
            filein.Text = title;
        }
    }
}