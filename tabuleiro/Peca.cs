
using tabuleiro;

namespace tabuleiro
{
    internal class Peca
    {
        // Atributos de classe
        public Posicao posicao{ get; set; }
        public Cor cor{ get; protected set; }
        public int qntMovimento{ get; protected set; }
        public Tabuleiro tabuleiro{ get; set; }


        // Construtor
        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qntMovimento = 0;
        }


    }
}
