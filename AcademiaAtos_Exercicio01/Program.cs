namespace AcademiaAtos_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Crie uma classe "Aluno" com os atributos "nome", "nota1", "nota2" e "nota3". Os atributos devem ser privados e
            // acessados através de propriedades. Em seguida, crie um método para calcular a média e verificar se o aluno está aprovado
            // ou reprovado(se a nota for maior ou igual a 6, está aprovado, senão está reprovado).

            
            List<Aluno> alunos = new List<Aluno>();
            Console.WriteLine("Bem - vindo ao sistema do aluno!");
            int cont = 1;
            
            while (true)
            {
                Console.WriteLine($"Digite o nome do {cont}º aluno: ");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite a nota 01 do aluno: ");
                double nota01 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a nota 02 do aluno: ");
                double nota02 = double.Parse(Console.ReadLine()); 
                Console.WriteLine($"Digite a nota 03 do aluno: ");
                double nota03 = double.Parse(Console.ReadLine());

                Aluno aluno =  new Aluno(nome, nota01, nota02, nota03);
                

                alunos.Add( aluno );

                Console.WriteLine();
                Console.Write("Deseja adicionar mais algum aluno (s/n)? ");
                char repetir = char.Parse(Console.ReadLine().ToLower());    
                if ( repetir == 's') 
                {
                    cont++;
                    continue;
                }
                else
                {
                    break;
                }
            }
            double somaNotas = 0;
            
            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine("Aluno {0}:", i + 1);
                Console.WriteLine("Nome: {0}", alunos[i].Nome);
                Console.WriteLine($"Notas: {alunos[i].Nota01}, {alunos[i].Nota02}, {alunos[i].Nota03}");
            }
            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine($"Média do aluno {alunos[i].Nome}: {alunos[i].CalculoMedia(somaNotas).ToString("F2")} : {alunos[i].ToString()}");
            }
        }
    }
}