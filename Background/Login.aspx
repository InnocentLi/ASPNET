<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="个性化旅游网站.Background.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                后台登录
            </h1>
            <p>
               登录: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
             <p>
               密码: <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </p>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登录" />
        <asp:Button ID="Button2" runat="server" Text="反馈" OnClick="Button2_Click" />
    </form>
</body>
</html>
