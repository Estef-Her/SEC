<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 529px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="label1" runat="server" Text="Tasa de Interés: "></asp:Label>
            <asp:DropDownList ID="tasaDeInteres" runat="server">
                <asp:ListItem>1%</asp:ListItem>
                <asp:ListItem>2%</asp:ListItem>
                <asp:ListItem Selected="True">3%</asp:ListItem>
                <asp:ListItem>4%</asp:ListItem>
                <asp:ListItem>5%</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Label ID="label2" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
        <asp:Calendar ID="calendarioFecha" runat="server"></asp:Calendar>
        <p>
            <asp:Label ID="label3" runat="server" Text="Monto de pensión: "></asp:Label>
            <asp:TextBox ID="monto" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="botonLimpiar" runat="server" Text="Limpiar" />
        <asp:Button ID="botonCalcular" runat="server" Text="Calcular" />
    </form>
</body>
</html>
