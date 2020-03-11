using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLC1P1.AnalizadorL
{
    class Token
    {
        public string lexema;
        public string tipoLex;
        public int fila;
        public int col;

        public Token(string lexema, string tipoLex, int fila, int col) {
            this.lexema = lexema;
            this.tipoLex = tipoLex;
            this.fila = fila;
            this.col = col;
        }
    }
}
