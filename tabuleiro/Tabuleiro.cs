using System.Runtime.CompilerServices;

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
            // Método retorna o valor contido na mitriz privado de peças.
            return pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {   
            // Método adiciona uma peça em posição específica do matriz de peças, 
            this.pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }





    }
}