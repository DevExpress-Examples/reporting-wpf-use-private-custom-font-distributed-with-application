<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600306/18.2.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5083)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/PrivateFontDemo/MainWindow.xaml)
* **[MainWindow.xaml.cs](./CS/PrivateFontDemo/MainWindow.xaml.cs)**
<!-- default file list end -->
# How to display a report that uses a private (embedded) font in a DocumentPreviewControl


The main idea of this approach is to use the [PrivateFontCollection](http://msdn.microsoft.com/en-us/library/system.drawing.text.privatefontcollection%28v=vs.110%29.aspx) class to store custom font families. Use the [Families](http://msdn.microsoft.com/en-us/library/system.drawing.text.fontcollection.families%28v=vs.110%29.aspx) property to access the FontFamily objects of your private fonts.   

In this example, the static "FontCollection" property of the "CustomFontsHelper" class is used to store the report's private fonts. Then, in the report constructor, the font families from this static collection are used to initialize fonts of the report components.  
  
  
This is a cross\-platform approach, so it can be used for all technologies supported by XtraReports. However, there are some notes:  
  
  
### CachedReportSource 
The [CachedReportSource](https://docs.devexpress.com/XtraReports/117751/create-end-user-reporting-applications/wpf-reporting/document-preview/quick-start/create-a-custom-document-preview) component caches report documents by default. When the report is restored from the cache, the fonts are loaded from the system fonts. To overcome this behavior it is necessary to override the font loading code to make it use the PrivateFontCollection to restore fonts. The CustomFontConverter class *(inherited from the DevExpress.Utils.Serializing.PrintingSystemXmlSerializer.FontConverter class)* is used for this purpose in this code example. To force the Reporting components use this custom font converter it is necessary to unregister the default font converter class and then register the custom font converter when the application is started. A static constructor is used for this purpose in this sample project.



<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-use-private-custom-font-distributed-with-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-use-private-custom-font-distributed-with-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
