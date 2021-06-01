<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NAV.aspx.cs" Inherits="个性化旅游网站.Background.NAV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>管理员导航</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>欢迎进入后台管理系统</h1>
            <asp:Button ID="Button2" runat="server" Text="产品设置" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="飞机票设置" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="新冠疫情设置" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="用户设置" OnClick="Button5_Click" />

        </div>
    </form>
</body>
</html>
