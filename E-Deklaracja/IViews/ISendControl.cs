using GPS.EDeklaracje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks; 

namespace E_Deklaracja.IViews
{
    public interface ISendControl : IView
    {
        event EventHandler OpenFileClick;
        event EventHandler SendClick;
        event EventHandler CheckClick;
        event EventHandler PrintUpoClick;

        IList<X509Certificate2> Certificates { get; set; }

        X509Certificate2 Certificate { get; set; }

        string FilePath { get; set; }
        string KodStatusuWysylki { get; set; }
        string StatusWysylki { get; set; }
        string NumerReferencyjny { get; set; }
        string WyslaneDane { get; set; }

        string OpenFile();
        string SaveAs(string filter);

        TypKomunikacjiMF TypKomunikacji { get; set; }

        bool SendWithoutSign { get; }
    }
}
