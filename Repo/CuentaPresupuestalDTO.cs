using Composite.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Repo
{
    public class CuentaPresupuestalDTO : ICuentaPresupuestalDTO
    {
        public int iIdCP { set; get; }
        public decimal dEnero { set; get; }
        public decimal dFebrero { set; get; }
        public decimal dMarzo { set; get; }
        public decimal dAbril { set; get; }
    }
}
