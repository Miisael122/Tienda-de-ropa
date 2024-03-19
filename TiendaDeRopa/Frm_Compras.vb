Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_Compras

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim saldox As Double



    Private Sub Frm_Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        comando.CommandText = "Select * From productos"
        lector = comando.ExecuteReader

        While lector.Read()

            cboProducto.Items.Add(lector(2))

        End While
        lector.Close()



        cboCondiciones.Items.Add("Credito")
        cboCondiciones.Items.Add("Contado")





    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectedIndexChanged

        comando.CommandText = "Select * From proveedores Where nombre='" & cboProveedor.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidProveedor.Text = lector(0)
        txtDomicilio.Text = lector(3)
        txtSaldo.Text = lector(10)
        lector.Close()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer

        comando.CommandText = "select Count(*) From compra"
            n = comando.ExecuteScalar + 1 'contador de total de registros
            txtidCompra.Text = n

    End Sub

    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        comando.CommandText = "Select * From productos Where nombre='" & cboProducto.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidProducto.Text = lector(0)
        txtMaximo.Text = lector(7)
        txtMinimo.Text = lector(8)
        txtExistencias.Text = lector(6)
        txtCostoant.Text = lector(5)
        lector.Close()

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim importe, importef, iva As Double


        importe = CDbl(cboCantidad.Text) * CDbl(txtNuevocosto.Text)
        iva = importe * 0.16
        importef = iva + importe
        txtSubtotal.Text = Val(txtSubtotal.Text) + CStr(importe)
        txtIva.Text = Val(txtIva.Text) + CStr(iva)
        txtTotal.Text = Val(txtTotal.Text) + CStr(importef)
        dgCompras.Rows.Add(txtidCompra.Text, txtidProducto.Text, cboProducto.Text, txtNuevocosto.Text, cboCantidad.Text, importe)



    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        Dim R As String
        Dim c4 As Double
        Dim c5, c1, c2 As Integer
        Dim fecha, fechavto As String

        fecha = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        fechavto = DTP2.Value.Year & "/" & DTP2.Value.Month & "/" & DTP2.Value.Day

        If cboCondiciones.Text = "Credito" Then

            R = "update proveedores set saldo=saldo + " & CDbl(txtTotal.Text) & " where idProveedor=" & Val(txtidProveedor.Text)
            comando.CommandText = R
            comando.ExecuteNonQuery()
            saldox = CDbl(txtTotal.Text)

        Else
            saldox = 0

        End If

        R = "Insert into compra values (" & Val(txtidProveedor.Text) & ",'" & txtFactura.Text & "','" & fecha & "','" & fechavto & "'," & Val(txtSubtotal.Text) & "," & Val(txtIva.Text) & "," & Val(txtTotal.Text) & "," & saldox & ",'" & cboCondiciones.Text & "')"

        comando.CommandText = R
        comando.ExecuteNonQuery()


        For i = 0 To dgCompras.Rows.Count() - 2


            c1 = Val(dgCompras.Item(0, i).Value)
            c2 = dgCompras.Item(1, i).Value
            c4 = CDbl(dgCompras.Item(3, i).Value)
            c5 = Val(dgCompras.Item(4, i).Value)


            R = "Insert into detcompra Values (" & c1 & ",'" & c2 & "'," & c5 & "," & c4 & ")"

            comando.CommandText = R
            comando.ExecuteNonQuery()

            Dim e2, c As Integer
            Dim cp As Double

            R = "Select * from productos where idProducto='" & c2 & "'"
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read() : e2 = lector(6) : c = lector(5) : cp = CDbl((e2 * c + c5 * c4) / (e2 + c5)) : lector.Close()

            R = "Update productos set existencia=existencia +" & c5 & ", costo=" & cp & " where idProducto='" & c2 & "'"
            comando.CommandText = R
            comando.ExecuteNonQuery()

        Next i

        MsgBox("Se grabo la compra")

    End Sub
    Private Sub Frm_Compras_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class