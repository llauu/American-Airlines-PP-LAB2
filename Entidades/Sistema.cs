using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades {
    public static class Sistema {
        private static string rutaUsuariosJson;
        private static List<Usuario>? listaUsuarios;
        private static List<Pasajero>? listaPasajeros;
        private static List<Aeronave>? listaAeronaves;
        private static List<Vuelo>? listaVuelos;

        public static List<Usuario>? ListaUsuarios { get { return listaUsuarios; } }
        public static List<Pasajero>? ListaPasajeros { get { return listaPasajeros; } }
        public static List<Aeronave>? ListaAeronaves { get { return listaAeronaves; } }
        public static List<Vuelo>? ListaVuelos { get { return listaVuelos; } }


        static Sistema() {
            listaUsuarios = new List<Usuario>();
            listaPasajeros = new List<Pasajero>();
            listaAeronaves = new List<Aeronave>();

            rutaUsuariosJson = @"..\..\..\..\db\MOCK_DATA.json";
        }

        public static bool CargarUsuariosJson() {
            bool exito = false;

            using (StreamReader sr = new StreamReader(rutaUsuariosJson)) {
                string json_str = sr.ReadToEnd();

                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json_str);
                exito = true;
            }

            return exito;
        }

        public static int IniciarSesion(string correo, string clave) {
            int indice = -1;
            
            if(listaUsuarios != null) {
                foreach (Usuario usuario in listaUsuarios) {
                    if (usuario.ChequearCorreo(correo) && usuario.ChequearClave(clave)) {
                        indice = listaUsuarios.IndexOf(usuario);
                        break;
                    }
                }
            }
            
            return indice;
        }

        public static bool AltaPasajero(Pasajero pasajero) {
            bool agregado = false;
            
            if (pasajero != null && listaPasajeros != null) {
                listaPasajeros.Add(pasajero);
                agregado = true;
            }

            return agregado;
        }

        public static bool BajaPasajero(Pasajero pasajero) {
            bool eliminado = false;

            if (pasajero != null && listaPasajeros != null) {
                listaPasajeros.Remove(pasajero);
                eliminado = true;
            }

            return eliminado;
        }

        public static bool AltaAeronave(Aeronave aeronave) {
            bool agregado = false;

            if (aeronave != null && listaAeronaves != null) {
                listaAeronaves.Add(aeronave);
                agregado = true;
            }

            return agregado;
        }

        public static bool BajaAeronave(Aeronave aeronave) {
            bool eliminado = false;

            if (aeronave != null && listaAeronaves != null) {
                listaAeronaves.Remove(aeronave);
                eliminado = true;
            }

            return eliminado;
        }
    }
}
