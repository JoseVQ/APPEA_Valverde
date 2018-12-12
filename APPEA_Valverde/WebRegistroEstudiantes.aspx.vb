Imports CapaNegocio
Public Class WebRegistroEstudiantes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oEstudiante As New PersonaCN
        Dim ok As Boolean

        ok = oEstudiante.Insertar(New CapaEntidad.Estudiante(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, DropDownList1.SelectedValue))
        MsgBox("Registro Guardado")
        Response.Redirect("WebRegistroEstudiantes.aspx")
    End Sub
End Class