<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="个性化旅游网站.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>您好，请注册</h1>
            用户名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
            密码:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox> <br />
            性别:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> (1为男性，2为女性)<br />
            qq号:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> <br />
            <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
