using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    class CuentaCorrienteDolares : CuentaBancaria
    {
        public CuentaCorrienteDolares(float fondos) : base(fondos)
        {
        }
        public override void Extraccion(int monto, TipoExtraccion tipo)
        {
            if ((Fondos - monto) < 0)
            {
                Console.WriteLine("No tiene fondos suficientes");
            }
            else
            {
                if (tipo == TipoExtraccion.CajeroAutomatico)
                {
                    if (monto > 200)
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
