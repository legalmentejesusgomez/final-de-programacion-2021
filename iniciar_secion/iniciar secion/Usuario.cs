using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  iniciar_secion.user
{
    class Usuario
    {
        private string user;
        private string pass;
        private string rol;
        private int id;

        public Usuario(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public Usuario(string user, string pass, int id)
        {
            this.user = user;
            this.pass = pass;
            this.id = id;
        }

        public Usuario(string user, string pass, string rol, int id) 
        {
            this.user = user;
            this.pass = pass;
            this.id = id;
            this.rol = rol;
        }

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Id { get => id; set => id = value; }
    }
}
