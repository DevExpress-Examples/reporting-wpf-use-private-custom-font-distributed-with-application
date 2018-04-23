using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;

namespace PrivateFontDemo {
    public class SampleReport : XtraReport {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        public XRLabel xrLabel1;
        private BottomMarginBand bottomMarginBand1;
    
        public SampleReport() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.detailBand1.Name = "detailBand1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(629.9999F, 38.625F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "This Label should be printed in Arial Narrow font.";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // SampleReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1});
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
