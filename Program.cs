using System;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, irei lhe ajudar a converter seu número para extenso");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();

             int Extenso = Convert.ToInt32(Console.ReadLine());

            // int quer dizer que estaremos trabalhando com um número inteiro
            // Extenso é a variável escolhida 

            Console.Write("Digite o número a ser escrito por extenso...");

            Console.WriteLine($"Seu número por extenso é igual a: {Extenso.ToWords()}.");




        }
    }
}
