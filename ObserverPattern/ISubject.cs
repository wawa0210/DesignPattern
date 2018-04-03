using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    interface ISubject
    {
        void Attach(NotifyEventHandler obj);

        void Detach(NotifyEventHandler obj);

        void Notify();
    }
}
