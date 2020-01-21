using Composite.Composite;
using Composite.Controller;
using Composite.Controller.Interfaces;
using Composite.Repo;
using Composite.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Recuperadores
{
    public class RecuperadorCP : IRecuperadorCP
    {

        public IClavePresupuestal ObtenerClavePresupuestal()
        {
            #region CP - 1
            ClavePresupuestal C111_1 = new ClavePresupuestal(LlenarDTO());
            UAComposite component111 = LlenarUA("1.1.1", C111_1);

            ClavePresupuestal C112_1 = new ClavePresupuestal(LlenarDTO());
            UAComposite component112 = LlenarUA("1.1.2", C112_1);

            ClavePresupuestal C121_1 = new ClavePresupuestal(LlenarDTO());
            UAComposite component121 = LlenarUA("1.2.1", C121_1);

            ClavePresupuestal C122_1 = new ClavePresupuestal(LlenarDTO());
            UAComposite component122 = LlenarUA("1.2.2", C122_1);

            UAComposite component11 = LlenarUA("1.1", component111);
            component11.Agregar(component112);

            UAComposite component12 = LlenarUA("1.2", component121);
            component12.Agregar(component122);

            UAComposite component1 = LlenarUA("1", component11);
            component1.Agregar(component12);
            #endregion

            #region CP - 2
            ClavePresupuestal C211_1 = new ClavePresupuestal(LlenarDTO());
            UAComposite component211 = LlenarUA("2.1.1", C211_1);

            ClavePresupuestal C212_1 = new ClavePresupuestal(LlenarDTO());
            UAComposite component212 = LlenarUA("2.1.2", C212_1);

            ClavePresupuestal C221_1 = new ClavePresupuestal(LlenarDTO());
            UAComposite component221 = LlenarUA("2.2.1", C221_1);

            ClavePresupuestal C222_1 = new ClavePresupuestal(LlenarDTO());
            UAComposite component222 = LlenarUA("2.2.2", C222_1);

            UAComposite component21 = LlenarUA("2.1", component211);
            component21.Agregar(component212);

            UAComposite component22 = LlenarUA("2.2", component221);
            component22.Agregar(component222);

            UAComposite component2 = LlenarUA("2", component21);
            component2.Agregar(component22);
            #endregion

            #region CP - 3
            ClavePresupuestal C311_1 = new ClavePresupuestal(LlenarDTO());

            UAComposite component31 = LlenarUA("3.1", C311_1);

            UAComposite component3 = LlenarUA("3", component31);
            #endregion

            #region CP - 4
            ClavePresupuestal C41_1 = new ClavePresupuestal(LlenarDTO());

            UAComposite component4 = LlenarUA("4", C41_1);
            #endregion


            UAComposite component = LlenarUA("X", component1);
            component.Agregar(component2);
            component.Agregar(component3);
            component.Agregar(component4);
            return component;
        }

        private ICuentaPresupuestalDTO LlenarDTO()
        {
            CuentaPresupuestalDTO cuentas = new CuentaPresupuestalDTO();
            Random random = new Random();
            cuentas.iIdCP = random.Next(1, 100);
            cuentas.dEnero = random.Next(101, 200);
            cuentas.dFebrero = random.Next(201, 300);
            cuentas.dMarzo = random.Next(301, 400);
            cuentas.dAbril = random.Next(401, 500);
            return cuentas;
        }

        private UAComposite LlenarUA(string _cClave, IClavePresupuestal _clavePresupuestalComponent)
        {
            UAComposite unidad = new UAComposite();
            unidad.UnidadAdministrativa = _cClave;
            unidad.Agregar(_clavePresupuestalComponent);
            return unidad;
        }
    }
}
