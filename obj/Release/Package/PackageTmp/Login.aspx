<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="个性化旅游网站.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>您好，请登录</h1>
            用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  <br />
            密码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
