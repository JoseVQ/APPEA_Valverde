Imports CapaDatos
Imports CapaEntidad
Public Class PersonaCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New PersonaCN
    Public Shared ReadOnly Property Instancia() As PersonaCN
        Get
            Return _instancia
        End Get
    End Property

    Public Function ListarTodos() As List(Of Persona)
        Return PersonaDA.Instancia.ListarTodos
    End Function

    Public Function FiltrarXdni(ByVal dni As String) As DataSet
        Return PersonaDA.Instancia.flitrarXdni(dni)
    End Function
End Class
