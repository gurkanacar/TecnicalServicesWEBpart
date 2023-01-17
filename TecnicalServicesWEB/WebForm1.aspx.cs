using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecnicalServicesWEB.Entity;

namespace TecnicalServicesWEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var degerler = db.TBL_PRODUCTFOLLOWING.ToList();
            //Repeater1.DataSource = degerler;
            //Repeater1.DataBind();

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            var degerler = db.TBL_PRODUCTFOLLOWING.Where(x => x.SERIALNO == TextBox1.Text);
            Repeater1.DataSource = degerler.ToList();
            Repeater1.DataBind();

        }
    }
}