namespace Entidades {
    public class Usuario {
        private string Apellido;
        private string Nombre;
        private int Legajo;
        private string Correo;
        private string Clave;
        private string Perfil;


        public Usuario (string apellido, string nombre, int legajo, string correo, string clave, string perfil) {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Legajo = legajo;
            this.Correo = correo;
            this.Clave = clave;
            this.Perfil = perfil;
        }

        public string apellido { get { return this.Apellido; } set { this.Apellido = value; } }
        public string nombre { get { return this.Nombre; } set { this.Nombre = value; } }
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
            return $"{nombre} {apellido} {legajo} {correo} {clave} {perfil}";
        }
    }
}