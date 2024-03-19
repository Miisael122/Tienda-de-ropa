Imports System.Data.SqlClient
Imports System.Configuration


Public Class Frm_ConsultaPedido3

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String


    Private Sub Frm_ConsultaPedido3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "select * from clientes"
        lector = comando.ExecuteReader

        While lector.Read()

            cbocliente.Items.Add(lector(1))

        End While
        lector.Close()

        cboestado.Items.Add("activo")
        cboestado.Items.Add("liquidado")
        cboestado.Items.Add("cancelado")

    End Sub

    Private Sub cboestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboestado.SelectedIndexChanged

        dgabono.Rows.Clear()

        R = "select p.idPedido, pr.nombre, c.nombre, p.fecha, p.fechaaproxent, p.estado, p.total, p.abono from pedidos as p inner join proveedores as pr on p.idProveedor=pr.idProveedor inner join clientes as c on p.idCliente=c.idCliente where c.nombre='" & cbocliente.Text & "' and p.estado='" & cboestado.Text & "'"

        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgabono.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))

        End While
        lector.Close()

    End Sub
End Class