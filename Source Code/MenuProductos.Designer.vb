<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuProductos
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
        Me.CrearProducto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoriaProducto = New System.Windows.Forms.TextBox()
        Me.NombreProducto = New System.Windows.Forms.TextBox()
        Me.PrecioProducto = New System.Windows.Forms.TextBox()
        Me.VolverMenuPrincipal = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EliminarProductoID = New System.Windows.Forms.TextBox()
        Me.EliminarProductoPorNombre = New System.Windows.Forms.TextBox()
        Me.EliminarXID = New System.Windows.Forms.Button()
        Me.EliminarXNombre = New System.Windows.Forms.Button()
        Me.ModifNombre = New System.Windows.Forms.TextBox()
        Me.ModifID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NuevoPrecio = New System.Windows.Forms.TextBox()
        Me.NuevoNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NuevaCategoria = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ModifPorID = New System.Windows.Forms.Button()
        Me.ModifNombreBotton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BuscarCategoria = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BuscarPrecio = New System.Windows.Forms.TextBox()
        Me.BuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BuscarPorPrecioBoton = New System.Windows.Forms.Button()
        Me.BuscarPorNombreBoton = New System.Windows.Forms.Button()
        Me.BuscarPorCategoriaBoton = New System.Windows.Forms.Button()
        Me.ListarTodo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrearProducto
        '
        Me.CrearProducto.Location = New System.Drawing.Point(180, 152)
        Me.CrearProducto.Name = "CrearProducto"
        Me.CrearProducto.Size = New System.Drawing.Size(100, 27)
        Me.CrearProducto.TabIndex = 15
        Me.CrearProducto.Text = "Crear Producto"
        Me.CrearProducto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Categoria De Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Precio De Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre De Producto"
        '
        'CategoriaProducto
        '
        Me.CategoriaProducto.Location = New System.Drawing.Point(180, 116)
        Me.CategoriaProducto.Name = "CategoriaProducto"
        Me.CategoriaProducto.Size = New System.Drawing.Size(100, 20)
        Me.CategoriaProducto.TabIndex = 10
        '
        'NombreProducto
        '
        Me.NombreProducto.Location = New System.Drawing.Point(180, 42)
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.NombreProducto.TabIndex = 9
        '
        'PrecioProducto
        '
        Me.PrecioProducto.Location = New System.Drawing.Point(180, 79)
        Me.PrecioProducto.Name = "PrecioProducto"
        Me.PrecioProducto.Size = New System.Drawing.Size(100, 20)
        Me.PrecioProducto.TabIndex = 8
        '
        'VolverMenuPrincipal
        '
        Me.VolverMenuPrincipal.Location = New System.Drawing.Point(12, 3)
        Me.VolverMenuPrincipal.Name = "VolverMenuPrincipal"
        Me.VolverMenuPrincipal.Size = New System.Drawing.Size(145, 23)
        Me.VolverMenuPrincipal.TabIndex = 16
        Me.VolverMenuPrincipal.Text = "Volver a Menu Principal"
        Me.VolverMenuPrincipal.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Por ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Por Nombre:"
        '
        'EliminarProductoID
        '
        Me.EliminarProductoID.Location = New System.Drawing.Point(83, 41)
        Me.EliminarProductoID.Name = "EliminarProductoID"
        Me.EliminarProductoID.Size = New System.Drawing.Size(100, 20)
        Me.EliminarProductoID.TabIndex = 20
        '
        'EliminarProductoPorNombre
        '
        Me.EliminarProductoPorNombre.Location = New System.Drawing.Point(83, 67)
        Me.EliminarProductoPorNombre.Name = "EliminarProductoPorNombre"
        Me.EliminarProductoPorNombre.Size = New System.Drawing.Size(100, 20)
        Me.EliminarProductoPorNombre.TabIndex = 21
        '
        'EliminarXID
        '
        Me.EliminarXID.Location = New System.Drawing.Point(189, 41)
        Me.EliminarXID.Name = "EliminarXID"
        Me.EliminarXID.Size = New System.Drawing.Size(92, 23)
        Me.EliminarXID.TabIndex = 22
        Me.EliminarXID.Text = "Eliminar ID"
        Me.EliminarXID.UseVisualStyleBackColor = True
        '
        'EliminarXNombre
        '
        Me.EliminarXNombre.Location = New System.Drawing.Point(189, 67)
        Me.EliminarXNombre.Name = "EliminarXNombre"
        Me.EliminarXNombre.Size = New System.Drawing.Size(92, 23)
        Me.EliminarXNombre.TabIndex = 23
        Me.EliminarXNombre.Text = "Eliminar Nombre"
        Me.EliminarXNombre.UseVisualStyleBackColor = True
        '
        'ModifNombre
        '
        Me.ModifNombre.Location = New System.Drawing.Point(187, 59)
        Me.ModifNombre.Name = "ModifNombre"
        Me.ModifNombre.Size = New System.Drawing.Size(100, 20)
        Me.ModifNombre.TabIndex = 28
        '
        'ModifID
        '
        Me.ModifID.Location = New System.Drawing.Point(187, 29)
        Me.ModifID.Name = "ModifID"
        Me.ModifID.Size = New System.Drawing.Size(100, 20)
        Me.ModifID.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nombre Del Producto a Modificar:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "ID del Producto a Modificar:"
        '
        'NuevoPrecio
        '
        Me.NuevoPrecio.Location = New System.Drawing.Point(187, 115)
        Me.NuevoPrecio.Name = "NuevoPrecio"
        Me.NuevoPrecio.Size = New System.Drawing.Size(100, 20)
        Me.NuevoPrecio.TabIndex = 32
        '
        'NuevoNombre
        '
        Me.NuevoNombre.Location = New System.Drawing.Point(187, 89)
        Me.NuevoNombre.Name = "NuevoNombre"
        Me.NuevoNombre.Size = New System.Drawing.Size(100, 20)
        Me.NuevoNombre.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Nuevo Precio:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Nuevo Nombre:"
        '
        'NuevaCategoria
        '
        Me.NuevaCategoria.Location = New System.Drawing.Point(187, 145)
        Me.NuevaCategoria.Name = "NuevaCategoria"
        Me.NuevaCategoria.Size = New System.Drawing.Size(100, 20)
        Me.NuevaCategoria.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Nueva Categoria:"
        '
        'ModifPorID
        '
        Me.ModifPorID.Location = New System.Drawing.Point(305, 29)
        Me.ModifPorID.Name = "ModifPorID"
        Me.ModifPorID.Size = New System.Drawing.Size(118, 20)
        Me.ModifPorID.TabIndex = 35
        Me.ModifPorID.Text = "Modificar Por ID"
        Me.ModifPorID.UseVisualStyleBackColor = True
        '
        'ModifNombreBotton
        '
        Me.ModifNombreBotton.Location = New System.Drawing.Point(305, 58)
        Me.ModifNombreBotton.Name = "ModifNombreBotton"
        Me.ModifNombreBotton.Size = New System.Drawing.Size(118, 20)
        Me.ModifNombreBotton.TabIndex = 36
        Me.ModifNombreBotton.Text = "Modificar Por Nombre"
        Me.ModifNombreBotton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(444, 356)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 283)
        Me.DataGridView1.TabIndex = 37
        '
        'BuscarCategoria
        '
        Me.BuscarCategoria.Location = New System.Drawing.Point(153, 127)
        Me.BuscarCategoria.Name = "BuscarCategoria"
        Me.BuscarCategoria.Size = New System.Drawing.Size(100, 20)
        Me.BuscarCategoria.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Buscar Por Categoria"
        '
        'BuscarPrecio
        '
        Me.BuscarPrecio.Location = New System.Drawing.Point(153, 97)
        Me.BuscarPrecio.Name = "BuscarPrecio"
        Me.BuscarPrecio.Size = New System.Drawing.Size(100, 20)
        Me.BuscarPrecio.TabIndex = 41
        '
        'BuscarNombre
        '
        Me.BuscarNombre.Location = New System.Drawing.Point(153, 68)
        Me.BuscarNombre.Name = "BuscarNombre"
        Me.BuscarNombre.Size = New System.Drawing.Size(100, 20)
        Me.BuscarNombre.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Buscar por Precio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Buscar por Nombre"
        '
        'BuscarPorPrecioBoton
        '
        Me.BuscarPorPrecioBoton.Location = New System.Drawing.Point(297, 97)
        Me.BuscarPorPrecioBoton.Name = "BuscarPorPrecioBoton"
        Me.BuscarPorPrecioBoton.Size = New System.Drawing.Size(118, 20)
        Me.BuscarPorPrecioBoton.TabIndex = 46
        Me.BuscarPorPrecioBoton.Text = "Buscar Por Precio"
        Me.BuscarPorPrecioBoton.UseVisualStyleBackColor = True
        '
        'BuscarPorNombreBoton
        '
        Me.BuscarPorNombreBoton.Location = New System.Drawing.Point(297, 68)
        Me.BuscarPorNombreBoton.Name = "BuscarPorNombreBoton"
        Me.BuscarPorNombreBoton.Size = New System.Drawing.Size(118, 20)
        Me.BuscarPorNombreBoton.TabIndex = 45
        Me.BuscarPorNombreBoton.Text = "Buscar por Nombre"
        Me.BuscarPorNombreBoton.UseVisualStyleBackColor = True
        '
        'BuscarPorCategoriaBoton
        '
        Me.BuscarPorCategoriaBoton.Location = New System.Drawing.Point(297, 127)
        Me.BuscarPorCategoriaBoton.Name = "BuscarPorCategoriaBoton"
        Me.BuscarPorCategoriaBoton.Size = New System.Drawing.Size(118, 20)
        Me.BuscarPorCategoriaBoton.TabIndex = 47
        Me.BuscarPorCategoriaBoton.Text = "Buscar Por Categoria"
        Me.BuscarPorCategoriaBoton.UseVisualStyleBackColor = True
        '
        'ListarTodo
        '
        Me.ListarTodo.Location = New System.Drawing.Point(293, 206)
        Me.ListarTodo.Name = "ListarTodo"
        Me.ListarTodo.Size = New System.Drawing.Size(122, 46)
        Me.ListarTodo.TabIndex = 48
        Me.ListarTodo.Text = "Listar Todo"
        Me.ListarTodo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ModifNombreBotton)
        Me.GroupBox1.Controls.Add(Me.ModifPorID)
        Me.GroupBox1.Controls.Add(Me.NuevaCategoria)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.NuevoPrecio)
        Me.GroupBox1.Controls.Add(Me.NuevoNombre)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ModifNombre)
        Me.GroupBox1.Controls.Add(Me.ModifID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(552, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 189)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MODIFICAR PRODUCTO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EliminarXNombre)
        Me.GroupBox2.Controls.Add(Me.EliminarXID)
        Me.GroupBox2.Controls.Add(Me.EliminarProductoPorNombre)
        Me.GroupBox2.Controls.Add(Me.EliminarProductoID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(558, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 116)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ELIMINAR PRODUCTO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CrearProducto)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.CategoriaProducto)
        Me.GroupBox3.Controls.Add(Me.NombreProducto)
        Me.GroupBox3.Controls.Add(Me.PrecioProducto)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 187)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "AGREGAR PRODUCTOS"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListarTodo)
        Me.GroupBox4.Controls.Add(Me.BuscarPorCategoriaBoton)
        Me.GroupBox4.Controls.Add(Me.BuscarPorPrecioBoton)
        Me.GroupBox4.Controls.Add(Me.BuscarPorNombreBoton)
        Me.GroupBox4.Controls.Add(Me.BuscarCategoria)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.BuscarPrecio)
        Me.GroupBox4.Controls.Add(Me.BuscarNombre)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 345)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(430, 268)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "BUSCAR PRODUCTO"
        '
        'MenuProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 651)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.VolverMenuPrincipal)
        Me.Name = "MenuProductos"
        Me.Text = "Menu de Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrearProducto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CategoriaProducto As TextBox
    Friend WithEvents NombreProducto As TextBox
    Friend WithEvents PrecioProducto As TextBox
    Friend WithEvents VolverMenuPrincipal As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EliminarProductoID As TextBox
    Friend WithEvents EliminarProductoPorNombre As TextBox
    Friend WithEvents EliminarXID As Button
    Friend WithEvents EliminarXNombre As Button
    Friend WithEvents ModifNombre As TextBox
    Friend WithEvents ModifID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NuevoPrecio As TextBox
    Friend WithEvents NuevoNombre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NuevaCategoria As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ModifPorID As Button
    Friend WithEvents ModifNombreBotton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BuscarCategoria As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BuscarPrecio As TextBox
    Friend WithEvents BuscarNombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BuscarPorPrecioBoton As Button
    Friend WithEvents BuscarPorNombreBoton As Button
    Friend WithEvents BuscarPorCategoriaBoton As Button
    Friend WithEvents ListarTodo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
