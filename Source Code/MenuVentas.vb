Public Class MenuVentas

    Private ventaActual As Venta


    Private Sub MenuVentas_load() Handles MyBase.Load
        Dim sistema As New Sistema

        sistema.MostrarTodaTabla("productos", DataGridView1)

    End Sub

    Private Sub VolverMenuPrincipal_Click(sender As Object, e As EventArgs) Handles VolverMenuPrincipal.Click
        Me.Hide()

        Dim form1 As New MenuPrincipal()

        form1.FormBorderStyle = Me.FormBorderStyle
        form1.StartPosition = FormStartPosition.Manual
        form1.Location = Me.Location
        form1.Size = Me.Size

        form1.Show()
    End Sub

    Private Sub CrearVenta_Click(sender As Object, e As EventArgs) Handles CrearVenta.Click
        If String.IsNullOrWhiteSpace(IdClienteVenta.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos o pon un valor valido.", "Campos vacíos o invalidos ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MenuDeCreacionDeVenta.Show()
            Dim ventaNueva As New Venta(IdClienteVenta.Text, Date.Now)

            'se pueden quitar los getters con doble dispatch'
            Me.ventaActual = ventaNueva
            IdCLienteActual.Text = IdClienteVenta.Text
            FechaVentaActual.Text = ventaNueva.DameFecha()
            IDVenta.Text = ventaNueva.DameID()
            TotalVentaActual.Text = 0
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim idDelProducto As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value)
            Dim nombreProducto As String = Convert.ToString(filaSeleccionada.Cells("Nombre").Value)
            Dim precio As Double = Convert.ToDouble(filaSeleccionada.Cells("Precio").Value)
            Dim categoria As String = Convert.ToString(filaSeleccionada.Cells("Categoria").Value)

            ProductoSeleccionado.Text = nombreProducto
            PrecioSeleccionado.Text = precio
            CategoriaSeleccionada.Text = categoria
            IDProducto.Text = idDelProducto
        End If
    End Sub



    Private Sub MenuVentas_load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuDeCreacionDeVenta.Hide()


    End Sub


    Private Sub CantidadAAgregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidadAAgregar.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub
    Private Sub AgregarCarrito_Click(sender As Object, e As EventArgs) Handles AgregarCarrito.Click
        If String.IsNullOrWhiteSpace(CantidadAAgregar.Text) OrElse
            CantidadAAgregar.Text <= 0 OrElse
            String.IsNullOrWhiteSpace(ProductoSeleccionado.Text) Then


            MessageBox.Show("Por favor, complete todos los campos requeridos o pon un valor valido.", "Campos vacíos o invalidos ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema()
            Dim ventaItem As New VentaItem(IDProducto.Text, CantidadAAgregar.Text)


            ventaActual.AgregarVentaItemAVenta(ventaItem)

            sistema.listarItemsDeVenta(ventaActual.DameID(), ItemsDeVenta)

            TotalVentaActual.Text = ventaActual.DameTotal()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TotalVentaActual.Text <= 0 Then
            MessageBox.Show("Minimo la compra debe tener un elemento.", "Campos vacíos o invalidos ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ventaActual.Alta()
        End If
    End Sub

    Private Sub EliminarVentaButton_Click(sender As Object, e As EventArgs) Handles EliminarVentaButton.Click

        If String.IsNullOrWhiteSpace(IDVenta.Text) Then
            MessageBox.Show("Tiene que haberse creado una venta almenos", "Campos vacíos o invalidos ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            ventaActual.Baja()

        End If
    End Sub


End Class