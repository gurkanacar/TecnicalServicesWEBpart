using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecnicalServicesWEB.Entity;

namespace TecnicalServicesWEB
{
    public partial class Default : System.Web.UI.Page
    {
        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBL_ABOUTUS.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBL_PRODUCTS.ToList();
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_CONNECTTION t = new TBL_CONNECTTION();
            t.NAMESURNAME = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.SUBJECT = TextBox3.Text;
            t.MESSAGE = TextBox4.Text;
            db.TBL_CONNECTTION.Add(t);
            db.SaveChanges();
        }
    }
}