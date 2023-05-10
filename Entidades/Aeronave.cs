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
        private bool enVuelo;

        private Aeronave() {
            this.matricula = ObtenerMatriculaUnica();
            this.enVuelo = false;
        }

        public Aeronave(int cantAsientos, int cantBanios, bool ofreceInternet, bool ofreceComida, int capacidadBodega) :this() {
            this.cantAsientos = Validador.ValidarNumeroPositivo(cantAsientos);
            this.cantBanios = Validador.ValidarNumeroPositivo(cantBanios);
            this.ofreceInternet = ofreceInternet;
            this.ofreceComida = ofreceComida;
            this.capacidadBodega = Validador.ValidarNumeroPositivo(capacidadBodega);
        }

        public string Matricula { get { return this.matricula; } set { this.matricula = value; } }
        public int CantAsientos { get {  return this.cantAsientos; } set { this.cantAsientos = value; } }
        public int CantBanios { get {  return this.cantBanios; } set { this.cantBanios = value; } }
        public bool OfreceInternet { get { return this.ofreceInternet; } set { this.ofreceInternet = value; } }
        public bool OfreceComida { get { return this.ofreceComida; } set { this.ofreceComida = value; } }
        public int CapacidadBodega { get { return this.capacidadBodega; } set { this.capacidadBodega = value; } }
        public bool EnVuelo { get { return this.enVuelo; } set { this.enVuelo = value; } }


        private string ObtenerMatriculaUnica() {
            string matriculaAlfanumerica;

            do {
                matriculaAlfanumerica = Sistema.GenerarIdAlfanumerico();
            } while (Validador.ValidarMatriculaUnica(matriculaAlfanumerica));

            return matriculaAlfanumerica;
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
