<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Partie_5_Exemple_1.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:blue;">Page 2</h1>
            <asp:Label ID="Message" runat="server"></asp:Label>
            <asp:HyperLink runat="server" NavigateUrl="~/Page 3.aspx">Aller a la Page 3</asp:HyperLink>
        </div>
    </form>
</body>
</html>
