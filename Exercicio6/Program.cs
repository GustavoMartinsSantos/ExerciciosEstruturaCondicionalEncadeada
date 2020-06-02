using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 10)
                Console.WriteLine("Esse número é menor que 10.");
            else if (num <= 19)
                Console.WriteLine("Esse número está entre 10 e 19.");
            else if (num <= 30)
                Console.WriteLine("Esse número está entre 19 e 30.");
            else
                Console.WriteLine("Esse número é maior que 30.");
        }
    }
}