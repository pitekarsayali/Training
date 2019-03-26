<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudOp2.aspx.cs" Inherits="Crud_Operation.CrudOp2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
        
        <div style="padding-top:20px">
            
            <asp:Label ID="EmpId" runat="server" Text="EmpId"></asp:Label><asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="176px"></asp:TextBox>
            
        </div>

         <div style="padding-top:20px">
            
            <asp:Label ID="EmpName" runat="server" Text="EmpName"></asp:Label><asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="176px"></asp:TextBox>
            
        </div>
        <div style="padding-top:20px">
            
            <asp:Label ID="salary" runat="server" Text="Salary"></asp:Label><asp:TextBox ID="TextBox3" runat="server" Height="22px" Width="176px"></asp:TextBox>
            
        </div>
         <div style="padding-top:20px">
            
            <asp:Label ID="Hike" runat="server" Text="Hike"></asp:Label><asp:TextBox ID="TextBox4" runat="server" Height="22px" Width="176px"></asp:TextBox>
            
             
            
        </div>
        <div style="padding-top:20px">
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Show table" OnClick="Show_Click" />
            <asp:Button ID="Button3" runat="server" Text="Update table" OnClick="Update_Click" />
            <asp:Button ID="Button4" runat="server" Text="delete table" OnClick="Delete_Click" />

            </div>
        <div style="padding-top:20px">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
        <div style="padding-top:30px">
        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Height="203px" Width="394px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
            </div>
    </form>
</body>
</html>
