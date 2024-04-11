using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Algo3
    {
        public Algo3()
        {
            int fruta = 0, cesta;

            Console.WriteLine("--------------------");

            for (cesta = 0; cesta < 60; cesta++)
            {
                fruta = fruta + 1;

                if (fruta >= 2)
                {
                    fruta = fruta * 2;
                }

            }

            Console.WriteLine("O total de frutas recebidas pelo monge é " + fruta);
        }
    }
}
