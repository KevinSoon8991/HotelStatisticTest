Public Class frm_statistic_makanan 
    Dim dtMakanan, dtReservasi As DataTable
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        gcSQL = "SELECT c.jenis_makanan " & _
                "from reservasi_makanan a INNER JOIN daftar_makanan c ON a.kd_makanan = c.kd_makanan GROUP BY c.jenis_makanan"
        dtMakanan = ExecDT()
        'gcSQL = "SELECT distinct(jenis_makanan) from reservasi_makanan"
        'dtReservasi = ExecDT()
        Dim xr As New xrStatisticMakanan
        With xr

            .DataSource = dtMakanan
            .DataMember = "food"
            '.XrSubreport1.ReportSource = xrDtl

            .CreateDocument()
            Dim printtool As New ReportPrintTool(xr)
            printtool.ShowRibbonPreview(UserLookAndFeel.Default)

        End With
    End Sub

    Private Sub frm_statistic_makanan_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConn()
    End Sub
End Class