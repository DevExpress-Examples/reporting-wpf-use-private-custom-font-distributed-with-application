Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
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
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' detailBand1
			' 
			Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.detailBand1.Name = "detailBand1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(629.9999F, 38.625F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "This Label should be printed in Arial Narrow font."
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' SampleReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1})
			Me.Version = "14.1"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace
