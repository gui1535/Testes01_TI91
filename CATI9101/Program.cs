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
            /* // Declarar variavel
             var x = 10;
             var nome = "Gui";
             var teste = true;
             var valor = 12.89;
             var num = 15f;
             var y = false;

 /*
             byte[] vetor = new byte[3]; // Matriz de bytes / byte vai de 0~255
             vetor[0] = 71;
             vetor[1] = 117;
             vetor[2] = 105;

             for (int i = 0; i < vetor.Length; i++)
             {
                 Console.WriteLine(vetor[i]);
             }
 */
            // --------------------------------------------------------------------------------------//
            // Variaveis
            /*
            byte l = 255; // 0~255
            short s = 32767; // 16bits
            ushort ss = 65535; // Valores positivos até 16bits
            int w; //w += 1; // w = w + 1
            double A, B, C, D;
            A = 2.55;
            float c = 10.66f;
            uint ww = 2147483648;
            ulong t = 782378217817821283; // 64^2
            long tt = 231223131212331231; // 64^2
            string m = "Senac";
           // m = m.Substring(2, 1); // Recuperar letra N


            bool chk = false;
            if (!chk)
            {
for (int i = 0; i < m.Length; i++)
            {

                   // Console.WriteLine(m.Substring(i, 1));
                }
                chk = true;
            }
// --------------------------------------------------------------------------------------//
           
            // Formas de conversões de tipos

            Console.ReadKey(); // Ler tecla
             */

            Console.WriteLine("Digite seu nome");
            string nome =Console.ReadLine();
            Console.WriteLine("Digite o ano de seu nascimento: ");
            // int ano = (int)Console.ReadLine(); // cast
            // int ano = int.Parse(Console.ReadLine()); // parse
            short ano = Convert.ToInt16(Console.ReadLine()); // classe convert
            byte idade = (byte)(DateTime.Now.Year - (byte)ano);
            Console.WriteLine("Ola {0}, sua idade é {1} anos", nome, idade);
            Console.ReadKey();
        }
    }
}

/*
          Console.WriteLine("Digite seu nome: ");
              string nome = Console.ReadLine();
          Console.WriteLine("Bom dia " + nome);
          Console.ReadKey();
// Copilot
          */