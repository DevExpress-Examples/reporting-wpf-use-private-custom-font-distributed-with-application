Imports DevExpress.XtraReports.UI

Namespace PrivateFontDemo

    Public Class SampleReport
        Inherits XtraReport

        Private Detail As DetailBand

        Private lbText As XRLabel

        Private TopMargin As TopMarginBand

        Private BottomMargin As BottomMarginBand

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Detail = New DetailBand()
            TopMargin = New TopMarginBand()
            BottomMargin = New BottomMarginBand()
            lbText = New XRLabel()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Detail.Controls.AddRange(New XRControl() {lbText})
            Detail.Name = "Detail"
            Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            TopMargin.Name = "TopMargin"
            TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            BottomMargin.Name = "BottomMargin"
            BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbText
            ' 
            lbText.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            lbText.Name = "lbText"
            lbText.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            lbText.SizeF = New System.Drawing.SizeF(630F, 79.99999F)
            lbText.StylePriority.UseFont = False
            lbText.StylePriority.UseTextAlignment = False
            lbText.Text = "Hello World"
            lbText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' SampleReport
            ' 
            Bands.AddRange(New Band() {Detail, TopMargin, BottomMargin})
            Version = "18.2"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
