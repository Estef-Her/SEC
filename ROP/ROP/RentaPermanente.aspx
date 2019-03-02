<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="ROP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/estilo2.css" rel="stylesheet" />
</head>
<body>
    <div ID="menuContent" runat="server">
        <!-- #Include virtual="/MenuCalculadoras.aspx" -->
    </div>
    <div class="container-all">
        <div class="wrap-form">
            <form id="form1" runat="server" class="table-form">
                <span class="form-title">Calculadora de Renta Permanente</span>
                        <table class="table table-sm ">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col">Meses</th>
                                    <th scope="col">Rentas</th>
                                    <th scope="col">Comisiones</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Mes 1</td>
                                    <td> 
                                        <asp:TextBox ID="renta1" runat="server" input type="text" class="form-control"  AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision1" runat="server" input type="text" class="form-control"  AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td>Mes 2</td>
                                    <td> 
                                        <asp:TextBox ID="renta2" runat="server" input type="text" class="form-control"  AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision2" runat="server" input type="text" class="form-control"  AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 3</td>
                                    <td> 
                                        <asp:TextBox ID="renta3" runat="server" input type="text" class="form-control"  AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision3" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 4</td>
                                    <td> 
                                        <asp:TextBox ID="renta4" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision4" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 5</td>
                                    <td> 
                                        <asp:TextBox ID="renta5" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision5" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 6</td>
                                    <td> 
                                        <asp:TextBox ID="renta6" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision6" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 7</td>
                                    <td> 
                                        <asp:TextBox ID="renta7" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision7" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 8</td>
                                    <td> 
                                        <asp:TextBox ID="renta8" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision8" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 9</td>
                                    <td> 
                                        <asp:TextBox ID="renta9" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision9" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>

                                <tr>
                                    <td>Mes 10</td>
                                    <td> 
                                        <asp:TextBox ID="renta10" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision10" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 11</td>
                                    <td> 
                                        <asp:TextBox ID="renta11" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision11" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mes 12</td>
                                    <td> 
                                        <asp:TextBox ID="renta12" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="comision12" runat="server" input type="text" class="form-control" AutoCompleteType="Disabled"></asp:TextBox>
                                    </td>
                                </tr>

                            </tbody>

                        </table>
                <asp:Button ID="botonCalcular" runat="server" Text="Calcular" />
                <asp:Button ID="botonLimpiar" runat="server" Text="Limpiar datos" CausesValidation="False" />
            </form>
        </div>
    </div>  
</body>
</html>