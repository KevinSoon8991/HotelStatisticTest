Imports System.Data
Imports System.Linq
Public Class xrStatisticMakanan
    Dim dtMakanan, dtListMakanan, dtBfr, lap, dtreserve As DataTable
    Dim idx As Integer = 1
    Dim first As Boolean = True
    Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint
        gcSQL = "select * from jenis_makanan"
        dtMakanan = ExecDT()
        gcSQL = "select * from daftar_makanan"
        dtListMakanan = ExecDT()
        gcSQL = "SELECT a.kd_tamu, b.nm_tamu, a.kd_makanan, c.nm_makanan, c.jenis_makanan, COUNT(*) AS jlh FROM reservasi_makanan a " & _
                "INNER JOIN tamu b ON a.kd_tamu = b.kd_tamu INNER JOIN daftar_makanan c ON a.kd_makanan = c.kd_makanan " & _
                "GROUP BY a.kd_tamu, a.kd_makanan"
        dtreserve = ExecDT()
        Dim drcekreserve As DataRow() = dtreserve.Select(String.Format("jenis_makanan = '{0}'", GetCurrentColumnValue("jenis_makanan")))
        If Not drcekreserve.Any Then
            Exit Sub
        End If
        If Not first Then
            Dim xrtbldlt As XRTable = TryCast(Detail.FindControl("xrtbl", True), XRTable)
            Detail.Controls.Remove(xrtbldlt)
        End If

        Dim xrtbl As New XRTable
        xrtbl.Name = "xrtbl"
        xrtbl.WidthF = 500
        xrtbl.HeightF = 25
        Dim xrtblrow As New XRTableRow
        xrtbl.Rows.Add(xrtblrow)
        Dim xrtblcellno As New XRTableCell
        xrtblcellno.Text = "No. "

        Dim xrtblcelltamu As New XRTableCell
        xrtblcelltamu.Text = "Tamu"
        xrtblrow.Cells.Add(xrtblcellno)
        xrtblrow.Cells.Add(xrtblcelltamu)
        For Each r As DataRow In dtListMakanan.Select(String.Format("jenis_makanan = '{0}'", GetCurrentColumnValue("jenis_makanan")))
            Dim xrtc As New XRTableCell
            xrtc.Text = r("nm_makanan")
            xrtbl.Rows(0).Cells.Add(xrtc)
        Next
        xrtbl.Borders = DevExpress.XtraPrinting.BorderSide.All
        xrtbl.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        xrtbl.LocationF = New PointF(0, 50)
        xrtbl.Rows(0).Cells(0).WidthF = 50
        xrtbl.Rows(0).Cells(1).WidthF = 150
        Dim dr() As DataRow = dtListMakanan.Select(String.Format("jenis_makanan = '{0}'", GetCurrentColumnValue("jenis_makanan")))
        For i As Integer = 2 To dr.Length + 1 Step 1
            xrtbl.Rows(0).Cells(i).WidthF = 100
        Next
        Detail.Controls.Add(xrtbl)
        XrSubreport1.WidthF = xrtbl.WidthF


        lap = New DataTable
        With lap
            .Columns.Add("nm_tamu", GetType(String))
            For Each r As DataRow In dtListMakanan.Select(String.Format("jenis_makanan = '{0}'", GetCurrentColumnValue("jenis_makanan")))
                .Columns.Add(r("nm_makanan"), GetType(String))
            Next
            .Columns.Add("jenis_makanan", GetType(String))
        End With

        Dim grp = From t In dtreserve.AsEnumerable()
                  Group t By x = New With {Key .kd_tamu = t("kd_tamu"), Key .nm_tamu = t("nm_tamu"), _
                                           Key .jenis_makanan = t("jenis_makanan")} Into g = Group
                Select New With {.kd_tamu = x.kd_tamu, .nm_tamu = x.nm_tamu, .jenis_makanan = x.jenis_makanan}


        For Each r In grp
            Dim nr As DataRow = lap.NewRow()
            nr("nm_tamu") = r.nm_tamu
            For Each row As DataRow In dtreserve.Select(String.Format("kd_tamu = '{0}' and jenis_makanan = '{1}'", r.kd_tamu, r.jenis_makanan))
                For Each dc As DataColumn In lap.Columns
                    If dc.ColumnName = row("nm_makanan") Then
                        nr(dc.ColumnName) = row("jlh")
                    End If
                Next
            Next
            nr("jenis_makanan") = r.jenis_makanan
            lap.Rows.Add(nr)
        Next

        Dim xrdtl As New xrStatisticMakananDetail
        xrdtl.DataSource = lap

        For Each r As DataRow In dtListMakanan.Select(String.Format("jenis_makanan = '{0}'", GetCurrentColumnValue("jenis_makanan")))
            Dim xrtcdtl As New XRTableCell
            xrdtl.xrtbldtl.Rows(0).Cells.Add(xrtcdtl)
        Next

        Dim xrbindtamu As New XRBinding("Text", lap, "nm_tamu")
        xrdtl.xrtbldtl.Rows(0).Cells(0).Summary.Running = SummaryRunning.Report
        xrdtl.xrtbldtl.Rows(0).Cells(0).Summary.Func = SummaryFunc.RecordNumber
        xrdtl.xrtbldtl.Rows(0).Cells(1).DataBindings.Add(xrbindtamu)
        xrdtl.xrtbldtl.Rows(0).Cells(0).WidthF = 50
        xrdtl.xrtbldtl.Rows(0).Cells(1).WidthF = 150
        Dim idxmkn As Integer = 2
        For Each dc As DataColumn In lap.Columns
            If dc.ColumnName = "nm_tamu" Or dc.ColumnName = "jenis_makanan" Then Continue For
            Dim xrbind As New XRBinding("Text", lap, dc.ColumnName)
            xrdtl.xrtbldtl.Rows(0).Cells(idxmkn).DataBindings.Add(xrbind)
            xrdtl.xrtbldtl.Rows(0).Cells(idxmkn).WidthF = 100
            idxmkn += 1
        Next
        xrdtl.FilterString = "[jenis_makanan] = '" & GetCurrentColumnValue("jenis_makanan") & "'"
        XrSubreport1.ReportSource = xrdtl

        XrSubreport1.LocationF = New Point(0, 75)
    
        first = False
   

    End Sub
End Class