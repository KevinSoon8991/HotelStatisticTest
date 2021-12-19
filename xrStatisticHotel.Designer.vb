<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrStatisticHotel
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrtbldetail = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrtcdtlno = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrtcdtlkdtamu = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrtcdtlnmtamu = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DsStatisticHotel1 = New Hotel_Statistic.dsStatisticHotel()
        Me.xrtbljudul = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrtcno = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrtckdtamu = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrtcnmtamu = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.xrtbldetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStatisticHotel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrtbljudul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrtbldetail})
        Me.Detail.HeightF = 30.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrtbldetail
        '
        Me.xrtbldetail.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrtbldetail.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrtbldetail.Name = "xrtbldetail"
        Me.xrtbldetail.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.xrtbldetail.SizeF = New System.Drawing.SizeF(260.8333!, 25.0!)
        Me.xrtbldetail.StylePriority.UseBorders = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtcdtlno, Me.xrtcdtlkdtamu, Me.xrtcdtlnmtamu})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'xrtcdtlno
        '
        Me.xrtcdtlno.Name = "xrtcdtlno"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.xrtcdtlno.Summary = XrSummary1
        Me.xrtcdtlno.Weight = 0.29583343505859372R
        '
        'xrtcdtlkdtamu
        '
        Me.xrtcdtlkdtamu.Name = "xrtcdtlkdtamu"
        Me.xrtcdtlkdtamu.Weight = 0.91249992370605482R
        '
        'xrtcdtlnmtamu
        '
        Me.xrtcdtlnmtamu.Name = "xrtcdtlnmtamu"
        Me.xrtcdtlnmtamu.Weight = 1.4000000762939455R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 4.166667!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrtbljudul, Me.XrLabel1})
        Me.ReportHeader.HeightF = 103.3333!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(900.0!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "STATISTIK RESERVASI HOTEL"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DsStatisticHotel1
        '
        Me.DsStatisticHotel1.DataSetName = "dsStatisticHotel"
        Me.DsStatisticHotel1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'xrtbljudul
        '
        Me.xrtbljudul.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrtbljudul.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrtbljudul.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 53.33331!)
        Me.xrtbljudul.Name = "xrtbljudul"
        Me.xrtbljudul.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4})
        Me.xrtbljudul.SizeF = New System.Drawing.SizeF(260.8333!, 50.0!)
        Me.xrtbljudul.StylePriority.UseBorders = False
        Me.xrtbljudul.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrtcno, Me.xrtckdtamu, Me.xrtcnmtamu})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'xrtcno
        '
        Me.xrtcno.Name = "xrtcno"
        Me.xrtcno.Text = "No"
        Me.xrtcno.Weight = 0.29583343505859372R
        '
        'xrtckdtamu
        '
        Me.xrtckdtamu.Name = "xrtckdtamu"
        Me.xrtckdtamu.Text = "Kode Tamu"
        Me.xrtckdtamu.Weight = 0.91249992370605482R
        '
        'xrtcnmtamu
        '
        Me.xrtcnmtamu.Name = "xrtcnmtamu"
        Me.xrtcnmtamu.Text = "Nama Tamu"
        Me.xrtcnmtamu.Weight = 1.4000000762939455R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Weight = 0.29583343505859372R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 0.91249992370605482R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Weight = 1.4000000762939455R
        '
        'xrStatisticHotel
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 0, 4)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "12.2"
        CType(Me.xrtbldetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStatisticHotel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrtbljudul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrtbldetail As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrtcdtlno As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcdtlkdtamu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcdtlnmtamu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DsStatisticHotel1 As Hotel_Statistic.dsStatisticHotel
    Friend WithEvents xrtbljudul As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrtcno As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtckdtamu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcnmtamu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
End Class
