using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estrutura_Sequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 2

            Console.WriteLine("Digite o comprimento do terreno:");
            double comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a largura do terreno");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = largura * comprimento;
            Console.WriteLine("Digite o preço do metro quadrado:");
            double precometroquadrado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double preco = area * precometroquadrado;
            Console.WriteLine("Área = " + area.ToString("F2"),CultureInfo.InvariantCulture);
            Console.WriteLine("preço = " + preco.ToString("F2"), CultureInfo.InvariantCulture);

            //Exercício 2


        }
    }
}
