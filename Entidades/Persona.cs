using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public abstract class Persona {
        protected string apellido;
        protected string nombre;

        protected Persona() {
            this.apellido = String.Empty;
            this.nombre = String.Empty;
        }
        
        protected Persona(string apellido, string nombre) : this() {
            this.apellido = Validador.ValidarCadena(apellido);
            this.nombre = Validador.ValidarCadena(nombre);
        }

        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

        public abstract bool TieneCodigoDeDescuento();

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.nombre} {this.apellido}");

            return sb.ToString();
        }
    }
}
