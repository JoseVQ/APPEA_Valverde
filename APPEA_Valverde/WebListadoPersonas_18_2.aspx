<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebListadoPersonas_18_2.aspx.vb" Inherits="APPEA_Valverde.WebListadoPersonas_18_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style1">
            <Columns>
                <asp:BoundField DataField="dni" HeaderText="Dni" />
                <asp:BoundField DataField="nombres" HeaderText="Nombre" />
                <asp:BoundField DataField="apellidoP" HeaderText="Apellido Paterno" />
                <asp:BoundField DataField="apellidoM" HeaderText="Apellidos Materno" />
                <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="edad" HeaderText="Edad" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Personas Mayor de 18 Años : "></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Personas Menor de 18 Años : "></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
