using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual número você deseja ver os múltiplos?");
            int mult = int.Parse(Console.ReadLine());

            int cont = mult;

            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont += mult;
            }
             Console.ReadKey();
        }
    }
}
