﻿Imports System.Data.SqlClient
Imports System.Configuration


Public Class Frm_ConsultaAbono1

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim R As String

    Private Sub Frm_ConsultaAbono1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "select * from abonos"
        lector = comando.ExecuteReader

        While lector.Read()

            cboAbono.Items.Add(lector(0))

        End While
        lector.Close()

    End Sub

    Private Sub cboAbono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAbono.SelectedIndexChanged

        dgAbono.Rows.Clear()

        R = "select a.idAbono, a.idPedido, c.nombre, pr.nombre, a.fecha, p.estado, p.total, a.importe from abonos as a inner join pedidos as p on a.idPedido=p.idPedido inner join proveedores as pr on p.idProveedor=pr.idProveedor inner join clientes as c on p.idCliente=c.idCliente where a.idAbono=" & Val(cboAbono.Text)

        comando.CommandText = R

        lector = comando.ExecuteReader
        While lector.Read()

            dgAbono.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))

        End While
        lector.Close()

    End Sub
End Class