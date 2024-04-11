using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Matriz1
    {
        public Matriz1()
        {
            double[,] m = new double[5, 5];
            int lin, col;

            for (lin = 0; lin < 5; lin++)
            {
                for (col = 0; col < 5; col++)
                {
                    Console.WriteLine("Digite um número");
                    m[lin, col] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nElementos da matriz");
            for (lin = 0; lin < 5; lin++)
            {
                for (col = 0; col < 5; col++)
                {
                    Console.Write(m[lin, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nElementos da matriz metade");
            for (lin = 0; lin < 5; lin++)
            {
                for (col = 0; col < 5; col++)
                {
                    Console.Write(m[lin, col]/2 + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

