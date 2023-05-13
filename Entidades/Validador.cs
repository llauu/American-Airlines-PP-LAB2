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
            if (dni < 3000000 || dni > 99999999) {
                throw new Exception("DNI no valido.");
            }

            if (Sistema.ListaPasajeros != null) {
                ValidarDniUnico(dni);
            }

            return dni;
        }

        public static void ValidarDniUnico(int dni) {
            if (Sistema.ListaPasajeros != null) {
                foreach (Pasajero pasajero in Sistema.ListaPasajeros) { 
                    if (pasajero.GetHashCode() == dni) {
                        throw new Exception("Ya existe un pasajero con ese DNI.");
                    }
                }
            }
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
                throw new Exception("Campos numericos no validos.");
            }

            return numero;
        }

        public static float ValidarFlotantePositivo(float numero) {
            if (!(numero > 0)) {
                throw new Exception("Campos numericos no validos.");
            }

            return numero;
        }

        public static bool ValidarMatriculaUnica(string matricula) {
            bool seRepite = false;

            if(Sistema.ListaAeronaves != null) {
                foreach(Aeronave aeronave in Sistema.ListaAeronaves) {
                    if(aeronave.Matricula == matricula) {  
                        seRepite = true; 
                        break;
                    }
                }
            }

            return seRepite;
        }

        public static bool ValidarIdVueloUnico(int id) {
            bool seRepite = false;

            if (Sistema.ListaVuelos != null) {
                foreach (Vuelo vuelo in Sistema.ListaVuelos) {
                    if (vuelo.GetHashCode() == id) {
                        seRepite = true;
                        break;
                    }
                }
            }

            return seRepite;
        }

        public static void ValidarCiudades(string partida, string destino) {
            if (partida == destino) {
                throw new Exception("Ciudad de partida y destino no pueden ser las mismas.");
            }
            else {
                if (String.IsNullOrEmpty(partida) || String.IsNullOrEmpty(destino)) {
                    throw new Exception("Ciudad de partida y destino no pueden ser las mismas.");
                }
            }
        }

        public static void ValidarInternacional(string partida, string destino, ETipoVuelo tipoVuelo) {
            if(tipoVuelo == ETipoVuelo.Internacional && partida != "Buenos Aires" && partida != "Buenos Aires") {
                throw new Exception("Los vuelos internacionales deben salir o llegar a Buenos Aires.");
            }
        }
    }
}
