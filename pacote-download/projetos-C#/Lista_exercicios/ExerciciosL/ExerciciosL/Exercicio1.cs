using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosL
{
    class Exercicio1
    {
        public Exercicio1()
        {
            double slmn, slp;

            Console.WriteLine("Digite o salário mínimo");
            slmn = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário da pessoa");
            slp = double.Parse(Console.ReadLine());

            slp = slp / slmn;

        }
    }
}
