<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="Demo.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Table >

            <asp:TableRow>
                    <asp:TableCell>
                             <asp:Label ID="label1" runat="server">EmployeeName:</asp:Label>
                     </asp:TableCell>

                    <asp:TableCell"> 
                        <asp:TextBox ID="TxtEmpName" runat="server"></asp:TextBox>
                    </asp:TableCell>

            </asp:TableRow>
        </asp:Table>
           </div>

         <div>
            <asp:Table >

            <asp:TableRow>
                    <asp:TableCell>
                             <asp:Label ID="label2" runat="server">Employee Mail:</asp:Label>
                     </asp:TableCell>

                    <asp:TableCell"> 
                        <asp:TextBox ID="TxtEmpMail" runat="server"></asp:TextBox>
                    </asp:TableCell>

            </asp:TableRow>
        </asp:Table>
            </div>

        <div>
            <asp:Table >

            <asp:TableRow>
                    <asp:TableCell>
                             <asp:Label ID="label3" runat="server">Employee Phone:</asp:Label>
                     </asp:TableCell>

                    <asp:TableCell"> 
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>

            </asp:TableRow>
        </asp:Table>
            </div>
        <div>

            <asp:Table >

            <asp:TableRow>
                    <asp:TableCell>
                             <asp:Label ID="label4" runat="server">Employee Relesion:</asp:Label>
                     </asp:TableCell>

                    <asp:TableCell"> 
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </asp:TableCell>

            </asp:TableRow>
        </asp:Table>
            </div>
    </form>
</body>
</html>
