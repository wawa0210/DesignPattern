using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObserver
    {
        /// <summary>
        /// 签到
        /// </summary>
        void Sign(object obj);
    }
}
