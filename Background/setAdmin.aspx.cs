using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace 个性化旅游网站.Background
{
    public partial class setAdmin : System.Web.UI.Page
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  

        private string sql = null;
        public string strHTML = string.Empty;
        public void openDatabase()
        {
            conn = new SqlConnection();

            //conn.ConnectionString = " Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=individualTravel;Data Source=DESKTOP-E55IERD";
            conn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=individualTravel;Data Source=LAPTOP-FCKARF0O";

            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();
                //Response.Write("<script>alert('连接成功');</script>");  
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            openDatabase();
           
                 
            cmd = new SqlCommand("UPDATE userN SET password = '"+TextBox1.Text+"' WHERE class = '1'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Write("<script>alert('修改成功');</script>");
            }
            Response.Write("<script>alert('修改成功');</script>");
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./NAV.aspx", false);
        }
    }
}