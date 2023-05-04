using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public static class Validador {
        public static string ValidarCadena(string cadena) {
            if(string.IsNullOrEmpty(cadena) || cadena.All(char.IsDigit)) {
                throw new Exception("Campos de texto no validos.");
            }
            
            return cadena;
        }

        public static int ValidarDni(int dni) {
            if(dni < 1 || dni > 99999999) {
                throw new Exception("DNI no valido.");
            }

            if(Sistema.ListaPasajeros != null) {
                foreach (Pasajero pasajero in Sistema.ListaPasajeros) {
                    if (pasajero.Dni == dni) {
                        throw new Exception("Ya existe un pasajero registrado con ese DNI.");
                    }
                }
            }

            return dni;
        }

        public static int CalcularEdad(DateTime fechaDeNacimiento) {
            int edad = DateTime.Now.Year - fechaDeNacimiento.Year;

            if (fechaDeNacimiento.Month > DateTime.Now.Month) {
                edad--;
            }

            return edad;
        }

        public static DateTime ValidarFechaDeNacimiento(DateTime fechaDeNacimiento) {
            if(CalcularEdad(fechaDeNacimiento) < 0 || CalcularEdad(fechaDeNacimiento) > 120) {
                throw new Exception("Fecha de nacimiento no valida.");
            }

            return fechaDeNacimiento;
        }

        public static int ValidarNumeroPositivo(int numero) {
            if (!(numero > 0)) {
                throw new Exception("No se permite el ingreso de numeros negativos.");
            }

            return numero;
        }
    }
}
