<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebListadoEstudiantes.aspx.vb" Inherits="APPEA_Valverde.WebListadoEstudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="Descripcion" DataValueField="CodEscuela">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDEA_ValverdeConnectionString %>" SelectCommand="SELECT [CodEscuela], [Descripcion] FROM [ESCUELA]"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" Text="Listar" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="CodEscuela" HeaderText="CodEscuela" SortExpression="CodEscuela" />
                    <asp:BoundField DataField="Nombres" HeaderText="Nombres" SortExpression="Nombres" />
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDEA_ValverdeConnectionString %>" SelectCommand="SeleccionarDescripcion" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="codEscuela" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
