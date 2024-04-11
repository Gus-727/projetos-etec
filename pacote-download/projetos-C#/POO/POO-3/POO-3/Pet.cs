using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3
{
    class Pet
    {
        // Propriedades

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Genero { get; set; }

        public string Especie { get; set; }

        // Método construtor

        public Pet(string nome, int idade, string genero, string especie )
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
            Especie = especie;
        }
    }
}
