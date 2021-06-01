<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="个性化旅游网站.Home" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>首页</title>
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>
        .homer{
            margin:0 auto;
            width:960px;  
        }
    </style>

     </head>
    
    
    <body><form id="form1" runat="server">
        <div>
             <div class="homer">
             <p><asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" />

                 <!-- Raser -->
                  <%=strHTML%>  

                 <span style="position:absolute;right:0">
                        <asp:Button ID="Button8" runat="server" Text="管理员登录" OnClick="Button8_Click"  />
                 </span>,
            </p>
           
            <div style="text-align: center;">
                 <asp:Image ID="Image1" runat="server" ImageUrl="~/image/首页展示.png" />
            </div>

            <p> 
                <asp:Button ID="Button3" runat="server" Text="首页" OnClick="Button3_Click" />
                 <asp:Button ID="Button4" runat="server" Text="旅游产品" OnClick="Button4_Click" />
                 <asp:Button ID="Button5" runat="server" Text="购物车" OnClick="Button5_Click" />
                 <asp:Button ID="Button6" runat="server" Text="机票购买" OnClick="Button6_Click" />
                 <asp:Button ID="Button7" runat="server" Text="新冠疫情" OnClick="Button7_Click" />
                
                <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="旅行游记" />
                <asp:Button ID="Button10" runat="server" Text="留言板" OnClick="Button10_Click" />
                
            </p>
           
            <!-- Razor -->
            <h1>最具性价比产品</h1>
             <%=strHTML2%> 
            <h1>最高星级旅游产品</h1>
            <%=strHTML3%> 
            <h1>最多人气</h1>
            <%=strHTML4%> 
                </div>
        </div>    
    </form>
</body>
</html>
