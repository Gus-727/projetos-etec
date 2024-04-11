using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosL
{
    class Exercicio5
    {
        public Exercicio5()
        {
            int[,] mtz = new int[3, 4];
            int lin, col;

            for(lin=0; lin < 3; lin++)
            {
                for (col=0; col < 4; col++)
                {
                    Console.WriteLine("Digite um número");
                    mtz[lin, col] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nExibição dos elementos da matriz");
            for(lin=0; lin < 3; lin++)
            {
                for(col=0; col < 4; col++)
                {
                    Console.Write(mtz[lin, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nExibição dos triplos elementos da matriz");
            for (lin = 0; lin < 3; lin++)
            {
                for (col = 0; col < 4; col++)
                {
                    mtz[lin, col] = mtz[lin, col] * 3;
                    Console.Write(mtz[lin, col] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
