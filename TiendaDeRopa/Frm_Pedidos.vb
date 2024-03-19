Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_Pedidos

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim r As String
    Dim estado As String
    Dim abono As Integer
    Dim cons As Integer


    Private Sub Frm_Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        comando.CommandText = "Select * From proveedores"
        lector = comando.ExecuteReader

        While lector.Read()

            cboProveedor.Items.Add(lector(1))

        End While
        lector.Close()

        abono = 0
        estado = "activo"

        comando.CommandText = "select Count(*) From detpedido"
        cons = comando.ExecuteScalar



    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged

        comando.CommandText = "Select * From clientes Where nombre='" & cboCliente.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidCliente.Text = lector(0)
        txtDomicilio.Text = lector(4)
        txtTelefono.Text = lector(2)
        txtSaldo.Text = lector(10)
        lector.Close()

    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectedIndexChanged

        comando.CommandText = "Select * From proveedores Where nombre='" & cboProveedor.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidProveedor.Text = lector(0)
        txtDomicilioo.Text = lector(3)
        txtTelefonoo.Text = lector(2)
        txtSaldoo.Text = lector(10)
        lector.Close()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim n As Integer

        comando.CommandText = "select Count(*) From pedidos"
        n = comando.ExecuteScalar + 1
        txtidPedido.Text = n
        txtestado.Text = estado

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click


        Dim importe As Double

        cons = cons + 1

        importe = Val(txtCantidad.Text) * Val(txtPrecio.Text)


        dgPedidos.Rows.Add(txtidPedido.Text, cons, txtDescripcion.Text, txtCantidad.Text, txtPrecio.Text, importe)


        txtTotal.Text = Val(txtTotal.Text) + importe


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        Dim c1, c3, c5 As Integer
        Dim c2 As String
        Dim c4 As Double
        Dim f1, f2 As String
        f1 = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        f2 = DTP2.Value.Year & "/" & DTP2.Value.Month & "/" & DTP2.Value.Day

        r = "insert into pedidos values(" & Val(txtidCliente.Text) & "," & Val(txtidProveedor.Text) & ",'" & f1 & "','" & f2 & "','" & txtestado.Text & "'," & Val(txtTotal.Text) & "," & abono & ")"

        comando.CommandText = r
        comando.ExecuteNonQuery()

        For i = 0 To dgPedidos.Rows.Count() - 2

            c1 = Val(dgPedidos.Item(0, i).Value)
            c2 = dgPedidos.Item(2, i).Value
            c3 = Val(dgPedidos.Item(3, i).Value)
            c4 = CDbl(dgPedidos.Item(4, i).Value)

            r = "insert into detpedido values(" & c1 & ",'" & c2 & "'," & c3 & "," & c4 & ")"

            comando.CommandText = r
            comando.ExecuteNonQuery()

        Next
        MsgBox("Se grabo el pedido")

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
    Private Sub Frm_Pedidos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class