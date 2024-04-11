using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Vetor3
    {
        public Vetor3()
        {
            string[] vetN = new string[4];
            double[] vetV = new double[4];
            int i;
            double comiss = 0;

            Console.WriteLine("Informe os dados do vendedor");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o nome do vendedor");
                vetN[i] = Console.ReadLine();
                Console.WriteLine("Digite o valor da venda");
                vetV[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nExibindo os dados do vendedor");
            for (i = 0; i < 4; i++)
           {
                Console.WriteLine("O nome do vendedor é " + vetN[i]);
                comiss = (12 * vetV[i]) / 100;
                Console.WriteLine("O valor de venda é " + vetV[i] + " e o valor da comissão é " + comiss);
           }
        }
    }
}
