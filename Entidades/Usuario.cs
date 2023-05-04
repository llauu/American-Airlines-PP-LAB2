namespace Entidades {
    public sealed class Usuario : Persona {
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;

        public Usuario (string apellido, string nombre, int legajo, string correo, string clave, string perfil) :base(apellido, nombre) {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }
        public string Correo { get { return this.correo; } set { this.correo = value; } }
        public string Clave { get { return this.clave; } set { this.clave = value; } }
        public string Perfil { get { return this.perfil; } set { this.perfil = value; } }

        public bool ChequearCorreo(string correo) {
            return correo == this.correo;
        }

        public bool ChequearClave(string clave) {
            return clave == this.clave;
        }

        public string Mostrar() {
            return $"{this.nombre} {this.apellido} {this.legajo} {this.correo} {this.clave} {this.perfil}";
        }
    }
}