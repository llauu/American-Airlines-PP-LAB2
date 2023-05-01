using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Persona {
        protected string Apellido;
        protected string Nombre;

        public Persona (string apellido, string nombre) {
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        public string apellido { get { return this.Apellido; } set { this.Apellido = value; } }
        public string nombre { get { return this.Nombre; } set { this.Nombre = value; } }
    }
}
