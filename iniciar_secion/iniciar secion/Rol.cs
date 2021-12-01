using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iniciar_secion
{
    class Rol
    {
        
        private string permisos;
        private string nombre;
        private int id;

        public Rol(string permisos, string nombre, int id)
        {
            this.Permisos = permisos;
            this.Nombre = nombre;
            this.Id = id;
        }

        public string Permisos { get => permisos; set => permisos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
    }
    
}
