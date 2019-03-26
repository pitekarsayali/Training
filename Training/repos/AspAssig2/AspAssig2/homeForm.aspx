<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeForm.aspx.cs" Inherits="AspAssig2.homeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="MyStyle.css" rel="stylesheet" /> 

</head>
<body>
    <div>
    <ul>
  <li><a class="active" href="#home">Home</a></li>
  <li><a href="#news">News</a></li>
  <li><a href="#contact">Contact</a></li>
  <li><a href="#about">About</a></li>
        
    </ul>
        </div>
    <form id="form1" runat="server">
        <div style="text-align:center;padding:20px">
           
          <asp:GridView ID="GridView1" runat="server" Height="239px" Width="448px">
        </asp:GridView>              


        </div>

        <div>
            <asp:Button ID="Button1" runat="server" Text="Edit" Width="96px" />
            <asp:Button ID="Button2" runat="server" Text="Delete" Width="96px" />
            <asp:Button ID="Button3" runat="server" Text="Select" Width="124px" />
        </div>

        <div>
       </div>

        <div>
        </div>
    </form>
</body>
</html>
