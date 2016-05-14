using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace TTG.Web.TTGWeb.effiect_translate
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		TTG.BLL.TTGWeb.effiect_translate bll=new TTG.BLL.TTGWeb.effiect_translate();
		TTG.Model.TTGWeb.effiect_translate model=bll.GetModel();
		this.lblchinese.Text=model.chinese;
		this.lblenglish.Text=model.english;
		this.lblelevel.Text=model.elevel.ToString();

	}


    }
}
