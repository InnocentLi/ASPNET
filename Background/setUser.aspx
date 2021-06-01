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
            <table border="1">
                    <tr>
      <th>username</th>
      <th>password</th>
      <th>qq</th>
      <th>性别</th>
      <th>权限</th>
     <th>产品购买编号</th>
    </tr> 
             <h1>用户展示</h1>
             <%=strHTML %>
                </table>
            <h1>用户删除设置</h1>
            输入id:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="删除" OnClick="Button1_Click" />
            <h1>用户增加</h1>
            用户名<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
            密码<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox><%=strHTML2%> <br />
            QQ<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> <br />
            性别<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox> <br />
            权限<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> <br />
            <asp:Button ID="Button2" runat="server" Text="增加" OnClick="Button2_Click" /> 
        </div>
    </form>
</body>
</html>
