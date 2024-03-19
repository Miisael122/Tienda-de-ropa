Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_ConsultaPago2

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Frm_ConsultaPago2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "Select p.idPago, c.idCompra, pr.nombre From pagos as p inner join compra as c on p.idCompra=c.idCompra inner join proveedores as pr on c.idProveedor=pr.idProveedor where c.saldo>0 "
        lector = comando.ExecuteReader

        While lector.Read()

            cboproveedor.Items.Add(lector(2))

        End While
        lector.Close()

    End Sub



    Private Sub cboproveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproveedor.SelectedIndexChanged

        dgpago.Rows.Clear()
        R = "select p.idPago, c.idCompra, pr.nombre, p.fecha, p.formapago, c.saldo, pr.saldo, p.referencia, p.importe from pagos as p inner join compra as c on p.IdCompra=c.IdCompra inner join proveedores as pr on c.idProveedor=pr.idProveedor where pr.nombre='" & cboproveedor.Text & "' and c.saldo>0"

        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgpago.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8))

        End While
        lector.Close()


    End Sub
End Class