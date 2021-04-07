<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page 1.aspx.cs" Inherits="Partie_5_Exemple_1.Page_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:red;">Page 1</h1>
            <label>Nom</label>
            <asp:TextBox runat="server" ID="Nom"></asp:TextBox>
            <br />
            <label>Prenom</label>
            <asp:TextBox runat="server" ID="Prenom"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="Envoyer" Text="Envoyer" OnClick="Envoyer_Click"/>
        </div>
    </form>
</body>
</html>
