<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="setFT.aspx.cs" Inherits="个性化旅游网站.Background.setFT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>设置机票</h1>


        </div>
        <h3>显示机票</h3>
        <%=strHTML %>
        <h3>增加机票</h3>
        ID<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
        出发地<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        到达地<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        价格<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        出发时间<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        结束时间<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
        持续时间<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="增加" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="回到导航" />

         <h3>删除机票</h3>
        请输入ID<asp:TextBox ID="TextBox8" runat="server" ></asp:TextBox> <br />
       
        <asp:Button ID="Button3" runat="server" Text="删除" OnClick="Button3_Click" />

    </form>
</body>
</html>
