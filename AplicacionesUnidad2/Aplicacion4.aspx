<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aplicacion4.aspx.cs" Inherits="AplicacionesUnidad2.Aplicacion4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 91px;
        }
        .auto-style3 {
            width: 152px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;<br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">id_producto:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtidproducto" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">descripcion:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">cantidad:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" Width="142px" />
                    </td>
                    <td>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
