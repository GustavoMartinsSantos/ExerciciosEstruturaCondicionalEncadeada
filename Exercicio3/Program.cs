using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de maçãs que você vai comprar: ");
            double num = int.Parse(Console.ReadLine());

            if (num < 12 && num > 0)
                num = num * 0.3;
            else if (num >= 12 && num < 20)
                num = num * 0.25;
            else if (num >= 20 && num <= 24)
                num = num * 0.2;
            else if (num >= 25)
                num = num * 0.15;
            else
                num = 0;
            
            Console.WriteLine("O valor dessa compra é de R$" + num);
        }
    }
}