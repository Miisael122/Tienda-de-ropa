Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_ConsultaVenta3

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Frm_ConsultaVenta3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dgVenta.Rows.Clear()
        Dim F As String

        F = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day

        R = "select v.idVenta, v.idCliente, c.nombre, c.saldo, v.fecha, v.fechavto, v.subtotal, v.iva, v.total, v.saldo from ventas as v inner join clientes as c on v.idCliente= c.idCliente where v.fechavto<='" & F & "' and v.saldo>0"
        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgVenta.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9))

        End While
        lector.Close()

    End Sub
End Class