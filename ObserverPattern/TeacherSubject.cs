using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{

    public class TeacherSubject : ISubject
    {
        public NotifyEventHandler NotifyEvent;

        public void Attach(NotifyEventHandler obj)
        {
            NotifyEvent += obj;
        }

        public void Detach(NotifyEventHandler obj)
        {
            NotifyEvent -= obj;
        }

        /// <summary>
        /// 通知类
        /// </summary>
        public void Notify()
        {
            NotifyEvent(this);
            //foreach (var item in listObserver)
            //{
            //    if (item == null) continue;

            //    item.Sign();
            //}
        }
    }
}
