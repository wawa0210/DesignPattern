using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class IObserver
    {
        /// <summary>
        /// 签到
        /// </summary>
        public abstract void Sign(object obj);
    }
}
