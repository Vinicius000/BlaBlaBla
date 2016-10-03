using System;
using TABULEIRO;
using Xadrez;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PosicaoXadrez pos = new PosicaoXadrez('c', 7 );

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            */
            try
            {

                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(4, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch(ExcecaoTabuleiro e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
