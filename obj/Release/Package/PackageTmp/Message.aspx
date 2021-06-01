<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="个性化旅游网站.Message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
            .homel{
            width:960px;
            margin:0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <h1>欢迎留言</h1>
              <%=strHTML%>    
        </div>
        <br/>
        <div class="homel">
        请输入标题 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br/>
         请输入内容<asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox> <br/>
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
            </div>
    </form>
</body>
</html>
