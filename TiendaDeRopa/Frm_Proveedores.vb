Public Class Frm_Proveedores
    Private Sub Frm_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaDeRopaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.TiendaDeRopaDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'TiendaDeRopaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.TiendaDeRopaDataSet.proveedores)


    End Sub

    Private Sub cmd_Inicio_Click(sender As Object, e As EventArgs) Handles cmd_Inicio.Click
        ProveedoresBindingSource.MoveFirst()
    End Sub

    Private Sub cmd_Siguiente_Click(sender As Object, e As EventArgs) Handles cmd_Siguiente.Click
        ProveedoresBindingSource.MoveNext()
    End Sub

    Private Sub cmd_Anterior_Click(sender As Object, e As EventArgs) Handles cmd_Anterior.Click
        ProveedoresBindingSource.MovePrevious()
    End Sub

    Private Sub cmd_Ultimo_Click(sender As Object, e As EventArgs) Handles cmd_Ultimo.Click
        ProveedoresBindingSource.MoveLast()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        GroupBox1.Enabled = False
        cmd_Nuevo.Enabled = False
        cmd_Guardar.Enabled = True
        ProveedoresBindingSource.AddNew()
    End Sub

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click
        GroupBox1.Enabled = True
        cmd_Nuevo.Enabled = True
        cmd_Guardar.Enabled = False
        ProveedoresBindingSource.EndEdit()
        ProveedoresTableAdapter.Update(TiendaDeRopaDataSet.proveedores)
    End Sub

    Private Sub cmd_Salir_Click(sender As Object, e As EventArgs) Handles cmd_Salir.Click
        Me.Dispose()
    End Sub
    Private Sub Frm_Proveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class