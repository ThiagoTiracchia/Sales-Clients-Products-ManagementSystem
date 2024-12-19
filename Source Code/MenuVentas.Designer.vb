<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuVentas
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
        Me.VolverMenuPrincipal = New System.Windows.Forms.Button()
        Me.CrearVenta = New System.Windows.Forms.Button()
        Me.IDVenta = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.label555 = New System.Windows.Forms.Label()
        Me.TotalVentaActual = New System.Windows.Forms.TextBox()
        Me.FechaVentaActual = New System.Windows.Forms.TextBox()
        Me.IdCLienteActual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ItemsDeVenta = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdClienteVenta = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AgregarCarrito = New System.Windows.Forms.Button()
        Me.ProductoSeleccionado = New System.Windows.Forms.TextBox()
        Me.CantidadAAgregar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrecioSeleccionado = New System.Windows.Forms.TextBox()
        Me.CategoriaSeleccionada = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.IDProducto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EliminarVentaButton = New System.Windows.Forms.Button()
        Me.MenuDeCreacionDeVenta = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ItemsDeVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDeCreacionDeVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'VolverMenuPrincipal
        '
        Me.VolverMenuPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.VolverMenuPrincipal.Name = "VolverMenuPrincipal"
        Me.VolverMenuPrincipal.Size = New System.Drawing.Size(145, 23)
        Me.VolverMenuPrincipal.TabIndex = 57
        Me.VolverMenuPrincipal.Text = "Volver a Menu Principal"
        Me.VolverMenuPrincipal.UseVisualStyleBackColor = True
        '
        'CrearVenta
        '
        Me.CrearVenta.Location = New System.Drawing.Point(256, 35)
        Me.CrearVenta.Name = "CrearVenta"
        Me.CrearVenta.Size = New System.Drawing.Size(106, 43)
        Me.CrearVenta.TabIndex = 58
        Me.CrearVenta.Text = "Crear Venta"
        Me.CrearVenta.UseVisualStyleBackColor = True
        '
        'IDVenta
        '
        Me.IDVenta.Location = New System.Drawing.Point(937, 81)
        Me.IDVenta.Name = "IDVenta"
        Me.IDVenta.ReadOnly = True
        Me.IDVenta.Size = New System.Drawing.Size(65, 20)
        Me.IDVenta.TabIndex = 109
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(884, 85)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "ID Venta:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1038, 81)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1035, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = "Fecha:"
        '
        'label555
        '
        Me.label555.AutoSize = True
        Me.label555.Location = New System.Drawing.Point(884, 52)
        Me.label555.Name = "label555"
        Me.label555.Size = New System.Drawing.Size(53, 13)
        Me.label555.TabIndex = 105
        Me.label555.Text = "IDCliente:"
        '
        'TotalVentaActual
        '
        Me.TotalVentaActual.Location = New System.Drawing.Point(1093, 78)
        Me.TotalVentaActual.Name = "TotalVentaActual"
        Me.TotalVentaActual.ReadOnly = True
        Me.TotalVentaActual.Size = New System.Drawing.Size(89, 20)
        Me.TotalVentaActual.TabIndex = 104
        '
        'FechaVentaActual
        '
        Me.FechaVentaActual.Location = New System.Drawing.Point(1093, 52)
        Me.FechaVentaActual.Name = "FechaVentaActual"
        Me.FechaVentaActual.ReadOnly = True
        Me.FechaVentaActual.Size = New System.Drawing.Size(89, 20)
        Me.FechaVentaActual.TabIndex = 103
        '
        'IdCLienteActual
        '
        Me.IdCLienteActual.Location = New System.Drawing.Point(937, 52)
        Me.IdCLienteActual.Name = "IdCLienteActual"
        Me.IdCLienteActual.ReadOnly = True
        Me.IdCLienteActual.Size = New System.Drawing.Size(65, 20)
        Me.IdCLienteActual.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(998, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Venta Actual"
        '
        'ItemsDeVenta
        '
        Me.ItemsDeVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsDeVenta.Location = New System.Drawing.Point(655, 250)
        Me.ItemsDeVenta.Name = "ItemsDeVenta"
        Me.ItemsDeVenta.Size = New System.Drawing.Size(506, 194)
        Me.ItemsDeVenta.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "ID de cliente Para la venta:"
        '
        'IdClienteVenta
        '
        Me.IdClienteVenta.Location = New System.Drawing.Point(151, 43)
        Me.IdClienteVenta.Name = "IdClienteVenta"
        Me.IdClienteVenta.Size = New System.Drawing.Size(86, 20)
        Me.IdClienteVenta.TabIndex = 112
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(394, 189)
        Me.DataGridView1.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Producto Seleccionado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Cantidad a Agregar:"
        '
        'AgregarCarrito
        '
        Me.AgregarCarrito.Location = New System.Drawing.Point(140, 138)
        Me.AgregarCarrito.Name = "AgregarCarrito"
        Me.AgregarCarrito.Size = New System.Drawing.Size(107, 23)
        Me.AgregarCarrito.TabIndex = 117
        Me.AgregarCarrito.Text = "Agregar al carrito"
        Me.AgregarCarrito.UseVisualStyleBackColor = True
        '
        'ProductoSeleccionado
        '
        Me.ProductoSeleccionado.Location = New System.Drawing.Point(140, 27)
        Me.ProductoSeleccionado.Name = "ProductoSeleccionado"
        Me.ProductoSeleccionado.ReadOnly = True
        Me.ProductoSeleccionado.Size = New System.Drawing.Size(104, 20)
        Me.ProductoSeleccionado.TabIndex = 118
        '
        'CantidadAAgregar
        '
        Me.CantidadAAgregar.Location = New System.Drawing.Point(140, 108)
        Me.CantidadAAgregar.Name = "CantidadAAgregar"
        Me.CantidadAAgregar.Size = New System.Drawing.Size(104, 20)
        Me.CantidadAAgregar.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Precio:"
        '
        'PrecioSeleccionado
        '
        Me.PrecioSeleccionado.Location = New System.Drawing.Point(140, 56)
        Me.PrecioSeleccionado.Name = "PrecioSeleccionado"
        Me.PrecioSeleccionado.ReadOnly = True
        Me.PrecioSeleccionado.Size = New System.Drawing.Size(104, 20)
        Me.PrecioSeleccionado.TabIndex = 119
        '
        'CategoriaSeleccionada
        '
        Me.CategoriaSeleccionada.Location = New System.Drawing.Point(140, 82)
        Me.CategoriaSeleccionada.Name = "CategoriaSeleccionada"
        Me.CategoriaSeleccionada.ReadOnly = True
        Me.CategoriaSeleccionada.Size = New System.Drawing.Size(104, 20)
        Me.CategoriaSeleccionada.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Categoria:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 13)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "|"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(9, 13)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "|"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(9, 13)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "|"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "v"
        '
        'IDProducto
        '
        Me.IDProducto.Location = New System.Drawing.Point(290, 27)
        Me.IDProducto.Name = "IDProducto"
        Me.IDProducto.ReadOnly = True
        Me.IDProducto.Size = New System.Drawing.Size(37, 20)
        Me.IDProducto.TabIndex = 128
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(263, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 13)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1013, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 78)
        Me.Button1.TabIndex = 130
        Me.Button1.Text = "Finalizar Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(655, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Carrito:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EliminarVentaButton
        '
        Me.EliminarVentaButton.Location = New System.Drawing.Point(838, 462)
        Me.EliminarVentaButton.Name = "EliminarVentaButton"
        Me.EliminarVentaButton.Size = New System.Drawing.Size(154, 78)
        Me.EliminarVentaButton.TabIndex = 132
        Me.EliminarVentaButton.Text = "Eliminar Venta Actual"
        Me.EliminarVentaButton.UseVisualStyleBackColor = True
        '
        'MenuDeCreacionDeVenta
        '
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label14)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.EliminarVentaButton)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label13)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Button1)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label12)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.IDProducto)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label11)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label10)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label9)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label7)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.CategoriaSeleccionada)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label5)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.CantidadAAgregar)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.PrecioSeleccionado)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.ProductoSeleccionado)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.AgregarCarrito)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label4)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label3)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label2)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.DataGridView1)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.ItemsDeVenta)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.IDVenta)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label21)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label20)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label19)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.label555)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.TotalVentaActual)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.FechaVentaActual)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.IdCLienteActual)
        Me.MenuDeCreacionDeVenta.Controls.Add(Me.Label8)
        Me.MenuDeCreacionDeVenta.Location = New System.Drawing.Point(12, 79)
        Me.MenuDeCreacionDeVenta.Name = "MenuDeCreacionDeVenta"
        Me.MenuDeCreacionDeVenta.Size = New System.Drawing.Size(1187, 560)
        Me.MenuDeCreacionDeVenta.TabIndex = 133
        Me.MenuDeCreacionDeVenta.TabStop = False
        Me.MenuDeCreacionDeVenta.Text = "HACER UNA VENTA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 13)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "Seleccione aqui para agregar al carrito"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "<--------- Para comenzar Venta"
        '
        'MenuVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 651)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MenuDeCreacionDeVenta)
        Me.Controls.Add(Me.IdClienteVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrearVenta)
        Me.Controls.Add(Me.VolverMenuPrincipal)
        Me.Name = "MenuVentas"
        Me.Text = "MenuVentas"
        CType(Me.ItemsDeVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDeCreacionDeVenta.ResumeLayout(False)
        Me.MenuDeCreacionDeVenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VolverMenuPrincipal As Button
    Friend WithEvents CrearVenta As Button
    Friend WithEvents IDVenta As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents label555 As Label
    Friend WithEvents TotalVentaActual As TextBox
    Friend WithEvents FechaVentaActual As TextBox
    Friend WithEvents IdCLienteActual As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ItemsDeVenta As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IdClienteVenta As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AgregarCarrito As Button
    Friend WithEvents ProductoSeleccionado As TextBox
    Friend WithEvents CantidadAAgregar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PrecioSeleccionado As TextBox
    Friend WithEvents CategoriaSeleccionada As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents IDProducto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents EliminarVentaButton As Button
    Friend WithEvents MenuDeCreacionDeVenta As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
End Class
