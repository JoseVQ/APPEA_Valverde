﻿Imports CapaEntidad
Imports System.Data.SqlClient
Public Class PersonaDA
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New PersonaDA
    Public Shared ReadOnly Property Instancia() As PersonaDA
        Get
            Return _instancia
        End Get
    End Property


    Public Function ListarTodos() As List(Of Persona)
        Dim Coleccion As New List(Of Persona)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim sqlcmd As New SqlCommand("pa_persona_listarTodos", cnn)
            sqlcmd.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = sqlcmd.ExecuteReader
            While PaTable.Read
                Coleccion.Add(New Persona(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3), PaTable.Item(4), PaTable.Item(5), PaTable.Item(6)))
            End While
            cnn.Close()
            cnn.Dispose()
            sqlcmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function


    Public Function flitrarXdni(ByVal dni As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("pa_buscar_x_dni", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.Char, 8).Value = dni
            da.Fill(ds, "Personas")
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

    Public Function Mayor() As Integer
        Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
        cnn.Open()
        Dim Sqlcmd As New SqlCommand("pa_mayor", cnn)
        Sqlcmd.CommandType = CommandType.StoredProcedure
        Sqlcmd.Parameters.Add("@numero", SqlDbType.Int)
        Sqlcmd.Parameters("@numero").Direction = ParameterDirection.Output
        Sqlcmd.ExecuteNonQuery()
        Return Sqlcmd.Parameters("@numero").Value
        cnn.Close()
        cnn.Dispose()
        Sqlcmd.Dispose()
    End Function


    Public Function Menor() As Integer
        Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
        cnn.Open()
        Dim Sqlcmd As New SqlCommand("pa_mayor", cnn)
        Sqlcmd.CommandType = CommandType.StoredProcedure
        Sqlcmd.Parameters.Add("@numero", SqlDbType.Int)
        Sqlcmd.Parameters("@numero").Direction = ParameterDirection.Output
        Sqlcmd.ExecuteNonQuery()
        Return Sqlcmd.Parameters("@numero").Value
        cnn.Close()
        cnn.Dispose()
        Sqlcmd.Dispose()
    End Function

    Public Function Agregar(ByVal Estudiante As Estudiante) As Boolean
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim Sqlcmd As New SqlCommand("pa_estudiante_agregar", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@codEstudiante", SqlDbType.VarChar, 40).Value = Estudiante.codEstudiante
            Sqlcmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 40).Value = Estudiante.apellidos
            Sqlcmd.Parameters.Add("@nombres", SqlDbType.VarChar, 40).Value = Estudiante.nombres
            Sqlcmd.Parameters.Add("@direccion", SqlDbType.VarChar, 40).Value = Estudiante.direccion
            Sqlcmd.Parameters.Add("@codEscuela", SqlDbType.Int).Value = Estudiante.codEscuela
            Sqlcmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
End Class
