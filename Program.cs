using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barrier barrier = new Barrier();

            barrier.Event1 += barrier.HandleEvent1;
            barrier.Event2 += barrier.HandleEvent2;

            for (int i = 1; i <= 10; i++)
            {
                Man man = new Man($"Человек {i}");

                barrier.Event1 += man.HandleEvent1;
                barrier.Event2 += man.HandleEvent2;

                barrier.RaiseRandomEvent(i);
            }
            Console.ReadKey();
        }
    }
}
