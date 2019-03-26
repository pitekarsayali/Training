<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Entityframe.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:Label runat="server" ID="lblResult" CssClass="red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" style="margin-left: 0px"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style2">Salary:</td>
                    <td>
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
                                  
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
