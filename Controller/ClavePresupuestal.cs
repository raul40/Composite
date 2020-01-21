using Composite.Controller.Interfaces;
using Composite.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Controller
{
    public class ClavePresupuestal : IClavePresupuestal
    {
        private readonly ICuentaPresupuestalDTO CPDTO;

        public ClavePresupuestal(ICuentaPresupuestalDTO _ICPDTO)
        {
            CPDTO = _ICPDTO;
        }

        public decimal ObtenerTotales()
        {
            decimal dTotales = CPDTO.dEnero + CPDTO.dFebrero;
            dTotales += CPDTO.dMarzo;
            dTotales += CPDTO.dAbril;


            Console.WriteLine(string.Format("Cuenta: {0} Total: {1}", CPDTO.iIdCP, dTotales));
            return dTotales;
        }
    }
}
