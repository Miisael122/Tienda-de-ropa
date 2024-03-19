Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_ConsultaCompra1

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Frm_ConsultaCompra1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "Select * From compra"
        lector = comando.ExecuteReader

        While lector.Read()

            cboidCompra.Items.Add(lector(0))

        End While
        lector.Close()

    End Sub

    Private Sub cboidCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboidCompra.SelectedIndexChanged
        dgcompra.Rows.Clear()
        R = "select c.idCompra, c.idProveedor, p.nombre, p.saldo, c.fecha, c.fechavto, c.subtotal, c.iva, c.total, c.saldo from compra as c inner join proveedores as p on c.idProveedor= p.idProveedor where c.idCompra=" & Val(cboidCompra.Text) & " and c.saldo>0"
        comando.CommandText = R
        lector = comando.ExecuteReader

        While lector.Read()

            dgcompra.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(6), lector(7), lector(8), lector(9))

        End While
        lector.Close()

    End Sub
End Class