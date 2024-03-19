Imports System.Data.SqlClient
Imports System.Configuration


Public Class Frm_ConsultaPago3

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f1, f2 As String
        f1 = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        f2 = DTP2.Value.Year & "/" & DTP2.Value.Month & "/" & DTP2.Value.Day

        dgpago.Rows.Clear()
        R = "select p.idPago, c.idCompra, pr.nombre, p.fecha, p.formapago, c.saldo, pr.saldo, p.referencia, p.importe from pagos as p inner join compra as c on p.IdCompra=c.IdCompra inner join proveedores as pr on c.idProveedor=pr.idProveedor where p.fecha>='" & f1 & "' and p.fecha<='" & f2 & "' and c.saldo>0"

        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgpago.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8))

        End While
        lector.Close()

    End Sub

    Private Sub Frm_ConsultaPago3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()
    End Sub
End Class