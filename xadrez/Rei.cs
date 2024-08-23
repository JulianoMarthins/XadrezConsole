using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace XadrezConsole.xadrez
{
    internal class Rei : Peca
    {
        // construtor
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor){}


        // Métodos
        public override string ToString()
        {
            return "R";
        }

    }
}
