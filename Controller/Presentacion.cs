using Composite.Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Controller
{
    public class Presentacion : IPresentacion
    {
        public decimal ObtenerTotal(IClavePresupuestal _ClavePresupuestal)
        {
            return _ClavePresupuestal.ObtenerTotales();
        }
    }
}
