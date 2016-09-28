using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace E_Deklaracja.Helpers
{
    public class UpoDocument
    {
        public string NumerReferencyjny { get; set; }
        public string SkrotDokumentu { get; set; }
        public string SkrotZlozonejStruktury { get; set; }
        public string NazwaStrukturyLogicznej { get; set; }
        public string DataWplyniecia { get; set; }
        public string KodUrzedu { get; set; }
        public string StempelCzasu { get; set; }
        public string NIP1 { get; set; }
        public string Pesel1 { get; set; }
        public string NIP2 { get; set; }
        public string Pesel2 { get; set; }

        public string DataICzas { get; set; }

        public UpoDocument()
        {

        }

        public static UpoDocument GetUpoDocument(string upo)
        {
            UpoDocument doc = new UpoDocument();

            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
            xml.LoadXml(upo);

            XmlNodeList node = xml.GetElementsByTagName("Potwierdzenie");
            XmlNodeList signingTime = xml.GetElementsByTagName("xades:SigningTime");

            if (node != null)
            {
                XmlNode value = node[0].SelectSingleNode("NumerReferencyjny");
                doc.NumerReferencyjny = value.InnerText;
                value = node[0].SelectSingleNode("SkrotDokumentu");
                doc.SkrotDokumentu = value.InnerText;
                value = node[0].SelectSingleNode("SkrotZlozonejStruktury");
                doc.SkrotZlozonejStruktury= value.InnerText;
                value = node[0].SelectSingleNode("NazwaStrukturyLogicznej");
                doc.NazwaStrukturyLogicznej = value.InnerText;
                value = node[0].SelectSingleNode("DataWplyniecia");
                doc.DataWplyniecia = value.InnerText;
                value = node[0].SelectSingleNode("KodUrzedu");
                doc.KodUrzedu = value.InnerText;
                value = node[0].SelectSingleNode("StempelCzasu");
                doc.StempelCzasu = value.InnerText;
                value = node[0].SelectSingleNode("NIP1");
                if (value != null)
                    doc.NIP1 = value.InnerText;
                value = node[0].SelectSingleNode("PESEL1");
                if (value != null)
                    doc.Pesel1 = value.InnerText;
                value = node[0].SelectSingleNode("NIP2");
                if (value != null)
                    doc.NIP2 = value.InnerText;
                value = node[0].SelectSingleNode("PESEL2");
                if (value != null)
                    doc.Pesel2 = value.InnerText;
            }

            if (signingTime != null && signingTime.Count > 0)
            {
                doc.DataICzas = signingTime[0].InnerText;
            }

            return doc;
        }

    }
}
