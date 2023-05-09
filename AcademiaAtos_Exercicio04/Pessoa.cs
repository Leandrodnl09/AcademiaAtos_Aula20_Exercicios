using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio04
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private float altura;

        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public float getAltura()
        {
            return altura;
        }
    }
}
