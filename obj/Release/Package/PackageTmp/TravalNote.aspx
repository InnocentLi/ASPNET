<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TravalNote.aspx.cs" Inherits="个性化旅游网站.TravalNote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>旅游游记</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/旅游游记.png" />
            <%=strHTML %>
        </div>
    </form>
</body>
</html>
