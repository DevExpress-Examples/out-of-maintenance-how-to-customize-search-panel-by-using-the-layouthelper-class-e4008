<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to customize Search Panel by using the LayoutHelper class


<p>Generally, WPF controls can be customized via <a href="http://www.wpftutorial.net/templates.html"><u>Control Templates</u></a>. Although this customization method has many advantages, sometimes you just wish to get a quick solution without writing additional XAML. This example illustrates how to customize Search Panel of the RichEditControl (see the image below) programmatically. The approach demonstrated in this example implies the use of a very handy <strong>LayoutHelper </strong>class. It allows you to search FrameworkElements by the specified criteria and can be very helpful in some situations where the only alternative is to write a large style/template. Note the way in which <a href="http://msdn.microsoft.com/en-us/library/system.windows.uielement.layoutupdated.aspx"><u>UIElement.LayoutUpdated Event</u></a> is utilized in this example.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-search-panel-by-using-the-layouthelper-class-e4008/11.2.11+/media/0efe1023-cf58-4f3c-ae81-18579c37367a.png"></p>

<br/>


