<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuDeAdministracionDeVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuDeAdministracionDeVentas))
        Me.VolverMenuPrincipal = New System.Windows.Forms.Button()
        Me.ListarTodo = New System.Windows.Forms.Button()
        Me.BuscarPorTotalBoton = New System.Windows.Forms.Button()
        Me.BuscarPorFechaBoton = New System.Windows.Forms.Button()
        Me.BuscarPorIDClienteBoton = New System.Windows.Forms.Button()
        Me.BuscarTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BuscarFecha = New System.Windows.Forms.TextBox()
        Me.BuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuscarPorIDBoton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDVentaABuscar = New System.Windows.Forms.TextBox()
        Me.IDVentaAEliminar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DisplayNuevoTotal = New System.Windows.Forms.TextBox()
        Me.modificar = New System.Windows.Forms.Button()
        Me.IDVentaAmodificar = New System.Windows.Forms.TextBox()
        Me.ConfirmarVerificacion = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'VolverMenuPrincipal
        '
        Me.VolverMenuPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.VolverMenuPrincipal.Name = "VolverMenuPrincipal"
        Me.VolverMenuPrincipal.Size = New System.Drawing.Size(145, 23)
        Me.VolverMenuPrincipal.TabIndex = 58
        Me.VolverMenuPrincipal.Text = "Volver a Menu Principal"
        Me.VolverMenuPrincipal.UseVisualStyleBackColor = True
        '
        'ListarTodo
        '
        Me.ListarTodo.Location = New System.Drawing.Point(294, 188)
        Me.ListarTodo.Name = "ListarTodo"
        Me.ListarTodo.Size = New System.Drawing.Size(131, 59)
        Me.ListarTodo.TabIndex = 69
        Me.ListarTodo.Text = "Listar Todas Las Ventas"
        Me.ListarTodo.UseVisualStyleBackColor = True
        '
        'BuscarPorTotalBoton
        '
        Me.BuscarPorTotalBoton.Location = New System.Drawing.Point(294, 108)
        Me.BuscarPorTotalBoton.Name = "BuscarPorTotalBoton"
        Me.BuscarPorTotalBoton.Size = New System.Drawing.Size(131, 20)
        Me.BuscarPorTotalBoton.TabIndex = 68
        Me.BuscarPorTotalBoton.Text = "Buscar Por Total"
        Me.BuscarPorTotalBoton.UseVisualStyleBackColor = True
        '
        'BuscarPorFechaBoton
        '
        Me.BuscarPorFechaBoton.Location = New System.Drawing.Point(294, 78)
        Me.BuscarPorFechaBoton.Name = "BuscarPorFechaBoton"
        Me.BuscarPorFechaBoton.Size = New System.Drawing.Size(131, 20)
        Me.BuscarPorFechaBoton.TabIndex = 67
        Me.BuscarPorFechaBoton.Text = "Buscar Por Fecha"
        Me.BuscarPorFechaBoton.UseVisualStyleBackColor = True
        '
        'BuscarPorIDClienteBoton
        '
        Me.BuscarPorIDClienteBoton.Location = New System.Drawing.Point(294, 49)
        Me.BuscarPorIDClienteBoton.Name = "BuscarPorIDClienteBoton"
        Me.BuscarPorIDClienteBoton.Size = New System.Drawing.Size(131, 20)
        Me.BuscarPorIDClienteBoton.TabIndex = 66
        Me.BuscarPorIDClienteBoton.Text = "Buscar por IDCliente"
        Me.BuscarPorIDClienteBoton.UseVisualStyleBackColor = True
        '
        'BuscarTotal
        '
        Me.BuscarTotal.Location = New System.Drawing.Point(150, 108)
        Me.BuscarTotal.Name = "BuscarTotal"
        Me.BuscarTotal.Size = New System.Drawing.Size(100, 20)
        Me.BuscarTotal.TabIndex = 64
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(2, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Buscar Por Total"
        '
        'BuscarFecha
        '
        Me.BuscarFecha.Location = New System.Drawing.Point(150, 78)
        Me.BuscarFecha.Name = "BuscarFecha"
        Me.BuscarFecha.Size = New System.Drawing.Size(100, 20)
        Me.BuscarFecha.TabIndex = 62
        '
        'BuscarNombre
        '
        Me.BuscarNombre.Location = New System.Drawing.Point(150, 49)
        Me.BuscarNombre.Name = "BuscarNombre"
        Me.BuscarNombre.Size = New System.Drawing.Size(100, 20)
        Me.BuscarNombre.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Buscar por Fecha"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 13)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Buscar por IDCliente"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(488, 296)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(706, 343)
        Me.DataGridView1.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "venta con los items de la venta"
        '
        'BuscarPorIDBoton
        '
        Me.BuscarPorIDBoton.Location = New System.Drawing.Point(293, 63)
        Me.BuscarPorIDBoton.Name = "BuscarPorIDBoton"
        Me.BuscarPorIDBoton.Size = New System.Drawing.Size(131, 23)
        Me.BuscarPorIDBoton.TabIndex = 72
        Me.BuscarPorIDBoton.Text = "Buscar"
        Me.BuscarPorIDBoton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "ID de la venta a buscar:"
        '
        'IDVentaABuscar
        '
        Me.IDVentaABuscar.Location = New System.Drawing.Point(149, 63)
        Me.IDVentaABuscar.Name = "IDVentaABuscar"
        Me.IDVentaABuscar.Size = New System.Drawing.Size(100, 20)
        Me.IDVentaABuscar.TabIndex = 75
        '
        'IDVentaAEliminar
        '
        Me.IDVentaAEliminar.Location = New System.Drawing.Point(148, 62)
        Me.IDVentaAEliminar.Name = "IDVentaAEliminar"
        Me.IDVentaAEliminar.Size = New System.Drawing.Size(100, 20)
        Me.IDVentaAEliminar.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "ID de la venta a eliminar:"
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(292, 62)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(131, 23)
        Me.Eliminar.TabIndex = 77
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IDVentaAEliminar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Eliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 104)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DAR DE BAJA VENTA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListarTodo)
        Me.GroupBox3.Controls.Add(Me.BuscarPorTotalBoton)
        Me.GroupBox3.Controls.Add(Me.BuscarPorFechaBoton)
        Me.GroupBox3.Controls.Add(Me.BuscarPorIDClienteBoton)
        Me.GroupBox3.Controls.Add(Me.BuscarTotal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.BuscarFecha)
        Me.GroupBox3.Controls.Add(Me.BuscarNombre)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 392)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(448, 259)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BUSCAR VENTAS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IDVentaABuscar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BuscarPorIDBoton)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 107)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VER UNA VENTA COMPLETA"
        '
        'DisplayNuevoTotal
        '
        Me.DisplayNuevoTotal.Location = New System.Drawing.Point(495, 118)
        Me.DisplayNuevoTotal.Name = "DisplayNuevoTotal"
        Me.DisplayNuevoTotal.ReadOnly = True
        Me.DisplayNuevoTotal.Size = New System.Drawing.Size(100, 20)
        Me.DisplayNuevoTotal.TabIndex = 83
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(257, 118)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(148, 20)
        Me.modificar.TabIndex = 84
        Me.modificar.Text = "Buscar Venta A Modifcar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'IDVentaAmodificar
        '
        Me.IDVentaAmodificar.Location = New System.Drawing.Point(139, 118)
        Me.IDVentaAmodificar.Name = "IDVentaAmodificar"
        Me.IDVentaAmodificar.Size = New System.Drawing.Size(100, 20)
        Me.IDVentaAmodificar.TabIndex = 85
        '
        'ConfirmarVerificacion
        '
        Me.ConfirmarVerificacion.Location = New System.Drawing.Point(613, 105)
        Me.ConfirmarVerificacion.Name = "ConfirmarVerificacion"
        Me.ConfirmarVerificacion.Size = New System.Drawing.Size(108, 44)
        Me.ConfirmarVerificacion.TabIndex = 86
        Me.ConfirmarVerificacion.Text = "Confirmar Modificion"
        Me.ConfirmarVerificacion.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "IDVenta A Modificar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(420, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Nuevo Total:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(15, 18)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(690, 78)
        Me.TextBox1.TabIndex = 89
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.ConfirmarVerificacion)
        Me.GroupBox4.Controls.Add(Me.IDVentaAmodificar)
        Me.GroupBox4.Controls.Add(Me.modificar)
        Me.GroupBox4.Controls.Add(Me.DisplayNuevoTotal)
        Me.GroupBox4.Location = New System.Drawing.Point(473, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(730, 159)
        Me.GroupBox4.TabIndex = 90
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MODIFICAR VENTA"
        '
        'MenuDeAdministracionDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 651)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.VolverMenuPrincipal)
        Me.Name = "MenuDeAdministracionDeVentas"
        Me.Text = "MenuDeAdministracionDeVentas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VolverMenuPrincipal As Button
    Friend WithEvents ListarTodo As Button
    Friend WithEvents BuscarPorTotalBoton As Button
    Friend WithEvents BuscarPorFechaBoton As Button
    Friend WithEvents BuscarPorIDClienteBoton As Button
    Friend WithEvents BuscarTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BuscarFecha As TextBox
    Friend WithEvents BuscarNombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BuscarPorIDBoton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IDVentaABuscar As TextBox
    Friend WithEvents IDVentaAEliminar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Eliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DisplayNuevoTotal As TextBox
    Friend WithEvents modificar As Button
    Friend WithEvents IDVentaAmodificar As TextBox
    Friend WithEvents ConfirmarVerificacion As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
