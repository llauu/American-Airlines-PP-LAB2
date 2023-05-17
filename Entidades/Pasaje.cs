using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Pasaje {
        private static int precioHoraVueloNacionalTurista;
        private static int precioHoraVueloInternacionalTurista;

        private int idPasaje;
        private Pasajero? pasajero;
        private ETipoClase clasePasajero;
        private Vuelo? vuelo;
        private bool equipajeDeMano;
        //     numero equipaje, kg de equipaje
        private Dictionary<int, float> equipajesBodega;
        private int numeroDeEquipaje;
        private double costoPasaje;

        static Pasaje() {
            precioHoraVueloNacionalTurista = 50;
            precioHoraVueloInternacionalTurista = 100;
        }

        public Pasaje() {
            this.equipajesBodega = new Dictionary<int, float>();
            this.numeroDeEquipaje = 0;
        }

        private int ObtenerIdPasajeUnico() {
            int idGenerado;

            do {
                idGenerado = Sistema.GenerarIdNumerico();
            } while (Validador.ValidarIdPasajeUnico(this.vuelo!, idGenerado));

            return idGenerado;
        }

        public Pasaje(Pasajero pasajero, bool equipajeDeMano, ETipoClase clasePasajero, Vuelo vuelo) :this() {
            this.pasajero = pasajero;
            this.equipajeDeMano = equipajeDeMano;
            this.clasePasajero = clasePasajero;
            this.vuelo = vuelo;
            this.idPasaje = ObtenerIdPasajeUnico();
            this.costoPasaje = CalcularCostoPasaje(vuelo.DuracionVuelo, vuelo.TipoVuelo, clasePasajero, pasajero);
        }

        public int IdPasaje { get { return this.idPasaje; } set { this.idPasaje = value; } }
        public Pasajero? Pasajero { get { return this.pasajero; } set { this.pasajero = value; } }
        public ETipoClase ClasePasajero { get { return this.clasePasajero; } set { this.clasePasajero = value; } }
        public Vuelo? Vuelo { get { return this.vuelo; } set { this.vuelo = value; } }
        public bool EquipajeDeMano { get { return this.equipajeDeMano; } set { this.equipajeDeMano = value; } }
        public Dictionary<int, float> EquipajesDeBodega { get { return this.equipajesBodega; } }
        public int NumeroDeEquipaje { get { return this.numeroDeEquipaje; } set { this.numeroDeEquipaje = value; } }
        public double CostoPasaje { get { return this.costoPasaje; } set { this.costoPasaje = value; } }

        private double CalcularCostoPasaje(int horasDeVuelo, ETipoVuelo tipoDeVuelo, ETipoClase clasePasajero, Pasajero pasajero) {
            double costo = 0;

            switch(tipoDeVuelo) {
                case ETipoVuelo.Nacional:
                    costo = precioHoraVueloNacionalTurista * horasDeVuelo;
                    break;

                case ETipoVuelo.Internacional:
                    costo = precioHoraVueloInternacionalTurista * horasDeVuelo;
                    break;
            }

            if(pasajero.TieneCodigoDeDescuento()) {
                costo -= (costo * 0.25);
            }

            if(clasePasajero == ETipoClase.Premium) {
                costo += costo * 0.35;
            }

            return costo;
        }

        private bool ChequearPesoDeLaBodega(float kilosAAgregar) {
            bool hayEspacio = false;
            float pesoBodegaAux;

            if (this.vuelo is not null) {
                pesoBodegaAux = this.vuelo.PesoBodegaOcupada + kilosAAgregar;

                if (pesoBodegaAux <= this.vuelo.Avion.CapacidadBodega) {
                    this.numeroDeEquipaje++;
                    this.equipajesBodega.Add(numeroDeEquipaje, kilosAAgregar);
                    this.vuelo.PesoBodegaOcupada = pesoBodegaAux;

                    hayEspacio = true;
                }
                else {
                    throw new Exception("Se supero la capacidad de la bodega, ingrese menos kilos o espere al proximo viaje.");
                }
            }

            return hayEspacio;
        }

        public void CargarEquipajeDeBodega(float kilosDeEquipaje) {
            switch(this.clasePasajero) {
                case ETipoClase.Turista:
                    if(kilosDeEquipaje <= 25 && this.numeroDeEquipaje < 1) {
                        ChequearPesoDeLaBodega(kilosDeEquipaje);
                    }
                    else {
                        throw new Exception("Se supero el peso o el numero de equipajes disponibles.");
                    }

                    break;

                case ETipoClase.Premium:
                    if (kilosDeEquipaje <= 21 && this.numeroDeEquipaje < 2) {
                        ChequearPesoDeLaBodega(kilosDeEquipaje);
                    }
                    else {
                        throw new Exception("Se supero el peso o el numero de equipajes disponibles.");
                    }

                    break;
            }
        }

        public string MostrarEquipajes() {
            StringBuilder sb = new StringBuilder();

            string bolsoDeMano = this.equipajeDeMano ? "Si" : "No";
            sb.AppendLine($"Lleva bolso de mano: {bolsoDeMano}");

            foreach (KeyValuePair<int, float> equipaje in this.equipajesBodega) {
                sb.AppendLine($"Equipaje {equipaje.Key}: { equipaje.Value}kg.");
            }

            return sb.ToString();
        }

        public static bool operator ==(Pasaje p1, Pasaje p2) {
            bool iguales = false;

            if (p1 is not null && p2 is not null) {
                iguales = p1.idPasaje == p2.idPasaje;
            }

            return iguales;
        }

        public static bool operator !=(Pasaje p1, Pasaje p2) {
            return !(p1 == p2);
        }

        public override bool Equals(object? obj) {
            Pasaje? pasaje = obj as Pasaje;
            return pasaje is not null && this == pasaje;
        }

        public override int GetHashCode() {
            return this.idPasaje;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Pasajero: \n{this.pasajero?.Nombre} {this.pasajero?.Apellido}");
            sb.AppendLine($"Clase: {this.clasePasajero}");
            sb.AppendLine($"Equipaje de mano: {this.equipajeDeMano}");

            return sb.ToString();
        }
    }
}
