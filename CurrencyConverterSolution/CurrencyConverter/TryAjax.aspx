<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryAjax.aspx.cs" Inherits="CurrencyConverter.TryAjax" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>try Asp.AJAX</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        <div style="background-color:Lime; padding:20px;">
        <asp:Label ID="lblTime1" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:Button ID="cmdRefreshTime" runat="server" OnClick="cmdRefreshTime_Click" Text="Refresh Time" />
        </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
        <ContentTemplate>
        <div style="background-color:Lime; padding:20px;">
        <asp:Label ID="lblTime2" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="cmdRefreshTime_Click" Text="Refresh Time" />
        </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Always">        
        <ContentTemplate>
        <div style="background-color:Lime; padding:20px;">
        <asp:Label ID="lblTime3" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="cmdRefreshTime_Click" Text="Refresh Time" />
        </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
