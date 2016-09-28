using E_Deklaracja.Helpers;
using E_Deklaracja.IPresenters;
using E_Deklaracja.IViews;
using GPS.Components.Cryptography.EDeklaracje;
using GPS.EDeklaracje.Service;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace E_Deklaracja.Presenters
{
    public class SendControlPresenter : PresenterBase<ISendControl>, ISendControlPresenter
    {
        private string refId = "";
        private requestUPOResponse UPO;

        private void OpenFile()
        {
            string path = this.View.OpenFile();

            this.View.FilePath = path;
        }

        public void DrukujUpo()
        {
            string path = this.View.SaveAs("pdf files (*.pdf)|*.pdf");

            if (string.IsNullOrEmpty(path))
                return;

            if (UPO == null)
                return;

            if (string.IsNullOrEmpty(UPO.upo))
                return;

            UpoDocument doc = UpoDocument.GetUpoDocument(UPO.upo);

            PdfDocument pdf = PdfReader.Open(Path.Combine(Path.GetDirectoryName( System.Reflection.Assembly.GetExecutingAssembly().Location), "upo.pdf"), PdfDocumentOpenMode.Modify, null);
            pdf.Info.Title = "UPO";

            PdfPage pdfPage = pdf.Pages[0];

            XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);

            XFont font = new XFont("Arial", 10, XFontStyle.Regular, new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always));
            XBrush b = XBrushes.Black;
            XStringFormat format = new XStringFormat();
            format.FormatFlags = XStringFormatFlags.MeasureTrailingSpaces;
            format.Alignment = XStringAlignment.Near;
            format.LineAlignment = XLineAlignment.Near;

            xGraphics.DrawString(doc.NumerReferencyjny, font, b, new RectangleF(55, 210, 479, 27), format);
            xGraphics.DrawString(doc.DataWplyniecia, font, b, new RectangleF(310, 210, 479, 27), format);
            xGraphics.DrawString(doc.SkrotDokumentu, font, b, new RectangleF(55, 236, 479, 27), format);
            xGraphics.DrawString(doc.SkrotZlozonejStruktury, font, b, new RectangleF(55, 263, 479, 27), format);
            xGraphics.DrawString(doc.NazwaStrukturyLogicznej, font, b, new RectangleF(55, 290, 479, 27), format);

            if (!string.IsNullOrEmpty(doc.Pesel1))
            {
                xGraphics.DrawString("PESEL " + doc.Pesel1, font, b, new RectangleF(55, 317, 479, 27), format);
            }
            else if (!string.IsNullOrEmpty(doc.NIP1))
            {
                xGraphics.DrawString("NIP " + doc.NIP1, font, b, new RectangleF(55, 317, 479, 27), format);
            }

            if (!string.IsNullOrEmpty(doc.Pesel2))
            {
                xGraphics.DrawString("PESEL " + doc.Pesel2, font, b, new RectangleF(310, 317, 479, 27), format);
            }
            else if (!string.IsNullOrEmpty(doc.NIP2))
            {
                xGraphics.DrawString("NIP " + doc.NIP2, font, b, new RectangleF(310, 317, 479, 27), format);
            }

            xGraphics.DrawString("Kod Urzędu Skarbowego: " + doc.KodUrzedu, font, b, new RectangleF(55, 344, 479, 27), format);
            xGraphics.DrawString(doc.StempelCzasu, font, b, new RectangleF(55, 370, 479, 50), format);

            xGraphics.DrawString(doc.DataICzas, font, b, new RectangleF(167, 533, 479, 27), format);

            pdf.Save(path);
            Process.Start(path);
        }

        public void PobierzUpo()
        {
            GateServiceHelper service = new GateServiceHelper(this.View.TypKomunikacji);

            UPO = service.GateService.requestUPO(new requestUPO() { refId = this.View.NumerReferencyjny });

            this.View.KodStatusuWysylki = UPO.status.ToString();
            this.View.StatusWysylki = UPO.statusOpis;
        }

        public void SendEdeklaracja()
        {
            refId = "";

            FormTools.MainView.Status = "Wysyłanie deklaracji...";

            XmlDocument xmlDoc = new XmlDocument();

            if (string.IsNullOrEmpty(this.View.FilePath))
                return;

            if (!File.Exists(this.View.FilePath))
                return;

            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(this.View.FilePath);

            string sendData = "";

            if (this.View.SendWithoutSign)
            {
                sendData = xmlDoc.InnerXml;
            }
            else
            {
                XmlDocument signed = EDeklaracja.PodpiszXades(xmlDoc, this.View.Certificate);
                sendData = signed.InnerXml;
            }

            //string doc = xmlDoc.InnerXml;

            //byte[] byte1 = Encoding.UTF8.GetBytes(doc);
            //CmsSigner signer = new CmsSigner(this.View.Certificate);
            
            //byte[] byte3 = EDeklaracja.GetByte64(byte1);
            //byte[] byte2 = EDeklaracja.PodpiszPKCS7(byte3, signer);

            byte[] byte1 = Encoding.UTF8.GetBytes(sendData);
            byte[] byte2 = EDeklaracja.GetByte64(byte1);

            this.View.WyslaneDane = sendData;

            GateServiceHelper service = new GateServiceHelper(this.View.TypKomunikacji);

            if (this.View.SendWithoutSign)
            {
                sendUnsignDocumentResponse resp = service.GateService.sendUnsignDocument(new sendUnsignDocument() { document = byte2 });
                refId = resp.refId;
            }
            else
            {
                sendDocumentResponse resp = service.GateService.sendDocument(new sendDocument() { document = byte2 });
                refId = resp.refId;
            }
           
            this.View.NumerReferencyjny = refId;

            PobierzUpo();

            FormTools.MainView.Status = "Gotowe";
        }

        public SendControlPresenter(ISendControl view)
        {
            this.View = view;

            this.View.OpenFileClick += delegate { this.OpenFile(); };
            this.View.SendClick += delegate { this.SendEdeklaracja(); };
            this.View.CheckClick += delegate { this.PobierzUpo(); };
            this.View.PrintUpoClick += delegate { this.DrukujUpo(); };
        }

        protected override void OnViewLoaded()
        {
            base.OnViewLoaded();

            LoadCertificates();            
        }

        private void LoadCertificates()
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);

            store.Open(OpenFlags.OpenExistingOnly);

            List<X509Certificate2> certificates = new List<X509Certificate2>();
            foreach (var item in store.Certificates)
            {
                certificates.Add(item);
            }
            this.View.Certificates = certificates;
        }        
    }
}
