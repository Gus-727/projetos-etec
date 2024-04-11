using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosL
{
    class Exercicio2
    {
        public Exercicio2()
        {
            double H, pesoI;
            string sexo;

            Console.WriteLine("Digite o sexo (masculino ou feminino)");
            sexo = Console.ReadLine();

            Console.WriteLine("\nDigite a altura da pessoa");
            H = double.Parse(Console.ReadLine());

            if (sexo == "Masculino")
            {
                pesoI = (72.7 * H) - 58;
                Console.WriteLine("Seu peso ideal é " + pesoI);
            }

            if (sexo == "Feminino")
            {
                pesoI = (62.1 * H) - 44.7;
                Console.WriteLine("Seu peso ideal é " + pesoI);
            }

        }
    }
}
