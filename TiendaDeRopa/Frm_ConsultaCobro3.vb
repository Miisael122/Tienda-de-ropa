Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_ConsultaCobro3

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Frm_ConsultaCobro3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f1, f2 As String
        f1 = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        f2 = DTP2.Value.Year & "/" & DTP2.Value.Month & "/" & DTP2.Value.Day



        dgcobro.Rows.Clear()
        R = "select c.idCobro, v.idVenta, cl.nombre, c.fecha, c.tipoCobro, v.saldo, cl.saldo, c.referencia, c.importe from cobros as c inner join ventas as v on c.idVenta=v.idVenta inner join clientes as cl on v.idCliente=cl.idCliente where c.fecha>='" & f1 & "' and c.fecha<= '" & f2 & "' and v.saldo>0"

        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgcobro.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8))

        End While
        lector.Close()

    End Sub
End Class