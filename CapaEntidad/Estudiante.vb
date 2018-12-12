Public Class Estudiante
    Private _codEstudiante As String
    Public Property codEstudiante() As String
        Get
            Return _codEstudiante
        End Get
        Set(ByVal value As String)
            _codEstudiante = value
        End Set
    End Property
    Private _apellidos As String
    Public Property apellidos() As String
        Get
            Return _apellidos
        End Get
        Set(ByVal value As String)
            _apellidos = value
        End Set
    End Property
    Private _nombres As String
    Public Property nombres() As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property
    Private _direccion As String
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
    Private _codEscuela As String
    Public Property codEscuela() As String
        Get
            Return _codEscuela
        End Get
        Set(ByVal value As String)
            _codEscuela = value
        End Set
    End Property

    Public Sub New(ByVal codEstudiante As String, ByVal apellidos As String, ByVal nombres As String, ByVal direccion As String, ByVal codEscuela As String)
        _codEstudiante = codEstudiante
        _apellidos = apellidos
        _nombres = nombres
        _direccion = direccion
        _codEscuela = codEscuela
    End Sub
End Class
