Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_Pagos

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim r As String

    Private Sub Frm_Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim n As New Globalization.CultureInfo("es-ES")
        n.NumberFormat.CurrencyDecimalSeparator = "."
        n.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = n

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "Select * From proveedores"
        lector = comando.ExecuteReader

        While lector.Read()

            cboProveedor.Items.Add(lector(1))

        End While
        lector.Close()

        cboCondicion.Items.Add("Cheque")
        cboCondicion.Items.Add("Transferencia")
        cboCondicion.Items.Add("Efectivo")

    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectedIndexChanged
        dgpagos.Rows.Clear()
        cboidCompra.Items.Clear()
        comando.CommandText = "Select * From proveedores Where nombre='" & cboProveedor.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidProveedor.Text =lector(0)
        txtDomicilio.Text = lector(3)
        txtTelefono.Text = lector(2)
        txtSaldo.Text = lector(10)
        lector.Close()

        r = "Select idCompra, factura, fecha, fechavto, total, saldo from compra where idProveedor=" & Val(txtidProveedor.Text) & " and saldo>0"
        comando.CommandText = r
        lector = comando.ExecuteReader

        While lector.Read()

            dgpagos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            cboidCompra.Items.Add(lector(0))

        End While
        lector.Close()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim n As Integer

        comando.CommandText = "select Count(*) From pagos"
        n = comando.ExecuteScalar + 1
        txtidPago.Text = n

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        Dim f As String
        f = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day

        r = "Insert into pagos values (" & Val(cboidCompra.Text) & ",'" & f & "','" & cboCondicion.Text & "','" & txtReferencia.Text & "'," & CDbl(txtImporte.Text) & ")"

        comando.CommandText = r
        comando.ExecuteNonQuery()

        r = "Update proveedores set saldo= saldo - " & CDbl(txtImporte.Text) & " where idProveedor=" & Val(txtidProveedor.Text)
        comando.CommandText = r
        comando.ExecuteNonQuery()

        r = "Update compra set saldo= saldo - " & CDbl(txtImporte.Text) & " where idCompra=" & Val(cboidCompra.Text)
        comando.CommandText = r
        comando.ExecuteNonQuery()
        MsgBox("Se grabo la compra")

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
    Private Sub Frm_Pagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class