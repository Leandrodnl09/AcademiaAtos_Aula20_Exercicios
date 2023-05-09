namespace AcademiaAtos_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro
            // (aumentando a velocidade em 10) e outro para frear o carro(diminuindo a velocidade em 10, mas nunca deixando a
            // velocidade negativa).

            Carro meuCarro = new Carro();

            Console.WriteLine("Bem-vindo ao programa do carro!");
            Console.WriteLine($"Digite a modelo do veiculo:");
            meuCarro.Modelo = Console.ReadLine();
            Console.WriteLine($"Digite o ano do veiculo:");
            meuCarro.Ano = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("O que você quer fazer?");
                Console.WriteLine("1 - Acelerar");
                Console.WriteLine("2 - Frear");
                Console.WriteLine("3 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    meuCarro.Acelerar();
                    Console.WriteLine("Velocidade atual do veiculo (" + meuCarro.Modelo+ ", ano " 
                        + meuCarro.Ano +") é de: " + meuCarro.Velocidade + " KM/h!");
                }
                else if (opcao == 2)
                {
                    meuCarro.Frear();
                    Console.WriteLine("Velocidade atual do veiculo (" + meuCarro.Modelo + ", ano "
                        + meuCarro.Ano + ") é de: " + meuCarro.Velocidade + " KM/h!");
                }

                else if (opcao == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }

            Console.WriteLine("Programa encerrado!");
        }
    }
}