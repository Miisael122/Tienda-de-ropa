Public Class Frm_Categorias

    Private Sub Frm_Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaDeRopaDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.TiendaDeRopaDataSet.categorias)
        'TODO: esta línea de código carga datos en la tabla 'TiendaDeRopaDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.TiendaDeRopaDataSet.categorias)


    End Sub

    Private Sub cmd_Inicio_Click(sender As Object, e As EventArgs) Handles cmd_Inicio.Click
        CategoriasBindingSource.MoveFirst()
    End Sub

    Private Sub cmd_Siguiente_Click(sender As Object, e As EventArgs) Handles cmd_Siguiente.Click
        CategoriasBindingSource.MoveNext()
    End Sub

    Private Sub cmd_Anterior_Click(sender As Object, e As EventArgs) Handles cmd_Anterior.Click
        CategoriasBindingSource.MovePrevious()
    End Sub

    Private Sub cmd_Ultimo_Click(sender As Object, e As EventArgs) Handles cmd_Ultimo.Click
        CategoriasBindingSource.MoveLast()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        GroupBox1.Enabled = False
        cmd_Nuevo.Enabled = False
        cmd_Guardar.Enabled = True
        CategoriasBindingSource.AddNew()
    End Sub

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click
        GroupBox1.Enabled = True
        cmd_Nuevo.Enabled = True
        cmd_Guardar.Enabled = False
        CategoriasBindingSource.EndEdit()
        CategoriasTableAdapter.Update(TiendaDeRopaDataSet.categorias)
    End Sub

    Private Sub cmd_Salir_Click(sender As Object, e As EventArgs) Handles cmd_Salir.Click
        Me.Dispose()
    End Sub

    Private Sub SqlConnection1_InfoMessage(sender As Object, e As SqlClient.SqlInfoMessageEventArgs)

    End Sub

    Private Sub CategoriasBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Frm_Categorias_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class