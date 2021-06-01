using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Ubiety.Dns.Core;


namespace 个性化旅游网站
{
    public partial class ShopListShow : System.Web.UI.Page
    {
        public string strHTML = "用户未登录或无产品购买";
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public string state = string.Empty;
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
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    
            string s1, s2, s3, s4, s5, s6;
            openDatabase();
            cmd = new SqlCommand("select * from userN where username = '"  +Session["name"]  + "'", conn);
            //Response.Write("<script>alert('"+q+"');</script>");
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                state = (String)dr[5].ToString().Trim();
                loadList();
                //strHTML = state;
            }
            conn.Close();
        }
        public void loadList()
        {
            string s1, s2, s3, s4, s5, s6;
            openDatabase();
            cmd = new SqlCommand("select * from product where produceID = '" + state + "'", conn);
            //Response.Write("<script>alert('"+q+"');</script>");
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
              
               strHTML = (String)dr[1].ToString().Trim(); ;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }



    }
}