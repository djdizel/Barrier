using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrier
{
    class Barrier
    {

        public void Message1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Открыто");
        }

        public void Message2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Закрыто");
        }

        public void Rng()
        {
            Random rng = new Random();
            rng.Next(0,1);
        }
    }
}
