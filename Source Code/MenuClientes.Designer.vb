<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BuscarPorCorreoBoton = New System.Windows.Forms.Button()
        Me.BuscarPorTelefonoBoton = New System.Windows.Forms.Button()
        Me.BuscarPorNombreBoton = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BuscarCorreo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BuscarTelefono = New System.Windows.Forms.TextBox()
        Me.BuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ModifPorID = New System.Windows.Forms.Button()
        Me.NuevoCorreo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NuevoTelefono = New System.Windows.Forms.TextBox()
        Me.NuevoNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ModifID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EliminarXID = New System.Windows.Forms.Button()
        Me.EliminarClienteID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VolverMenuPrincipal = New System.Windows.Forms.Button()
        Me.CrearCliente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CorreoCliente = New System.Windows.Forms.TextBox()
        Me.NombreCliente = New System.Windows.Forms.TextBox()
        Me.TelefonoCliente = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ModificarClienteRecienCreadoButon = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Correo = New System.Windows.Forms.TextBox()
        Me.label555 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.EliminarLogeado = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.ListarTodo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BuscarPorCorreoBoton
        '
        Me.BuscarPorCorreoBoton.Location = New System.Drawing.Point(302, 123)
        Me.BuscarPorCorreoBoton.Name = "BuscarPorCorreoBoton"
        Me.BuscarPorCorreoBoton.Size = New System.Drawing.Size(118, 20)
        Me.BuscarPorCorreoBoton.TabIndex = 87
        Me.BuscarPorCorreoBoton.Text = "Buscar Por Correo"
        Me.BuscarPorCorreoBoton.UseVisualStyleBackColor = True
        '
        'BuscarPorTelefonoBoton
        '
        Me.BuscarPorTelefonoBoton.Location = New System.Drawing.Point(302, 93)
        Me.BuscarPorTelefonoBoton.Name = "BuscarPorTelefonoBoton"
        Me.BuscarPorTelefonoBoton.Size = New System.Drawing.Size(118, 20)
        Me.BuscarPorTelefonoBoton.TabIndex = 86
        Me.BuscarPorTelefonoBoton.Text = "Buscar Por Telefono"
        Me.BuscarPorTelefonoBoton.UseVisualStyleBackColor = True
        '
        'BuscarPorNombreBoton
        '
        Me.BuscarPorNombreBoton.Location = New System.Drawing.Point(302, 64)
        Me.BuscarPorNombreBoton.Name = "BuscarPorNombreBoton"
        Me.BuscarPorNombreBoton.Size = New System.Drawing.Size(118, 20)
        Me.BuscarPorNombreBoton.TabIndex = 85
        Me.BuscarPorNombreBoton.Text = "Buscar por Nombre"
        Me.BuscarPorNombreBoton.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(155, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 13)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "BUSCAR CLIENTES"
        '
        'BuscarCorreo
        '
        Me.BuscarCorreo.Location = New System.Drawing.Point(158, 123)
        Me.BuscarCorreo.Name = "BuscarCorreo"
        Me.BuscarCorreo.Size = New System.Drawing.Size(100, 20)
        Me.BuscarCorreo.TabIndex = 83
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Buscar Por Correo"
        '
        'BuscarTelefono
        '
        Me.BuscarTelefono.Location = New System.Drawing.Point(158, 93)
        Me.BuscarTelefono.Name = "BuscarTelefono"
        Me.BuscarTelefono.Size = New System.Drawing.Size(100, 20)
        Me.BuscarTelefono.TabIndex = 81
        '
        'BuscarNombre
        '
        Me.BuscarNombre.Location = New System.Drawing.Point(158, 64)
        Me.BuscarNombre.Name = "BuscarNombre"
        Me.BuscarNombre.Size = New System.Drawing.Size(100, 20)
        Me.BuscarNombre.TabIndex = 80
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Buscar por Telefono"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Buscar por Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(446, 360)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 283)
        Me.DataGridView1.TabIndex = 77
        '
        'ModifPorID
        '
        Me.ModifPorID.Location = New System.Drawing.Point(313, 154)
        Me.ModifPorID.Name = "ModifPorID"
        Me.ModifPorID.Size = New System.Drawing.Size(179, 20)
        Me.ModifPorID.TabIndex = 75
        Me.ModifPorID.Text = "Modificar "
        Me.ModifPorID.UseVisualStyleBackColor = True
        '
        'NuevoCorreo
        '
        Me.NuevoCorreo.Location = New System.Drawing.Point(194, 234)
        Me.NuevoCorreo.Name = "NuevoCorreo"
        Me.NuevoCorreo.Size = New System.Drawing.Size(100, 20)
        Me.NuevoCorreo.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Nuevo Correo:"
        '
        'NuevoTelefono
        '
        Me.NuevoTelefono.Location = New System.Drawing.Point(195, 207)
        Me.NuevoTelefono.Name = "NuevoTelefono"
        Me.NuevoTelefono.Size = New System.Drawing.Size(100, 20)
        Me.NuevoTelefono.TabIndex = 72
        '
        'NuevoNombre
        '
        Me.NuevoNombre.Location = New System.Drawing.Point(195, 181)
        Me.NuevoNombre.Name = "NuevoNombre"
        Me.NuevoNombre.Size = New System.Drawing.Size(100, 20)
        Me.NuevoNombre.TabIndex = 71
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Nuevo Telefono:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Nuevo Nombre:"
        '
        'ModifID
        '
        Me.ModifID.Location = New System.Drawing.Point(195, 154)
        Me.ModifID.Name = "ModifID"
        Me.ModifID.Size = New System.Drawing.Size(100, 20)
        Me.ModifID.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "ID del Cliente a Modificar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "MODIFICAR CLIENTE"
        '
        'EliminarXID
        '
        Me.EliminarXID.Location = New System.Drawing.Point(313, 57)
        Me.EliminarXID.Name = "EliminarXID"
        Me.EliminarXID.Size = New System.Drawing.Size(179, 23)
        Me.EliminarXID.TabIndex = 62
        Me.EliminarXID.Text = "Eliminar ID"
        Me.EliminarXID.UseVisualStyleBackColor = True
        '
        'EliminarClienteID
        '
        Me.EliminarClienteID.Location = New System.Drawing.Point(96, 54)
        Me.EliminarClienteID.Name = "EliminarClienteID"
        Me.EliminarClienteID.Size = New System.Drawing.Size(100, 20)
        Me.EliminarClienteID.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Por ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "BAJA CLIENTE"
        '
        'VolverMenuPrincipal
        '
        Me.VolverMenuPrincipal.Location = New System.Drawing.Point(14, 7)
        Me.VolverMenuPrincipal.Name = "VolverMenuPrincipal"
        Me.VolverMenuPrincipal.Size = New System.Drawing.Size(145, 23)
        Me.VolverMenuPrincipal.TabIndex = 56
        Me.VolverMenuPrincipal.Text = "Volver a Menu Principal"
        Me.VolverMenuPrincipal.UseVisualStyleBackColor = True
        '
        'CrearCliente
        '
        Me.CrearCliente.Location = New System.Drawing.Point(185, 155)
        Me.CrearCliente.Name = "CrearCliente"
        Me.CrearCliente.Size = New System.Drawing.Size(100, 27)
        Me.CrearCliente.TabIndex = 55
        Me.CrearCliente.Text = "Crear Cliente"
        Me.CrearCliente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Correo Del Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Telefono Del Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nombre De Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 14)
        Me.Label1.MaximumSize = New System.Drawing.Size(200, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "ALTA CLIENTE"
        '
        'CorreoCliente
        '
        Me.CorreoCliente.Location = New System.Drawing.Point(185, 119)
        Me.CorreoCliente.Name = "CorreoCliente"
        Me.CorreoCliente.Size = New System.Drawing.Size(100, 20)
        Me.CorreoCliente.TabIndex = 50
        '
        'NombreCliente
        '
        Me.NombreCliente.Location = New System.Drawing.Point(185, 45)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.NombreCliente.TabIndex = 49
        '
        'TelefonoCliente
        '
        Me.TelefonoCliente.Location = New System.Drawing.Point(185, 82)
        Me.TelefonoCliente.Name = "TelefonoCliente"
        Me.TelefonoCliente.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoCliente.TabIndex = 48
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(340, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 89
        '
        'ModificarClienteRecienCreadoButon
        '
        Me.ModificarClienteRecienCreadoButon.Location = New System.Drawing.Point(313, 181)
        Me.ModificarClienteRecienCreadoButon.Name = "ModificarClienteRecienCreadoButon"
        Me.ModificarClienteRecienCreadoButon.Size = New System.Drawing.Size(179, 20)
        Me.ModificarClienteRecienCreadoButon.TabIndex = 90
        Me.ModificarClienteRecienCreadoButon.Text = "Modificar Cliente Recien logeado"
        Me.ModificarClienteRecienCreadoButon.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(953, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Cliente Recien Logueado"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(930, 38)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Size = New System.Drawing.Size(65, 20)
        Me.Nombre.TabIndex = 92
        '
        'Telefono
        '
        Me.Telefono.Location = New System.Drawing.Point(1086, 38)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Size = New System.Drawing.Size(89, 20)
        Me.Telefono.TabIndex = 93
        '
        'Correo
        '
        Me.Correo.Location = New System.Drawing.Point(1086, 64)
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.Size = New System.Drawing.Size(89, 20)
        Me.Correo.TabIndex = 94
        '
        'label555
        '
        Me.label555.AutoSize = True
        Me.label555.Location = New System.Drawing.Point(877, 38)
        Me.label555.Name = "label555"
        Me.label555.Size = New System.Drawing.Size(47, 13)
        Me.label555.TabIndex = 95
        Me.label555.Text = "Nombre:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1028, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 96
        Me.Label19.Text = "Telefono:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1031, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 13)
        Me.Label20.TabIndex = 97
        Me.Label20.Text = "Correo:"
        '
        'EliminarLogeado
        '
        Me.EliminarLogeado.Location = New System.Drawing.Point(313, 85)
        Me.EliminarLogeado.Name = "EliminarLogeado"
        Me.EliminarLogeado.Size = New System.Drawing.Size(179, 23)
        Me.EliminarLogeado.TabIndex = 98
        Me.EliminarLogeado.Text = "Eliminar Logueado"
        Me.EliminarLogeado.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(877, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = "ID:"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(930, 67)
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(65, 20)
        Me.ID.TabIndex = 100
        '
        'ListarTodo
        '
        Me.ListarTodo.Location = New System.Drawing.Point(302, 198)
        Me.ListarTodo.Name = "ListarTodo"
        Me.ListarTodo.Size = New System.Drawing.Size(122, 46)
        Me.ListarTodo.TabIndex = 101
        Me.ListarTodo.Text = "Listar Todo"
        Me.ListarTodo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EliminarLogeado)
        Me.GroupBox1.Controls.Add(Me.ModificarClienteRecienCreadoButon)
        Me.GroupBox1.Controls.Add(Me.ModifPorID)
        Me.GroupBox1.Controls.Add(Me.NuevoCorreo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.NuevoTelefono)
        Me.GroupBox1.Controls.Add(Me.NuevoNombre)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ModifID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.EliminarXID)
        Me.GroupBox1.Controls.Add(Me.EliminarClienteID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(357, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 298)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Baja De Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CrearCliente)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CorreoCliente)
        Me.GroupBox2.Controls.Add(Me.NombreCliente)
        Me.GroupBox2.Controls.Add(Me.TelefonoCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 201)
        Me.GroupBox2.TabIndex = 103
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alta De Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.ListarTodo)
        Me.GroupBox3.Controls.Add(Me.BuscarPorCorreoBoton)
        Me.GroupBox3.Controls.Add(Me.BuscarPorTelefonoBoton)
        Me.GroupBox3.Controls.Add(Me.BuscarPorNombreBoton)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.BuscarCorreo)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.BuscarTelefono)
        Me.GroupBox3.Controls.Add(Me.BuscarNombre)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 353)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(433, 257)
        Me.GroupBox3.TabIndex = 104
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Busqueda"
        '
        'MenuClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1206, 651)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.label555)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.VolverMenuPrincipal)
        Me.Name = "MenuClientes"
        Me.Text = "MenuClientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuscarPorCorreoBoton As Button
    Friend WithEvents BuscarPorTelefonoBoton As Button
    Friend WithEvents BuscarPorNombreBoton As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents BuscarCorreo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BuscarTelefono As TextBox
    Friend WithEvents BuscarNombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ModifPorID As Button
    Friend WithEvents NuevoCorreo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents NuevoTelefono As TextBox
    Friend WithEvents NuevoNombre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ModifID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents EliminarXID As Button
    Friend WithEvents EliminarClienteID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents VolverMenuPrincipal As Button
    Friend WithEvents CrearCliente As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents CorreoCliente As TextBox
    Friend WithEvents NombreCliente As TextBox
    Friend WithEvents TelefonoCliente As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ModificarClienteRecienCreadoButon As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Telefono As TextBox
    Friend WithEvents Correo As TextBox
    Friend WithEvents label555 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents EliminarLogeado As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents ListarTodo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
