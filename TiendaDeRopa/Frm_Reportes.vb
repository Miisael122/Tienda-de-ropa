Public Class Frm_Reportes
    Private Sub Frm_Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class