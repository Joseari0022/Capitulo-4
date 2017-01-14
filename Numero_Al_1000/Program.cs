using System;
using System.Collections.Generic;
using System.Text;
namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.WriteLine("Numero primero hasta 1000");
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont < 3)
                {
                    Console.Write(i + ", ");
                }
                cont = 0;
            }
            Console.ReadKey();
        }
    }
}