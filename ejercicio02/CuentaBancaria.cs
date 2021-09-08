using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    public enum TipoExtraccion
    {
        CajeroHumano=1,
        CajeroAutomatico=2
    }
    class CuentaBancaria
    {
        public float Monto { get; set; }
        public CuentaBancaria()
        {

        }

        public CuentaBancaria(float monto)
        {
            Monto = monto;
        }
        public void insercion(int monto)
        {

        }
        public virtual void extraccion(int monto, TipoExtraccion tipo)
        {
            Console.WriteLine("vacio");
        }

    }
}
