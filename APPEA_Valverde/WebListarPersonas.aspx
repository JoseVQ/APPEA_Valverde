<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebListarPersonas.aspx.vb" Inherits="APPEA_Valverde.WebListarPersonas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese DNI :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="txtBuscar" runat="server" Text="Buscar" />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style1">
            <Columns>
                <asp:BoundField DataField="Nombre y Apellido" HeaderText="Nombre Completo" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Edad" HeaderText="Edad" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
