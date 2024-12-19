Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Configuration
Public Class Sistema
    'Public SQLCon As New SqlConnection With {.ConnectionString = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString}
    'esta clase se podria usar un singleton'
    'se va a repetir mucho el uso de SQLCon.Open() y Close(), se podria hacer uso de una lambda o clousure'
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConexionABase").ConnectionString
    Public SQLCon As New SqlConnection(connectionString)


    'IMPORTANTE este codigo muchas veces no va a chequear errores (que deberia  si tengo tiempo agrego algunos) pero no es lo principal de este challenge
    ' tambien ocurre con cosas case sensitive

    Public Sub New()

    End Sub

    'Muchisimo codigo repetido con los buscadores de ventas clientes y productos, como los 3 tienen 3 atributos quiza se pueden hacer una clase polimorfica
    ' o parametrizar que es donde se quiere buscar y el que  en una sola funcion al estilo
    ' EncontrarEnBaseDeDatos("Nombre de Tabla " , " Columna A Buscar" , "Valor ")
    ' update: seria mucho mejor en clases polimorficas



    Public Sub EncontrarClientePorNombre(nombreDeCliente As String, DataGrid As DataGridView)
        EncontrarEnBaseDeDatos("Cliente", "Telefono", "Correo", "clientes", "Telefono", nombreDeCliente, DataGrid)
    End Sub

    Public Function EncontrarClientePorTelefono(telefono As String, DataGrid As DataGridView)
        EncontrarEnBaseDeDatos("Cliente", "Telefono", "Correo", "clientes", "Cliente", telefono, DataGrid)
    End Function

    Public Sub EncontrarClientePorCorreo(Correo As String, DataGrid As DataGridView)
        EncontrarEnBaseDeDatos("Cliente", "Telefono", "Correo", "clientes", "Correo", Correo, DataGrid)

    End Sub
    Public Sub EncontrarVentaPorIDeCliente(IDCliente As Int32, DataGrid As DataGridView)
        EncontrarEnBaseDeDatos("IDCliente", "Fecha", "Total", "ventas", "IDCliente", IDCliente, DataGrid)
    End Sub

    Public Sub EncontrarVentaPorFecha(fecha As Date, DataGrid As DataGridView)
        EncontrarEnBaseDeDatos("IDCliente", "Fecha", "Total", "ventas", "Fecha", fecha, DataGrid)
    End Sub

    Public Sub EncontrarVentaPorTotal(total As Int32, DataGrid As DataGridView)
        EncontrarEnBaseDeDatos("IDCliente", "Fecha", "Total", "ventas", "Total", total, DataGrid)
    End Sub

    Public Sub EncontrarEnBaseDeDatosVentaYSusItems(idVenta As Int32, DataGrid As DataGridView)

        SQLCon.Open()
        Dim dataTableCombinada As New DataTable()
        Dim query As String = "
        SELECT 
            v.ID AS VentaID, 
            v.IDCliente, 
            v.Fecha, 
            v.Total, 
            vi.ID AS ItemID, 
            vi.IDProducto, 
            vi.PrecioUnitario, 
            vi.Cantidad, 
            vi.PrecioTotal 
        FROM ventas v
        LEFT JOIN ventasitems vi ON v.ID = vi.IDVenta
        WHERE v.ID = @IDVenta"

        Dim comando As New SqlCommand(query, SQLCon)
        Dim adapter As New SqlDataAdapter(comando)
        comando.Parameters.AddWithValue("@IDVenta", idVenta)

        adapter.Fill(dataTableCombinada)
        DataGrid.DataSource = dataTableCombinada

        formatearFilas(DataGrid)

        SQLCon.Close()
    End Sub

    Public Sub GenerarReporteDeUnaVenta(idVenta As Int32, DataGrid As DataGridView)

        SQLCon.Open()
        Dim dataTableCombinada As New DataTable()
        Dim query As String = "
        SELECT 
            v.ID AS VentaID, 
            cte.*,
            v.Fecha, 
            v.Total AS 'v.TotalDeVenta', 
            vi.ID AS ItemID, 
            vi.IDProducto, 
            vi.PrecioUnitario, 
            vi.Cantidad, 
            vi.PrecioTotal 
        FROM ventas v
        LEFT JOIN ventasitems vi ON v.ID = vi.IDVenta
        LEFT JOIN clientes cte ON v.IDCliente = cte.ID
        WHERE v.ID = @IDVenta"

        Dim comando As New SqlCommand(query, SQLCon)
        Dim adapter As New SqlDataAdapter(comando)
        comando.Parameters.AddWithValue("@IDVenta", idVenta)

        adapter.Fill(dataTableCombinada)
        DataGrid.DataSource = dataTableCombinada

        formatearFilas(DataGrid)

        SQLCon.Close()
    End Sub


    Public Sub GenerarReporteDeProductos(idVenta As Int32, DataGrid As DataGridView)

        SQLCon.Open()
        Dim dataTableCombinada As New DataTable()
        Dim query As String = "
        SELECT 
            v.ID AS VentaID, 
            cte.*,
            v.Fecha, 
            v.Total AS 'v.TotalDeVenta', 
            vi.ID AS ItemID, 
            vi.IDProducto, 
            vi.PrecioUnitario, 
            vi.Cantidad, 
            vi.PrecioTotal 
        FROM ventas v
        LEFT JOIN ventasitems vi ON v.ID = vi.IDVenta
        LEFT JOIN clientes cte ON v.IDCliente = cte.ID
        WHERE v.ID = @IDVenta"

        Dim comando As New SqlCommand(query, SQLCon)
        Dim adapter As New SqlDataAdapter(comando)
        comando.Parameters.AddWithValue("@IDVenta", idVenta)

        adapter.Fill(dataTableCombinada)
        DataGrid.DataSource = dataTableCombinada

        formatearFilas(DataGrid)

        SQLCon.Close()
    End Sub


    Public Sub GenerarReporteDeProductos(DataGrid As DataGridView)

        SQLCon.Open()
        Dim dataTableCombinada As New DataTable()

        Dim query As String = "
        SELECT 
            p.Nombre AS Producto,
            FORMAT(v.Fecha, 'yyyy-MM') AS Mes,
            SUM(vi.Cantidad) AS CantidadVendida
        FROM 
            productos p
        INNER JOIN 
            ventasitems vi ON p.ID = vi.IDProducto
        INNER JOIN 
            ventas v ON vi.IDVenta = v.ID
        GROUP BY 
            p.Nombre, FORMAT(v.Fecha, 'yyyy-MM')
        ORDER BY 
            p.Nombre, Mes;"



        Dim comando As New SqlCommand(query, SQLCon)
        Dim adapter As New SqlDataAdapter(comando)

        adapter.Fill(dataTableCombinada)
        DataGrid.DataSource = dataTableCombinada



        SQLCon.Close()
    End Sub

    Public Sub formatearFilas(Datagrid As DataGridView)
        For Each Fila As DataGridViewRow In Datagrid.Rows
            ' Si el campo "ItemID" está vacío, es una fila de la tabla "ventas"
            If IsDBNull(Fila.Cells("ItemID").Value) Then
                Fila.DefaultCellStyle.BackColor = Color.LightBlue ' Color para la venta
            Else
                Fila.DefaultCellStyle.BackColor = Color.LightGreen ' Color para los ítems
            End If
        Next
    End Sub

    Public Sub EncontrarProductoPorCategoria(categoria As String, dataGrid As DataGridView)
        EncontrarEnBaseDeDatos("Nombre", "Precio", "Categoria", "productos", "Categoria", categoria, dataGrid)
    End Sub
    Public Sub EncontrarProductoPorNombre(nombre As String, dataGrid As DataGridView)
        EncontrarEnBaseDeDatos("Nombre", "Precio", "Categoria", "productos", "Nombre", nombre, dataGrid)

    End Sub

    Public Sub EncontrarProductoPorPrecio(precio As String, dataGrid As DataGridView)
        EncontrarEnBaseDeDatos("Nombre", "Precio", "Categoria", "productos", "Precio", precio, dataGrid)
    End Sub

    Public Sub EncontrarEnBaseDeDatos(columna1 As String, columna2 As String, columna3 As String, NombreDeTabla As String, Columna As String, valorABuscar As Object, DataGrid As DataGridView)
        SQLCon.Open()
        Dim query As String = "SELECT ID, " & columna1 & ", " & columna2 & ", " & columna3 & " FROM " & NombreDeTabla & " WHERE " & Columna & " = @Valor"
        Dim dataTable As New DataTable()
        Dim commando As New SqlCommand(query, SQLCon)
        commando.Parameters.AddWithValue("@Valor", valorABuscar)

        Dim adapter As New SqlDataAdapter(commando)


        adapter.Fill(dataTable)

        DataGrid.DataSource = dataTable

        SQLCon.Close()
    End Sub
    Public Sub ModificarCliente(ID As Int32, nombre As String, telefono As String, correo As String)
        ModificarEnBaseDeDatosClienteOProductoPorID(ID, nombre, telefono, correo, "clientes")

    End Sub

    Private Sub ModificarEnBaseDeDatosClienteOProductoPorID(ID As Integer, columna1 As String, columna2 As String, columna3 As String, tablaAModificar As String)
        SQLCon.Open()
        Dim query As String
        If tablaAModificar = "clientes" Then
            query = "UPDATE clientes
        SET Cliente = '" & columna1 & "', telefono= '" & columna2 & "' , correo='" & columna3 & "  '
        WHERE ID = " & ID & ";"

        End If

        If tablaAModificar = "productos" Then
            query = "UPDATE productos
        SET Nombre = '" & columna1 & "', Precio = '" & columna2 & "' , Categoria ='" & columna3 & "  '
        WHERE ID = " & ID & ";"

        End If

        Dim comando As New SqlCommand(query, SQLCon)
        comando.ExecuteNonQuery()
        SQLCon.Close()
    End Sub

    Public Sub ModificarProductoPorID(ID As Int32, nombre As String, Precio As String, Categoria As String)
        ModificarEnBaseDeDatosClienteOProductoPorID(ID, nombre, Precio, Categoria, "productos")

    End Sub

    Public Sub ModificarProductoPorNombre(nombre As String, nuevoNombre As String, Precio As String, Categoria As String)
        ModificarEnBaseDeDatosProductoPorNombre(nombre, nuevoNombre, Precio, Categoria)

    End Sub

    Public Sub ModificarEnBaseDeDatosProductoPorNombre(nombre As String, columna1 As String, columna2 As String, columna3 As String)
        SQLCon.Open()
        Dim query As String

        query = "UPDATE productos
        SET Nombre = '" & columna1 & "', Precio = '" & columna2 & "' , Categoria ='" & columna3 & "  '
        WHERE Nombre = " & nombre & ";"



        Dim comando As New SqlCommand(query, SQLCon)
        comando.ExecuteNonQuery()
        SQLCon.Close()
    End Sub


    Public Sub DarDeBaja(ID As Int32, BaseDeDatos As String)
        SQLCon.Open()
        Dim query As String = "DELETE FROM " & BaseDeDatos & " WHERE ID ='" & ID & "';"
        Dim comando As New SqlCommand(query, SQLCon)
        comando.ExecuteNonQuery()


        If BaseDeDatos = "ventas" Then

            'hay que buscar los items con ese id y borrarlos'


            Dim queryParaBorrarItemsDeVentas As String = "DELETE FROM ventasitems WHERE IDVenta = '" & ID & "';"
            Dim comandoParaBorrarItems As New SqlCommand(queryParaBorrarItemsDeVentas, SQLCon)
            comandoParaBorrarItems.ExecuteNonQuery()

        End If

        SQLCon.Close()

    End Sub

    Public Sub DarDeBajaProductoPorNombre(nombre As String)
        SQLCon.Open()
        Dim query As String = "DELETE FROM productos WHERE Nombre ='" & nombre & "';"
        Dim comando As New SqlCommand(query, SQLCon)
        comando.ExecuteNonQuery()

        SQLCon.Close()

    End Sub

    Public Function DarDeAlta(nombre As String, telefono As String, correo As String) As Int32
        Return AgregarABaseDeDatos("clientes", nombre, telefono, correo)
    End Function


    'como dije antes es mejor pasarle el objeto y hacer doble dispatch pero hagamoslo asi mas legible por ahora'
    Public Function AdherirEsteItemAEsteIdDeVenta(Idventa As Int32, IdProducto As Int32, cantidad As Int32, precioUnitario As Int32, precioTotal As Int32)
        Dim IdDeVentaItem As Int32
        SQLCon.Open()

        Dim query As String = "INSERT INTO ventasitems
                            VALUES ( '" & Idventa & "', '" & IdProducto & " ', '" & precioUnitario & " ', '" & cantidad & " ', '" & precioTotal & " ' );"
        Dim comando As New SqlCommand(query, SQLCon)

        Dim rowsAffected As Integer = comando.ExecuteNonQuery()


        Dim queryParaId As String = "SELECT  TOP 1 * FROM ventasitems ORDER BY ID DESC"

        Dim commandoParaId As New SqlCommand(queryParaId, SQLCon)

        Dim reader As SqlDataReader = commandoParaId.ExecuteReader()

        If reader.Read() Then

            IdDeVentaItem = Convert.ToInt32(reader("ID"))

        End If


        SQLCon.Close()
        Return IdDeVentaItem


    End Function

    Public Function crearVentaVacia(iDCliente As Integer, fecha As Date) As Int32

        Return AgregarABaseDeDatos("ventas", iDCliente, fecha, 0)



    End Function

    Public Sub AltaAVentaCon(iD As Int32, total As Int32)
        SQLCon.Open()
        Dim query As String = "UPDATE ventas
        SET Total = '" & total & "'
        WHERE ID = " & iD & ";"
        Dim comando As New SqlCommand(query, SQLCon)
        comando.ExecuteNonQuery()
        SQLCon.Close()
    End Sub

    Public Sub EsteItemAEsteIdDeVenta(item As VentaItem, iD As Integer)
        item.UsarEsteIdDeVenta(iD)
    End Sub


    'posiblemente se pueda parametrizar el agregar producto o venta o cliente, si tengo tiempo veo como hacerlo, ya que hay mucho codigo repetido'
    Public Function AgregarProducto(nombre As String, precio As Integer, categoria As String) As Int32
        Return AgregarABaseDeDatos("productos", nombre, precio, categoria)

    End Function

    Private Function AgregarABaseDeDatos(baseDeDatos As String, columna1 As Object, columna2 As Object, columna3 As Object) As Integer
        Dim ID As Int32

        SQLCon.Open()

        Dim query As String = "INSERT INTO " & baseDeDatos & "
                            VALUES ( @columna1, @columna2 , @columna3 );"
        Dim comando As New SqlCommand(query, SQLCon)
        comando.Parameters.AddWithValue("@columna1", columna1)
        comando.Parameters.AddWithValue("@columna2", columna2)
        comando.Parameters.AddWithValue("@columna3", columna3)
        Dim rowsAffected As Integer = comando.ExecuteNonQuery()


        Dim queryParaId As String = "SELECT  TOP 1 * FROM " & baseDeDatos & " ORDER BY ID DESC"

        Dim commandoParaId As New SqlCommand(queryParaId, SQLCon)

        Dim reader As SqlDataReader = commandoParaId.ExecuteReader()

        If reader.Read() Then

            ID = Convert.ToInt32(reader("ID"))

        End If


        SQLCon.Close()
        Return ID
    End Function

    Public Function DarPrecioDeProducto(idProducto As Integer) As Integer
        Dim precioDeProducto As Int32
        SQLCon.Open()
        Dim queryParaId As String = "SELECT Precio FROM productos WHERE ID = " & idProducto & ""

        Dim commandoParaId As New SqlCommand(queryParaId, SQLCon)

        Dim reader As SqlDataReader = commandoParaId.ExecuteReader()

        If reader.Read() Then

            precioDeProducto = Convert.ToInt32(reader("Precio"))

        End If

        SQLCon.Close()
        Return precioDeProducto
    End Function

    Friend Sub MostrarTodaTabla(BaseDeDatos As String, dataGrid As DataGridView)
        SQLCon.Open()
        Dim query As String = "SELECT * FROM " & BaseDeDatos & ""

        Dim adapter As New SqlDataAdapter(query, SQLCon)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        dataGrid.DataSource = dt


        SQLCon.Close()
    End Sub

    Friend Sub listarItemsDeVenta(IDVenta As Int32, dataGrid As DataGridView)
        SQLCon.Open()
        Dim query As String = "SELECT * FROM ventasitems WHERE IDVenta = " & IDVenta & ""

        Dim commandoParaId As New SqlCommand(query, SQLCon)

        Dim adapter As New SqlDataAdapter(query, SQLCon)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        dataGrid.DataSource = datatable

        SQLCon.Close()



    End Sub

    Friend Sub CargarDetalleVentaParaModificar(IDVenta As Int32, DataGrid As DataGridView)
        SQLCon.Open()

        Dim query As String = "
    SELECT 
        vi.ID AS IDVentaItem,
        vi.IDProducto,
        p.Nombre AS Producto,
        vi.Cantidad,
        vi.PrecioUnitario,
        vi.PrecioTotal
    FROM 
        ventasitems vi
    INNER JOIN 
        productos p ON vi.IDProducto = p.ID
    WHERE 
        vi.IDVenta = @IDVenta;"


        Dim adapter As New SqlDataAdapter(query, SQLCon)
        Dim datatable As New DataTable()
        adapter.SelectCommand.Parameters.AddWithValue("@IDVenta", IDVenta)


        adapter.Fill(datatable)
        DataGrid.DataSource = datatable


        DataGrid.Columns("Cantidad").ReadOnly = False
        DataGrid.Columns("PrecioUnitario").ReadOnly = False



        SQLCon.Close()
    End Sub

    Friend Sub GuardarModifacionDeVenta(idVenta As Integer, nuevoTotal As Int32, dataGrid As DataGridView)
        SQLCon.Open()
        Dim transaction As SqlTransaction = SQLCon.BeginTransaction()

        For Each filas As DataGridViewRow In dataGrid.Rows
            Dim idVentaItem As Int32 = Convert.ToInt32(filas.Cells("IDVentaItem").Value)
            Dim cantidad As Int32 = Convert.ToDouble(filas.Cells("Cantidad").Value)
            Dim precioUnitario As Int32 = Convert.ToDouble(filas.Cells("PrecioUnitario").Value)
            Dim precioTotal As Int32 = Convert.ToDouble(filas.Cells("PrecioTotal").Value)

            Dim queryItem As String = "
                UPDATE ventasitems 
                SET 
                    Cantidad = @Cantidad, 
                    PrecioUnitario = @PrecioUnitario, 
                    PrecioTotal = @PrecioTotal 
                WHERE 
                    ID = @IDVentaItem;"

            Dim comandoItem As New SqlCommand(queryItem, SQLCon, transaction)
            comandoItem.Parameters.AddWithValue("@Cantidad", cantidad)
            comandoItem.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
            comandoItem.Parameters.AddWithValue("@PrecioTotal", precioTotal)
            comandoItem.Parameters.AddWithValue("@IDVentaItem", idVentaItem)
            comandoItem.ExecuteNonQuery()
            Next

            Dim totalGeneral As Int32 = nuevoTotal
            Dim queryVenta As String = "UPDATE ventas SET Total = @Total WHERE ID = @IDVenta;"
            Dim comandoVenta As New SqlCommand(queryVenta, SQLCon, transaction)
            comandoVenta.Parameters.AddWithValue("@Total", totalGeneral)
            comandoVenta.Parameters.AddWithValue("@IDVenta", idVenta)
            comandoVenta.ExecuteNonQuery()

            transaction.Commit()
            MessageBox.Show("Se guardo exitosamente la modificacion")


            SQLCon.Close()
    End Sub
End Class
