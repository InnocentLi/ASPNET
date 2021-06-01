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
    public partial class Register : System.Web.UI.Page
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  

        private string sql = null;
        public string strHTML = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void openDatabase()
        {
            conn = new SqlConnection();
            // 
            // conn.ConnectionString = " Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=individualTravel;Data Source=DESKTOP-E55IERD";
            conn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=individualTravel;Data Source=LAPTOP-FCKARF0O";

            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();
                //Response.Write("<script>alert('连接成功');</script>");  
            }

        }

        // 加载
        public bool load()
        {
            // s1 name   s2 password   s3 qq      s4 sex      s5 class
            string s1;
            openDatabase();
            cmd = new SqlCommand("select username from userN", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                if (TextBox1.Text == s1)
                {
                   
                    return false;
                }
            }
            conn.Close();
            openDatabase();
            cmd = new SqlCommand("INSERT INTO userN VALUES ('"+TextBox1.Text+"', '"+ TextBox2.Text + "', '"+TextBox4.Text+"', '"+TextBox3.Text+"', '2')", conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            conn.Close();
            return true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox3.Text!="1"&&TextBox3.Text!="2")
            {
                Response.Write("<script>alert('格式有问题请检查');</script>");
            }
            else
            {
                if (load())
                {
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