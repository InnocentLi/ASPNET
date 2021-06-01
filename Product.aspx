<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="个性化旅游网站.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>个性化旅游网站</title>
    <style>
        .home{
            margin:0 auto;
            width:960px;
        }
       .produce{
           margin-left:3px;
           border:1px solid black;
           margin-top:2px;

       }
       .produce:hover{
           background-color:orange;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/旅游产品介绍.png" />
            <div class="home">
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" /><br />
                 <%=strHTML%>  
            </div>
        </div>  
    </form>
</body>
</html>
