using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de três números: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("O maior desses números é {0}", num1);
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine("O maior desses números é {0}", num2);
            else if (num3 > num1 && num3 > num2)
                Console.WriteLine("O maior desses números é {0}", num3);
            else
                Console.WriteLine("Esses valores são iguais.");
        }
    }
}