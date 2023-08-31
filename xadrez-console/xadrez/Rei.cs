using System;
using tabuleiro;

namespace xadrez {
    class Rei : Peca {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(pos.linha - 1, pos.coluna);
             if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //diagonal superior direita
            pos.definirValores(pos.linha - 1, pos.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //diagonal superior esquerda
            pos.definirValores(pos.linha - 1, pos.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //esquerda
            pos.definirValores(pos.linha, pos.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //direita
            pos.definirValores(pos.linha, pos.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //diagonal inferior direita
            pos.definirValores(pos.linha + 1, pos.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //diagonal inferior esquerda
            pos.definirValores(pos.linha + 1, pos.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //baixo
            pos.definirValores(pos.linha + 1, pos.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
