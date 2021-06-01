<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlyBuy.aspx.cs" Inherits="个性化旅游网站.FlyBuy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>结算</title>

      <style>
        .home{
             display: block;
             margin: 0 auto;
             width: 960px;
             height: 100px;
             margin-top: 5px;
         }
         .child{
             margin-left: 300px;
         }
         /* .image{
             width: 960px;
         } */
         .to{
             width: 50px;
         }
         .fly{
             width: 50px;
         }
         .fromPlace{
             position: relative;
             display: inline;
             top: -20px;
         }
         .toPlace{
             position: relative;
             display: inline;
             top: -20px;
             left: 0px;
         }
 
         .fromTime{
             position: relative;
             display: inline;
             top: 17px;
             left: -251px;
         }
         .toTime{
             position: relative;
             display: inline;
             top: 17px;
             left: -109px;
         }
         .price{
             position: relative;
             top: -78px;
             left: 316px;
         }
         button{
             
    position: relative;
    top: -143px;
    left: 289px;
    border-radius: 3px;
    width: 100px;
    height: 40px;
    font-size: 25px;

         }  
         .long {
               position: relative;
                top: -21px;
                font-size: 39px;
                left: 650px;
         }   
         .text{
            position: relative;
            top: -67px;
            font-size: 39px;
            left: 252px;
         }
     </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%=strHTML %>
        </div>
        <asp:Button ID="Button1" CssClass="long" runat="server" Text="立刻预定" OnClick="Button1_Click" />
    </form>
</body>
</html>
