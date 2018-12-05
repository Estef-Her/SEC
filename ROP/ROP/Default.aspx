<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="ROP.ROP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="/Content/style.css" rel="stylesheet" /> 
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
<script type="text/javascript" src="Scripts/jquery.validate.js"></script>
    <title></title>
</head>
<body style="height: 364px">
        <form id="form1" runat="server">
        <ul>
          <li><a class="active" href="#home">Inicio</a></li>
        </ul>
    <h1>Cálculo estimado del retiro programado</h1>
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

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div>
                        <p>
                            <asp:Label ID="Label1" runat="server" Text="Fecha de nacimiento:"></asp:Label>
                            <asp:TextBox ID="txtNacim" runat="server" style="margin-left: 15px"></asp:TextBox>
                        </p>
                        <p>
                            <asp:Label ID="Label2" runat="server" Text="Capital de pensión:"></asp:Label>
                            <asp:span class="SimboloColones">₡<asp:TextBox ID="txtCapital" runat="server" style="margin-left: 8px"></asp:TextBox></asp:span>
                        </p>
                        <p>
                            <asp:Label ID="lblTasa" runat="server" Text="Tasa de interés técnica: "></asp:Label>
                            &nbsp;&nbsp;<asp:DropDownList ID="DpDLtasaDeInteres" runat="server">
                                <asp:ListItem>1%</asp:ListItem>
                                <asp:ListItem>2%</asp:ListItem>
                                <asp:ListItem Selected="True">3%</asp:ListItem>
                                <asp:ListItem>4%</asp:ListItem>
                                <asp:ListItem>5%</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblMens" runat="server" Text="La tasa de interés técnica es aprobada por la SUPEN, actualmente está fijada en 3%"></asp:Label>
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
                            <asp:Label ID="Label4" runat="server" Visible="False" Text="El monto de estimado de la pension en la modalidad de retiro programado(ROP) es de:"></asp:Label>
                            <asp:TextBox ID="txtEstimado" runat="server" Visible="false" style="margin-left: 8px"></asp:TextBox>
                        </p>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </form>
</body>
</html>
