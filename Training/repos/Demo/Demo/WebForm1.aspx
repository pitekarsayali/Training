<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table>

            
        

            
                <asp:TableRow>
                    <asp:TableCell>
                             <asp:Label ID="label1" runat="server">UserName:</asp:Label>
                     </asp:TableCell>

                    <asp:TableCell"> 
                        <asp:TextBox ID="t1" runat="server"></asp:TextBox>
                    </asp:TableCell>

                    <asp:TableCell"> 
                        <asp:Button ID="bt1" runat="server" Text="click" OnClick="Button1_Click" />
                        </asp:TableCell>

                </asp:TableRow>

               
        </asp:Table>
            </div>

        <div>
            <asp:Table>

            
        

            
                <asp:TableRow>
                    <asp:TableCell>
                             <asp:Label ID="label2" runat="server">UserName:</asp:Label>
                     </asp:TableCell>

                    <asp:TableCell"> 
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>

                    <asp:TableCell"> 
                        <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click" />
                        </asp:TableCell>

                </asp:TableRow>

               
        </asp:Table>
            </div>
    </form>
</body>
</html>
