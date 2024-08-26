using System.Runtime.CompilerServices;
using XadrezConsole.tabuleiro;

namespace tabuleiro
{
    class Tabuleiro
    {
        // Atributos de Classe
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;



        // Construtor
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }



        // Metódos de classe
        public Peca Peca(int linha, int coluna)
        {            
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
         
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }


        public void ColocarPeca(Peca p, Posicao pos)
        {               
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição");
            }

            this.pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= this.linhas || pos.coluna < 0 || pos.coluna >= this.colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}