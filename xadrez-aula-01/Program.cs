using System;
using Tabuleiro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(1, 2);

            Console.WriteLine("Posicao = " + P);

            Console.ReadLine();
        }
    }
}
