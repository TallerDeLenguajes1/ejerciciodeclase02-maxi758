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
        public float Fondos { get; set; }
        public CuentaBancaria()
        {

        }

        public CuentaBancaria(float fondos)
        {
            Fondos = fondos;
        }
        public void Insercion(int monto)
        {
            Fondos += monto;
        }
        public virtual void Extraccion(int monto, TipoExtraccion tipo)
        {
            Console.WriteLine("vacio");
        }

    }
}
