using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class No
    {
        private Inteiro item;
        public Inteiro Item
        {
            get { return item; }
            set { item = value; }
        }

        private No esquerda;
        public No Esquerda
        {
            get { return esquerda; }
            set { esquerda = value; }
        }

        private No direita;
        public No Direita
        {
            get { return direita; }
            set { direita = value; }
        }

        private int altura;
        public int Altura
        {
            get { return altura; }
        }

        public No()
        {

            item = new Inteiro();
            esquerda = null;
            direita = null;
            altura = 0;
        }

        public No(Inteiro registro)
        {

            item = registro;
            esquerda = null;
            direita = null;
            altura = 0;
        }

        public void setAltura()
        {

            int alturaEsq, alturaDir;

            if (this.direita == null)
                alturaDir = -1;
            else
                alturaDir = this.direita.Altura;

            if (this.esquerda == null)
                alturaEsq = -1;
            else
                alturaEsq = this.esquerda.Altura;

            if (alturaEsq > alturaDir)
                this.altura = alturaEsq + 1;
            else
                this.altura = alturaDir + 1;
        }

        public int Getfab()
        {

            int alturaEsq, alturaDir;

            if (this.direita == null)
                alturaDir = -1;
            else
                alturaDir = this.direita.Altura;

            if (this.esquerda == null)
                alturaEsq = -1;
            else
                alturaEsq = this.esquerda.Altura;

            return (alturaEsq - alturaDir);
        }
    }
}