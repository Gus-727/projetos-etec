using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Vetor2
    {
        public Vetor2()
        {
            int[] v1 = new int[5];
            int[] v2 = new int[5];
            int i, j;

            Console.WriteLine("Atribua valores para o primeiro vetor");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número");
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Atribua valores para o segundo vetor");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número");
                v2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nValores do primeiro vetor");
            for (i = 0; i < 5; i++)
            {
                Console.Write(v1[i] + "\t");
            }
            Console.WriteLine("\nValores do segundo vetor");
            for (i = 0; i < 5; i++)
            {
                Console.Write(v2[i] + "\t");
            }
            Console.WriteLine("Valores do vetor intercalado");
            for (i = 0; i < 5; i++)
            {
                Console.Write(v1[i] + "\t");
                Console.Write(v2[i] + "\t");
            }
        }
    }
}
