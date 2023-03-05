using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows;
using DevExpress.Drawing;
using DevExpress.Utils.Serializing;
using DevExpress.XtraPrinting.Caching;

namespace PrivateFontDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        static MainWindow() {
            string fontFilePath = "Fonts/MissFajardose-Regular.ttf";
            byte[] fontData = System.IO.File.ReadAllBytes(fontFilePath);
            DXFontRepository.Instance.AddFont(fontData);
        }


        public MainWindow() {
            InitializeComponent();
            Loaded += MainWindow_Loaded;            
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            var report = new SampleReport();
            report.Font = new DXFont("Miss Fajardose", 48F, DXFontStyle.Regular, DXGraphicsUnit.Point);

            var cachedReportSource = new CachedReportSource(report, new MemoryDocumentStorage());
            preview.DocumentSource = cachedReportSource;
            cachedReportSource.CreateDocumentAsync();
        }
    }
}
