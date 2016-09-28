using E_Deklaracja.IPresenters;
using E_Deklaracja.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Deklaracja.Presenters
{
    public class MainViewPresenter : PresenterBase<IMainView>, IMainViewPresenter
    {
        public MainViewPresenter(IMainView view)
        {
            this.View = view;
            this.OnShowView += delegate { view.OnShowView(); };
        }


    }
}
