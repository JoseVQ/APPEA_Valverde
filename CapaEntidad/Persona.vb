Public Class Persona
    Private _dni As String
    Public Property dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property
    Private _apellidoP As String
    Public Property apellidoP() As String
        Get
            Return _apellidoP
        End Get
        Set(ByVal value As String)
            _apellidoP = value
        End Set
    End Property
    Private _apellidoM As String
    Public Property apellidoM() As String
        Get
            Return _apellidoM
        End Get
        Set(ByVal value As String)
            _apellidoM = value
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
    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Private _edad As Integer
    Public Property edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    Public Sub New(ByVal dni As String, ByVal apellidoP As String, ByVal apellidoM As String, ByVal nombres As String, ByVal direccion As String, ByVal email As String, ByVal edad As Integer)
        _dni = dni
        _apellidoP = apellidoP
        _apellidoM = apellidoM
        _nombres = nombres
        _direccion = direccion
        _email = email
        _edad = edad
    End Sub
    Public Sub New(ByVal nombres As String, ByVal direccion As String, ByVal email As String, ByVal edad As Integer)
        _nombres = nombres
        _direccion = direccion
        _email = email
        _edad = edad
    End Sub
End Class
