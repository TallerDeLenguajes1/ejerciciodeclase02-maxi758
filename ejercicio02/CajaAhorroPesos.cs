using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    class CajaAhorroPesos : CuentaBancaria
    {
        public CajaAhorroPesos(float monto) : base(monto)
        {
        }
        public override void extraccion(int monto, TipoExtraccion tipo)
        {

        }
    }
}
