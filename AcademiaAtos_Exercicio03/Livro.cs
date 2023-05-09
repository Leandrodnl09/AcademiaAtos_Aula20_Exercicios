using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio03
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        public Livro(string titulo, Autor autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Título do livro: " + Titulo);
            Console.WriteLine("Autor do livro: " + Autor.Nome + " " + Autor.Sobrenome);
            Console.WriteLine("Nacionalidade do autor: " + Autor.Nacionalidade);
        }
    }
}
