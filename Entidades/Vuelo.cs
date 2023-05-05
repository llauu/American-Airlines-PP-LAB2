using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Vuelo {
        private const int precioHoraVueloNacionalTurista = 50;
        private const int precioHoraVueloInternacionalTurista = 100;

        private int idVuelo;
        private string? ciudadPartida;
        private string? ciudadDestino;
        private DateTime fechaDeVuelo;
        private Aeronave? avion;
        private int cantAsientosPremium;
        private int cantAsientosTurista;
        private int duracionVuelo;
        private List<Pasajero> listaPasajeros;

        private Vuelo() {
            this.idVuelo = GenerarIdVuelo();
            this.listaPasajeros = new List<Pasajero>();
        }

        public Vuelo(string ciudadPartida, string ciudadDestino, DateTime fechaDeVuelo, Aeronave avion, int cantAsientosPremium, int cantAsientosTurista, int duracionVuelo) :this() {
            this.ciudadPartida = ciudadPartida;
            this.ciudadDestino = ciudadDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.cantAsientosPremium = cantAsientosPremium;
            this.cantAsientosTurista = cantAsientosTurista;
            this.duracionVuelo = duracionVuelo;
        }

        private int GenerarIdVuelo() {
            Random rand = new Random();
            int idGenerado;
            bool idRepetido = false;

            do {
                idGenerado = rand.Next(100000, 1000000);

                if (Sistema.ListaVuelos != null) {
                    foreach (Vuelo vuelo in Sistema.ListaVuelos) {
                        if (vuelo.idVuelo == idGenerado) {
                            idRepetido = true;
                            break;
                        }
                    }
                }                    
            } while (idRepetido);
            
            return idGenerado;
        }



    }
}
