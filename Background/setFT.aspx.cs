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
    public partial class setFT : System.Web.UI.Page
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
              
            string s1, s2, s3, s4, s5, s6,s7;
            openDatabase();
            cmd = new SqlCommand("select * from FlyT", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
                s3 = (String)dr[2].ToString().Trim();
                s4 = (String)dr[3].ToString().Trim();
                s5 = (String)dr[4].ToString().Trim();
                s6 = (String)dr[5].ToString().Trim();
                s7 = (String)dr[6].ToString().Trim();
                // <a href="./ShoppingList.aspx?q=1">购买</a>
                strHTML += s1+"--"+s2+"--"+s3+"--"+s4+"--"+s5+"--"+s6+"--"+s7+"<br/>";

            }

            conn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            strHTML = "";
            openDatabase();
            cmd = new SqlCommand("INSERT INTO FlyT VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')", conn);
            SqlDataReader dr = cmd.ExecuteReader();
              // dr = cmd.ExecuteReader();
            dr.Read();
            conn.Close();
            load();
          

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("./NAV.aspx", false);
        }

   


        //删除
        protected void Button3_Click(object sender, EventArgs e)
        {
            openDatabase();

            cmd = new SqlCommand("DELETE FROM FlyT WHERE ID = '" + TextBox8.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Write("<script>alert('删除成功');</script>");
            }
            conn.Close();
            strHTML = "";
            load();
        }
    }
}