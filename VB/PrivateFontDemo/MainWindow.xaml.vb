Imports System.Drawing.Text
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Printing

Namespace PrivateFontDemo

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Private report As SampleReport

        Private privateFonts As PrivateFontCollection

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Loaded, AddressOf Me.MainWindow_Loaded
            AddHandler DevExpress.XtraPrinting.XamlExport.FontResolver.FamilyNameResolved, AddressOf FontResolver_FamilyNameResolved
        End Sub

        Private Sub FontResolver_FamilyNameResolved(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.XamlExport.FontResolver.FamilyNameResolvedEventArgs)
            If Me.useFontResolver.IsChecked <> True Then Return
            If Equals(e.FamilyName, "Arial Narrow") Then
                ' Packaging Fonts with Applications
                ' http://msdn.microsoft.com/en-us/library/ms753303(v=vs.100).aspx
                e.FamilyName = "./Resources/#" & e.FamilyName
            End If
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            privateFonts = New PrivateFontCollection()
            privateFonts.AddFontFile("./Resources/ARIALN.TTF")
            Dim fontFamily As System.Drawing.FontFamily = privateFonts.Families.First()
            report = New SampleReport()
            report.Font = New System.Drawing.Font(fontFamily, 20, System.Drawing.FontStyle.Regular)
            Me.preview.Model = New XtraReportPreviewModel(report)
        End Sub

        Private Sub createDocument_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            report.CreateDocument()
        End Sub
    End Class
End Namespace
