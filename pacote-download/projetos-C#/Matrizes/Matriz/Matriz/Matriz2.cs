using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Matriz2
    {
        public Matriz2()
        {
            int tamanho = 3;
            int[,] mat = new int[10, 10];
            int lin, col;

            for (lin=0; lin < 10; lin++)
            {
                for(col=0; col < 10; col++)
                {
                    Console.WriteLine("Digite um número");
                    mat[lin, col] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nElementos da matriz");
            for (lin = 0; lin < 10; lin++)
            {
                for (col = 0; col < 10; col++)
                {
                    Console.Write(mat[lin, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nExibição da linha");
            Console.WriteLine("Digite o número da linha");
            lin = int.Parse(Console.ReadLine());
            for(col = 0; col < 10; col++)
            {
                Console.Write(mat[lin, col] + "\t");
            }

        }
    }
}
