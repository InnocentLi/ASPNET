using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 个性化旅游网站.Background
{
    public partial class NAV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./setProduct.aspx", false);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("./setFT.aspx", false);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("./setUser.aspx", false);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            Response.Redirect("./setMessage.aspx", false);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("./setAdmin.aspx", false);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home.aspx", false);
        }
    }
}