using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Pasajero : Persona {
        private int dni;
        private int edad;
        private DateTime fechaDeNacimiento;

        // Constructor sin parametros para serializar xml
        public Pasajero() {}

        public Pasajero(string apellido, string nombre, int dni, DateTime fechaDeNacimiento) : base(apellido, nombre) {
            this.dni = Validador.ValidarDni(dni);
            this.fechaDeNacimiento = Validador.ValidarFechaDeNacimiento(fechaDeNacimiento);
            this.edad = Validador.CalcularEdad(fechaDeNacimiento);
        }

        public DateTime FechaDeNacimiento { get { return this.fechaDeNacimiento; } set { this.fechaDeNacimiento = value; } }
        public int Dni { get { return this.dni; } set { this.dni = value; } }
        public int Edad { get { return this.edad; } set { this.edad = value; } }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Edad: {this.edad}");

            return sb.ToString();
        }
    }
}
