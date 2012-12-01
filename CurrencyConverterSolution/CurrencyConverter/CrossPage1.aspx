<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrossPage1.aspx.cs" Inherits="CurrencyConverter.CrossPage1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>CrossPage1</title>
</head>
<body>
    <form id="form1" runat="server">
<div>
First Name:
<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
<br />
Last Name:
<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button runat="server" ID="cmdPost" PostBackUrl="CrossPage2.aspx"  Text="Cross-Page Postback" /><br />
</div>
    </form>
</body>
</html>
