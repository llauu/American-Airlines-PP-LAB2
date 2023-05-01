namespace Entidades {
    public sealed class Usuario : Persona {
        private int Legajo;
        private string Correo;
        private string Clave;
        private string Perfil;

        public Usuario (string apellido, string nombre, int legajo, string correo, string clave, string perfil) :base(apellido, nombre) {
            this.Legajo = legajo;
            this.Correo = correo;
            this.Clave = clave;
            this.Perfil = perfil;
        }

        public int legajo { get { return this.Legajo; } set { this.Legajo = value; } }
        public string correo { get { return this.Correo; } set { this.Correo = value; } }
        public string clave { get { return this.Clave; } set { this.Clave = value; } }
        public string perfil { get { return this.Perfil; } set { this.Perfil = value; } }

        public bool ChequearCorreo(string correo) {
            return correo == this.Correo;
        }

        public bool ChequearClave(string clave) {
            return clave == this.Clave;
        }

        public string Mostrar() {
            return $"{this.nombre} {this.apellido} {this.legajo} {this.correo} {this.clave} {this.perfil}";
        }
    }
}