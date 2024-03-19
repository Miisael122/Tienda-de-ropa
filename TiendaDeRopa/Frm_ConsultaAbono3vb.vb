Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_ConsultaAbono3vb

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Frm_ConsultaAbono3vb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()


    End Sub

    Private Sub cmdConsulta_Click(sender As Object, e As EventArgs) Handles cmdConsulta.Click

        dgAbono.Rows.Clear()
        Dim F As String
        F = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        R = "select a.idAbono, a.idPedido, c.nombre, pr.nombre, a.fecha, p.estado, p.total, a.importe from abonos as a inner join pedidos as p on a.idPedido=p.idPedido inner join proveedores as pr on p.idProveedor=pr.idProveedor inner join clientes as c on p.idCliente=c.idCliente where a.fecha='" & F & "'"

        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgAbono.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))

        End While
        lector.Close()

    End Sub
End Class