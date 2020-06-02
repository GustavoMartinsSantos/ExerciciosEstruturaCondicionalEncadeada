using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de três números diferentes: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            string ordem;

            if (num1 > num2 && num1 > num3 && num2 > num3)
                ordem = num1 + "_" + num2 + "_" + num3 + ".";
            else if (num1 > num2 && num1 > num3 && num3 > num2)
                ordem = num1 + "_" + num3 + "_" + num2 + ".";
            else if (num2 > num1 && num2 > num3 && num1 > num3)
                ordem = num2 + "_" + num1 + "_" + num3 + ".";
            else if (num2 > num1 && num2 > num3 && num3 > num1)
                ordem = num2 + "_" + num3 + "_" + num1 + ".";
            else if (num3 > num1 && num3 > num2 && num2 > num1)
                ordem = num3 + "_" + num2 + "_" + num1 + ".";
            else if (num3 > num1 && num3 > num2 && num1 > num2)
                ordem = num3 + "_" + num1 + "_" + num2 + ".";
            else
                ordem = "Você digitou o valor errado!";

            Console.WriteLine(ordem);
        }
    }
}