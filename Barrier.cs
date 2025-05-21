using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrier
{
    public delegate void BarrierEventHandler(object sender);

    class Barrier
    {
        public event BarrierEventHandler Event1;
        public event BarrierEventHandler Event2;

        public void HandleEvent1(object sender)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Открыто");
            Console.ResetColor();
        }

        public void HandleEvent2(object sender)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Закрыто");
            Console.ResetColor();
        }

        public void RaiseRandomEvent(int seed)
        {
            Random rng = new Random(seed);
            int eventChoice = rng.Next(0, 2);

            if (eventChoice == 0)
            {
                Event1?.Invoke(this);
            }
            else
            {
                Event2?.Invoke(this);
            }
        }
    }
}