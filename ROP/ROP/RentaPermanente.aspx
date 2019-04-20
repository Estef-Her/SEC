<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RentaPermanente.aspx.vb" Inherits="ROP.RentaPermanente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="Scripts/jquery.validate.js"></script>
    <script src="validation.js"></script>
    <style type="text/css">
        /*.auto-style3 {
            width: 200px;
        }*/
        .auto-style4 {
            width: 260px;
        }

        #tabla {
            border-width: medium;
            border-color: #14487E;
            width: 650px;
            margin-left: 20px;
        }

        #primeraNota {
            text-align: center;
            font-size: small
        }

        #segundaNota {
            text-align: center;
            font-size: small
        }

        #titulo {
            margin: 50px auto;
            text-align: center;
        }

        #listaAnios {
            margin-right: 8px;
        }

        #botonActualizar {
            color: white;
            background-color: #14487E;
            border-color: #14487E;
        }

        #primerEncabezado {
            background-color: #14487E;
            color: white;
        }

        #segundoEncabezado {
            background-color: #14487E;
            color: white;
        }

        #tercerEncabezado {
            background-color: #14487E;
            color: whitesmoke;
        }

        
    </style>
</head>
<body>
    <div id="menuContent" runat="server">
        <!-- #Include virtual="~/MenuCalculadoras.aspx" -->
    </div>

    <div class="container">
                <div class="info"><h3>Cálculo estimado de la renta permanente de una pensión</h3></div> 
        </div>

    <h1 id="primeraNota">Seleccione el mes y el año desde los cuales desea digitar sus rendimientos y comisiones.</h1>

    <div class="container-all">
        <div class="wrap-form">
            <form id="form1" runat="server" class="table-form register-form" onload="cargaFechasRecientes">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>

                       
                        <div style="text-align: center;">
                            <label>Mes:</label>
                            <asp:DropDownList runat="server" ID="listaMeses">
                                <asp:ListItem Selected="True">Enero</asp:ListItem>
                                <asp:ListItem>Febrero</asp:ListItem>
                                <asp:ListItem>Marzo</asp:ListItem>
                                <asp:ListItem>Abril</asp:ListItem>
                                <asp:ListItem>Mayo</asp:ListItem>
                                <asp:ListItem>Junio</asp:ListItem>
                                <asp:ListItem>Julio</asp:ListItem>
                                <asp:ListItem>Agosto</asp:ListItem>
                                <asp:ListItem>Septiembre</asp:ListItem>
                                <asp:ListItem>Octubre</asp:ListItem>
                                <asp:ListItem>Noviembre</asp:ListItem>
                                <asp:ListItem>Diciembre</asp:ListItem>
                            </asp:DropDownList>
                            <label>Año:</label>
                            <asp:DropDownList runat="server" ID="listaAnios" OnLoad="cargandoAnios"></asp:DropDownList>
                            <asp:Button ID="botonActualizar" runat="server" CausesValidation="false" Text="Actualizar fechas" />
                        </div>

                        <h1 id="segundaNota">Digite los rendimientos y comisiones generados durante las fechas indicadas.</h1>

                        <table class="table table-sm" id="tabla" border="1">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col" id="primerEncabezado">
                                        <center>Fechas</center>
                                    </th>
                                    <th scope="col" id="segundoEncabezado">
                                        <center>Rendimientos</center>
                                    </th>
                                    <th scope="col" id="tercerEncabezado">
                                        <center>Comisiones</center>
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes1" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        <asp:TextBox ID="rendimiento1" runat="server" input type="text" class="rendimiento1 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R1"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="rendimiento1" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision1" runat="server" input type="text" class="comision1 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C1"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="comision1" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes2" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento2" runat="server" input type="text" class="rendimiento2 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R2"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="rendimiento2" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                       
                                        <asp:TextBox ID="comision2" runat="server" input type="text" class="comision2 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C2"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="comision2" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes3" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento3" runat="server" input type="text" class="rendimiento3 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R3"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="rendimiento3" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision3" runat="server" input type="text" class="comision3 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C3"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="comision3" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes4" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento4" runat="server" input type="text" class="rendimiento4 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R4"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="rendimiento4" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision4" runat="server" input type="text" class="comision4 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C4"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="comision4" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes5" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento5" runat="server" input type="text" class="rendimiento5 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R5"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="rendimiento5" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision5" runat="server" input type="text" class="comision5 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C5"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="comision4" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes6" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento6" runat="server" input type="text" class="rendimiento6 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R6"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="rendimiento6" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision6" runat="server" input type="text" class="comision6 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C6"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="comision6" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes7" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento7" runat="server" input type="text" class="rendimiento7 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R7"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="rendimiento7" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision7" runat="server" input type="text" class="comision7 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C7"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="comision7" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes8" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento8" runat="server" input type="text" class="rendimiento8 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R8"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="rendimiento8" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision8" runat="server" input type="text" class="comision8 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C8"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="comision8" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes9" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento9" runat="server" input type="text" class="rendimiento9 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R9"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="rendimiento9" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision9" runat="server" input type="text" class="comision9 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C9"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="comision9" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes10" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento10" runat="server" input type="text" class="rendimiento10 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R10"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="rendimiento10" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision10" runat="server" input type="text" class="comision10 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C10"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="comision10" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes11" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento11" runat="server" input type="text" class="rendimiento11 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R11"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="rendimiento11" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision11" runat="server" input type="text" class="comision11 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C11"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="comision11" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center><asp:Label ID="mes12" runat="server" ForeColor="#000000" Font-Bold="true"></asp:Label></center>
                                    </td>
                                    <td class="auto-style4">
                                        
                                        <asp:TextBox ID="rendimiento12" runat="server" input type="text" class="rendimiento12 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_R12"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="rendimiento12" ErrorMessage="* Digite rendimiento" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="comision12" runat="server" input type="text" class="comision12 form-control" AutoCompleteType="Disabled" AutoPostBack="true" OnTextChanged="Text_Changed_C12"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="comision12" ErrorMessage="* Digite comisión" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>

                            </tbody>

                        </table>


                        <div align="center">
                            <asp:Button ID="botonCalcular" runat="server" Text="Calcular" Width="30%" />
                            <br />
                            <asp:Button ID="botonLimpiar" runat="server" Text="Limpiar datos" Width="30%" CausesValidation="False" />
                            <br />
                            <asp:Button ID="botonDescargar" runat="server" Text="Descargar" Width="30%" CausesValidation="false" />
                            <br />
                            <br />
                            <asp:Label ID="etiquetaLarga" class="text-center" runat="server" Visible="False" Text="El monto mensual estimado de la pensión en esta modalidad, durante el presente año, es de: "></asp:Label>
                            <asp:Label ID="etiquetaCorta" class="text-center" runat="server" Visible="False" ForeColor="#000000" Font-Bold="true"></asp:Label>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </form>
        </div>
    </div>
</body>
</html>
