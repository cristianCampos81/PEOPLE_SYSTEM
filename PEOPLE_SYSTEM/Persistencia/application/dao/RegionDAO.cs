using Modelo.application.modelo;
using Persistencia.PEOPLE_SYSTEMDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Persistencia.PEOPLE_SYSTEMDataSet;

namespace Persistencia.application.dao
{
    public class RegionDAO
    {
        public bool Insert(RegionModel region)
        {
            REGIONTableAdapter adapter =
                new REGIONTableAdapter();

            try
            {
                int resultado = adapter.Insert(region.Nombre,
                    region.Descripcion);

                if (resultado == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }

        public List<RegionModel> BuscarTodo()
        {
            List<RegionModel> regiones =
                new List<RegionModel>();

            REGIONTableAdapter adapter =
              new REGIONTableAdapter();

            try
            {
                foreach (REGIONRow fila in adapter.GetData())
                {
                    RegionModel region = new RegionModel();
                    region.Id = fila.ID;
                    region.Nombre = fila.NOMBRE;
                    region.Descripcion = fila.DESCRIPCION;

                    regiones.Add(region);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

            }

            return regiones;
        }
    }
}
