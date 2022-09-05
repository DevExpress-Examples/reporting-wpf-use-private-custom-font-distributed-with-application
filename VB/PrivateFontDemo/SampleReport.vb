Imports DevExpress.XtraReports.UI

Namespace PrivateFontDemo

    Public Class SampleReport
        Inherits XtraReport

        Private topMarginBand1 As TopMarginBand

        Private detailBand1 As DetailBand

        Public xrLabel1 As XRLabel

        Private bottomMarginBand1 As BottomMarginBand

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            topMarginBand1 = New TopMarginBand()
            detailBand1 = New DetailBand()
            xrLabel1 = New XRLabel()
            bottomMarginBand1 = New BottomMarginBand()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.Name = "topMarginBand1"
            ' 
            ' detailBand1
            ' 
            detailBand1.Controls.AddRange(New XRControl() {xrLabel1})
            detailBand1.Name = "detailBand1"
            ' 
            ' xrLabel1
            ' 
            xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            xrLabel1.Name = "xrLabel1"
            xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel1.SizeF = New System.Drawing.SizeF(629.9999F, 38.625F)
            xrLabel1.StylePriority.UseFont = False
            xrLabel1.Text = "This Label should be printed in Arial Narrow font."
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' SampleReport
            ' 
            Bands.AddRange(New Band() {topMarginBand1, detailBand1, bottomMarginBand1})
            Version = "14.1"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
