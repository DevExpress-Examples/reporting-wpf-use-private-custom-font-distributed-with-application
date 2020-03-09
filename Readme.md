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



