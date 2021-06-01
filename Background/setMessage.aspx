<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="setMessage.aspx.cs" Inherits="个性化旅游网站.Background.setMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>留言管理</h1>
             <%=strHTML %>
            <h1>删除内容</h1>
           输入标题: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
            <asp:Button ID="Button1" runat="server" Text="删除" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
