using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void ChangedEventHandler(object sender,EventArgs e);

    class Program
    {
        static void Main(string[] args)
        {
            //EventHandler

            var e = new EventTest(5);
            e.SetValue(100);
            e.ChangeNum += new EventTest.NumManupulationHandler(EventTest.EventFired);
            e.SetValue(200);

            I i = new Myclass();
            i.MyEvent += new MyDelegate(f);
            i.FireAway();
        }

        private static void f()
        {
            Console.WriteLine("This is called where the event fired!");
        }
    }

    class EventTest
    {

        private int value;
        public delegate void NumManupulationHandler();
        public event NumManupulationHandler ChangeNum;

        public EventTest(int n)
        {
            SetValue(n);
        }

        public static void EventFired()
        {
            Console.WriteLine("Binded Event fired!");
        }

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Event fired!");
            }
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }

    public delegate void MyDelegate();

    public interface I
    {
        event MyDelegate MyEvent;
        //event EventHandler MyGuidlineEvent;
        void FireAway();
    }

    public class Myclass:I
    {
        public event MyDelegate MyEvent;

        public void FireAway()
        {
            if (MyEvent != null)
            {
                MyEvent();
            }
        }
    }
}
