using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio04
{
    internal class Agenda
    {
        private Pessoa[] pessoas = new Pessoa[10];
        private int indice = 0;

        public void armazenaPessoa(string nome, int idade, float altura)
        {
            if (indice < 10)
            {
                Pessoa novaPessoa = new Pessoa(nome, idade, altura);
                pessoas[indice] = novaPessoa;
                indice++;
            }
            else
            {
                Console.WriteLine("Agenda cheia!");
            }
        }

        public void removePessoa(string nome)
        {
            bool encontrou = false;
            for (int i = 0; i < indice; i++)
            {
                if (pessoas[i].getNome() == nome)
                {
                    encontrou = true;
                    for (int j = i; j < indice - 1; j++)
                    {
                        pessoas[j] = pessoas[j + 1];
                    }
                    indice--;
                    break;
                }
            }
            if (!encontrou)
            {
                Console.WriteLine("Pessoa não encontrada na agenda!");
            }
        }

        public Pessoa buscaPessoa(string nome)
        {
            for (int i = 0; i < indice; i++)
            {
                if (pessoas[i].getNome() == nome)
                {
                    return pessoas[i];
                }
            }
            return null;
        }

        public void imprimeAgenda()
        {
            Console.WriteLine("Agenda:");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(pessoas[i].getNome() + ", " + pessoas[i].getIdade() + " anos, " + pessoas[i].getAltura() + "m");
            }
        }
    }
}
