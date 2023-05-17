using System.Text;

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

        public override bool TieneCodigoDeDescuento() {
            return true;
        }

        public static bool operator ==(Usuario u1, Usuario u2) {
            bool iguales = false;

            if (u1 is not null && u2 is not null) {
                iguales = u1.legajo == u2.legajo;
            }

            return iguales;
        }

        public static bool operator !=(Usuario u1, Usuario u2) {
            return !(u1 == u2);
        }

        public override bool Equals(object? obj) {
            Usuario? usuario = obj as Usuario;
            return usuario is not null && this == usuario;
        }

        public override int GetHashCode() {
            return this.legajo;
        }

        public bool ChequearCorreo(string correo) {
            return correo == this.correo;
        }

        public bool ChequearClave(string clave) {
            return clave == this.clave;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Correo electronico: {this.correo}");
            sb.AppendLine($"Perfil: {this.perfil}");

            return sb.ToString();
        }
    }
}