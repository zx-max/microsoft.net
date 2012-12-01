<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs"
    Inherits="CurrencyConverter.CurrencyConverter"  %> 

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency Converter</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p><input type="text" size="20" ID="US" runat="server"/>U.S. dollar to euros</p>
        <p><input type="submit" value="OK" ID="Convert" runat="server" OnServerClick="Convert_ServerClick" /></p>
    </div>
    <p style="font-weight: bold" ID="Result" runat="server"></p>
    </form>
</body>
</html>
