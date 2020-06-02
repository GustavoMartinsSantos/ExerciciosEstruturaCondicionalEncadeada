using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("Esse número é positivo.");
            else if (num < 0)
                Console.WriteLine("Esse número é negativo.");
            else
                Console.WriteLine("Esse número é igual a 0.");
        }
    }
}