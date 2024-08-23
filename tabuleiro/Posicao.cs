
namespace tabuleiro
{
    internal class Posicao
    {
        // Atributos de classe
        public int linha{ get; set; }
        public int coluna{ get; set; }


        // Contrutores
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }


        // Metodos de Classe
        public override string ToString()
        {
            return $"Linha: {this.linha}\nColuna: {this.coluna}";
        }
    }
}
