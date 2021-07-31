using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da nota 1: ");
            double nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double soma = nota1 / nota2;
            Console.WriteLine("A divisão notas é:" + soma);

        }
    }
}
