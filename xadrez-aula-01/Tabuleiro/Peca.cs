﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABULEIRO
{
    class Peca
    {

        public Posicao posicao { get; set; }    
        public Tabuleiro tab { get; protected set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimento { get; protected set; } 
        
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.quantidadeMovimento = 0;
        }

    }
}
