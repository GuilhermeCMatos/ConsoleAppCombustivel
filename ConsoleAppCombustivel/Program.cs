using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do litro da gasolina: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distancia percorrida em km: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos km o carro faz por litro: ");
            double l = double.Parse(Console.ReadLine());

            double resultado = (d / l) * c;

            Console.WriteLine("1- O total gasto foi: R$" + resultado);

            Console.ReadKey();
        }
    }
}
