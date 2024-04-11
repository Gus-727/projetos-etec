using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    class Nota
    {
        // Propriedades
        public string Aluno { get; set; }
        public string Turma { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Media { get; set; }

        // Método construtor
        public Nota(string aluno, string turma, int nota1, int nota2, int media)
        {
            Aluno = aluno;
            Turma = turma;
            Nota1 = nota1;
            Nota2 = nota2;
            Media = media;
        }

    }
}
