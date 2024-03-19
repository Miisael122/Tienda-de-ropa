Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_Cobros

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim r As String

    Private Sub Frm_Cobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        cboCondicion.Items.Add("Cheque")
        cboCondicion.Items.Add("Transferencia")
        cboCondicion.Items.Add("Efectivo")

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        dgCobro.Rows.Clear()
        cboidVenta.Items.Clear()
        comando.CommandText = "Select * From clientes Where nombre='" & cboCliente.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidCliente.Text = lector(0)
        txtDomicilio.Text = lector(4)
        txtTelefono.Text = lector(2)
        txtSaldo.Text = lector(10)
        lector.Close()

        r = "Select idVenta, factura, fecha, fechavto, total, saldo from ventas where idCliente=" & Val(txtidCliente.Text) & " and saldo>0"
        comando.CommandText = r
        lector = comando.ExecuteReader

        While lector.Read()

            dgCobro.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            cboidVenta.Items.Add(lector(0))

        End While
        lector.Close()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim n As Integer

        comando.CommandText = "select Count(*) From cobros"
        n = comando.ExecuteScalar + 1
        txtidPago.Text = n

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        Dim f As String
        f = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day

        r = "Insert into cobros values (" & Val(cboidVenta.Text) & ",'" & f & "','" & cboCondicion.Text & "','" & txtReferencia.Text & "'," & CDbl(txtImporte.Text) & ")"

        comando.CommandText = r
        comando.ExecuteNonQuery()

        r = "Update clientes set saldo= saldo - " & CDbl(txtImporte.Text) & " where idCliente=" & Val(txtidCliente.Text)
        comando.CommandText = r
        comando.ExecuteNonQuery()

        r = "Update ventas set saldo= saldo - " & CDbl(txtImporte.Text) & " where idVenta=" & Val(cboidVenta.Text)
        comando.CommandText = r
        comando.ExecuteNonQuery()
        MsgBox("Se grabo el cobro")

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click

        Me.Dispose()
    End Sub
    Private Sub Frm_Cobros_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class