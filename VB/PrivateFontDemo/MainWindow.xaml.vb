Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPrinting.Caching

Namespace PrivateFontDemo

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Shared Sub New()
            Call PrintingSystemXmlSerializer.UnregisterConverter(GetType(Font))
            Call PrintingSystemXmlSerializer.RegisterConverter(New CustomFontConverter())
        End Sub

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Loaded, AddressOf Me.MainWindow_Loaded
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim report = New SampleReport()
            report.Font = New Font(GetFamily("Miss Fajardose"), 48F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point)
            Dim cachedReportSource = New CachedReportSource(report, New MemoryDocumentStorage())
            Me.preview.DocumentSource = cachedReportSource
            cachedReportSource.CreateDocumentAsync()
        End Sub
    End Class
End Namespace
