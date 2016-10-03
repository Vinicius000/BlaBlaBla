using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABULEIRO
{
    class ExcecaoTabuleiro : Exception
    {
        public excecaoTabuleiro(string msg) : base(msg)
        {}
    }
}
