Public Class MenuReportes
    Private Sub VolverMenuPrincipal_Click(sender As Object, e As EventArgs) Handles VolverMenuPrincipal.Click
        Me.Hide()

        Dim form1 As New MenuPrincipal()

        form1.FormBorderStyle = Me.FormBorderStyle
        form1.StartPosition = FormStartPosition.Manual
        form1.Location = Me.Location
        form1.Size = Me.Size

        form1.Show()
    End Sub
    Private Sub PrecioProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDReporte11.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub
    Private Sub Reporte11Boton_Click(sender As Object, e As EventArgs) Handles Reporte11Boton.Click

        If String.IsNullOrWhiteSpace(IDReporte11.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            sistema.GenerarReporteDeUnaVenta(IDReporte11.Text, DataGridView1)
        End If
    End Sub



    Private Sub IDReporte11_TextChanged(sender As Object, e As EventArgs) Handles IDReporte11.TextChanged

    End Sub

    Private Sub GenerarReporteProductos_Click(sender As Object, e As EventArgs) Handles GenerarReporteProductos.Click
        Dim sistema As New Sistema
        sistema.GenerarReporteDeProductos(DataGridView1)

    End Sub
End Class