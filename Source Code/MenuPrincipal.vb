Imports System.Windows
Imports System.Data.DataTable
Imports System.Data.SqlClient
Public Class MenuPrincipal


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProductosMenu_Click(sender As Object, e As EventArgs) Handles ProductosMenu.Click
        Me.Hide()

        Dim MenuProductos As New MenuProductos()

        MenuProductos.FormBorderStyle = Me.FormBorderStyle
        MenuProductos.StartPosition = FormStartPosition.Manual
        MenuProductos.Location = Me.Location
        MenuProductos.Size = Me.Size

        MenuProductos.Show()

    End Sub

    Private Sub MenuClientes_Click(sender As Object, e As EventArgs) Handles MenuClientes.Click
        Me.Hide()

        Dim MenuCliente As New MenuClientes()

        MenuCliente.FormBorderStyle = Me.FormBorderStyle
        MenuCliente.StartPosition = FormStartPosition.Manual
        MenuCliente.Location = Me.Location
        MenuCliente.Size = Me.Size

        MenuCliente.Show()




    End Sub

    Private Sub MenuVentas_Click(sender As Object, e As EventArgs) Handles MenuVentas.Click
        Me.Hide()

        Dim MenuVentas As New MenuVentas()

        MenuVentas.FormBorderStyle = Me.FormBorderStyle
        MenuVentas.StartPosition = FormStartPosition.Manual
        MenuVentas.Location = Me.Location
        MenuVentas.Size = Me.Size

        MenuVentas.Show()
    End Sub

    Private Sub MenuDeAdmDeVentas_Click(sender As Object, e As EventArgs) Handles MenuDeAdmDeVentas.Click
        Me.Hide()
        Dim MenuAdminstracionVentas As New MenuDeAdministracionDeVentas()

        MenuAdminstracionVentas.FormBorderStyle = Me.FormBorderStyle
        MenuAdminstracionVentas.StartPosition = FormStartPosition.Manual
        MenuAdminstracionVentas.Location = Me.Location
        MenuAdminstracionVentas.Size = Me.Size

        MenuAdminstracionVentas.Show()
    End Sub

    Private Sub MenuReportes_Click(sender As Object, e As EventArgs) Handles MenuReportes.Click
        Me.Hide()
        Dim MenuReportes As New MenuReportes()

        MenuReportes.FormBorderStyle = Me.FormBorderStyle
        MenuReportes.StartPosition = FormStartPosition.Manual
        MenuReportes.Location = Me.Location
        MenuReportes.Size = Me.Size

        MenuReportes.Show()
    End Sub
End Class
