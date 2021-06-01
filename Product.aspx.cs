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
    public partial class Product : System.Web.UI.Page
    {

        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  

        private string sql = null;
        public string strHTML = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            load(); 
        }

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
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    
            string s1, s2, s3, s4, s5,s6;
            openDatabase();
            cmd = new SqlCommand("select * from product", conn);
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
                strHTML += "<div class='produce' style='display:inline-block;'><img style='width:230px' src=" + s6 + "><h3>" + s2 + "</h3><p>" + s3 + "</p><h5>" + s4 + "星级</h5><a href='./ShoppingList.aspx?q="+s1+"'>详情</a></div>";

            }
      
            conn.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // 触发搜索按钮
        protected void Button1_Click(object sender, EventArgs e)
        {
            openDatabase();
            string s1, s2, s3, s4, s5, s6;
            openDatabase();
            cmd = new SqlCommand("select * from product where produceName like '%"+TextBox1.Text +"%';", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            strHTML = "";
            while (dr.Read())
            {
                s1 = (String)dr[0].ToString().Trim();
                s2 = (String)dr[1].ToString().Trim();
                s3 = (String)dr[2].ToString().Trim();
                s4 = (String)dr[3].ToString().Trim();
                s5 = (String)dr[4].ToString().Trim();
                s6 = (String)dr[5].ToString().Trim();
                // <a href="./ShoppingList.aspx?q=1">购买</a>
                strHTML += "<div style='display:inline-block;'><img style='width:230px' src=" + s6 + "><h3>" + s2 + "</h3><p>" + s3 + "</p><h5>" + s4 + "星级</h5><a href='./ShoppingList.aspx?q=" + s1 + "'>详情</a></div>";

            }

            conn.Close();
        }
    }
}