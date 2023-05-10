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
            rutaAvionesJson = @"..\..\..\..\db\aviones.json";
            rutaPasajerosXML = @"..\..\..\..\db\pasajeros.xml";
        }

        public static bool CargarUsuariosJson() {
            bool cargado = false;

            using (StreamReader sr = new StreamReader(rutaUsuariosJson)) {
                string json_str = sr.ReadToEnd();

                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json_str);
                cargado = true;
            }

            return cargado;
        }

        public static bool CargarAvionesJson() {
            bool cargado = false;

            if (File.Exists(rutaAvionesJson)) {
                using (StreamReader sr = new StreamReader(rutaAvionesJson)) {
                    string json_str = sr.ReadToEnd();

                    listaAeronaves = JsonSerializer.Deserialize<List<Aeronave>>(json_str);
                    cargado = true;
                }
            }

            return cargado;
        }

        public static bool GuardarAvionesJson() {
            bool guardado = false;

            using (StreamWriter sw = new StreamWriter(rutaAvionesJson)) {
                string json_str = JsonSerializer.Serialize(listaAeronaves);

                sw.WriteLine(json_str);
                guardado = true;
            }

            return guardado;
        }

        public static bool CargarPasajerosXML() {
            bool cargado = false;

            if (File.Exists(rutaPasajerosXML)) {
                using (XmlTextReader reader = new XmlTextReader(rutaPasajerosXML)) {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));

                    listaPasajeros = (List<Pasajero>)ser.Deserialize(reader);
                }
            }
            
            return cargado;
        }

        public static bool GuardarPasajerosXML() {
            bool cargado = false;

            using (XmlTextWriter writer = new XmlTextWriter(rutaPasajerosXML, Encoding.UTF8)) {
                XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));

                ser.Serialize(writer, listaPasajeros);
            }

            return cargado;
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
    }

}
