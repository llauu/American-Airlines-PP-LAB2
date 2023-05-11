using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades {
    public static class Archivos {
        public static List<Usuario>? LeerArchivoJson(List<Usuario>? lista, string rutaJSON) {
            using (StreamReader sr = new StreamReader(rutaJSON)) {
                string json_str = sr.ReadToEnd();

                lista = JsonSerializer.Deserialize<List<Usuario>>(json_str);
            }
           
            return lista;
        }

        public static List<Aeronave>? LeerArchivoJson(List<Aeronave>? lista, string rutaJSON) {
            if (File.Exists(rutaJSON)) {
                using (StreamReader sr = new StreamReader(rutaJSON)) {
                    string json_str = sr.ReadToEnd();

                    lista = JsonSerializer.Deserialize<List<Aeronave>>(json_str);
                }
            }

            return lista;
        }

        public static bool EscribirArchivoJson(List<Usuario>? lista, string rutaJSON) {
            bool guardado = false;

            using (StreamWriter sw = new StreamWriter(rutaJSON)) {
                string json_str = JsonSerializer.Serialize(lista);

                sw.WriteLine(json_str);
                guardado = true;
            }

            return guardado;
        }

        public static bool EscribirArchivoJson(List<Aeronave>? lista, string rutaJSON) {
            bool guardado = false;

            using (StreamWriter sw = new StreamWriter(rutaJSON)) {
                string json_str = JsonSerializer.Serialize(lista);

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

        public static List<Vuelo>? LeerArchivoXML(List<Vuelo>? lista, string rutaXML) {
            if (File.Exists(rutaXML)) {
                using (XmlTextReader reader = new XmlTextReader(rutaXML)) {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Vuelo>));

                    lista = (List<Vuelo>?)ser.Deserialize(reader);
                }
            }

            return lista;
        }

        public static bool EscribirArchivoXML(List<Pasajero>? lista, string rutaXML) {
            bool guardado = false;

            using (XmlTextWriter writer = new XmlTextWriter(rutaXML, Encoding.UTF8)) {
                XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));

                ser.Serialize(writer, lista);
                guardado = true;
            }

            return guardado;
        }

        public static bool EscribirArchivoXML(List<Vuelo>? lista, string rutaXML) {
            bool guardado = false;

            using (XmlTextWriter writer = new XmlTextWriter(rutaXML, Encoding.UTF8)) {
                XmlSerializer ser = new XmlSerializer(typeof(List<Vuelo>));

                ser.Serialize(writer, lista);
                guardado = true;
            }

            return guardado;
        }
    }
}
