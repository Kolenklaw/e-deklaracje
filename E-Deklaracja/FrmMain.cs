using E_Deklaracja.IPresenters;
using E_Deklaracja.IViews;
using E_Deklaracja.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Deklaracja
{
    public partial class FrmMain : Form, IMainView
    {
        IMainViewPresenter presenter;

        public FrmMain()
        {
            InitializeComponent();

            presenter = new MainViewPresenter(this);
        }

        public string Status
        {
            get
            {
                return lblStatus.Text;                
            }
            set
            {
                lblStatus.Text = value;
                this.Refresh();
            }
        }

        public void OnShowView()
        {
            Application.Run(this);
        }
    }
}
