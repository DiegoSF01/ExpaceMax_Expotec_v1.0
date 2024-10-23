using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ArenaDeBatalha.ObjetosDoJogo
{
    public static class ControladorPontuacao
    {
        private static int pontuacao;

        public static int Pontuacao
        {
            get
            {
                return pontuacao;
            }
            set
            {
                pontuacao = value;
                if (pontuacao < 0)
                {
                    pontuacao = 0;
                }

            }
        }
    }
}
