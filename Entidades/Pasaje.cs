using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Pasaje {
        private Pasajero? pasajero;
        private Vuelo? vuelo;
        private ETipoClase clasePasajero;
        private bool equipajeDeMano;
        //     numero equipaje, kg de equipaje
        private Dictionary<int, int> equipajesBodega;

        private Pasaje() {
            this.equipajesBodega = new Dictionary<int, int>();
        }

        public Pasaje(Pasajero pasajero, bool equipajeDeMano, ETipoClase clasePasajero) :this() {
            this.pasajero = pasajero;
            this.equipajeDeMano = equipajeDeMano;
            this.clasePasajero = clasePasajero;
        }

        public Dictionary<int, int> EquipajesDeBodega { get { return this.equipajesBodega; } }
        public bool EquipajeDeMano { get { return this.equipajeDeMano; } set { this.equipajeDeMano = value; } }
    }
}
