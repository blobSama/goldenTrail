<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="flightCalculator.aspx.cs" Inherits="WebApplication3.flightCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div">
            <asp:Label ID="hLbl" runat="server" Text="Enter initial height: " AssociatedControlID="height"></asp:Label>
            <asp:TextBox ID="height" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="distAns" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="sLbl" runat="server" Text="Enter initial speed: " AssociatedControlID="speed"></asp:Label>
            <asp:TextBox ID="speed" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="sAns" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="dLbl" runat="server" Text="Enter degree: " AssociatedControlID="degree"></asp:Label>
            <asp:TextBox ID="degree" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="degAns" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
