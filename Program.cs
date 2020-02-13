using System;
using System.IO;
namespace EXERCICIO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string acao = "";
            string caminho = "gravados.txt";
            string nome = "", email = "",telefone = "", rg = "";
            Console.WriteLine("G - Gravar");
            Console.WriteLine("L-Ler");
            Console.WriteLine("S- Sair");
            
            acao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            while (acao != "S")
            {
                if (acao == "G")
                {
                    Console.Write("Informe seu nome: ");
                    nome = Console.ReadLine();

                    Console.Write("Informe seu e-mail: ");
                    email = Console.ReadLine();

                    Console.Write("Informe seu telefone:  ");
                    telefone = Console.ReadLine();

                    Console.Write("Informe seu RG: ");
                    rg = Console.ReadLine();

                    StreamWriter sw = new StreamWriter(caminho, true);

                    sw.WriteLine("Nome: " + nome);
                    sw.WriteLine("E-mail: " + email);
                    sw.WriteLine("Telefone: " + telefone);
                    sw.WriteLine("RG: " + rg);

                    sw.Close();

                }
                else if (acao == "L")
                {
                    StreamReader sr = new StreamReader(caminho);
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }

                Console.WriteLine();
                Console.WriteLine("Pressione uma tecla");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("G - Gravar");
                Console.WriteLine("L-Ler");
                Console.WriteLine("S- Sair");

                Console.Write("Digite uma operação: ");

                acao = Console.ReadLine().ToUpper();
                Console.WriteLine();

                {
                   
                }
            }
        }
    }
}
