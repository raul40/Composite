using Composite.Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    public class UAComposite : IClavePresupuestal
    {
        public string UnidadAdministrativa { set; get; }

        protected List<IClavePresupuestal> _children = new List<IClavePresupuestal>();
        public decimal ObtenerTotales()
        {
            decimal dTotal = 0;
            foreach (IClavePresupuestal item in this._children)
            {
                dTotal = dTotal + item.ObtenerTotales();
            }
            Console.WriteLine(string.Format("UA: {0}\nTotal de Cuentas: {1}\n", UnidadAdministrativa, dTotal));
            return dTotal;
        }

        public void Agregar(IClavePresupuestal component)
        {
            this._children.Add(component);
        }

        public void Eliminar(IClavePresupuestal component)
        {
            this._children.Remove(component);
        }
        
    }
}
