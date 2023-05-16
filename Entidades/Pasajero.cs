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
        public Pasajero() {
        }

        public Pasajero(string apellido, string nombre, int dni, DateTime fechaDeNacimiento) : base(apellido, nombre) {
            this.dni = Validador.ValidarDni(dni);
            this.fechaDeNacimiento = Validador.ValidarFechaDeNacimiento(fechaDeNacimiento);
            this.edad = Validador.CalcularEdad(fechaDeNacimiento);
        }

        public DateTime FechaDeNacimiento { get { return this.fechaDeNacimiento; } set { this.fechaDeNacimiento = value; } }
        public int Dni { get { return this.dni; } set { this.dni = value; } }
        public int Edad { get { return this.edad; } set { this.edad = value; } }

        public static bool operator ==(Pasajero p1, Pasajero p2) {
            bool iguales = false;

            if(p1 is not null && p2 is not null) {
                iguales = p1.dni == p2.dni && p1.fechaDeNacimiento == p2.fechaDeNacimiento;
            }

            return iguales;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2) {
            return !(p1 == p2);
        }

        public override bool Equals(object? obj) {
            Pasajero? pasajero = obj as Pasajero; 
            return pasajero is not null && this == pasajero;
        }

        public override int GetHashCode() {
            return this.dni;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"| DNI: {this.dni} ");
            sb.AppendLine($"| Edad: {this.edad}");

            return sb.ToString();
        }
    }
}
