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
        public delegate void Event();
        public event Event Event1;
        public event Event Event2;
        public void Message1()
        {
            Console.WriteLine("Человек идет");
        }
        public void Message2()
        {
            Console.WriteLine("Человек стоит");
        }

    }
}
