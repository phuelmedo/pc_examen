using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta_Negocio
{
    public class PlantaCollection
    {
        public List<Planta> ReadAll()
        {
            var plantas = CommonBC.ModelPlanta.vwPlanta;
            return ObtenerPlantas(plantas.ToList());
        }

        private List<Planta> ObtenerPlantas(List<Planta_DALC.vwPlanta> plantasDalc)
        {
            List<Planta> plantaList = new List<Planta>();
            foreach (Planta_DALC.vwPlanta planta in plantasDalc)
            {
                Planta e = new Planta();
                e.Id = planta.Id;
                e.NombreComun = AES_Helper.DecryptString(planta.NombreComun);
                e.NombreCientifico = AES_Helper.DecryptString(planta.NombreCientifico);
                e.TipoPlanta = planta.TipoPlanta;
                e.Descripcion = AES_Helper.DecryptString(planta.Descripcion);
                e.TiempoRiego = planta.TiempoRiego;
                e.CantidadAgua = planta.CantidadAgua;
                e.Epoca = planta.Epoca;
                e.EsVenenosa = planta.EsVenenosa;
                e.EsAuctoctona = planta.EsAutoctona;

                plantaList.Add(e);
            }
            return plantaList;
        }
    }
}
