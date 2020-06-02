using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número total de horas trabalhadas no mês: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor que você ganha por hora trabalhada: R$");
            double valorporhora = double.Parse(Console.ReadLine());

            // calculo para se descobrir o número total de horas extras trabalhadas
            int calculo = horas - 160;

            if (calculo > 0)
            {
                if (calculo <= 5)
                    valorporhora = (horas * valorporhora) + (0.25 * calculo * valorporhora);
                if (calculo <= 10)
                    valorporhora = (horas * valorporhora) + (0.35 * calculo * valorporhora);
                if (calculo <= 15)
                    valorporhora = (horas * valorporhora) + (0.5 * calculo * valorporhora);
                if (calculo > 15)
                    valorporhora = (horas * valorporhora) + (0.6 * calculo * valorporhora);
            } else if (calculo == 0)
                valorporhora = horas * valorporhora;
              else
                valorporhora = 0;

            Console.WriteLine("O seu salário mais o acrescimo é igual a R${0}", valorporhora);
        }
    }
}