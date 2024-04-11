using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Vetor1
    {
        public Vetor1() {
            int[] vet = new int[12];
            int i;

            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("Digite um número");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n---------");

            for (i = 0; i < 12; i++)
            {
                Console.Write(vet[i] + "\t");
            }

            Console.WriteLine("\n---------");

            for (i = 0;i < 12;i++)
            {
                if (vet[i] % 2 == 0) 
                {
                    Console.WriteLine(vet[i] + " é par");
                }
                else
                {
                    Console.WriteLine(vet[i] + " é ímpar");
                }
            }
        }
    }
}
