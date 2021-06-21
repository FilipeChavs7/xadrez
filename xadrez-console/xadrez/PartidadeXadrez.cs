using System;
using tabuleiro;

namespace xadrez
{
    class PartidadeXadrez
    {
        public Tabuleiro tab; { get; set; }
        private int turno;
        private Cor jogadorAtual;

        public PartidadeXadrez()
        {
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementaQtdMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 4));
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 3));
        }
    }
}
