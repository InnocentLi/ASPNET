<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingList.aspx.cs" Inherits="个性化旅游网站.ShoppingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .home{
            margin:0 auto;
            width:960px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="home">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/购物车.png" />
              <br />
           <%=strHTML%>
            <br />
            <asp:Button ID="Button1" runat="server" Text="立刻购买" OnClick="Button1_Click1" />
        </div>
    </form>
</body>
</html>
