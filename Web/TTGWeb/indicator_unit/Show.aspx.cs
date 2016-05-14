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
namespace TTG.Web.TTGWeb.indicator_unit
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
		TTG.BLL.TTGWeb.indicator_unit bll=new TTG.BLL.TTGWeb.indicator_unit();
		TTG.Model.TTGWeb.indicator_unit model=bll.GetModel();
		this.lblindicator.Text=model.indicator;
		this.lbltranslation.Text=model.translation;
		this.lblunit.Text=model.unit;

	}


    }
}
