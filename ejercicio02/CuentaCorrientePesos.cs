using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    class CuentaCorrientePesos : CuentaBancaria
    {
        public CuentaCorrientePesos(float fondos) : base(fondos)
        {
        }
        public override void Extraccion(int monto, TipoExtraccion tipo)
        {
            if ((monto - Fondos) > 5000)
            {
                Console.WriteLine("No tiene fondos suficientes");
            }
            else
            {
                if (tipo == TipoExtraccion.CajeroAutomatico)
                {
                    if (monto>20000)
                    {
                        Console.WriteLine("El limite de extracción es de $20.000");
                    }
                    else
                    {
                        Fondos -= monto;
                    }
                }
                else
                {
                    Fondos -= monto;
                }

            }
            

        }
    }
}
