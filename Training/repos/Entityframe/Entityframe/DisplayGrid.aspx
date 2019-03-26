<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayGrid.aspx.cs" Inherits="Entityframe.DisplayGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None" Height="279px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="508px">  
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>  
                        <asp:BoundField DataField="id" HeaderText="ID" />
                        <asp:BoundField DataField="name" HeaderText="Name" />  
                        <asp:BoundField DataField="salary" HeaderText="Salary" />
                        <asp:TemplateField HeaderText="Option">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnDelete" runat="server"  OnClick="btnDelete_Click" OnClientClick ="return confirm('Are you sure?');">Delete</asp:LinkButton>
                            | <a href="Update.aspx?Id=<%# Eval("Id") %>">Edit</a>
                           <asp:HiddenField ID="hdfId" runat="server" Value ='<%# Eval("Id") %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>

                        
                      

                    </Columns>  

                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>  
        </div>
       
    </form>
</body>
</html>
