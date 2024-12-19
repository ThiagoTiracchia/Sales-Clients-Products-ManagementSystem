Public Class VentaItem
    Private ID As Int32
    Private IDVenta As Int32
    Private IDProducto As Int32
    Private PrecioUnitario As Int32
    Private Cantidad As Int32
    Private PrecioTotal As Int32





    Public Sub New(IdProducto As Int32, cantidad As Int32) 'Alta'
        Dim sistema As New Sistema

        Me.IDProducto = IdProducto
        Me.Cantidad = cantidad

        Me.PrecioUnitario = sistema.DarPrecioDeProducto(IdProducto)

        Me.PrecioTotal = PrecioUnitario * cantidad





    End Sub

    Public Sub UsarEsteIdDeVenta(iD As Integer)
        Dim sistema As New Sistema
        Me.IDVenta = iD


        'La forma prolija seria : pasarle el objeto al venta item al sistema y que este vaya recibiendo los atributos pidiendoselos al objeto
        'mediante doble dispatch ya que los getters y setters son mala practica, si tengo tiempo para pulirlo lo hago mediante refactors'
        'por ahora prefiero pasarle todo los atributos necesarios por parametros' 
        Me.ID = sistema.AdherirEsteItemAEsteIdDeVenta(IDVenta, IDProducto, Cantidad, Me.PrecioUnitario, Me.PrecioTotal)

    End Sub

    Public Function Valor() As Int32

        Return Me.PrecioTotal

    End Function




End Class
