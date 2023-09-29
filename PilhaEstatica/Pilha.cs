using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    internal class Pilha
    {
        string[] valores;
        int topo = 0;
        int limite;

        public Pilha(int Tamanho) // construtor >> setup
        { 
            valores = new string[Tamanho];
            limite = Tamanho;
        }

        public void Empilhar(string valor)
        {
            if (topo < limite)
            {
                valores[topo] = valor;
                topo++;
            }
            else
            {
                Console.WriteLine("Pilha cheia");
            }
        }

        public void Desempilhar()
        {
            if (topo > 0)
            {
                //valores[topo - 1] = "";
                topo--;
            }
            else
            {
                Console.WriteLine("Pilha Vazia!");
            }
        }

        public void Imprimir()
        {
            if (topo > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Impressão da Pilha");

                for (int i = (topo - 1); i >= 0; i--)
                {
                    Console.WriteLine(valores[i]);
                }
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }
        }

    }
}
