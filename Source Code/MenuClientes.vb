Public Class MenuClientes

    'No se provee opcion de eliminar por nombre de Cliente
    'ya que pueden tener el mismo nombre varios clientes (tome el codigo como si cliente fuese nombre y no un numero) es algo rapidamente cambiable 

    Private ClienteMasReciente As Cliente
    Private Sub MenuClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrearCliente_Click(sender As Object, e As EventArgs) Handles CrearCliente.Click
        If String.IsNullOrWhiteSpace(NombreCliente.Text) OrElse
           String.IsNullOrWhiteSpace(TelefonoCliente.Text) OrElse
           String.IsNullOrWhiteSpace(CorreoCliente.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim nombreCreado As String = NombreCliente.Text
            Dim telefonoCreado As String = TelefonoCliente.Text
            Dim correoCreado As String = CorreoCliente.Text

            Dim nuevoCliente As New Cliente(nombreCreado, telefonoCreado, correoCreado)

            nuevoCliente.Alta()

            Me.ClienteMasReciente = nuevoCliente

            Nombre.Text = nombreCreado
            Telefono.Text = telefonoCreado
            Correo.Text = correoCreado
            ID.Text = nuevoCliente.DameID()

        End If
    End Sub
    Private Sub EliminarClienteID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EliminarClienteID.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub
    Private Sub EliminarXID_Click(sender As Object, e As EventArgs) Handles EliminarXID.Click
        If String.IsNullOrWhiteSpace(EliminarClienteID.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim ID As Int32 = EliminarClienteID.Text
            sistema.DarDeBaja(ID, "clientes")

        End If
    End Sub

    Private Sub EliminarLogeado_Click(sender As Object, e As EventArgs) Handles EliminarLogeado.Click
        Dim sistema As New Sistema
        sistema.DarDeBaja(ClienteMasReciente.DameID(), "clientes")

    End Sub
    Private Sub ModifID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ModifID.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub


    Private Sub ModifPorID_Click(sender As Object, e As EventArgs) Handles ModifPorID.Click
        If String.IsNullOrWhiteSpace(ModifID.Text) OrElse
             String.IsNullOrWhiteSpace(NuevoNombre.Text) OrElse
             String.IsNullOrWhiteSpace(NuevoTelefono.Text) OrElse
               String.IsNullOrWhiteSpace(NuevoCorreo.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema

            Dim ID As Int32 = ModifID.Text
            Dim nombre As String = NuevoNombre.Text
            Dim telefono As String = NuevoTelefono.Text
            Dim correo As String = NuevoCorreo.Text

            sistema.ModificarCliente(ID, nombre, telefono, correo)

        End If

    End Sub

    Private Sub ModificarClienteRecienCreadoButon_Click(sender As Object, e As EventArgs) Handles ModificarClienteRecienCreadoButon.Click
        If String.IsNullOrWhiteSpace(NuevoNombre.Text) OrElse
            String.IsNullOrWhiteSpace(NuevoTelefono.Text) OrElse
              String.IsNullOrWhiteSpace(NuevoCorreo.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema

            sistema.ModificarCliente(ClienteMasReciente.DameID(), NuevoNombre.Text, NuevoTelefono.Text, NuevoCorreo.Text)

            Nombre.Text = NuevoNombre.Text
            Telefono.Text = NuevoTelefono.Text
            Correo.Text = NuevoCorreo.Text
            ID.Text = ClienteMasReciente.DameID()
        End If
    End Sub

    Private Sub BuscarPorNombreBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorNombreBoton.Click
        If String.IsNullOrWhiteSpace(BuscarNombre.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim nombre As String = BuscarNombre.Text
            sistema.EncontrarClientePorNombre(nombre, DataGridView1)

        End If
    End Sub

    Private Sub BuscarPorTelefonoBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorTelefonoBoton.Click
        If String.IsNullOrWhiteSpace(BuscarTelefono.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim telefono As String = BuscarTelefono.Text
            sistema.EncontrarClientePorTelefono(telefono, DataGridView1)

        End If
    End Sub

    Private Sub BuscarPorCorreoBoton_Click(sender As Object, e As EventArgs) Handles BuscarPorCorreoBoton.Click
        If String.IsNullOrWhiteSpace(BuscarCorreo.Text) Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sistema As New Sistema
            Dim correo As String = BuscarCorreo.Text
            sistema.EncontrarClientePorCorreo(correo, DataGridView1)

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

    Private Sub ListarTodo_Click(sender As Object, e As EventArgs) Handles ListarTodo.Click
        Dim sistema As New Sistema
        sistema.MostrarTodaTabla("clientes", DataGridView1)
    End Sub


End Class