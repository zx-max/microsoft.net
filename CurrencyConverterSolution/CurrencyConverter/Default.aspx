<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CurrencyConverter.Default" %>

<!DOCTYPE html PUBLIC>

<html>
<head runat="server">
    <title>Welcome to you, who wish to learn c#</title>
    
    <%--http://encosia.com/using-jquery-to-directly-call-aspnet-ajax-page-methods/--%>
    <script type="text/javascript" src="js/jquery-1.6.2.min.js"></script>
    <script type="text/javascript">
          $(document).ready(function () {
              // Add the page method call as an onclick handler for the div.
              $("#Result").click(function () {
                  console.log("hello world"); 
                  $.ajax({
                      type: "POST",
                      url: "Default.aspx/HelloWorld",
                      data: "{}",
                      contentType: "application/json; charset=utf-8",
                      dataType: "json",
                      success: function (msg) {
                          // Replace the div's content with the page method's return.
                          $("#Result").text(msg.d);
                      }
                  });
              });
          });
      </script>
</head>
<body>
    <div><a href="CurrencyConverter.aspx">CurrencyConverter</a>
    <a href="CreatePerson.aspx">Crea una Persona</a></div>
    <div id="Result">Click here for the time.</div>
</body>
</html>