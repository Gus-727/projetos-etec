using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosL
{
    class Exercicio3
    {
        public Exercicio3()
        {
            int n, nI, soma;

           for(n=0;n < 4; n++)
            {
                Console.WriteLine("Digite um número de 4 algarismos");
                nI = int.Parse(Console.ReadLine());

                if (nI >= 1000 && nI <= 9999)
                {
                    soma = nI / 100;
                    soma = soma + nI % 100;
                    soma = soma * soma;

                    if (soma == nI)
                    {
                        Console.WriteLine("O número " + soma + " apresenta a mesma característica");
                    }
                    if(soma != nI)
                    {
                        Console.WriteLine("O número " + soma + " não apresenta a mesma característica");
                    }
                }

                else
                {
                    break;
                }
            }
        }
    }
}
