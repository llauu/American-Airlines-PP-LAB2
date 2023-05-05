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

        private Aeronave() {
            this.matricula = GenerarIdAlfanumerico();
        }

        public Aeronave(int cantAsientos, int cantBanios, bool ofreceInternet, bool ofreceComida, int capacidadBodega) :this() {
            this.cantAsientos = Validador.ValidarNumeroPositivo(cantAsientos);
            this.cantBanios = Validador.ValidarNumeroPositivo(cantBanios);
            this.ofreceInternet = ofreceInternet;
            this.ofreceComida = ofreceComida;
            this.capacidadBodega = Validador.ValidarNumeroPositivo(capacidadBodega);
        }

        public string Matricula { get { return this.matricula; } }
        public int CantAsientos { get {  return this.cantAsientos; } set { this.cantAsientos = value; } }
        public int CantBanios { get {  return this.cantBanios; } set { this.cantBanios = value; } }
        public bool OfreceInternet { get { return this.ofreceInternet; } set { this.ofreceInternet = value; } }
        public bool OfreceComida { get { return this.ofreceComida; } set { this.ofreceComida = value; } }
        public int CapacidadBodega { get { return this.capacidadBodega; } set { this.capacidadBodega = value; } }

        private string GenerarIdAlfanumerico() {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] arrayAlfanumerico = new char[8];
            string idAlfanumericoUnico;

            do {
                for (int i = 0; i < arrayAlfanumerico.Length; i++) {
                    arrayAlfanumerico[i] = chars[random.Next(chars.Length)];
                }

                idAlfanumericoUnico = new string(arrayAlfanumerico);
            } while (Validador.ValidarMatriculaUnica(idAlfanumericoUnico));
            
            return idAlfanumericoUnico;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {this.matricula}");
            sb.AppendLine($"Cantidad de asientos: {this.cantAsientos}");
            sb.AppendLine($"Cantidad de baños: {this.cantBanios}");
            sb.AppendLine($"Ofrece internet: {this.ofreceInternet}");
            sb.AppendLine($"Ofrece comida: {this.ofreceComida}");
            sb.AppendLine($"Capacidad de bodega (kg): {this.capacidadBodega}");

            return sb.ToString();
        }
    }
}
