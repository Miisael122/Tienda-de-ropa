Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_ConsultaCobro4

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Frm_ConsultaCobro4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "Select cl.nombre From cobros as c inner join ventas as v on c.idVenta=v.idVenta inner join clientes as cl on v.idCliente=cl.idCliente where v.saldo>0 group by cl.nombre"
        lector = comando.ExecuteReader

        While lector.Read()

            cbocliente.Items.Add(lector(0))

        End While
        lector.Close()

    End Sub

    Private Sub cboidcliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocliente.SelectedIndexChanged

        dgcobro.Rows.Clear()
        R = "select c.idCobro, v.idVenta, cl.nombre, c.fecha, c.tipoCobro, v.saldo, cl.saldo, c.referencia, c.importe from cobros as c inner join ventas as v on c.idVenta=v.idVenta inner join clientes as cl on v.idCliente=cl.idCliente where cl.nombre='" & cbocliente.Text & "' and v.saldo>0"

        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgcobro.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8))

        End While
        lector.Close()

    End Sub
End Class