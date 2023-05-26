using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;


namespace Entidades {
    public static class Archivos {
        public static List<Usuario>? LeerArchivoJson(List<Usuario>? lista, string rutaJSON) {
            using (StreamReader sr = new StreamReader(rutaJSON)) {
                string json_str = sr.ReadToEnd();

                lista = JsonConvert.DeserializeObject<List<Usuario>>(json_str);
            }
           
            return lista;
        }

        public static List<Aeronave>? LeerArchivoJson(List<Aeronave>? lista, string rutaJSON) {
            if (File.Exists(rutaJSON)) {
                using (StreamReader sr = new StreamReader(rutaJSON)) {
                    string json_str = sr.ReadToEnd();

                    lista = JsonConvert.DeserializeObject<List<Aeronave>>(json_str);
                }
            }

            return lista;
        }

        public static List<Vuelo>? LeerArchivoJson(List<Vuelo>? lista, string rutaJSON) {
            if (File.Exists(rutaJSON)) {
                using (StreamReader sr = new StreamReader(rutaJSON)) {
                    string json_str = sr.ReadToEnd();

                    lista = JsonConvert.DeserializeObject<List<Vuelo>>(json_str);
                }
            }

            return lista;
        }

        public static bool EscribirArchivoJson(List<Usuario>? lista, string rutaJSON) {
            bool guardado = false;

            using (StreamWriter sw = new StreamWriter(rutaJSON)) {
                string json_str = JsonConvert.SerializeObject(lista);

                sw.WriteLine(json_str);
                guardado = true;
            }

            return guardado;
        }

        public static bool EscribirArchivoJson(List<Aeronave>? lista, string rutaJSON) {
            bool guardado = false;

            if(lista != null && lista.Count > 0) {
                using (StreamWriter sw = new StreamWriter(rutaJSON)) {
                    string json_str = JsonConvert.SerializeObject(lista);

                    sw.WriteLine(json_str);
                    guardado = true;
                }
            }

            return guardado;
        }

        public static bool EscribirArchivoJson(List<Vuelo>? lista, string rutaJSON) {
            bool guardado = false;

            using (StreamWriter sw = new StreamWriter(rutaJSON)) {
                string json_str = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented,
                    new JsonSerializerSettings {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                sw.WriteLine(json_str);
                guardado = true;
            }

            return guardado;
        }

        public static List<Pasajero>? LeerArchivoXML(List<Pasajero>? lista, string rutaXML) {
            if (File.Exists(rutaXML)) {
                using (XmlTextReader reader = new XmlTextReader(rutaXML)) {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));

                    lista = (List<Pasajero>?)ser.Deserialize(reader);
                }
            }

            return lista;
        }

        public static bool EscribirArchivoXML(List<Pasajero>? lista, string rutaXML) {
            bool guardado = false;

            if (lista != null && lista.Count > 0) {
                using (XmlTextWriter writer = new XmlTextWriter(rutaXML, Encoding.UTF8)) {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));

                    ser.Serialize(writer, lista);
                    guardado = true;
                }
            }

            return guardado;
        }
        
        public static bool EscribirEstadisticasCsv(string texto, string rutaCsv) {
            bool creado = false;

            using (StreamWriter file = new StreamWriter(rutaCsv, false, Encoding.UTF8)) {
                file.WriteLine(texto);
                file.Close();

                creado = true;
            }

            return creado;
        }

        public static void GuardarConexionDeUsuario(Usuario usuarioConectado, string rutaLog) {
            string registroDeInicio = $"[{DateTime.Now}] El {usuarioConectado.Perfil} {usuarioConectado.Nombre} {usuarioConectado.Apellido} se ha conectado.";
            
            using (StreamWriter sw = new StreamWriter(rutaLog, true)) {
                sw.WriteLine(registroDeInicio); 
            }
        }

        public static void GuardarDesconexionDeUsuario(Usuario usuarioDesconectado, string rutaLog) {
            string registroDeSalida = $"[{DateTime.Now}] El {usuarioDesconectado.Perfil} {usuarioDesconectado.Nombre} {usuarioDesconectado.Apellido} se ha desconectado.";

            using (StreamWriter sw = new StreamWriter(rutaLog, true)) {
                sw.WriteLine(registroDeSalida);
            }
        }
    }
}
