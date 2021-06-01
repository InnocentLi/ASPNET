using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace 个性化旅游网站
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  

        private string sql = null;
        public string strHTML = string.Empty;



        // 数据库打开
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
            cmd = new SqlCommand("select * from userN where class = '2'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()){
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
               

                if ((TextBox1.Text == s1) && (TextBox2.Text == s2))
                {
                    Session["name"] = s1;
                    Response.Redirect("./Home.aspx", false);
                   // conn.Close();
                }
                // Page.ClientScript.RegisterClientScriptBlock(GetType(), "", "<div style='display:inline-block;'><img src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>");
                //Response.Write(s1+s2+s3+s4);
                // strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>";

            } 
                Response.Write("<script>alert('用户名或密码错误');</script>");
                conn.Close();
        }

        // 登录成功
        protected void Button1_Click(object sender, EventArgs e)
        {
            load();
        }


        //注册
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Register.aspx", false);
        }
    }
}