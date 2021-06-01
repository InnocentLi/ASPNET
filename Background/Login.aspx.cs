
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
    public partial class Login : System.Web.UI.Page
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  

        private string sql = null;
        public string strHTML = string.Empty;




        public void openDatabase()
        {
            conn = new SqlConnection();

            // conn.ConnectionString = " Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=individualTravel;Data Source=DESKTOP-E55IERD";
            conn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=individualTravel;Data Source=LAPTOP-FCKARF0O";

            if (conn.State == ConnectionState.Closed)
            {
          
                conn.Open();
                //Response.Write("<script>alert('连接成功');</script>");  
            }

        }


        public void load()
        {
            // s1 name   s2 password   s3 qq      s4 sex      s5 class
            string s1, s2, s3, s4, s5;
            openDatabase();
            cmd = new SqlCommand("select * from userN where class = '1'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
                s3 = (String)dr[2].ToString().Trim();
                s4 = (String)dr[3].ToString().Trim();
                s5 = (String)dr[4].ToString().Trim();

               if((TextBox1.Text == s1) && (TextBox2.Text==s2))
                {
                    Response.Redirect("./NAV.aspx", false);
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误');</script>"); 
                }

                // Page.ClientScript.RegisterClientScriptBlock(GetType(), "", "<div style='display:inline-block;'><img src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>");
                //Response.Write(s1+s2+s3+s4);
                // strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>";

            }
            conn.Close();

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //登录
        protected void Button1_Click(object sender, EventArgs e)
        {
            load();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Respond.aspx", false);
        }
    }
}