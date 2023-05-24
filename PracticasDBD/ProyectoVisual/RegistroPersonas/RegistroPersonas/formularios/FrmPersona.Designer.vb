<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersona
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdPersonaLabel As System.Windows.Forms.Label
        Dim PrimerNombreLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.DsBDPrueba26 = New RegistroPersonas.DsBDPrueba26()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonaTableAdapter = New RegistroPersonas.DsBDPrueba26TableAdapters.PersonaTableAdapter()
        Me.TableAdapterManager = New RegistroPersonas.DsBDPrueba26TableAdapters.TableAdapterManager()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.TxtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.TxtPrimerApellidi = New System.Windows.Forms.TextBox()
        Me.TxtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.DtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.CbxSexo = New System.Windows.Forms.ComboBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.CbxCiudad = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        IdPersonaLabel = New System.Windows.Forms.Label()
        PrimerNombreLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.DsBDPrueba26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdPersonaLabel
        '
        IdPersonaLabel.AutoSize = True
        IdPersonaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPersonaLabel.Location = New System.Drawing.Point(23, 57)
        IdPersonaLabel.Name = "IdPersonaLabel"
        IdPersonaLabel.Size = New System.Drawing.Size(84, 16)
        IdPersonaLabel.TabIndex = 1
        IdPersonaLabel.Text = "Identificador:"
        '
        'PrimerNombreLabel
        '
        PrimerNombreLabel.AutoSize = True
        PrimerNombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrimerNombreLabel.Location = New System.Drawing.Point(40, 102)
        PrimerNombreLabel.Name = "PrimerNombreLabel"
        PrimerNombreLabel.Size = New System.Drawing.Size(67, 16)
        PrimerNombreLabel.TabIndex = 3
        PrimerNombreLabel.Text = "Nombres:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(116, 125)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 12)
        Label1.TabIndex = 9
        Label1.Text = "Primer"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(248, 125)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 12)
        Label2.TabIndex = 10
        Label2.Text = "Segundo"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(383, 103)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(68, 16)
        Label3.TabIndex = 6
        Label3.Text = "Apellidos:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(459, 126)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(38, 12)
        Label4.TabIndex = 3
        Label4.Text = "Primer"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(592, 126)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(48, 12)
        Label5.TabIndex = 3
        Label5.Text = "Segundo"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(28, 154)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(79, 16)
        Label6.TabIndex = 3
        Label6.Text = "Nacimiento:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(409, 154)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(42, 16)
        Label7.TabIndex = 3
        Label7.Text = "Sexo:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(42, 204)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(65, 16)
        Label8.TabIndex = 3
        Label8.Text = "Telefono:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(399, 205)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(52, 16)
        Label9.TabIndex = 3
        Label9.Text = "Correo:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(39, 250)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(68, 16)
        Label10.TabIndex = 3
        Label10.Text = "Direccion:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(397, 250)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(54, 16)
        Label11.TabIndex = 3
        Label11.Text = "Ciudad:"
        '
        'DsBDPrueba26
        '
        Me.DsBDPrueba26.DataSetName = "DsBDPrueba26"
        Me.DsBDPrueba26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.DsBDPrueba26
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CiudadTableAdapter = Nothing
        Me.TableAdapterManager.PersonaTableAdapter = Me.PersonaTableAdapter
        Me.TableAdapterManager.UpdateOrder = RegistroPersonas.DsBDPrueba26TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TxtId
        '
        Me.TxtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "idPersona", True))
        Me.TxtId.Location = New System.Drawing.Point(118, 56)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 2
        '
        'TxtPrimerNombre
        '
        Me.TxtPrimerNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerNombre", True))
        Me.TxtPrimerNombre.Location = New System.Drawing.Point(118, 102)
        Me.TxtPrimerNombre.Name = "TxtPrimerNombre"
        Me.TxtPrimerNombre.Size = New System.Drawing.Size(117, 20)
        Me.TxtPrimerNombre.TabIndex = 4
        '
        'TxtSegundoNombre
        '
        Me.TxtSegundoNombre.Location = New System.Drawing.Point(250, 102)
        Me.TxtSegundoNombre.Name = "TxtSegundoNombre"
        Me.TxtSegundoNombre.Size = New System.Drawing.Size(117, 20)
        Me.TxtSegundoNombre.TabIndex = 5
        '
        'TxtPrimerApellidi
        '
        Me.TxtPrimerApellidi.Location = New System.Drawing.Point(461, 102)
        Me.TxtPrimerApellidi.Name = "TxtPrimerApellidi"
        Me.TxtPrimerApellidi.Size = New System.Drawing.Size(117, 20)
        Me.TxtPrimerApellidi.TabIndex = 7
        '
        'TxtSegundoApellido
        '
        Me.TxtSegundoApellido.Location = New System.Drawing.Point(594, 102)
        Me.TxtSegundoApellido.Name = "TxtSegundoApellido"
        Me.TxtSegundoApellido.Size = New System.Drawing.Size(117, 20)
        Me.TxtSegundoApellido.TabIndex = 8
        '
        'DtpNacimiento
        '
        Me.DtpNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PersonaBindingSource, "fechaNac", True))
        Me.DtpNacimiento.Location = New System.Drawing.Point(118, 154)
        Me.DtpNacimiento.Name = "DtpNacimiento"
        Me.DtpNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.DtpNacimiento.TabIndex = 15
        '
        'CbxSexo
        '
        Me.CbxSexo.FormattingEnabled = True
        Me.CbxSexo.Location = New System.Drawing.Point(461, 153)
        Me.CbxSexo.Name = "CbxSexo"
        Me.CbxSexo.Size = New System.Drawing.Size(121, 21)
        Me.CbxSexo.TabIndex = 16
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(118, 204)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TxtTelefono.TabIndex = 4
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(461, 204)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(200, 20)
        Me.TxtCorreo.TabIndex = 4
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(118, 250)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(249, 62)
        Me.TxtDireccion.TabIndex = 4
        '
        'CbxCiudad
        '
        Me.CbxCiudad.FormattingEnabled = True
        Me.CbxCiudad.Location = New System.Drawing.Point(461, 249)
        Me.CbxCiudad.Name = "CbxCiudad"
        Me.CbxCiudad.Size = New System.Drawing.Size(121, 21)
        Me.CbxCiudad.TabIndex = 16
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnGuardar, Me.BtnEditar, Me.BtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNuevo.Image = Global.RegistroPersonas.My.Resources.Resources.newButton24px
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(24, 24)
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnGuardar.Image = Global.RegistroPersonas.My.Resources.Resources.saveButton
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(24, 24)
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.RegistroPersonas.My.Resources.Resources.editButton
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(24, 24)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminar.Image = Global.RegistroPersonas.My.Resources.Resources.cleanButton
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(24, 24)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'FrmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CbxCiudad)
        Me.Controls.Add(Me.CbxSexo)
        Me.Controls.Add(Me.DtpNacimiento)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(PrimerNombreLabel)
        Me.Controls.Add(Me.TxtSegundoApellido)
        Me.Controls.Add(Me.TxtSegundoNombre)
        Me.Controls.Add(Me.TxtPrimerApellidi)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtPrimerNombre)
        Me.Controls.Add(IdPersonaLabel)
        Me.Controls.Add(Me.TxtId)
        Me.Name = "FrmPersona"
        Me.Text = "FrmPersona"
        CType(Me.DsBDPrueba26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsBDPrueba26 As DsBDPrueba26
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As DsBDPrueba26TableAdapters.PersonaTableAdapter
    Friend WithEvents TableAdapterManager As DsBDPrueba26TableAdapters.TableAdapterManager
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtPrimerNombre As TextBox
    Friend WithEvents TxtSegundoNombre As TextBox
    Friend WithEvents TxtPrimerApellidi As TextBox
    Friend WithEvents TxtSegundoApellido As TextBox
    Friend WithEvents DtpNacimiento As DateTimePicker
    Friend WithEvents CbxSexo As ComboBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents CbxCiudad As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
End Class
