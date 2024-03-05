using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inteiro
    {

        private int valor;
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Inteiro(int valor)
        {
            this.valor = valor;
        }

        public Inteiro()
        {
            valor = 0;
        }

        public void imprimir()
        {
            Console.WriteLine("Valor -> " + valor);
        }
    }
}
