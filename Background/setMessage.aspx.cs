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
    public partial class setMessage : System.Web.UI.Page
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  

        private string sql = null;
        public string strHTML = string.Empty;
        public string strHTML2 = string.Empty;

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
        public void load()
        {

            string str, s1, s2, s3;
            openDatabase();
            strHTML = "";
            cmd = new SqlCommand("select * FROM message", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
                s3 = (String)dr[2].ToString().Trim();
         
                strHTML += "<div><p style='color:red'>用户名" + s1 + "</p><p>标题" + s2 + "</p><p>留言内容:" + s3 + "</p></div>";
                //Response.Write("<script>alert('删除成功');</script>");
            }


            conn.Close();
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            openDatabase();

            cmd = new SqlCommand("DELETE FROM message WHERE title = '" + TextBox1.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Write("<script>alert('删除成功');</script>");
            }
            conn.Close();

            load();
        }
    }
}