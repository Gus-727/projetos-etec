using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Algo2
    {
        public Algo2()
        {
            int cod, qtd;
            double tot;
            Console.WriteLine("Digite o código do pedido");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade desejada");
            qtd = int.Parse(Console.ReadLine());

            if (cod == 100)
            {
                tot = qtd * 8.00;
                Console.WriteLine("O total a pagar será de: " + tot + " reais");
            }

            else
            {
                if (cod == 101)
                {
                    tot = qtd * 7.50;
                    Console.WriteLine("O total a pagar será de: " + tot + " reais");
                }

                if (cod == 102)
                {
                    tot = qtd * 8.50;
                    Console.WriteLine("O total a pagar será de: " + tot + " reais");
                }

                if (cod == 103)
                {
                    tot = qtd * 10.00;
                    Console.WriteLine("O total a pagar será de: " + tot + " reais");
                }

                if (cod == 105)
                {
                    tot = qtd * 5.00;
                    Console.WriteLine("O total a pagar será de: " + tot + " reais");
                }

            }
        }
    }
}
