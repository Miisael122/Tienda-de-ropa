Imports System.Data.SqlClient
Imports System.Configuration

Public Class Frm_Productos2

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Private Sub Frm_Productos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaDeRopaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.TiendaDeRopaDataSet.productos)

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
        comando.CommandText = "Select * From Categorias Where Concepto='" & cboCategorias.Text & "'"

        lector = comando.ExecuteReader
        lector.Read()
        txtIdCategorias.Text = lector(0)
        lector.Close()
    End Sub



    Private Sub cmd_Inicio_Click(sender As Object, e As EventArgs) Handles cmd_Inicio.Click
        ProductosBindingSource.MoveFirst()
    End Sub

    Private Sub cmd_Siguiente_Click(sender As Object, e As EventArgs) Handles cmd_Siguiente.Click
        ProductosBindingSource.MoveNext()
    End Sub

    Private Sub cmd_Anterior_Click(sender As Object, e As EventArgs) Handles cmd_Anterior.Click
        ProductosBindingSource.MovePrevious()
    End Sub

    Private Sub cmd_Ultimo_Click(sender As Object, e As EventArgs) Handles cmd_Ultimo.Click
        ProductosBindingSource.MoveLast()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        GroupBox1.Enabled = False
        cmd_Nuevo.Enabled = False
        cmd_Guardar.Enabled = True
        ProductosBindingSource.AddNew()
    End Sub

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click
        GroupBox1.Enabled = True
        cmd_Nuevo.Enabled = True
        cmd_Guardar.Enabled = False
        ProductosBindingSource.EndEdit()
        ProductosTableAdapter.Update(TiendaDeRopaDataSet.productos)
    End Sub

    Private Sub cmd_Salir_Click(sender As Object, e As EventArgs) Handles cmd_Salir.Click
        Me.Dispose()
    End Sub
    Private Sub Frm_Productos2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub

End Class