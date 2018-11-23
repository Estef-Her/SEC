<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="ROP.ROP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
<script type="text/javascript" src="Scripts/jquery.validate.js"></script>
    <title></title>
</head>
<body style="height: 364px">
    <script type="text/javascript">
       $(document).ready(function () {
       $("#form1").validate({
           rules: {
               'txtCapital': { required: true, number: true, minlength: 1 },
               'txtNacim': { required : true , number :true , minlength: 4, maxlength:4}
           },
           messages: {
               'txtCapital': {
                   required:  'Debe digitar un monto',
                   number: 'Debe ingresar datos numericos'
               },
               'txtNacim': {
                   required:  'Debe digitar un monto',
                   number: 'Debe ingresar datos numericos'
               }
           },
 
          
       });
   });
    </script>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Año de Nacimiento:"></asp:Label>
            <asp:TextBox ID="txtNacim" runat="server" style="margin-left: 15px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Capital de Pensión:"></asp:Label>
            <asp:TextBox ID="txtCapital" runat="server" style="margin-left: 8px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblTasa" runat="server" Text="Tasa de Interés: "></asp:Label>
            <asp:DropDownList ID="DpDLtasaDeInteres" runat="server">
                <asp:ListItem>1%</asp:ListItem>
                <asp:ListItem>2%</asp:ListItem>
                <asp:ListItem Selected="True">3%</asp:ListItem>
                <asp:ListItem>4%</asp:ListItem>
                <asp:ListItem>5%</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMens" runat="server" Text="La tasa del 3% es la aprobada normativamente "></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Sexo:"></asp:Label>
        <asp:RadioButtonList ID="radioListSexo" runat="server">
            <asp:ListItem Value="1">Masculino</asp:ListItem>
            <asp:ListItem Value="2">Femenino</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" />
            <asp:Button ID="btnConsultar" runat="server" Text="Calcular" />
        </p>
        <p style="margin-left: 200px">
            <asp:Label ID="Label4" runat="server" Text="El monto estimado es:"></asp:Label>
            <asp:TextBox ID="txtEstimado" runat="server" style="margin-left: 8px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
