using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Ubiety.Dns.Core;


namespace 个性化旅游网站.Background
{
    public partial class setUser : System.Web.UI.Page
    {
        public string strHTML = string.Empty;
        public string strHTML2 = string.Empty;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;

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

        // 加载所有用户
        public void load()
        {

            string str, s1, s2, s3, s4, s5,s6;
            openDatabase();
            strHTML = "";
            cmd = new SqlCommand("select * FROM userN", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
                s3 = (String)dr[2].ToString().Trim();
                s4 = (String)dr[3].ToString().Trim();
                s5 = (String)dr[4].ToString().Trim();
                s6 = (String)dr[5].ToString().Trim();
                strHTML += "<tr><th>" + s1 + "</th><th>" + s2 + "</th><th>" + s3 + "</th><th>" + s4 + "</th><th>" + s5 + "</th><th>" + s6 + "</th></tr>";
                //Response.Write("<script>alert('删除成功');</script>");
            }


            conn.Close();
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }


        //删除用户
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            openDatabase();

            cmd = new SqlCommand("DELETE FROM userN WHERE username = '" + TextBox1.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Write("<script>alert('删除成功');</script>");
            }
            conn.Close();

            load();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            strHTML2 = TextBox3.Text.Length.ToString();
        }




        public bool load2()
        {
            // s1 name   s2 password   s3 qq      s4 sex      s5 class
            string s1;
            openDatabase();
            cmd = new SqlCommand("select username from userN", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                if (TextBox2.Text == s1)
                {

                    return false;
                }
            }
            conn.Close();
            openDatabase();
            cmd = new SqlCommand("INSERT INTO userN VALUES ('" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text +"')", conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            conn.Close();
            return true;
        }


        //增加
        protected void Button2_Click(object sender, EventArgs e)
        {
      

            //判断是否用户名重复
            if (TextBox5.Text != "1" && TextBox5.Text != "2")
            {
                Response.Write("<script>alert('格式有问题请检查');</script>");
            }
            else
            {
                if (load2())
                {
                    load();
                    Response.Write("<script>alert('成功');</script>");
                }
                else
                {
                    Response.Write("<script>alert('注册失败,请检查是否用户名重复');</script>");
                }
            }



        }


    }
}