using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arvore arvore = new Arvore();

            Console.WriteLine("1- Inserir um número na árvore AVL\r\n2- Remover um número da árvore AVL\r\n3- Pesquisar um número na árvore AVL\r\n4- Mostrar todos os elementos da árvore AVL, usando o caminhamento central\r\n5- Mostrar todos os elementos da árvore AVL, usando o caminhamento pós-ordem.\r\n6- Mostrar todos os elementos da árvore AVL, usando o caminhamento pré-ordem.\r\n7- Sair");

            int opcao= int.Parse(Console.ReadLine());
            do
            {

                switch (opcao)
                {
                    case 1:
                        Console.Write("Escolha um número para inserir na árvore: ");
                        int numInserir = int.Parse(Console.ReadLine());
                        Inteiro inteiro = new Inteiro(numInserir);
                        arvore.Inserir(inteiro);
                        break;
                    case 2:
                        Console.Write("Escolha um número para remover da árvore: ");
                        int numRemover = int.Parse(Console.ReadLine());
                        arvore.Remover(numRemover);
                        Console.WriteLine("Item removido");
                        break;
                    case 3:
                        Console.Write("Escolha um número para pesquisar na árvore: ");
                        int numPesquisar = int.Parse(Console.ReadLine());
                       if(arvore.Pesquisar(numPesquisar)!= null)
                        {
                            Console.WriteLine("Número encontrado: " );
                        } 
                       else
                            Console.WriteLine("Número nao encontrado: ");
                        break;

                    case 4:
                        Console.WriteLine("Elementos da árvore, usando o caminhamento central:");
                        arvore.Ordem();
                        break;
                    case 5:
                        Console.WriteLine("Elementos da árvore, usando o caminhamento pós-ordem:");
                        arvore.PosOrdem();
                        break;
                    case 6:
                        Console.WriteLine("Elementos da árvore, usando o caminhamento pré-ordem:");
                        arvore.PreOrdem();
                        break;

                    default:
                        Console.WriteLine("Escolha um número válido");
                        break;
                }
                Console.WriteLine("1- Inserir um número na árvore AVL\r\n2- Remover um número da árvore AVL\r\n3- Pesquisar um número na árvore AVL\r\n4- Mostrar todos os elementos da árvore AVL, usando o caminhamento central\r\n5- Mostrar todos os elementos da árvore AVL, usando o caminhamento pós-ordem.\r\n6- Mostrar todos os elementos da árvore AVL, usando o caminhamento pré-ordem.\r\n7- Sair");

                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 7);
                Console.ReadKey();
        }
    }
}
