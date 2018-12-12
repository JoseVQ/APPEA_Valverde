Imports CapaNegocio
Public Class WebListadoPersonas_18_2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            mostrar()
        End If


    End Sub

    Sub mostrar()
        Dim oPersona As New PersonaCN
        GridView1.DataSource = oPersona.ListarTodos
        Label2.Text = oPersona.Mayor()
        Label4.Text = oPersona.Menor()
        GridView1.DataBind()
    End Sub
End Class