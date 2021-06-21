using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }
        public void incrementaQtdMovimento()
        {
            qtdMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
