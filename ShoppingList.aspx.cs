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
    public partial class ShoppingList : System.Web.UI.Page
    {
        public string strHTML = string.Empty;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  
        string q;
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
            cmd = new SqlCommand("select * from product where produceID = '"+q+"'", conn);
            //Response.Write("<script>alert('"+q+"');</script>");
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
                s3 = (String)dr[2].ToString().Trim();
                s4 = (String)dr[3].ToString().Trim();
                s5 = (String)dr[4].ToString().Trim();
                s6 = (String)dr[5].ToString().Trim();

                strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s6 + "><h3>" + s2 + "</h3><p>" + s3 + "</p><h5>" + s4 + "星级</h5><p>" + s5 + "</p></div>";

                // strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>";
                
            }
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            q = Request.QueryString["q"];
            load();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Write("<script>alert('请先登录');</script>");
            }
            else
            {
                joinShopList();
                Response.Write("<script>alert('预定成功');</script>");
                
            }
            //Response.Write("<script>alert('" + q + "');</script>");
        }

        public void joinShopList()
        {
            
            openDatabase();
            // UPDATE userN SET class = 'Request.QueryString["q"]' WHERE userN = 'Session["name"]' 
            cmd = new SqlCommand("UPDATE userN SET shoplist = '"+Request.QueryString["q"]+"' WHERE username = '"+Session["name"]+"'", conn);
            //Response.Write("<script>alert('"+q+"');</script>");
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            conn.Close();
        }
    }
}