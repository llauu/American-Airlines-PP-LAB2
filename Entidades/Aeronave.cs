using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Aeronave {
        private string matricula;
        private int cantAsientos;
        private int cantBanios;
        private bool ofreceInternet;
        private bool ofreceComida;
        private int capacidadBodega;

        public Aeronave(int cantAsientos, int cantBanios, bool ofreceInternet, bool ofreceComida, int capacidadBodega) {
            this.matricula = GenerarIdAlfanumerico();
            this.cantAsientos = Validador.ValidarNumeroPositivo(cantAsientos);
            this.cantBanios = Validador.ValidarNumeroPositivo(cantBanios);
            this.ofreceInternet = ofreceInternet;
            this.ofreceComida = ofreceComida;
            this.capacidadBodega = Validador.ValidarNumeroPositivo(capacidadBodega);
        }

        public string Matricula { get { return this.matricula; } }
        public int CantAsientos { get {  return cantAsientos; } set { this.cantAsientos = value; } }
        public int CantBanios { get {  return cantBanios; } set {  cantBanios = value; } }
        public bool OfreceInternet { get { return ofreceInternet; } set { ofreceInternet = value; } }
        public bool OfreceComida { get { return ofreceComida; } set { ofreceComida = value; } }
        public int CapacidadBodega { get { return capacidadBodega; } set { capacidadBodega = value; } }

        private string GenerarIdAlfanumerico() {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            char[] arrayAlfanumerico = new char[8];

            for (int i = 0; i < arrayAlfanumerico.Length; i++) {
                arrayAlfanumerico[i] = chars[random.Next(chars.Length)];
            }

            return new string(arrayAlfanumerico);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.matricula}");
            sb.AppendLine($"Cantidad asientos: {this.cantAsientos}");
            sb.AppendLine($"Cantidad banios: {this.cantBanios}");
            sb.AppendLine($"Ofrece internet: {this.ofreceInternet}");
            sb.AppendLine($"Ofrece comida: {this.ofreceComida}");
            sb.AppendLine($"Capacidad bodega: {this.capacidadBodega}");

            return sb.ToString();
        }
    }
}
