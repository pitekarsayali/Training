<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudOP.aspx.cs" Inherits="Crud_Operation.CrudOP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="ShowTable" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Insert" OnClick="Button2_Click"  />
            <asp:Button ID="Button3" runat="server" Text="update" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="DELETE" OnClick="Button4_Click" />
            </div>

        <div>
            

            </div>
    </form>
</body>
</html>
