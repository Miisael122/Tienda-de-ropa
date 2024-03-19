Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration


Public Class Frm_ReportePedidos2
    Private Sub Frm_ReportePedidos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEstado.Items.Add("Activo")
        cboEstado.Items.Add("Liquidado")
        cboEstado.Items.Add("Cancelado")
    End Sub
    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim f1 As String
        Dim f2 As String
        Dim edo As String
        f1 = DTP1.Value.Day & "/" & DTP1.Value.Month & "/" & DTP1.Value.Year
        f2 = DTP2.Value.Day & "/" & DTP2.Value.Month & "/" & DTP2.Value.Year
        edo = cboEstado.Text
        Dim Conexion As SqlConnection
        Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Conexion.Open()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = Conexion
        Adaptador.SelectCommand.CommandText = "REPORTEPEDIDOSPERIODO"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
        Dim param2 = New SqlParameter("@FF", SqlDbType.Date)
        Dim param3 = New SqlParameter("@EDO", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param3.Direction = ParameterDirection.Input
        param1.Value = CDate(f1)
        param2.Value = CDate(f2)
        param3.Value = edo

        Adaptador.SelectCommand.Parameters.Add(param1)

        Adaptador.SelectCommand.Parameters.Add(param2)

        Adaptador.SelectCommand.Parameters.Add(param3)
        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("FI", f1)
        Dim p2 As New ReportParameter("FF", f2)
        Dim ee As New ReportParameter("EDO", edo)

        Frm_Reportes.ReportViewer1.LocalReport.DataSources.Clear()

        Frm_Reportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)

        Frm_Reportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\misae\Documents\DISI\TiendaDeRopa\TiendaDeRopa\ReportePedidos2.rdlc"
        Frm_Reportes.ReportViewer1.LocalReport.SetParameters(
New ReportParameter() {p1, p2, ee})
        Frm_Reportes.ReportViewer1.RefreshReport()
        Frm_Reportes.Show()
        Conexion.Close()
    End Sub
End Class