using Modelo.application.modelo;
using Persistencia.application.dao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*RegionModel region = new RegionModel();
            region.Nombre = "REGION METROPOLITANA";
            region.Descripcion = "";

            RegionDAO dao = new RegionDAO();

            bool resultado = dao.Insert(region);

            if (resultado)
            {
                Debug.WriteLine("REGION CREADA");
            }
            else
            {
                Debug.WriteLine("REGION AL CREAR LA REGION. ");
            }*/

            RegionDAO dao = new RegionDAO();

            foreach(RegionModel region in dao.BuscarTodo())
            {
                Debug.WriteLine(region.ToString());
            }
        }
    }
}
