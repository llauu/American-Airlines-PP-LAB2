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

        public static List<Usuario>? ListaUsuarios { get { return listaUsuarios; } }

        static Sistema() {
            listaUsuarios = new List<Usuario>();

            rutaUsuariosJson = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            rutaUsuariosJson = Path.Combine(rutaUsuariosJson, @"source\repos\Monserrat.Lautaro.PrimerParcial\db\MOCK_DATA.json");

        }

        public static bool CargarUsuariosJson() {
            bool exito = false;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(rutaUsuariosJson)) {
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
    }
}
