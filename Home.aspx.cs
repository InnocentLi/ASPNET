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
    public partial class Home : System.Web.UI.Page
    {
        public string strHTML = string.Empty;
        public string strHTML2 = string.Empty;
        public string strHTML3 = string.Empty;
        public string strHTML4 = string.Empty;

        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;  
        private string sql = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                strHTML = "未登录，请先登录";
            }
            else
            {
                strHTML = "欢迎您"+Session["name"];
            }

            load();
            load2();
            load3();
        }

        // 数据库打开
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

        // 加载个性化

        public void load()
        {
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    
            string s1, s2, s3, s4, s5,s6;
            openDatabase();
            // 排序
            cmd = new SqlCommand("SELECT * FROM product ORDER BY price", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            s1 = (String)dr[0].ToString().Trim();
            s2 = (String)dr[1].ToString().Trim();
            s3 = (String)dr[2].ToString().Trim();
            s4 = (String)dr[3].ToString().Trim();
            s5 = (String)dr[4].ToString().Trim();
            s6 = (String)dr[5].ToString().Trim();
            // html 代码片段 拼接
            strHTML2 = "<div style='display:inline-block;'><img style='width:230px' src=" + s6 + "><h3>" + s2 + "</h3><p>" + s3 + "</p><h5>" + s4 + "星级</h5><a href='./ShoppingList.aspx?q=" + s1 + "'>详情</a></div>";

            // strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>";
            conn.Close();
        }

        public void load2()
        {
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    
            string s1, s2, s3, s4, s5, s6;
            openDatabase();
            cmd = new SqlCommand("SELECT * FROM product ORDER BY star DESC", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            s1 = (String)dr[0].ToString().Trim();
            s2 = (String)dr[1].ToString().Trim();
            s3 = (String)dr[2].ToString().Trim();
            s4 = (String)dr[3].ToString().Trim();
            s5 = (String)dr[4].ToString().Trim();
            s6 = (String)dr[5].ToString().Trim();
            strHTML3 = "<div style='display:inline-block;'><img style='width:230px' src=" + s6 + "><h3>" + s2 + "</h3><p>" + s3 + "</p><h5>" + s4 + "星级</h5><a href='./ShoppingList.aspx?q=" + s1 + "'>详情</a></div>";

            // strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>";
            conn.Close();
        }

        public void load3()
        {
            // s1 id   s2 name   s3 price      s4 star      s5 details s6 img    
            string s1, s2, s3, s4, s5, s6;
            openDatabase();
            cmd = new SqlCommand("SELECT * FROM product ORDER BY sales DESC", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            s1 = (String)dr[0].ToString().Trim();
            s2 = (String)dr[1].ToString().Trim();
            s3 = (String)dr[2].ToString().Trim();
            s4 = (String)dr[3].ToString().Trim();
            s5 = (String)dr[4].ToString().Trim();
            s6 = (String)dr[5].ToString().Trim();
            strHTML4 = "<div style='display:inline-block;'><img style='width:230px' src=" + s6 + "><h3>" + s2 + "</h3><p>" + s3 + "</p><h5>" + s4 + "星级</h5><a href='./ShoppingList.aspx?q=" + s1 + "'>详情</a></div>";

            // strHTML = "<div style='display:inline-block;'><img style='width:230px' src=" + s4 + "><h3>" + s6 + "</h3><p>" + s7 + "</p><h5>" + s2 + "</h5></div>";
            conn.Close();
        }

        // 首页
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx", false);
        }

        // 旅游产品
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Product.aspx", false);
        }

        // 购物车
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("./ShopListShow.aspx", false);
        }

        //新冠疫情
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("./COVID.aspx", false);
        }

        //登录
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Login.aspx", false);
        }

        //注册
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Register.aspx", false);
        }


        // 管理员登录
        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Background/Login.aspx", false);
        }

        //机票购买
        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("./FlyTicket.aspx", false);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("./TravalNote.aspx", false);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Message.aspx", false);
        }
    }
}