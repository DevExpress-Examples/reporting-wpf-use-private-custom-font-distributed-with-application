using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows;
using DevExpress.Utils.Serializing;
using DevExpress.XtraPrinting.Caching;

namespace PrivateFontDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        static MainWindow() {
            PrintingSystemXmlSerializer.UnregisterConverter(typeof(Font));
            PrintingSystemXmlSerializer.RegisterConverter(new CustomFontConverter());
        }


        public MainWindow() {
            InitializeComponent();
            Loaded += MainWindow_Loaded;            
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            var report = new SampleReport();
            report.Font = new Font(CustomFontsHelper.GetFamily("Miss Fajardose"), 48F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point);

            var cachedReportSource = new CachedReportSource(report, new MemoryDocumentStorage());
            preview.DocumentSource = cachedReportSource;
            cachedReportSource.CreateDocumentAsync();
        }
    }
}
