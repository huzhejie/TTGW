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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace TTG.Web.TTGWeb.enterprise
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtid.Text.Trim().Length==0)
			{
				strErr+="id不能为空！\\n";	
			}
			if(this.txtcounty.Text.Trim().Length==0)
			{
				strErr+="county不能为空！\\n";	
			}
			if(this.txtcommunty.Text.Trim().Length==0)
			{
				strErr+="communty不能为空！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtaddress.Text.Trim().Length==0)
			{
				strErr+="address不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdistance_to_community.Text))
			{
				strErr+="distance_to_community格式错误！\\n";	
			}
			if(this.txttype.Text.Trim().Length==0)
			{
				strErr+="type不能为空！\\n";	
			}
			if(this.txtmain_product.Text.Trim().Length==0)
			{
				strErr+="main_product不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtarea.Text))
			{
				strErr+="area格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstuff_amount.Text))
			{
				strErr+="stuff_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtimmigrant_stuff_amount.Text))
			{
				strErr+="immigrant_stuff_amount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlf_average_salary.Text))
			{
				strErr+="lf_average_salary格式错误！\\n";	
			}
			if(this.txtnote_information.Text.Trim().Length==0)
			{
				strErr+="note_information不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstatistics_date.Text))
			{
				strErr+="statistics_date格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheck_status.Text))
			{
				strErr+="check_status格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlock_tables.Text))
			{
				strErr+="lock_tables格式错误！\\n";	
			}
			if(this.txtteunset1.Text.Trim().Length==0)
			{
				strErr+="teunset1不能为空！\\n";	
			}
			if(this.txtteunset2.Text.Trim().Length==0)
			{
				strErr+="teunset2不能为空！\\n";	
			}
			if(this.txtteunset3.Text.Trim().Length==0)
			{
				strErr+="teunset3不能为空！\\n";	
			}
			if(this.txtteunset4.Text.Trim().Length==0)
			{
				strErr+="teunset4不能为空！\\n";	
			}
			if(this.txtteunset5.Text.Trim().Length==0)
			{
				strErr+="teunset5不能为空！\\n";	
			}
			if(this.txtteunset6.Text.Trim().Length==0)
			{
				strErr+="teunset6不能为空！\\n";	
			}
			if(this.txtteunset7.Text.Trim().Length==0)
			{
				strErr+="teunset7不能为空！\\n";	
			}
			if(this.txtteunset8.Text.Trim().Length==0)
			{
				strErr+="teunset8不能为空！\\n";	
			}
			if(this.txtteunset9.Text.Trim().Length==0)
			{
				strErr+="teunset9不能为空！\\n";	
			}
			if(this.txtteunset10.Text.Trim().Length==0)
			{
				strErr+="teunset10不能为空！\\n";	
			}
			if(this.txtteunset11.Text.Trim().Length==0)
			{
				strErr+="teunset11不能为空！\\n";	
			}
			if(this.txtteunset12.Text.Trim().Length==0)
			{
				strErr+="teunset12不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string id=this.txtid.Text;
			string county=this.txtcounty.Text;
			string communty=this.txtcommunty.Text;
			string name=this.txtname.Text;
			string address=this.txtaddress.Text;
			decimal distance_to_community=decimal.Parse(this.txtdistance_to_community.Text);
			string type=this.txttype.Text;
			string main_product=this.txtmain_product.Text;
			decimal area=decimal.Parse(this.txtarea.Text);
			int stuff_amount=int.Parse(this.txtstuff_amount.Text);
			int immigrant_stuff_amount=int.Parse(this.txtimmigrant_stuff_amount.Text);
			decimal lf_average_salary=decimal.Parse(this.txtlf_average_salary.Text);
			string note_information=this.txtnote_information.Text;
			DateTime statistics_date=DateTime.Parse(this.txtstatistics_date.Text);
			int check_status=int.Parse(this.txtcheck_status.Text);
			int lock_tables=int.Parse(this.txtlock_tables.Text);
			string teunset1=this.txtteunset1.Text;
			string teunset2=this.txtteunset2.Text;
			string teunset3=this.txtteunset3.Text;
			string teunset4=this.txtteunset4.Text;
			string teunset5=this.txtteunset5.Text;
			string teunset6=this.txtteunset6.Text;
			string teunset7=this.txtteunset7.Text;
			string teunset8=this.txtteunset8.Text;
			string teunset9=this.txtteunset9.Text;
			string teunset10=this.txtteunset10.Text;
			string teunset11=this.txtteunset11.Text;
			string teunset12=this.txtteunset12.Text;

			TTG.Model.TTGWeb.enterprise model=new TTG.Model.TTGWeb.enterprise();
			model.id=id;
			model.county=county;
			model.communty=communty;
			model.name=name;
			model.address=address;
			model.distance_to_community=distance_to_community;
			model.type=type;
			model.main_product=main_product;
			model.area=area;
			model.stuff_amount=stuff_amount;
			model.immigrant_stuff_amount=immigrant_stuff_amount;
			model.lf_average_salary=lf_average_salary;
			model.note_information=note_information;
			model.statistics_date=statistics_date;
			model.check_status=check_status;
			model.lock_tables=lock_tables;
			model.teunset1=teunset1;
			model.teunset2=teunset2;
			model.teunset3=teunset3;
			model.teunset4=teunset4;
			model.teunset5=teunset5;
			model.teunset6=teunset6;
			model.teunset7=teunset7;
			model.teunset8=teunset8;
			model.teunset9=teunset9;
			model.teunset10=teunset10;
			model.teunset11=teunset11;
			model.teunset12=teunset12;

			TTG.BLL.TTGWeb.enterprise bll=new TTG.BLL.TTGWeb.enterprise();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
