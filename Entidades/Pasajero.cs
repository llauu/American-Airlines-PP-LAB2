using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Pasajero : Persona {
        int dni;
        int edad;

        public Pasajero (string apellido, string nombre, int dni, int edad) :base(apellido, nombre) {
            this.dni = dni;
            this.edad = edad;
        }

    }
}
