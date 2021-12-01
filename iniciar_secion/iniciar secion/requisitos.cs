using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iniciar_secion.conexion;

namespace iniciar_secion_prioridad
{
    class requerimientos
    {
        private string prioridad;
        private string tipo;
        private string asignacion;
        private string descripcion;

        public requerimientos()
        {
        }

        public requerimientos(string prioridad, string tipo)
        {
            this.prioridad = prioridad;
            this.tipo = tipo;
        }

        public requerimientos(string prioridad, string tipo, string asignacion, string descripcion)
        {
            this.prioridad = prioridad;
            this.tipo = tipo;
            this.asignacion = asignacion;
            this.descripcion = descripcion;
        }

        public string Prioridad { get => prioridad; set => prioridad = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Asignacion { get => asignacion; set => asignacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }



    }

}
