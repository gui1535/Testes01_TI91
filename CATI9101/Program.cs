using System;

namespace CATI9101
{
    internal class Program
    {
        // Main
        static void Main(string[] args)
        {
            ManiString();

            Console.ReadKey();

        }

        // Matriz
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
            for (int i = 0; i < jogadores.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}° primeiro jogador");
                jogadores[i] = Console.ReadLine();
            }
        }

        // Tabuada
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

        // Manipulação de Strings
        static void ManiString()
        {
            string nome = "Guilherme Araujo";

            // Retornar numeros de caracteres
            //Console.WriteLine(nome.Length);

            // Removendo espaços do começo e do fim
            //nome = nome.Trim();
            //Console.WriteLine(nome + " - " + nome.Length);

            // Exibindo primeiro 3 caracteres de nomes
            //Console.WriteLine(nome.Substring(0,3));

            // Removendo string e mantem os 4 primeiros
            //nome = nome.Remove(4);
            //Console.WriteLine(nome);

            // Substituindo caracteres
            //Console.WriteLine(nome.Replace("", ""));

            // Inserir string
            //Console.WriteLine(nome.Insert(3, " A"));

            // Retorna a posição da string "i"
            //Console.WriteLine(nome.IndexOf("i"));

            // Converte em maiusculo
            //Console.WriteLine(nome.ToUpper());

            // Converte em minusculo
            //Console.WriteLine(nome.ToLower());

            // Divide uma String em um vetor de strings
            //string[] vnome;
            //vnome = nome.Split(' ');
            //for (int i = 0; i < vnome.Length;i++)
            //{
            //Console.WriteLine(vnome[i]);
            //}

            // Alterando variavel para manter so os 4 primeiros caracteres
            //nome = nome.Substring(0, 3));
            string texto = "socorra-me subi no onibus em marrocos";
            Console.WriteLine(texto);
            string textoinv = string.Empty;
            for (int i = texto.Length - 1; i > -1; i--)
            {
                textoinv += texto.Substring(i, 1);
            }
            Console.WriteLine(textoinv);
        }

        // Tipos de Conversão
        static void TiposConversao()
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de seu nascimento: ");
            // int ano = (int)Console.ReadLine(); // cast
            // int ano = int.Parse(Console.ReadLine()); // parse
            string ano = Console.ReadLine(); // classe convert
            int idade = DateTime.Now.Year - int.Parse(ano);
            Console.WriteLine("Ola {0}, sua idade é {1} anos", nome, idade);
            Console.ReadKey();
        }

        // Variaveis
        static void Variaveis()
        {
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
        }
    }
}