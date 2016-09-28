using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Deklaracja.IPresenters
{
    public interface ISendControlPresenter
    {        
        void SendEdeklaracja();
        void PobierzUpo();
        void DrukujUpo();
    }
}
