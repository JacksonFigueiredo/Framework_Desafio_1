using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameWork_Challenge_2.Business
{
    public class Metodos
    {
        static public int GetFatoresPrimos(int numero, out int[] arrResultado)
        {

            const int MAX_SIZE = 15000;
            int contador = 0;
            int[] vetor = new int[MAX_SIZE];
            arrResultado = new int[MAX_SIZE];
            int i = 0;
            int indice = 0;
            for (i = 2; i <= numero; i++)
            {
                if (IsNumeroPrimo(i) == true)
                    vetor[contador++] = i;
            }

            while (true)
            {
                if (IsNumeroPrimo(numero) == true)
                {
                    arrResultado[indice++] = numero;
                    break;
                }

                for (i = contador - 1; i >= 0; i--)
                {
                    if ((numero % vetor[i]) == 0)
                    {
                        arrResultado[indice++] = vetor[i];
                        numero = numero / vetor[i];
                        break;
                    }
                }
            }
            return indice;
        }

        static bool IsNumeroPrimo(int numero)
        {
            bool bPrimo = true;
            int fator = numero / 2;
            int i = 0;
            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    bPrimo = false;
            }
            return bPrimo;
        }

    }
}
