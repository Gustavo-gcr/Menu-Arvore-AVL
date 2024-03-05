using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arvore
    {
        private No raiz;

        public Arvore()
        {

            raiz = null;
        }

        public Inteiro Pesquisar(int chave)
        {
            return Pesquisar(this.raiz, chave);
        }

       
        private Inteiro Pesquisar(No i, int chave)
        {

            if (i == null)
                return null;
            else if (chave == i.Item.Valor)
                return i.Item;
            else if (chave > i.Item.Valor)
                return Pesquisar(i.Direita, chave);
            else
                return Pesquisar(i.Esquerda, chave);
        }

        public void Inserir(Inteiro novo)
        {
            this.raiz = Inserir(this.raiz, novo);
        }

       
        private No Inserir(No i, Inteiro novo)
        {

            if (i == null)
                i = new No(novo);
            else if (novo.Valor == i.Item.Valor)
                throw new Exception("ERRO!");
            else if (novo.Valor < i.Item.Valor)
                i.Esquerda = Inserir(i.Esquerda, novo);
            else
                i.Direita = Inserir(i.Direita, novo);

            return Balancear(i);
        }

        private No Balancear(No i)
        {

            int fatorB;
            int fatorBFilho;

            fatorB = i.Getfab();

            if (fatorB == 2)
            {
                fatorBFilho = i.Esquerda.Getfab();
                if (fatorBFilho == -1)
                {

                    i.Esquerda = RotacionarEsq(i.Esquerda);
                }

                i = RotacionarDir(i);
            }
            else if (fatorB == -2)
            {

                fatorBFilho = i.Direita.Getfab();
                if (fatorBFilho == 1)
                {

                    i.Direita = RotacionarDir(i.Direita);
                }

                i = RotacionarEsq(i);
            }
            else
                i.setAltura();

            return i;
        }

        private No RotacionarDir(No p)
        {

            No u = p.Esquerda;
            No filhoEsqDir = u.Direita;  

            u.Direita = p;
            p.Esquerda = filhoEsqDir;

            p.setAltura();
            u.setAltura();

            return u;
        }

        private No RotacionarEsq(No p)
        {

            No z = p.Direita;
            No filhoDirEsq = z.Esquerda; 

            z.Esquerda = p;
            p.Direita = filhoDirEsq;

            p.setAltura();
            z.setAltura();

            return z;
        }


        public void Remover(int chaveRemover)
        {
            this.raiz = Remover(this.raiz, chaveRemover);
        }

        private No Remover(No i, int chaveRemover)
        {

            if (i == null)
                throw new Exception("ERRO!");
            else if (chaveRemover == i.Item.Valor)
            {
                if (i.Esquerda == null)
                    i = i.Direita;
                else if (i.Direita == null)
                    i = i.Esquerda;
                else
                    i.Esquerda = Antecessor(i, i.Esquerda);
            }
            else if (chaveRemover > i.Item.Valor)
                i.Direita = Remover(i.Direita, chaveRemover);
            else
                i.Esquerda = Remover(i.Esquerda, chaveRemover);

            return Balancear(i);
        }

        private No Antecessor(No noRetirar, No i)
        {

            if (i.Direita != null)
                i.Direita = Antecessor(noRetirar, i.Direita);
            else
            {
                noRetirar.Item = i.Item;
                i = i.Esquerda;
            }

            return Balancear(i);
        }

        public void Ordem()
        {
            Ordem(this.raiz);
        }

        private void Ordem(No i)
        {

            if (i != null)
            {
                Ordem(i.Esquerda);
                i.Item.imprimir();
                Ordem(i.Direita);
            }
        }
        public void PreOrdem()
        {
            PreOrdem(this.raiz);
        }

        private void PreOrdem(No i)
        {
            if (i != null)
            {
                i.Item.imprimir(); 
                PreOrdem(i.Esquerda);
                PreOrdem(i.Direita);
            }
        }

        public void PosOrdem()
        {
            PosOrdem(this.raiz);
        }

        private void PosOrdem(No i)
        {
            if (i != null)
            {
                PosOrdem(i.Esquerda);
                PosOrdem(i.Direita);
                i.Item.imprimir(); 
            }
        }
    }
}
