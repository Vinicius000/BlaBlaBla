using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");

            int x = int.Parse(Console.ReadLine());

            int y = 2 * x;

            Console.WriteLine("DOBRO = " + y);

            Console.ReadLine();
        }
    }
}
