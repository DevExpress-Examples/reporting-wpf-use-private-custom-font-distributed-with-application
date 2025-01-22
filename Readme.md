<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600306/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5083)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WPF - How to Use a Custom Font Distributed With the Application

The main idea of this approach is to use the [DXFontRepository](https://docs.devexpress.com/CoreLibraries/DevExpress.Drawing.DXFontRepository) instance to store custom fonts. The report constructor creates a new font and a [XRControlStyle](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControlStyle) report style based on the newly created font. The new custom style is added to the [XtraReport.StyleSheet](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.StyleSheet) collection.

![Custom Font in WPF Reporting Application](Images/screenshot.png)

## Files to Look At

* [MainWindow.xaml](./CS/PrivateFontDemo/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/PrivateFontDemo/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/PrivateFontDemo/MainWindow.xaml.vb))

## Documentation

- [DevExpress.Drawing Graphics Library](https://docs.devexpress.com/CoreLibraries/404247/devexpress-drawing-library)
- [DXFontRepository](https://docs.devexpress.com/CoreLibraries/DevExpress.Drawing.DXFontRepository)

## More Examples

- [Reporting for Web - How to Use a Custom Font Distributed With the Application](https://github.com/DevExpress-Examples/reporting-use-a-custom-font-distributed-with-the-application)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-use-private-custom-font-distributed-with-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-use-private-custom-font-distributed-with-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
