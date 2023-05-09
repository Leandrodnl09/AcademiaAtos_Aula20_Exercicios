using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio03
{
    internal class Autor
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Nacionalidade { get; set; }

        public Autor(string nome, string sobrenome, string nacionalidade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Nacionalidade = nacionalidade;
        }
    }
}
