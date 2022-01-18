using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameWork_Challenge_2.Negocio.Interfaces
{
    public interface ICamadaNegocio
    {
        NumerosPrimos GerarNumerosPrimos(NumerosPrimos entrada);
    }
}
