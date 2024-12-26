using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDATASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = Counter.Instance;
            Counter counter2 = Counter.Instance;

            counter1.Increment();
            counter1.Increment();
            Console.WriteLine("Counter1 count: " + counter1.GetCount()); 

            counter2.Increment();
            counter2.Increment();
            Console.WriteLine("Counter2 count: " + counter2.GetCount()); 

        }
    }
    public class Counter
    {
        private static Counter _instance;
        private static readonly object _lock = new object();
        private int _count;

        private Counter()
        {
            _count = 0;
        }

        
        public static Counter Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Counter();
                    }
                    return _instance;
                }
            }
        }

       
        public void Increment()
        {
            _count++;
        }

        
        public int GetCount()
        {
            return _count;
        }
    }



}
