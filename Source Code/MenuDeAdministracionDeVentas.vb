Public Class MenuDeAdministracionDeVentas


    Private Sub VolverMenuPrincipal_Click(sender As Object, e As EventArgs) Handles VolverMenuPrincipal.Click
        Me.Hide()

        Dim form1 As New MenuPrincipal()

        form1.FormBorderStyle = Me.FormBorderStyle
        form1.StartPosition = FormStartPosition.Manual
        form1.Location = Me.Location
        form1.Size = Me.Size

        form1.Show()
    End Sub

    Private Sub BuscarTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BuscarTotal.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub


    Private Sub BuscarNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BuscarNombre.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub
    Private Sub IDVentaABuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDVentaABuscar.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub IDVentaAEliminar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDVentaAEliminar.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub


    Private Sub IDVentaAmodificar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDVentaAmodificar.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub


    Private Sub ListarTodo_Click(sender As Object, e As EventArgs) Handles ListarTodo.Click
        Dim sistema As New Sistema
        sistema.MostrarTodaTabla("ventas", DataGridView1)
    End Sub

    Private Sub BuscarPorIDBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorIDBoton.Click

        If String.IsNullOrWhiteSpace(IDVentaABuscar.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            sistema.EncontrarEnBaseDeDatosVentaYSusItems(IDVentaABuscar.Text, DataGridView1)

        End If
    End Sub

    Private Sub BuscarPorIDClienteBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorIDClienteBoton.Click
        If String.IsNullOrWhiteSpace(BuscarNombre.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim IdCliente As Int32 = BuscarNombre.Text
            sistema.EncontrarVentaPorIDeCliente(IdCliente, DataGridView1)

        End If
    End Sub

    Private Sub BuscarPorFechaBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorFechaBoton.Click
        If String.IsNullOrWhiteSpace(BuscarFecha.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim fecha As Date = BuscarFecha.Text
            sistema.EncontrarVentaPorFecha(fecha, DataGridView1)

        End If
    End Sub

    Private Sub BuscarPorTotalBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorTotalBoton.Click
        If String.IsNullOrWhiteSpace(BuscarTotal.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim total As Int32 = BuscarTotal.Text
            sistema.EncontrarVentaPorTotal(total, DataGridView1)

        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If String.IsNullOrWhiteSpace(IDVentaAEliminar.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim idAEliminar As Int32 = IDVentaAEliminar.Text
            sistema.DarDeBaja(idAEliminar, "ventas")


        End If


    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 AndAlso (e.ColumnIndex = DataGridView1.Columns("Cantidad").Index OrElse e.ColumnIndex = DataGridView1.Columns("PrecioUnitario").Index) Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Obtener la cantidad y el precio unitario
            Dim cantidad As Int32 = fila.Cells("Cantidad").Value
            Dim precioUnitario As Int32 = fila.Cells("PrecioUnitario").Value

            ' Calcular el precio total
            Dim precioTotal As Int32 = cantidad * precioUnitario
            fila.Cells("PrecioTotal").Value = precioTotal

            ' Actualizar el total general
            CalcularTotalGeneral()
        End If
    End Sub

    Private Sub CalcularTotalGeneral()
        Dim totalGeneral As Double = 0

        ' Sumar todos los precios totales
        For Each row As DataGridViewRow In DataGridView1.Rows
            totalGeneral += Convert.ToDouble(row.Cells("PrecioTotal").Value)
        Next

        ' Mostrar el total general en un TextBox o Label
        DisplayNuevoTotal.Text = totalGeneral.ToString("F2")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim sistema As New Sistema

        sistema.CargarDetalleVentaParaModificar(IDVentaAmodificar.Text, DataGridView1)
    End Sub

    Private Sub ConfirmarVerificacion_Click(sender As Object, e As EventArgs) Handles ConfirmarVerificacion.Click
        Dim sistema As New Sistema
        Dim idVenta As Int32 = IDVentaAmodificar.Text

        sistema.GuardarModifacionDeVenta(idVenta, IDVentaAmodificar.Text, DataGridView1)


    End Sub
End Class