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
    public partial class TravalNote : System.Web.UI.Page
    {

        public string strHTML = string.Empty;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  
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
        // 加载
        public void load()
        {
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    
            string s1, s2, s3, s4, s5, s6;
            openDatabase();
            cmd = new SqlCommand("select * from TravelNote where money='1500RMB'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
                s3 = (String)dr[2].ToString().Trim();
                s4 = (String)dr[3].ToString().Trim();
                s5 = (String)dr[4].ToString().Trim();
                s6 = (String)dr[5].ToString().Trim();
                // <a href="./ShoppingList.aspx?q=1">购买</a>
                strHTML = s6;

            }

            conn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}