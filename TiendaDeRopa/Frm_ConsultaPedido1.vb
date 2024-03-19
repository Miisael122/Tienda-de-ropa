Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_ConsultaPedido1

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Frm_ConsultaAbono1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "select * from pedidos"
        lector = comando.ExecuteReader

        While lector.Read()

            cboPedido.Items.Add(lector(0))

        End While
        lector.Close()

    End Sub

    Private Sub cboPedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedido.SelectedIndexChanged

        dgabono.Rows.Clear()

        R = "select p.idPedido, pr.nombre, c.nombre, p.fecha, p.fechaaproxent, p.estado, p.total, p.abono from pedidos as p inner join proveedores as pr on p.idProveedor=pr.idProveedor inner join clientes as c on p.idCliente=c.idCliente where p.idPedido=" & Val(cboPedido.Text)

        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgabono.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))

        End While
        lector.Close()

    End Sub
End Class