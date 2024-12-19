Public Class MenuProductos
    Private Sub PrecioProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioProducto.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub



    Private Sub CrearProducto_Click(sender As Object, e As EventArgs) Handles CrearProducto.Click
        If String.IsNullOrWhiteSpace(NombreProducto.Text) OrElse
             String.IsNullOrWhiteSpace(PrecioProducto.Text) OrElse
             String.IsNullOrWhiteSpace(CategoriaProducto.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim nombre As String = NombreProducto.Text
            Dim precio As String = PrecioProducto.Text
            Dim categoria As String = CategoriaProducto.Text

            Dim Producto As New Producto(nombre, precio, categoria)
        End If
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EliminarProductoID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EliminarProductoID.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub


    Private Sub EliminarXID_Click(sender As Object, e As EventArgs) Handles EliminarXID.Click
        If String.IsNullOrWhiteSpace(EliminarProductoID.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim ID As Int32 = EliminarProductoID.Text
            sistema.DarDeBaja(ID, "productos")

        End If
    End Sub

    Private Sub EliminarXNombre_Click(sender As Object, e As EventArgs) Handles EliminarXNombre.Click
        If String.IsNullOrWhiteSpace(EliminarProductoPorNombre.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim nombreDeProducto As String = EliminarProductoPorNombre.Text
            sistema.DarDeBajaProductoPorNombre(nombreDeProducto)

        End If
    End Sub



    Private Sub ModifID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ModifID.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub NuevoPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NuevoPrecio.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub ModifPorID_Click(sender As Object, e As EventArgs) Handles ModifPorID.Click
        If String.IsNullOrWhiteSpace(ModifID.Text) OrElse
             String.IsNullOrWhiteSpace(NuevoNombre.Text) OrElse
             String.IsNullOrWhiteSpace(NuevoPrecio.Text) OrElse
               String.IsNullOrWhiteSpace(NuevaCategoria.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema

            Dim ID As Int32 = ModifID.Text
            Dim nombre As String = NuevoNombre.Text
            Dim Precio As Int32 = NuevoPrecio.Text
            Dim categoria As String = NuevaCategoria.Text

            sistema.ModificarProductoPorID(ID, nombre, Precio, categoria)

        End If


    End Sub

    Private Sub ModifNombreBotton_Click(sender As Object, e As EventArgs) Handles ModifNombreBotton.Click
        If String.IsNullOrWhiteSpace(ModifNombre.Text) OrElse
             String.IsNullOrWhiteSpace(NuevoNombre.Text) OrElse
             String.IsNullOrWhiteSpace(NuevoPrecio.Text) OrElse
               String.IsNullOrWhiteSpace(NuevaCategoria.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim nombre As String = ModifNombre.Text
            Dim sistema As New Sistema
            Dim nuevonombree As String = NuevoNombre.Text
            Dim Precio As Int32 = NuevoPrecio.Text
            Dim categoria As String = NuevaCategoria.Text

            sistema.ModificarProductoPorNombre(nombre, nuevonombree, Precio, categoria)
        End If
    End Sub

    Private Sub BuscarPorNombreBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorNombreBoton.Click
        If String.IsNullOrWhiteSpace(BuscarNombre.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim nombre As String = BuscarNombre.Text
            sistema.EncontrarProductoPorNombre(nombre, DataGridView1)

        End If
    End Sub
    Private Sub BuscarPorPrecioBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorPrecioBoton.Click
        If String.IsNullOrWhiteSpace(BuscarPrecio.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim precio As String = BuscarPrecio.Text
            sistema.EncontrarProductoPorPrecio(precio, DataGridView1)

        End If


    End Sub



    Private Sub BuscarPorCategoriaBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorCategoriaBoton.Click
        If String.IsNullOrWhiteSpace(BuscarCategoria.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim categoria As String = BuscarCategoria.Text
            sistema.EncontrarProductoPorPrecio(categoria, DataGridView1)

        End If
    End Sub

    Private Sub ListarTodo_Click(sender As Object, e As EventArgs) Handles ListarTodo.Click
        Dim sistema As New Sistema
        sistema.MostrarTodaTabla("productos", DataGridView1)
    End Sub
End Class