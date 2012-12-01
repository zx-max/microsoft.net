<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleCounter.aspx.cs" Inherits="CurrencyConverter.SimpleCounter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnincrement" OnClick="cmdIncrement_Click"  runat = "server" />
    <asp:Label ID="lblCount" runat="server" />
    </div>
    </form>
</body>
</html>
