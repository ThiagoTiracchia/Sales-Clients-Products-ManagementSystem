Public Class Venta
    Private ID As Int32
    Private IDCliente As Int32
    Private Fecha As Date
    Private Total As Int32
    Private Items As List(Of VentaItem)

    'Total y todo atributo en esta y otras clases que hacen reverencia a una moneda o plata, no deberian ser del tipo int32 sino su tipo especifico ya sea nose DOLAR o PESO'


    Public Sub New(IdCliente As Int32, fecha As String) 'Alta'
        'voy a hacer que el new sea el dar el Alta a un cliente asi no se instancian variables en null como la ID '
        Dim sistema As New Sistema
        Dim itemsVacios As List(Of VentaItem) = New List(Of VentaItem)
        Me.Items = itemsVacios
        Me.IDCliente = IdCliente
        Me.Fecha = fecha
        Me.Total = 0

        Me.ID = sistema.crearVentaVacia(Me.IDCliente, Me.Fecha)
    End Sub

    Public Sub AgregarVentaItemAVenta(item As VentaItem)
        Items.Add(item)
        Dim sistema As New Sistema

        Me.Total = Me.Total + item.Valor()
        sistema.EsteItemAEsteIdDeVenta(item, Me.ID)


    End Sub


    Public Sub Alta()
        Dim sistema As New Sistema

        sistema.AltaAVentaCon(Me.ID, Me.Total)
        'loguear a sql modificando haciendo un update'
    End Sub

    Public Sub Baja()
        Dim sistema As New Sistema

        sistema.DarDeBaja(Me.ID, "ventas")

    End Sub

    Friend Function DameFecha() As String
        Return Me.Fecha
    End Function

    Friend Function DameID() As Int32
        Return Me.ID
    End Function

    Friend Function DameTotal() As Int32
        Return Me.Total
    End Function
End Class
