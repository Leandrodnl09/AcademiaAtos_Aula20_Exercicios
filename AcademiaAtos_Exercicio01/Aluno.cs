using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio01
{
    internal class Aluno
    {
        private string nome;
        private double nota01;
        private double nota02;
        private double nota03;
        private double media;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Nota01
        {
            get { return nota01; }
            set { nota01 = value; }
        }

        public double Nota02
        {
            get { return nota02; }
            set { nota02 = value; }
        }

        public double Nota03
        {
            get { return nota03; }
            set { nota03 = value; }
        }

        public Aluno(string nome, double nota01, double nota02, double nota03)
        {
            Nome = nome;
            Nota01 = nota01;
            Nota02 = nota02;
            Nota03 = nota03;
        }

        public double CalculoMedia(double media)
        {
            return (Nota01 + Nota02 + Nota03) / 3.0;

        }
        public override string ToString()
        {
            if (CalculoMedia(media) >= 60.0) 
            {
                return "Aluno Aprovado!";
            }
            else
            {
                return "Aluno Reprovado!";
            }
        }

        internal object CalculoMedia()
        {
            throw new NotImplementedException();
        }
    }
}

