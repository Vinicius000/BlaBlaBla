using System;
using TABULEIRO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
