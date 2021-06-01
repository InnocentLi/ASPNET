<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="setAdmin.aspx.cs" Inherits="个性化旅游网站.Background.setAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>管理员<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="回到导航" />
            </h1>
            修改密码<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="修改密码" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
