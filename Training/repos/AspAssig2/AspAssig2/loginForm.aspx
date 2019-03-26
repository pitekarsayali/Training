<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginForm.aspx.cs" Inherits="AspAssig2.loginForm" %>

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
        <div style="padding-top:20px">
                <div class="form-control" style="width:400px;height:300px;left:40%;position:absolute;border:solid;background-color:cadetblue;padding-top:50px">
                 <div>
                     
                      <div style="font-size:30px;text-align:center;padding-top:10px">
                        <asp:Label runat="server">Login Form:</asp:Label>
                          </div>
                      <div style="padding:10px;font-size:20px">
                        <asp:Label runat="server">User Name:</asp:Label>
                   
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                  </div>
                <div style="padding:10px;font-size:20px">
                        <asp:Label runat="server">User Password:</asp:Label>
               
                        <asp:TextBox ID="txtUserPassword" runat="server" TextMode="Password"></asp:TextBox>
                        
                 </div>


                      <div style="text-align:center;padding:10px;font-size:20px;width:20px;height:10px;right:70%">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" Width="90px" Height="40px" BackColor="WindowFrame"  />
                          </div>


                      <div style="font-size:20px;text-align:center;padding-top:30px">
                        <asp:Label runat="server" ID="errLabel"></asp:Label>
                          </div>

                     <div style="text-align:center;padding:20px">
           
          <asp:GridView ID="GridView2" runat="server" Height="239px" Width="448px">
        </asp:GridView>   
                         
                         <asp:GridView ID="gd" runat="server"></asp:GridView>

        </div>

                      <div style="padding:10px;font-size:20px">
                        <asp:Label runat="server" ID="label1"></asp:Label></div>
            </div>
        </div>
            </div>
       
    </form>
</body>
</html>
