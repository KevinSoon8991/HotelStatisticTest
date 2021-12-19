Imports MySql.Data.MySqlClient
Public Class xrStatisticHotel
    Dim dtKamar As DataTable

    Private Sub ReportHeader_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ReportHeader.BeforePrint



    End Sub


    Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint
        
    End Sub

    Private Sub xrStatisticHotel_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        'xrtbljudul.WidthF = 900
        'Dim xrtckamar As New XRTableCell
        'xrtckamar.Text = "Jenis Kamar"
        'xrtbljudul.Rows(0).Cells.Add(xrtckamar)


        'xrtcno.WidthF = 30
        'xrtckdtamu.WidthF = 150
        'xrtckdtamu.Text = "Kode Tamu"
        'xrtcnmtamu.WidthF = 200

        'xrtckamar.WidthF = 520


        'xrtbljudul2.WidthF = 900

        'gcSQL = "select * from kamar"
        'dtKamar = ExecDT()
        'Dim startindex As Integer = 3
        'For Each r As DataRow In dtKamar.Rows
        '    Dim xrtc As New XRTableCell
        '    xrtc.Text = r("jns_kamar")
        '    xrtc.Name = r("jns_kamar")
        '    xrtbljudul2.Rows(0).Cells.Add(xrtc)
        'Next

        'XrTableCell1.WidthF = 30
        'XrTableCell2.WidthF = 150
        'XrTableCell3.WidthF = 200

        'For Each r As DataRow In dtKamar.Rows
        '    xrtbljudul2.Rows(0).Cells(startindex).WidthF = xrtckamar.WidthF / dtKamar.Rows.Count
        '    startindex += 1
        'Next
    End Sub
End Class