Public Class FrmCiudad

    Sub LlenarRegistros()
        Dim dCiudad As New DCiudades
        DgvRegistros.DataSource = dCiudad.MostrarRegistros().Tables(0)
        DgvRegistros.Refresh()
        GbRegistro.Text = "Registros almacenados: " &
            DgvRegistros.Rows.Count
    End Sub

    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub


    'Limpiando los campos del formulario'
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtId.Clear()
        TxtNombre.Clear()
        TxtNombre.Focus()
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim ciudad As New Ciudades()
            ciudad.Nombre = TxtNombre.Text.Trim
            Dim dCiudad As New DCiudades
            If (dCiudad.GuardarRegistros(ciudad)) Then
                MsgBox("Registro guardado exitosamente",
                   MsgBoxStyle.Information, "Ciudades")
            End If
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistros()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim ciudad As New Ciudades(CInt(TxtId.Text), TxtNombre.Text, True)
            Dim dao As New DCiudades
            If (dao.EditarRegistro(ciudad)) Then
                MsgBox("Registro editado exitosamente",
                       MsgBoxStyle.Information, "Ciudades")
            End If
        Catch ex As Exception
            MsgBox("No se pudo editar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistros()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim codigo As Integer = TxtId.Text
        Dim dCiudad As New DCiudades()
        Dim ciudad As New Ciudad
        ciudad = dCiudad.BuscarRegistro(codigo)
        If (ciudad.id = 0) Then
            MsgBox("El registro no existe",
                   MsgBoxStyle.Exclamation, "ADVERTENCIA")
            Exit Sub
        End If

        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este registro " & ciudad.id, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "ADVERTENCIA"))
        If (resp = vbNo) Then
            MsgBox("Operacion cancelada",
                       MsgBoxStyle.Information, "Ciudades")
            Exit Sub
        End If

        Dim eliminado = dCiudad.EliminarRegistro(ciudad.id)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente",
                       MsgBoxStyle.Information, "Ciudades")
        Else
            MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        LlenarRegistros()
    End Sub

    'Seleccionando registros de la tabla'
    Private Sub DgvRegistros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRegistros.CellClick
        Dim fila As Integer = DgvRegistros.CurrentRow.Index
        TxtId.Text = DgvRegistros.Rows(fila).Cells(0).Value
        TxtNombre.Text = DgvRegistros.Rows(fila).Cells(1).Value
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim dao As New DCiudades
        DgvRegistros.DataSource = dao.buscarRegistro(TxtBuscar.Text.Trim).Tables(0)
        DgvRegistros.Refresh()
    End Sub
End Class