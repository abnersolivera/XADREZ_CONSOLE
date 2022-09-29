using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c',1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
        }
    }
}