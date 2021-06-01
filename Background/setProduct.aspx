<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="setProduct.aspx.cs" Inherits="个性化旅游网站.Background.setProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>产品增加</h2>
             ID设置;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
             项目名称:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
             价格设置:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> <br />
             星级:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> <br />
             产品详情:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox> <br />
             图片URL:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> <br />
            <asp:Button ID="Button2" runat="server" Text="增加" OnClick="Button2_Click" />
            <h2>产品删除</h2>
            输入产品id;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox> <br />
            <asp:Button ID="Button1" runat="server" Text="删除" OnClick="Button1_Click" /><br />

        </div>
    </form>
</body>
</html>
