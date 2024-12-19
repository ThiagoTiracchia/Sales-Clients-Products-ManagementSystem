Public Class Cliente

    Private ID As Int32
    Private Nombre As String
    Private Telefono As String
    Private Correo As String

    Public Sub New(nombre As String, telefono As String, correo As String) 'Alta'

        Me.Nombre = nombre
        Me.Telefono = telefono
        Me.Correo = correo



    End Sub

    Public Sub Alta()
        Dim sistema As New Sistema



        Me.ID = sistema.DarDeAlta(Me.Nombre, Me.Telefono, Me.Correo)
    End Sub


    Public Sub Modificar(nombre As String, telefono As String, correo As String)
        Dim sistema As New Sistema
        sistema.ModificarCliente(Me.ID, nombre, telefono, correo)

    End Sub

    Public Sub Baja()
        Dim sistema As New Sistema
        sistema.DarDeBaja(Me.ID, "clientes")
    End Sub

    Public Function DameID() As Int32

        Return Me.ID

    End Function

End Class




