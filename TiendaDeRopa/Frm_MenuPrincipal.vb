Public Class Frm_MenuPrincipal
    Private Sub Frm_MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Frm_Categorias.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Frm_Clientes.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Frm_Proveedores.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Frm_Productos.Show()
    End Sub

    Private Sub Productos2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Productos2ToolStripMenuItem.Click
        Frm_Productos2.Show()
    End Sub

    Private Sub OfertasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfertasToolStripMenuItem.Click
        Frm_Ofertas.Show()
    End Sub

    Private Sub ConsultaOfertaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaOfertaToolStripMenuItem.Click
        Frm_ConsultaOfertas.Show()
    End Sub

    Private Sub OfertasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OfertasToolStripMenuItem1.Click
        Frm_Compras.Show()
    End Sub


    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Frm_Ventas.Show()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        Frm_Pagos.Show()
    End Sub

    Private Sub ConsultaCompraPorIdToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConsultaCompraPorIdToolStripMenuItem.Click
        Frm_ConsultaCompra1.Show()
    End Sub

    Private Sub ConsultaCompraPorFechasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConsultaCompraPorFechasToolStripMenuItem.Click
        Frm_ConsultaCompra2.Show()
    End Sub

    Private Sub ConsuraCompraPorCompraAVencerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsuraCompraPorCompraAVencerToolStripMenuItem.Click
        Frm_ConsultaCompra3.Show()
    End Sub

    Private Sub ConsultaVentaPorIdToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConsultaVentaPorIdToolStripMenuItem.Click
        Frm_ConsultaVenta1.Show()
    End Sub

    Private Sub ConsultaVentaPorFechasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaVentaPorFechasToolStripMenuItem2.Click
        Frm_ConsultaVenta2.Show()
    End Sub

    Private Sub ConsultaVentaPorVentasAVencerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaVentaPorVentasAVencerToolStripMenuItem.Click
        Frm_ConsultaVenta3.Show()
    End Sub

    Private Sub ConsultaPorIdPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorIdPagoToolStripMenuItem.Click
        Frm_ConsultaPago1.Show()
    End Sub

    Private Sub ConsultaPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorProveedorToolStripMenuItem.Click
        Frm_ConsultaPago2.Show()
    End Sub

    Private Sub ConsultaPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorPeriodoToolStripMenuItem.Click
        Frm_ConsultaPago3.Show()
    End Sub

    Private Sub ConsultaPorIdCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorIdCompraToolStripMenuItem.Click
        Frm_ConsultaPago4.Show()
    End Sub

    Private Sub CobrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobrosToolStripMenuItem.Click
        Frm_Cobros.Show()
    End Sub

    Private Sub ConsultaPorIdCobroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorIdCobroToolStripMenuItem.Click
        Frm_ConsultaCobro1.Show()
    End Sub

    Private Sub ConsultaPorIdVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorIdVentaToolStripMenuItem.Click
        Frm_ConsultaCobro2.Show()
    End Sub

    Private Sub ConsultaPorPeriodoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaPorPeriodoToolStripMenuItem1.Click
        Frm_ConsultaCobro3.Show()
    End Sub

    Private Sub ConsultaPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorClienteToolStripMenuItem.Click
        Frm_ConsultaCobro4.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        Frm_Pedidos.Show()
    End Sub

    Private Sub AbonosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonosToolStripMenuItem.Click
        Frm_Abonos.Show()
    End Sub

    Private Sub ConsultaPorPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorPedidoToolStripMenuItem.Click
        Frm_ConsultaPedido1.Show()
    End Sub

    Private Sub ConsultaPorProvYEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorProvYEstadoToolStripMenuItem.Click
        Frm_ConsultaPedido2.Show()
    End Sub

    Private Sub ConsultaPorClienteYEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorClienteYEstadoToolStripMenuItem.Click
        Frm_ConsultaPedido3.Show()
    End Sub

    Private Sub ConsultaPorAbonoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorAbonoToolStripMenuItem.Click
        Frm_ConsultaAbono1.Show()
    End Sub

    Private Sub ConsultaPorClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaPorClienteToolStripMenuItem1.Click
        Frm_ConsultaAbono2.Show()
    End Sub

    Private Sub ConsultaPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorFechaToolStripMenuItem.Click
        Frm_ConsultaAbono3vb.Show()
    End Sub

    Private Sub ReportePorNombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorNombreToolStripMenuItem.Click
        Frm_ReporteCliente1.Show()
    End Sub

    Private Sub ReportePorCiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorCiudadToolStripMenuItem.Click
        Frm_ReporteProveedores1.Show()
    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        Frm_ReporteCliente2.Show()
    End Sub

    Private Sub ReporteDeAbonosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAbonosToolStripMenuItem.Click
        Frm_ReporteCliente3.Show()
    End Sub

    Private Sub ReporteDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeComprasToolStripMenuItem.Click
        Frm_ReporteProveedor2.Show()

    End Sub

    Private Sub ReporteDePagosPorProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDePagosPorProveedoresToolStripMenuItem.Click
        Frm_ReportePagos1.Show()
    End Sub

    Private Sub ReporteDePagosPorPeriodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDePagosPorPeriodosToolStripMenuItem.Click
        Frm_ReportePagos2.Show()
    End Sub

    Private Sub ReportePorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorClienteToolStripMenuItem.Click
        Frm_ReportePedidos1.Show()
    End Sub

    Private Sub ReportePorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorPeriodoToolStripMenuItem.Click
        Frm_ReportePedidos2.Show()
    End Sub

    Private Sub ReporteDeCobrosPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCobrosPorClienteToolStripMenuItem.Click
        Frm_ReporteCobros1.Show()
    End Sub

    Private Sub ReporteDeCobrosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCobrosPorPeriodoToolStripMenuItem.Click
        Frm_ReporteCobros2.Show()
    End Sub

    Private Sub ReportePorPeriodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorPeriodosToolStripMenuItem.Click
        Frm_ReporteCompra.Show()
    End Sub

    Private Sub Frm_MenuPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            System.Diagnostics.Process.Start("C:\Users\misae\Documents\DISI\TiendaDeRopa\ayuda.chm")
        End If
    End Sub
End Class
