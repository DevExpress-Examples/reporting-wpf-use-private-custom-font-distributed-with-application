using System.Drawing.Text;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Printing;

namespace PrivateFontDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        SampleReport report;
        PrivateFontCollection privateFonts;

        public MainWindow() {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            DevExpress.XtraPrinting.XamlExport.FontResolver.FamilyNameResolved += FontResolver_FamilyNameResolved;
        }

        void FontResolver_FamilyNameResolved(object sender, DevExpress.XtraPrinting.XamlExport.FontResolver.FamilyNameResolvedEventArgs e) {
            if(useFontResolver.IsChecked != true)
                return;

            if(e.FamilyName == "Arial Narrow") {
                // Packaging Fonts with Applications
                // http://msdn.microsoft.com/en-us/library/ms753303(v=vs.100).aspx
                e.FamilyName = "./Resources/#" + e.FamilyName;
            }
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("./Resources/ARIALN.TTF");
            System.Drawing.FontFamily fontFamily = privateFonts.Families.First();

            report = new SampleReport();
            report.Font = new System.Drawing.Font(fontFamily, 20, System.Drawing.FontStyle.Regular);

            preview.Model = new XtraReportPreviewModel(report);
        }

        private void createDocument_Click(object sender, RoutedEventArgs e) {
            report.CreateDocument();
        }
    }
}
