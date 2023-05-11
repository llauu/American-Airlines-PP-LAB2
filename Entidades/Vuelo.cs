using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Vuelo {
        private static int precioHoraVueloNacionalTurista = 50;
        private static int precioHoraVueloInternacionalTurista = 100;
        private static List<string> destinosInternacionales;

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
        private ETipoVuelo tipoVuelo;

        static Vuelo() {
            destinosInternacionales = new List<string>() {
                "Recife (Brasil)",
                "Roma (Italia)",
                "Acapulco (México)",
                "Miami (EE.UU.)"
            };
        }

        private Vuelo() {
            this.idVuelo = ObtenerIdVueloUnico();
            this.listaPasajeros = new List<Pasajero>();
            this.estadoDelVuelo = EEstadoVuelo.EnTierra;
        }

        public Vuelo(string ciudadPartida, string ciudadDestino, DateTime fechaDeVuelo, Aeronave avion) : this() {
            Validador.ValidarCiudades(ciudadPartida, ciudadDestino);
            this.ciudadPartida = ciudadPartida;
            this.ciudadDestino = ciudadDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.cantAsientosPremium = CalcularAsientosPremium(avion.CantAsientos);
            this.cantAsientosTurista = avion.CantAsientos - this.cantAsientosPremium;
            this.tipoVuelo = ObtenerTipoDeVuelo(ciudadPartida, ciudadDestino);
            Validador.ValidarInternacional(ciudadPartida, ciudadDestino, this.tipoVuelo);
            this.duracionVuelo = CalcularDuracionDeVuelo(this.tipoVuelo);
        }

        public int IdVuelo { get { return this.idVuelo; } }
        public string CiudadPartida { get { return this.ciudadPartida!; } set { this.ciudadPartida = value; } }
        public string CiudadDestino { get { return this.ciudadDestino!; } set { this.ciudadDestino = value; } }
        public DateTime FechaDeVuelo { get { return this.fechaDeVuelo!; } set { this.fechaDeVuelo = value; } }
        public Aeronave Avion { get { return this.avion!; } set { this.avion = value; } }
        public EEstadoVuelo EstadoDelVuelo { get { return this.estadoDelVuelo; } set { this.estadoDelVuelo = value; } }
        public int CantAsientosPremium { get { return this.cantAsientosPremium; } set { this.cantAsientosPremium = value; } }
        public int CantAsientosTurista { get { return this.cantAsientosTurista; } set { this.cantAsientosTurista = value; } }
        public int DuracionVuelo { get { return this.duracionVuelo; } set { this.duracionVuelo = value; } }
        public List<Pasajero> ListaPasajeros { get { return this.listaPasajeros; } set { this.listaPasajeros = value; } }
        public ETipoVuelo TipoVuelo { get { return this.tipoVuelo; } set { this.tipoVuelo = value; } }


        private int ObtenerIdVueloUnico() {
            Random rand = new Random();
            int idGenerado;

            do {
                idGenerado = Sistema.GenerarIdNumerico();                    
            } while (Validador.ValidarIdVueloUnico(idGenerado));
            
            return idGenerado;
        }


        private int CalcularAsientosPremium(int cantAsientos) {
            int cantPremium;

            cantAsientos = Validador.ValidarNumeroPositivo(cantAsientos);
            cantPremium = (int)Math.Floor(cantAsientos * 0.2);

            return cantPremium;
        }


        private ETipoVuelo ObtenerTipoDeVuelo(string partida, string destino) {
            ETipoVuelo tipoVuelo = ETipoVuelo.Nacional;

            foreach(string destinoAux in destinosInternacionales) {
                if(partida == destinoAux || destino == destinoAux) {
                    tipoVuelo = ETipoVuelo.Internacional;
                    break;
                }
            }

            return tipoVuelo;
        }

        private int CalcularDuracionDeVuelo(ETipoVuelo tipoVuelo) {
            Random rand = new Random();
            int duracionDelVuelo;

            //si tipoVuelo == ETipoVuelo.Internacional
            duracionDelVuelo = rand.Next(8, 13);

            if (tipoVuelo == ETipoVuelo.Nacional) {
                duracionDelVuelo = rand.Next(2, 5);
            }

            return duracionDelVuelo;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {this.idVuelo}");
            sb.AppendLine($"Ciudad de partida: {this.ciudadPartida}");
            sb.AppendLine($"Ciudad de destino: {this.ciudadDestino}");
            sb.AppendLine($"Fecha del vuelo: {this.fechaDeVuelo}");
            sb.AppendLine($"Asientos premium: {this.cantAsientosPremium}");
            sb.AppendLine($"Asientos turista: {this.cantAsientosTurista}");
            sb.AppendLine($"Duracion del vuelo: {this.duracionVuelo}hs"); 

            return sb.ToString();
        }
    }
}
