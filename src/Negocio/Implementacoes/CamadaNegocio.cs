using FrameWork_Challenge_2.Business;
using FrameWork_Challenge_2.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameWork_Challenge_2.Negocio.Implementacoes
{
    public class CamadaNegocio : ICamadaNegocio
    {
        public int[] GerarNumerosPrimos(int entrada)
        {
            int[] saida;

            Metodos.GetFatoresPrimos(entrada, out saida);

            return saida;
        }
    }
}
