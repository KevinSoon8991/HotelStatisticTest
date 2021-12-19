Imports MySql.Data.MySqlClient
Public Class frm_hotel_statistic
    Public dtRep, dtKamar As DataTable
    Dim ErrMsg As String
    Dim KamarColl As List(Of String)

    Private Sub frm_hotel_statistic_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConn()
        dtRep = New DataTable
        With dtRep
            .Columns.Add("Kode Tamu", GetType(String))
            .Columns.Add("Nama Tamu", GetType(String))
            gcSQL = "select * from kamar"
            dtKamar = ExecDT()
            KamarColl = New List(Of String)
            KamarColl.Clear()
            For Each r As DataRow In dtKamar.Rows
                .Columns.Add(r("jns_kamar"), GetType(String))
                KamarColl.Add(r("jns_kamar"))
            Next
        End With
        gcSQL = "SELECT a.kd_tamu, b.nm_tamu, a.jns_kamar, COUNT(*) AS frek FROM reservasi a " & _
                "INNER JOIN tamu b on a.kd_tamu = b.kd_tamu GROUP BY a.kd_tamu, a.jns_kamar"
        Dim dtT As DataTable = ExecDT()
        'gchotel.DataSource = dtT
        '===========================cara SQL (START)=======================================================
        gcSQL = "select * from tamu"
        Dim dtTamu As DataTable = ExecDT()
        '================================END===============================================================

        For Each r As DataRow In dtTamu.Rows
            Dim nRep As DataRow = dtRep.NewRow()
            nRep("Kode Tamu") = r("kd_tamu")
            nRep("Nama Tamu") = r("nm_tamu")
            For Each r_reservasi As DataRow In dtT.Select(String.Format("kd_tamu = '{0}'", r("kd_tamu")))
                For Each r_kamar As DataRow In dtKamar.Rows
                    If r_reservasi("jns_kamar") = r_kamar("jns_kamar") Then
                        nRep(r_kamar("jns_kamar")) = r_reservasi("frek")
                    End If
                Next
            Next
            dtRep.Rows.Add(nRep)
        Next
        gchotel.DataSource = dtRep
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim xr As New xrStatisticHotel
        With xr

            .DataSource = dtRep
          

            '==============================================INITIALIZE TABLE WIDTH=================================================================
            .xrtbljudul.WidthF = 900
            .xrtbldetail.WidthF = 900
            '===============================================PROGRAMMATICALLY ADD TABLE CELL=======================================================

            Dim xrtckamar As New XRTableCell()
            xrtckamar.Text = "Jenis Kamar"
            .xrtbljudul.Rows(0).Cells.Add(xrtckamar)

            Dim startindex As Integer = 3

            For Each r As DataRow In dtKamar.Rows
                Dim xrjdlkamar As New XRTableCell
                xrjdlkamar.Text = r("jns_kamar")
                Dim xrdtl As New XRTableCell
                .xrtbljudul.Rows(1).Cells.Add(xrjdlkamar)
                .xrtbldetail.Rows(0).Cells.Add(xrdtl)
            Next

            '=================================================ADD BINDING DATASOURCE==========================================================
            Dim xrbind_kdtamu As New XRBinding("Text", dtRep, "Kode Tamu")
            Dim xrbind_nmtamu As New XRBinding("Text", dtRep, "Nama Tamu")

            .xrtcdtlkdtamu.DataBindings.Add(xrbind_kdtamu)
            .xrtcdtlnmtamu.DataBindings.Add(xrbind_nmtamu)

            For Each r As DataRow In dtKamar.Rows
                Dim xrbind_kmr As New XRBinding("Text", dtRep, r("jns_kamar"))
                .xrtbldetail.Rows(0).Cells(startindex).DataBindings.Add(xrbind_kmr)
                startindex += 1
            Next
            '==========================================================SET CELL WIDTH=====================================================
            .xrtcno.WidthF = 30
            .xrtckdtamu.WidthF = 150
            .xrtcnmtamu.WidthF = 200
            .xrtbljudul.Rows(0).Cells(3).WidthF = 520
            .xrtcdtlno.WidthF = 30
            .xrtcdtlkdtamu.WidthF = 150
            .xrtcdtlnmtamu.WidthF = 200

            .XrTableCell7.WidthF = 30
            .XrTableCell8.WidthF = 150
            .XrTableCell9.WidthF = 200


            For i As Integer = 3 To dtKamar.Rows.Count + 2
                .xrtbljudul.Rows(1).Cells(i).WidthF = 520 / dtKamar.Rows.Count
                .xrtbldetail.Rows(0).Cells(i).WidthF = 520 / dtKamar.Rows.Count
            Next

            
           
            .CreateDocument()
            Dim printtool As New ReportPrintTool(xr)
            printtool.ShowRibbonPreview(UserLookAndFeel.Default)

        End With
    End Sub
End Class