using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper //internal - possui comportamento INTERNO
    {
        
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaTentativa == senhaTentativa;
        }
    }
}
