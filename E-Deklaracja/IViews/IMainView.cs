using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Deklaracja.IViews
{
    public interface IMainView : IView
    {
        string Status { get; set; }
    }
}
