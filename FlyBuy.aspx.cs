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
    public partial class FlyBuy : System.Web.UI.Page
    {

        public string strHTML = string.Empty;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  
        string q;


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
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    
            string s1, s2, s3, s4, s5, s6, s7;
            string str;
            openDatabase();
            // 查询机票
            cmd = new SqlCommand("SELECT * FROM FlyT where id="+q, conn);
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
                str = "./FlyBuy.aspx?q=" + s1;
                // html 代码片段 拼接
                strHTML = "<div class='home'><div class='child'><h1 class='fromPlace'>" + s2 + "</h1><img class='fly' src='./image/飞机.png' ><h1 class='toPlace'>" + s3 + "</h1><h2 class='fromTime'>" + s5 + "</h2><h2 class='toTime'>" + s6 + "</h2><h1 class='price'>" + s4 + "<span>元</span></h1></div><h1 class='text'>"+ s7 + "</h1></div>";

            }

            // strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>";
            conn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            q = Request.QueryString["q"];
            load();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('预定成功');</script>");
        }
    }
}