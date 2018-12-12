Imports CapaNegocio
Public Class WebListarPersonas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        Dim ds As DataSet
        Dim dni As String
        dni = TextBox1.Text
        ds = PersonaCN.Instancia.FiltrarXdni(dni)
        GridView1.DataSource = PersonaCN.Instancia.FiltrarXdni(dni)
        GridView1.DataBind()
    End Sub
End Class