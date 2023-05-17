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
            rutaVuelosXML = @"..\..\..\..\db\datosVuelos.json";
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
            listaVuelos = Archivos.LeerArchivoJson(listaVuelos, rutaVuelosXML);
        }

        public static void EscribirArchivos() {
            Archivos.EscribirArchivoJson(listaUsuarios, rutaUsuariosJson);
            Archivos.EscribirArchivoJson(listaAeronaves, rutaAvionesJson);
            Archivos.EscribirArchivoXML(listaPasajeros, rutaPasajerosXML);
            Archivos.EscribirArchivoJson(listaVuelos, rutaVuelosXML);
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
            
            if (listaPasajeros != null) {
                listaPasajeros.Add(pasajero);
                agregado = true;
            }

            return agregado;
        }

        public static bool BajaPasajero(Pasajero pasajero) {
            bool eliminado = false;

            if (listaPasajeros != null) {
                listaPasajeros.Remove(pasajero);
                eliminado = true;
            }

            return eliminado;
        }

        public static bool AltaAeronave(Aeronave aeronave) {
            bool agregado = false;

            if (listaAeronaves != null) {
                listaAeronaves.Add(aeronave);
                agregado = true;
            }

            return agregado;
        }

        public static bool BajaAeronave(Aeronave aeronave) {
            bool eliminado = false;

            if (listaAeronaves != null) {
                listaAeronaves.Remove(aeronave);
                eliminado = true;
            }

            return eliminado;
        }

        public static bool AltaVuelo(Vuelo vuelo) {
            bool agregado = false;

            if (listaVuelos != null) {
                listaVuelos.Add(vuelo);
                agregado = true;
            }

            return agregado;
        }

        public static bool BajaVuelo(Vuelo vuelo) {
            bool eliminado = false;

            if (listaVuelos != null && listaAeronaves != null) {
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

        public static void BuscarClientes(List<Pasajero> pasajeroEncontrados, string textoABuscar) {
            if (listaPasajeros != null) {
                foreach (Pasajero pasajero in listaPasajeros) {
                    if (pasajero.Nombre.ToUpper().StartsWith(textoABuscar)) {
                        pasajeroEncontrados.Add(pasajero);
                    }
                    else {
                        if (pasajero.Apellido.ToUpper().StartsWith(textoABuscar)) {
                            pasajeroEncontrados.Add(pasajero);
                        }
                        else {
                            if (pasajero.GetHashCode().ToString().StartsWith(textoABuscar)) {
                                pasajeroEncontrados.Add(pasajero);
                            }
                        }
                    }
                }
            }
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

        public static List<Aeronave> CargarListaAeronavesDisponibles(List<Aeronave> aeronavesDisponibles) {
            if (listaAeronaves != null) {
                foreach (Aeronave aeronave in listaAeronaves) {
                    if (!aeronave.VueloProgramado) {
                        aeronavesDisponibles.Add(aeronave);
                    }
                }
            }

            return aeronavesDisponibles;
        }

        public static List<Vuelo> CargarListaVuelosDisponibles() {
            List<Vuelo> vuelosDisponibles = new List<Vuelo> ();

            if(listaVuelos != null) {
                foreach(Vuelo vuelo in listaVuelos) {
                    if(vuelo.EstadoDelVuelo == EEstadoVuelo.EnTierra) {
                        vuelosDisponibles.Add(vuelo);
                    }
                }
            }

            return vuelosDisponibles;
        }

        public static Dictionary<string, double> CargarDestinosConSuFacturacion() {
            Dictionary<string, double> destinosConSuFacturacion = new Dictionary<string, double> ();

            // Cargo el diccionario con todas las ciudades, y todos los valores los inicializo en 0
            foreach (string ciudad in listaCiudades!) {
                destinosConSuFacturacion.Add(ciudad, 0);

                foreach (Vuelo vuelo in listaVuelos!) {
                    if(vuelo.CiudadDestino == ciudad) {
                        foreach (Pasaje pasaje in vuelo.ListaPasajes) {
                            destinosConSuFacturacion[ciudad] += pasaje.CostoPasaje;
                        }
                    }
                }
            }

            return destinosConSuFacturacion;
        }

        public static Dictionary<string, string> ObtenerDestinosOrdenadosPorSuFacturacion() {
            Dictionary<string, double> destinos = CargarDestinosConSuFacturacion();
            Dictionary<string, double> destinosOrdenados = new Dictionary<string, double>();
            
            // me creo otro diccionario pero que sea <string, string> para poder agregarle el signo $ al precio 
            Dictionary<string, string> destinosOrdenadosEnString = new Dictionary<string, string>();

            destinosOrdenados = destinos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); 

            foreach(KeyValuePair<string, double> item in destinosOrdenados) {
                destinosOrdenadosEnString[item.Key] = $"${item.Value}";
            }

            return destinosOrdenadosEnString;
        }

        public static Dictionary<string, int> CargarPasajerosConCantidadDeVuelos() {
            Dictionary<string, int> pasajerosConCantidadDeVuelos = new Dictionary<string, int>();

            foreach (Pasajero pasajero in listaPasajeros!) {
                pasajerosConCantidadDeVuelos.Add($"{pasajero.Nombre} {pasajero.Apellido}", 0);

                foreach(Vuelo vuelo in listaVuelos!) {
                    if(vuelo.EstadoDelVuelo != EEstadoVuelo.EnTierra) {
                        foreach (Pasaje pasaje in vuelo.ListaPasajes) {
                            if (pasajero == pasaje.Pasajero!) {
                                pasajerosConCantidadDeVuelos[$"{pasajero.Nombre} {pasajero.Apellido}"]++;
                            }
                        }
                    }
                }
            }

            return pasajerosConCantidadDeVuelos;
        }

        public static Dictionary<string, int> ObtenerPasajerosOrdenadosPorCantidadDeVuelos() {
            Dictionary<string, int> pasajerosConCantidadDeVuelos = CargarPasajerosConCantidadDeVuelos();
            Dictionary<string, int> pasajerosOrdenados = new Dictionary<string, int>();

            pasajerosOrdenados = pasajerosConCantidadDeVuelos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return pasajerosOrdenados;
        }


        public static double CalcularGananciasTotales() {
            double gananciasTotales = 0;
            
            foreach(Vuelo vuelo in listaVuelos!) {
                foreach(Pasaje pasaje in vuelo.ListaPasajes) {
                    gananciasTotales += pasaje.CostoPasaje;
                }
            }

            return gananciasTotales;
        }

        public static double CalcularGananciasVuelosInternacionales() {
            double gananciasTotales = 0;

            foreach (Vuelo vuelo in listaVuelos!) {
                if(vuelo.TipoVuelo == ETipoVuelo.Internacional) {
                    foreach (Pasaje pasaje in vuelo.ListaPasajes) {
                        gananciasTotales += pasaje.CostoPasaje;
                    }
                }
            }

            return gananciasTotales;
        }

        public static double CalcularGananciasVuelosNacionales() {
            double gananciasTotales = 0;

            foreach (Vuelo vuelo in listaVuelos!) {
                if (vuelo.TipoVuelo == ETipoVuelo.Nacional) {
                    foreach (Pasaje pasaje in vuelo.ListaPasajes) {
                        gananciasTotales += pasaje.CostoPasaje;
                    }
                }
            }

            return gananciasTotales;
        }


        public static Dictionary<string, string> CargarAvionesConSusHorasDeVuelos() {
            Dictionary<string, int> avionesConHorasDeVuelos = new Dictionary<string, int>();
            Dictionary<string, string> avionesConHorasDeVuelosEnString = new Dictionary<string, string>();

            foreach (Aeronave avion in listaAeronaves!) {
                avionesConHorasDeVuelos.Add(avion.Matricula, 0);

                foreach(Vuelo vuelo in listaVuelos!) {
                    if(vuelo.EstadoDelVuelo != EEstadoVuelo.EnTierra && vuelo.Avion == avion) {
                        avionesConHorasDeVuelos[avion.Matricula] += vuelo.DuracionVuelo;
                    }
                }
            }

            foreach (KeyValuePair<string, int> item in avionesConHorasDeVuelos) {
                avionesConHorasDeVuelosEnString[item.Key] = $"{item.Value}hs.";
            }

            return avionesConHorasDeVuelosEnString;
        }


            //El destino más pedido por los clientes.
        public static string BuscarDestinoMasPedido() {
            string destinoMasPedido = "Ninguno";
             int contadorDestinoMasPedido = 0;
            int contadorActual = 0;
            bool banderaPrimero = true;

            foreach (string destino in listaCiudades!) {
                contadorActual = 0;

                foreach (Vuelo vuelo in listaVuelos!) {
                    if(vuelo.CiudadDestino == destino) {
                        contadorActual += vuelo.ListaPasajes.Count();
                    }
                }

                if(banderaPrimero || contadorActual > contadorDestinoMasPedido) {
                    destinoMasPedido = destino;
                    contadorDestinoMasPedido = contadorActual;
                    banderaPrimero = false;
                }
            }

            return destinoMasPedido;
        }
    }
}
