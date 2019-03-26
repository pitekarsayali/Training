<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegForm.aspx.cs" Inherits="AspAssig2.RegForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position:relative;">
        <div class="form-control" style="width:500px;height:300px;left:30%;position:absolute;">
                 <div>
                        <asp:Label runat="server" ID="lblUname">Employee Name:</asp:Label>
                   
                        <asp:TextBox ID="txtEmpName" runat="server" MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="rg1" runat="server"  ControlToValidate="txtEmpName" ForeColor="HotPink" ErrorMessage="Requird" ></asp:RequiredFieldValidator>
                     <asp:CustomValidator ID="custom1" runat="server" ErrorMessage="maximum length should be 20" ></asp:CustomValidator>
              
                  </div>

                <div>
                        <asp:Label runat="server">Email:</asp:Label>
               
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ControlToValidate="txtemail" ForeColor="HotPink" ErrorMessage="Requird" ></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rege1" runat="server" ControlToValidate="txtemail"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Invalid Mail Id"></asp:RegularExpressionValidator>
                 </div>

            <div>
                        <asp:Label runat="server">Phone:</asp:Label>
               
                        <asp:TextBox ID="txtboxPhone"  runat="server" MaxLength="10" ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ControlToValidate="txtboxPhone" ForeColor="HotPink" ErrorMessage="Requird" ></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="r1" runat="server"  MinimumValue="0" MaximumValue="9" ControlToValidate="txtboxPhone" ErrorMessage="Only 10 digits" ></asp:RangeValidator>
                 </div>

               <div>
                        <asp:Label runat="server" >State:</asp:Label>                    
                        <asp:DropDownList ID="state" runat="server" OnSelectedIndexChanged="state_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  ControlToValidate="state" ErrorMessage="Requird" ></asp:RequiredFieldValidator>
               </div>  

               <div>
                        <asp:Label runat="server">City:</asp:Label>
                  
                        <asp:DropDownList ID="dropdwn" runat="server" OnSelectedIndexChanged="dropdwn_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
              </div>

                
              <div>
                        <asp:Label runat="server">Religion:</asp:Label>
                   
                 <asp:RadioButton ID="RadioButton1" Text="Hindu" runat="server" name="rd2" GroupName="Test1" Checked="true"/>                   
                 <asp:RadioButton ID="RadioButton2" Text="Muslim" runat="server" name="rd2" GroupName="Test1"/>
                  

               </div>

            <div>             
                        <asp:Label runat="server">Gender:</asp:Label>                   
                       <asp:RadioButton ID="rdmale" Text="Male" runat="server" name="rd2" GroupName="Test2"/>                   
                       <asp:RadioButton ID="rdfemale" Text="Female" runat="server" name="rd2" GroupName="Test2" Checked="true"/>
                 </div>

                 <div>
                        <asp:Label runat="server">Skills:</asp:Label>                 
                      <asp:CheckBox ID="cs" Text="C#" runat="server" Checked="true" />                   
                      <asp:CheckBox ID="java" Text="JAVA" runat="server" />
            </div>

             <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1"/>

            <div>
                        <asp:Label runat="server" ID="Label1">Employee Name:</asp:Label>
                   
                        <asp:TextBox ID="loginuser" runat="server" MaxLength="20"></asp:TextBox>
                </div>

             <div>
                        <asp:Label runat="server" ID="Label2">password:</asp:Label>
                   
                        <asp:TextBox ID="txtpass" runat="server" MaxLength="20"></asp:TextBox>
                </div>
            
               <div>
                                          
                        
                 <asp:GridView ID="GridView1" runat="server">
                 </asp:GridView>
              </div>
            <div>
                        <asp:Label runat="server" ID="Labelmsg"></asp:Label>

                </div>
            <div style="text-emphasis-color:blueviolet">
                        <asp:Label runat="server" ID="Label3" ></asp:Label>
                </div>
           
           
        </div>

           </div>
        

        
    </form>
</body>
</html>
