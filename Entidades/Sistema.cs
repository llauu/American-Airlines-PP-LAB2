using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades {
    public static class Sistema {
        private static string rutaUsuariosJson;
        private static string rutaAvionesJson;
        private static string rutaPasajerosXML;
        private static string rutaVuelosXML;
        private static List<Usuario>? listaUsuarios;
        private static List<Pasajero>? listaPasajeros;
        private static List<Aeronave>? listaAeronaves;
        private static List<Vuelo>? listaVuelos;
        private static List<string>? listaCiudades;

        public static List<Usuario>? ListaUsuarios { get { return listaUsuarios; } }
        public static List<Pasajero>? ListaPasajeros { get { return listaPasajeros; } }
        public static List<Aeronave>? ListaAeronaves { get { return listaAeronaves; } }
        public static List<Vuelo>? ListaVuelos { get { return listaVuelos; } }
        public static List<string>? ListaCiudades { get { return listaCiudades; } }


        static Sistema() {
            listaUsuarios = new List<Usuario>();
            listaPasajeros = new List<Pasajero>();
            listaAeronaves = new List<Aeronave>();
            listaVuelos = new List<Vuelo>();

            CargarListaCiudades();

            rutaUsuariosJson = @"..\..\..\..\db\MOCK_DATA.json";
            rutaAvionesJson = @"..\..\..\..\db\datosAviones.json";
            rutaPasajerosXML = @"..\..\..\..\db\datosPasajeros.xml";
            rutaVuelosXML = @"..\..\..\..\db\datosVuelos.xml";
        }

        private static void CargarListaCiudades() { 
            listaCiudades = new List<string>() 
            { 
                "Buenos Aires", 
                "Santa Rosa", 
                "Bariloche", 
                "Corrientes", 
                "Córdoba", 
                "Jujuy", 
                "Mendoza", 
                "Neuquén", 
                "Posadas", 
                "Iguazú", 
                "Salta", 
                "Santiago del Estero", 
                "Trelew", 
                "Tucumán", 
                "Puerto Madryn", 
                "Ushuaia", 
                "Recife (Brasil)", 
                "Roma (Italia)", 
                "Acapulco (México)", 
                "Miami (EE.UU.)" 
            }; 
        }

        public static void CargarUsuarios() {
            listaUsuarios = Archivos.LeerArchivoJson(listaUsuarios, rutaUsuariosJson);
        }
        
        public static void CargarArchivos() {
            listaAeronaves = Archivos.LeerArchivoJson(listaAeronaves, rutaAvionesJson);
            listaPasajeros = Archivos.LeerArchivoXML(listaPasajeros, rutaPasajerosXML);
            listaVuelos = Archivos.LeerArchivoXML(listaVuelos, rutaVuelosXML);
        }

        public static void EscribirArchivos() {
            Archivos.EscribirArchivoJson(listaUsuarios, rutaUsuariosJson);
            Archivos.EscribirArchivoJson(listaAeronaves, rutaAvionesJson);
            Archivos.EscribirArchivoXML(listaPasajeros, rutaPasajerosXML);
            Archivos.EscribirArchivoXML(listaVuelos, rutaVuelosXML);
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

        public static bool AltaVuelo(Vuelo vuelo) {
            bool agregado = false;

            if (vuelo != null && listaVuelos != null) {
                listaVuelos.Add(vuelo);
                agregado = true;
            }

            return agregado;
        }

        public static bool BajaVuelo(Vuelo vuelo) {
            bool eliminado = false;

            if (vuelo != null && listaVuelos != null && listaAeronaves != null) {
                int i = listaAeronaves.IndexOf(vuelo.Avion);
                listaAeronaves[i].VueloProgramado = false;

                listaVuelos.Remove(vuelo);
                eliminado = true;
            }

            return eliminado;
        }

        public static string GenerarIdAlfanumerico() {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] arrayAlfanumerico = new char[8];
            string idAlfanumericoUnico;

            for (int i = 0; i < arrayAlfanumerico.Length; i++) {
                arrayAlfanumerico[i] = chars[random.Next(chars.Length)];
            }

            idAlfanumericoUnico = new string(arrayAlfanumerico);

            return idAlfanumericoUnico;
        }

        public static int GenerarIdNumerico() {
            Random rand = new Random();
            int idGenerado;

            idGenerado = rand.Next(100000, 1000000);

            return idGenerado;
        }

        public static void ChequearEstadoVuelos() {
            if(listaVuelos != null) {
                foreach (Vuelo vuelo in listaVuelos) {
                    if (vuelo.FechaDeVuelo.Date < DateTime.Now.Date) {
                        vuelo.EstadoDelVuelo = EEstadoVuelo.Finalizado;
                    }
                    else {
                        if(vuelo.FechaDeVuelo.Date ==  DateTime.Now.Date) {
                            vuelo.EstadoDelVuelo = EEstadoVuelo.EnCurso;
                        }
                    }
                }
            }
        }

        public static List<Aeronave> CargarListaAeronavesDisponibles() {
            List<Aeronave> aeronavesDisponibles = new List<Aeronave>();

            if (listaAeronaves != null) {
                foreach (Aeronave aeronave in listaAeronaves) {
                    if (!aeronave.VueloProgramado) {
                        aeronavesDisponibles.Add(aeronave);
                    }
                }
            }

            return aeronavesDisponibles;
        }


    }
}
