using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Vuelo {
        private static int precioHoraVueloNacionalTurista = 50;
        private static int precioHoraVueloInternacionalTurista = 100;

        private int idVuelo;
        private string? ciudadPartida;
        private string? ciudadDestino;
        private DateTime fechaDeVuelo;
        private Aeronave? avion;
        private EEstadoVuelo estadoDelVuelo;
        private int cantAsientosPremium;
        private int cantAsientosTurista;
        private int duracionVuelo;
        private List<Pasajero> listaPasajeros;

        private Vuelo() {
            this.idVuelo = ObtenerIdVueloUnico();
            this.listaPasajeros = new List<Pasajero>();
            this.estadoDelVuelo = EEstadoVuelo.EnTierra;
        }

        public Vuelo(string ciudadPartida, string ciudadDestino, DateTime fechaDeVuelo, Aeronave avion, int cantAsientos) : this() {
            this.ciudadPartida = ciudadPartida;
            this.ciudadDestino = ciudadDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            CalcularAsientosPremiumYTurista(cantAsientos, out this.cantAsientosPremium, out this.cantAsientosTurista);
        }

        public int IdVuelo { get { return this.idVuelo; } }

        private int ObtenerIdVueloUnico() {
            Random rand = new Random();
            int idGenerado;

            do {
                idGenerado = Sistema.GenerarIdNumerico();                    
            } while (Validador.ValidarIdVueloUnico(idGenerado));
            
            return idGenerado;
        }


        private void CalcularAsientosPremiumYTurista(int cantAsientos, out int cantPremium, out int cantTurista) {
            cantAsientos = Validador.ValidarNumeroPositivo(cantAsientos);

            cantPremium = (int)Math.Floor(cantAsientos / 0.2);
            cantTurista = cantAsientos - cantPremium;
        }
    }
}
