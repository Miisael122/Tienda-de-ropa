Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_Ventas
    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim saldox As Double

    Private Sub Frm_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        comando.CommandText = "Select * From productos"
        lector = comando.ExecuteReader

        While lector.Read()

            cboProducto.Items.Add(lector(2))

        End While
        lector.Close()

        For i = 0 To 30
            txtCantidad.Items.Add(i)
        Next i

        cboCondiciones.Items.Add("Credito")
        cboCondiciones.Items.Add("Contado")

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged

        comando.CommandText = "Select * From clientes Where nombre='" & cboCliente.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidCliente.Text = lector(0)
        txtDomicilio.Text = lector(4)
        txtCelular.Text = lector(3)
        txtSaldo.Text = lector(10)
        txtTelefono.Text = lector(2)
        txtPuntos.Text = lector(9)
        lector.Close()

    End Sub

    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged

        comando.CommandText = "Select * From productos Where nombre='" & cboProducto.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidProducto.Text = lector(0)
        txtPrecio.Text = lector(4)
        txtExistencias.Text = lector(6)
        lector.Close()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim n As Integer

        comando.CommandText = "select Count(*) From ventas"
        n = comando.ExecuteScalar + 1
        txtidVenta.Text = n

    End Sub

    Private Sub cdmAceptar_Click(sender As Object, e As EventArgs) Handles cdmAceptar.Click

        Dim importe, importef, iva As Double


        importe = CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text)
        iva = importe * 0.16
        importef = iva + importe

        txtSubtotal.Text = Val(txtSubtotal.Text) + CStr(importe)
        txtIva.Text = Val(txtIva.Text) + CStr(iva)
        txtTotal.Text = Val(txtTotal.Text) + CStr(importef)

        dgventas.Rows.Add(txtidVenta.Text, txtidProducto.Text, cboProducto.Text, txtCantidad.Text, importe)

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click

        Me.Dispose()

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        Dim c1, c3, puntos As Integer
        Dim c2, fecha, fechavto, R As String
        Dim c4 As Double

        fecha = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        fechavto = DTP2.Value.Year & "/" & DTP2.Value.Month & "/" & DTP2.Value.Day

        If cboCondiciones.Text = "Credito" Then

            R = "update clientes set saldo=saldo + " & CDbl(txtTotal.Text) & " where idCliente=" & Val(txtidCliente.Text)
            comando.CommandText = R
            comando.ExecuteNonQuery()
            saldox = CDbl(txtTotal.Text)

        Else
            saldox = 0

        End If

        R = "Insert into ventas values (" & Val(txtidCliente.Text) & ",'" & fecha & "','" & fechavto & "'," & Val(txtSubtotal.Text) & "," & Val(txtIva.Text) & "," & Val(txtTotal.Text) & "," & saldox & ",'" & cboCondiciones.Text & "','" & txtFactura.Text & "')"

        comando.CommandText = R
        comando.ExecuteNonQuery()

        puntos = puntos + Math.Truncate(txtTotal.Text / 100)

        R = "update clientes set puntos=puntos + " & puntos & " where idCliente=" & Val(txtidCliente.Text)
        comando.CommandText = R
        comando.ExecuteNonQuery()
        puntos = 0

        For i = 0 To dgventas.Rows.Count() - 2

            c1 = Val(dgventas.Item(0, i).Value)
            c2 = dgventas.Item(1, i).Value
            c3 = Val(dgventas.Item(3, i).Value)
            c4 = CDbl(dgventas.Item(4, i).Value)

            R = "Insert into detventa values(" & c1 & ",'" & c2 & "'," & c3 & "," & c4 & ")"

            comando.CommandText = R
            comando.ExecuteNonQuery()

            R = "Update productos set existencia=existencia -" & c3 & " where idProducto='" & c2 & "'"
            comando.CommandText = R
            comando.ExecuteNonQuery()

        Next i

    End Sub
    Private Sub Frm_Ventas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class