using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class AluguelCarro
    {
        public static double ValorDiaria = 95;
        public static double ValorQuilometro = 0.35;

        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            return ((quilometragemFinal - quilometragemInicial) * ValorQuilometro) + (dias * ValorDiaria);
        }
    }
}
