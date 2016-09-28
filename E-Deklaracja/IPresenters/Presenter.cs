using E_Deklaracja.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Deklaracja.IPresenters
{
    public abstract class PresenterBase<TView> : IPresenter
        where TView : IView
    {
        private TView _view;
        public TView View
        {
            get { return _view; }
            set
            {
                _view = value;
                _view.Load += (s, e) => OnViewLoaded();
            }
        }

        public void ShowView() { raiseShowViewEvent(); }

        public event EventHandler OnShowView;

        private void raiseShowViewEvent()
        {
            if (OnShowView != null) OnShowView(null, null);
        }

        protected virtual void OnViewLoaded()
        {
        }

        //public Func<ISession> CreateSession { private get; set; }
        //private ISession _session;
        //protected ISession Session
        //{
        //    get
        //    {
        //        if (_session == null)
        //            _session = CreateSession();
        //        return _session;
        //    }
        //}

        public virtual void Dispose()
        {
            //if (_session != null)
            //    _session.Dispose();
        }
    }
}
