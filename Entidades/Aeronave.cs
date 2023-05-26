using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Aeronave {
        private string matricula;
        private int cantAsientos;
        private int cantAsientosPremium;
        private int cantAsientosTurista;
        private int cantBanios;
        private bool ofreceInternet;
        private bool ofreceComida;
        private float capacidadBodega;
        private bool vueloProgramado;

        private Aeronave() {
            this.matricula = ObtenerMatriculaUnica();
            this.vueloProgramado = false;
        }

        public Aeronave(int cantAsientos, int cantBanios, bool ofreceInternet, bool ofreceComida, float capacidadBodega) :this() {
            this.capacidadBodega = Validador.ValidarFlotantePositivo(capacidadBodega);
            this.cantAsientos = Validador.ValidarNumeroPositivo(cantAsientos);
            this.cantBanios = Validador.ValidarNumeroPositivo(cantBanios);
            this.cantAsientosPremium = CalcularAsientosPremium(CantAsientos);
            this.cantAsientosTurista = cantAsientos - this.cantAsientosPremium;
            this.ofreceInternet = ofreceInternet;
            this.ofreceComida = ofreceComida;
        }

        public string Matricula { get { return this.matricula; } set { this.matricula = value; } }
        public int CantAsientos { get {  return this.cantAsientos; } set { this.cantAsientos = value; } }
        public int CantAsientosPremium { get { return this.cantAsientosPremium; } set { this.cantAsientosPremium = value; } }
        public int CantAsientosTurista { get { return this.cantAsientosTurista; } set { this.cantAsientosTurista = value; } }
        public int CantBanios { get {  return this.cantBanios; } set { this.cantBanios = value; } }
        public bool OfreceInternet { get { return this.ofreceInternet; } set { this.ofreceInternet = value; } }
        public bool OfreceComida { get { return this.ofreceComida; } set { this.ofreceComida = value; } }
        public float CapacidadBodega { get { return this.capacidadBodega; } set { this.capacidadBodega = value; } }
        public bool VueloProgramado { get { return this.vueloProgramado; } set { this.vueloProgramado = value; } }

        private int CalcularAsientosPremium(int cantAsientos) {
            int cantPremium;

            cantAsientos = Validador.ValidarNumeroPositivo(cantAsientos);
            cantPremium = (int)Math.Floor(cantAsientos * 0.2);

            return cantPremium;
        }

        private string ObtenerMatriculaUnica() {
            string matriculaAlfanumerica;

            do {
                matriculaAlfanumerica = Sistema.GenerarIdAlfanumerico();
            } while (Validador.ValidarMatriculaUnica(matriculaAlfanumerica));

            return matriculaAlfanumerica;
        }


        public static bool operator ==(Aeronave a1, Aeronave a2) {
            bool iguales = false;

            if (a1 is not null && a2 is not null) {
                iguales = a1.matricula == a2.matricula;
            }

            return iguales;
        }

        public static bool operator !=(Aeronave a1, Aeronave a2) {
            return !(a1 == a2);
        }

        public override bool Equals(object? obj) {
            Aeronave? aeronave = obj as Aeronave;
            return aeronave is not null && this == aeronave;
        }

        public override int GetHashCode() {
            return (this.matricula).GetHashCode();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            string ofreceInternet = this.ofreceInternet ? "Si" : "No";
            string ofreceComida = this.ofreceComida ? "Si" : "No";

            sb.AppendLine($"Matricula: {this.matricula}");
            sb.AppendLine($"Asientos para clase turista: {this.cantAsientosTurista}");
            sb.AppendLine($"Asientos para clase premium: {this.cantAsientosPremium}");
            sb.AppendLine($"Cantidad de baños: {this.cantBanios}");
            sb.AppendLine($"Ofrece internet: {ofreceInternet}");
            sb.AppendLine($"Ofrece comida: {ofreceComida}");
            sb.AppendLine($"Capacidad de bodega: {this.capacidadBodega}kg");

            return sb.ToString();
        }
    }
}
