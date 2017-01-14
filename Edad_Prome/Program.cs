using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad_Prome
{
    class Program
    {
        static void Main(string[] args)
        {
            int ed, ac = 0;
            for (int x = 1; x < 10; x++)
            {
                Console.WriteLine("Dijite edades: ");
                ed = int.Parse(Console.ReadLine());
                ac = ac + ed;
            }

            Console.WriteLine("El promedio de todo el grupo es: "+ ac/10);
            Console.ReadLine();
        }
    }
}
