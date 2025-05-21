using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Barrier
{
    class Man
    {
        public string Name { get; private set; }

        public Man(string name)
        {
            Name = name;
        }

        public void HandleEvent1(object sender)
        {
            Console.WriteLine($"{Name}, иду.");

            if (sender is Barrier barrier)
            {
                barrier.Event1 -= HandleEvent1;
                barrier.Event2 -= HandleEvent2;
            }
        }

        public void HandleEvent2(object sender)
        {
            Console.WriteLine($"{Name}, стою.");
        }
    }
}
