using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Exercicio02
{
    internal class Carro
    {       
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Frear()
        {
            Velocidade -= 10;
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
        }
    }
}
