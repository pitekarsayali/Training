<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomeForm.aspx.cs" Inherits="Regis_Form.WelcomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-control" style="width:500px;height:300px;left:30%;position:absolute; background-color:bisque">
            <h1>WelCome To Yash Technologies</h1>
            <%:Session["name"] %>
        </div>
    </form>
</body>
</html>
