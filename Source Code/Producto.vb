Public Class Producto
    Private ID As Int32
    Private Nombre As String
    Private Precio As Int32
    Private Categoria As String

    Public Sub New(nombre As String, precio As Int32, categoria As String) 'Alta'
        'voy a hacer que el new sea el dar el Alta a un cliente asi no se instancian variables en null como la ID '
        Dim sistema As New Sistema
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Categoria = categoria


        Me.ID = sistema.AgregarProducto(nombre, precio, categoria)
    End Sub

    Public Function Valor() As Int32
        Return Precio
    End Function


End Class
