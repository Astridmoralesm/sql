Public Class FrmPersona

    Dim dciudad As New DCiudades

    Private Sub FrmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCiudades()
    End Sub

    Sub llenarCiudades()
        Dim ds As New DataSet
        ds = dciudad.MostrarRegistros
        CbxCiudad.DataSource = ds.Tables(0)
        CbxCiudad.DisplayMember = "Ciudad"
        CbxCiudad.ValueMember = "Codigo"
    End Sub

End Class