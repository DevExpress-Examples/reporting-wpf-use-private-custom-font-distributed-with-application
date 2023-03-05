Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.Drawing
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPrinting.Caching

Namespace PrivateFontDemo

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Shared Sub New()
            Dim fontFilePath As String = "Fonts/MissFajardose-Regular.ttf"
            Dim fontData() As Byte = System.IO.File.ReadAllBytes(fontFilePath)
            DXFontRepository.Instance.AddFont(fontData)
        End Sub

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Loaded, AddressOf Me.MainWindow_Loaded
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim report = New SampleReport()
            report.Font = New DXFont("Miss Fajardose", 48.0F, DXFontStyle.Regular, DXGraphicsUnit.Point)
            Dim cachedReportSource = New CachedReportSource(report, New MemoryDocumentStorage())
            Me.preview.DocumentSource = cachedReportSource
            cachedReportSource.CreateDocumentAsync()
        End Sub
    End Class
End Namespace
