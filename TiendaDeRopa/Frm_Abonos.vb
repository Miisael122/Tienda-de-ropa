Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_Abonos

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim r As String

    Private Sub Frm_Abonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim n As New Globalization.CultureInfo("es-ES")
        n.NumberFormat.CurrencyDecimalSeparator = "."
        n.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = n

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "Select * From clientes"
        lector = comando.ExecuteReader

        While lector.Read()

            cboCliente.Items.Add(lector(1))

        End While
        lector.Close()

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged

        dgabono.Rows.Clear()
        cboPedido.Items.Clear()

        comando.CommandText = "Select * From clientes Where nombre='" & cboCliente.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidCliente.Text = lector(0)
        lector.Close()

        r = "update pedidos set estado= 'liquidado' where abono=total"

        comando.CommandText = r
        comando.ExecuteNonQuery()

        r = "select p.idPedido, p.idProveedor, pr.nombre, p.total, p.abono, p.total - p.abono as saldo, p.estado from pedidos as p inner join proveedores as pr on p.idProveedor=pr.idProveedor where p.idCliente=" & Val(txtidCliente.Text)

        comando.CommandText = r
        lector = comando.ExecuteReader



        While lector.Read()

            dgabono.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            cboPedido.Items.Add(lector(0))

        End While
        lector.Close()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer

        comando.CommandText = "select Count(*) From abonos"
        n = comando.ExecuteScalar + 1
        txtidAbono.Text = n
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        Dim f As String
        f = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day

        r = "insert into abonos values(" & Val(cboPedido.Text) & ",'" & f & "'," & CDbl(txtImporte.Text) & ")"

        comando.CommandText = r
        comando.ExecuteNonQuery()

        r = "update pedidos set abono=abono +" & CDbl(txtImporte.Text) & " where idPedido=" & Val(cboPedido.Text)

        comando.CommandText = r
        comando.ExecuteNonQuery()





        MsgBox("Se grabo el abono")
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
    Private Sub Frm_Abonos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class