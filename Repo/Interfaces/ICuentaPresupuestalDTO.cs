using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Repo.Interfaces
{
    public interface ICuentaPresupuestalDTO
    {
        int iIdCP { set; get; }
        decimal dEnero { set; get; }
        decimal dFebrero { set; get; }
        decimal dMarzo { set; get; }
        decimal dAbril { set; get; }
    }
}
