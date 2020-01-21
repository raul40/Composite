using Composite.Controller;
using Composite.Controller.Interfaces;
using Composite.Recuperadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
        }

        private static void Init()
        {
            IRecuperadorCP Recuperador = new RecuperadorCP();
            IClavePresupuestal Component = Recuperador.ObtenerClavePresupuestal();
            IPresentacion Presentacion = new Presentacion();
            decimal dTotal = Presentacion.ObtenerTotal(Component);
            Console.WriteLine(string.Format("Totales Cuentas Arbol: {0}", dTotal));

            Console.ReadLine();
        }
    }
}
