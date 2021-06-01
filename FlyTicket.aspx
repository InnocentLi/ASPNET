<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlyTicket.aspx.cs" Inherits="个性化旅游网站.FlyTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>飞机票购买</title>

      <style>
        .home{
            display: block;
            margin: 0 auto;
            width: 960px;
            height: 100px;
            border: 1px solid black;
            margin-top: 5px;
        }
        .home:hover{
            border: 1px solid green;
            background:black;
            color:white;
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
        a{
            position: relative;
            top: -94px;
            left: 318px;
            text-decoration: none;
            display: block;
            border: 1px solid black;
            width: 66px;
            height: 20px;
            color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <!--  <div class="home" ><div class="child"><h4 class="fromPlace">哈尔滨</h4><img class="to" src="./image/箭头.png" alt=""><img class="fly" src="./image/飞机.png" alt=""><img class="to" src="./image/箭头.png" alt=""><h4 class="toPlace">长沙</h4><h2 class="fromTime">10:00</h2><h2 class="toTime">12:00</h2><h1 class="price">500<span>元</span></h1><a href="">立刻购买</a></div> -->
                          <%=strHTML%>  

    </form>
</body>
</html>
