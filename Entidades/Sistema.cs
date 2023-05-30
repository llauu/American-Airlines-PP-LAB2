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
        private static string rutaRegistroUsuarios;
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
            rutaRegistroUsuarios = @"..\..\..\..\db\usuario.log";
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

        /// <summary>
        /// Lee el archivo de los usuarios generados anteriormente para el inicio de sesion
        /// </summary>
        public static void CargarUsuarios() {
            listaUsuarios = Archivos.LeerArchivoJson(listaUsuarios, rutaUsuariosJson);
        }
        
        /// <summary>
        /// Lee los archivos en donde se encuentran los datos utilizados anteriormente
        /// </summary>
        public static void CargarArchivos() {
            listaAeronaves = Archivos.LeerArchivoJson(listaAeronaves, rutaAvionesJson);
            listaPasajeros = Archivos.LeerArchivoXML(listaPasajeros, rutaPasajerosXML); 
            listaVuelos = Archivos.LeerArchivoJson(listaVuelos, rutaVuelosXML);
        }

        /// <summary>
        /// Escribe los datos en archivos para tener permanencia de ellos
        /// </summary>
        public static void EscribirArchivos() {
            Archivos.EscribirArchivoJson(listaUsuarios, rutaUsuariosJson);
            Archivos.EscribirArchivoJson(listaAeronaves, rutaAvionesJson);
            Archivos.EscribirArchivoXML(listaPasajeros, rutaPasajerosXML);
            Archivos.EscribirArchivoJson(listaVuelos, rutaVuelosXML);
        }

        /// <summary>
        /// Registra la conexion de un usuario al sistema
        /// </summary>
        /// <param name="usuario">Usuario que se conecto</param>
        public static void RegistrarConexion(Usuario usuario) {
            Archivos.GuardarConexionDeUsuario(usuario, rutaRegistroUsuarios);
        }
        
        /// <summary>
        /// Registra la desconexion de un usuario del sistema
        /// </summary>
        /// <param name="usuario">Usuario que se desconecto</param>
        public static void RegistrarDesconexion(Usuario usuario) {
            Archivos.GuardarDesconexionDeUsuario(usuario, rutaRegistroUsuarios);
        }

        /// <summary>
        /// Permite el inicio de sesion a traves de un correo y una clave iniciada, recorre la lista de usuario previamente cargados para validarlos
        /// </summary>
        /// <param name="correo">Correo ingresado</param>
        /// <param name="clave">Clave ingresada</param>
        /// <returns>Indice donde se encuentra el usuario en la lista de usuarios</returns>
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

        /// <summary>
        /// Permite el alta de un pasajero en el sistema, agregandolo a la lista de pasajeros
        /// </summary>
        /// <param name="pasajero">Pasajero a agregar a la lista</param>
        /// <returns>true si se agrego correctamente, false si no</returns>
        public static bool AltaPasajero(Pasajero pasajero) {
            bool agregado = false;
            
            if (listaPasajeros != null) {
                listaPasajeros.Add(pasajero);
                agregado = true;
            }

            return agregado;
        }

        /// <summary>
        /// Permite la baja de un pasajero en el sistema, quitandolo de la lista de pasajeros
        /// </summary>
        /// <param name="pasajero">Pasajero a eliminar de la lista</param>
        /// <returns>true si se elimino correctamente, false si no</returns>
        public static bool BajaPasajero(Pasajero pasajero) {
            bool eliminado = false;

            if (listaPasajeros != null) {
                listaPasajeros.Remove(pasajero);
                eliminado = true;
            }

            return eliminado;
        }


        /// <summary>
        /// Permite el alta de una aeronave en el sistema, agregandolo a la lista de aeronaves
        /// </summary>
        /// <param name="aeronave">Aeronave a agregar a la lista</param>
        /// <returns>true si se agrego correctamente, false si no</returns>
        public static bool AltaAeronave(Aeronave aeronave) {
            bool agregado = false;

            if (listaAeronaves != null) {
                listaAeronaves.Add(aeronave);
                agregado = true;
            }

            return agregado;
        }

        /// <summary>
        /// Permite la baja de una aeronave en el sistema, quitandola de la lista de aeronaves
        /// </summary>
        /// <param name="aeronave">Aeronave a eliminar de la lista</param>
        /// <returns>true si se elimino correctamente, false si no</returns>
        public static bool BajaAeronave(Aeronave aeronave) {
            bool eliminado = false;

            if (listaAeronaves != null) {
                listaAeronaves.Remove(aeronave);
                eliminado = true;
            }

            return eliminado;
        }

        /// <summary>
        /// Permite el alta de un vuelo en el sistema, agregandolo a la lista de vuelos
        /// </summary>
        /// <param name="vuelo">Vuelo a agregar a la lista</param>
        /// <returns>true si se agrego correctamente, false si no</returns>
        public static bool AltaVuelo(Vuelo vuelo) {
            bool agregado = false;

            if (listaVuelos != null) {
                listaVuelos.Add(vuelo);
                agregado = true;
            }

            return agregado;
        }

        public static bool EditarVuelo(Vuelo vueloAEditar, Vuelo vueloEditado) {
            bool editado = false;

            if (listaVuelos != null) {
                int i = listaVuelos.IndexOf(vueloAEditar);
                listaVuelos[i] = vueloEditado;
            }

            return editado;
        }

        /// <summary>
        /// Permite la baja de un vuelo en el sistema, quitandolo de la lista de vuelos
        /// </summary>
        /// <param name="vuelo">Vuelo a eliminar de la lista</param>
        /// <returns>true si se elimino correctamente, false si no</returns>
        public static bool BajaVuelo(Vuelo vuelo) {
            bool eliminado = false;

            if (listaVuelos != null && listaAeronaves != null) {
                DesprogramarVueloDeAeronave(vuelo.Avion);

                listaVuelos.Remove(vuelo);
                eliminado = true;
            }

            return eliminado;
        }

        /// <summary>
        /// Genera un ID alfanumerico en base a las letras del abcedario y los numeros del 0 al 9
        /// </summary>
        /// <returns>Un string del id generado</returns>
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

        /// <summary>
        /// Genera un ID numerico entre 100000 y 999999 (incluidos)
        /// </summary>
        /// <returns>El ID generado</returns>
        public static int GenerarIdNumerico() {
            Random rand = new Random();
            int idGenerado;

            idGenerado = rand.Next(100000, 1000000);

            return idGenerado;
        }

        /// <summary>
        /// Permite la busqueda de un pasajero en base a su nombre, apellido o dni
        /// </summary>
        /// <param name="pasajeroEncontrados">lista donde se van a cargar los pasajeros que coincidan con los criterios de busqueda</param>
        /// <param name="textoABuscar">nombre, apellido o dni el cual se quiere buscar</param>
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

        /// <summary>
        /// Recorre la lista de vuelos para verificar el estado de los mismos, lo que hace es si el dia actual es mayor al dia del vuelo, 
        /// lo setea en finalizado, y si es igual, en curso.
        /// </summary>
        public static void ChequearEstadoVuelos() {
            if(listaVuelos != null) {
                foreach (Vuelo vuelo in listaVuelos) {
                    if (vuelo.FechaDeVuelo.Date < DateTime.Now.Date) {
                        vuelo.EstadoDelVuelo = EEstadoVuelo.Finalizado;

                        DesprogramarVueloDeAeronave(vuelo.Avion);
                    }
                    else {
                        if(vuelo.FechaDeVuelo.Date ==  DateTime.Now.Date) {
                            vuelo.EstadoDelVuelo = EEstadoVuelo.EnCurso;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Permite desprogramar un vuelo programado de una aeronave
        /// </summary>
        /// <param name="aeronave">Aeronave la cual se le va a desprogramar el vuelo</param>
        private static void DesprogramarVueloDeAeronave(Aeronave aeronave) {
            if(listaAeronaves != null) {
                int i = listaAeronaves.IndexOf(aeronave);
                listaAeronaves[i].VueloProgramado = false;
            }
        }

        /// <summary>
        /// Permite la carga de una lista con las aeronaves disponibles para viajar
        /// </summary>
        /// <param name="aeronavesDisponibles">lista donde se van a cargar las aeronaves disponibles para vuelos</param>
        public static void CargarListaAeronavesDisponibles(List<Aeronave> aeronavesDisponibles) {
            if (listaAeronaves != null) {
                foreach (Aeronave aeronave in listaAeronaves) {
                    if (!aeronave.VueloProgramado) {
                        aeronavesDisponibles.Add(aeronave);
                    }
                }
            }
        }

        /// <summary>
        /// Permite la carga de una lista con los vuelos disponibles para vender
        /// </summary>
        /// <returns>La lista con los vuelos que aun estan en tierra disponibles para vender</returns>
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

        /// <summary>
        /// Permite la carga de los destinos con su correspondiente facturacion en total, lo hago atravez de un diccionario en donde la 
        /// clave es el destino y el valor es la facturacion total
        /// </summary>
        /// <returns>Un diccionario con los destinos y las facturaciones cargadas</returns>
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

        /// <summary>
        /// Ordena los destinos obtenidos en la funcion CargarDestinosConSuFacturacion() de manera descendente y los guarda en un nuevo
        /// diccionario para cargar el valor con el signo $
        /// </summary>
        /// <returns>El diccionario de destinos ordenado descendentemente en base a su facturacion</returns>
        public static Dictionary<string, string> ObtenerDestinosOrdenadosPorSuFacturacion() {
            Dictionary<string, double> destinos = CargarDestinosConSuFacturacion();
            Dictionary<string, double> destinosOrdenados = new Dictionary<string, double>();
            
            destinosOrdenados = destinos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            // me creo otro diccionario pero que sea <string, string> para poder agregarle el signo $ al precio 
            Dictionary<string, string> destinosOrdenadosEnString = new Dictionary<string, string>();

            foreach (KeyValuePair<string, double> item in destinosOrdenados) {
                destinosOrdenadosEnString[item.Key] = $"${item.Value.ToString("0")}";
            }

            return destinosOrdenadosEnString;
        }

        /// <summary>
        /// Permite la carga de un diccionario con los pasajeros y su cantidad de vuelos en total, de la misma manera que antes, aprovechando la clave-valor
        /// </summary>
        /// <returns>Un diccionario con los pasajeros cargados con sus respectiva cantidad de viajes</returns>
        public static Dictionary<string, int> CargarPasajerosConCantidadDeVuelos() {
            Dictionary<string, int> pasajerosConCantidadDeVuelos = new Dictionary<string, int>();

            foreach (Pasajero pasajero in listaPasajeros!) {
                pasajerosConCantidadDeVuelos.Add($"{pasajero}", 0);

                foreach(Vuelo vuelo in listaVuelos!) {
                    if(vuelo.EstadoDelVuelo != EEstadoVuelo.EnTierra) {
                        foreach (Pasaje pasaje in vuelo.ListaPasajes) {
                            if (pasajero == pasaje.Pasajero!) {
                                pasajerosConCantidadDeVuelos[$"{pasajero}"]++;
                            }
                        }
                    }
                }
            }

            return pasajerosConCantidadDeVuelos;
        }

        /// <summary>
        /// Ordena los pasajeros obtenidos en la funcion CargarPasajerosConCantidadDeVuelos() de manera descendente en base a su cantidad de vuelos
        /// </summary>
        /// <returns>Un diccionario con los pasajeros ordenados con su respeciva cantidad de viajes</returns>
        public static Dictionary<string, int> ObtenerPasajerosOrdenadosPorCantidadDeVuelos() {
            Dictionary<string, int> pasajerosConCantidadDeVuelos = CargarPasajerosConCantidadDeVuelos();
            Dictionary<string, int> pasajerosOrdenados = new Dictionary<string, int>();

            pasajerosOrdenados = pasajerosConCantidadDeVuelos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return pasajerosOrdenados;
        }

        /// <summary>
        /// Calcula las ganancias totales de todos los pasajes vendidos de todos los vuelos
        /// </summary>
        /// <returns>Un double con las ganancias totales</returns>
        public static double CalcularGananciasTotales() {
            double gananciasTotales = 0;
            
            foreach(Vuelo vuelo in listaVuelos!) {
                foreach(Pasaje pasaje in vuelo.ListaPasajes) {
                    gananciasTotales += pasaje.CostoPasaje;
                }
            }

            return gananciasTotales;
        }

        /// <summary>
        /// Calcula las ganancias totales de todos los pasajes vendidos en vuelos internacionales
        /// </summary>
        /// <returns>Un double con las ganancias de los vuelos internacionales</returns>
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

        /// <summary>
        /// Calcula las ganancias totales de todos los pasajes vendidos en vuelos nacionales
        /// </summary>
        /// <returns>Un double con las ganancias de los vuelos nacionales</returns>
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

        /// <summary>
        /// Permite la carga de un diccionario con los aviones y sus horas de vuelo en total, luego lo transformo en un diccionario con clave-valor de
        /// tipo <string, string> para agregar el hs. al final de las horas totales para una mejor comprension
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// Recorre todos los destinos que ofrece la empresa, y de acuerdo a la cantidad de pasajes por vuelo que se compraron se van sumando a un 
        /// contador para encontrar el destino mas veces elegido.
        /// </summary>
        /// <returns>el destino mas pedido por los pasajeros</returns>
        public static string BuscarDestinoMasPedido() {
            string destinoMasPedido = "Ninguno"; 
            int contadorDestinoMasPedido = 0;
            bool banderaPrimero = true;
            int contadorActual;

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

            if(contadorDestinoMasPedido == 0) {
                destinoMasPedido = "Ninguno";
            }

            return destinoMasPedido;
        }

        /// <summary>
        /// Escribe un string con formato .csv con todas las estadisticas historicas de la aerolinea para guardarlo en una archivo .csv
        /// </summary>
        /// <param name="destinoMasPedido"></param>
        /// <param name="gananciasTotales"></param>
        /// <param name="gananciasInternacionales"></param>
        /// <param name="gananciasNacionales"></param>
        /// <param name="DestinosOrdenadosPorFacturacion"></param>
        /// <param name="PasajerosOrdenadosPorCantVuelos"></param>
        /// <param name="AvionesConSusHorasDeVuelo"></param>
        /// <returns>El string escrito con formato .csv con todas las estadisticas historicas cargadas</returns>
        public static string EscribirEstadisticasAGuardar(string destinoMasPedido, string gananciasTotales, string gananciasInternacionales,
                                                    string gananciasNacionales, Dictionary<string, string> DestinosOrdenadosPorFacturacion,
                                                    Dictionary<string, int> PasajerosOrdenadosPorCantVuelos, Dictionary<string, string> AvionesConSusHorasDeVuelo) {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Destino mas pedido");
            sb.AppendLine(destinoMasPedido);

            sb.AppendLine("\nGanancias totales");
            sb.AppendLine(gananciasTotales);

            sb.AppendLine("\nGanancias internacionales");
            sb.AppendLine(gananciasInternacionales);

            sb.AppendLine("\nGanancias nacionales");
            sb.AppendLine(gananciasNacionales);

            sb.AppendLine("\nDestinos ordenados por facturacion");
            sb.AppendLine("Destino; Facturacion");

            foreach (KeyValuePair<string, string> item in DestinosOrdenadosPorFacturacion) {
                sb.AppendLine($"{item.Key}; {item.Value}");
            }

            sb.AppendLine("\nPasajeros ordenados por cantidad de vuelos");
            sb.AppendLine("Pasajero; Cantidad de vuelos");

            foreach (KeyValuePair<string, int> item in PasajerosOrdenadosPorCantVuelos) {
                sb.AppendLine($"{item.Key}; {item.Value}");
            }

            sb.AppendLine("\nAviones con sus cantidades de horas de vuelo");
            sb.AppendLine("Avion; Horas de vuelo");

            foreach (KeyValuePair<string, string> item in AvionesConSusHorasDeVuelo) {
                sb.AppendLine($"{item.Key}; {item.Value}");
            }

            return sb.ToString();
        }
    }
}
