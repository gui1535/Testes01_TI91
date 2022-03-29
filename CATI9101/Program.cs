using System;

namespace CATI9101
{
    internal class Program
    {
        // Atributos

        // Construtores - Criam e inicializam instancias

        // Metodos de acesso (get e set) - C# -> Propriedades

        // Metodos da classe - função, operação, ação do objeto

        static void Main(string[] args) // void nao retorna
        {
            // Declarar variavel    
            var x = 10;
            var nome = "Gui";
            var teste = true;
            var valor = 12.89;
            var num = 15f;
            var y = false;


            byte[] vetor = new byte[3]; // Matriz de bytes / byte vai de 0~255
            vetor[0] = 71;
            vetor[1] = 117;
            vetor[2] = 105;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }




            byte l = 0;


            int w;
            //w += 1; // w = w + 1
            double A, B, C, D;
            A = 2.55;


            // Formas de conversões de tipos

            Console.ReadKey(); // Ler tecla

        }
        public static int Exibir(int x) {
            x = x*9;
            return x;
        }
    }
}

/*
          Console.WriteLine("Digite seu nome: ");
              string nome = Console.ReadLine();
          Console.WriteLine("Bom dia " + nome);
          Console.ReadKey();
          */