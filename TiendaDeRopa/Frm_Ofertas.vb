Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_Ofertas

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Private Sub Frm_Ofertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "Select * From categorias"
        lector = comando.ExecuteReader

        While lector.Read()

            cboCategorias.Items.Add(lector(1))

        End While
        lector.Close()



    End Sub

    Private Sub cboCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategorias.SelectedIndexChanged
        cboProductos.Items.Clear()
        comando.CommandText = "Select * From categorias Where concepto='" & cboCategorias.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtIdCategoria.Text = lector(0)
        lector.Close()

        comando.CommandText = "Select * From productos Where idCategoria=" & txtIdCategoria.Text
        lector = comando.ExecuteReader
        While lector.Read()

            cboProductos.Items.Add(lector(2))

        End While
        lector.Close()
    End Sub

    Private Sub cboProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductos.SelectedIndexChanged
        comando.CommandText = "Select * From productos Where Nombre='" & cboProductos.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtidProducto.Text = lector(0)
        txtprecio.Text = lector(4)
        lector.Close()


    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        dgOfertas.Rows.Add(txtidOferta.Text, txtidProducto.Text, cboProductos.Text, txtPrecioOferta.Text, txtDescripcion.Text, "Activo")
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim N As Integer
        comando.CommandText = "select Count(*) From oferta"
        N = comando.ExecuteScalar + 1 'contador de total de registros
        txtidOferta.Text = N
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        MsgBox(dgOfertas.Rows.Count)
        MsgBox(DTP1.Value.Date)
        MsgBox(DTP2.Value.Date)
        MsgBox(dgOfertas.Rows.Count)

        Dim R As String
        MsgBox(dgOfertas.Rows.Count)
        Dim c1 As Integer
        Dim c2, c4 As String
        Dim c3 As Double
        Dim c5 As String
        Dim FI As String
        Dim FF As String

        FI = DTP1.Value.Year & "/" & DTP1.Value.Month & "/" & DTP1.Value.Day
        FF = DTP2.Value.Year & "/" & DTP2.Value.Month & "/" & DTP2.Value.Day
        comando.CommandText = "Insert into oferta values('" & FI & "','" & FF & "')"
        comando.ExecuteNonQuery()

        For i = 0 To dgOfertas.Rows.Count() - 2

            c1 = Val(dgOfertas.Item(0, i).Value)
            c2 = dgOfertas.Item(1, i).Value
            c3 = CDbl(dgOfertas.Item(3, i).Value)
            c4 = dgOfertas.Item(4, i).Value
            c5 = dgOfertas.Item(5, i).Value
            R = "Insert into detoferta Values (" & c1 & ",'" & c2 & "'," & c3 & ",'" & c4 & "','" & c5 & "')"
            MsgBox(R)
            comando.CommandText = R
            comando.ExecuteNonQuery()
        Next i


    End Sub

    Private Sub cmd_Salir_Click(sender As Object, e As EventArgs) Handles cmd_Salir.Click
        Me.Dispose()
    End Sub
    Private Sub Frm_Ofertas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class