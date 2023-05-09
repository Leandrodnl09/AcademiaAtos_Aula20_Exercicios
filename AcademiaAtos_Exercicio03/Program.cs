namespace AcademiaAtos_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13 - Crie uma classe autor. Em seguida, crie uma classe "Livro" com os atributos "titulo" e "autor". O atributo autor, deve ser 
            // uma instancia de uma classe Autor. Crie um método para exibir as informações do livro.

            List<Livro> livros = new List<Livro>();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Digite o título do livro:");
                string titulo = Console.ReadLine();

                Console.WriteLine("Digite o nome do autor:");
                string nomeAutor = Console.ReadLine();

                Console.WriteLine("Digite o sobrenome do autor:");
                string sobrenomeAutor = Console.ReadLine();

                Console.WriteLine("Digite a nacionalidade do autor:");
                string nacionalidadeAutor = Console.ReadLine();

                Autor autor = new Autor(nomeAutor, sobrenomeAutor, nacionalidadeAutor);
                Livro livro = new Livro(titulo, autor);
                livros.Add(livro);

                Console.WriteLine("Deseja continuar? (S/N)");
                string resposta = Console.ReadLine();
                continuar = resposta.ToLower() == "s";
            }

            Console.WriteLine("\nLista de livros cadastrados:");
            foreach (Livro livro in livros)
            {
                livro.ExibirInformacoes();
                Console.WriteLine("--------------------");
            }
        }
    }
}