Public Class Frm_Productos
    Private Sub Frm_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaDeRopaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.TiendaDeRopaDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'TiendaDeRopaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.TiendaDeRopaDataSet.productos)


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

    Private Sub Frm_Productos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub

End Class