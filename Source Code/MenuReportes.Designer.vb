<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuReportes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VolverMenuPrincipal = New System.Windows.Forms.Button()
        Me.IDReporte11 = New System.Windows.Forms.TextBox()
        Me.Reporte11Boton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GenerarReporteProductos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(469, 258)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 381)
        Me.DataGridView1.TabIndex = 0
        '
        'VolverMenuPrincipal
        '
        Me.VolverMenuPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.VolverMenuPrincipal.Name = "VolverMenuPrincipal"
        Me.VolverMenuPrincipal.Size = New System.Drawing.Size(145, 23)
        Me.VolverMenuPrincipal.TabIndex = 17
        Me.VolverMenuPrincipal.Text = "Volver a Menu Principal"
        Me.VolverMenuPrincipal.UseVisualStyleBackColor = True
        '
        'IDReporte11
        '
        Me.IDReporte11.Location = New System.Drawing.Point(76, 65)
        Me.IDReporte11.Name = "IDReporte11"
        Me.IDReporte11.Size = New System.Drawing.Size(100, 20)
        Me.IDReporte11.TabIndex = 18
        '
        'Reporte11Boton
        '
        Me.Reporte11Boton.Location = New System.Drawing.Point(197, 65)
        Me.Reporte11Boton.Name = "Reporte11Boton"
        Me.Reporte11Boton.Size = New System.Drawing.Size(140, 23)
        Me.Reporte11Boton.TabIndex = 19
        Me.Reporte11Boton.Text = "Generar Reporte Venta"
        Me.Reporte11Boton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID Venta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Generar Reporte de una venta"
        '
        'GenerarReporteProductos
        '
        Me.GenerarReporteProductos.Location = New System.Drawing.Point(197, 131)
        Me.GenerarReporteProductos.Name = "GenerarReporteProductos"
        Me.GenerarReporteProductos.Size = New System.Drawing.Size(140, 23)
        Me.GenerarReporteProductos.TabIndex = 22
        Me.GenerarReporteProductos.Text = "Generar De Productos"
        Me.GenerarReporteProductos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Generar Reporte de Productos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IDReporte11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Reporte11Boton)
        Me.GroupBox1.Controls.Add(Me.GenerarReporteProductos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 174)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes"
        '
        'MenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 651)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VolverMenuPrincipal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MenuReportes"
        Me.Text = "MenuReportes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VolverMenuPrincipal As Button
    Friend WithEvents IDReporte11 As TextBox
    Friend WithEvents Reporte11Boton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GenerarReporteProductos As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
