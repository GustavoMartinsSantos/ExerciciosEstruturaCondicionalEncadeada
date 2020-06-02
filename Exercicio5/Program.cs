using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor em dinheiro que você tem sobrando: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor < 30)
                Console.WriteLine("Fique em casa vendo tv.");
            else if (valor < 50)
                Console.WriteLine("Vá ao cinema!");
            else
                Console.WriteLine("Vá jantar fora!");
        }
    }
}