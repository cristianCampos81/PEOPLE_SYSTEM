using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.modelo
{
    public class RegionModel
    {
        private int id;
        private string nombre;
        private string descripcion;

        public RegionModel()
        {

        }

        public RegionModel(int id, string nombre, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return "\n\t\t\tREGION: \n" +
                   "\nID: " + id +
                   "\nNOMBRE: " + nombre +
                   "\nNOMBRE: " + descripcion;
        }
    }
}
