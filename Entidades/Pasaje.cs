using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Pasaje {
        private int idPasaje;
        private Pasajero? pasajero;
        private ETipoClase clasePasajero;
        private Vuelo? vuelo;
        private bool equipajeDeMano;
        //     numero equipaje, kg de equipaje
        private Dictionary<int, int> equipajesBodega;
        private int numeroDeEquipaje;

        public Pasaje() {
            this.equipajesBodega = new Dictionary<int, int>();
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
        }

        public int IdPasaje { get { return this.idPasaje; } set { this.idPasaje = value; } }
        public Pasajero? Pasajero { get { return this.pasajero; } set { this.pasajero = value; } }
        public ETipoClase ClasePasajero { get { return this.clasePasajero; } set { this.clasePasajero = value; } }
        public Vuelo? Vuelo { get { return this.vuelo; } set { this.vuelo = value; } }
        public bool EquipajeDeMano { get { return this.equipajeDeMano; } set { this.equipajeDeMano = value; } }
        public Dictionary<int, int> EquipajesDeBodega { get { return this.equipajesBodega; } }
        public int NumeroDeEquipaje { get { return this.numeroDeEquipaje; } set { this.numeroDeEquipaje = value; } }

        public void CargarEquipajeDeBodega(int kilosDeEquipaje) {
            switch(this.clasePasajero) {
                case ETipoClase.Turista:
                    if(kilosDeEquipaje <= 25 && this.numeroDeEquipaje < 1) {
                        this.numeroDeEquipaje++;
                        this.equipajesBodega.Add(numeroDeEquipaje, kilosDeEquipaje);
                    }
                    else {
                        throw new Exception("Se supero el peso o el numero de equipajes disponibles.");
                    }

                    break;

                case ETipoClase.Premium:
                    if (kilosDeEquipaje <= 21 && this.numeroDeEquipaje < 2) {
                        this.numeroDeEquipaje++;
                        this.equipajesBodega.Add(numeroDeEquipaje, kilosDeEquipaje);
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

            foreach (KeyValuePair<int, int> equipaje in this.equipajesBodega) {
                sb.AppendLine($"Equipaje {equipaje.Key}: { equipaje.Value}kg.");
            }

            return sb.ToString();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Pasajero: \n{this.pasajero?.Nombre} {this.pasajero?.Apellido}");
            sb.AppendLine($"Clase: {this.clasePasajero}");
            sb.AppendLine($"Equipaje de mano: {this.equipajeDeMano}");
            sb.AppendLine($"Equipajes en bodega: {this.equipajesBodega}");

            return sb.ToString();
        }
    }
}
