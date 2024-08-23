
using tabuleiro;

namespace tabuleiro
{
    internal class Peca
    {
        // Atributos de classe
        public Posicao posicao{ get; set; }
        public Cor cor { get; protected set; }
        public int qntMovimentos{ get; protected set; }
        public Tabuleiro tabuleiro{ get; protected set; }


        // Construtor
        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qntMovimentos = 0;
        }
    }
}
