<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        ' Me.PruebademoDataSet = New challenge.pruebademoDataSet()
        Me.PruebademoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.PruebademoDataSet1 = New challenge.pruebademoDataSet()
        Me.ProductosMenu = New System.Windows.Forms.Button()
        Me.MenuClientes = New System.Windows.Forms.Button()
        Me.MenuVentas = New System.Windows.Forms.Button()
        Me.MenuDeAdmDeVentas = New System.Windows.Forms.Button()
        Me.MenuReportes = New System.Windows.Forms.Button()
        ' CType(Me.PruebademoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PruebademoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.PruebademoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PruebademoDataSet
        '
        ' Me.PruebademoDataSet.DataSetName = "pruebademoDataSet"
        ' Me.PruebademoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PruebademoDataSetBindingSource
        '
        ' Me.PruebademoDataSetBindingSource.DataSource = Me.PruebademoDataSet
        Me.PruebademoDataSetBindingSource.Position = 0
        '
        'PruebademoDataSet1
        '
        ' Me.PruebademoDataSet1.DataSetName = "pruebademoDataSet"
        ' Me.PruebademoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosMenu
        '
        Me.ProductosMenu.Location = New System.Drawing.Point(43, 219)
        Me.ProductosMenu.Name = "ProductosMenu"
        Me.ProductosMenu.Size = New System.Drawing.Size(306, 63)
        Me.ProductosMenu.TabIndex = 0
        Me.ProductosMenu.Text = "Menu de  Productos"
        Me.ProductosMenu.UseVisualStyleBackColor = True
        '
        'MenuClientes
        '
        Me.MenuClientes.Location = New System.Drawing.Point(471, 219)
        Me.MenuClientes.Name = "MenuClientes"
        Me.MenuClientes.Size = New System.Drawing.Size(306, 63)
        Me.MenuClientes.TabIndex = 1
        Me.MenuClientes.Text = "Menu De Clientes"
        Me.MenuClientes.UseVisualStyleBackColor = True
        '
        'MenuVentas
        '
        Me.MenuVentas.Location = New System.Drawing.Point(879, 219)
        Me.MenuVentas.Name = "MenuVentas"
        Me.MenuVentas.Size = New System.Drawing.Size(306, 63)
        Me.MenuVentas.TabIndex = 2
        Me.MenuVentas.Text = "Menu Para Hacer una Venta"
        Me.MenuVentas.UseVisualStyleBackColor = True
        '
        'MenuDeAdmDeVentas
        '
        Me.MenuDeAdmDeVentas.Location = New System.Drawing.Point(888, 384)
        Me.MenuDeAdmDeVentas.Name = "MenuDeAdmDeVentas"
        Me.MenuDeAdmDeVentas.Size = New System.Drawing.Size(306, 63)
        Me.MenuDeAdmDeVentas.TabIndex = 3
        Me.MenuDeAdmDeVentas.Text = "Menu de Administracion De Ventas"
        Me.MenuDeAdmDeVentas.UseVisualStyleBackColor = True
        '
        'MenuReportes
        '
        Me.MenuReportes.Location = New System.Drawing.Point(43, 373)
        Me.MenuReportes.Name = "MenuReportes"
        Me.MenuReportes.Size = New System.Drawing.Size(306, 63)
        Me.MenuReportes.TabIndex = 4
        Me.MenuReportes.Text = "Reportes"
        Me.MenuReportes.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 651)
        Me.Controls.Add(Me.MenuReportes)
        Me.Controls.Add(Me.MenuDeAdmDeVentas)
        Me.Controls.Add(Me.MenuVentas)
        Me.Controls.Add(Me.MenuClientes)
        Me.Controls.Add(Me.ProductosMenu)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu Principal"
        ' CType(Me.PruebademoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PruebademoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.PruebademoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PruebademoDataSetBindingSource As BindingSource
    ' Friend WithEvents PruebademoDataSet As pruebademoDataSet
    ' Friend WithEvents PruebademoDataSet1 As pruebademoDataSet
    Friend WithEvents ProductosMenu As Button
    Friend WithEvents MenuClientes As Button
    Friend WithEvents MenuVentas As Button
    Friend WithEvents MenuDeAdmDeVentas As Button
    Friend WithEvents MenuReportes As Button
End Class
