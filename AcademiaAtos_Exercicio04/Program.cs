namespace AcademiaAtos_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
            // void armazenaPessoa(String nome, int idade, float altura);
            // void removePessoa(String nome);
            // Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            // void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda


            Agenda agenda = new Agenda();
            List<Pessoa> listaPessoas = new List<Pessoa>();

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Remover pessoa");
                Console.WriteLine("3 - Buscar pessoa");
                Console.WriteLine("4 - Imprimir agenda");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Console.Write("Digite o nome da pessoa: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a idade da pessoa: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Digite a altura da pessoa (em metros): ");
                    float altura = float.Parse(Console.ReadLine());
                    agenda.armazenaPessoa(nome, idade, altura);
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o nome da pessoa a ser removida: ");
                    string nome = Console.ReadLine();
                    agenda.removePessoa(nome);
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o nome da pessoa a ser buscada: ");
                    string nome = Console.ReadLine();
                    Pessoa pessoaEncontrada = agenda.buscaPessoa(nome);
                    if (pessoaEncontrada != null)
                    {
                        Console.WriteLine("Pessoa encontrada:");
                        Console.WriteLine(pessoaEncontrada.getNome() + ", " + pessoaEncontrada.getIdade() + " anos, " + pessoaEncontrada.getAltura() + "m");
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada na agenda!");
                    }
                }
                else if (opcao == 4)
                {
                    agenda.imprimeAgenda();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                Console.WriteLine();
            }
        }
    }
}