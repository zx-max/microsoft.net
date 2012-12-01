<%@ Page Language="C#" 
CodeBehind="CreatePerson.aspx.cs" 
Inherits="CurrencyConverter.WebForm1" 
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>CRUD</title>
<link type="text/css" href="css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
<script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
<script type="text/javascript" src="js/jquery-ui-1.8.19.custom.min.js"></script>
<script type="text/javascript">
    $(function () {
        $("#txtBirthDate").datepicker();
    });
</script>
<style type="text/css">
.ui-datepicker { font-size:8pt !important}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="text" id="rrr" runat="server"/>
    Nome:<asp:TextBox id="txtName" Width="200" runat="server"/>
    Cognome:<asp:TextBox id="txtSurname" Width="200" runat="server" />
    Data di nascita:<asp:TextBox ID="txtBirthDate" runat="server"/>
    <asp:Button id="btnSave" Text="save" runat="server" OnClick="storePerson" />
    </div>
    <asp:Label ID="lblInfo" runat="server" />
    <asp:GridView ID="GridView1" runat="server" />
</form>
</body>
</html>
