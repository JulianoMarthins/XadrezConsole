namespace tabuleiro
{
    public class Tabuleiro
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
            this.pecas = new Peca[linhas, colunas];
        }
    }
}