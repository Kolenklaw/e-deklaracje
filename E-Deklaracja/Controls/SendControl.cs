using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Deklaracja.IViews;
using E_Deklaracja.IPresenters;
using E_Deklaracja.Presenters;

namespace E_Deklaracja.Controls
{
    public partial class SendControl : UserControl, ISendControl
    {
        SendControlPresenter presenter;

        public SendControl()
        {
            InitializeComponent();

            presenter = new SendControlPresenter(this);
            
            this.btnOpenFile.Click += OpenFileClick;
            this.btnSend.Click += SendClick;
            this.btnPobierzUpo.Click += CheckClick;
            this.btnDrukujUpo.Click += PrintUpoClick;

            //this.btnOpenFile.Click += delegate
            //{
            //    var Handler = this.OpenFileClick;

            //    if (Handler != null)
            //    {
            //        Handler(this, EventArgs.Empty);
            //    }
            //};
        }

        public event EventHandler OpenFileClick;

        public event EventHandler SendClick;

        public event EventHandler CheckClick;

        public event EventHandler PrintUpoClick;

        public string FilePath
        {
            get
            {
                return txtFilePath.Text;
            }
            set
            {
                txtFilePath.Text = value;
            }
        }

        public string KodStatusuWysylki
        {
            get
            {
                return txtKodStatusu.Text;
            }
            set
            {
                txtKodStatusu.Text = value;
            }
        }

        public string StatusWysylki
        {
            get
            {
                return txtStatusWysylki.Text;
            }
            set
            {
                txtStatusWysylki.Text = value;
            }
        }

        public GPS.EDeklaracje.TypKomunikacjiMF TypKomunikacji
        {
            get
            {
                GPS.EDeklaracje.TypKomunikacjiMF result = GPS.EDeklaracje.TypKomunikacjiMF.Testowy;
                if (rbOficjalny.Checked)
                    result = GPS.EDeklaracje.TypKomunikacjiMF.Oficjalny;

                return result;
            }
            set
            {
                if (value == GPS.EDeklaracje.TypKomunikacjiMF.Oficjalny)
                    rbOficjalny.Checked = true;
                else
                    rbTestowy.Checked = true;
            }
        }


        public string OpenFile()
        {
            string result = "";

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                dialog.Title = "Wybierz plik e-deklaracji...";

                if (dialog.ShowDialog() == DialogResult.OK)
                    result = dialog.FileName;
            }

            return result;
        }

        public string SaveAs(string filter)
        {
            string result = "";

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = filter;
                dialog.Title = "Zapisz plik jako...";

                if (dialog.ShowDialog() == DialogResult.OK)
                    result = dialog.FileName;
            }

            return result;
        }


        IList<System.Security.Cryptography.X509Certificates.X509Certificate2> certificates = new List<System.Security.Cryptography.X509Certificates.X509Certificate2>();
        public IList<System.Security.Cryptography.X509Certificates.X509Certificate2> Certificates
        {
            get
            {
                return certificates;
            }
            set
            {
                certificates = value;

                comboCertificates.DataSource = certificates;
                comboCertificates.DisplayMember = "Subject";
            }
        }

        private System.Security.Cryptography.X509Certificates.X509Certificate2 certificate = null;
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate
        {
            get
            {
                if (comboCertificates.SelectedItem == null)
                    return null;

                certificate = (System.Security.Cryptography.X509Certificates.X509Certificate2)comboCertificates.SelectedItem;
                return certificate;
            }
            set
            {
                certificate = value;

                comboCertificates.SelectedItem = certificate;
            }
        }


        public void WaitAnimation()
        {
            this.Cursor = Cursors.WaitCursor;
        }


        public string NumerReferencyjny
        {
            get
            {
                return txtNumerReferencyjny.Text;
            }
            set
            {
                txtNumerReferencyjny.Text = value;
            }
        }


        public string WyslaneDane
        {
            get
            {
                return rtxtDane.Text;
            }
            set
            {
                rtxtDane.Text = value;
            }
        }

        public bool SendWithoutSign
        {
            get
            {
                return cbBezPodpisu.Checked;
            }
        }

        public void OnShowView()
        {
            throw new NotImplementedException();
        }
    }
}
