﻿using System;
using tabuleiro;

namespace XadrezConsole
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for(int i = 0; i < tabuleiro.linhas; i++)
            {
                for(int j = 0; j < tabuleiro.colunas; j++)
                {
                    if(tabuleiro.Peca(i,j) == null){
                        Console.Write(" -");
                    }
                    else
                    {
                        Console.Write(tabuleiro.Peca(i, j));
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
