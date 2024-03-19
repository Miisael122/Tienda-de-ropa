Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_ConsultaOfertas

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Private Sub Frm_ConsultaOfertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        cboEstado.Items.Add("Activo")
        cboEstado.Items.Add("Suspendido")
        cboEstado.Items.Add("Cancelado")

    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged

        Dim r As String

        r = "select o.idOferta, do.idProducto, p.nombre, do.descripcion, do.precioOferta, o.fechaInicio, o.fechaFin, do.estado
             from oferta as o inner join detoferta as do on o.idOferta=do.idOferta inner join productos as p on p.idProducto=do.idProducto where do.estado='" & cboEstado.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read()

            dgConsultaOferta.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(6))

        End While
        lector.Close()

    End Sub
End Class