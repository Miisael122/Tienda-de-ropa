Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class Frm_ReportePagos1

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim r As String

    Private Sub Frm_ReporteCliente1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = "server=.; DataBase=TiendaDeRopa; Integrated Security=SSPI"
        conexion.Open()

        comando.CommandText = "Select nombre From proveedores"
        lector = comando.ExecuteReader

        While lector.Read()

            cboNombre.Items.Add(lector(0))

        End While
        lector.Close()
        conexion.Close()

    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click

        Dim nombre As String
        nombre = cboNombre.Text
        Dim Conexion As SqlConnection
        Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Conexion.Open()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = Conexion
        Adaptador.SelectCommand.CommandText = "REPORPAGOSPROVEEDORES"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@NOM", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param1.Value = nombre
        Adaptador.SelectCommand.Parameters.Add(param1)


        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("NOM", nombre)

        Frm_Reportes.ReportViewer1.LocalReport.DataSources.Clear()

        Frm_Reportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)

        Frm_Reportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\misae\Documents\DISI\TiendaDeRopa\TiendaDeRopa\ReportePagos1.rdlc"
        Frm_Reportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
        Frm_Reportes.ReportViewer1.RefreshReport()
        Frm_Reportes.Show()
        Conexion.Close()

    End Sub
End Class