﻿using System;
using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidadeXadrez partida = new PartidadeXadrez();
                



                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
