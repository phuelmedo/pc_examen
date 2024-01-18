using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta_Negocio
{
    public interface IPersistente
    {
        bool Create();
        bool Read(int id);
        bool Update();
        bool Delete(int id);
        bool ReadUser(string username, string password);
    }
}
