<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/PrivateFontDemo/MainWindow.xaml)
* **[MainWindow.xaml.cs](./CS/PrivateFontDemo/MainWindow.xaml.cs)**
<!-- default file list end -->
# How to display a report that uses a private (embedded) font in a DocumentPreview


<p>Unlike WinForms, where an embedded font can be registered globally using the PrivateFontCollection, WPF requires explicit reference to the embedded font. This sample application demonstrates how to work around this limitation.<br /><br /><strong>See also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/E5198">E5198: How to use a private font (a custom font distributed with the application) in XtraReport</a> </p>
<p><strong>Note:</strong> This example targets the older version of our WPF report viewer called <a href="https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentViewer">DocumentPreview</a>. The new <strong> DocumentPreviewControl</strong> (v15.1+) does not use XAML for rendering document pages and therefore does not require any special handling with the exception of what's described in this MSDN article: <a href="How to: Create a Private Font Collection">How to: Create a Private Font Collection</a>

<br/>


