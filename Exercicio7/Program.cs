using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            string categoria = "(indefinida)";

            if (idade >= 0) { 
                if (idade <= 12)
                    categoria = "Infantil";
                else if (idade <= 17)
                    categoria = "Juvenil";
                else if (idade <= 23)
                    categoria = "Jovem";
                else if (idade <= 34)
                    categoria = "Profissional";
                else 
                    categoria = "Sênior";
            } 

            Console.WriteLine("{0}, você está inserido na categoria {1}", nome, categoria);
        }
    }
}