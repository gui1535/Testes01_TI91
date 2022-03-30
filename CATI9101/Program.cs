using System;

namespace CATI9101
{
    internal class Program
    {
        // Main
        static void Main(string[] args)
        {
            //Tabuada();
            Matriz();

            Console.ReadKey();
        }

        static void Matriz()
        {
            // Declaração de matrizes
            string[] jogadores = { "José", "Paulo", "Gabriel", "Julio", "Marcos" };
            // int[,] pontos = { { 0, 2 }, { 1, 3 }, { 2, 5 }, { 3, 4 } };
            string[] times = new string[5];
            int[,] tabela = new int[5, 6];

            /*
            int[,] m = new int[4, 2];
            m[0, 0] = 0;
            m[1, 0] = 1;
            m[2, 0] = 2;
            m[3, 0] = 3;
            m[0, 1] = 4;
            */
            foreach (string jogador in jogadores)
            {
                Console.WriteLine(jogador);
            }
        }


        // Tabuada
        /*
        static void Tabuada()
        {
        int[] vnumero = new int[10];
        string sair = string.Empty;
        int cont = 10;
            while (sair != "s" && cont > 0)
            {
                Console.WriteLine("Digite um numero de 1 a 10: ");

                bool atender = false;
                int numero = int.Parse(Console.ReadLine());
                do
                {
                    if (numero > 0 && numero < 11)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"{numero} X {i + 1} = {numero * (i + 1)}");
                        }
                        atender = true;

                    }
                    else
                    {
                        atender = false;
                        Console.WriteLine("Você igite um numero de 1 a 10");
                        numero = int.Parse(Console.ReadLine());
                    }
                } while (!atender);
                cont--; // decrementa um número na variável contador
                vnumero[cont] = numero;

                Console.WriteLine("Deseja sair? (s) ou enter para continuar:");
                sair = Console.ReadLine();
                Console.Clear(); // limpa o console 
            }// fim do While
            Console.WriteLine();
            Console.Write("Você exibiu as tabuadas dos números ");
            foreach (var item in vnumero)
            {
                Console.Write($"{item} | ");
            }
        }
        */
    }
}