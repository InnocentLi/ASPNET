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
    public partial class Message : System.Web.UI.Page
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

        public void load()
        {
            strHTML = "";
             string s1, s2,s3;
            openDatabase();
            cmd = new SqlCommand("select * from message", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
                s3 = (String)dr[2].ToString().Trim();
                strHTML += "<div class='homel'><h1>"+s2+"</h1><p>作者："+s1+"</p>"+s3+"</div>";

            }

            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s1;
            if (Session["name"]!=null)
            {
                s1 = Session["name"].ToString();
            }
            else{
                s1 = "无名氏";
            }
            
            openDatabase();
            cmd = new SqlCommand("INSERT INTO message VALUES ('" + s1 + "', '" + TextBox1.Text + "', '" + TextBox2.Text +"')", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            conn.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            load();
        }
    }
}