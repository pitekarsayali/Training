<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="Entityframe.AddEmployee" %>

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
                    <td>
                        <asp:Button ID="btnAddEmployee" runat="server" OnClick="btnAddEmployee_Click" Text="Add Employee" />
                    </td>
                </tr>
                  <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnupdateEmployee" runat="server" OnClick="btnUpdateEmployee_Click" Text="Update" />
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>

        
             <div>
                    <div>
            
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Id" />
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="salary" HeaderText="Salary" />
                    <asp:TemplateField HeaderText="Option">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnDelete" runat="server"  OnClick="btnDelete_Click" OnClientClick ="return confirm('Are you sure?');">Delete</asp:LinkButton>
                            | <a href="update.aspx?Id=<%# Eval("Id") %>">Edit</a>
                          <asp:HiddenField ID="hdfId" runat="server" Value ='<%# Eval("Id") %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>

        </div>
        </div>
    </form>
</body>
</html>
