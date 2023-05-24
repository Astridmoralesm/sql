Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class DCiudades
    Dim strConn As String = My.Settings.StrConnection.ToString()

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "Select id as N'Codigo', nombre as N'Ciudad' from Ciudad"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function


    'Guardando registro'
    Public Function GuardarRegistros(ByVal ciudad As Ciudades) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            Dim tsql = "insert into Ciudad(nombre) values(@nombre)"
            cmd.Parameters.AddWithValue("@nombre", ciudad.Nombre)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Error al intentar guardar los datos",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function


    'Editando registro'
    Public Function EditarRegistro(ByVal ciudad As Ciudades) As Boolean
        Dim flag = False
        Try
            Dim tsql = "UPDATE Ciudad SET nombre = @nombre, estado = @estado where id = @id"
            Dim conn As New SqlConnection(My.Settings.StrConnection)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", ciudad.Nombre)
            cmd.Parameters.AddWithValue("@estado", ciudad.Estado)
            cmd.Parameters.AddWithValue("@id", ciudad.Id)
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                flag = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Error al intentar modificar los datos",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return flag
    End Function


    'Eliminando registro'
    Public Function EliminarRegistro(ByVal id As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "delete from Ciudad where id = @id"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    'Buscando registros'
    Public Function BuscarRegistro(ByVal id As Integer) As Ciudad
        Dim ciudad As New Ciudad
        Try
            Dim tsql As String = "select * from Ciudad where id = @id"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id", id)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                ciudad.id = tbl.Rows(0).Item("id")
                ciudad.nombre = tbl.Rows(0).Item("nombre")
                ciudad.estado = tbl.Rows(0).Item("estado")
            End If
        Catch ex As Exception

        End Try
        Return ciudad
    End Function

    Public Function buscarRegistro(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        nombre = nombre + "%"
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "Select id as N'Codigo', nombre as N'Ciudad' from Ciudad where nombre like @nombre"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
