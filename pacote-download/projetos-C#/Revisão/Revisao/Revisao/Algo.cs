using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Algo
    {

      public Algo() 
      {
            int hora, min, segundo, seg;
            Console.WriteLine("Digite a duração do evento em segundos");
            segundo = int.Parse(Console.ReadLine());
            hora = segundo / 3600;
            min = ((segundo % 3600) / 60);
            seg = ((segundo % 60));
            Console.WriteLine("A duração do evento foi de " + hora + " horas, " + min + " minutos e " + seg + " segundos");
        }
    }
}
