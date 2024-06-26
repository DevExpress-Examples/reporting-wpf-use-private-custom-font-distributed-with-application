<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600306/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5083)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/PrivateFontDemo/MainWindow.xaml)
* **[MainWindow.xaml.cs](./CS/PrivateFontDemo/MainWindow.xaml.cs)**
<!-- default file list end -->
# How to display a report that uses a private (embedded) font in a DocumentPreview


<p>Unlike WinForms, where an embedded font can be registered globally using the PrivateFontCollection, WPF requires explicit reference to the embedded font. This sample application demonstrates how to work around this limitation.<br /><br /><strong>See also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/E5198">E5198: How to use a private font (a custom font distributed with the application) in XtraReport</a> </p>
<p><strong>Note:</strong> This example targets the older version of our WPF report viewer called <a href="https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentViewer">DocumentPreview</a>. The new <strong> DocumentPreviewControl</strong> (v15.1+) does not use XAML for rendering document pages and therefore does not require any special handling with the exception of what's described in this MSDN article: <a href="https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-create-a-private-font-collection">How to: Create a Private Font Collection</a>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-use-private-custom-font-distributed-with-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-use-private-custom-font-distributed-with-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
