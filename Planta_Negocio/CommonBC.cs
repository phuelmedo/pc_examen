using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta_Negocio
{
    public class CommonBC
    {
        private static Planta_DALC.El_SaltoEntities _modelPlanta;
        public static Planta_DALC.El_SaltoEntities ModelPlanta
        {
            get
            {
                if (_modelPlanta == null)
                {
                    _modelPlanta = new Planta_DALC.El_SaltoEntities();
                }
                return _modelPlanta;
            }
        }
        public CommonBC() { }
    }
}
