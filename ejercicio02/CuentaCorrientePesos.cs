using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    class CuentaCorrientePesos : CuentaBancaria
    {
        public CuentaCorrientePesos(float monto) : base(monto)
        {
        }
        public override void extraccion(int monto, TipoExtraccion tipo)
        {

        }
    }
}
