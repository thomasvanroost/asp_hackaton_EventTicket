<%@ Page Language="C#" AutoEventWireup="true" CodeFile="servertest.aspx.cs" Inherits="servertest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <% Response.Write(DateTime.Now); %>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
