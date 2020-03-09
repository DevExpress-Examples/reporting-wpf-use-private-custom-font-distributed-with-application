Imports System.Drawing
Imports System.Drawing.Text
Imports System.Linq
Imports System.Windows
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPrinting.Caching

Namespace PrivateFontDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Shared Sub New()
			PrintingSystemXmlSerializer.UnregisterConverter(GetType(Font))
			PrintingSystemXmlSerializer.RegisterConverter(New CustomFontConverter())
		End Sub


		Public Sub New()
			InitializeComponent()
			AddHandler Me.Loaded, AddressOf MainWindow_Loaded
		End Sub

		Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim report = New SampleReport()
			report.Font = New Font(CustomFontsHelper.GetFamily("Miss Fajardose"), 48F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point)

			Dim cachedReportSource As New CachedReportSource(report, New MemoryDocumentStorage())
			preview.DocumentSource = cachedReportSource
			cachedReportSource.CreateDocumentAsync()
		End Sub
	End Class
End Namespace
