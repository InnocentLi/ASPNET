<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="setUser.aspx.cs" Inherits="个性化旅游网站.Background.setUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>用户删除设置</h1>
            输入id:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="删除" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
