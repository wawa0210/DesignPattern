using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subject = new TeacherSubject();

            subject.Attach(new StudentObserver("wawa0210").Sign);
            subject.Attach(new MomObserver("wawa0210 Mom").Sign);
            subject.Attach(new StudentObserver("tom").Sign);
            subject.Attach(new MomObserver("tom Mom").Sign);
            subject.Detach(new MomObserver("tom Mom").Sign);

            subject.Notify();
        }
    }
}
