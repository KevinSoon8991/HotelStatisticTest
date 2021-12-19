<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_hotel_statistic
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gchotel = New DevExpress.XtraGrid.GridControl()
        Me.gvhotel = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gchotel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvhotel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gchotel
        '
        Me.gchotel.Location = New System.Drawing.Point(13, 62)
        Me.gchotel.MainView = Me.gvhotel
        Me.gchotel.Name = "gchotel"
        Me.gchotel.Size = New System.Drawing.Size(519, 396)
        Me.gchotel.TabIndex = 0
        Me.gchotel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvhotel})
        '
        'gvhotel
        '
        Me.gvhotel.GridControl = Me.gchotel
        Me.gvhotel.Name = "gvhotel"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(424, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print Laporan"
        '
        'frm_hotel_statistic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 470)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.gchotel)
        Me.Name = "frm_hotel_statistic"
        Me.Text = "frm_hotel_statistic"
        CType(Me.gchotel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvhotel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gchotel As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvhotel As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
End Class
