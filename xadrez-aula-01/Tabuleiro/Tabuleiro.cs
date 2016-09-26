﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABULEIRO
{
    class Tabuleiro
    {

        private Peca[,] pecas;
        public int linhas { get; set; }
        public int colunas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        
    }
}